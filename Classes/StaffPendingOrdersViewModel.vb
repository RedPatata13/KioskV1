Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class StaffPendingOrdersViewModel
        Inherits ViewModel(Of Forms.StaffPendingOrdersView, StaffKeys)

        Private Property _orderControls As Dictionary(Of String, StaffPendingOrdersUserControl)

        Public Sub New(view As StaffPendingOrdersView, mediator As Mediator(Of StaffKeys))
            MyBase.New(view, mediator)
            _orderControls = New Dictionary(Of String, StaffPendingOrdersUserControl)
        End Sub

        Public Overrides Sub Project(projector As Form)
            MyBase.Project(projector)
            _orderControls.Clear()
            _view.ListPendingOrdersFlowLayoutPanel.Controls.Clear()

            Dim orders = GetOrderDetailInfoList().
                         Where(Function(o) Not o.IsComplete).
                         GroupBy(Function(o) o.OrderId)

            For Each orderGroup In orders
                Dim orderId = orderGroup.Key
                Dim itemNames = orderGroup.Select(Function(i) i.ItemName).ToList()
                Dim isPaid = orderGroup.First().IsPaid
                Dim isComplete = orderGroup.First().IsComplete

                Dim uc As New StaffPendingOrdersUserControl(orderId, itemNames, isPaid, isComplete)
                AddHandler uc.CompleteOrderClicked, Sub() OnCompleteClicked(orderId)
                _orderControls(orderId) = uc
                _view.ListPendingOrdersFlowLayoutPanel.Controls.Add(uc)
            Next
        End Sub

        Private Sub OnCompleteClicked(orderId As String)
            Dim order = _mediator.GetUnitOfWork().Orders.GetById(orderId)
            If order IsNot Nothing Then
                order.IsComplete = True
                _mediator.GetUnitOfWork().SaveChanges()
                MessageBox.Show($"Order {orderId} marked as complete.")
            End If
            Project(_view.ParentForm)
        End Sub

        Public Function GetOrderDetailInfoList() As List(Of OrderDetailInfo)
            Dim result = (From detail In _mediator.GetUnitOfWork.OrderDetails.GetAll()
                          Where detail.Item IsNot Nothing AndAlso
                                        detail.Order IsNot Nothing AndAlso
                                        detail.Order.IsPaid = True
                          Select New OrderDetailInfo With {
                                      .OrderId = detail.OrderId,
                                      .IsPaid = detail.Order.IsPaid,
                                      .IsComplete = detail.Order.IsComplete,
                                      .ItemName = detail.Item.Name
                                  }).ToList()
            Return result
        End Function
    End Class
End Namespace
