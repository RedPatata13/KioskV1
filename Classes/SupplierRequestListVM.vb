Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes

Public Class SupplierRequestListVM
    Inherits KioskV0.Classes.ViewModel(Of SupplierAdminBatchReqView, SupplierKeys)
    Private Property Loaded As Boolean = False
    Public Sub New(view As SupplierAdminBatchReqView, mediator As Mediator(Of SupplierKeys))
        MyBase.New(view, mediator)

        SetDGV()
        SetEvents()
    End Sub

    Public Overrides Sub Project(projector As Form)
        If Not Loaded Then
            MyBase.Project(projector)
            ResizeComponents(_mediator.GetProjectorPanelSize())
        End If
        MyBase.Project(projector)
        SetDGVPending()
    End Sub
    Protected Friend Overrides Sub SetEvents()
        MyBase.SetEvents()

        _view.MainAction = AddressOf ApproveAction
        _view.ViewAction = AddressOf SetDGVPending
    End Sub
    Private Sub SetDGV()
        SetDGVPending()
        Dim dgv = _view.BR_Grid
        dgv.DataSource = Nothing
        dgv.Columns.Clear()
        dgv.AutoGenerateColumns = True
        dgv.ReadOnly = True
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ColumnHeadersHeight = 40
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        SetDGVPending()
    End Sub

    Private Sub SetDGVPending()
        _view.BR_Grid.Rows.Clear()
        _view.DGV_Source = New BindingSource With {.DataSource = _mediator.GetUnitOfWork.BatchRequests.GetAll().Where(Function(s) s.IsPending)}
        _view.ViewModeButton.Text = "View Previous"
        _view.ViewAction = Sub() SetDGVFinalized()
        _view.MainAction = Sub() ApproveAction()
        _view.ActionButton.Enabled = True
        'MessageBox.Show("this works")
    End Sub

    Private Sub SetDGVFinalized()
        _view.BR_Grid.Rows.Clear()
        _view.DGV_Source = New BindingSource With {.DataSource = _mediator.GetUnitOfWork.BatchRequests.GetAll().Where(Function(s) Not s.IsPending)}
        _view.ViewModeButton.Text = "View Pending"
        _view.ViewAction = Sub() SetDGVPending()
        _view.ActionButton.Enabled = False
    End Sub

    Private Sub ApproveAction()
        Dim vm = DirectCast(_mediator.GetVM(SupplierKeys.SupplierAssessRequest), SupplierRequestBatchVM)
        vm.LoadAsEdit(_view.SelectedRequest)
    End Sub

    Private Sub EditAction()
        MessageBox.Show("Action is now to disabled")
    End Sub
End Class
