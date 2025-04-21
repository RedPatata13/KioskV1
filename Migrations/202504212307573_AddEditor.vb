Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddEditor
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.AdminItemVersions", "EditorId", Function(c) c.String(maxLength:=128))
            CreateIndex("dbo.AdminItemVersions", "EditorId")
            AddForeignKey("dbo.AdminItemVersions", "EditorId", "dbo.Users", "UserId")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.AdminItemVersions", "EditorId", "dbo.Users")
            DropIndex("dbo.AdminItemVersions", New String() { "EditorId" })
            DropColumn("dbo.AdminItemVersions", "EditorId")
        End Sub
    End Class
End Namespace
