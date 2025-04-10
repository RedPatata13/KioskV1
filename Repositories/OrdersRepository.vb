Public Class OrdersRepository
    Inherits BaseRepository(Of Order)
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub
End Class
