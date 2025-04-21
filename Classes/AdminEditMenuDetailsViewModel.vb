Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity
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
        Private Property selectedFilePath As String = String.Empty
        Private Property FoundBatches As New Dictionary(Of String, InventoryBatch)
        Private Property FoundCategories As New Dictionary(Of String, Category)
        Private Property FoundSupplier As New Dictionary(Of String, User)

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
            _view.SaveButtonClick = Sub() UpdateMenu(model)
            _view.IsCustomerItem = model.IsDisplayedAsCustomerItem
            _view.BoundItem.Text = model.Batch.SupplierItem.Name
            LoadedBatch = model.Batch
            _view.SetClick()
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
            _view.SetAsMenuClick = AddressOf SetItemAsMenuClick
        End Sub

        Private Sub SelectSupplierClick()
            _mediator.SwapPage(AdminKeys.AdminMenuSelectSupplierItem)
        End Sub
        Private Sub SetCache()
            Dim context = DirectCast(_mediator.GetUnitOfWork, UnitOfWork)._context

            Dim categoryList As List(Of Category) = _mediator.GetUnitOfWork.Categories.GetAll()
            Dim supplierList As List(Of SupplierItem) = _mediator.GetUnitOfWork.SupplierItems.GetAll()
            Dim suppliers As List(Of User) = _mediator.GetUnitOfWork.Users.GetAll()

            For Each cl In categoryList
                CategoryCache.Add(cl.CategoryId, cl)
                context.Categories.Attach(cl)
            Next
        End Sub
        Private Sub SetComboBoxes()
            Dim catNameList As List(Of String) = CategoryCache.Select(Function(cl) cl.Value.CategoryName).ToList()
            'Dim suppNameList As List(Of String) = SupplierCache.Select(Function(sl) sl.Value.Name).ToList()

            _view.CategoryComboBox.Items.Clear()
            _view.CategoryComboBox.Items.AddRange(catNameList.ToArray())
        End Sub

        Private Sub SetItemAsMenuClick()
            _view.IsCustomerItem = Not _view.IsCustomerItem
            If _view.IsCustomerItem Then
                MessageBox.Show("Item is now added to the menu")
            Else
                MessageBox.Show("Item is now removed from the menu. You may add it again anytime you want.")
            End If
            _view.SetClick()
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
                'Dim supplier As SupplierItem = Nothing
                For Each kv In CategoryCache
                    If kv.Value.CategoryName = _view.CategoryName Then
                        category = kv.Value
                    End If
                Next
                If category Is Nothing Then Throw New Exception("category not found")


                Dim context = DirectCast(_mediator.GetUnitOfWork(), UnitOfWork)._context
                If LoadedBatch Is Nothing Then
                    Throw New Exception("LoadedBatch Is null")
                End If
                context.InventoryBatches.Attach(LoadedBatch)

                If context Is Nothing Then
                    Throw New Exception("Context doot")
                End If
                Dim local_cat_cpy = context.Categories.Local.FirstOrDefault(Function(c) c.CategoryId = category.CategoryId)
                If local_cat_cpy Is Nothing Then
                    local_cat_cpy = context.Categories.Find(category.CategoryId)
                    If local_cat_cpy Is Nothing Then
                        Throw New Exception("Category not found in DB")
                    End If
                End If

                Dim model = New AdminItem()
                model.Id = "AdminItem_" & Guid.NewGuid().ToString().Substring(0, 10)
                model.Name = _view.MenuName
                model.Category = local_cat_cpy
                model.CategoryId = local_cat_cpy.CategoryId
                model.Description = _view.ProductDescription
                model.ImageFilePath = selectedFilePath
                model.IsDisplayedAsCustomerItem = _view.IsCustomerItem
                model.Batch = LoadedBatch
                model.BatchId = LoadedBatch.BatchId
                Dim cost As Decimal
                Dim selling As Decimal

                If Not Decimal.TryParse(_view.Cost, cost) Then
                    Throw New FormatException("Invalid format for Cost.")
                End If
                If Not Decimal.TryParse(_view.Sell, selling) Then
                    Throw New FormatException("Invalid format for Selling price.")
                End If

                model.SellingCost = cost


                model.Validate()

                Dim version_model = New AdminItemVersion With {
                    .VersionId = "VERSION_" & Guid.NewGuid().ToString().Substring(0, 5),
                    .BaseItem = model,
                    .BaseItemId = model.Id,
                    .Batch = model.Batch,
                    .BatchID = model.BatchId,
                    .Category = model.Category,
                    .CategoryId = model.CategoryId,
                    .ImageFilePath = model.ImageFilePath,
                    .IsCurrentVersion = True,
                    .IsDisplayedAsACustomerItem = model.IsDisplayedAsCustomerItem,
                    .SellingCost = model.SellingCost,
                    .UnitCost = model.Batch.UnitCost,
                    .Name = model.Name,
                    .VersionUpdateReason = "Base Item with name: [" & model.Name & "] and with ID: {" & model.Id & "} created.",
                    .DateCreated = DateTime.Now(),
                    .EditorId = _mediator.GetCurrentUser().UserId
                }

                Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminMenu), AdminMenuViewModel)
                vm.AddNewMenu(model)
                _mediator.GetUnitOfWork.AdminItemVersion.Add(version_model)
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
                ' Validate required fields
                If String.IsNullOrEmpty(_view.CategoryName) Then
                    Throw New ArgumentException("Category name cannot be empty")
                End If

                ' Get category from cache
                Dim category As Category = CategoryCache.Values.FirstOrDefault(Function(c) c.CategoryName = _view.CategoryName)
                If category Is Nothing Then
                    Throw New Exception("Category not found in cache")
                End If

                ' Get context
                Dim context = DirectCast(_mediator.GetUnitOfWork(), UnitOfWork)._context
                If context Is Nothing Then
                    Throw New Exception("Database context not available")
                End If

                ' Handle category - check if already tracked
                Dim dbCategory = context.Categories.Local.FirstOrDefault(Function(c) c.CategoryId = category.CategoryId)
                If dbCategory Is Nothing Then
                    ' Try to find in database first
                    dbCategory = context.Categories.Find(category.CategoryId)
                    If dbCategory Is Nothing Then
                        ' If not in DB, add the new category
                        context.Categories.Add(category)
                        dbCategory = category
                    Else
                        ' If found in DB, attach only if not tracked
                        If context.Entry(dbCategory).State = EntityState.Detached Then
                            context.Categories.Attach(dbCategory)
                        End If
                    End If
                End If

                ' Handle batch - improved attachment logic
                If LoadedBatch IsNot Nothing Then
                    ' Check if batch is already tracked
                    Dim existingBatch = context.InventoryBatches.Local.FirstOrDefault(Function(b) b.BatchId = LoadedBatch.BatchId)
                    If existingBatch Is Nothing Then
                        ' Try to find in database
                        existingBatch = context.InventoryBatches.Find(LoadedBatch.BatchId)
                        If existingBatch Is Nothing Then
                            ' New batch - add it
                            context.InventoryBatches.Add(LoadedBatch)
                        Else
                            ' Existing batch - update loaded batch with DB values
                            context.Entry(existingBatch).CurrentValues.SetValues(LoadedBatch)
                            LoadedBatch = existingBatch
                        End If
                    Else
                        ' Use the already tracked instance
                        LoadedBatch = existingBatch
                    End If

                    model.Batch = LoadedBatch
                    model.BatchId = LoadedBatch.BatchId
                End If

                ' Set default image if empty
                If String.IsNullOrEmpty(selectedFilePath) Then
                    selectedFilePath = "default_image_path.png"
                End If

                ' Store original values before updating
                Dim originalName = model.Name
                Dim originalSellingCost = model.SellingCost
                Dim originalBatchId = model.BatchId
                Dim originalCategoryId = model.CategoryId

                ' Update model properties
                model.Name = _view.MenuName
                model.SellingCost = 0.00 ' Consider parsing from view like you do with cost
                model.Category = dbCategory
                model.CategoryId = dbCategory.CategoryId
                model.Description = _view.ProductDescription
                model.ImageFilePath = selectedFilePath
                model.IsDisplayedAsCustomerItem = _view.IsCustomerItem

                ' Validate cost
                Dim cost As Decimal
                If Not Decimal.TryParse(_view.Cost, cost) Then
                    Throw New FormatException("Invalid format for Cost.")
                End If

                ' Check if we need to create a new version
                Dim needsNewVersion = (originalName <> model.Name) OrElse
                             (originalSellingCost <> model.SellingCost) OrElse
                             (originalBatchId <> model.BatchId) OrElse
                             (originalCategoryId <> model.CategoryId)

                If needsNewVersion Then
                    ' Create new version based on original values
                    Dim current_ver = _mediator.GetUnitOfWork.AdminItemVersion.GetCurrentVersion(model.Id)
                    current_ver.IsCurrentVersion = False
                    Dim newVersion = New AdminItemVersion With {
                    .VersionId = "VER_" & Guid.NewGuid().ToString("N").Substring(0, 8),
                    .BaseItemId = model.Id,
                    .Name = model.Name,
                    .SellingCost = model.SellingCost,
                    .BatchID = model.BatchId,
                    .CategoryId = model.CategoryId,
                    .ImageFilePath = model.ImageFilePath,
                    .IsDisplayedAsACustomerItem = model.IsDisplayedAsCustomerItem,
                    .IsCurrentVersion = True,
                    .VersionUpdateReason = "Auto-versioned due to significant changes",
                    .DateCreated = DateTime.Now,
                    .EditorId = _mediator.GetCurrentUser().UserId
            }

                    ' Add the new version
                    _mediator.GetUnitOfWork.AdminItemVersion.Update(current_ver)
                    _mediator.GetUnitOfWork.AdminItemVersion.Add(newVersion)
                End If

                ' Update the main item
                _mediator.GetUnitOfWork.AdminItems.Update(model)
                _mediator.GetUnitOfWork.SaveChanges()

                ' Update UI
                _mediator.SwapPage(Previous)
                Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminMenu), AdminMenuViewModel)
                vm.UpdateStaged(model)
                RestoreView()

            Catch ex As Exception
                MessageBox.Show($"Error updating menu: {ex.Message}")
                Throw ' Re-throw to allow caller to handle
            End Try
        End Sub

        Private Sub LoadWithDetails(model As AdminItem)
            'model.Validate()
            'MessageBox.Show($"{model.MenuId}")
            _view.MenuName = model.Name
            _view.CategoryName = model.Category?.CategoryName
            ' _view.BoundItem.Text = model.Batch.SupplierItem.Name
            _view.ProductDescription = model.Description
            _view.Cost = $"{model.SellingCost}"
            _view.ProductImagePath = model.ImageFilePath
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

            End If
        End Sub
    End Class
End Namespace