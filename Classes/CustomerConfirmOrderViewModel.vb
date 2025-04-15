Imports System.Data.Entity
Imports System.Runtime.Remoting.Contexts
Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class CustomerConfirmOrderViewModel
        Inherits ViewModel(Of Forms.CustomerConfirmOrderView, CustomerKeys)
        Public Property Cart As Dictionary(Of String, OrderDetail)
        Public Sub New(view As CustomerConfirmOrderView, mediator As Mediator(Of CustomerKeys))
            MyBase.New(view, mediator)

            AddHandler _view.ViewOrderButton.Click, Sub() Confirm()
        End Sub

        Public Sub LoadWithCart(cart As Dictionary(Of String, OrderDetail))
            Me.Cart = cart
            _mediator.SwapPage(CustomerKeys.CustomerConfirmOrder)
        End Sub

        Private Sub Confirm()
            If Cart Is Nothing Then Return
            _mediator.GetUnitOfWork().Orders.Add(GetOrder())
            _mediator.GetUnitOfWork.SaveChanges()
            _mediator.SwapPage(CustomerKeys.CustomerPayment)
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

    End Class

End Namespace