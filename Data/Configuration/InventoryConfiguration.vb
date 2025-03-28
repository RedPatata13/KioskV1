Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.ModelConfiguration

Public Class InventoryConfiguration
    Inherits EntityTypeConfiguration(Of Inventory)

    Public Sub New()
        ' Primary Key
        Me.HasKey(Function(i) i.InventoryId)

        Me.HasRequired(Function(i) i.Product).
            WithMany(Function(p) p.Inventories).
            HasForeignKey(Function(i) i.ProductId).
            WillCascadeOnDelete(False)

        ' Delivery Date and Time is required
        Me.Property(Function(i) i.DeliveryDateAndTime).
            IsRequired()

        ' Supplier is required and max length 100
        Me.Property(Function(i) i.Supplier).
            HasMaxLength(100).
            IsRequired()

        ' Quantity is required and must be at least 1
        Me.Property(Function(i) i.Quantity).
            IsRequired()

        ' Status is required and max length 50
        Me.Property(Function(i) i.Status).
            HasMaxLength(50).
            IsRequired()
    End Sub
End Class
