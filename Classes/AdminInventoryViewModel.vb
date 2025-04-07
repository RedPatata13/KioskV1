Imports Autofac
Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Services

Namespace KioskV0.Classes
    Public Class AdminInventoryViewModel
        Inherits ViewModel(Of Forms.AdminInventoryView, AdminKeys)

        Public Sub New(view As AdminInventoryView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

            _view.RequestSupplyButtonClick = Sub() _mediator.SwapPage(AdminKeys.AdminSupplyRequest)
        End Sub

        Public Overrides Sub Project(form As Form)
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

            Dim container As IContainer = ContainerConfiguration.ConfigureContainer()
            Dim adminService = container.Resolve(Of AdminService)()

            _view.DGV_Source = New BindingSource With {.DataSource = adminService.GetAllInventories()}
        End Sub
    End Class
End Namespace
