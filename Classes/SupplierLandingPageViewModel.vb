Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes

Public Class SupplierLandingPageViewModel
    Inherits ViewModel(Of SupplierLandingPageView, SupplierKeys)

    Public Sub New(view As SupplierLandingPageView, mediator As Mediator(Of SupplierKeys))
        MyBase.New(view, mediator)

        _view.LoginButtonClick = Sub() _mediator.Logout()
    End Sub
End Class
