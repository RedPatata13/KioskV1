Imports KioskV0.KioskV0.Forms
Imports LiveCharts

Namespace KioskV0.Classes
    Public Class StaffPosViewModel
        Inherits ViewModel(Of Forms.StaffPosView, StaffKeys)
        Private Property _currOrd As OrderPrimal = Nothing
        Private Property Cart As New Dictionary(Of String, AdminItem)
        Private Property DontAskAgain As Boolean = False
        Public Sub New(view As StaffPosView, mediator As Mediator(Of StaffKeys))
            MyBase.New(view, mediator)

            TempOrder()
        End Sub

        Private Sub TempOrder()
            Dim order = _mediator.GetUnitOfWork.Orders.GetById("395f1b8e-1")
            If order Is Nothing Then Throw New Exception("Order not found")

            For Each item In order.OrderItems
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
    End Class

End Namespace