Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddEditorIdRequired
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropIndex("dbo.AdminItemVersions", New String() { "EditorId" })
            AlterColumn("dbo.AdminItemVersions", "EditorId", Function(c) c.String(nullable := False, maxLength := 128))
            CreateIndex("dbo.AdminItemVersions", "EditorId")
        End Sub
        
        Public Overrides Sub Down()
            DropIndex("dbo.AdminItemVersions", New String() { "EditorId" })
            AlterColumn("dbo.AdminItemVersions", "EditorId", Function(c) c.String(maxLength := 128))
            CreateIndex("dbo.AdminItemVersions", "EditorId")
        End Sub
    End Class
End Namespace
