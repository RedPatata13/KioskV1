Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminMenuViewModel
        Inherits ViewModel(Of Forms.AdminMenuView, AdminKeys)

        Public Sub New(view As AdminMenuView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace