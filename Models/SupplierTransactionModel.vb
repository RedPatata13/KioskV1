Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class SupplierTransactionModel
    <Key>
    <Required>
    <StringLength(10)>
    Public Property BatchId As String = Guid.NewGuid().ToString("N").Substring(0, 10)

    <Required>
    <ForeignKey("Menu")>
    Public Property MenuId As String
    Public Overridable Property Menu As Menu

    <Required>
    Public Property Quantity As Integer

    Public Property DateRelease As Nullable(Of DateTime)

    Public Property TotalCost As Decimal

    Public Property Returned As String

    <Required>
    Public Property Status As String
End Class
