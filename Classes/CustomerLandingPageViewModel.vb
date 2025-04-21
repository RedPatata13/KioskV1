Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes

Public Class CustomerLandingPageViewModel
    Inherits KioskV0.Classes.ViewModel(Of Form, KioskV0.CustomerKeys)

    Public Sub New(view As Form, mediator As Mediator(Of CustomerKeys))
        MyBase.New(view, mediator)
    End Sub
End Class
