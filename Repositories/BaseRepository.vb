Imports System.Data.Entity

Public Class BaseRepository(Of T As Class)
    Implements IBaseRepository(Of T)

    Private ReadOnly _context As KioskDbContext
    Public ReadOnly _dbSet As DbSet(Of T)

    Public Sub New(context As KioskDbContext)
        _context = context
        _dbSet = _context.Set(Of T)()
    End Sub

    ' Add an entity
    Public Sub Add(entity As T) Implements IBaseRepository(Of T).Add
        If entity Is Nothing Then
            Throw New ArgumentNullException(NameOf(entity), $"{GetType(T).Name} cannot be null.")
        End If
        _dbSet.Add(entity)
    End Sub

    ' Update an entity
    Public Sub Update(entity As T) Implements IBaseRepository(Of T).Update
        If entity Is Nothing Then
            Throw New ArgumentNullException(NameOf(entity), $"{GetType(T).Name} cannot be null.")
        End If
        _context.Entry(entity).State = EntityState.Modified
    End Sub

    ' Delete an entity by ID
    Public Sub Delete(id As Integer) Implements IBaseRepository(Of T).Delete
        Dim entity = _dbSet.Find(id)
        If entity IsNot Nothing Then
            _dbSet.Remove(entity)
        End If
    End Sub

    ' Get all entities
    Public Function GetAll() As IEnumerable(Of T) Implements IBaseRepository(Of T).GetAll
        Return _dbSet.AsNoTracking().ToList()
    End Function

    ' Get an entity by ID
    Public Function GetById(id As Integer) As T Implements IBaseRepository(Of T).GetById
        Return _dbSet.Find(id)
    End Function
End Class
