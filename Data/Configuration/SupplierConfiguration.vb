Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.ModelConfiguration

Public Class SupplierConfiguration
    Inherits EntityTypeConfiguration(Of Supplier)

    Public Sub New()
        ' Primary Key
        Me.HasKey(Function(s) s.SupplierId)

        ' Name - Required, Max Length 100
        Me.Property(Function(s) s.Name).
            IsRequired().
            HasMaxLength(100)

        ' Contact Number - Optional, Max Length 15
        Me.Property(Function(s) s.ContactNumber).
            HasMaxLength(15)

        ' Email - Optional, Max Length 100
        Me.Property(Function(s) s.Email).
            HasMaxLength(100)

        ' Created At - Required
        Me.Property(Function(s) s.CreatedAt).
            IsRequired()

        ' Address - Optional, Max Length 200
        Me.Property(Function(s) s.Address).
            HasMaxLength(200)

        ' Foreign Key: Supplier is linked to a Product
        Me.HasRequired(Function(s) s.Product).
            WithMany().
            HasForeignKey(Function(s) s.ProductId).
            WillCascadeOnDelete(False) ' Prevents automatic deletion of products when a supplier is deleted

        ' Ignore NotMapped Property
        Me.Ignore(Function(s) s.ProductName)
    End Sub
End Class
