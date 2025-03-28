Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class OrderItem
    Public Property OrderItemId As Integer

    Public Property OrderId As Integer ' Foreign key to Order
    Public Property ProductId As Integer

    Public Property TotalAmount As Decimal

    Public Property Quantity As Integer
    Public Property Price As Decimal

    ' Navigation Properties
    Public Overridable Property Product As Product
    Public Overridable Property Order As Order
End Class
