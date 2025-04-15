Public Class OrdersRepository
    Inherits BaseRepository(Of OrderPrimal)
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub
End Class
