Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes

Public Class SupplierRequestListVM
    Inherits KioskV0.Classes.ViewModel(Of SupplierBatchesView, SupplierKeys)

    Public Sub New(view As SupplierBatchesView, mediator As Mediator(Of SupplierKeys))
        MyBase.New(view, mediator)
    End Sub
End Class
