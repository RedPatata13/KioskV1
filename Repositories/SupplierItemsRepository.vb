Imports System.Data.Entity

Public Class SupplierItemsRepository
    Inherits BaseRepository(Of SupplierItem)
    Implements ISupplierItemsRepository
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub

    Public Overrides Function GetAll() As IEnumerable(Of SupplierItem)
        Return _dbSet.Include(Function(si) si.Batches) _
                    .Include(Function(si) si.Supplier) _
                    .AsNoTracking().ToList()

    End Function
End Class
