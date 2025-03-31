Imports KioskV0.KioskV0.Classes

Namespace KioskV0.Classes
    Public Class AdminAddMenuViewModel
        Inherits ViewModel(Of Forms.AdminAddMenuView, AdminKeys)

        Public Sub New(view As Forms.AdminAddMenuView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

        End Sub
    End Class
End Namespace