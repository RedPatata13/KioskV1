Public Class OrderItemsRepository
    Inherits BaseRepository(Of OrderItem)
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub
End Class
