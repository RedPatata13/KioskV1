Imports System.ComponentModel.DataAnnotations

Public Class User
    Inherits BaseModel

    <Key>
    Public Property UserId As String

    <Required(ErrorMessage:="First name is required.")>
    <StringLength(50, ErrorMessage:="First name cannot be longer than 50 characters.")>
    Public Property FirstName As String

    <Required(ErrorMessage:="Last name is required.")>
    <StringLength(50, ErrorMessage:="Last name cannot be longer than 50 characters.")>
    Public Property LastName As String

    <Required(ErrorMessage:="Username is required.")>
    <StringLength(20, MinimumLength:=3, ErrorMessage:="Username must be between 3 and 20 characters.")>
    Public Property Username As String

    <Required(ErrorMessage:="Password hash is required.")>
    Public Property PasswordHash As String

    <Required(ErrorMessage:="Contact Number.")>
    <RegularExpression("^\d{10,15}$", ErrorMessage:="Invalid contact number format.")>
    Public Property ContactNumber As String

    <Required(ErrorMessage:="Email is required.")>
    <RegularExpression("^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage:="Invalid email format.")>
    <StringLength(100, ErrorMessage:="Email cannot be longer than 100 characters.")>
    Public Property Email As String

    <Required(ErrorMessage:="Role is required.")>
    <StringLength(20, ErrorMessage:="Role cannot be longer than 20 characters.")>
    Public Property Role As String

    <StringLength(200, ErrorMessage:="Address cannot be longer than 200 characters.")>
    Public Property Address As String

    Public Property CreatedAt As DateTime

    Public Overrides Function ToString() As String
        Return Username
    End Function
End Class