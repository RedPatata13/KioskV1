Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Public Class Inventory
    Public Property InventoryId As Integer
    Public Property MenuId As Integer
    Public Property DeliveryDateAndTime As DateTime
    Public Property Supplier As String
    Public Property Quantity As Integer
    Public Property Status As String
    Public Overridable Property Menu As Menu

End Class
