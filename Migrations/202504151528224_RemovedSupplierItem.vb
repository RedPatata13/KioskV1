Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class RemovedSupplierItem
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.AdminItems", "SupplierItemId", "dbo.SupplierItems")
            DropIndex("dbo.AdminItems", New String() { "CategoryId" })
            DropIndex("dbo.AdminItems", New String() { "SupplierItemId" })
            AlterColumn("dbo.AdminItems", "CategoryId", Function(c) c.String(maxLength := 128))
            CreateIndex("dbo.AdminItems", "CategoryId")
            DropColumn("dbo.AdminItems", "SupplierItemId")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.AdminItems", "SupplierItemId", Function(c) c.String(nullable := False, maxLength := 50))
            DropIndex("dbo.AdminItems", New String() { "CategoryId" })
            AlterColumn("dbo.AdminItems", "CategoryId", Function(c) c.String(nullable := False, maxLength := 128))
            CreateIndex("dbo.AdminItems", "SupplierItemId")
            CreateIndex("dbo.AdminItems", "CategoryId")
            AddForeignKey("dbo.AdminItems", "SupplierItemId", "dbo.SupplierItems", "Id")
        End Sub
    End Class
End Namespace
