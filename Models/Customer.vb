Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Public Class Customer

    Public Property CustomerId As Integer
    Public Property Name As String
    Public Property Email As String
    Public Property ContactNumber As String
    Public Property CreatedAt As DateTime
    Public Property OrderId As Integer
    Public Overridable Property Order As OrderPrimal
End Class
