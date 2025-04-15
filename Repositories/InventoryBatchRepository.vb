Public Class InventoryBatchRepository
    Inherits BaseRepository(Of InventoryBatch)
    Implements IInventoryBatchRepository
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub
End Class
