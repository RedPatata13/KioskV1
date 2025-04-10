Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Try2
        Inherits DbMigration
    
        Public Overrides Sub Up()
            RenameTable(name := "dbo.Users", newName := "Suppliers")
            DropIndex("dbo.SupplierItems", New String() { "Supplier_UserId" })
            DropColumn("dbo.SupplierItems", "SupplierId")
            RenameColumn(table := "dbo.SupplierItems", name := "Supplier_UserId", newName := "SupplierId")
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
            
            AlterColumn("dbo.SupplierItems", "Name", Function(c) c.String(nullable := False, maxLength := 100))
            AlterColumn("dbo.SupplierItems", "Description", Function(c) c.String(maxLength := 255))
            AlterColumn("dbo.SupplierItems", "SupplierId", Function(c) c.String(nullable := False, maxLength := 128))
            AlterColumn("dbo.SupplierItems", "SupplierId", Function(c) c.String(nullable := False, maxLength := 128))
            CreateIndex("dbo.SupplierItems", "SupplierId")
            CreateIndex("dbo.Suppliers", "UserId")
            AddForeignKey("dbo.Suppliers", "UserId", "dbo.Users", "UserId")
            DropColumn("dbo.Suppliers", "FirstName")
            DropColumn("dbo.Suppliers", "LastName")
            DropColumn("dbo.Suppliers", "Username")
            DropColumn("dbo.Suppliers", "PasswordHash")
            DropColumn("dbo.Suppliers", "ContactNumber")
            DropColumn("dbo.Suppliers", "Email")
            DropColumn("dbo.Suppliers", "Role")
            DropColumn("dbo.Suppliers", "Address")
            DropColumn("dbo.Suppliers", "CreatedAt")
            DropColumn("dbo.Suppliers", "Discriminator")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Suppliers", "Discriminator", Function(c) c.String(nullable := False, maxLength := 128))
            AddColumn("dbo.Suppliers", "CreatedAt", Function(c) c.DateTime(nullable := False))
            AddColumn("dbo.Suppliers", "Address", Function(c) c.String())
            AddColumn("dbo.Suppliers", "Role", Function(c) c.String())
            AddColumn("dbo.Suppliers", "Email", Function(c) c.String())
            AddColumn("dbo.Suppliers", "ContactNumber", Function(c) c.String())
            AddColumn("dbo.Suppliers", "PasswordHash", Function(c) c.String())
            AddColumn("dbo.Suppliers", "Username", Function(c) c.String())
            AddColumn("dbo.Suppliers", "LastName", Function(c) c.String())
            AddColumn("dbo.Suppliers", "FirstName", Function(c) c.String())
            DropForeignKey("dbo.Suppliers", "UserId", "dbo.Users")
            DropForeignKey("dbo.Orders", "User_UserId", "dbo.Users")
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders")
            DropForeignKey("dbo.OrderItems", "MenuId", "dbo.Menus")
            DropForeignKey("dbo.Inventories", "MenuId", "dbo.Menus")
            DropIndex("dbo.Suppliers", New String() { "UserId" })
            DropIndex("dbo.Orders", New String() { "User_UserId" })
            DropIndex("dbo.OrderItems", New String() { "MenuId" })
            DropIndex("dbo.OrderItems", New String() { "OrderId" })
            DropIndex("dbo.Inventories", New String() { "MenuId" })
            DropIndex("dbo.SupplierItems", New String() { "SupplierId" })
            AlterColumn("dbo.SupplierItems", "SupplierId", Function(c) c.String(maxLength := 128))
            AlterColumn("dbo.SupplierItems", "SupplierId", Function(c) c.String())
            AlterColumn("dbo.SupplierItems", "Description", Function(c) c.String())
            AlterColumn("dbo.SupplierItems", "Name", Function(c) c.String())
            DropTable("dbo.Orders")
            DropTable("dbo.OrderItems")
            DropTable("dbo.Inventories")
            DropTable("dbo.Menus")
            DropTable("dbo.Users")
            RenameColumn(table := "dbo.SupplierItems", name := "SupplierId", newName := "Supplier_UserId")
            AddColumn("dbo.SupplierItems", "SupplierId", Function(c) c.String())
            CreateIndex("dbo.SupplierItems", "Supplier_UserId")
            RenameTable(name := "dbo.Suppliers", newName := "Users")
        End Sub
    End Class
End Namespace
