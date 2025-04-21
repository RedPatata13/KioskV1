Imports System.Data.Entity.ModelConfiguration

Public Class OrderDetailsConfiguration
    Inherits EntityTypeConfiguration(Of OrderDetail)

    Public Sub New()
        ' Define the primary key
        Me.HasKey(Function(od) od.OrderDetailsId)

        ' Define properties and constraints
        Me.Property(Function(od) od.OrderDetailsId).
            IsRequired().
            HasMaxLength(50) ' Adjust as needed

        Me.Property(Function(od) od.OrderId).
            IsRequired().
            HasMaxLength(50)

        Me.Property(Function(od) od.VersionId).
            IsRequired().
            HasMaxLength(50)

        ' Define relationships
        Me.HasRequired(Function(od) od.Order) _
            .WithMany() _
            .HasForeignKey(Function(od) od.OrderId) _
            .WillCascadeOnDelete(True)

        Me.HasRequired(Function(od) od.ItemVersion) _
            .WithMany() _
            .HasForeignKey(Function(od) od.VersionId) _
            .WillCascadeOnDelete(False)

        Me.HasRequired(Function(od) od.Item) _
            .WithMany() _
            .HasForeignKey(Function(od) od.ReferencedItemId) _
            .WillCascadeOnDelete(False)
    End Sub
End Class
