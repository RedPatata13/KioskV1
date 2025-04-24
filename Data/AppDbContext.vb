Imports System.Data.Entity
Imports System.Reflection.Emit


Public Class KioskDbContext
    Inherits DbContext

    Public Property CustomerItems As DbSet(Of CustomerItem)
    Public Property AdminItems As DbSet(Of AdminItem)
    Public Property SupplierItems As DbSet(Of SupplierItem)
    Public Property Users As DbSet(Of User)
    Public Property Suppliers As DbSet(Of Supplier)
    Public Property Categories As DbSet(Of Category)
    Public Property OrderItems As DbSet(Of OrderItem)
    Public Property OrderDetails As DbSet(Of OrderDetail)
    Public Property OrderPrimals As DbSet(Of OrderPrimal)
    Public Property InventoryBatches As DbSet(Of InventoryBatch)
    Public Property TransactedOrder As DbSet(Of TransactedOrder)
    Public Property AdminItemVersions As DbSet(Of AdminItemVersion)
    Public Property Deductions As DbSet(Of ItemToBatchDeduction)
    Public Property StockDebts As DbSet(Of StockDebt)

    Public Sub New()
        MyBase.New(JsonConfigReader.GetConnectionString())
    End Sub
    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        modelBuilder.Configurations.Add(New CategoryConfiguration())
        modelBuilder.Configurations.Add(New MenuConfiguration())
        modelBuilder.Configurations.Add(New SupplierConfiguration())
        modelBuilder.Configurations.Add(New SupplierItemConfiguration())
        modelBuilder.Configurations.Add(New AdminItemConfiguration())
        modelBuilder.Configurations.Add(New OrderConfiguration())
        modelBuilder.Configurations.Add(New OrderDetailsConfiguration())
        modelBuilder.Configurations.Add(New TransactedOrderConfiguration())
        modelBuilder.Configurations.Add(New AdminItemVersionConfiguration())
        modelBuilder.Configurations.Add(New ItBDeductionConfiguration())
        modelBuilder.Configurations.Add(New StockDebtConfiguration())
        modelBuilder.Configurations.Add(New BatchRequestConfiguration())
        'modelBuilder.Configurations.Add(New )
        modelBuilder.Entity(Of CustomerItem)() _
            .HasOptional(Function(c) c.AdminItem) _
            .WithMany() _
            .HasForeignKey(Function(c) c.AdminItemId) _
            .WillCascadeOnDelete(False) ' Prevent cascading delete for AdminItem    
        MyBase.OnModelCreating(modelBuilder)
        modelBuilder.Configurations.Add(New InventoryBatchConfiguration())
    End Sub
End Class


