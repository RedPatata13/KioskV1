Public Class SupplierDashboard
    Public Property LoginButtonClick As Action
    Private Sub Logout_Click(sender As Object, e As EventArgs) 
        LoginButtonClick?.Invoke()
    End Sub
End Class