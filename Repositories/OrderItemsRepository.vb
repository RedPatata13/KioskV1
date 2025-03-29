Public Class OrderItemsRepository
    Inherits BaseRepository(Of OrderItem)
    Public Sub New(context As AppDbContext)
        MyBase.New(context)
    End Sub
End Class
