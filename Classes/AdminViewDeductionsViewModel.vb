Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes

Public Class AdminViewDeductionsViewModel
    Inherits ViewModel(Of AdminViewDeductionsView, KioskV0.AdminKeys)
    Private Property Loaded As Boolean = False
    Public Sub New(view As AdminViewDeductionsView, mediator As Mediator(Of AdminKeys))
        MyBase.New(view, mediator)

        SetEvents()
    End Sub
    Protected Friend Overrides Sub SetEvents()
        MyBase.SetEvents()

        _view.BackClick = Sub() _mediator.SwapPage(AdminKeys.AdminInventory)
        _view.SelectedClick = Sub() Loadgenerate
    End Sub
    Public Overrides Sub Project(projector As Form)
        If Not Loaded Then
            MyBase.Project(projector)
            ResizeComponents(_mediator.GetProjectorPanelSize())
        End If

        Loaded = True
        MyBase.Project(projector)
    End Sub

    Public Sub LoadBatchDeductions(batch As InventoryBatch)
        PrepareDataGridView()
        Dim list = _mediator.GetUnitOfWork().Deductions.GetDeductorOfBatch(batch.BatchId)
        _view.DGV_Source = New BindingSource With {.DataSource = list}

        _mediator.SwapPage(AdminKeys.AdminViewDeductions)
    End Sub
    Private Sub PrepareDataGridView()
        Dim dgv = _view.Grid
        dgv.DataSource = Nothing
        dgv.Columns.Clear()
        dgv.AutoGenerateColumns = True
        dgv.ReadOnly = True
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ColumnHeadersHeight = 40
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        '_view.DGV_Source = New BindingSource With {.DataSource = _mediator.GetUnitOfWork.InventoryBatches.GetAll()}
    End Sub

    Private Sub Loadgenerate()
        Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminStockDebtCRUD), AdminStockDebtCRUDViewModel)
        vm.LoadAsCreate(_view.SelectedDeduction)
    End Sub
End Class
