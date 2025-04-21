Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class FK2
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.OrderDetails", "ReferencedItemId", Function(c) c.String(nullable := False, maxLength := 50))
            CreateIndex("dbo.OrderDetails", "ReferencedItemId")
            AddForeignKey("dbo.OrderDetails", "ReferencedItemId", "dbo.AdminItems", "Id")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.OrderDetails", "ReferencedItemId", "dbo.AdminItems")
            DropIndex("dbo.OrderDetails", New String() { "ReferencedItemId" })
            DropColumn("dbo.OrderDetails", "ReferencedItemId")
        End Sub
    End Class
End Namespace
