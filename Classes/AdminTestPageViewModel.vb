Imports KiostV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminTestPageViewModel
        Inherits ViewModel(Of AdminTestPageView, AdminKeys)

        Public Sub New(view As AdminTestPageView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            _view.TestButtonClick = AddressOf TestButtonClick
        End Sub

        Private Sub TestButtonClick()
            _mediator.SwapPage(AdminKeys.AdminLandingPage)
        End Sub
    End Class


End Namespace