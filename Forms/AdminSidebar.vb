Namespace KioskV0.Forms
    Public Class AdminSidebar
        Public Property AccountButtonClick As Action
        Public Property DashboardButtonClick As Action
        Public Property MenuButtonClick As Action

        Public Sub AccountButton_Click(sender As Object, e As EventArgs) Handles AccountsButton.Click
            AccountButtonClick?.Invoke()
        End Sub

        Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
            DashboardButtonClick?.Invoke()
        End Sub

        Private Sub MenuListButton_Click(sender As Object, e As EventArgs) Handles MenuListButton.Click
            MenuButtonClick?.Invoke()
        End Sub
    End Class

End Namespace