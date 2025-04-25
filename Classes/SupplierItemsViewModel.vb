Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes
Namespace KioskV0.Classes
    Public Class SupplierItemsViewModel
        Inherits ViewModel(Of Forms.SupplierItemsView, SupplierKeys)

        Public Sub New(view As Forms.SupplierItemsView, mediator As Mediator(Of SupplierKeys))
            MyBase.New(view, mediator)

            AddHandler _view.SupplierItemsDataGridView.CellDoubleClick, AddressOf DataGridView_CellDoubleClick
        End Sub

        Public Sub LoadSupplierItems()
            Dim dgv = _view.SupplierItemsDataGridView
            dgv.DataSource = Nothing
            dgv.Columns.Clear()
            dgv.AutoGenerateColumns = True
            dgv.ReadOnly = True
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgv.ColumnHeadersHeight = 40
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            ' Get the list of SupplierItem from the mediator
            Dim itemList As List(Of SupplierItem) = _mediator.GetSupplierItemList()

            _view.DGVSource = New BindingSource With {.DataSource = itemList}
            dgv.DataSource = _view.DGVSource
        End Sub

        Private Sub DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
            If e.RowIndex >= 0 Then
                OpenDetailsView(e.RowIndex)
            End If
        End Sub

        Private Sub OpenDetailsView(rowIndex As Integer)
            Try
                Dim selectedItem As SupplierItem = DirectCast(_view.DGVSource.Item(rowIndex), SupplierItem)

                ' Instantiate the view and viewmodel for the detail view
                Dim detailView As New SupplierItemDetailView()
                Dim detailViewModel As New SupplierItemDetailVM(detailView, _mediator)

                ' Load the selected item into the detail view
                detailViewModel.LoadItem(selectedItem)

                ' Project the detail view (display it)
                _mediator.SwapPage(SupplierKeys.SupplierItemDetails)

            Catch ex As Exception
                MessageBox.Show("Error opening details view: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace