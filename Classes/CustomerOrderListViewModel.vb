Imports System.Collections.Concurrent
Imports System.Security.Cryptography.X509Certificates
Imports System.Threading
Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model
Imports LiveCharts.Charts
Imports LiveCharts.WinForms
Imports LiveCharts.Wpf

Namespace KioskV0.Classes
    Public Class CustomerOrderListViewModel
        Inherits ViewModel(Of Forms.CustomerOrderListView, CustomerKeys)
        Private Property Loaded As Boolean = False
        Private Property TestBool As Boolean = False
        Private Property NoItemsPanel As Panel = New Panel
        'Private _cart As List(Of OrderModel)
        Private Property Cart As New Dictionary(Of String, OrderDetail)

        Public Property UpdatedCart As Dictionary(Of String, OrderDetail)
            Get
                Return Cart
            End Get
            Set(value As Dictionary(Of String, OrderDetail))
                'Cart.Clear()
                Cart = value

                If value Is Nothing OrElse value.Count = 0 Then
                    LoadWithEmptyCart()
                Else
                    LoadWithCart()
                End If
            End Set
        End Property

        Public Sub New(view As CustomerOrderListView, mediator As Mediator(Of CustomerKeys))
            MyBase.New(view, mediator)
            GetCart()
            SetEvents()

            _view.OrderListPanel.BringToFront()
            RecordChildAspectRatio(_view.OrderListFlowLayout)
            RecordChildAspectRatio(_view.OrderListPanel)
            RecordChildAspectRatio(_view.Buttons)
            RecordChildAspectRatio(_view.OrderMoreButton)
            RecordChildAspectRatio(_view.StartOverButton)
        End Sub

        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()
            _view.OrderMoreClick = AddressOf OnOrderMoreClicked
            _view.StartOverClick = AddressOf OnStartOverClicked
            _view.CheckOutClick = AddressOf OnCheckoutClicked

        End Sub
        Public Overrides Sub Project(projector As Form)
            _mediator.LayoutAction(Sub()
                                       _mediator.AddAction(Sub() MyBase.Project(projector))
                                       If Not Loaded Then
                                           _mediator.AddAction(Sub() MyBase.Project(projector))
                                           _mediator.AddAction(Sub() ResizeComponents(_mediator.GetProjectorPanelSize()))
                                           _mediator.AddAction(Sub() SetupPanel())
                                           _mediator.AddAction(Sub() LoadOrderDetails())
                                       End If
                                       _mediator.InvokeAllAction()
                                       'MessageBox.Show($"{_view.Size.Width}")
                                   End Sub)
            Loaded = True
        End Sub
        Private Sub LoadWithEmptyCart()
            NoItemsPanel.Visible = True
        End Sub
        Private Sub LoadWithCart()
            NoItemsPanel.Visible = False
            LoadOrderDetails()
        End Sub
        Private Sub GetCart()

        End Sub
        Private Sub SetupPanel()
            NoItemsPanel.Location = New Point(_view.PanelLocation.X, _view.PanelLocation.Y + _view.TopBar.Height)
            NoItemsPanel.Size = _mediator.GetScreenSize()
            NoItemsPanel.BackColor = Color.Wheat
            _view.Controls.Add(NoItemsPanel)
            NoItemsPanel.BringToFront()

            Dim uc = New CustomerNoItemUserControl()
            Dim x = NoItemsPanel.Width / 2 - uc.Width / 2
            Dim y = NoItemsPanel.Height / 2 - uc.Height / 1.5
            uc.Location = New Point(x, y)
            uc.BackClick = Sub() _mediator.SwapPage(CustomerKeys.CustomerMenu)
            NoItemsPanel.Controls.Add(uc)
        End Sub
        Private Sub LoadOrderDetails()
            If _view IsNot Nothing Then
                _view.OrderListFlowLayout.Controls.Clear()

                For Each order In Cart
                    Dim orderDetails As New CustomerOrderDetailsUserControl(order.Value)
                    orderDetails.AddItemClick = Sub()
                                                    order.Value.Quantity += 1
                                                    'Cart(order.Key).Quantity += 1
                                                    orderDetails.SetLabels()
                                                    SyncCart()
                                                End Sub
                    orderDetails.DecreaseItemClick = Sub()
                                                         If order.Value.Quantity > 1 Then
                                                             order.Value.Quantity -= 1
                                                             'Cart(order.Key).Quantity -= 1
                                                             orderDetails.SetLabels()
                                                             SyncCart()
                                                         End If

                                                     End Sub
                    orderDetails.RemoveItemClick = Sub()
                                                       'Cart.Remove(order)
                                                       '_mediator.AddAction(Sub()
                                                       Cart.Remove(order.Key)
                                                       _view.OrderListFlowLayout.Controls.Remove(orderDetails)
                                                       orderDetails.Dispose()
                                                       SyncCart()
                                                       If Cart.Count = 0 Then LoadWithEmptyCart()
                                                       'End Sub)
                                                       'LoadOrderDetails()
                                                       'End Sub
                                                   End Sub
                    _view.OrderListFlowLayout.Controls.Add(orderDetails)
                Next
                PopulateDGV()
                '_mediator.InvokeAllAction()
            End If

        End Sub

        Private Sub PopulateDGV()
            With _view.OrderDetailsDGV
                .Rows.Clear()

                If .Columns.Count = 0 Then
                    .Columns.Add("ItemName", "Item")
                    .Columns.Add("Quantity", "Qty")
                    .Columns.Add("TotalPrice", "Price")

                    .Columns("ItemName").Width = 220
                    .Columns("Quantity").Width = 30
                    .Columns("TotalPrice").Width = 90

                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.None
                End If

                For Each order In Cart.Values
                    Dim itemName As String = order.ItemVersion.Name
                    Dim quantity As Integer = order.Quantity
                    Dim unitPrice As Decimal = order.ItemVersion.SellingCost
                    Dim totalPrice As Decimal = unitPrice * quantity

                    .Rows.Add(itemName, quantity, totalPrice.ToString("C"))
                Next
            End With
        End Sub

        Private Sub UpdateTotalPrice()
            Dim total As Decimal = Cart.Values.Sum(Function(order) order.Quantity * order.ItemVersion.SellingCost)
            _view.TotalPriceLabel.Text = $"PHP{total:C}"
        End Sub

        Private Sub SyncCart()
            PopulateDGV()
            UpdateTotalPrice()
        End Sub

        Private Sub OnOrderMoreClicked()
            'MessageBox.Show($"{Cart.Count}")
            Dim vm = DirectCast(_mediator.GetVM(CustomerKeys.CustomerMenu), CustomerMenuViewModel)
            vm.UpdatedCart = Cart
            _mediator.SwapPage(CustomerKeys.CustomerMenu)
        End Sub

        Private Sub OnStartOverClicked()
            Cart.Clear()
            LoadOrderDetails()
            Dim vm = DirectCast(_mediator.GetVM(CustomerKeys.CustomerMenu), CustomerMenuViewModel)
            vm.UpdatedCart = Cart
            _mediator.SwapPage(CustomerKeys.CustomerMenu)
        End Sub

        Private Sub OnCheckoutClicked()
            _mediator.SwapPage(CustomerKeys.CustomerConfirmOrder)
            Dim vm = DirectCast(_mediator.GetVM(CustomerKeys.CustomerConfirmOrder), CustomerConfirmOrderViewModel)
            vm.LoadWithCart(Cart)
        End Sub


    End Class

End Namespace