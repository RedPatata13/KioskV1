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
                        .Name = c.String(),
                        .Description = c.String(),
                        .SupplierId = c.String(),
                        .Supplier_UserId = c.String(maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Users", Function(t) t.Supplier_UserId) _
                .Index(Function(t) t.Supplier_UserId)
            
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
                        .CreatedAt = c.DateTime(nullable := False),
                        .Discriminator = c.String(nullable := False, maxLength := 128)
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
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.CustomerItems", "AdminItemId", "dbo.AdminItems")
            DropForeignKey("dbo.AdminItems", "SupplierItemId", "dbo.SupplierItems")
            DropForeignKey("dbo.SupplierItems", "Supplier_UserId", "dbo.Users")
            DropIndex("dbo.CustomerItems", New String() { "AdminItemId" })
            DropIndex("dbo.SupplierItems", New String() { "Supplier_UserId" })
            DropIndex("dbo.AdminItems", New String() { "SupplierItemId" })
            DropTable("dbo.CustomerItems")
            DropTable("dbo.Users")
            DropTable("dbo.SupplierItems")
            DropTable("dbo.AdminItems")
        End Sub
    End Class
End Namespace
