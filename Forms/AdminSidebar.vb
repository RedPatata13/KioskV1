Namespace KioskV0.Forms
    Public Class AdminSidebar
        Public Property AccountButtonClick As Action
        Public Property DashboardButtonClick As Action
        Public Property InventoryButtonClick As Action
        Public Property OrderHistoryButtonClick As Action
        Public Property StaffTransactionButtonClick As Action
        Public Property MenuButtonClick As Action
        Public Property LogoutButtonClick As Action


        Public Sub AccountButton_Click(sender As Object, e As EventArgs) Handles AccountsButton.Click
            AccountButtonClick?.Invoke()
        End Sub

        Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
            DashboardButtonClick?.Invoke()
        End Sub

        Private Sub MenuListButton_Click(sender As Object, e As EventArgs) Handles MenuListButton.Click
            MenuButtonClick?.Invoke()
        End Sub

        Private Sub InventoryButton_Click(sender As Object, e As EventArgs) Handles InventoryButton.Click
            InventoryButtonClick?.Invoke()
        End Sub

        Private Sub StaffTransacButton_Click(sender As Object, e As EventArgs) Handles StaffTransacButton.Click
            StaffTransactionButtonClick?.Invoke()
        End Sub

        Private Sub OrderHistoryButton_Click(sender As Object, e As EventArgs) Handles OrderHistoryButton.Click
            OrderHistoryButtonClick?.Invoke()
        End Sub

        Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
            LogoutButtonClick?.Invoke()
        End Sub
    End Class

End Namespace