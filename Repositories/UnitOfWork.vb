Public Class UnitOfWork
    Implements IUnitOfWork, IDisposable

    Private ReadOnly _context As AppDbContext

    Public ReadOnly Property Users As IBaseRepository(Of User) Implements IUnitOfWork.Users
    Public ReadOnly Property Products As IBaseRepository(Of Product) Implements IUnitOfWork.Products
    Public ReadOnly Property Customers As IBaseRepository(Of Customer) Implements IUnitOfWork.Customers
    Public ReadOnly Property Orders As IBaseRepository(Of Order) Implements IUnitOfWork.Orders
    Public ReadOnly Property OrderItems As IBaseRepository(Of OrderItem) Implements IUnitOfWork.OrderItems
    Public ReadOnly Property Suppliers As IBaseRepository(Of Supplier) Implements IUnitOfWork.Supliers
    Public ReadOnly Property Transactions As IBaseRepository(Of Transaction) Implements IUnitOfWork.Transactions
    Public ReadOnly Property Inventories As IBaseRepository(Of Inventory) Implements IUnitOfWork.Invertories

    Public Sub New(context As AppDbContext)
        _context = context
        Users = New UsersRepository(_context)
        Products = New ProductsRepository(_context)
        Customers = New CustomersRepository(_context)
        Orders = New OrdersRepository(_context)
        OrderItems = New OrderItemsRepository(_context)
        Suppliers = New SuppliersRepository(_context)
        Transactions = New TransactionsRepository(_context)
        Inventories = New InventoriesRepository(_context)

    End Sub

    Public Sub SaveChanges() Implements IUnitOfWork.SaveChanges
        _context.SaveChanges()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        _context.Dispose()
    End Sub
End Class
