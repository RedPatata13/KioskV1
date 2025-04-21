Imports System.Data.Entity.ModelConfiguration

Public Class TransactedOrderConfiguration
    Inherits EntityTypeConfiguration(Of TransactedOrder)

    Public Sub New()
        Me.HasKey(Function(s) s.TransactedOrderId)

        Me.Property(Function(s) s.TransactedOrderId) _
           .IsRequired() _
           .HasMaxLength(50)

        Me.Property(Function(s) s.IsFinalized) _
            .IsRequired()

        Me.HasRequired(Function(s) s.User) _
            .WithMany() _
            .HasForeignKey(Function(s) s.UserId) _
            .WillCascadeOnDelete(False)

        Me.HasRequired(Function(s) s.Order) _
            .WithMany() _
            .HasForeignKey(Function(s) s.OrderId) _
            .WillCascadeOnDelete(False)

        Me.Property(Function(s) s.SubTotal) _
            .IsRequired()

        Me.Property(Function(s) s.CashPaid) _
            .IsRequired()

        Me.Property(Function(s) s.Change) _
            .IsRequired()

        Me.Property(Function(s) s.DateTransacted) _
            .IsRequired()
    End Sub
End Class
