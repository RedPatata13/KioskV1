Public Class SupplierSidebar
    Public Property DashboardClick As Action
    Public Property SupplierItems As Action
    Public Property LogoutClick As Action
    Public Property BatchRequestsClick As Action

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        DashboardClick?.Invoke()
    End Sub

    Private Sub InventoryButton_Click(sender As Object, e As EventArgs) Handles InventoryButton.Click
        SupplierItems?.Invoke()
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        LogoutClick?.Invoke()
    End Sub

    Private Sub BatchRequests_Click(sender As Object, e As EventArgs) Handles BatchRequests.Click
        BatchRequestsClick?.Invoke()
    End Sub
End Class