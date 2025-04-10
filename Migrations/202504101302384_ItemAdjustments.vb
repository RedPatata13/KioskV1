Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class ItemAdjustments
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems")
            DropForeignKey("dbo.AdminItems", "SupplierItemId", "dbo.SupplierItems")
            DropIndex("dbo.AdminItems", New String() { "SupplierItemId" })
            DropIndex("dbo.CustomerItems", New String() { "AdminItemId" })
            DropPrimaryKey("dbo.AdminItems")
            DropPrimaryKey("dbo.SupplierItems")
            AddColumn("dbo.AdminItems", "SellingCost", Function(c) c.Decimal(nullable := False, precision := 18, scale := 2))
            AddColumn("dbo.AdminItems", "ImageFilePath", Function(c) c.String(maxLength := 255))
            AddColumn("dbo.SupplierItems", "StockCount", Function(c) c.Int(nullable := False))
            AlterColumn("dbo.AdminItems", "Id", Function(c) c.String(nullable := False, maxLength := 50))
            AlterColumn("dbo.AdminItems", "Name", Function(c) c.String(nullable := False, maxLength := 100))
            AlterColumn("dbo.AdminItems", "Description", Function(c) c.String(maxLength := 255))
            AlterColumn("dbo.AdminItems", "SupplierItemId", Function(c) c.String(nullable := False, maxLength := 50))
            AlterColumn("dbo.SupplierItems", "Id", Function(c) c.String(nullable := False, maxLength := 50))
            AlterColumn("dbo.CustomerItems", "AdminItemId", Function(c) c.String(maxLength := 50))
            AddPrimaryKey("dbo.AdminItems", "Id")
            AddPrimaryKey("dbo.SupplierItems", "Id")
            CreateIndex("dbo.AdminItems", "SupplierItemId")
            CreateIndex("dbo.CustomerItems", "AdminItemId")
            AddForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems", "Id")
            AddForeignKey("dbo.AdminItems", "SupplierItemId", "dbo.SupplierItems", "Id")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.AdminItems", "SupplierItemId", "dbo.SupplierItems")
            DropForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems")
            DropIndex("dbo.CustomerItems", New String() { "AdminItemId" })
            DropIndex("dbo.AdminItems", New String() { "SupplierItemId" })
            DropPrimaryKey("dbo.SupplierItems")
            DropPrimaryKey("dbo.AdminItems")
            AlterColumn("dbo.CustomerItems", "AdminItemId", Function(c) c.String(maxLength := 128))
            AlterColumn("dbo.SupplierItems", "Id", Function(c) c.String(nullable := False, maxLength := 128))
            AlterColumn("dbo.AdminItems", "SupplierItemId", Function(c) c.String(nullable := False, maxLength := 128))
            AlterColumn("dbo.AdminItems", "Description", Function(c) c.String())
            AlterColumn("dbo.AdminItems", "Name", Function(c) c.String())
            AlterColumn("dbo.AdminItems", "Id", Function(c) c.String(nullable := False, maxLength := 128))
            DropColumn("dbo.SupplierItems", "StockCount")
            DropColumn("dbo.AdminItems", "ImageFilePath")
            DropColumn("dbo.AdminItems", "SellingCost")
            AddPrimaryKey("dbo.SupplierItems", "Id")
            AddPrimaryKey("dbo.AdminItems", "Id")
            CreateIndex("dbo.CustomerItems", "AdminItemId")
            CreateIndex("dbo.AdminItems", "SupplierItemId")
            AddForeignKey("dbo.AdminItems", "SupplierItemId", "dbo.SupplierItems", "Id")
            AddForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems", "Id")
        End Sub
    End Class
End Namespace
