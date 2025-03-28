Imports System.Data.Entity

Public Class ProductsRepository
    Implements IBaseRepository(Of Product)

    Private ReadOnly _context As AppDbContext

    Public Sub New(context As AppDbContext)
        _context = context
    End Sub

    Public Sub Add(entity As Product) Implements IBaseRepository(Of Product).Add
        _context.Products.Add(entity)
        _context.SaveChanges()
    End Sub

    Public Sub Update(entity As Product) Implements IBaseRepository(Of Product).Update
        _context.Entry(entity).State = EntityState.Modified
        _context.SaveChanges()
    End Sub

    Public Sub Delete(id As Integer) Implements IBaseRepository(Of Product).Delete
        Dim product = _context.Products.Find(id)
        If product IsNot Nothing Then
            _context.Products.Remove(product)
            _context.SaveChanges()
        End If
    End Sub

    Public Function GetAll() As IEnumerable(Of Product) Implements IBaseRepository(Of Product).GetAll
        Return _context.Products.ToList()
    End Function

    Public Function GetById(id As Integer) As Product Implements IBaseRepository(Of Product).GetById
        Return _context.Products.Find(id)
    End Function
End Class
