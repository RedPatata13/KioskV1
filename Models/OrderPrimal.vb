Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class OrderPrimal
    Public Property OrderId As String
    Public Property TotalPrice As Decimal

    'Public Property UserId As String
    Public Property CreatedAt As DateTime
    Public Property IsComplete As Boolean
    Public Property IsPaid As Boolean

    Public Overridable Property OrderItems As ICollection(Of OrderDetail) ' Order has many OrderItems

    Public Property OrderMode As String
End Class
