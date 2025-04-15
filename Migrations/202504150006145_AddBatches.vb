Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddBatches
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.InventoryBatches",
                Function(c) New With
                    {
                        .BatchId = c.String(nullable := False, maxLength := 50),
                        .SupplierId = c.String(nullable := False, maxLength := 128),
                        .SupplierItemId = c.String(nullable := False, maxLength := 50),
                        .QuantityReceived = c.Int(nullable := False),
                        .UnitCost = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .ReceivedDate = c.DateTime(nullable := False),
                        .ExpiryDate = c.DateTime(),
                        .BatchNumber = c.String(nullable := False, maxLength := 100),
                        .IsActive = c.Boolean(nullable := False),
                        .IsDeprecated = c.Boolean(nullable := False),
                        .DeprecationReason = c.String(maxLength := 500),
                        .DeprecatedDate = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.BatchId) _
                .ForeignKey("dbo.Suppliers", Function(t) t.SupplierId) _
                .ForeignKey("dbo.SupplierItems", Function(t) t.SupplierItemId) _
                .Index(Function(t) t.SupplierId) _
                .Index(Function(t) t.SupplierItemId)
            
            AddColumn("dbo.AdminItems", "BatchId", Function(c) c.String(maxLength := 50))
            AlterColumn("dbo.SupplierItems", "Description", Function(c) c.String(maxLength := 500))
            CreateIndex("dbo.AdminItems", "BatchId")
            AddForeignKey("dbo.AdminItems", "BatchId", "dbo.InventoryBatches", "BatchId")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.InventoryBatches", "SupplierItemId", "dbo.SupplierItems")
            DropForeignKey("dbo.InventoryBatches", "SupplierId", "dbo.Suppliers")
            DropForeignKey("dbo.AdminItems", "BatchId", "dbo.InventoryBatches")
            DropIndex("dbo.InventoryBatches", New String() { "SupplierItemId" })
            DropIndex("dbo.InventoryBatches", New String() { "SupplierId" })
            DropIndex("dbo.AdminItems", New String() { "BatchId" })
            AlterColumn("dbo.SupplierItems", "Description", Function(c) c.String(maxLength := 255))
            DropColumn("dbo.AdminItems", "BatchId")
            DropTable("dbo.InventoryBatches")
        End Sub
    End Class
End Namespace
