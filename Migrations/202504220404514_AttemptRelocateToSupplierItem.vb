Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AttemptRelocateToSupplierItem
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.AdminItems", "SupplierItemId", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.SupplierItems", "UnitCost", Function(c) c.Decimal(nullable:=True, precision:=18, scale:=2))
            CreateIndex("dbo.AdminItems", "SupplierItemId")
            AddForeignKey("dbo.AdminItems", "SupplierItemId", "dbo.SupplierItems", "Id")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.AdminItems", "SupplierItemId", "dbo.SupplierItems")
            DropIndex("dbo.AdminItems", New String() { "SupplierItemId" })
            DropColumn("dbo.SupplierItems", "UnitCost")
            DropColumn("dbo.AdminItems", "SupplierItemId")
        End Sub
    End Class
End Namespace
