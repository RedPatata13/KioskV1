Imports System.Data.Entity.ModelConfiguration

Public Class SupplierConfiguration
    Inherits EntityTypeConfiguration(Of Supplier)

    Public Sub New()
        ' If Supplier inherits from User, we might need to define the inheritance strategy
        Me.Map(Function(s) s.ToTable("Suppliers")) ' Map Supplier to a specific table name
        Me.HasKey(Function(s) s.UserId)
        Me.HasMany(Function(s) s.SupplierItems).WithRequired().
            HasForeignKey(Function(si) si.SupplierId).
            WillCascadeOnDelete(True)
        ' Define any other properties or configurations needed for Supplier
    End Sub
End Class
