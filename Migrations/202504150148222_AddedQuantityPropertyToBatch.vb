Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddedQuantityPropertyToBatch
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.InventoryBatches", "RemainingQuantity", Function(c) c.Int(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.InventoryBatches", "RemainingQuantity")
        End Sub
    End Class
End Namespace
