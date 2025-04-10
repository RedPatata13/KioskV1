Imports System.Data.Entity.ModelConfiguration

Public Class CategoryConfiguration
    Inherits EntityTypeConfiguration(Of Category)

    Public Sub New()
        ' Define the primary key
        Me.HasKey(Function(c) c.CategoryId)

        ' Define properties and constraints
        Me.Property(Function(c) c.CategoryName) _
            .HasMaxLength(100) _ ' Limit the length of CategoryName to 100 characters
            .IsRequired() ' Make sure CategoryName is required

        ' Configure table name (optional)
        Me.ToTable("Categories")
    End Sub
End Class
