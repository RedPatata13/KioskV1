Imports System.ComponentModel.DataAnnotations

Namespace KioskV0.Forms
    Public Class AdminAccountSettingsView
        Public Property AddAccountClick As Action
        Public Property EditUserClick As Action

        Private _dgvSource As BindingSource
        Public Property DGV_Source As BindingSource
            Get
                Return _dgvSource
            End Get
            Set(value As BindingSource)
                _dgvSource = value
                SetupDataGridViewColumns()
                AccountsDataGridView.DataSource = _dgvSource
            End Set
        End Property
        Public ReadOnly Property SelectedUser As User
            Get
                If AccountsDataGridView.CurrentRow IsNot Nothing Then
                    ' Retrieve the currently selected model
                    Return CType(AccountsDataGridView.CurrentRow.DataBoundItem, User)
                Else
                    Throw New Exception("No Row is selected")
                End If
            End Get
        End Property

        Private Sub SetupDataGridViewColumns()
            AccountsDataGridView.AutoGenerateColumns = False
            AccountsDataGridView.Columns.Clear()

            Dim props = GetType(User).GetProperties()
            For Each prop In props
                ' Skip UserId from being added as a column
                If prop.Name = "UserId" OrElse prop.Name = "CreatedAt" OrElse prop.Name = "PasswordHash" Then
                    Continue For
                End If

                Dim displayAttr = prop.GetCustomAttributes(GetType(DisplayAttribute), False).FirstOrDefault()
                Dim headerText As String = If(displayAttr IsNot Nothing,
                                              DirectCast(displayAttr, DisplayAttribute).Name,
                                              prop.Name)

                Dim col As New DataGridViewTextBoxColumn() With {
                    .DataPropertyName = prop.Name,
                    .HeaderText = headerText,
                    .Name = prop.Name,
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                }

                AccountsDataGridView.Columns.Add(col)
            Next

        End Sub

        Private Sub AddAccountButton_Click(sender As Object, e As EventArgs) Handles AddAccountButton.Click
            AddAccountClick?.Invoke()
        End Sub

        'Private Sub AccountsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AccountsDataGridView.CellContentClick

        'End Sub
        Private Sub AccountsDataGridView_Enter(sender As Object, e As EventArgs) Handles AccountsDataGridView.Enter
            _editUser.Enabled = (AccountsDataGridView.CurrentRow IsNot Nothing)
        End Sub

        Private Sub AccountsDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles AccountsDataGridView.SelectionChanged
            _editUser.Enabled = (AccountsDataGridView.CurrentRow IsNot Nothing)
        End Sub

        Private Sub AccountsDataGridView_Leave(sender As Object, e As EventArgs) Handles AccountsDataGridView.Leave
            _editUser.Enabled = False
        End Sub

        Private Sub _editUser_Click(sender As Object, e As EventArgs) Handles _editUser.Click
            EditUserClick?.Invoke()
        End Sub
    End Class
End Namespace