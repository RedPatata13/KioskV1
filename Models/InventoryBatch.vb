Imports System.ComponentModel

Public Class InventoryBatch
    <DisplayName("Batch ID")>
    Public Property BatchId As String

    <DisplayName("Supplier ID")>
    Public Property SupplierId As String

    <DisplayName("Item ID")>
    Public Property SupplierItemId As String

    <DisplayName("Quantity Received")>
    Public Property QuantityReceived As Integer

    <DisplayName("Remaining Quantity")>
    Public Property RemainingQuantity As Integer

    <DisplayName("Unit Cost")>
    Public Property UnitCost As Decimal

    <DisplayName("Received Date")>
    Public Property ReceivedDate As DateTime

    <DisplayName("Expiry Date")>
    Public Property ExpiryDate As Nullable(Of DateTime)
    Public Property BatchName As String

    ' Navigation properties
    <DisplayName("Supplier")>
    Public Overridable Property Supplier As Supplier

    <DisplayName("Item")>
    Public Overridable Property SupplierItem As SupplierItem

    <DisplayName("Admin Items")>
    Public Overridable Property AdminItems As ICollection(Of AdminItem)

    <DisplayName("Is Active")>
    Public Property IsActive As Boolean = True

    <DisplayName("Is Deprecated")>
    Public Property IsDeprecated As Boolean = False

    <DisplayName("Deprecation Reason")>
    Public Property DeprecationReason As String

    <DisplayName("Deprecated Date")>
    Public Property DeprecatedDate As Nullable(Of DateTime)
End Class
