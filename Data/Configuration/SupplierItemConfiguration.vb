Imports System.Data.Entity.ModelConfiguration

Public Class SupplierItemConfiguration
    Inherits EntityTypeConfiguration(Of SupplierItem)

    Public Sub New()
        ' Define the primary key
        Me.HasKey(Function(s) s.Id)

        ' Define properties and constraints
        Me.Property(Function(s) s.Name).
            HasMaxLength(100). ' Limit the length of Name to 100 characters
            IsRequired() ' Make sure Name is required

        Me.Property(Function(s) s.Description).
            HasMaxLength(255). ' Limit the length of Description to 255 characters
            IsOptional() ' Description is optional

        ' Define the relationship between SupplierItem and Supplier
        Me.HasRequired(Function(s) s.Supplier) _
            .WithMany() _  ' Supplier can have many SupplierItems (one-to-many)
            .HasForeignKey(Function(s) s.SupplierId) _  ' SupplierItem has SupplierId as the foreign key
            .WillCascadeOnDelete(False) ' Prevent cascade delete for SupplierItem

    End Sub
End Class
