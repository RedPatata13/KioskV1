Namespace KioskV0.Forms
    Public Class SupplierSidebar
        Public Property RequestsClick As Action
        Public Property SupplierItems As Action
        Public Property TransactionClick As Action
        Public Property LogoutClick As Action

        Private Sub RequestsButton_Click(sender As Object, e As EventArgs) Handles RequestsButton.Click
            RequestsClick?.Invoke()

        End Sub
        Private Sub TransacHistoryButton_Click(sender As Object, e As EventArgs) Handles TransacHistoryButton.Click
            TransactionClick?.Invoke()
        End Sub

        Private Sub ItemsButton_Click(sender As Object, e As EventArgs) Handles ItemsButton.Click
            SupplierItems?.Invoke()
        End Sub

        Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
            LogoutClick?.Invoke()
        End Sub
    End Class
End Namespace