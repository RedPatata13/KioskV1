Namespace KioskV0.Forms
    Public Class CustomerNoItemUserControl
        Public Property BackClick As Action
        Private Sub OrderMoreButton_Click(sender As Object, e As EventArgs) Handles OrderMoreButton.Click
            BackClick?.Invoke()
        End Sub
    End Class

End Namespace