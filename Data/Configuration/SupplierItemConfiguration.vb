Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class SupplierItemConfiguration
    Inherits EntityTypeConfiguration(Of SupplierItem)

    Public Sub New()
        ' Primary Key
        Me.HasKey(Function(si) si.Id)

        ' Properties configuration
        Me.Property(Function(si) si.Id) _
        .HasMaxLength(50) _
        .IsRequired()

        Me.Property(Function(si) si.Name) _
        .HasMaxLength(100) _
        .IsRequired()

        Me.Property(Function(si) si.Description) _
        .HasMaxLength(500) _
        .IsOptional()

        Me.Property(Function(si) si.SupplierId) _
        .HasMaxLength(50) _
        .IsRequired()

        ' Relationships
        ' SupplierItem to Supplier (Many-to-One)
        Me.HasRequired(Function(si) si.Supplier) _
        .WithMany(Function(s) s.SupplierItems) _ ' Assuming Supplier has collection
        .HasForeignKey(Function(si) si.SupplierId) _
        .WillCascadeOnDelete(False)

        ' SupplierItem to InventoryBatches (One-to-Many)
        Me.HasMany(Function(si) si.Batches) _
        .WithRequired(Function(b) b.SupplierItem) _ ' Batch must have an InventoryItem
        .HasForeignKey(Function(b) b.SupplierItemId) _
        .WillCascadeOnDelete(False) ' Prevent cascade delete

        ' Indexes for performance
        'Me.HasIndex(Function(si) si.SupplierId) _
        '.HasName("IX_SupplierItem_SupplierId")

        'Me.HasIndex(Function(si) si.Name)
        '.HasName("IX_SupplierItem_Name")

        ' Table naming (if different from class name)
        Me.ToTable("SupplierItems")

        ' Optional: Add a computed column or complex type if needed
        'Me.Property(Function(si) si.FullDescription)
        '    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
    End Sub
End Class