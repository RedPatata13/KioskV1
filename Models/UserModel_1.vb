Imports System.ComponentModel.DataAnnotations

Public Class User
    Inherits BaseModel
    Public Property UserId As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Username As String
    Public Property PasswordHash As String

    <RegularExpression("^\d{10,15}$", ErrorMessage:="Invalid contact number format.")>
    Public Property ContactNumber As String

    <RegularExpression("^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage:="Invalid email format.")>
    Public Property Email As String

    Public Property Role As String
    Public Property Address As String
    Public Property CreatedAt As DateTime

    Public Overrides Function ToString() As String
        Return Username
    End Function
End Class
