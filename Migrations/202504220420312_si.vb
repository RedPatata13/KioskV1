Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class si
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropIndex("dbo.AdminItems", New String() { "SupplierItemId" })
            AlterColumn("dbo.AdminItems", "SupplierItemId", Function(c) c.String(nullable := False, maxLength := 50))
            CreateIndex("dbo.AdminItems", "SupplierItemId")
        End Sub
        
        Public Overrides Sub Down()
            DropIndex("dbo.AdminItems", New String() { "SupplierItemId" })
            AlterColumn("dbo.AdminItems", "SupplierItemId", Function(c) c.String(maxLength := 50))
            CreateIndex("dbo.AdminItems", "SupplierItemId")
        End Sub
    End Class
End Namespace
