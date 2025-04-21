Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class StaffCreditSalesViewModel
        Inherits ViewModel(Of Forms.StaffCreditSalesView, StaffKeys)

        Public Sub New(view As StaffCreditSalesView, mediator As Mediator(Of StaffKeys))
            MyBase.New(view, mediator)

            LoadTransactions()
        End Sub

        Private Sub LoadTransactions()
            Dim dgv = _view.TransactionsDataGrid
            dgv.DataSource = Nothing
            dgv.Columns.Clear()
            dgv.AutoGenerateColumns = True
            dgv.ReadOnly = True
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgv.ColumnHeadersHeight = 40
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            _view.DGV_Source = New BindingSource With {.DataSource = _mediator.GetUnitOfWork.TransactedOrder.GetAll()}
        End Sub
    End Class

End Namespace