Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Public Class Inventory
    Public Property InventoryId As String = Guid.NewGuid().ToString().Substring(0, 10)
    Public Property MenuId As String
    Public Property DeliveryDateAndTime As DateTime
    Public Property Supplier As String
    Public Property Quantity As Integer
    Public Property Status As String
    Public Overridable Property Menu As Menu

End Class
