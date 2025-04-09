Public Class SupplierTransactionsRepository
    Inherits BaseRepository(Of Supplier)
    Public Sub New(context As AppDbContext)
        MyBase.New(context)
    End Sub
End Class
