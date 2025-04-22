Namespace KioskV0.Forms
    Public Class SupplierItemUserControl
        Private _currentItem As SupplierItem
        Public Property EditClick As Action
        Public Property DeleteClick As Action
        Public Sub LoadDetails(item As SupplierItem)
            ItemId.Text = item.Id
            ItemName.Text = item.Name
            ItemDesc.Text = item.Description
        End Sub

        Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
            EditClick?.Invoke()
        End Sub

        Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
            DeleteClick?.Invoke()
        End Sub
    End Class

End Namespace