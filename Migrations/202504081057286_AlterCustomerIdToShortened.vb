Imports System.Data.Entity.Migrations

Partial Public Class AlterColumnsForMultipleTables
    Inherits DbMigration

    Public Overrides Sub Up()
        ' Modify CustomerId column in Customers table to be of max length 10
        AlterColumn("dbo.Customers", "CustomerId", Function(c) c.String(nullable:=False, maxLength:=10))

        ' Modify MenuId column in Menus table to be of max length 10
        AlterColumn("dbo.Menus", "MenuId", Function(c) c.String(nullable:=False, maxLength:=10))

        ' Modify OrderId column in Orders table to be of max length 10
        AlterColumn("dbo.Orders", "OrderId", Function(c) c.String(nullable:=False, maxLength:=10))

        ' Modify OrderItemId column in OrderItems table to be of max length 10
        AlterColumn("dbo.OrderItems", "OrderItemId", Function(c) c.String(nullable:=False, maxLength:=10))

        ' Modify SupplierId column in Suppliers table to be of max length 10
        AlterColumn("dbo.Suppliers", "SupplierId", Function(c) c.String(nullable:=False, maxLength:=10))

        ' Modify TransactionId column in Transactions table to be of max length 10
        AlterColumn("dbo.Transactions", "TransactionId", Function(c) c.String(nullable:=False, maxLength:=10))

        ' Modify UserId column in Users table to be of max length 10
        AlterColumn("dbo.Users", "UserId", Function(c) c.String(nullable:=False, maxLength:=10))

        ' Modify InventoryId column in Inventories table to be of max length 10
        AlterColumn("dbo.Inventories", "InventoryId", Function(c) c.String(nullable:=False, maxLength:=10))
    End Sub

    Public Overrides Sub Down()
        ' Revert CustomerId column in Customers table back to original
        AlterColumn("dbo.Customers", "CustomerId", Function(c) c.String(nullable:=False))

        ' Revert MenuId column in Menus table back to original
        AlterColumn("dbo.Menus", "MenuId", Function(c) c.String(nullable:=False))

        ' Revert OrderId column in Orders table back to original
        AlterColumn("dbo.Orders", "OrderId", Function(c) c.String(nullable:=False))

        ' Revert OrderItemId column in OrderItems table back to original
        AlterColumn("dbo.OrderItems", "OrderItemId", Function(c) c.String(nullable:=False))

        ' Revert SupplierId column in Suppliers table back to original
        AlterColumn("dbo.Suppliers", "SupplierId", Function(c) c.String(nullable:=False))

        ' Revert TransactionId column in Transactions table back to original
        AlterColumn("dbo.Transactions", "TransactionId", Function(c) c.String(nullable:=False))

        ' Revert UserId column in Users table back to original
        AlterColumn("dbo.Users", "UserId", Function(c) c.String(nullable:=False))

        ' Revert InventoryId column in Inventories table back to original
        AlterColumn("dbo.Inventories", "InventoryId", Function(c) c.String(nullable:=False))
    End Sub
End Class
