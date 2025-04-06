Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.ModelConfiguration

Public Class UserConfiguration
    Inherits EntityTypeConfiguration(Of User)

    Public Sub New()
        ' Primary Key
        Me.HasKey(Function(u) u.UserId)

        ' Name - Required, Max Length 100
        Me.Property(Function(u) u.FirstName).
            IsRequired().
            HasMaxLength(100)
        Me.Property(Function(u) u.LastName).
            IsRequired().
            HasMaxLength(100)
        ' Username - Required, Max Length 50
        Me.Property(Function(u) u.Username).
            IsRequired().
            HasMaxLength(50)

        ' PasswordHash - Required, Max Length 255
        Me.Property(Function(u) u.PasswordHash).
            IsRequired().
            HasMaxLength(255)

        ' Contact Number - Max Length 15 (Optional)
        Me.Property(Function(u) u.ContactNumber).
            HasMaxLength(15).
            IsOptional()

        ' Email - Max Length 100 (Optional)
        Me.Property(Function(u) u.Email).
            HasMaxLength(100).
            IsOptional()

        ' Role - Required, Max Length 50
        Me.Property(Function(u) u.Role).
            IsRequired().
            HasMaxLength(50)

        ' Address - Max Length 200 (Optional)
        Me.Property(Function(u) u.Address).
            HasMaxLength(200).
            IsOptional()

        ' Created At - Required
        Me.Property(Function(u) u.CreatedAt).
            IsRequired()
    End Sub
End Class
