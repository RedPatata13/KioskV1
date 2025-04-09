Public Class SupplierTransactionsRepository
    Inherits BaseRepository(Of SupplierTransactionModel)
    Public Sub New(context As AppDbContext)
        MyBase.New(context)
    End Sub
End Class
