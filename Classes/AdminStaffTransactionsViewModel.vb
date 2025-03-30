Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminStaffTransactionsViewModel
        Inherits ViewModel(Of Forms.AdminStaffTransactionsView, AdminKeys)

        Public Sub New(view As AdminStaffTransactionsView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace