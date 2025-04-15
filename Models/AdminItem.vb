Public Class AdminItem
    Public Property Id As String
    Public Property Name As String
    Public Property Description As String
    Public Property CategoryId As String
    Public Property Category As Category
    Public Property SupplierItemId As String ' FK
    Public Property SupplierItem As SupplierItem
    Public Property SellingCost As Decimal
    Public Property ImageFilePath As String
    Public Property IsDisplayedAsCustomerItem As Boolean

    Public Property BatchId As String
    Public Overridable Property Batch As InventoryBatch
End Class
