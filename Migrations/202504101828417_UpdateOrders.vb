Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class UpdateOrders
        Inherits DbMigration
    
        Public Overrides Sub Up()
            'DropForeignKey("dbo.Orders", "User_UserId", "dbo.Users")
            'DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders")
            'DropIndex("dbo.OrderItems", New String() { "OrderId" })
            'DropIndex("dbo.Orders", New String() { "User_UserId" })
            CreateTable(
                "dbo.OrderPrimals",
                Function(c) New With
                    {
                        .OrderId = c.String(nullable := False, maxLength := 128),
                        .TotalPrice = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .UserId = c.String(nullable := False),
                        .CreatedAt = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.OrderId)
            
            CreateTable(
                "dbo.OrderDetails",
                Function(c) New With
                    {
                        .OrderDetailsId = c.String(nullable := False, maxLength := 50),
                        .OrderId = c.String(nullable := False, maxLength := 128),
                        .CustomerItemId = c.String(nullable := False, maxLength := 128),
                        .Quantity = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.OrderDetailsId) _
                .ForeignKey("dbo.CustomerItems", Function(t) t.CustomerItemId) _
                .ForeignKey("dbo.OrderPrimals", Function(t) t.OrderId, cascadeDelete := True) _
                .Index(Function(t) t.OrderId) _
                .Index(Function(t) t.CustomerItemId)

            'AddColumn("dbo.OrderItems", "Order_OrderId", Function(c) c.String(maxLength := 128))
            'CreateIndex("dbo.OrderItems", "Order_OrderId")
            'AddForeignKey("dbo.OrderItems", "Order_OrderId", "dbo.OrderPrimals", "OrderId")
            'DropTable("dbo.Orders")
        End Sub
        
        Public Overrides Sub Down()
            CreateTable(
                "dbo.Orders",
                Function(c) New With
                    {
                        .OrderId = c.Int(nullable := False, identity := True),
                        .OrderDate = c.DateTime(nullable := False),
                        .TotalAmount = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .UserId = c.Int(nullable := False),
                        .CreatedAt = c.DateTime(nullable := False),
                        .User_UserId = c.String(maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.OrderId)

            'DropForeignKey("dbo.OrderItems", "Order_OrderId", "dbo.OrderPrimals")
            'DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.OrderPrimals")
            DropForeignKey("dbo.OrderDetails", "CustomerItemId", "dbo.CustomerItems")
            'DropIndex("dbo.OrderDetails", New String() { "CustomerItemId" })
            'DropIndex("dbo.OrderDetails", New String() { "OrderId" })
            'DropIndex("dbo.OrderItems", New String() { "Order_OrderId" })
            'DropColumn("dbo.OrderItems", "Order_OrderId")
            'DropTable("dbo.OrderDetails")
            DropTable("dbo.OrderPrimals")
            'CreateIndex("dbo.Orders", "User_UserId")
            'CreateIndex("dbo.OrderItems", "OrderId")
            'AddForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders", "OrderId", cascadeDelete := True)
            'AddForeignKey("dbo.Orders", "User_UserId", "dbo.Users", "UserId")
        End Sub
    End Class
End Namespace
