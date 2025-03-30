Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.ModelConfiguration

Public Class OrderItemConfiguration
    Inherits EntityTypeConfiguration(Of OrderItem)

    Public Sub New()
        ' Primary Key
        Me.HasKey(Function(oi) oi.OrderItemId)

        ' Foreign Key: OrderItem belongs to one Product
        Me.HasRequired(Function(oi) oi.Product).
            WithMany().
            HasForeignKey(Function(oi) oi.ProductId).
            WillCascadeOnDelete(False) ' Prevent cascade delete

        ' Foreign Key: OrderItem belongs to one Order
        Me.HasRequired(Function(oi) oi.Order).
            WithMany(Function(o) o.OrderItems).
            HasForeignKey(Function(oi) oi.OrderId).
            WillCascadeOnDelete(True) ' Deletes order items when order is deleted

        ' TotalAmount is required
        Me.Property(Function(oi) oi.TotalAmount).
            IsRequired()

        ' Quantity is required (minimum value 1)
        Me.Property(Function(oi) oi.Quantity).
            IsRequired()

        ' Price is required (minimum value 0.01)
        Me.Property(Function(oi) oi.Price).
            IsRequired()
    End Sub
End Class
