Imports System.Data.Entity.Core.Common.EntitySql
Imports System.Data.Entity.ModelConfiguration

Public Class AdminItemVersionConfiguration
    Inherits EntityTypeConfiguration(Of AdminItemVersion)

    Public Sub New()
        Me.HasKey(Function(aivc) aivc.VersionId)

        Me.Property(Function(aivc) aivc.VersionId) _
            .IsRequired() _
            .HasMaxLength(50)

        'Me.Property(Function(aivc) aivc.BaseItem)
        Me.HasRequired(Function(aivc) aivc.BaseItem).
            WithMany().
            HasForeignKey(Function(aivc) aivc.BaseItemId).
            WillCascadeOnDelete(False)
        Me.Property(Function(aivc) aivc.Name) _
            .IsRequired() _
            .HasMaxLength(50)

        Me.Property(Function(aivc) aivc.ImageFilePath) _
            .HasMaxLength(250).
            IsOptional()

        Me.Property(Function(aivc) aivc.SellingCost) _
            .IsRequired() _
            .HasPrecision(18, 2)

        Me.Property(Function(aivc) aivc.UnitCost) _
            .IsRequired() _
            .HasPrecision(18, 2)
        Me.Property(Function(aivc) aivc.VersionUpdateReason) _
            .IsRequired() _
            .HasMaxLength(500)

        Me.Property(Function(aivc) aivc.IsDisplayedAsACustomerItem).
            IsRequired()

        Me.Property(Function(aivc) aivc.IsCurrentVersion).
            IsRequired()

        Me.HasRequired(Function(aivc) aivc.Category).
            WithMany().
            HasForeignKey(Function(aivc) aivc.CategoryId).
            WillCascadeOnDelete(False)

        Me.HasRequired(Function(aivc) aivc.Batch) _
            .WithMany() _
            .HasForeignKey(Function(aivc) aivc.BatchID) _
            .WillCascadeOnDelete(False)
    End Sub
End Class
