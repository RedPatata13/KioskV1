Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports KioskV0.KioskV0.Model

Public Class Menu
    Inherits BaseModel

    <Key>
    Public Property MenuId As Integer

    <Required(ErrorMessage:="Menu name is required.")>
    <StringLength(100, ErrorMessage:="Menu name cannot exceed 100 characters.")>
    <DisplayName("Menu")>
    Public Property MenuName As String

    <Required(ErrorMessage:="Cost is required.")>
    <Range(0.01, 999999.99, ErrorMessage:="Cost must be between 0.01 and 999,999.99.")>
    Public Property Cost As Decimal

    <Required(ErrorMessage:="Selling price is required.")>
    <Range(0.01, 999999.99, ErrorMessage:="Selling price must be between 0.01 and 999,999.99.")>
    Public Property Selling As Decimal

    <Required(ErrorMessage:="Category is required.")>
    Public Property Category As String

    <StringLength(255, ErrorMessage:="Description cannot exceed 255 characters.")>
    <DisplayName("Description")>
    Public Property ProductDescription As String

    <Required(ErrorMessage:="Supplier name is required.")>
    Public Property Supplier As String

    <StringLength(255, ErrorMessage:="Image path cannot exceed 255 characters.")>
    Public Property ProductImagePath As String
    Public Overridable Property OrderItems As ICollection(Of OrderItem)
    Public Overridable Property Inventories As ICollection(Of Inventory)
End Class
