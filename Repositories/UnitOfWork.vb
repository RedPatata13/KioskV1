Public Class UnitOfWork
    Implements IUnitOfWork, IDisposable

    Public ReadOnly _context As KioskDbContext
    Public ReadOnly Property Menus As MenuRepository Implements IUnitOfWork.Menus
    Public ReadOnly Property Customers As IBaseRepository(Of Customer) Implements IUnitOfWork.Customers
    Public ReadOnly Property Orders As IBaseRepository(Of OrderPrimal) Implements IUnitOfWork.Orders
    Public ReadOnly Property OrderItems As IBaseRepository(Of OrderItem) Implements IUnitOfWork.OrderItems
    Public ReadOnly Property Suppliers As IBaseRepository(Of Supplier) Implements IUnitOfWork.Suppliers
    Public ReadOnly Property SupplierItems As IBaseRepository(Of SupplierItem) Implements IUnitOfWork.SupplierItems
    Public ReadOnly Property AdminItems As IBaseRepository(Of AdminItem) Implements IUnitOfWork.AdminItems
    Public ReadOnly Property Transactions As IBaseRepository(Of Transaction) Implements IUnitOfWork.Transactions
    Public ReadOnly Property Inventories As IBaseRepository(Of Inventory) Implements IUnitOfWork.Inventories
    Public ReadOnly Property Users As UsersRepository Implements IUnitOfWork.Users
    Public ReadOnly Property CustomerItems As IBaseRepository(Of CustomerItem) Implements IUnitOfWork.CustomerItems
    Public ReadOnly Property Categories As IBaseRepository(Of Category) Implements IUnitOfWork.Categories
    Public ReadOnly Property OrderDetails As IBaseRepository(Of OrderDetail) Implements IUnitOfWork.OrderDetails
    Public ReadOnly Property InventoryBatches As IBaseRepository(Of InventoryBatch) Implements IUnitOfWork.InventoryBatches
    Public ReadOnly Property TransactedOrders As IBaseRepository(Of TransactedOrder) Implements IUnitOfWork.TransactedOrder
    Public ReadOnly Property AdminItemVersions As AdminItemVersionRepository Implements IUnitOfWork.AdminItemVersion
    Public ReadOnly Property Deductions As ItemDeductionRepository Implements IUnitOfWork.Deductions
    Public ReadOnly Property StockDebts As StockDebtRepository Implements IUnitOfWork.StockDebts

    Public Sub New(context As KioskDbContext)
        _context = context
        Users = New UsersRepository(_context)
        Menus = New MenuRepository(_context)
        Customers = New CustomersRepository(_context)
        Orders = New OrdersRepository(_context)
        OrderItems = New OrderItemsRepository(_context)
        Suppliers = New SuppliersRepository(_context)
        SupplierItems = New SupplierItemsRepository(_context)
        Transactions = New TransactionsRepository(_context)
        Inventories = New InventoriesRepository(_context)
        AdminItems = New AdminItemsRepository(_context)
        CustomerItems = New CustomerItemsRepository(_context)
        Categories = New CategoryRepository(_context)
        OrderDetails = New OrderDetailsRepository(_context)
        InventoryBatches = New InventoryBatchRepository(_context)
        TransactedOrders = New TransactedOrdersRepository(_context)
        AdminItemVersions = New AdminItemVersionRepository(_context)
        Deductions = New ItemDeductionRepository(_context)
        StockDebts = New StockDebtRepository(_context)
    End Sub

    Public Sub SaveChanges() Implements IUnitOfWork.SaveChanges
        _context.SaveChanges()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        _context.Dispose()
    End Sub
End Class
