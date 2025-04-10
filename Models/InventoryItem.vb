Public Class InventoryItem
    Public Property Id As Integer
    Public Property Name As String
    Public Property Description As String
    Public Property SupplierId As Integer ' Foreign Key for Supplier (created/edited by Supplier)
    Public Property Supplier As Supplier ' Navigation Property
End Class
