Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class MinorCheck
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.Users", "ContactNumber", Function(c) c.String(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.Users", "ContactNumber", Function(c) c.String())
        End Sub
    End Class
End Namespace
