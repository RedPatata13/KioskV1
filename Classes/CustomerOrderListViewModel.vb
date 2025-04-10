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
        Private _cart As List(Of OrderModel)
        Public Sub New(view As CustomerOrderListView, mediator As Mediator(Of CustomerKeys))
            MyBase.New(view, mediator)
            GetCart()
            SetEvents()


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

        Private Sub GetCart()
            _cart = Nothing
            If _cart Is Nothing Then
                _cart = New List(Of OrderModel)() ' Initialize if it's Nothing
            End If
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
            uc.BackClick = Sub() ShowNoItemsPanel()
            NoItemsPanel.Controls.Add(uc)
        End Sub
        Private Sub ShowNoItemsPanel()
            If Not TestBool Then
                NoItemsPanel.Visible = Not NoItemsPanel.Visible
                TestBool = Not TestBool
            End If
        End Sub
        Private Sub LoadOrderDetails()
            If _view IsNot Nothing Then
                _view.OrderListFlowLayout.Controls.Clear()

                For Each order In _cart
                    Dim orderDetails As New CustomerOrderDetailsUserControl(order) With {
                    .AddItemClick = Sub()
                                        order.Quantity += 1
                                        orderDetails.SetLabels()
                                    End Sub,
                    .DecreaseItemClick = Sub()
                                             If order.Quantity > 1 Then
                                                 order.Quantity -= 1
                                             End If
                                             orderDetails.SetLabels()
                                         End Sub,
                    .RemoveItemClick = Sub()
                                           _cart.Remove(order)
                                           LoadOrderDetails()
                                       End Sub
                    }
                    _view.OrderListFlowLayout.Controls.Add(orderDetails)
                Next
            End If

        End Sub

        Private Sub PopulateDGV()
            If _view IsNot Nothing Then
                _view.OrderDetailsDGV.Rows.Clear()
                For Each order In _cart
                    Dim totalPrice As Decimal = order.MenuItem.Selling * order.Quantity
                    _view.OrderDetailsDGV.Rows.Add(order.MenuItem.Name, order.Quantity, totalPrice.ToString("C"))
                Next
            Else
                'handle when view is nothing
            End If
        End Sub

        Private Sub OnOrderMoreClicked()
            _mediator.SwapPage(CustomerKeys.CustomerMenu)
        End Sub

        Private Sub OnStartOverClicked()
            _cart.Clear()
            LoadOrderDetails()
            _mediator.SwapPage(CustomerKeys.CustomerMenu)
        End Sub

        Private Sub OnCheckoutClicked()
            _mediator.SwapPage(CustomerKeys.CustomerPayment)
        End Sub


    End Class

End Namespace