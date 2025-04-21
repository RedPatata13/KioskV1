Namespace KioskV0.Forms
    Public Class CustomerConfirmOrderView
        Public Property BackButtonClick As Action
        Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
            BackButtonClick?.Invoke()           
        End Sub
    End Class
End Namespace