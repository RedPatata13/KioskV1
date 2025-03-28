Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.ModelConfiguration

Public Class ProductConfiguration
    Inherits EntityTypeConfiguration(Of Product)

    Public Sub New()
        ' Primary Key
        Me.HasKey(Function(p) p.ProductId)

        ' Product Name - Required, Max Length 100
        Me.Property(Function(p) p.ProductName).
            IsRequired().
            HasMaxLength(100)

        ' Price - Required
        Me.Property(Function(p) p.Price).
            IsRequired()

        ' Category - Required, Max Length 50
        Me.Property(Function(p) p.Category).
            IsRequired().
            HasMaxLength(50)

        ' Description - Optional, Max Length 500
        Me.Property(Function(p) p.Description).
            HasMaxLength(500)

        ' Product Image Path - Required, Max Length 255
        Me.Property(Function(p) p.ProductImagePath).
            IsRequired().
            HasMaxLength(255)
    End Sub
End Class
