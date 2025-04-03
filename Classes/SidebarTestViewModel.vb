Namespace KioskV0.Classes
    Public Class SidebarTestViewModel
        Inherits ViewModel(Of SidebarTest, AdminKeys)

        Public Sub New(view As SidebarTest, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

            _view.HomeButtonClick = AddressOf HomeButtonClick
            _view.TestButtonClick = AddressOf TestButtonClick
        End Sub

        Private Sub TestButtonClick()
            _mediator.SwapPage(AdminKeys.AdminTestPage)
        End Sub

        Private Sub HomeButtonClick()
            _mediator.SwapPage(AdminKeys.AdminLandingPage)
        End Sub
    End Class
End Namespace