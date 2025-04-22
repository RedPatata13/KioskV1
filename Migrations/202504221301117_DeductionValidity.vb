Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class DeductionValidity
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.ItemToBatchDeductions", "IsValid", Function(c) c.Boolean())
            AddColumn("dbo.StockDebts", "IsResolved", Function(c) c.Boolean())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.StockDebts", "IsResolved")
            DropColumn("dbo.ItemToBatchDeductions", "IsValid")
        End Sub
    End Class
End Namespace
