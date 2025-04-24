Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class BatchRequest
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.BatchRequests",
                Function(c) New With
                    {
                        .RequestID = c.String(nullable := False, maxLength := 50),
                        .RequestMSG = c.String(nullable := False, maxLength := 250),
                        .RequesterID = c.String(nullable := False, maxLength := 128),
                        .ItemID = c.String(nullable := False, maxLength := 50),
                        .DateRequested = c.DateTime(nullable := False),
                        .Units = c.Int(nullable := False),
                        .IsPending = c.Boolean(nullable := False),
                        .FinalResult = c.String()
                    }) _
                .PrimaryKey(Function(t) t.RequestID) _
                .ForeignKey("dbo.SupplierItems", Function(t) t.ItemID) _
                .ForeignKey("dbo.Users", Function(t) t.RequesterID) _
                .Index(Function(t) t.RequesterID) _
                .Index(Function(t) t.ItemID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.BatchRequests", "RequesterID", "dbo.Users")
            DropForeignKey("dbo.BatchRequests", "ItemID", "dbo.SupplierItems")
            DropIndex("dbo.BatchRequests", New String() { "ItemID" })
            DropIndex("dbo.BatchRequests", New String() { "RequesterID" })
            DropTable("dbo.BatchRequests")
        End Sub
    End Class
End Namespace
