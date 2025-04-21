Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Multiplicity
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems")
            DropForeignKey("dbo.OrderDetails", "CustomerItemId", "dbo.AdminItems")
            DropIndex("dbo.AdminItems", New String() { "CategoryId" })
            DropIndex("dbo.AdminItems", New String() { "BatchId" })
            DropIndex("dbo.CustomerItems", New String() { "AdminItemId" })
            DropIndex("dbo.OrderDetails", New String() { "CustomerItemId" })
            DropPrimaryKey("dbo.AdminItems")
            AlterColumn("dbo.AdminItems", "Id", Function(c) c.String(nullable := False, maxLength := 50))
            AlterColumn("dbo.AdminItems", "Name", Function(c) c.String(nullable := False, maxLength := 100))
            AlterColumn("dbo.AdminItems", "Description", Function(c) c.String(maxLength := 255))
            AlterColumn("dbo.AdminItems", "CategoryId", Function(c) c.String(nullable := False, maxLength := 128))
            AlterColumn("dbo.AdminItems", "ImageFilePath", Function(c) c.String(maxLength := 255))
            AlterColumn("dbo.AdminItems", "BatchId", Function(c) c.String(nullable := False, maxLength := 50))
            AlterColumn("dbo.CustomerItems", "AdminItemId", Function(c) c.String(maxLength := 50))
            AlterColumn("dbo.OrderDetails", "CustomerItemId", Function(c) c.String(nullable := False, maxLength := 50))
            AddPrimaryKey("dbo.AdminItems", "Id")
            CreateIndex("dbo.AdminItems", "CategoryId")
            CreateIndex("dbo.AdminItems", "BatchId")
            CreateIndex("dbo.CustomerItems", "AdminItemId")
            CreateIndex("dbo.OrderDetails", "CustomerItemId")
            AddForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems", "Id")
            AddForeignKey("dbo.OrderDetails", "CustomerItemId", "dbo.AdminItems", "Id")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.OrderDetails", "CustomerItemId", "dbo.AdminItems")
            DropForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems")
            DropIndex("dbo.OrderDetails", New String() { "CustomerItemId" })
            DropIndex("dbo.CustomerItems", New String() { "AdminItemId" })
            DropIndex("dbo.AdminItems", New String() { "BatchId" })
            DropIndex("dbo.AdminItems", New String() { "CategoryId" })
            DropPrimaryKey("dbo.AdminItems")
            AlterColumn("dbo.OrderDetails", "CustomerItemId", Function(c) c.String(nullable := False, maxLength := 128))
            AlterColumn("dbo.CustomerItems", "AdminItemId", Function(c) c.String(maxLength := 128))
            AlterColumn("dbo.AdminItems", "BatchId", Function(c) c.String(maxLength := 50))
            AlterColumn("dbo.AdminItems", "ImageFilePath", Function(c) c.String())
            AlterColumn("dbo.AdminItems", "CategoryId", Function(c) c.String(maxLength := 128))
            AlterColumn("dbo.AdminItems", "Description", Function(c) c.String())
            AlterColumn("dbo.AdminItems", "Name", Function(c) c.String())
            AlterColumn("dbo.AdminItems", "Id", Function(c) c.String(nullable := False, maxLength := 128))
            AddPrimaryKey("dbo.AdminItems", "Id")
            CreateIndex("dbo.OrderDetails", "CustomerItemId")
            CreateIndex("dbo.CustomerItems", "AdminItemId")
            CreateIndex("dbo.AdminItems", "BatchId")
            CreateIndex("dbo.AdminItems", "CategoryId")
            AddForeignKey("dbo.OrderDetails", "CustomerItemId", "dbo.AdminItems", "Id")
            AddForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems", "Id")
        End Sub
    End Class
End Namespace
