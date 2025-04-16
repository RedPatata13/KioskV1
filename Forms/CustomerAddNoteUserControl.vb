Namespace KioskV0.Forms
    Public Class CustomerAddNoteUserControl
        Public Property BackClick As Action

        Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
            BackClick?.Invoke()
        End Sub
    End Class

End Namespace