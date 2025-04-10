Imports System.ComponentModel.DataAnnotations

Public Class User
    Public Property UserId As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Username As String

    Public Property PasswordHash As String

    Public Property ContactNumber As String

    Public Property Email As String
    Public Property Role As String
    Public Property Address As String

    Public Property CreatedAt As DateTime

    Public Overrides Function ToString() As String
        Return Username
    End Function
End Class
