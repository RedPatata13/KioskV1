Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports Autofac
Imports KioskV0.Classes
Imports KioskV0.KioskV0.Classes
Imports KioskV0.KioskV0.Model
Imports KioskV0.KioskV0.Services
Imports Microsoft.VisualBasic.ApplicationServices

Namespace KioskV0.Classes
    Public Class AdminEditMenuDetailsViewModel
        Inherits ViewModel(Of Forms.AdminEditMenuDetailsView, AdminKeys)
        Private ReadOnly _menu As Menu
        Public ReadOnly Property Menu As Menu
            Get
                Return _menu
            End Get
        End Property
        Private Property ImagePath As String
        Public Sub New(view As Forms.AdminEditMenuDetailsView,
                       mediator As Mediator(Of AdminKeys),
                       menu As Menu)
            MyBase.New(view, mediator)
            _menu = menu
            SetEvents()
        End Sub
        Private Sub MapViewToUser()
            _menu.MenuName = _view.MenuName
            _menu.ProductDescription = _view.ProductDescription
            _menu.Cost = _view.Cost
            _menu.Selling = _view.Sell
            _menu.Supplier = _view.SupplierName
            _menu.Category = _view.CategoryComboBox.Text
            _menu.ProductImagePath = ImagePath
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
        'Public Sub LoadAsDelete(model As MenuModel)
        '    model.ValidateOrGetErrors()
        '    _view.Label = ""
        'End Sub
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

            Dim container As IContainer = ContainerConfiguration.ConfigureContainer()
            Dim adminService = container.Resolve(Of AdminService)()

            _mediator.AddAction(Sub() adminService.DeleteMenu(model))
            _mediator.AddAction(Sub() RestoreView())
            '_mediator.AddAction(Sub() MessageBox.Show("Menu Deleted"))
            _mediator.InvokeAllAction()
        End Sub
        Private Sub CancelButtonClick()
            _mediator.AddAction(Sub() _mediator.SwapPage(Previous))
            _mediator.AddAction(Sub() RestoreView())
            _mediator.InvokeAllAction()
        End Sub

        Private Sub SelectImageClick()
            Using openFileDialog As New OpenFileDialog()
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
                openFileDialog.Title = "Select an Image"

                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim selectedFilePath As String = openFileDialog.FileName
                    _view.SelectedImagePath = selectedFilePath
                    ImagePath = selectedFilePath
                    MessageBox.Show("Selected File: " & selectedFilePath, "File Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End Sub
        Private Sub SaveButtonClick()
            MapViewToUser()

            Dim container As IContainer = ContainerConfiguration.ConfigureContainer()
            Dim adminService = container.Resolve(Of AdminService)()

            adminService.AddMenu(_menu)
            _mediator.SwapPage(Previous)
            RestoreView()
        End Sub

        Private Sub UpdateMenu(model As Menu)
            Try
                Dim newModel = New Menu()
                newModel.MenuId = model.MenuId
                newModel.MenuName = _view.MenuName
                newModel.Category = _view.CategoryName
                newModel.Supplier = _view.SupplierName
                newModel.ProductDescription = _view.ProductDescription
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

                newModel.Validate()

                _mediator.UpdateMenu(newModel.MenuId, newModel)
                _mediator.SwapPage(Previous)
                RestoreView()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try

        End Sub

        Private Sub LoadWithDetails(model As Menu)
            model.Validate()
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
    End Class
End Namespace