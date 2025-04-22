Namespace KioskV0.Forms
    Public Class SupplierItemsView
        Public Property MenuSearch As Action
        Private Sub SearchMenu_TextChanged(sender As Object, e As EventArgs) Handles SearchMenu.TextChanged
            MenuSearch?.Invoke()
        End Sub
    End Class
End Namespace