Imports System.Data.Entity.ModelConfiguration

Public Class ItBDeductionConfiguration
    Inherits EntityTypeConfiguration(Of ItemToBatchDeduction)

    Public Sub New()
        Me.HasKey(Function(itb) itb.ItB_Id)

        Me.Property(Function(itb) itb.ItB_Id) _
            .IsRequired().HasMaxLength(50)

        Me.Property(Function(itb) itb.AmountDeducted) _
            .IsRequired()

        Me.HasRequired(Function(itb) itb.Batch) _
            .WithMany() _
            .HasForeignKey(Function(itb) itb.BatchId) _
            .WillCascadeOnDelete(False)

        Me.HasRequired(Function(itb) itb.Version) _
            .WithMany() _
            .HasForeignKey(Function(itb) itb.VersionId) _
            .WillCascadeOnDelete(False)

        Me.HasRequired(Function(itb) itb.Order) _
            .WithMany() _
            .HasForeignKey(Function(itb) itb.OrderId) _
            .WillCascadeOnDelete(False)

        Me.HasRequired(Function(itb) itb.BaseItem) _
            .WithMany() _
            .HasForeignKey(Function(itb) itb.BaseItemId) _
            .WillCascadeOnDelete(False)
    End Sub
End Class
