Public Interface IUnitOfWork
    Inherits IDisposable
    ReadOnly Property Users As UsersRepository
    ReadOnly Property Menus As MenuRepository
    ReadOnly Property Customers As IBaseRepository(Of Customer)
    ReadOnly Property Suppliers As IBaseRepository(Of Supplier)
    ReadOnly Property Inventories As IBaseRepository(Of Inventory)
    ReadOnly Property OrderItems As IBaseRepository(Of OrderItem)
    ReadOnly Property Transactions As IBaseRepository(Of Transaction)
    ReadOnly Property Orders As IBaseRepository(Of OrderPrimal)
    'ReadOnly Property SupplierItem As IBaseRepository(Of SupplierItem)
    ReadOnly Property SupplierItems As IBaseRepository(Of SupplierItem)
    ReadOnly Property AdminItems As IBaseRepository(Of AdminItem)
    ReadOnly Property CustomerItems As IBaseRepository(Of CustomerItem)
    ReadOnly Property Categories As IBaseRepository(Of Category)
    ReadOnly Property OrderDetails As IBaseRepository(Of OrderDetail)
    ReadOnly Property InventoryBatches As IBaseRepository(Of InventoryBatch)
    ReadOnly Property TransactedOrder As IBaseRepository(Of TransactedOrder)
    ReadOnly Property AdminItemVersion As AdminItemVersionRepository
    Sub SaveChanges()
End Interface
