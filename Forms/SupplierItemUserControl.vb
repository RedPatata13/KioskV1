Namespace KioskV0.Forms
    Public Class SupplierItemUserControl
        Private _currentItem As SupplierItem
        Public Event EditClick()
        Public Sub LoadDetails(item As SupplierItem)
            ItemId.Text = item.Id
            ItemName.Text = item.Name
            ItemDesc.Text = item.Description
        End Sub

        Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
            RaiseEvent EditClick()
        End Sub
    End Class

End Namespace