Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminInventoryViewModel
        Inherits ViewModel(Of Forms.AdminInventoryView, AdminKeys)

        Public Sub New(view As AdminInventoryView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace
