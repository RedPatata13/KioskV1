Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AdminItemVersionUpdateReason
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.AdminItemVersions", "VersionUpdateReason", Function(c) c.String(nullable := False, maxLength := 500))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.AdminItemVersions", "VersionUpdateReason")
        End Sub
    End Class
End Namespace
