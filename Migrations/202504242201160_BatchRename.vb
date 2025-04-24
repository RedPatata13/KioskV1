Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class BatchRename
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.InventoryBatches", "BatchName", Function(c) c.String(nullable := False, maxLength := 100))
            DropColumn("dbo.InventoryBatches", "BatchNumber")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.InventoryBatches", "BatchNumber", Function(c) c.String(nullable := False, maxLength := 100))
            DropColumn("dbo.InventoryBatches", "BatchName")
        End Sub
    End Class
End Namespace
