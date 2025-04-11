Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class SupplierAcceptRequestViewModel
        Inherits ViewModel(Of Forms.SupplierAcceptRequestView, SupplierKeys)

        Public Sub New(view As Forms.SupplierAcceptRequestView, mediator As Mediator(Of SupplierKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class


End Namespace