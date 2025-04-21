Public Class SupplyRequest

    Public Property ID As String
    Public Property SupplierID As String
    Public Property ProductName As String
    Public Property Quantity As Integer
    Public Property UnitCost As Decimal
    Public Property Note As String
    Public Property Status As String
    'Public Property ExpiryDate As Nullable(Of DateTime)
    Public Property CreatedAt As DateTime
    'Public Property ResponseDate As Nullable(Of DateTime)


    Public Overridable Property Supplier As Supplier
    Public Overridable Property SupplierItem As SupplierItem
End Class
