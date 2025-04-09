Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Partial Public Class MakeUserIdNullable
        Inherits DbMigration

        Public Overrides Sub Up()
            ' Drop the index on UserId if it exists
            DropIndex("dbo.Orders", New String() {"UserId"})

            ' Alter the UserId column to allow null values
            AlterColumn("dbo.Orders", "UserId", Function(c) c.String(maxLength:=128, nullable:=True))

            ' Recreate the index on UserId
            CreateIndex("dbo.Orders", "UserId")
        End Sub

        Public Overrides Sub Down()
            ' Drop the index on UserId if we roll back the migration
            DropIndex("dbo.Orders", New String() {"UserId"})

            ' Revert UserId back to not nullable
            AlterColumn("dbo.Orders", "UserId", Function(c) c.String(nullable:=False, maxLength:=128))

            ' Recreate the index on UserId
            CreateIndex("dbo.Orders", "UserId")
        End Sub
    End Class
End Namespace
