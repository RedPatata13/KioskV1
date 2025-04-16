Namespace KioskV0.Forms
    Public Class StaffPosView
        Public Property PayButtonClick As Action
        Public Property OrderTextBoxTextchanged As Action
        Public Property Cart As Dictionary(Of String, AdminItem)
        Private Property Property1

        Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click
            PayButtonClick?.Invoke()
        End Sub

        Private Sub SearchOrderTextbox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles SearchOrderTextbox.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                OrderTextBoxTextchanged?.Invoke()
            End If
        End Sub
    End Class
End Namespace