Imports System.Data.Entity.ModelConfiguration
Imports System.ComponentModel.DataAnnotations.Schema

Public Class SupplyRequestConfiguration
    Inherits EntityTypeConfiguration(Of SupplyRequest)

    Public Sub New()
        ' Primary Key
        Me.HasKey(Function(sr) sr.ID)

        ' Properties configuration
        Me.Property(Function(sr) sr.ID) _
            .HasMaxLength(50) _
            .IsRequired()

        Me.Property(Function(sr) sr.SupplierID) _
            .IsRequired() ' Assuming it's an integer or string, configure accordingly

        Me.Property(Function(sr) sr.ProductName) _
            .HasMaxLength(200) _
            .IsRequired()

        Me.Property(Function(sr) sr.Quantity) _
            .IsRequired()

        Me.Property(Function(sr) sr.Note) _
            .HasMaxLength(500) _
            .IsOptional()

        Me.Property(Function(sr) sr.Status) _
            .HasMaxLength(50) _
            .IsRequired()

        Me.Property(Function(sr) sr.CreatedAt) _
            .IsRequired()

        ' Relationships
        ' SupplyRequest to Supplier (Many-to-One)
        Me.HasRequired(Function(sr) sr.Supplier) _
            .WithMany(Function(s) s.SupplyRequests) _ ' Assuming Supplier has a collection of SupplyRequests
            .HasForeignKey(Function(sr) sr.SupplierID) _
            .WillCascadeOnDelete(False)

        ' Table naming (if different from class name)
        Me.ToTable("SupplyRequests")

        ' Optional: Add an index or any other database constraints as needed
        ' Me.HasIndex(Function(sr) sr.SupplierID) _
        '    .HasName("IX_SupplyRequest_SupplierID")
    End Sub
End Class
