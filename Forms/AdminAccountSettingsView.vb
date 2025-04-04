Namespace KioskV0.Forms
    Public Class AdminAccountSettingsView
        Public Property AddItemClick As Action
        Public Property AddAccountClick As Action
        Public Property EditInventoryClick As Action

        Private _dgvSource As BindingSource
        Public Property DGV_Source As BindingSource
            Get
                Return _dgvSource
            End Get
            Set(value As BindingSource)
                _dgvSource = value
                AccountsDataGridView.DataSource = _dgvSource
            End Set
        End Property

        'Public ReadOnly Property AccountPanel As FlowLayoutPanel
        '    Get
        '        Return FlowLayoutPanel1
        '    End Get
        'End Property
        Private Sub EditInventory_Click(sender As Object, e As EventArgs) Handles EditInventory.Click
            EditInventoryClick?.Invoke()
        End Sub

        Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
            AddItemClick?.Invoke()
        End Sub

        Private Sub AddUser_Click(sender As Object, e As EventArgs) Handles AddUser.Click
            AddAccountClick?.Invoke()
        End Sub

        Private Sub AddAccountButton_Click(sender As Object, e As EventArgs) Handles AddAccountButton.Click
            AddAccountClick?.Invoke()
        End Sub

        'Private Sub AccountsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AccountsDataGridView.CellContentClick

        'End Sub
    End Class
End Namespace