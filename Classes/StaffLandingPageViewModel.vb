Namespace KioskV0.Classes
    Public Class StaffLandingPageViewModel
        Inherits ViewModel(Of Forms.StaffLandingPageView, StaffKeys)

        Public Sub New(view As Forms.StaffLandingPageView, mediator As Mediator(Of StaffKeys))
            MyBase.New(view, mediator)
        End Sub

    End Class

End Namespace