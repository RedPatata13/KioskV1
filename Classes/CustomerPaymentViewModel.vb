Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class CustomerPaymentViewModel
        Inherits ViewModel(Of Forms.CustomerPaymentView, CustomerKeys)
        Public Property CurrentOrderNumber As String


        Public Sub New(view As CustomerPaymentView, mediator As Mediator(Of CustomerKeys))
            MyBase.New(view, mediator)

            AddHandler _view.PayButton.Click, Sub() ShowOrderNumber()

        End Sub

        Private Sub ShowOrderNumber()
            Dim ordernumUC As New CustomerInvoiceUserControl()
            ordernumUC.Dock = DockStyle.Fill
            ordernumUC.SetOrderNumber(CurrentOrderNumber)
            'print
            AddHandler ordernumUC.ReturnToMenuClick, Sub()
                                                         Dim menuVM = DirectCast(_mediator.GetVM(CustomerKeys.CustomerMenu), CustomerMenuViewModel)
                                                         menuVM.ResetView()

                                                         _mediator.SwapPage(CustomerKeys.CustomerMenu)
                                                     End Sub
            _view.Controls.Clear()
            _view.Controls.Add(ordernumUC)
            ordernumUC.BringToFront()
        End Sub

    End Class

End Namespace