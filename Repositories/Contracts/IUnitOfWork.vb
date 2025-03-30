Public Interface IUnitOfWork
    Inherits IDisposable
    ReadOnly Property Users As IBaseRepository(Of User)
    ReadOnly Property Products As IBaseRepository(Of Product)
    ReadOnly Property Customers As IBaseRepository(Of Customer)
    ReadOnly Property Supliers As IBaseRepository(Of Supplier)
    ReadOnly Property Invertories As IBaseRepository(Of Inventory)
    ReadOnly Property OrderItems As IBaseRepository(Of OrderItem)
    ReadOnly Property Transactions As IBaseRepository(Of Transaction)
    ReadOnly Property Orders As IBaseRepository(Of Order)
    Sub SaveChanges()
End Interface
