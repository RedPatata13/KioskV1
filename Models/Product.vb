Imports System.ComponentModel.DataAnnotations

Public Class Product
    Public Property ProductId As Integer
    Public Property ProductName As String
    Public Property Price As Decimal

    Public Property Category As String

    Public Property Description As String

    Public Property ProductImagePath As String
    Public Overridable Property OrderItems As ICollection(Of OrderItem)
    Public Overridable Property Inventories As ICollection(Of Inventory)
End Class
