Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.ModelConfiguration

Public Class OrderConfiguration
    Inherits EntityTypeConfiguration(Of Order)

    Public Sub New()
        ' Primary Key
        Me.HasKey(Function(o) o.OrderId)

        ' Required Fields
        Me.Property(Function(o) o.OrderDate).IsRequired()
        Me.Property(Function(o) o.TotalAmount).IsRequired()
        Me.Property(Function(o) o.CreatedAt).
            IsRequired().
            HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)

        ' Foreign Key: Order has one User (Staff)
        Me.HasRequired(Function(o) o.User).
            WithMany().
            HasForeignKey(Function(o) o.UserId).
            WillCascadeOnDelete(False)

        ' Foreign Key: Order has many OrderItems
        Me.HasMany(Function(o) o.OrderItems).
            WithRequired(Function(oi) oi.Order).
            HasForeignKey(Function(oi) oi.OrderId). ' ✅ Corrected Foreign Key
            WillCascadeOnDelete(True)
    End Sub
End Class
