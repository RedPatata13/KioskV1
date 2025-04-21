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

    Public Function GetCurrentVersion(itemId As String) As AdminItemVersion Implements IAdminItemVersionRepository.GetCurrentVersion
        Dim version As AdminItemVersion = _dbSet.Local.FirstOrDefault(Function(v) v.BaseItemId = itemId AndAlso v.IsCurrentVersion)
        If version Is Nothing Then
            version = _dbSet.FirstOrDefault(Function(v) v.BaseItemId = itemId AndAlso v.IsCurrentVersion)
        End If


        Return version
    End Function
End Class
