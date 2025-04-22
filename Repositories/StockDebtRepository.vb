Imports System.Data.Entity
Public Class StockDebtRepository
    Inherits BaseRepository(Of StockDebt)
    Implements IStockDebtRepository

    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub

    Public Overrides Function GetAll() As IEnumerable(Of StockDebt)
        Return _dbSet.Include(Function(s) s.Item) _
                     .Include(Function(s) s.Item.Category) _
                     .Include(Function(s) s.Item.Batch) _
                     .Include(Function(s) s.GeneratedBy) _
                     .AsNoTracking().ToList()
    End Function

    Public Function GetAllUnresolved() As IEnumerable(Of StockDebt) Implements IStockDebtRepository.GetAllUnresolved
        Return _dbSet.Include(Function(s) s.Item) _
                     .Include(Function(s) s.Item.Category) _
                     .Include(Function(s) s.Item.Batch) _
                     .Include(Function(s) s.GeneratedBy) _
                     .Where(Function(s) s.IsResolved = False) _
                     .AsNoTracking().ToList()
    End Function

    Public Function GetAllResolved() As IEnumerable(Of StockDebt) Implements IStockDebtRepository.GetAllResolved
        Return _dbSet.Include(Function(s) s.Item) _
                     .Include(Function(s) s.Item.Category) _
                     .Include(Function(s) s.Item.Batch) _
                     .Include(Function(s) s.GeneratedBy) _
                     .Where(Function(s) s.IsResolved) _
                     .AsNoTracking().ToList()
    End Function
End Class
