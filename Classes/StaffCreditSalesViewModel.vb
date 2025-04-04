Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class StaffCreditSalesViewModel
        Inherits ViewModel(Of Forms.StaffCreditSalesView, StaffKeys)

        Public Sub New(view As StaffCreditSalesView, mediator As Mediator(Of StaffKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace