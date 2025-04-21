Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AdminItemVersion
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.AdminItemVersions",
                Function(c) New With
                    {
                        .VersionId = c.String(nullable := False, maxLength := 50),
                        .Name = c.String(nullable := False, maxLength := 50),
                        .ImageFilePath = c.String(maxLength := 250),
                        .UnitCost = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .SellingCost = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .IsDisplayedAsACustomerItem = c.Boolean(nullable := False),
                        .IsCurrentVersion = c.Boolean(nullable := False),
                        .BaseItemId = c.String(nullable := False, maxLength := 50),
                        .CategoryId = c.String(nullable := False, maxLength := 128),
                        .BatchID = c.String(nullable := False, maxLength := 50)
                    }) _
                .PrimaryKey(Function(t) t.VersionId) _
                .ForeignKey("dbo.AdminItems", Function(t) t.BaseItemId) _
                .ForeignKey("dbo.InventoryBatches", Function(t) t.BatchID) _
                .ForeignKey("dbo.Categories", Function(t) t.CategoryId) _
                .Index(Function(t) t.BaseItemId) _
                .Index(Function(t) t.CategoryId) _
                .Index(Function(t) t.BatchID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.AdminItemVersions", "CategoryId", "dbo.Categories")
            DropForeignKey("dbo.AdminItemVersions", "BatchID", "dbo.InventoryBatches")
            DropForeignKey("dbo.AdminItemVersions", "BaseItemId", "dbo.AdminItems")
            DropIndex("dbo.AdminItemVersions", New String() { "BatchID" })
            DropIndex("dbo.AdminItemVersions", New String() { "CategoryId" })
            DropIndex("dbo.AdminItemVersions", New String() { "BaseItemId" })
            DropTable("dbo.AdminItemVersions")
        End Sub
    End Class
End Namespace
