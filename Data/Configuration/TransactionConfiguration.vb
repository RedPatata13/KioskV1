Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.ModelConfiguration

Public Class TransactionConfiguration
    Inherits EntityTypeConfiguration(Of Transaction)

    Public Sub New()
        ' Primary Key
        Me.HasKey(Function(t) t.TransactionId)

        ' Foreign Key: Transaction belongs to one User (Staff)
        Me.HasRequired(Function(t) t.User).
            WithMany().
            HasForeignKey(Function(t) t.UserId).
            WillCascadeOnDelete(False) ' Prevents user deletion from affecting transactions

        ' Foreign Key: Transaction is associated with one Product
        Me.HasRequired(Function(t) t.Menu).
            WithMany().
            HasForeignKey(Function(t) t.MenuId).
            WillCascadeOnDelete(False) ' Prevents product deletion from affecting transactions

        ' Total Amount - Required, Must be Greater than 0
        Me.Property(Function(t) t.TotalAmount).
            IsRequired()

        ' Quantity - Required, Must be at least 1
        Me.Property(Function(t) t.Quantity).
            IsRequired()

        ' Price - Required, Must be Greater than 0
        Me.Property(Function(t) t.Price).
            IsRequired()

        ' Created At - Required
        Me.Property(Function(t) t.CreatedAt).
            IsRequired()
    End Sub
End Class
