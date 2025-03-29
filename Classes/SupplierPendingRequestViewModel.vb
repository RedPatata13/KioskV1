Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class SupplierPendingRequestViewModel
        Inherits ViewModel(Of Forms.SupplierPendingRequestView, SupplierKeys)

        Public Sub New(view As SupplierPendingRequestView, mediator As Mediator(Of SupplierKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace