Namespace KioskV0.Classes
    Public Class AdminSideBarViewModel
        Inherits ViewModel(Of Forms.AdminSidebar, AdminKeys)

        Public Sub New(view As Forms.AdminSidebar, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

            SetEvents()
        End Sub

        Protected Friend Overrides Sub SetEvents()
            _view.AccountButtonClick = AddressOf AccountsButtonClick
            _view.DashboardButtonClick = AddressOf AdminDashboardButtonClick
            _view.MenuButtonClick = AddressOf MenuButtonClick
            _view.InventoryButtonClick = AddressOf InventoryButtonClick
            _view.StaffTransactionButtonClick = AddressOf StaffTransactions
            _view.OrderHistoryButtonClick = AddressOf OrderHistoryClick
        End Sub
        Private Sub AdminDashboardButtonClick()
            _mediator.SwapPage(AdminKeys.AdminDashboard)
        End Sub
        Private Sub AccountsButtonClick()
            _mediator.SwapPage(AdminKeys.AdminAccountSettings)
        End Sub

        Private Sub InventoryButtonClick()
            _mediator.SwapPage(AdminKeys.AdminInventory)
        End Sub

        Private Sub OrderHistoryClick()
            _mediator.SwapPage(AdminKeys.AdminOrderHistory)
        End Sub

        Private Sub StaffTransactions()
            _mediator.SwapPage(AdminKeys.AdminStaffTransactions)
        End Sub

        Private Sub MenuButtonClick()
            _mediator.SwapPage(AdminKeys.AdminMenu)
        End Sub
    End Class
End Namespace