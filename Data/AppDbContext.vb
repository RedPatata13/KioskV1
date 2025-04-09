Imports System.Data.Entity
Public Class AppDbContext
    Inherits DbContext

    Public Sub New()
        MyBase.New(JsonConfigReader.GetConnectionString())
    End Sub

    Public Property Customers As DbSet(Of Customer)
    Public Property Inventories As DbSet(Of Inventory)
    Public Property Orders As DbSet(Of Order)
    Public Property OrderItems As DbSet(Of OrderItem)
    Public Property Menu As DbSet(Of Menu)
    Public Property Suppliers As DbSet(Of Supplier)
    Public Property Transactions As DbSet(Of Transaction)
    Public Property Users As DbSet(Of User)
    Public Property SupplierTransactions As DbSet(Of SupplierTransactionModel)

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        modelBuilder.Configurations.Add(New CustomerConfiguration())
        modelBuilder.Configurations.Add(New InventoryConfiguration())
        modelBuilder.Configurations.Add(New OrderConfiguration())
        modelBuilder.Configurations.Add(New OrderItemConfiguration())
        modelBuilder.Configurations.Add(New MenuConfiguration())
        modelBuilder.Configurations.Add(New SupplierConfiguration())
        modelBuilder.Configurations.Add(New TransactionConfiguration())
        modelBuilder.Configurations.Add(New UserConfiguration())
        modelBuilder.Configurations.Add(New SupplierTransactionConfiguration())
        MyBase.OnModelCreating(modelBuilder)
    End Sub
End Class
