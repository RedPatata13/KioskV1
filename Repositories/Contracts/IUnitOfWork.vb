﻿Public Interface IUnitOfWork
    Inherits IDisposable
    ReadOnly Property Users As UsersRepository
    ReadOnly Property Menus As MenuRepository
    ReadOnly Property Customers As IBaseRepository(Of Customer)
    ReadOnly Property Suppliers As IBaseRepository(Of Supplier)
    ReadOnly Property Inventories As IBaseRepository(Of Inventory)
    ReadOnly Property OrderItems As IBaseRepository(Of OrderItem)
    ReadOnly Property Transactions As IBaseRepository(Of Transaction)
    ReadOnly Property Orders As IBaseRepository(Of Order)
    Sub SaveChanges()
End Interface
