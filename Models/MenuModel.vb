Imports System.ComponentModel.DataAnnotations

Namespace KioskV0.Model
    Public Class MenuModel
        Inherits BaseModel
        Public Property MenuID As String
        <Required(ErrorMessage:="Menu Name is required.")>
        <StringLength(25, MinimumLength:=3, ErrorMessage:="Menu Name must be between 3 and 25 characters.")>
        Public Property MenuName As String

        <Required(ErrorMessage:="Category is required.")>
        <StringLength(25, MinimumLength:=3, ErrorMessage:="Category must be between 3 and 25 characters.")>
        Public Property Category As String

        <Required(ErrorMessage:="Supplier is required.")>
        <StringLength(25, MinimumLength:=3, ErrorMessage:="Supplier must be between 3 and 25 characters.")>
        Public Property Supplier As String

        <StringLength(250, ErrorMessage:="Product Description cannot exceed 250 characters.")>
        Public Property ProductDescription As String

        <Required(ErrorMessage:="Cost is required.")>
        <Range(0, Decimal.MaxValue, ErrorMessage:="Cost must be a positive value.")>
        Public Property Cost As Decimal

        <Required(ErrorMessage:="Selling price is required.")>
        <Range(0, Decimal.MaxValue, ErrorMessage:="Selling price must be a positive value.")>
        Public Property Selling As Decimal

        Public Sub New()
            MenuID = Guid.NewGuid().ToString().Substring(0, 10)
        End Sub
        Public Overrides Function Equals(obj As Object) As Boolean
            If obj Is Nothing Then Return False
            If TypeOf obj Is MenuModel Then
                Dim other As MenuModel = DirectCast(obj, MenuModel)
                Return Me.MenuID = other.MenuID
            End If
            Return False
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MenuID.GetHashCode()
        End Function
    End Class
End Namespace
