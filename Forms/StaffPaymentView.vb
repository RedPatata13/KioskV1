Namespace KioskV0.Forms
    Public Class StaffPaymentView
        Public Property SubmitButtonClick As Action
        Public Property ReceivedAmountTextChanged As Action
        Private Sub SubmitPaymentButton_Click(sender As Object, e As EventArgs) Handles SubmitPaymentButton.Click
            SubmitButtonClick?.Invoke()
        End Sub

        Private Sub ReceivedAmountTextBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles ReceivedAmountTextBox.KeyPress
            If Char.IsControl(e.KeyChar) Then Exit Sub

            If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
                e.Handled = True
            End If

            If e.KeyChar = "."c AndAlso ReceivedAmountTextBox.Text.Contains(".") Then
                e.Handled = True
            End If
        End Sub

        Private Sub ReceivedAmountTextBox_TextChanged(sender As Object, e As EventArgs) Handles ReceivedAmountTextBox.TextChanged, ReceivedAmountTextBox.KeyPress
            ReceivedAmountTextChanged?.Invoke()
        End Sub
    End Class
End Namespace