Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports System.Web.ModelBinding
Imports KioskV0.KioskV0.Classes
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class AdminEditMenuDetailsViewModel
        Inherits ViewModel(Of Forms.AdminEditMenuDetailsView, AdminKeys)
        Public Property LoadedBatch As InventoryBatch = Nothing
        Private Property Loaded As Boolean = False
        Private Property CategoryCache As New Dictionary(Of String, Category)
        Private Property SupplierCache As New Dictionary(Of String, SupplierItem)
        Private Property selectedFilePath As String
        Public Sub New(view As Forms.AdminEditMenuDetailsView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            SetEvents()
            SetCache()
            SetComboBoxes()
        End Sub
        Public Sub LoadAsEdit(model As AdminItem)
            'model.Validate()
            _view.Label = "Edit Menu"
            _view.DeleteButton.Visible = True
            _mediator.LayoutAction(Sub()
                                       _mediator.AddAction(Sub() LoadWithDetails(model))
                                       _mediator.AddAction(Sub() _mediator.SwapPage(AdminKeys.AdminEditMenuDetails))
                                       _mediator.InvokeAllAction()
                                   End Sub)
            '_view.DeleteButtonClick = Sub() DeleteMenu(model)
            _view.SaveButtonClick = Sub() UpdateMenu(model)
        End Sub
        Public Overrides Sub Project(projector As Form)
            If Not Loaded Then
                MyBase.Project(projector)
                ResizeComponents(_mediator.GetProjectorPanelSize())
            End If
            Loaded = True
            MyBase.Project(projector)
        End Sub
        Public Sub SetLoadedBatch()
            If LoadedBatch IsNot Nothing Then
                _view.BoundItem.Text = LoadedBatch.SupplierItem.Name
            End If

            _mediator.SwapPage(AdminKeys.AdminEditMenuDetails)
        End Sub
        Private Sub RestoreView()
            _view.ResetFields()
            _view.DeleteButton.Visible = False
            _view.Label = "Add Menu"
            _view.SaveButtonClick = AddressOf SaveButtonClick
            LoadedBatch = Nothing
        End Sub
        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()
            Previous = AdminKeys.AdminLandingPage
            _view.CancelButtonClick = AddressOf CancelButtonClick
            _view.SelectImageClick = AddressOf SelectImageClick
            _view.SaveButtonClick = AddressOf SaveButtonClick
            _view.SelectSupplierClick = AddressOf SelectSupplierClick
        End Sub

        Private Sub SelectSupplierClick()
            _mediator.SwapPage(AdminKeys.AdminMenuSelectSupplierItem)
        End Sub
        Private Sub SetCache()
            Dim categoryList As List(Of Category) = _mediator.GetUnitOfWork.Categories.GetAll()
            Dim supplierList As List(Of SupplierItem) = _mediator.GetUnitOfWork.SupplierItems.GetAll()

            For Each cl In categoryList
                CategoryCache.Add(cl.CategoryId, cl)
            Next

            For Each sl In supplierList
                SupplierCache.Add(sl.Id, sl)
            Next
        End Sub
        Private Sub SetComboBoxes()
            Dim catNameList As List(Of String) = CategoryCache.Select(Function(cl) cl.Value.CategoryName).ToList()
            Dim suppNameList As List(Of String) = SupplierCache.Select(Function(sl) sl.Value.Name).ToList()

            _view.CategoryComboBox.Items.Clear()
            _view.CategoryComboBox.Items.AddRange(catNameList.ToArray())

            _view.SupplierComboBox.Items.Clear()
            _view.SupplierComboBox.Items.AddRange(suppNameList.ToArray())
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
                Dim category As Category = Nothing
                Dim supplier As SupplierItem = Nothing
                For Each kv In CategoryCache
                    If kv.Value.CategoryName = _view.CategoryName Then
                        category = kv.Value
                    End If
                Next
                If category Is Nothing Then Throw New Exception("category not found")

                For Each kv In SupplierCache
                    If kv.Value.Name = _view.SupplierName Then
                        supplier = kv.Value
                    End If
                Next
                If supplier Is Nothing Then Throw New Exception("supplier item not found")

                Dim context = DirectCast(_mediator.GetUnitOfWork(), UnitOfWork)._context
                If LoadedBatch Is Nothing Then
                    Throw New Exception("LoadedBatch Is null")
                End If
                context.InventoryBatches.Attach(LoadedBatch)

                If context Is Nothing Then
                    Throw New Exception("Context doot")
                End If
                Dim local_cat_cpy = context.Categories.Local.FirstOrDefault(Function(c) c.CategoryId = category.CategoryId)
                Dim local_suppI_cpy = context.SupplierItems.Local.FirstOrDefault(Function(si) si.Id = supplier.Id)
                If local_cat_cpy Is Nothing Then
                    local_cat_cpy = context.Categories.Find(category.CategoryId)
                    If local_cat_cpy Is Nothing Then
                        Throw New Exception("Category not found in DB")
                    End If
                End If
                If local_suppI_cpy Is Nothing Then
                    local_suppI_cpy = context.SupplierItems.Find(supplier.Id)
                    If local_cat_cpy Is Nothing Then
                        Throw New Exception("Supplier not found in DB.")
                    End If
                End If

                Dim model = New AdminItem()
                model.Id = "AdminItem_" & Guid.NewGuid().ToString().Substring(0, 10)
                model.Name = _view.MenuName
                model.Category = local_cat_cpy
                model.SupplierItem = local_suppI_cpy
                model.Description = _view.ProductDescription
                model.Batch = LoadedBatch
                Dim cost As Decimal
                Dim selling As Decimal

                If Not Decimal.TryParse(_view.Cost, cost) Then
                    Throw New FormatException("Invalid format for Cost.")
                End If
                If Not Decimal.TryParse(_view.Sell, selling) Then
                    Throw New FormatException("Invalid format for Selling price.")
                End If

                model.SellingCost = cost
                'model.Selling = selling

                'model.Validate()
                Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminMenu), AdminMenuViewModel)
                vm.AddNewMenu(model)
                _mediator.CreateMenu(model)
                _mediator.SwapPage(Previous)
                _mediator.GetUnitOfWork().SaveChanges()
                RestoreView()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Sub
        Private Sub UpdateMenu(model As AdminItem)
            Try
                'Dim newModel = New AdminItem()

                'newModel.MenuName = _view.MenuName
                'newModel.Category = _view.CategoryName
                'newModel.Supplier = _view.SupplierName
                'newModel.ProductDescription = _view.ProductDescription
                'newModel.ProductImagePath = ""
                'Dim cost As Decimal
                'Dim selling As Decimal

                'If Not Decimal.TryParse(_view.Cost, cost) Then
                '    Throw New FormatException("Invalid format for Cost.")
                'End If
                'If Not Decimal.TryParse(_view.Sell, selling) Then
                '    Throw New FormatException("Invalid format for Selling price.")
                'End If

                'newModel.Cost = cost
                'newModel.Selling = selling

                ''newModel.Validate()
                'Dim res = _mediator.GetUnitOfWork.Menus.GetById(newModel.MenuId)
                '_mediator.UpdateMenu(newModel)
                '_mediator.SwapPage(Previous)

                'Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminMenu), AdminMenuViewModel)
                'vm.UpdateStaged(model)
                Dim category As Category = Nothing
                Dim supplier As SupplierItem = Nothing
                'Dim model As AdminItem = Nothing
                For Each kv In CategoryCache
                    If kv.Value.CategoryName = _view.CategoryName Then
                        category = kv.Value
                    End If
                Next
                If category Is Nothing Then Throw New Exception("category not found")

                For Each kv In SupplierCache
                    If kv.Value.Name = _view.SupplierName Then
                        supplier = kv.Value
                    End If
                Next
                If supplier Is Nothing Then Throw New Exception("supplier item not found")

                Dim context = DirectCast(_mediator.GetUnitOfWork(), UnitOfWork)._context
                If context Is Nothing Then
                    Throw New Exception("Context doot")
                End If
                Dim local_cat_cpy = context.Categories.Local.FirstOrDefault(Function(c) c.CategoryId = category.CategoryId)
                Dim local_suppI_cpy = context.SupplierItems.Local.FirstOrDefault(Function(si) si.Id = supplier.Id)
                If local_cat_cpy Is Nothing Then
                    local_cat_cpy = context.Categories.Find(category.CategoryId)
                    If local_cat_cpy Is Nothing Then
                        Throw New Exception("Category not found in DB")
                    End If
                End If
                If local_suppI_cpy Is Nothing Then
                    local_suppI_cpy = context.SupplierItems.Find(supplier.Id)
                    If local_cat_cpy Is Nothing Then
                        Throw New Exception("Supplier not found in DB.")
                    End If
                End If

                model.Name = _view.MenuName
                model.SellingCost = 0.00
                model.SupplierItem = local_suppI_cpy
                model.Category = local_cat_cpy
                model.Description = _view.ProductDescription
                model.ImageFilePath = selectedFilePath
                Dim cost As Decimal

                If Not Decimal.TryParse(_view.Cost, cost) Then
                    Throw New FormatException("Invalid format for Cost.")
                End If

                model.SellingCost = cost

                _mediator.GetUnitOfWork.AdminItems.Update(model)
                _mediator.GetUnitOfWork.SaveChanges()
                _mediator.SwapPage(Previous)

                Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminMenu), AdminMenuViewModel)
                vm.UpdateStaged(model)
                RestoreView()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                'Throw New Exception("Yep here")
            End Try

        End Sub

        Private Sub LoadWithDetails(model As AdminItem)
            'model.Validate()
            'MessageBox.Show($"{model.MenuId}")
            _view.MenuName = model.Name
            _view.CategoryName = model.Category?.CategoryName
            _view.SupplierName = model.SupplierItem?.Name
            _view.ProductDescription = model.Description
            _view.Cost = $"{model.SellingCost}"
            _view.ProductImagePath = model.ImageFilePath
            '_view.Sell = $"{model.Selling}"
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
                selectedFilePath = openFileDialog.FileName

                ' Optionally, set the selected image to a PictureBox (if you want to preview it)
                _view.Thumbnail.SizeMode = PictureBoxSizeMode.Zoom

                _view.Thumbnail.Image = Image.FromFile(selectedFilePath)

                ' Display the selected file path (for example, in a TextBox or MessageBox)
                MessageBox.Show("Selected file: " & selectedFilePath)
            End If
        End Sub
    End Class
End Namespace