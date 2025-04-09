Imports System.Data.Entity.Migrations

Partial Public Class AlterColumnsForMultipleTables
    Inherits DbMigration

    Public Overrides Sub Up()
        AlterColumn("dbo.Customers", "CustomerId", Function(c) c.String(nullable:=False, maxLength:=10))

        AlterColumn("dbo.Menus", "MenuId", Function(c) c.String(nullable:=False, maxLength:=10))

        AlterColumn("dbo.Orders", "OrderId", Function(c) c.String(nullable:=False, maxLength:=10))

        AlterColumn("dbo.OrderItems", "OrderItemId", Function(c) c.String(nullable:=False, maxLength:=10))

        AlterColumn("dbo.Suppliers", "SupplierId", Function(c) c.String(nullable:=False, maxLength:=10))

        AlterColumn("dbo.Transactions", "TransactionId", Function(c) c.String(nullable:=False, maxLength:=10))

        AlterColumn("dbo.Users", "UserId", Function(c) c.String(nullable:=False, maxLength:=10))

        AlterColumn("dbo.Inventories", "InventoryId", Function(c) c.String(nullable:=False, maxLength:=10))
    End Sub

    Public Overrides Sub Down()
        AlterColumn("dbo.Customers", "CustomerId", Function(c) c.String(nullable:=False))

        AlterColumn("dbo.Menus", "MenuId", Function(c) c.String(nullable:=False))

        AlterColumn("dbo.Orders", "OrderId", Function(c) c.String(nullable:=False))

        AlterColumn("dbo.OrderItems", "OrderItemId", Function(c) c.String(nullable:=False))

        AlterColumn("dbo.Suppliers", "SupplierId", Function(c) c.String(nullable:=False))

        AlterColumn("dbo.Transactions", "TransactionId", Function(c) c.String(nullable:=False))

        AlterColumn("dbo.Users", "UserId", Function(c) c.String(nullable:=False))

        AlterColumn("dbo.Inventories", "InventoryId", Function(c) c.String(nullable:=False))
    End Sub
End Class
