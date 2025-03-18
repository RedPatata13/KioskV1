Namespace KioskV0.Classes
    Public Class AdminLandingPageViewModel
        Inherits ViewModel(Of Forms.AdminLandingPageView, AdminKeys)

        Public Sub New(view As Form, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

            _view.TestButtonClick = AddressOf TestButtonClick
        End Sub

        Private Sub TestButtonClick()
            _mediator.SwapPage(AdminKeys.Sample)
        End Sub
    End Class

End Namespace