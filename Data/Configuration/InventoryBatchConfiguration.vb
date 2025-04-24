Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class InventoryBatchConfiguration
    Inherits EntityTypeConfiguration(Of InventoryBatch)

    Public Sub New()
        ' Primary Key
        Me.HasKey(Function(b) b.BatchId)

        ' Properties configuration
        Me.Property(Function(b) b.BatchId) _
        .HasMaxLength(50) _
        .IsRequired()

        Me.Property(Function(b) b.SupplierId) _
        .HasMaxLength(50) _
        .IsRequired()

        Me.Property(Function(b) b.SupplierItemId) _
        .HasMaxLength(50) _
        .IsRequired()

        Me.Property(Function(b) b.QuantityReceived) _
        .IsRequired()

        Me.Property(Function(b) b.RemainingQuantity) _
            .IsRequired()

        Me.Property(Function(b) b.UnitCost) _
        .HasPrecision(18, 2) _ ' Decimal precision for monetary value
        .IsRequired()

        Me.Property(Function(b) b.ReceivedDate) _
        .IsRequired()

        Me.Property(Function(b) b.BatchName) _
        .HasMaxLength(100) _
        .IsRequired()

        Me.Property(Function(b) b.IsActive) _
        .IsRequired()

        Me.Property(Function(b) b.IsDeprecated) _
        .IsRequired()

        Me.Property(Function(b) b.DeprecationReason) _
        .HasMaxLength(500) _
        .IsOptional()

        ' Relationships
        ' InventoryBatch to Supplier (Many-to-One)
        Me.HasRequired(Function(b) b.Supplier) _
        .WithMany() _ ' Assuming Supplier doesn't have a collection of batches
        .HasForeignKey(Function(b) b.SupplierId) _
        .WillCascadeOnDelete(False)

        ' InventoryBatch to InventoryItem (Many-to-One)
        Me.HasRequired(Function(b) b.SupplierItem) _
        .WithMany(Function(i) i.Batches) _
        .HasForeignKey(Function(b) b.SupplierItemId) _
        .WillCascadeOnDelete(False)

        ' InventoryBatch to AdminItems (One-to-Many)
        Me.HasMany(Function(b) b.AdminItems) _
        .WithRequired(Function(a) a.Batch) _ ' AdminItem may or may not have a batch _
        .HasForeignKey(Function(a) a.BatchId) _
        .WillCascadeOnDelete(False)



        ' Optional: Table naming convention
        Me.ToTable("InventoryBatches")
    End Sub
End Class