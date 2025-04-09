Public Class UnitOfWork
    Implements IUnitOfWork, IDisposable

    Public ReadOnly _context As AppDbContext
    Public ReadOnly Property Menus As IBaseRepository(Of Menu) Implements IUnitOfWork.Menus
    Public ReadOnly Property Customers As IBaseRepository(Of Customer) Implements IUnitOfWork.Customers
    Public ReadOnly Property Orders As IBaseRepository(Of Order) Implements IUnitOfWork.Orders
    Public ReadOnly Property OrderItems As IBaseRepository(Of OrderItem) Implements IUnitOfWork.OrderItems
    Public ReadOnly Property Suppliers As IBaseRepository(Of Supplier) Implements IUnitOfWork.Suppliers
    Public ReadOnly Property Transactions As IBaseRepository(Of Transaction) Implements IUnitOfWork.Transactions
    Public ReadOnly Property Inventories As IBaseRepository(Of Inventory) Implements IUnitOfWork.Inventories
    Public ReadOnly Property Users As UsersRepository Implements IUnitOfWork.Users
    Public ReadOnly Property SupplierTransactions As IBaseRepository(Of SupplierTransactionModel) Implements IUnitOfWork.SupplierTransactions

    Public Sub New(context As AppDbContext)
        _context = context
        Users = New UsersRepository(_context)
        Menus = New MenuRepository(_context)
        Customers = New CustomersRepository(_context)
        Orders = New OrdersRepository(_context)
        OrderItems = New OrderItemsRepository(_context)
        Suppliers = New SuppliersRepository(_context)
        Transactions = New TransactionsRepository(_context)
        Inventories = New InventoriesRepository(_context)
        SupplierTransactions = New SupplierTransactionsRepository(_context)
    End Sub

    Public Sub SaveChanges() Implements IUnitOfWork.SaveChanges
        _context.SaveChanges()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        _context.Dispose()
    End Sub
End Class
