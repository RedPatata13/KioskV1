Namespace KioskV0.Classes
    Public Class AdminSideBarViewModel
        Inherits ViewModel(Of Forms.AdminSidebar, AdminKeys)

        Public Sub New(view As Forms.AdminSidebar, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

            SetEvents()
        End Sub

        Private Sub SetEvents()
            _view.AccountButtonClick = AddressOf AccountsButtonClick
        End Sub
        Private Sub AdminHomeButtonClick()
            _mediator.SwapPage(AdminKeys.AdminLandingPage)
        End Sub
        Private Sub AccountsButtonClick()
            _mediator.SwapPage(AdminKeys.AdminAccountSettings)
        End Sub
    End Class
End Namespace