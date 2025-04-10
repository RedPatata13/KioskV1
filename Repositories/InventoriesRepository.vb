Public Class InventoriesRepository
    Inherits BaseRepository(Of Inventory)
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub
End Class
