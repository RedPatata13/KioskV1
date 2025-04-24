Imports System.ComponentModel.DataAnnotations

Public Class AdminItem
    Inherits BaseModel

    <Key>
    Public Property Id As String

    <Required(ErrorMessage:="Name is required.")>
    <StringLength(50, ErrorMessage:="Name cannot exceed 50 characters.")>
    Public Property Name As String
    Public Property Description As String

    <Required(ErrorMessage:="Category ID is required.")>
    Public Property CategoryId As String
    Public Property Category As Category
    Public Property SupplierItemId As String ' FK
    Public Property SupplierItem As SupplierItem
    <Required(ErrorMessage:="Product ID is required.")>
    Public Property SellingCost As Decimal
    Public Property ImageFilePath As String

    <Required(ErrorMessage:="Product ID is required.")>
    Public Property IsDisplayedAsCustomerItem As Boolean

    Public Property BatchId As String
    Public Overridable Property Batch As InventoryBatch

    Public Property IsValid As Boolean
End Class
