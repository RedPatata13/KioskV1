Public Class SupplierLandingPageView
    Public Property LoginButtonClick As Action
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        LoginButtonClick?.Invoke()
    End Sub
End Class