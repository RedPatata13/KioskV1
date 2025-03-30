Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminAccountSettingsViewModel
        Inherits ViewModel(Of Forms.AdminAccountSettingsView, AdminKeys)

        Public Sub New(view As AdminAccountSettingsView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace