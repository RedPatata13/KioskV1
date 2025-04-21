Imports System.Data.Entity
Public Class OrdersRepository
    Inherits BaseRepository(Of OrderPrimal)

    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub

    Public Overrides Function GetById(id As String) As OrderPrimal
        Return _dbSet.Include(Function(o) o.OrderItems) _
                     .Include("OrderItems.ItemVersion") _
                 .FirstOrDefault(Function(o) o.OrderId = id)
    End Function
End Class
