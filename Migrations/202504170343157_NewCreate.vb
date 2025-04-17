Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class NewCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.AdminItems",
                Function(c) New With
                    {
                        .Id = c.String(nullable := False, maxLength := 128),
                        .Name = c.String(),
                        .Description = c.String(),
                        .CategoryId = c.String(nullable := False, maxLength := 128),
                        .SupplierItemId = c.String(nullable := False, maxLength := 50),
                        .SellingCost = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .ImageFilePath = c.String(),
                        .IsDisplayedAsCustomerItem = c.Boolean(nullable := False),
                        .BatchId = c.String(maxLength := 50)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.InventoryBatches", Function(t) t.BatchId) _
                .ForeignKey("dbo.Categories", Function(t) t.CategoryId) _
                .ForeignKey("dbo.SupplierItems", Function(t) t.SupplierItemId) _
                .Index(Function(t) t.CategoryId) _
                .Index(Function(t) t.SupplierItemId) _
                .Index(Function(t) t.BatchId)
            
            CreateTable(
                "dbo.InventoryBatches",
                Function(c) New With
                    {
                        .BatchId = c.String(nullable := False, maxLength := 50),
                        .SupplierId = c.String(nullable := False, maxLength := 128),
                        .SupplierItemId = c.String(nullable := False, maxLength := 50),
                        .QuantityReceived = c.Int(nullable := False),
                        .RemainingQuantity = c.Int(nullable := False),
                        .UnitCost = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .ReceivedDate = c.DateTime(nullable := False),
                        .ExpiryDate = c.DateTime(),
                        .BatchNumber = c.String(nullable := False, maxLength := 100),
                        .IsActive = c.Boolean(nullable := False),
                        .IsDeprecated = c.Boolean(nullable := False),
                        .DeprecationReason = c.String(maxLength := 500),
                        .DeprecatedDate = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.BatchId) _
                .ForeignKey("dbo.Suppliers", Function(t) t.SupplierId) _
                .ForeignKey("dbo.SupplierItems", Function(t) t.SupplierItemId) _
                .Index(Function(t) t.SupplierId) _
                .Index(Function(t) t.SupplierItemId)
            
            CreateTable(
                "dbo.Users",
                Function(c) New With
                    {
                        .UserId = c.String(nullable := False, maxLength := 128),
                        .FirstName = c.String(),
                        .LastName = c.String(),
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
                "dbo.SupplierItems",
                Function(c) New With
                    {
                        .Id = c.String(nullable := False, maxLength := 50),
                        .Name = c.String(nullable := False, maxLength := 100),
                        .Description = c.String(maxLength := 500),
                        .SupplierId = c.String(nullable := False, maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Suppliers", Function(t) t.SupplierId) _
                .Index(Function(t) t.SupplierId)
            
            CreateTable(
                "dbo.Categories",
                Function(c) New With
                    {
                        .CategoryId = c.String(nullable := False, maxLength := 128),
                        .CategoryName = c.String(nullable := False, maxLength := 100)
                    }) _
                .PrimaryKey(Function(t) t.CategoryId)
            
            CreateTable(
                "dbo.CustomerItems",
                Function(c) New With
                    {
                        .Id = c.String(nullable := False, maxLength := 128),
                        .Name = c.String(),
                        .Description = c.String(),
                        .AdminItemId = c.String(maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.AdminItems", Function(t) t.AdminItemId) _
                .Index(Function(t) t.AdminItemId)
            
            CreateTable(
                "dbo.OrderItems",
                Function(c) New With
                    {
                        .OrderItemId = c.Int(nullable := False, identity := True),
                        .OrderId = c.Int(nullable := False),
                        .MenuId = c.Int(nullable := False),
                        .TotalAmount = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Quantity = c.Int(nullable := False),
                        .Price = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Order_OrderId = c.String(maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.OrderItemId) _
                .ForeignKey("dbo.Menus", Function(t) t.MenuId, cascadeDelete := True) _
                .ForeignKey("dbo.OrderPrimals", Function(t) t.Order_OrderId) _
                .Index(Function(t) t.MenuId) _
                .Index(Function(t) t.Order_OrderId)
            
            CreateTable(
                "dbo.Menus",
                Function(c) New With
                    {
                        .MenuId = c.Int(nullable := False, identity := True),
                        .MenuName = c.String(nullable := False, maxLength := 100),
                        .Cost = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Selling = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Category = c.String(nullable := False, maxLength := 50),
                        .ProductDescription = c.String(maxLength := 500),
                        .Supplier = c.String(nullable := False, maxLength := 100),
                        .ProductImagePath = c.String(nullable := False, maxLength := 255)
                    }) _
                .PrimaryKey(Function(t) t.MenuId)
            
            CreateTable(
                "dbo.Inventories",
                Function(c) New With
                    {
                        .InventoryId = c.Int(nullable := False, identity := True),
                        .MenuId = c.Int(nullable := False),
                        .DeliveryDateAndTime = c.DateTime(nullable := False),
                        .Supplier = c.String(),
                        .Quantity = c.Int(nullable := False),
                        .Status = c.String()
                    }) _
                .PrimaryKey(Function(t) t.InventoryId) _
                .ForeignKey("dbo.Menus", Function(t) t.MenuId, cascadeDelete := True) _
                .Index(Function(t) t.MenuId)
            
            CreateTable(
                "dbo.OrderPrimals",
                Function(c) New With
                    {
                        .OrderId = c.String(nullable := False, maxLength := 128),
                        .TotalPrice = c.Decimal(nullable := False, precision := 18, scale := 2),
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
                .ForeignKey("dbo.AdminItems", Function(t) t.CustomerItemId) _
                .ForeignKey("dbo.OrderPrimals", Function(t) t.OrderId, cascadeDelete := True) _
                .Index(Function(t) t.OrderId) _
                .Index(Function(t) t.CustomerItemId)
            
            CreateTable(
                "dbo.Suppliers",
                Function(c) New With
                    {
                        .UserId = c.String(nullable := False, maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.UserId) _
                .ForeignKey("dbo.Users", Function(t) t.UserId) _
                .Index(Function(t) t.UserId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Suppliers", "UserId", "dbo.Users")
            DropForeignKey("dbo.OrderItems", "Order_OrderId", "dbo.OrderPrimals")
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.OrderPrimals")
            DropForeignKey("dbo.OrderDetails", "CustomerItemId", "dbo.AdminItems")
            DropForeignKey("dbo.OrderItems", "MenuId", "dbo.Menus")
            DropForeignKey("dbo.Inventories", "MenuId", "dbo.Menus")
            DropForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems")
            DropForeignKey("dbo.AdminItems", "SupplierItemId", "dbo.SupplierItems")
            DropForeignKey("dbo.AdminItems", "CategoryId", "dbo.Categories")
            DropForeignKey("dbo.InventoryBatches", "SupplierItemId", "dbo.SupplierItems")
            DropForeignKey("dbo.InventoryBatches", "SupplierId", "dbo.Suppliers")
            DropForeignKey("dbo.SupplierItems", "SupplierId", "dbo.Suppliers")
            DropForeignKey("dbo.AdminItems", "BatchId", "dbo.InventoryBatches")
            DropIndex("dbo.Suppliers", New String() { "UserId" })
            DropIndex("dbo.OrderDetails", New String() { "CustomerItemId" })
            DropIndex("dbo.OrderDetails", New String() { "OrderId" })
            DropIndex("dbo.Inventories", New String() { "MenuId" })
            DropIndex("dbo.OrderItems", New String() { "Order_OrderId" })
            DropIndex("dbo.OrderItems", New String() { "MenuId" })
            DropIndex("dbo.CustomerItems", New String() { "AdminItemId" })
            DropIndex("dbo.SupplierItems", New String() { "SupplierId" })
            DropIndex("dbo.InventoryBatches", New String() { "SupplierItemId" })
            DropIndex("dbo.InventoryBatches", New String() { "SupplierId" })
            DropIndex("dbo.AdminItems", New String() { "BatchId" })
            DropIndex("dbo.AdminItems", New String() { "SupplierItemId" })
            DropIndex("dbo.AdminItems", New String() { "CategoryId" })
            DropTable("dbo.Suppliers")
            DropTable("dbo.OrderDetails")
            DropTable("dbo.OrderPrimals")
            DropTable("dbo.Inventories")
            DropTable("dbo.Menus")
            DropTable("dbo.OrderItems")
            DropTable("dbo.CustomerItems")
            DropTable("dbo.Categories")
            DropTable("dbo.SupplierItems")
            DropTable("dbo.Users")
            DropTable("dbo.InventoryBatches")
            DropTable("dbo.AdminItems")
        End Sub
    End Class
End Namespace
