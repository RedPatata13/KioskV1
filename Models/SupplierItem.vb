Public Class SupplierItem
    Public Property Id As String
    Public Property Name As String
    Public Property Description As String
    Public Property SupplierId As String
    Public Property Supplier As Supplier
    'Public Property StockCount As Integer
    Public Overridable Property Batches As ICollection(Of InventoryBatch)

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
