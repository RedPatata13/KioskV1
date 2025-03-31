Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminAddUserViewModel
        Inherits ViewModel(Of Forms.AdminAddUserView, AdminKeys)

        Public Sub New(view As AdminAddUserView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class
End Namespace