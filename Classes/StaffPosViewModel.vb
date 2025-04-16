Imports System.Runtime.InteropServices
Imports KioskV0.KioskV0.Forms
Imports LiveCharts

Namespace KioskV0.Classes
    Public Class StaffPosViewModel
        Inherits ViewModel(Of Forms.StaffPosView, StaffKeys)
        Private Property _currOrd As OrderPrimal = Nothing
        Private Property Cart As New Dictionary(Of String, AdminItem)

        Private Property _orderCache As New Dictionary(Of String, AdminItem)
        Private Property _deletedItemsQueue As New Queue(Of OrderDetail)
        Private Property DontAskAgain As Boolean = False
        Public Sub New(view As StaffPosView, mediator As Mediator(Of StaffKeys))
            MyBase.New(view, mediator)

            'TempOrder()
            SetEvents()
        End Sub
        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()

            _view.PayButtonClick = AddressOf PayButtonClick
            _view.OrderTextBoxTextchanged = Sub() TempOrder(_view.SearchOrderTextbox.Text)
        End Sub
        Private Sub TempOrder(id As String)
            _currOrd = _mediator.GetUnitOfWork.Orders.GetById(id)
            If _currOrd Is Nothing Then
                MessageBox.Show("Order not found")
                Return
            End If

            For Each item In _currOrd.OrderItems
                Cart.Add(item.OrderDetailsId, item.CustomerItem)
                Dim uc = New StaffPosOrderUserControl()
                uc.Model = item
                uc.DeleteClick = Sub() DeleteClick(uc)
                _view.CurrentItemsFlowPanel.Controls.Add(uc)
            Next
        End Sub

        Private Sub DeleteClick(uc As StaffPosOrderUserControl)
            Dim confirmPanel As StaffPosConfirmationUserControl = New StaffPosConfirmationUserControl()
            Dim backdrop = New Panel()
            Dim confirm As Action = Sub()
                                        EnableControls()
                                        Cart.Remove(uc.Model.OrderDetailsId)
                                        _view.CurrentItemsFlowPanel.Controls.Remove(uc)
                                        _view.Controls.Remove(confirmPanel)
                                        _view.Controls.Remove(backdrop)
                                        _currOrd.OrderItems.Remove(uc.Model)
                                        _deletedItemsQueue.Enqueue(uc.Model)
                                        uc.Dispose()
                                        DontAskAgain = confirmPanel.Checkbox.Checked
                                    End Sub
            Dim cancel As Action = Sub()
                                       EnableControls()
                                       _view.Controls.Remove(confirmPanel)
                                       _view.Controls.Remove(backdrop)
                                       confirmPanel.Dispose()
                                   End Sub
            If Not DontAskAgain Then
                DisableControls()
                _view.Controls.Add(confirmPanel)
                confirmPanel.BringToFront()
                confirmPanel.CancelButtonClick = cancel
                confirmPanel.ConfirmButtonClick = confirm

                Dim size = _mediator.GetProjectorPanelSize()
                Dim x = size.Width / 2 - confirmPanel.Width / 2
                Dim y = size.Height / 2 - confirmPanel.Height / 2


                backdrop.Size = size
                backdrop.BackColor = Color.FromArgb(128, 0, 0, 0)
                backdrop.Parent = _view

                _view.Controls.Add(backdrop)
                backdrop.Location = New Point(0, 0)
                confirmPanel.Location = New Point(x, y)

                backdrop.BringToFront()
                confirmPanel.BringToFront()
            Else
                confirm.Invoke()
                DontAskAgain = True
            End If
        End Sub

        Private Sub PayButtonClick()
            If _currOrd Is Nothing Then
                MessageBox.Show("There's no Order Selected")
                Return
            End If
            Dim context = DirectCast(_mediator.GetUnitOfWork, UnitOfWork)._context
            Dim total As Decimal = 0.0
            For Each item In _currOrd.OrderItems
                context.OrderDetails.Attach(item)
                _mediator.GetUnitOfWork.OrderDetails.Update(item)
                total += item.CustomerItem.SellingCost * item.Quantity
            Next
            If total > 0 Then
                context.OrderPrimals.Attach(_currOrd)
                Dim user = _mediator.CurrentUser

                context.Users.Attach(user)
                Dim model = New TransactedOrder With {
                    .TransactedOrderId = "TRORD_" & Guid.NewGuid().ToString().Substring(0, 5),
                    .OrderId = _currOrd.OrderId,
                    .Order = _currOrd,
                    .CashPaid = 10000,
                    .SubTotal = total,
                    .Change = 10000 - total,
                    .DateTransacted = DateTime.Now,
                    .IsFinalized = True,
                    .UserId = user.UserId,
                    .User = user
                }
                While _deletedItemsQueue.Count > 0
                    _mediator.GetUnitOfWork.OrderDetails.Delete(_deletedItemsQueue.Dequeue().OrderDetailsId)
                End While
                _mediator.GetUnitOfWork.TransactedOrder.Add(model)
                _mediator.GetUnitOfWork.SaveChanges()
                MessageBox.Show("Transaction Successful!")
                _view.CurrentItemsFlowPanel.Controls.Clear()
                _currOrd = Nothing
            Else
                MessageBox.Show("There are no Items")
            End If
        End Sub
    End Class

End Namespace