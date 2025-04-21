Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class RemoveAdminItemsFromBatch
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.AdminItems", "BatchId", "dbo.InventoryBatches")
            AddColumn("dbo.AdminItems", "InventoryBatch_BatchId", Function(c) c.String(maxLength := 50))
            CreateIndex("dbo.AdminItems", "InventoryBatch_BatchId")
            AddForeignKey("dbo.AdminItems", "InventoryBatch_BatchId", "dbo.InventoryBatches", "BatchId")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.AdminItems", "InventoryBatch_BatchId", "dbo.InventoryBatches")
            DropIndex("dbo.AdminItems", New String() { "InventoryBatch_BatchId" })
            DropColumn("dbo.AdminItems", "InventoryBatch_BatchId")
            AddForeignKey("dbo.AdminItems", "BatchId", "dbo.InventoryBatches", "BatchId")
        End Sub
    End Class
End Namespace
