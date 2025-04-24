Imports System.ComponentModel.DataAnnotations

Public Class User
    Inherits BaseModel

    <Display(Name:="User ID")>
    Public Property UserId As String

    <Display(Name:="First Name")>
    Public Property FirstName As String

    <Display(Name:="Last Name")>
    Public Property LastName As String

    <Display(Name:="Username")>
    Public Property Username As String

    <Display(Name:="Password")>
    Public Property PasswordHash As String

    <Display(Name:="Contact Number")>
    <RegularExpression("^\d{10,15}$", ErrorMessage:="Invalid contact number format.")>
    Public Property ContactNumber As String

    <Display(Name:="Email Address")>
    <RegularExpression("^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage:="Invalid email format.")>
    Public Property Email As String

    <Display(Name:="User Role")>
    Public Property Role As String

    <Display(Name:="Home Address")>
    Public Property Address As String

    <Display(Name:="Created At")>
    Public Property CreatedAt As DateTime

    Public Overrides Function ToString() As String
        Return Username
    End Function
End Class
