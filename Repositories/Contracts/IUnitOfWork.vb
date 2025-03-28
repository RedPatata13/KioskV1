Public Interface IUnitOfWork
    Inherits IDisposable
    ReadOnly Property Users As IBaseRepository(Of User)
    ReadOnly Property Products As IBaseRepository(Of Product)
    Sub SaveChanges()
End Interface
