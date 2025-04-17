Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class OrderPrimal
    Public Property OrderId As String
    Public Property TotalPrice As Decimal

    'Public Property UserId As String
    Public Property CreatedAt As DateTime

    Public Overridable Property User As User

    Public Overridable Property OrderItems As ICollection(Of OrderDetail) ' Order has many OrderItems
End Class
