Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminOrderHistoryViewModel
        Inherits ViewModel(Of Forms.AdminOrderHistoryView, AdminKeys)

        Public Sub New(view As AdminOrderHistoryView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace