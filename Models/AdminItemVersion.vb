Public Class AdminItemVersion
    Inherits BaseModel

    Public Property VersionId As String
    Public Property Name As String
    Public Property ImageFilePath As String
    Public Property UnitCost As Decimal
    Public Property SellingCost As Decimal
    Public Property IsDisplayedAsACustomerItem As Boolean
    Public Property IsCurrentVersion As Boolean
    Public Property VersionUpdateReason As String
    Public Property BaseItem As AdminItem
    Public Property BaseItemId As String
    Public Property CategoryId As String
    Public Property Category As Category
    Public Property BatchID As String
    Public Property DateCreated As DateTime
    Public Property EditedBy As User
    Public Property EditorId As String
    Public Overridable Property Batch As InventoryBatch
End Class
