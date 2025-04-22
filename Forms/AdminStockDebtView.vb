Public Class AdminStockDebtView
    Public Property ResolveButtonClick As Action
    Public Property ShowResolvedClick As Action
    'Public Property
    Private _dgvSource As BindingSource
    Public Property DGV_Source As BindingSource
        Get
            Return _dgvSource
        End Get
        Set(value As BindingSource)
            _dgvSource = value
            StockDataGrid.DataSource = _dgvSource
        End Set
    End Property
    Public ReadOnly Property SelectedDebt As StockDebt
        Get
            If StockDataGrid.CurrentRow IsNot Nothing Then
                Return CType(StockDataGrid.CurrentRow.DataBoundItem, StockDebt)
            Else
                Return Nothing
            End If
        End Get
    End Property

    Private Sub ViewChangesButton_Click(sender As Object, e As EventArgs) Handles ResolvedButton.Click
        ResolveButtonClick?.Invoke()
    End Sub

    Private Sub ShowResolved_Click(sender As Object, e As EventArgs) Handles ShowResolved.Click
        ShowResolvedClick?.Invoke()
    End Sub
End Class