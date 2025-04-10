Public Class AdminItem
    Public Property Id As String
    Public Property Name As String
    Public Property Description As String
    Public Property SupplierItemId As String ' FK
    Public Property SupplierItem As SupplierItem
    Public Property IsDisplayedAsCustomerItem As Boolean
End Class
