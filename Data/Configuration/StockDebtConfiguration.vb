Imports System.Data.Entity.ModelConfiguration

Public Class StockDebtConfiguration
    Inherits EntityTypeConfiguration(Of StockDebt)

    Public Sub New()
        Me.HasKey(Function(s) s.SD_Id)

        Me.Property(Function(s) s.SD_Id) _
            .IsRequired() _
            .HasMaxLength(50)

        Me.Property(Function(s) s.Units) _
            .IsRequired()

        Me.Property(Function(s) s.DateGenerated) _
            .IsRequired()

        Me.Property(Function(s) s.Status) _
            .IsRequired()

        Me.Property(Function(s) s.Reason) _
            .IsRequired()

        Me.HasRequired(Function(s) s.GeneratedBy) _
            .WithMany() _
            .HasForeignKey(Function(s) s.GeneratorID) _
            .WillCascadeOnDelete(False)

        Me.HasRequired(Function(s) s.Item) _
            .WithMany() _
            .HasForeignKey(Function(s) s.ItemId) _
            .WillCascadeOnDelete(False)

        Me.Property(Function(s) s.IsResolved) _
            .IsOptional()

        Me.HasRequired(Function(s) s.Version) _
            .WithMany() _
            .HasForeignKey(Function(s) s.VersionId) _
            .WillCascadeOnDelete(False)
    End Sub
End Class
