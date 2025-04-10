Public Class AdminItem
    Public Property Id As Integer
    Public Property Name As String
    Public Property Description As String
    Public Property SupplierItemId As Integer ' Foreign Key for SupplierItem
    Public Property SupplierItem As InventoryItem ' Navigation Property
    Public Property IsDisplayedAsCustomerItem As Boolean ' Whether the AdminItem is displayed to Customers
End Class
