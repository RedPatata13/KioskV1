Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports System.Web.ModelBinding
Imports KioskV0.KioskV0.Classes
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class AdminEditMenuDetailsViewModel
        Inherits ViewModel(Of Forms.AdminEditMenuDetailsView, AdminKeys)
        Private Property Loaded As Boolean = False
        Public Sub New(view As Forms.AdminEditMenuDetailsView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            SetEvents()
        End Sub
        Public Sub LoadAsEdit(model As Menu)
            model.Validate()
            _view.Label = "Edit Menu"
            _view.DeleteButton.Visible = True
            _mediator.LayoutAction(Sub()
                                       _mediator.AddAction(Sub() LoadWithDetails(model))
                                       _mediator.AddAction(Sub() _mediator.SwapPage(AdminKeys.AdminEditMenuDetails))
                                       _mediator.InvokeAllAction()
                                   End Sub)
            _view.DeleteButtonClick = Sub() DeleteMenu(model)
            _view.SaveButtonClick = Sub() UpdateMenu(model)
        End Sub
        Public Overrides Sub Project(projector As Form)
            If Not Loaded Then
                ResizeComponents(_mediator.GetProjectorPanelSize())
            End If
            Loaded = True
            MyBase.Project(projector)
        End Sub
        Private Sub RestoreView()
            _view.ResetFields()
            _view.DeleteButton.Visible = False
            _view.Label = "Add Menu"
            _view.SaveButtonClick = AddressOf SaveButtonClick
        End Sub
        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()
            Previous = AdminKeys.AdminLandingPage
            _view.CancelButtonClick = AddressOf CancelButtonClick
            _view.SelectImageClick = AddressOf SelectImageClick
            _view.SaveButtonClick = AddressOf SaveButtonClick
        End Sub
        Private Sub DeleteMenu(model As Menu)
            '_mediator.DeleteMenu(model)
            _mediator.AddAction(Sub() _mediator.SwapPage(Previous))
            _mediator.AddAction(Sub() _mediator.DeleteMenu(model))
            _mediator.AddAction(Sub() RestoreView())
            '_mediator.AddAction(Sub() MessageBox.Show("Menu Deleted"))
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminMenu), AdminMenuViewModel)
            _mediator.AddAction(Sub() vm.DeleteStaged())
            _mediator.InvokeAllAction()
        End Sub
        Private Sub CancelButtonClick()
            _mediator.AddAction(Sub() _mediator.SwapPage(Previous))
            _mediator.AddAction(Sub() RestoreView())
            _mediator.InvokeAllAction()
        End Sub

        Private Sub SaveButtonClick()
            Try
                Dim model = New Menu()
                model.MenuName = _view.MenuName
                model.Category = _view.CategoryName
                model.Supplier = _view.SupplierName
                model.ProductDescription = _view.ProductDescription
                Dim cost As Decimal
                Dim selling As Decimal

                If Not Decimal.TryParse(_view.Cost, cost) Then
                    Throw New FormatException("Invalid format for Cost.")
                End If
                If Not Decimal.TryParse(_view.Sell, selling) Then
                    Throw New FormatException("Invalid format for Selling price.")
                End If

                model.Cost = cost
                model.Selling = selling

                model.Validate()
                Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminMenu), AdminMenuViewModel)
                vm.AddNewMenu(model)
                _mediator.CreateMenu(model)
                _mediator.SwapPage(Previous)
                RestoreView()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Sub
        Private Sub UpdateMenu(model As Menu)
            Try
                Dim newModel = New Menu()
                newModel.MenuId = model.MenuId
                newModel.MenuName = _view.MenuName
                newModel.Category = _view.CategoryName
                newModel.Supplier = _view.SupplierName
                newModel.ProductDescription = _view.ProductDescription
                newModel.ProductImagePath = ""
                Dim cost As Decimal
                Dim selling As Decimal

                If Not Decimal.TryParse(_view.Cost, cost) Then
                    Throw New FormatException("Invalid format for Cost.")
                End If
                If Not Decimal.TryParse(_view.Sell, selling) Then
                    Throw New FormatException("Invalid format for Selling price.")
                End If

                newModel.Cost = cost
                newModel.Selling = selling

                'newModel.Validate()
                Dim res = _mediator.GetUnitOfWork.Menus.GetById(newModel.MenuId)
                _mediator.UpdateMenu(newModel)
                _mediator.SwapPage(Previous)

                Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminMenu), AdminMenuViewModel)
                vm.UpdateStaged(newModel)
                RestoreView()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                'Throw New Exception("Yep here")
            End Try

        End Sub

        Private Sub LoadWithDetails(model As Menu)
            model.Validate()
            'MessageBox.Show($"{model.MenuId}")
            _view.MenuName = model.MenuName
            _view.CategoryName = model.Category
            _view.SupplierName = model.Supplier
            _view.ProductDescription = model.ProductDescription
            _view.Cost = $"{model.Cost}"
            _view.Sell = $"{model.Selling}"
        End Sub

        Private Sub DefaultLoad()
            _view.ResetFields()
        End Sub

        Private Sub SelectImageClick()
            Dim openFileDialog As New OpenFileDialog()

            ' Set filter to show only supported image file types (jpg, png, bmp, gif)
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*"
            openFileDialog.Title = "Select an Image File"

            ' Show the dialog and check if the user selected a file
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Get the file path
                Dim selectedFilePath As String = openFileDialog.FileName

                ' Optionally, set the selected image to a PictureBox (if you want to preview it)
                _view.Thumbnail.SizeMode = PictureBoxSizeMode.Zoom

                _view.Thumbnail.Image = Image.FromFile(selectedFilePath)

                ' Display the selected file path (for example, in a TextBox or MessageBox)
                MessageBox.Show("Selected file: " & selectedFilePath)
            End If
        End Sub
    End Class
End Namespace