Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Supplier
    Inherits User
    Public Property SupplierItems As ICollection(Of SupplierItem)
End Class
