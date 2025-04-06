Public Class OrdersRepository
    Inherits BaseRepository(Of Order)
    Public Sub New(context As AppDbContext)
        MyBase.New(context)
    End Sub
End Class
