Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes

Public Class SupplierItemsViewModel
    Inherits ViewModel(Of SupplierItemsView, SupplierKeys)

    Public Sub New(view As SupplierItemsView, mediator As Mediator(Of SupplierKeys))
        MyBase.New(view, mediator)
    End Sub
End Class
