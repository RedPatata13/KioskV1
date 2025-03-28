Public Class UnitOfWork
    Implements IUnitOfWork, IDisposable

    Private ReadOnly _context As AppDbContext

    Public ReadOnly Property Users As IBaseRepository(Of User) Implements IUnitOfWork.Users
    Public ReadOnly Property Products As IBaseRepository(Of Product) Implements IUnitOfWork.Products
    Public Sub New(context As AppDbContext)
        _context = context
        Users = New UsersRepository(_context)
        Products = New ProductsRepository(_context)
    End Sub

    Public Sub SaveChanges() Implements IUnitOfWork.SaveChanges
        _context.SaveChanges()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        _context.Dispose()
    End Sub
End Class
