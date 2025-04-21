Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminAccountSettingsViewModel
        Inherits ViewModel(Of Forms.AdminAccountSettingsView, AdminKeys)
        Private Property Loaded As Boolean = False
        Public Sub New(view As AdminAccountSettingsView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

            SetEvents()
        End Sub
        Public Overrides Sub Project(projector As Form)
            If Not Loaded Then
                MyBase.Project(projector)
                ResizeComponents(_mediator.GetProjectorPanelSize())
            End If
            MyBase.Project(projector)
            _mediator.LayoutAction(Sub() LoadAccounts())
        End Sub
        Public Sub LoadAccounts()
            Dim dgv = _view.AccountsDataGridView
            dgv.DataSource = Nothing
            dgv.Columns.Clear()
            dgv.AutoGenerateColumns = True
            dgv.ReadOnly = True
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgv.ColumnHeadersHeight = 40
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            _view.DGV_Source = New BindingSource With {.DataSource = _mediator.GetUserList()}
        End Sub
        Protected Friend Overrides Sub SetEvents()
            _view.EditUserClick = AddressOf EditUser
            _view.AddAccountClick = Sub() _mediator.SwapPage(AdminKeys.AdminAddUser)
            _view.SearchBarTextChanged = AddressOf SearchBarTextChanged
        End Sub
        Private Sub EditUser()
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminAddUser), AdminEditUserViewModel)
            vm.LoadAsEdit(_view.SelectedUser)
        End Sub

        Private Sub SearchBarTextChanged()
            Try
                Dim searchTerm As String = If(_view.SearchUser.Text?.Trim(), String.Empty)

                Dim userList = _mediator.GetUserList()

                If String.IsNullOrEmpty(searchTerm) Then
                    _view.DGV_Source = New BindingSource With {.DataSource = userList}
                    Return
                End If

                Dim filteredUsers = userList.Where(
            Function(u)
                Return (u.Username IsNot Nothing AndAlso u.Username.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0) Or
                       (u.UserId IsNot Nothing AndAlso u.UserId.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0) Or
                       (u.FirstName IsNot Nothing AndAlso u.FirstName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0) Or
                       (u.LastName IsNot Nothing AndAlso u.LastName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
            End Function)


                _view.DGV_Source = New BindingSource With {.DataSource = filteredUsers.ToList()}

            Catch ex As Exception

                MessageBox.Show("An error occurred while searching: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                _view.DGV_Source = New BindingSource With {.DataSource = _mediator.GetUserList()}
            End Try
        End Sub
    End Class

End Namespace