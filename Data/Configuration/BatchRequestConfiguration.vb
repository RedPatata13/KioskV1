Imports System.Data.Entity.ModelConfiguration

Public Class BatchRequestConfiguration
    Inherits EntityTypeConfiguration(Of BatchRequest)

    Public Sub New()
        Me.HasKey(Function(b) b.RequestID)

        Me.Property(Function(b) b.RequestID) _
            .IsRequired() _
            .HasMaxLength(50)

        Me.Property(Function(b) b.Units) _
            .IsRequired()

        Me.Property(Function(b) b.RequestMSG) _
            .IsRequired() _
            .HasMaxLength(250)

        Me.Property(Function(b) b.DateRequested) _
            .IsRequired()

        Me.Property(Function(B) B.IsPending) _
            .IsRequired()

        Me.HasRequired(Function(b) b.Requester) _
            .WithMany() _
            .HasForeignKey(Function(b) b.RequesterID) _
            .WillCascadeOnDelete(False)

        Me.HasRequired(Function(b) b.Item) _
            .WithMany() _
            .HasForeignKey(Function(b) b.ItemID) _
            .WillCascadeOnDelete(False)
    End Sub
End Class
