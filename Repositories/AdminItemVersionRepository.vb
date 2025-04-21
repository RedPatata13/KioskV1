Imports System.Data.Entity

Public Class AdminItemVersionRepository
    Inherits BaseRepository(Of AdminItemVersion)
    Implements IAdminItemVersionRepository

    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub

    Public Overrides Function GetAll() As IEnumerable(Of AdminItemVersion)
        Return _dbSet.Include(Function(a) a.BaseItem) _
                     .Include(Function(a) a.Batch) _
                     .Include(Function(a) a.Category) _
                     .AsNoTracking _
                     .ToList()
    End Function
End Class
