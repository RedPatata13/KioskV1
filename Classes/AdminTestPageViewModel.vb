
Namespace KioskV0.Classes
    Public Class AdminTestPageViewModel
        Inherits ViewModel(Of Forms.AdminTestPageView, AdminKeys)

        Public Sub New(view As Forms.AdminTestPageView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            _view.TestButtonClick = AddressOf TestButtonClick
        End Sub

        Private Sub TestButtonClick()
            _mediator.SwapPage(AdminKeys.AdminLandingPage)
        End Sub
    End Class


End Namespace