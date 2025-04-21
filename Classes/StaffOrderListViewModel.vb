Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model
Imports LiveCharts.WinForms

Namespace KioskV0.Classes
    Public Class StaffOrderListViewModel
        Inherits ViewModel(Of Forms.CustomerMenuView, StaffKeys)
        Private Property Loaded As Boolean = False
        Private Property AllMenuItems As List(Of AdminItemVersion)
        Private Property CategoryList As New Dictionary(Of String, Category)
        Private _cart As New List(Of OrderModel)
        Private Property UserCart As New Dictionary(Of String, OrderDetail)
        Private Property TotalItems As Integer = 0
        Private Property TotalCost As Decimal = 0
        Public Property UpdatedCart As Dictionary(Of String, OrderDetail)
            Get
                Return UserCart
            End Get
            Set(value As Dictionary(Of String, OrderDetail))
                'UserCart.Clear()
                '_mediator.GetUnitOfWork.Attach
                TotalItems = 0
                TotalCost = 0
                UserCart = value
                For Each kv In value
                    TotalItems += kv.Value.Quantity
                    TotalCost += kv.Value.ItemVersion.SellingCost * kv.Value.Quantity
                Next
                UpdateCartSummary()
            End Set
        End Property
        Public Sub New(view As CustomerMenuView, mediator As Mediator(Of StaffKeys))
            MyBase.New(view, mediator)

            RecordChildAspectRatio(_view.ViewOrderButton)
            RecordChildAspectRatio(_view.StartOverButton)

            OnStartOverClicked()
            SetEvents()
        End Sub
        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()
            _view.CategoryClick = AddressOf OnCategoryClicked
            _view.ViewOrderClick = AddressOf OnViewOrderClicked
            _view.StartOverClick = AddressOf OnStartOverClicked
        End Sub

        Public Overrides Sub Project(projector As Form)
            _mediator.LayoutAction(Sub()
                                       _mediator.AddAction(Sub() MyBase.Project(projector))
                                       If Not Loaded Then
                                           _mediator.AddAction(Sub() MyBase.Project(projector))
                                           _mediator.AddAction(Sub() ResizeComponents(_mediator.GetProjectorPanelSize()))
                                           _mediator.AddAction(Sub() LoadMenuData())
                                           _mediator.AddAction(Sub() LoadCategories())
                                       End If
                                       _mediator.AddAction(Sub() LoadMenuItems("All"))
                                       _mediator.InvokeAllAction()
                                   End Sub)
            Loaded = True
        End Sub
        Private Sub LoadCategories()
            _view.CategoryPanel.Controls.Clear()
            Dim locationY = 0
            Dim allButton = New Guna.UI2.WinForms.Guna2Button
            allButton.Text = "All"
            allButton.Location = New Point(0, locationY)
            locationY += allButton.Height
            AddHandler allButton.Click, Sub() LoadMenuItems(allButton.Text)
            _view.CategoryPanel.Controls.Add(allButton)
            For Each ctgr In CategoryList
                Dim button As New Guna.UI2.WinForms.Guna2Button
                button.Text = ctgr.Value.CategoryName
                'button.Click = Sub() LoadMenuItems(button.Text)
                button.Location = New Point(0, locationY)
                locationY += button.Height
                AddHandler button.Click, Sub() LoadMenuItems(button.Text)
                _view.CategoryPanel.Controls.Add(button)
            Next

        End Sub

        Private Sub LoadMenuData()
            ' Clear existing category list
            CategoryList.Clear()

            ' Get only AdminItems marked for customer display
            Dim displayedItems = _mediator.GetUnitOfWork.AdminItemVersion.GetAll() _
            .Where(Function(ami) ami.IsDisplayedAsACustomerItem AndAlso ami.Category IsNot Nothing AndAlso ami.IsCurrentVersion) _
            .ToList()

            ' Populate category dictionary
            For Each ami In displayedItems
                If Not CategoryList.ContainsKey(ami.Category.CategoryId) Then
                    CategoryList.Add(ami.Category.CategoryId, ami.Category)
                End If
            Next

            AllMenuItems = displayedItems
        End Sub

        Private Sub LoadMenuItems(category As String)
            _view.ItemPanel.Controls.Clear()

            Dim filtered = If(category = "All", AllMenuItems,
                AllMenuItems.Where(Function(x) x.Category.CategoryName.Contains(category)).ToList())

            'Dim filtered As List(Of CustomerItem) = AllMenuItems
            For Each item In filtered
                Dim uc As New CustomerMenuUserControl(item)
                uc.SelfClick = Sub() MenuUserControlClick(item)
                _view.ItemPanel.Controls.Add(uc)
            Next
        End Sub

        Private Sub OnCategoryClicked(category As String)
            LoadMenuItems(category)
        End Sub
        Private Sub MenuUserControlClick(item As AdminItemVersion)
            ShowQuantityUC(item)
        End Sub

        Private Sub ShowQuantityUC(item As AdminItemVersion)
            ' Create the UserControl instance
            Dim quantityUC As New CustomerOrderQuantityUserControl(item)
            quantityUC.AddOrderClick = Sub()
                                           ' Use quantityUC.Quantity to get the updated amount
                                           Dim amount = quantityUC.Quantity
                                           TotalItems += quantityUC.Quantity
                                           TotalCost += amount * item.SellingCost
                                           _view.UpdateCartSummary(TotalItems, TotalCost)
                                           AddToCart(item, amount) ' Add to cart with the updated amount
                                           _view.HideQuantityPopup() ' Hide the quantity popup
                                       End Sub
            quantityUC.CancelClick = Sub()
                                         _view.HideQuantityPopup() ' Hide the quantity popup without adding to cart
                                     End Sub


            ' Display the UserControl to the view
            _view.DisplayOrderQuantity(quantityUC)
        End Sub


        Private Sub AddToCart(menu As AdminItemVersion, quantity As Integer)
            If Not UserCart.ContainsKey(menu.VersionId) Then
                Dim id = Guid.NewGuid().ToString().Substring(0, 10)
                Dim model = New OrderDetail With {
                .OrderDetailsId = id,
                .ItemVersion = menu,
                .VersionId = menu.VersionId,
                .Quantity = 0
                }
                UserCart(menu.VersionId) = model
            End If

            UserCart(menu.VersionId).Quantity += quantity
            'MessageBox.Show($"{UserCart(menu.Id).Quantity}")
        End Sub

        Private Sub UpdateCartSummary()
            'Dim totalItems = Cart.Sum(Function(o) o.Quantity)
            'Dim totalPrice = _car.Sum(Function(o) o.MenuItem.Selling * o.Quantity)
            'UserCart.Clear()
            _view.UpdateCartSummary(TotalItems, TotalCost)
        End Sub

        Private Sub OnStartOverClicked()
            UserCart.Clear()
            TotalItems = 0
            TotalCost = 0
            UpdateCartSummary()
        End Sub
        Private Sub OnViewOrderClicked()
            Dim vm = DirectCast(_mediator.GetVM(StaffKeys.StaffPos), StaffPosViewModel)
            vm.IncomingCartItems = UserCart
            _mediator.SwapPage(StaffKeys.StaffPos)

        End Sub
    End Class

End Namespace