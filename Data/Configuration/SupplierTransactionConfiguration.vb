Imports System.Data.Entity.ModelConfiguration

Public Class SupplierTransactionConfiguration
    Inherits EntityTypeConfiguration(Of SupplierTransactionModel)

    Public Sub New()
        Me.ToTable("SupplierTransactions")

        Me.HasKey(Function(t) t.BatchId)

        Me.HasRequired(Function(t) t.Menu) _
            .WithMany() _
            .HasForeignKey(Function(t) t.MenuId)

        Me.Property(Function(t) t.BatchId).HasMaxLength(10)
        Me.Property(Function(t) t.Status).IsRequired()
    End Sub
End Class
