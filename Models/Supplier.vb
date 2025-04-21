Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Supplier
    Inherits User
    Public Property SupplierItems As ICollection(Of SupplierItem)
    Public Overridable Property SupplyRequests As ICollection(Of SupplyRequest)
End Class
