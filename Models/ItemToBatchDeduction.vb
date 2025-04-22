Public Class ItemToBatchDeduction
    Public Property ItB_Id As String
    Public Property AmountDeducted As Integer
    Public Property Batch As InventoryBatch
    Public Property BatchId As String

    Public Property BaseItem As AdminItem
    Public Property BaseItemId As String

    Public Property Version As AdminItemVersion
    Public Property VersionId As String

    Public Property Order As OrderPrimal
    Public Property OrderId As String

    Public Property IsValid As Boolean
    Public Property CausedBy As String
End Class
