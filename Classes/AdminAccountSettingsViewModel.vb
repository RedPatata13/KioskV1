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
        End Sub
        Private Sub EditUser()
            'MessageBox.Show($"Selected: {_view.SelectedUser.UserName}")
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminAddUser), AdminEditUserViewModel)
            vm.LoadAsEdit(_view.SelectedUser)

        End Sub
    End Class

End Namespace