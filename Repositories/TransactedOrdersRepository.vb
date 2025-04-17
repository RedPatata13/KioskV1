Imports System.Data.Entity

Public Class TransactedOrdersRepository
    Inherits BaseRepository(Of TransactedOrder)
    Implements ITransactedDetailsRepository

    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub

    Public Overrides Function GetAll() As IEnumerable(Of TransactedOrder)
        Return _dbSet.Include(Function(tr) tr.User) _
            .AsNoTracking().ToList()
    End Function
End Class
