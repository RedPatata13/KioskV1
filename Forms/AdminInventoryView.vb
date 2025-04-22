Namespace KioskV0.Forms
    Public Class AdminInventoryView
        Public Property RequestSupplyButtonClick As Action
        Public Property ViewDeductionsClick As Action

        Private _dgvSource As BindingSource
        Public Property DGV_Source As BindingSource
            Get
                Return _dgvSource
            End Get
            Set(value As BindingSource)
                _dgvSource = value
                InventoryDataGrid.DataSource = _dgvSource
            End Set
        End Property
        Public ReadOnly Property SelectedBatch As InventoryBatch
            Get
                If InventoryDataGrid.CurrentRow IsNot Nothing Then
                    ' Retrieve the currently selected model
                    Return CType(InventoryDataGrid.CurrentRow.DataBoundItem, InventoryBatch)
                Else
                    Throw New Exception("No Row is selected")
                End If
            End Get
        End Property

        Private Sub RequestSupplyButton_Click(sender As Object, e As EventArgs) Handles RequestSupplyButton.Click
            RequestSupplyButtonClick?.Invoke()
        End Sub

        Private Sub ViewChangesButton_Click(sender As Object, e As EventArgs) Handles ViewChangesButton.Click
            ViewDeductionsClick?.Invoke()
        End Sub
    End Class
End Namespace
