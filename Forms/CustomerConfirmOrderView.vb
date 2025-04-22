Namespace KioskV0.Forms
    Public Class CustomerConfirmOrderView
        Public Property BackButtonClick As Action
        Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
            BackButtonClick?.Invoke()           
        End Sub

        Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

        End Sub

        Private Sub ViewOrderButton_Click(sender As Object, e As EventArgs) Handles ConfirmOrderButton.Click

        End Sub
    End Class
End Namespace