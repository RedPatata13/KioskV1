Public Class AdminMenuSelectSupplierItemView
    Public Property SelectButtonClick As Action
    Public Property CancelButtonCLick As Action
    Public Property CellClickAction As Action
    Private _dgvSource As BindingSource
    Public Property DGV_Source As BindingSource
        Get
            Return _dgvSource
        End Get
        Set(value As BindingSource)
            _dgvSource = value
            BatchSelectionGrid.DataSource = _dgvSource
        End Set
    End Property

    Public ReadOnly Property SelectedItem As InventoryBatch
        Get
            If BatchSelectionGrid.CurrentRow IsNot Nothing Then
                ' Retrieve the currently selected model
                Return CType(BatchSelectionGrid.CurrentRow.DataBoundItem, InventoryBatch)
            Else
                Throw New Exception("No Row is selected")
            End If
        End Get
    End Property

    Private Sub BatchSelectionGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BatchSelectionGrid.CellContentClick
        CellClickAction?.Invoke()
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        SelectButtonClick?.Invoke()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        CancelButtonCLick?.Invoke()
    End Sub
End Class