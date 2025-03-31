Namespace KioskV0.Forms
    Public Class AdminAccountSettingsView
        Public Property AddItemClick As Action
        Public Property AddAccountClick As Action

        Public Property EditInventoryClick As Action

        Private Sub EditInventory_Click(sender As Object, e As EventArgs) Handles EditInventory.Click
            EditInventoryClick?.Invoke()
        End Sub

        Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
            AddItemClick?.Invoke()
        End Sub

        Private Sub AddUser_Click(sender As Object, e As EventArgs) Handles AddUser.Click
            AddAccountClick?.Invoke()
        End Sub
    End Class
End Namespace