Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel
Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Model

Public Class User
    Inherits BaseModel
    Public Property UserId As String = Guid.NewGuid().ToString().Substring(0, 10)

    <Required(ErrorMessage:="First name is required.")>
    <StringLength(100, ErrorMessage:="First name cannot be longer than 100 characters.")>
    <DisplayName("First Name")>
    Public Property FirstName As String

    <Required(ErrorMessage:="Last name is required.")>
    <StringLength(100, ErrorMessage:="Last name cannot be longer than 100 characters.")>
    <DisplayName("Last Name")>
    Public Property LastName As String

    <Required(ErrorMessage:="Username is required.")>
    <StringLength(50, ErrorMessage:="Username cannot be longer than 50 characters.")>
    <DisplayName("Username")>
    Public Property Username As String

    <Required(ErrorMessage:="Password is required.")>
    <StringLength(100, MinimumLength:=6, ErrorMessage:="Password must be at least 6 characters long.")>
    <DisplayName("Password")>
    Public Property PasswordHash As String
    <Required(ErrorMessage:="Contact Number is required.")>
    <RegularExpression("^\+?\d{10,15}$", ErrorMessage:="Invalid contact number. It should be 10 to 15 digits, with an optional + at the start.")>
    <DisplayName("Contact Number")>
    Public Property ContactNumber As String

    <Required(ErrorMessage:="Email is required.")>
    <StringLength(100, ErrorMessage:="Email cannot be longer than 100 characters.")>
    <DisplayName("Email Address")>
    <RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage:="Invalid email format.")>
    Public Property Email As String

    <Required(ErrorMessage:="Role is required.")>
    <EnumDataType(GetType(UserType), ErrorMessage:="Invalid role.")>
    <DisplayName("Role")>
    Public Property Role As String

    <StringLength(255, ErrorMessage:="Address cannot be longer than 255 characters.")>
    <DisplayName("Address")>
    Public Property Address As String

    <DisplayName("Created At")>
    Public Property CreatedAt As DateTime
End Class
