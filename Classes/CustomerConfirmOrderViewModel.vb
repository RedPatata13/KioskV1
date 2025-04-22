Imports System.Data.Entity
Imports System.Runtime.Remoting.Contexts
Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class CustomerConfirmOrderViewModel
        Inherits ViewModel(Of Forms.CustomerConfirmOrderView, CustomerKeys)
        Public Property Cart As Dictionary(Of String, OrderDetail)
        Public Property SelectedOrderType As String
        Public Property OrderNumber As String
        Public Property OrderNote As String
        Public Sub New(view As CustomerConfirmOrderView, mediator As Mediator(Of CustomerKeys))
            MyBase.New(view, mediator)

            AddHandler _view.ConfirmOrderButton.Click, Sub() Confirm()
            AddHandler _view.BackButton.Click, Sub() _mediator.SwapPage(CustomerKeys.CustomerOrderList)
            AddHandler _view.AddNoteButton.Click, Sub() ShowAddNote()
        End Sub

        Public Sub LoadWithCart(cart As Dictionary(Of String, OrderDetail))
            Me.Cart = cart
            ' _mediator.SwapPage(CustomerKeys.CustomerConfirmOrder)
            LoadOrderDetails()
        End Sub

        Private Sub Confirm()
            If Cart Is Nothing Then Return
            Dim order = GetOrder()
            'order.OrderType = SelectedOrderType
            OrderNumber = order.OrderId
            _mediator.GetUnitOfWork().Orders.Add(order)
            _mediator.GetUnitOfWork.SaveChanges()

            Dim paymentVM = DirectCast(_mediator.GetVM(CustomerKeys.CustomerPayment), CustomerPaymentViewModel)
            paymentVM.CurrentOrderNumber = OrderNumber

            ShowOrderType()
            Cart = Nothing
        End Sub

        Private Function GetOrder() As OrderPrimal
            Dim op As New OrderPrimal With {
                .OrderId = Guid.NewGuid().ToString().Substring(0, 10),
                .CreatedAt = DateTime.Now,
                .OrderItems = Cart.Values.ToList(),
                .TotalPrice = Cart.Values.Aggregate(0D, Function(t, x) t + (x.Quantity * x.CustomerItem.SellingCost))
            }

            Dim context = DirectCast(_mediator.GetUnitOfWork(), UnitOfWork)._context
            If context Is Nothing Then
                Throw New Exception("Context doot")
            End If

            ' Attach all categories and customer items first
            For Each o In op.OrderItems
                ' Handle Category
                Dim category = context.Categories.Local.FirstOrDefault(Function(c) c.CategoryId = o.CustomerItem.Category.CategoryId)
                If category Is Nothing Then
                    category = context.Categories.Find(o.CustomerItem.Category.CategoryId)
                    If category Is Nothing Then
                        Throw New Exception("Category not found in DB")
                    End If
                End If
                o.CustomerItem.Category = category

                ' Handle CustomerItem
                Dim customerItem = context.AdminItems.Local.FirstOrDefault(Function(c) c.Id = o.CustomerItem.Id)
                If customerItem Is Nothing Then
                    customerItem = context.AdminItems.Find(o.CustomerItem.Id)
                    If customerItem Is Nothing Then
                        Throw New Exception("CustomerItem not found in DB")
                    End If
                End If

                o.CustomerItem = customerItem
            Next

            Return op
        End Function

        Private Sub LoadOrderDetails()
            If _view IsNot Nothing Then
                _view.OrdersFlowlayoutPanel.Controls.Clear()

                For Each order In Cart
                    Dim orderDetails As New CustomerOrderDetailsUserControl(order.Value)
                    orderDetails.ShowButtons = False
                    _view.OrdersFlowlayoutPanel.Controls.Add(orderDetails)
                Next
            End If
        End Sub

        Private Sub ShowAddNote()
            _view.ConfirmOrderPanel.Controls.Clear()

            Dim addNote As New CustomerAddNoteUserControl()
            addNote.Dock = DockStyle.Fill

            addNote.NoteText = OrderNote
            AddHandler addNote.SaveNoteClick, Sub(note As String)
                                                  OrderNote = note
                                                  _view.ConfirmOrderPanel.Visible = False
                                                  LoadOrderDetails()
                                              End Sub
            AddHandler addNote.BackClick, Sub()
                                              _view.ConfirmOrderPanel.Visible = False
                                              LoadOrderDetails()
                                          End Sub
            _view.ConfirmOrderPanel.Controls.Add(addNote)
            _view.ConfirmOrderPanel.BringToFront()
            _view.ConfirmOrderPanel.Visible = True
        End Sub

        Private Sub ShowOrderType()
            _view.ConfirmOrderPanel.Controls.Clear()
            Dim orderType As New CustomerOrderTypeUserControl()
            orderType.Dock = DockStyle.Fill

            AddHandler orderType.DineInClicked, Sub()
                                                    SelectedOrderType = "Dine In"
                                                    _mediator.SwapPage(CustomerKeys.CustomerPayment)
                                                End Sub
            AddHandler orderType.TakeOutClicked, Sub()
                                                     SelectedOrderType = "Take Out"
                                                     _mediator.SwapPage(CustomerKeys.CustomerPayment)
                                                 End Sub
            _view.ConfirmOrderPanel.Controls.Add(orderType)
            _view.ConfirmOrderPanel.BringToFront()
            _view.ConfirmOrderPanel.Visible = True
        End Sub

    End Class

End Namespace