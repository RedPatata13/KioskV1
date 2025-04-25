Namespace KioskV0.Forms
    Public Class StaffCreditSalesView
        Private _dgvSource As BindingSource
        Public Property DGV_Source As BindingSource
            Get
                Return _dgvSource
            End Get
            Set(value As BindingSource)
                _dgvSource = value
                TransactionsDataGrid.DataSource = _dgvSource
            End Set
        End Property

        Private Sub TransactionsDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionsDataGrid.CellContentClick

        End Sub
    End Class
End Namespace