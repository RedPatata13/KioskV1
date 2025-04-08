Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Supplier
    Public Property SupplierId As String = Guid.NewGuid().ToString().Substring(0, 10)
    Public Property Name As String
    Public Property ContactNumber As String

    Public Property Email As String
    Public Property CreatedAt As DateTime

    Public Property Address As String

    Public Property MenuId As String

    Public Overridable Property Menu As Menu

    Public ReadOnly Property MenuName As String
        Get
            Return If(Menu?.MenuName, String.Empty)
        End Get
    End Property
End Class
