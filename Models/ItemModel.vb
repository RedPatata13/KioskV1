Imports System.ComponentModel.DataAnnotations

Namespace KioskV0.Classes
    Public Class ItemModel
        <Required(ErrorMessage:="Product ID is required.")>
        <StringLength(50, ErrorMessage:="Product ID cannot exceed 50 characters.")>
        Public Property ProductId As String

        <Required(ErrorMessage:="Product Name is required.")>
        <StringLength(100, ErrorMessage:="Product Name cannot exceed 100 characters.")>
        Public Property ProductName As String

        <Range(0, Integer.MaxValue, ErrorMessage:="Quantity cannot be negative.")>
        Public Property Quantity As Int32

        <Required(ErrorMessage:="Supplier is required.")>
        <StringLength(100, ErrorMessage:="Supplier name cannot exceed 100 characters.")>
        Public Property Supplier As String

        <Required(ErrorMessage:="Item Status is required.")>
        Public Property Status As ItemStatus
    End Class

End Namespace