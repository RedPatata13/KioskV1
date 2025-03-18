Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminDashboardViewModel
        Inherits ViewModel(Of Forms.AdminDashboardView, AdminKeys)

        Public Sub New(view As AdminDashboardView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace
