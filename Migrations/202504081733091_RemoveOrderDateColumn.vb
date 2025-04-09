Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class RemoveOrderDateColumn
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropColumn("dbo.Orders", "OrderDate")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Orders", "OrderDate", Function(c) c.DateTime(nullable := False))
        End Sub
    End Class
End Namespace
