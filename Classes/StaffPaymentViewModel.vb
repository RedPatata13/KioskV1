Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class StaffPaymentViewModel
        Inherits ViewModel(Of Forms.StaffPaymentView, StaffKeys)

        Public Sub New(view As StaffPaymentView, mediator As Mediator(Of StaffKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace