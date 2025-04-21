Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddSupplyRequestConfiguration
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.SupplyRequests",
                Function(c) New With
                    {
                        .ID = c.String(nullable := False, maxLength := 50),
                        .SupplierID = c.String(nullable := False, maxLength := 128),
                        .ProductName = c.String(nullable := False, maxLength := 200),
                        .Quantity = c.Int(nullable := False),
                        .UnitCost = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Note = c.String(maxLength := 500),
                        .Status = c.String(nullable := False, maxLength := 50),
                        .CreatedAt = c.DateTime(nullable := False),
                        .SupplierItem_Id = c.String(maxLength := 50)
                    }) _
                .PrimaryKey(Function(t) t.ID) _
                .ForeignKey("dbo.Suppliers", Function(t) t.SupplierID) _
                .ForeignKey("dbo.SupplierItems", Function(t) t.SupplierItem_Id) _
                .Index(Function(t) t.SupplierID) _
                .Index(Function(t) t.SupplierItem_Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.SupplyRequests", "SupplierItem_Id", "dbo.SupplierItems")
            DropForeignKey("dbo.SupplyRequests", "SupplierID", "dbo.Suppliers")
            DropIndex("dbo.SupplyRequests", New String() { "SupplierItem_Id" })
            DropIndex("dbo.SupplyRequests", New String() { "SupplierID" })
            DropTable("dbo.SupplyRequests")
        End Sub
    End Class
End Namespace
