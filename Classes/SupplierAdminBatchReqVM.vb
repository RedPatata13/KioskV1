Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class SupplierAdminBatchReqVM
        Inherits ViewModel(Of SupplierAdminBatchReqView, SupplierKeys)

        Public Sub New(view As SupplierAdminBatchReqView, mediator As Mediator(Of SupplierKeys))
            MyBase.New(view, mediator)
        End Sub

        Public Sub LoadBatchRequests()
            Dim dgv = _view.BatchRequestDataGridView
            dgv.DataSource = Nothing
            dgv.Columns.Clear()
            dgv.AutoGenerateColumns = False
            dgv.ReadOnly = True
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgv.ColumnHeadersHeight = 40
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            ' Example data source
            Dim requestList As List(Of BatchRequest) = _mediator.GetBatchRequestList() ' You implement this

            ' Bind to a projected list with only the fields we want to show
            Dim displayList = requestList.Select(Function(r) New With {
                Key .RequestID = r.RequestID,
                Key .Message = r.RequestMSG,
                Key .RequesterName = If(r.Requester IsNot Nothing, r.Requester, r.RequesterID),
                Key .ItemName = If(r.Item IsNot Nothing, r.Item.Name, r.ItemID),
                Key .DateRequested = r.DateRequested.ToString("yyyy-MM-dd"),
                Key .Units = r.Units,
                Key .Approved = If(r.IsApproved, "Yes", "No")
            }).ToList()

            _view.DGV_Source = New BindingSource With {.DataSource = displayList}
            dgv.DataSource = _view.DGV_Source
        End Sub

    End Class

End Namespace