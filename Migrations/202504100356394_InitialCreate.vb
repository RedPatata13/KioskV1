Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.AdminItems",
                Function(c) New With
                    {
                        .Id = c.String(nullable := False, maxLength := 128),
                        .Name = c.String(),
                        .Description = c.String(),
                        .SupplierItemId = c.String(nullable := False, maxLength := 128),
                        .IsDisplayedAsCustomerItem = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.SupplierItems", Function(t) t.SupplierItemId) _
                .Index(Function(t) t.SupplierItemId)
            
            CreateTable(
                "dbo.SupplierItems",
                Function(c) New With
                    {
                        .Id = c.String(nullable := False, maxLength := 128),
                        .Name = c.String(nullable := False, maxLength := 100),
                        .Description = c.String(maxLength := 255),
                        .SupplierId = c.String(nullable := False, maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Suppliers", Function(t) t.SupplierId) _
                .Index(Function(t) t.SupplierId)
            
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
                "dbo.OrderItems",
                Function(c) New With
                    {
                        .OrderItemId = c.Int(nullable := False, identity := True),
                        .OrderId = c.Int(nullable := False),
                        .MenuId = c.Int(nullable := False),
                        .TotalAmount = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Quantity = c.Int(nullable := False),
                        .Price = c.Decimal(nullable := False, precision := 18, scale := 2)
                    }) _
                .PrimaryKey(Function(t) t.OrderItemId) _
                .ForeignKey("dbo.Menus", Function(t) t.MenuId, cascadeDelete := True) _
                .ForeignKey("dbo.Orders", Function(t) t.OrderId, cascadeDelete := True) _
                .Index(Function(t) t.OrderId) _
                .Index(Function(t) t.MenuId)
            
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
                .PrimaryKey(Function(t) t.OrderId) _
                .ForeignKey("dbo.Users", Function(t) t.User_UserId) _
                .Index(Function(t) t.User_UserId)
            
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
            DropForeignKey("dbo.Orders", "User_UserId", "dbo.Users")
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders")
            DropForeignKey("dbo.OrderItems", "MenuId", "dbo.Menus")
            DropForeignKey("dbo.Inventories", "MenuId", "dbo.Menus")
            DropForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems")
            DropForeignKey("dbo.AdminItems", "SupplierItemId", "dbo.SupplierItems")
            DropForeignKey("dbo.SupplierItems", "SupplierId", "dbo.Suppliers")
            DropIndex("dbo.Suppliers", New String() { "UserId" })
            DropIndex("dbo.Orders", New String() { "User_UserId" })
            DropIndex("dbo.OrderItems", New String() { "MenuId" })
            DropIndex("dbo.OrderItems", New String() { "OrderId" })
            DropIndex("dbo.Inventories", New String() { "MenuId" })
            DropIndex("dbo.CustomerItems", New String() { "AdminItemId" })
            DropIndex("dbo.SupplierItems", New String() { "SupplierId" })
            DropIndex("dbo.AdminItems", New String() { "SupplierItemId" })
            DropTable("dbo.Suppliers")
            DropTable("dbo.Orders")
            DropTable("dbo.OrderItems")
            DropTable("dbo.Inventories")
            DropTable("dbo.Menus")
            DropTable("dbo.CustomerItems")
            DropTable("dbo.Users")
            DropTable("dbo.SupplierItems")
            DropTable("dbo.AdminItems")
        End Sub
    End Class
End Namespace
