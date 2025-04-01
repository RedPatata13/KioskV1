Imports System.ComponentModel.DataAnnotations

Namespace KioskV0.Model
    Public Class MenuModel
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
    End Class
End Namespace
