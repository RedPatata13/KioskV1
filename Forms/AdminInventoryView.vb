Namespace KioskV0.Forms
    Public Class AdminInventoryView
        Public Property RequestSupplyButtonClick As Action

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

        Private Sub RequestSupplyButton_Click(sender As Object, e As EventArgs) Handles RequestSupplyButton.Click
            RequestSupplyButtonClick?.Invoke()
        End Sub
    End Class
End Namespace
