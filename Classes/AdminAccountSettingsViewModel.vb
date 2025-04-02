Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminAccountSettingsViewModel
        Inherits ViewModel(Of Forms.AdminAccountSettingsView, AdminKeys)

        Public Sub New(view As AdminAccountSettingsView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

            SetEvents()
        End Sub

        Protected Friend Overrides Sub SetEvents()
            _view.AddAccountClick = AddressOf AddUserClick
            _view.EditInventoryClick = AddressOf EditInventoryClick
            _view.AddItemClick = AddressOf AddItemClick
        End Sub

        Private Sub EditInventoryClick()
            _mediator.SwapPage(AdminKeys.AdminEditInventory)
        End Sub

        Private Sub AddUserClick()
            _mediator.SwapPage(AdminKeys.AdminAddUser)
        End Sub

        Private Sub AddItemClick()
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminEditMenuDetails), AdminEditMenuDetailsViewModel)
            vm.Previous = AdminKeys.AdminAccountSettings
            _mediator.SwapPage(AdminKeys.AdminEditMenuDetails)
        End Sub

    End Class

End Namespace