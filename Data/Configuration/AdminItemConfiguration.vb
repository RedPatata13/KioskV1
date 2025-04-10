Imports System.Data.Entity.ModelConfiguration

Public Class AdminItemConfiguration
    Inherits EntityTypeConfiguration(Of AdminItem)

    Public Sub New()
        ' Define the primary key
        Me.HasKey(Function(a) a.Id)

        ' Define properties and constraints
        Me.Property(Function(a) a.Id).
            IsRequired().
            HasMaxLength(50) ' Adjust as needed

        Me.Property(Function(a) a.Name).
            IsRequired().
            HasMaxLength(100) ' Adjust as needed

        Me.Property(Function(a) a.Description).
            HasMaxLength(255).
            IsOptional()

        Me.Property(Function(a) a.SellingCost).
            IsRequired().
            HasPrecision(18, 2) ' Define decimal precision

        Me.Property(Function(a) a.ImageFilePath).
            HasMaxLength(255).
            IsOptional()

        Me.Property(Function(a) a.IsDisplayedAsCustomerItem).
            IsRequired()

        ' Define the relationship between AdminItem and SupplierItem
        Me.HasRequired(Function(a) a.SupplierItem) _
            .WithMany() _
            .HasForeignKey(Function(a) a.SupplierItemId) _
            .WillCascadeOnDelete(False) ' Prevent cascading delete
    End Sub
End Class
