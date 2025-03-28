Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Customers",
                Function(c) New With
                    {
                        .CustomerId = c.Int(nullable := False, identity := True),
                        .Name = c.String(maxLength := 100),
                        .Email = c.String(maxLength := 255),
                        .ContactNumber = c.String(maxLength := 15),
                        .CreatedAt = c.DateTime(nullable := False),
                        .OrderId = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.CustomerId) _
                .ForeignKey("dbo.Orders", Function(t) t.OrderId, cascadeDelete := True) _
                .Index(Function(t) t.OrderId)
            
            CreateTable(
                "dbo.Orders",
                Function(c) New With
                    {
                        .OrderId = c.Int(nullable := False, identity := True),
                        .OrderDate = c.DateTime(nullable := False),
                        .TotalAmount = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .StaffId = c.Int(nullable := False),
                        .CreatedAt = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.OrderId) _
                .ForeignKey("dbo.Users", Function(t) t.StaffId) _
                .Index(Function(t) t.StaffId)
            
            CreateTable(
                "dbo.OrderItems",
                Function(c) New With
                    {
                        .OrderItemId = c.Int(nullable := False, identity := True),
                        .OrderId = c.Int(nullable := False),
                        .ProductId = c.Int(nullable := False),
                        .TotalAmount = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Quantity = c.Int(nullable := False),
                        .Price = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Product_ProductId = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.OrderItemId) _
                .ForeignKey("dbo.Orders", Function(t) t.OrderId, cascadeDelete := True) _
                .ForeignKey("dbo.Products", Function(t) t.Product_ProductId) _
                .ForeignKey("dbo.Products", Function(t) t.ProductId) _
                .Index(Function(t) t.OrderId) _
                .Index(Function(t) t.ProductId) _
                .Index(Function(t) t.Product_ProductId)
            
            CreateTable(
                "dbo.Products",
                Function(c) New With
                    {
                        .ProductId = c.Int(nullable := False, identity := True),
                        .ProductName = c.String(nullable := False, maxLength := 100),
                        .Price = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Category = c.String(nullable := False, maxLength := 50),
                        .Description = c.String(maxLength := 500),
                        .ProductImagePath = c.String(nullable := False, maxLength := 255)
                    }) _
                .PrimaryKey(Function(t) t.ProductId)
            
            CreateTable(
                "dbo.Inventories",
                Function(c) New With
                    {
                        .InventoryId = c.Int(nullable := False, identity := True),
                        .ProductId = c.Int(nullable := False),
                        .DeliveryDateAndTime = c.DateTime(nullable := False),
                        .Supplier = c.String(nullable := False, maxLength := 100),
                        .Quantity = c.Int(nullable := False),
                        .Status = c.String(nullable := False, maxLength := 50)
                    }) _
                .PrimaryKey(Function(t) t.InventoryId) _
                .ForeignKey("dbo.Products", Function(t) t.ProductId) _
                .Index(Function(t) t.ProductId)
            
            CreateTable(
                "dbo.Users",
                Function(c) New With
                    {
                        .UserId = c.Int(nullable := False, identity := True),
                        .Name = c.String(),
                        .Username = c.String(),
                        .PasswordHash = c.String(),
                        .ContactNumber = c.String(),
                        .Email = c.String(),
                        .Role = c.String(),
                        .Address = c.String(),
                        .CreatedAt = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.UserId)
            
            CreateTable(
                "dbo.Suppliers",
                Function(c) New With
                    {
                        .SupplierId = c.Int(nullable := False, identity := True),
                        .Name = c.String(nullable := False, maxLength := 100),
                        .ContactNumber = c.String(maxLength := 15),
                        .Email = c.String(maxLength := 100),
                        .CreatedAt = c.DateTime(nullable := False),
                        .Address = c.String(maxLength := 200),
                        .ProductId = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.SupplierId) _
                .ForeignKey("dbo.Products", Function(t) t.ProductId) _
                .Index(Function(t) t.ProductId)
            
            CreateTable(
                "dbo.Transactions",
                Function(c) New With
                    {
                        .TransactionId = c.Int(nullable := False, identity := True),
                        .StaffId = c.Int(nullable := False),
                        .TotalAmount = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Quantity = c.Int(nullable := False),
                        .Price = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .ProductId = c.Int(nullable := False),
                        .CreatedAt = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.TransactionId) _
                .ForeignKey("dbo.Products", Function(t) t.ProductId) _
                .ForeignKey("dbo.Users", Function(t) t.StaffId) _
                .Index(Function(t) t.StaffId) _
                .Index(Function(t) t.ProductId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Transactions", "StaffId", "dbo.Users")
            DropForeignKey("dbo.Transactions", "ProductId", "dbo.Products")
            DropForeignKey("dbo.Suppliers", "ProductId", "dbo.Products")
            DropForeignKey("dbo.Customers", "OrderId", "dbo.Orders")
            DropForeignKey("dbo.Orders", "StaffId", "dbo.Users")
            DropForeignKey("dbo.OrderItems", "ProductId", "dbo.Products")
            DropForeignKey("dbo.OrderItems", "Product_ProductId", "dbo.Products")
            DropForeignKey("dbo.Inventories", "ProductId", "dbo.Products")
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders")
            DropIndex("dbo.Transactions", New String() { "ProductId" })
            DropIndex("dbo.Transactions", New String() { "StaffId" })
            DropIndex("dbo.Suppliers", New String() { "ProductId" })
            DropIndex("dbo.Inventories", New String() { "ProductId" })
            DropIndex("dbo.OrderItems", New String() { "Product_ProductId" })
            DropIndex("dbo.OrderItems", New String() { "ProductId" })
            DropIndex("dbo.OrderItems", New String() { "OrderId" })
            DropIndex("dbo.Orders", New String() { "StaffId" })
            DropIndex("dbo.Customers", New String() { "OrderId" })
            DropTable("dbo.Transactions")
            DropTable("dbo.Suppliers")
            DropTable("dbo.Users")
            DropTable("dbo.Inventories")
            DropTable("dbo.Products")
            DropTable("dbo.OrderItems")
            DropTable("dbo.Orders")
            DropTable("dbo.Customers")
        End Sub
    End Class
End Namespace
