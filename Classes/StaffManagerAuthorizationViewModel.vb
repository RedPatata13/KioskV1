Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class StaffManagerAuthorizationViewModel
        Inherits ViewModel(Of Forms.StaffManagerAuthorizationView, StaffKeys)

        Public Sub New(view As StaffManagerAuthorizationView, mediator As Mediator(Of StaffKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace