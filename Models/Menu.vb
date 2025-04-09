Imports KioskV0.KioskV0.Model

Public Class Menu
    Inherits BaseModel
    Public Property MenuId As Integer
    Public Property MenuName As String
    Public Property Cost As Decimal
    Public Property Selling As Decimal
    Public Property Category As String
    Public Property ProductDescription As String
    Property Supplier As String
    Public Property ProductImagePath As String
    Public Overridable Property OrderItems As ICollection(Of OrderItem)
    Public Overridable Property Inventories As ICollection(Of Inventory)
    Public Overrides Function ToString() As String
        Return MenuName
    End Function
End Class
