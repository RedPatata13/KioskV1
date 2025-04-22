Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class TransactedOrderEatMode
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.TransactedOrders", "EatMode", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.TransactedOrders", "EatMode")
        End Sub
    End Class
End Namespace
