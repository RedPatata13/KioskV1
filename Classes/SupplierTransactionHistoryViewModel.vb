Namespace KioskV0.Classes
    Public Class SupplierTransactionHistoryViewModel
        Inherits ViewModel(Of Forms.SupplierTransactionHistoryView, SupplierKeys)

        Public Sub New(view As Forms.SupplierTransactionHistoryView, mediator As Mediator(Of SupplierKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace