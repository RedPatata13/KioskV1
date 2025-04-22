Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate1
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.OrderPrimals", "UserId", "dbo.Users")
            DropForeignKey("dbo.TransactedOrders", "OrderId", "dbo.OrderPrimals")
            DropForeignKey("dbo.TransactedOrders", "UserId", "dbo.Users")
            DropIndex("dbo.OrderPrimals", New String() { "UserId" })
            DropIndex("dbo.TransactedOrders", New String() { "UserId" })
            DropIndex("dbo.TransactedOrders", New String() { "OrderId" })
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
            
            DropColumn("dbo.OrderPrimals", "UserId")
            DropTable("dbo.TransactedOrders")
        End Sub
        
        Public Overrides Sub Down()
            CreateTable(
                "dbo.TransactedOrders",
                Function(c) New With
                    {
                        .TransactedOrderId = c.String(nullable := False, maxLength := 50),
                        .IsFinalized = c.Boolean(nullable := False),
                        .UserId = c.String(nullable := False, maxLength := 128),
                        .OrderId = c.String(nullable := False, maxLength := 128),
                        .SubTotal = c.Int(nullable := False),
                        .CashPaid = c.Int(nullable := False),
                        .Change = c.Int(nullable := False),
                        .DateTransacted = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.TransactedOrderId)
            
            AddColumn("dbo.OrderPrimals", "UserId", Function(c) c.String(maxLength := 128))
            DropForeignKey("dbo.SupplyRequests", "SupplierItem_Id", "dbo.SupplierItems")
            DropForeignKey("dbo.SupplyRequests", "SupplierID", "dbo.Suppliers")
            DropIndex("dbo.SupplyRequests", New String() { "SupplierItem_Id" })
            DropIndex("dbo.SupplyRequests", New String() { "SupplierID" })
            DropTable("dbo.SupplyRequests")
            CreateIndex("dbo.TransactedOrders", "OrderId")
            CreateIndex("dbo.TransactedOrders", "UserId")
            CreateIndex("dbo.OrderPrimals", "UserId")
            AddForeignKey("dbo.TransactedOrders", "UserId", "dbo.Users", "UserId")
            AddForeignKey("dbo.TransactedOrders", "OrderId", "dbo.OrderPrimals", "OrderId")
            AddForeignKey("dbo.OrderPrimals", "UserId", "dbo.Users", "UserId")
        End Sub
    End Class
End Namespace
