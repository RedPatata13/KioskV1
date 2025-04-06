Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class OrderItem
    Public Property OrderItemId As Integer

    Public Property OrderId As Integer
    Public Property MenuId As Integer

    Public Property TotalAmount As Decimal

    Public Property Quantity As Integer
    Public Property Price As Decimal
    Public Overridable Property Menu As Menu
    Public Overridable Property Order As Order
End Class
