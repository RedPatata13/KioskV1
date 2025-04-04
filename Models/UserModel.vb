Imports System.ComponentModel.DataAnnotations
Imports System.Text.RegularExpressions

Namespace KioskV0.Model
    Public Class UserModel
        Inherits BaseModel
        <Required(ErrorMessage:="Role is required.")>
        Public Property Role As UserType

        <Required(ErrorMessage:="Username is required.")>
        <StringLength(25, MinimumLength:=3, ErrorMessage:="Username must be between 3 and 25 characters.")>
        Public Property UserName As String

        <Required(ErrorMessage:="Password is required.")>
        <DataType(DataType.Password)>
        Public Property Password As String

        <Required(ErrorMessage:="First name is required.")>
        <StringLength(25, MinimumLength:=3, ErrorMessage:="First name must be between 3 and 25 characters.")>
        Public Property FirstName As String

        <Required(ErrorMessage:="Last name is required.")>
        <StringLength(25, MinimumLength:=3, ErrorMessage:="Last name must be between 3 and 25 characters.")>
        Public Property LastName As String

        <Required(ErrorMessage:="Email is required.")>
        <StringLength(250, MinimumLength:=1, ErrorMessage:="Email cannot be empty or exceed 250 characters.")>
        <RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage:="Invalid email format.")>
        Public Property Email As String

        <Required(ErrorMessage:="Contact number is required.")>
        <RegularExpression("^\+?\d{10,15}$", ErrorMessage:="Invalid contact number. It should be 10 to 15 digits, with an optional + at the start.")>
        Public Property ContactNo As String
    End Class
End Namespace
