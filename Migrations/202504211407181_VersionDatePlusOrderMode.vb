Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class VersionDatePlusOrderMode
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.AdminItemVersions", "DateCreated", Function(c) c.DateTime(nullable := False))
            AddColumn("dbo.OrderPrimals", "OrderMode", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.OrderPrimals", "OrderMode")
            DropColumn("dbo.AdminItemVersions", "DateCreated")
        End Sub
    End Class
End Namespace
