Public Class InventoriesRepository
    Inherits BaseRepository(Of Inventory)
    Public Sub New(context As AppDbContext)
        MyBase.New(context)
    End Sub
End Class
