Namespace KioskV0.Forms
    Public Class AdminSidebar
        Public Property AccountButtonClick As Action

        Public Sub AccountButton_Click(sender As Object, e As EventArgs) Handles AccountsButton.Click
            AccountButtonClick?.Invoke()
        End Sub
    End Class

End Namespace