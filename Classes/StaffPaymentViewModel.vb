Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class StaffPaymentViewModel
        Inherits ViewModel(Of Forms.StaffPaymentView, StaffKeys)
        Private Property _currTO As TransactedOrder
        Public Sub New(view As StaffPaymentView, mediator As Mediator(Of StaffKeys))
            MyBase.New(view, mediator)

            _view.ReceivedAmountTextChanged = AddressOf ReceivedAmountTextChanged
        End Sub

        Public Sub LoadWithDetails(subTotal As Decimal, pendingAction As Action, model As TransactedOrder)
            _currTO = model
            _mediator.SwapPage(StaffKeys.StaffPayment)
            _view.PayingAmountTextBox.Text = $"{subTotal}"
            Dim amount As Decimal = 0

            _view.SubmitButtonClick = Sub()
                                          Try
                                              amount = Decimal.Parse(_view.ReceivedAmountTextBox.Text)
                                              ' Use the number...
                                          Catch ex As FormatException
                                              MessageBox.Show("Please enter a valid whole number")
                                              Return
                                          Catch ex As OverflowException
                                              MessageBox.Show("Number is too large or too small")
                                              Return
                                          End Try

                                          If amount < subTotal Then
                                              MessageBox.Show("Insufficient Amount")
                                              Return
                                          End If

                                          MessageBox.Show($"{amount} - {subTotal} = {amount - subTotal}")
                                          model.Change = amount - subTotal
                                          model.CashPaid = amount
                                          model.SubTotal = subTotal
                                          pendingAction?.Invoke()
                                          MessageBox.Show("Transaction Successful")
                                          _mediator.SwapPage(StaffKeys.StaffPos)
                                          ResetFields()
                                      End Sub



        End Sub
        Private Sub ReceivedAmountTextChanged()
            Dim amount As Decimal = 0
            Try
                amount = Decimal.Parse(_view.ReceivedAmountTextBox.Text)
                ' Use the number...
            Catch ex As FormatException
                MessageBox.Show("Please enter a valid whole number")
            Catch ex As OverflowException
                MessageBox.Show("Number is too large or too small")
            End Try

            _view.Change.Text = $"{amount - _currTO?.SubTotal}"
        End Sub

        Private Sub ResetFields()
            _view.ReceivedAmountTextBox.Text = ""
            _view.PaymentChoiceCombobox.SelectedIndex = -1
            _view.PayingAmountTextBox.Text = ""
            _view.Change.Text = ""
            _view.NoteTextBox.Text = ""
            _currTO = Nothing

        End Sub
    End Class

End Namespace