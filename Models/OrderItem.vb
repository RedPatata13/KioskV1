Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class OrderItem
    Public Property OrderItemId As String = Guid.NewGuid().ToString().Substring(0, 10)
    Public Property OrderId As String
    Public Property MenuId As String

    Public Property TotalAmount As Decimal

    Public Property Quantity As Integer
    Public Property Price As Decimal
    Public Overridable Property Menu As Menu
    Public Overridable Property Order As Order
End Class
