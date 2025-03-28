Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Order
    Public Property OrderId As Integer

    Public Property OrderDate As DateTime

    Public Property TotalAmount As Decimal

    Public Property StaffId As Integer

    Public Property CreatedAt As DateTime

    Public Overridable Property User As User
    Public Overridable Property OrderItems As ICollection(Of OrderItem) ' Order has many OrderItems
End Class
