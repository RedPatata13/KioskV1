Imports System.Data.Entity

Public Class UsersRepository
    Implements IBaseRepository(Of User)

    Private ReadOnly _context As AppDbContext

    Public Sub New(context As AppDbContext)
        _context = context
    End Sub

    Public Sub Add(entity As User) Implements IBaseRepository(Of User).Add
        _context.Users.Add(entity)
        ' No SaveChanges() here!
    End Sub

    Public Sub Update(entity As User) Implements IBaseRepository(Of User).Update
        _context.Entry(entity).State = EntityState.Modified
        ' No SaveChanges() here!
    End Sub

    Public Sub Delete(id As Integer) Implements IBaseRepository(Of User).Delete
        Dim user = _context.Users.Find(id)
        If user IsNot Nothing Then
            _context.Users.Remove(user)
        End If
        ' No SaveChanges() here!
    End Sub

    Public Function GetAll() As IEnumerable(Of User) Implements IBaseRepository(Of User).GetAll
        Return _context.Users.AsNoTracking().ToList()
    End Function

    Public Function GetById(id As Integer) As User Implements IBaseRepository(Of User).GetById
        Return _context.Users.Find(id)
    End Function
End Class
