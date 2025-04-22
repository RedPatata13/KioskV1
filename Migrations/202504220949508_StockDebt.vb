Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class StockDebt
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.StockDebts",
                Function(c) New With
                    {
                        .SD_Id = c.String(nullable := False, maxLength := 50),
                        .ItemId = c.String(nullable := False, maxLength := 50),
                        .Units = c.Int(nullable := False),
                        .DateGenerated = c.DateTime(nullable := False),
                        .Status = c.String(nullable := False),
                        .Reason = c.String(nullable := False),
                        .GeneratorID = c.String(nullable := False, maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.SD_Id) _
                .ForeignKey("dbo.Users", Function(t) t.GeneratorID) _
                .ForeignKey("dbo.AdminItems", Function(t) t.ItemId) _
                .Index(Function(t) t.ItemId) _
                .Index(Function(t) t.GeneratorID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.StockDebts", "ItemId", "dbo.AdminItems")
            DropForeignKey("dbo.StockDebts", "GeneratorID", "dbo.Users")
            DropIndex("dbo.StockDebts", New String() { "GeneratorID" })
            DropIndex("dbo.StockDebts", New String() { "ItemId" })
            DropTable("dbo.StockDebts")
        End Sub
    End Class
End Namespace
