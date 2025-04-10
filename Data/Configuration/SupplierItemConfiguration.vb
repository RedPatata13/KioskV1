Imports System.Data.Entity.ModelConfiguration
Imports System.Net

Public Class SupplierItemConfiguration
    Inherits EntityTypeConfiguration(Of SupplierItem)

    Public Sub New()
        ' Define the primary key
        'Me.Map(Function(s) s.ToTable("Suppliers"))
        Me.HasKey(Function(s) s.Id)

        ' Define properties and constraints
        Me.Property(Function(s) s.Id).
            IsRequired().
            HasMaxLength(50) ' Assuming GUID or short unique string ID

        Me.Property(Function(s) s.Name).
            IsRequired().
            HasMaxLength(100)

        Me.Property(Function(s) s.Description).
            IsOptional().
            HasMaxLength(255)

        Me.Property(Function(s) s.StockCount).
            IsRequired()
        Me.HasRequired(Function(s) s.Supplier) _
            .WithMany() _
            .HasForeignKey(Function(s) s.SupplierId) _
            .WillCascadeOnDelete(False)
    End Sub
End Class
