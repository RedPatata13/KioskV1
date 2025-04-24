Public Class SupplierAdminBatchReqView
    Private _dgvSource As BindingSource

    Public Property MainAction As Action
    Public Property ViewAction As Action
    Public Property DGV_Source As BindingSource
        Get
            Return _dgvSource
        End Get
        Set(value As BindingSource)
            _dgvSource = value
            BR_Grid.DataSource = _dgvSource
        End Set
    End Property
    Public ReadOnly Property SelectedRequest As BatchRequest
        Get
            If BR_Grid.CurrentRow IsNot Nothing Then
                Return CType(BR_Grid.CurrentRow.DataBoundItem, BatchRequest)
            Else
                Throw New Exception("No Row is selected")
            End If
        End Get
    End Property
    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles ActionButton.Click
        MainAction?.Invoke()
    End Sub

    Private Sub ViewModeButton_Click(sender As Object, e As EventArgs) Handles ViewModeButton.Click
        ViewAction?.Invoke()
    End Sub
End Class