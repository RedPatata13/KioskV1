Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddedTransactions
        Inherits DbMigration
    
        Public Overrides Sub Up()
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
                .PrimaryKey(Function(t) t.TransactedOrderId) _
                .ForeignKey("dbo.OrderPrimals", Function(t) t.OrderId) _
                .ForeignKey("dbo.Users", Function(t) t.UserId) _
                .Index(Function(t) t.UserId) _
                .Index(Function(t) t.OrderId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.TransactedOrders", "UserId", "dbo.Users")
            DropForeignKey("dbo.TransactedOrders", "OrderId", "dbo.OrderPrimals")
            DropIndex("dbo.TransactedOrders", New String() { "OrderId" })
            DropIndex("dbo.TransactedOrders", New String() { "UserId" })
            DropTable("dbo.TransactedOrders")
        End Sub
    End Class
End Namespace
