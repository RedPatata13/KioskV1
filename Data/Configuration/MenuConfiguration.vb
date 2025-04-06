Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.ModelConfiguration

Public Class MenuConfiguration
    Inherits EntityTypeConfiguration(Of Menu)

    Public Sub New()
        ' Primary Key
        Me.HasKey(Function(p) p.MenuId)

        ' Product Name - Required, Max Length 100
        Me.Property(Function(p) p.MenuName).
            IsRequired().
            HasMaxLength(100)

        ' Price - Required
        Me.Property(Function(p) p.Cost).
            IsRequired()

        Me.Property(Function(p) p.Selling).
            IsRequired()

        Me.Property(Function(p) p.Supplier).
            IsRequired().
            HasMaxLength(100)

        ' Category - Required, Max Length 50
        Me.Property(Function(p) p.Category).
            IsRequired().
            HasMaxLength(50)

        ' Description - Optional, Max Length 500
        Me.Property(Function(p) p.ProductDescription).
            HasMaxLength(500)

        ' Product Image Path - Required, Max Length 255
        Me.Property(Function(p) p.ProductImagePath).
            IsRequired().
            HasMaxLength(255)
    End Sub
End Class
