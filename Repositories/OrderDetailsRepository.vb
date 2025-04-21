Imports System.Data.Entity

Public Class OrderDetailsRepository
    Inherits BaseRepository(Of OrderDetail)
    Implements IOrderDetailsRepository

    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub

    Public Overrides Function GetAll() As IEnumerable(Of OrderDetail)
        'Return _dbSet.Include(Function(c) c.Or)
        Return _dbSet.Include(Function(od) od.Order) _
            .Include(Function(od) od.ItemVersion) _
            .AsNoTracking() _
            .ToList()
    End Function


    'Public Overrides Function GetAll() As IEnumerable(Of AdminItem)
    '    Return _dbSet.Include(Function(c) c.Category) _
    '                 .Include(Function(c) c.SupplierItem) _
    '                 .Include(Function(c) c.SupplierItem.Supplier) _
    '                 .AsNoTracking() _
    '                 .ToList()
    'End Function
End Class
