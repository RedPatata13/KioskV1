Public Interface IUnitOfWork
    ReadOnly Property Users As IBaseRepository(Of User)
    ReadOnly Property Products As IBaseRepository(Of Product)
    Sub SaveChanges()
End Interface
