Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminOrderHistoryViewModel
        Inherits ViewModel(Of Forms.AdminOrderHistoryView, AdminKeys)

        Public Sub New(view As AdminOrderHistoryView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            LoadTable()
        End Sub

        Private Sub LoadTable()
            Dim dgv = _view.OrderHistoryDataGrid
            dgv.DataSource = Nothing
            dgv.Columns.Clear()
            dgv.AutoGenerateColumns = True
            dgv.ReadOnly = True
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgv.ColumnHeadersHeight = 40
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            _view.DGV_Source = New BindingSource With {.DataSource = _mediator.GetOrderList()}
        End Sub
    End Class

End Namespace