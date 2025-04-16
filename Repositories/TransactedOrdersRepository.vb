Public Class TransactedOrdersRepository
    Inherits BaseRepository(Of TransactedOrder)
    Implements ITransactedDetailsRepository

    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub
End Class
