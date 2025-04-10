Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddFK
        Inherits DbMigration

        Public Overrides Sub Up()
            AddForeignKey("dbo.AdminItems", "CategoryId", "dbo.Categories", "CategoryId")
        End Sub

        Public Overrides Sub Down()
            DropForeignKey("dbo.AdminItems", "CategoryId", "dbo.Categories")
        End Sub
    End Class
End Namespace
