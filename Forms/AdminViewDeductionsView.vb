Public Class AdminViewDeductionsView
    Public Property SelectedClick As Action
    Public Property BackClick As Action
    Private _dgvSource As BindingSource
    Public Property DGV_Source As BindingSource
        Get
            Return _dgvSource
        End Get
        Set(value As BindingSource)
            _dgvSource = value
            Grid.DataSource = _dgvSource
        End Set
    End Property
    Public ReadOnly Property SelectedDeduction As ItemToBatchDeduction
        Get
            If Grid.CurrentRow IsNot Nothing Then
                ' Retrieve the currently selected model
                Return CType(Grid.CurrentRow.DataBoundItem, ItemToBatchDeduction)
            Else
                Throw New Exception("No Row is selected")
            End If
        End Get
    End Property
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles SetSelected.Click
        SelectedClick?.Invoke()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        BackClick?.Invoke()
    End Sub
End Class