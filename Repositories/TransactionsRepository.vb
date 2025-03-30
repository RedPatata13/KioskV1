Public Class TransactionsRepository
    Inherits BaseRepository(Of Transaction)
    Public Sub New(context As AppDbContext)
        MyBase.New(context)
    End Sub
End Class
