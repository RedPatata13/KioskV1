Imports System.Data.Entity

Public Class AdminItemsRepository
    Inherits BaseRepository(Of AdminItem)
    Implements IAdminItemsRepository
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub

    Public Overrides Function GetAll() As IEnumerable(Of AdminItem)
        Return _dbSet.Include(Function(c) c.Category) _
                     .Include(Function(c) c.SupplierItem) _
                     .Include(Function(c) c.SupplierItem.Supplier) _
                     .AsNoTracking().ToList()
    End Function


End Class
