Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class RemovedUserId
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropColumn("dbo.OrderPrimals", "UserId")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.OrderPrimals", "UserId", Function(c) c.String(nullable := False))
        End Sub
    End Class
End Namespace
