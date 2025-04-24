Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes

Public Class SupplierItemsViewModel
    Inherits ViewModel(Of Forms.SupplierItemsView, SupplierKeys)


    Public Sub New(view As Forms.SupplierItemsView, mediator As Mediator(Of SupplierKeys))
        MyBase.New(view, mediator)
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

        ' Example: get the list of SupplierItem from the mediator
        Dim itemList As List(Of SupplierItem) = _mediator.GetSupplierItemList() ' You must implement this

        _view.DGV_Source = New BindingSource With {.DataSource = itemList}
        dgv.DataSource = _view.DGV_Source
    End Sub


End Class
