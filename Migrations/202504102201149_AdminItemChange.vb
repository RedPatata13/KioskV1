Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AdminItemChange
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems")
            DropIndex("dbo.CustomerItems", New String() { "AdminItemId" })
            DropPrimaryKey("dbo.AdminItems")
            AlterColumn("dbo.AdminItems", "Id", Function(c) c.String(nullable := False, maxLength := 128))
            AlterColumn("dbo.AdminItems", "Name", Function(c) c.String())
            AlterColumn("dbo.AdminItems", "Description", Function(c) c.String())
            AlterColumn("dbo.AdminItems", "ImageFilePath", Function(c) c.String())
            AlterColumn("dbo.CustomerItems", "AdminItemId", Function(c) c.String(maxLength := 128))
            AddPrimaryKey("dbo.AdminItems", "Id")
            CreateIndex("dbo.CustomerItems", "AdminItemId")
            AddForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems", "Id")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems")
            DropIndex("dbo.CustomerItems", New String() { "AdminItemId" })
            DropPrimaryKey("dbo.AdminItems")
            AlterColumn("dbo.CustomerItems", "AdminItemId", Function(c) c.String(maxLength := 50))
            AlterColumn("dbo.AdminItems", "ImageFilePath", Function(c) c.String(maxLength := 255))
            AlterColumn("dbo.AdminItems", "Description", Function(c) c.String(maxLength := 255))
            AlterColumn("dbo.AdminItems", "Name", Function(c) c.String(nullable := False, maxLength := 100))
            AlterColumn("dbo.AdminItems", "Id", Function(c) c.String(nullable := False, maxLength := 50))
            AddPrimaryKey("dbo.AdminItems", "Id")
            CreateIndex("dbo.CustomerItems", "AdminItemId")
            AddForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems", "Id")
        End Sub
    End Class
End Namespace
