Namespace KioskV0.Forms
    Public Class AdminInventoryView
        Public Property EditInventoryClick As Action
        Private Sub RequestSupplyButton_Click(sender As Object, e As EventArgs) Handles RequestSupplyButton.Click
            EditInventoryClick?.Invoke()
        End Sub
    End Class
End Namespace