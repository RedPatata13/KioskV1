Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class CustomerPaymentViewModel
        Inherits ViewModel(Of Forms.CustomerPaymentView, CustomerKeys)
        Public Property CurrentOrderNumber As String

        'yung naka comment here yung mag gegenerate ng 2 digit sana
        'Private Property IsOrderNumberGenerated As Boolean = False

        Public Sub New(view As CustomerPaymentView, mediator As Mediator(Of CustomerKeys))
            MyBase.New(view, mediator)
            AddHandler _view.PayButton.Click, Sub() ShowOrderNumber()

        End Sub

        'Public Function GenerateOrderNumber() As String
        '    ' ' Use a short random number along with a prefix
        '    Dim randomNum As Integer = New Random().Next(10, 99) ' Random 2-digit number
        '    Return randomNum.ToString()
        'End Function

        Private Sub ShowOrderNumber()

            'If Not IsOrderNumberGenerated Then
            '    CurrentOrderNumber = GenerateOrderNumber()
            '    IsOrderNumberGenerated = True ' Mark that the order number is generated
            'End If

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