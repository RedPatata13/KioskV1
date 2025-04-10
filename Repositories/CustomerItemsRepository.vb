Imports System.Data.Entity

Public Class CustomerItemsRepository
    Inherits BaseRepository(Of CustomerItem)
    Implements ICustomerItemRepository
    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub
    Public Overrides Function GetAll() As IEnumerable(Of CustomerItem)
        Return _dbSet.Include(Function(c) c.AdminItem) _
            .Include(Function(c) c.AdminItem.Category) _
            .Include(Function(c) c.AdminItem.SupplierItem) _
            .Include(Function(c) c.AdminItem.SupplierItem.Supplier) _
            .AsNoTracking().ToList()
    End Function

End Class
