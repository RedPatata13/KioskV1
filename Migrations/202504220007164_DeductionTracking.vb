Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class DeductionTracking
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.ItemToBatchDeductions",
                Function(c) New With
                    {
                        .ItB_Id = c.String(nullable := False, maxLength := 50),
                        .AmountDeducted = c.Int(nullable := False),
                        .BatchId = c.String(nullable := False, maxLength := 50),
                        .BaseItemId = c.String(maxLength := 50),
                        .VersionId = c.String(nullable := False, maxLength := 50),
                        .OrderId = c.String(nullable := False, maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.ItB_Id) _
                .ForeignKey("dbo.AdminItems", Function(t) t.BaseItemId) _
                .ForeignKey("dbo.InventoryBatches", Function(t) t.BatchId) _
                .ForeignKey("dbo.OrderPrimals", Function(t) t.OrderId) _
                .ForeignKey("dbo.AdminItemVersions", Function(t) t.VersionId) _
                .Index(Function(t) t.BatchId) _
                .Index(Function(t) t.BaseItemId) _
                .Index(Function(t) t.VersionId) _
                .Index(Function(t) t.OrderId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.ItemToBatchDeductions", "VersionId", "dbo.AdminItemVersions")
            DropForeignKey("dbo.ItemToBatchDeductions", "OrderId", "dbo.OrderPrimals")
            DropForeignKey("dbo.ItemToBatchDeductions", "BatchId", "dbo.InventoryBatches")
            DropForeignKey("dbo.ItemToBatchDeductions", "BaseItemId", "dbo.AdminItems")
            DropIndex("dbo.ItemToBatchDeductions", New String() { "OrderId" })
            DropIndex("dbo.ItemToBatchDeductions", New String() { "VersionId" })
            DropIndex("dbo.ItemToBatchDeductions", New String() { "BaseItemId" })
            DropIndex("dbo.ItemToBatchDeductions", New String() { "BatchId" })
            DropTable("dbo.ItemToBatchDeductions")
        End Sub
    End Class
End Namespace
