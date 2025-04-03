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
        End Sub
        Private Sub AdminDashboardButtonClick()
            _mediator.SwapPage(AdminKeys.AdminDashboard)
        End Sub
        Private Sub AccountsButtonClick()
            _mediator.SwapPage(AdminKeys.AdminAccountSettings)
        End Sub

        Private Sub MenuButtonClick()
            _mediator.SwapPage(AdminKeys.AdminMenu)
        End Sub
    End Class
End Namespace