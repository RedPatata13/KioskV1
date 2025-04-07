Imports Autofac
Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Services

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

            Dim container As IContainer = ContainerConfiguration.ConfigureContainer()
            Dim adminService = container.Resolve(Of AdminService)()
            _view.DGV_Source = New BindingSource With {.DataSource = adminService.GetAllOrders()}
        End Sub
    End Class

End Namespace