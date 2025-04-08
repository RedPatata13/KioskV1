Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Public Class Customer

    Public Property CustomerId As String = Guid.NewGuid().ToString().Substring(0, 10)
    Public Property Name As String
    Public Property Email As String
    Public Property ContactNumber As String
    Public Property CreatedAt As DateTime
    Public Property OrderId As String
    Public Overridable Property Order As Order
End Class
