Namespace KioskV0.Forms
    Public Class SupplierItemsView
        Public Property MenuSearch As Action
        Public Property AddItemClick As Action
        Private Sub SearchMenu_TextChanged(sender As Object, e As EventArgs) Handles SearchMenu.TextChanged
            MenuSearch?.Invoke()
        End Sub

        Private Sub AddSupplyButton_Click(sender As Object, e As EventArgs) Handles AddSupplyButton.Click
            AddItemClick?.Invoke()
        End Sub
    End Class
End Namespace