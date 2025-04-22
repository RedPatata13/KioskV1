Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminInventoryViewModel
        Inherits ViewModel(Of Forms.AdminInventoryView, AdminKeys)
        Private Property Loaded As Boolean = False
        Public Sub New(view As AdminInventoryView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

            SetEvents()
        End Sub

        Public Overrides Sub Project(form As Form)
            If Not Loaded Then
                MyBase.Project(form)
                ResizeComponents(_mediator.GetProjectorPanelSize())
            End If

            _mediator.AddAction(Sub() PrepareDataGridView())
            _mediator.AddAction(Sub() MyBase.Project(form))
            _mediator.InvokeAllAction()
        End Sub

        Private Sub PrepareDataGridView()
            Dim dgv = _view.InventoryDataGrid
            dgv.DataSource = Nothing
            dgv.Columns.Clear()
            dgv.AutoGenerateColumns = True
            dgv.ReadOnly = True
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgv.ColumnHeadersHeight = 40
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            _view.DGV_Source = New BindingSource With {.DataSource = _mediator.GetUnitOfWork.InventoryBatches.GetAll()}
        End Sub

        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()
            _view.RequestSupplyButtonClick = Sub() _mediator.SwapPage(AdminKeys.AdminSupplyRequest)
            _view.ViewDeductionsClick = Sub() SwapToDeductions()
        End Sub

        Private Sub SwapToDeductions()
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminViewDeductions), AdminViewDeductionsViewModel)
            vm.LoadBatchDeductions(_view.SelectedBatch)
        End Sub
    End Class
End Namespace
