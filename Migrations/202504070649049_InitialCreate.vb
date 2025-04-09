﻿Imports System
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
                        .UserId = c.Int(nullable := False),
                        .CreatedAt = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.OrderId) _
                .ForeignKey("dbo.Users", Function(t) t.UserId) _
                .Index(Function(t) t.UserId)
            
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
                        .Menu_MenuId = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.OrderItemId) _
                .ForeignKey("dbo.Menus", Function(t) t.Menu_MenuId) _
                .ForeignKey("dbo.Menus", Function(t) t.MenuId) _
                .ForeignKey("dbo.Orders", Function(t) t.OrderId, cascadeDelete := True) _
                .Index(Function(t) t.OrderId) _
                .Index(Function(t) t.MenuId) _
                .Index(Function(t) t.Menu_MenuId)
            
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
                        .Supplier = c.String(nullable := False, maxLength := 100),
                        .Quantity = c.Int(nullable := False),
                        .Status = c.String(nullable := False, maxLength := 50)
                    }) _
                .PrimaryKey(Function(t) t.InventoryId) _
                .ForeignKey("dbo.Menus", Function(t) t.MenuId) _
                .Index(Function(t) t.MenuId)
            
            CreateTable(
                "dbo.Users",
                Function(c) New With
                    {
                        .UserId = c.Int(nullable := False, identity := True),
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
                "dbo.Suppliers",
                Function(c) New With
                    {
                        .SupplierId = c.Int(nullable := False, identity := True),
                        .Name = c.String(nullable := False, maxLength := 100),
                        .ContactNumber = c.String(maxLength := 15),
                        .Email = c.String(maxLength := 100),
                        .CreatedAt = c.DateTime(nullable := False),
                        .Address = c.String(maxLength := 200),
                        .MenuId = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.SupplierId) _
                .ForeignKey("dbo.Menus", Function(t) t.MenuId) _
                .Index(Function(t) t.MenuId)
            
            CreateTable(
                "dbo.Transactions",
                Function(c) New With
                    {
                        .TransactionId = c.Int(nullable := False, identity := True),
                        .UserId = c.Int(nullable := False),
                        .TotalAmount = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Quantity = c.Int(nullable := False),
                        .Price = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .MenuId = c.Int(nullable := False),
                        .CreatedAt = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.TransactionId) _
                .ForeignKey("dbo.Menus", Function(t) t.MenuId) _
                .ForeignKey("dbo.Users", Function(t) t.UserId) _
                .Index(Function(t) t.UserId) _
                .Index(Function(t) t.MenuId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Transactions", "UserId", "dbo.Users")
            DropForeignKey("dbo.Transactions", "MenuId", "dbo.Menus")
            DropForeignKey("dbo.Suppliers", "MenuId", "dbo.Menus")
            DropForeignKey("dbo.Customers", "OrderId", "dbo.Orders")
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users")
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders")
            DropForeignKey("dbo.OrderItems", "MenuId", "dbo.Menus")
            DropForeignKey("dbo.OrderItems", "Menu_MenuId", "dbo.Menus")
            DropForeignKey("dbo.Inventories", "MenuId", "dbo.Menus")
            DropIndex("dbo.Transactions", New String() { "MenuId" })
            DropIndex("dbo.Transactions", New String() { "UserId" })
            DropIndex("dbo.Suppliers", New String() { "MenuId" })
            DropIndex("dbo.Inventories", New String() { "MenuId" })
            DropIndex("dbo.OrderItems", New String() { "Menu_MenuId" })
            DropIndex("dbo.OrderItems", New String() { "MenuId" })
            DropIndex("dbo.OrderItems", New String() { "OrderId" })
            DropIndex("dbo.Orders", New String() { "UserId" })
            DropIndex("dbo.Customers", New String() { "OrderId" })
            DropTable("dbo.Transactions")
            DropTable("dbo.Suppliers")
            DropTable("dbo.Users")
            DropTable("dbo.Inventories")
            DropTable("dbo.Menus")
            DropTable("dbo.OrderItems")
            DropTable("dbo.Orders")
            DropTable("dbo.Customers")
        End Sub
    End Class
End Namespace
