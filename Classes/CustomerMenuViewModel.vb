Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class CustomerMenuViewModel
        Inherits ViewModel(Of Forms.CustomerMenuView, CustomerKeys)
        Private Property Loaded As Boolean = False
        Private Property AllMenuItems As List(Of CustomerItem)
        Private Property CategoryList As New Dictionary(Of String, Category)
        Private _cart As New List(Of OrderModel)
        Public Sub New(view As CustomerMenuView, mediator As Mediator(Of CustomerKeys))
            MyBase.New(view, mediator)

            RecordChildAspectRatio(_view.ViewOrderButton)
            RecordChildAspectRatio(_view.StartOverButton)
            '_view.ViewOrderButton.Location = New Point(_view.ViewOrderButton.Location.X + 400, _view.ViewOrderButton.Location.Y)
            '_view.ViewOrderButton.Location = New Point(_view.StartOverButton.Location.X + 400, _view.StartOverButton.Location.Y)
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

            'Dim categoryList = _mediator.GetUnitOfWork().Categories.GetAll()
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
            AllMenuItems = _mediator.GetCustomerItemList()
            For Each ami In AllMenuItems
                If Not CategoryList.ContainsKey(ami.AdminItem.Category.CategoryId) Then
                    CategoryList.Add(ami.AdminItem.Category.CategoryId, ami.AdminItem.Category)

                End If
            Next
        End Sub

        Private Sub LoadMenuItems(category As String)
            _view.ItemPanel.Controls.Clear()

            Dim filtered = If(category = "All", AllMenuItems,
                AllMenuItems.Where(Function(x) x.AdminItem.Category.CategoryName.Contains(category)).ToList())

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
        Private Sub MenuUserControlClick(item As CustomerItem)
            ShowQuantityUC(item)
        End Sub

        Private Sub ShowQuantityUC(item As CustomerItem)
            Dim quantityUC As New CustomerOrderQuantityUserControl(item) With {
            .AddOrderClick = Sub(model, qty)
                                 AddToCart(model, qty)
                                 _view.HideQuantityPopup()
                                 UpdateCartSummary()
                             End Sub,
            .CancelClick = Sub()
                               _view.HideQuantityPopup()
                           End Sub
        }
            _view.DisplayOrderQuantity(quantityUC)
        End Sub

        Private Sub AddToCart(menu As CustomerItem, quantity As Integer)
            Dim existingOrder = _cart.FirstOrDefault(Function(o) o.MenuItem.Equals(menu))
            If existingOrder IsNot Nothing Then
                existingOrder.Quantity += quantity
            Else
                _cart.Add(New OrderModel With {
              .MenuItem = menu,
              .Quantity = quantity
            })
            End If
        End Sub

        Private Sub UpdateCartSummary()
            Dim totalItems = _cart.Sum(Function(o) o.Quantity)
            Dim totalPrice = _cart.Sum(Function(o) o.MenuItem.Selling * o.Quantity)

            _view.UpdateCartSummary(totalItems, totalPrice)
        End Sub

        Private Sub OnStartOverClicked()
            _cart.Clear()
            UpdateCartSummary()
        End Sub
        Private Sub OnViewOrderClicked()
            If _cart.Count = 0 Then
                'Dim noItemUC As New CustomerNoItemUserControl() With {
                '.BackClick = Sub()
                '                 _view.CustomerMainPanelView.Controls.Clear()
                '                 _view.CustomerMainPanelView.Visible = False
                '                 _mediator.SwapPage(CustomerKeys.CustomerMenu)
                '             End Sub}
                _view.CustomerMainPanelView.Controls.Clear()
                '_view.CustomerMainPanelView.Controls.Add(noItemUC)
                _view.CustomerMainPanelView.Visible = True
            Else
                _mediator.SwapPage(CustomerKeys.CustomerOrderList)
            End If
        End Sub
    End Class

End Namespace