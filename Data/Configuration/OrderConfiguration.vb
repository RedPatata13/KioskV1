Imports System.Data.Entity.ModelConfiguration

Public Class OrderConfiguration
    Inherits EntityTypeConfiguration(Of OrderPrimal)

    Public Sub New()
        ' Define the primary key
        Me.HasKey(Function(o) o.OrderId)

        ' Define properties and constraints
        Me.Property(Function(o) o.OrderId).
            IsRequired()

        Me.Property(Function(o) o.TotalPrice).
            IsRequired().
            HasPrecision(18, 2) ' Define decimal precision

        'Me.Property(Function(o) o.UserId).
        '    IsRequired()

        Me.Property(Function(o) o.CreatedAt).
            IsRequired()

        Me.Property(Function(o) o.OrderMode).IsOptional()

        '' Define the relationship between Order and User
        'Me.HasRequired(Function(o) o.User) _
        '    .WithMany() _
        '    .HasForeignKey(Function(o) o.UserId) _
        '    .WillCascadeOnDelete(False)

        ' Define the relationship between Order and OrderItems
        Me.HasMany(Function(o) o.OrderItems) _
            .WithRequired() _
            .HasForeignKey(Function(oi) oi.OrderId) _
            .WillCascadeOnDelete(True)
    End Sub
End Class