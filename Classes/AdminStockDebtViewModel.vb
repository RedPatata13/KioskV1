Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes

Public Class AdminStockDebtViewModel
    Inherits ViewModel(Of AdminStockDebtView, KioskV0.AdminKeys)
    Private Property Loaded As Boolean = False
    Public Property _staged As AdminItem
    Public Sub New(view As AdminStockDebtView, mediator As Mediator(Of KioskV0.AdminKeys))
        MyBase.New(view, mediator)

        SetEvents()
    End Sub
    Protected Friend Overrides Sub SetEvents()
        MyBase.SetEvents()

        '_view.BackClick = Sub() _mediator.SwapPage(AdminKeys.AdminInventory)
        PrepareDataGridView()
        _view.ResolveButtonClick = AddressOf LoadAsEdit
        _view.ShowResolvedClick = AddressOf PopulateDGVResolved
    End Sub

    Private Sub LoadAsEdit()
        If _view.SelectedDebt Is Nothing Then
            MessageBox.Show("No debt is selected")
            Return
        End If
        Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminResolveStockDebt), AdminResolveStockDebtViewModel)
        vm.LoadAsEdit(_view.SelectedDebt)
    End Sub
    Public Overrides Sub Project(projector As Form)
        If Not Loaded Then
            MyBase.Project(projector)
            ResizeComponents(_mediator.GetProjectorPanelSize())
        End If

        Loaded = True
        MyBase.Project(projector)
        PopulateDGVUnresolved()
    End Sub

    Public Sub LoadBatchDeductions()
        PrepareDataGridView()
        'Dim list = _mediator.GetUnitOfWork().Deductions.GetDeductorOfBatch(batch.BatchId)
        ''_view.DGV_Source = New BindingSource With {.DataSource = list}

        _mediator.SwapPage(AdminKeys.AdminViewDeductions)
    End Sub
    Private Sub PrepareDataGridView()
        Dim dgv = _view.StockDataGrid
        dgv.DataSource = Nothing
        dgv.Columns.Clear()
        dgv.AutoGenerateColumns = True
        dgv.ReadOnly = True
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ColumnHeadersHeight = 40
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        PopulateDGVUnresolved()
    End Sub

    Private Sub PopulateDGVUnresolved()
        _view.StockDataGrid.Columns.Clear()
        Dim list = _mediator.GetUnitOfWork.StockDebts.GetAllUnresolved()
        _view.DGV_Source = New BindingSource With {.DataSource = list}
        Dim msg = $"There are {list.Count} stock debts unresolved!"
        _view.UnresolvedCount.Text = msg

        _view.ShowResolvedClick = AddressOf PopulateDGVResolved
        _view.ShowResolved.Text = "Show all resolved"
        _view.ResolvedButton.Enabled = True
    End Sub

    Private Sub PopulateDGVResolved()
        _view.StockDataGrid.Columns.Clear()
        Dim list = _mediator.GetUnitOfWork.StockDebts.GetAllResolved()
        _view.DGV_Source = New BindingSource With {.DataSource = list}
        Dim msg = $"There are {list.Count} stock debts resolved!"
        _view.UnresolvedCount.Text = msg

        _view.ShowResolvedClick = AddressOf PopulateDGVUnresolved
        _view.ResolvedButton.Enabled = False
        _view.ShowResolved.Text = "Show all unresolved"
    End Sub
End Class
