Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Order
    Public Property OrderId As String = Guid.NewGuid().ToString().Substring(0, 10)

    Public Property TotalAmount As Decimal

    Public Property UserId As String

    Public Property CreatedAt As DateTime

    Public Overridable Property User As User
    Public Overridable Property OrderItems As ICollection(Of OrderItem) ' Order has many OrderItems
End Class
