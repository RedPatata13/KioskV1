Public Class InventoryBatch
    Public Property BatchId As String
    Public Property SupplierId As String
    Public Property SupplierItemId As String
    Public Property QuantityReceived As Integer
    Public Property RemainingQuantity As Integer
    Public Property UnitCost As Decimal
    Public Property ReceivedDate As DateTime
    Public Property ExpiryDate As Nullable(Of DateTime)
    Public Property BatchName As String

    ' Navigation properties
    Public Overridable Property Supplier As Supplier
    Public Overridable Property SupplierItem As SupplierItem
    Public Overridable Property AdminItems As ICollection(Of AdminItem)

    Public Property IsActive As Boolean = True
    Public Property IsDeprecated As Boolean = False
    Public Property DeprecationReason As String
    Public Property DeprecatedDate As Nullable(Of DateTime)
End Class