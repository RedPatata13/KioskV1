Public Class SupplierDashboardView
    Public Property SwitchPendingCompleteButtonClick As Action

    Private Sub SwitchPendingCompleteButton_Click(sender As Object, e As EventArgs) Handles SwitchPendingCompleteButton.Click
        SwitchPendingCompleteButtonClick?.Invoke()
    End Sub
End Class