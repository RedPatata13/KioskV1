Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Supplier
    Public Property SupplierId As Integer
    Public Property Name As String
    Public Property ContactNumber As String

    Public Property Email As String
    Public Property CreatedAt As DateTime

    Public Property Address As String

    Public Property ProductId As Integer

    Public Overridable Property Product As Product

    Public ReadOnly Property ProductName As String
        Get
            Return If(Product?.ProductName, String.Empty)
        End Get
    End Property
End Class
