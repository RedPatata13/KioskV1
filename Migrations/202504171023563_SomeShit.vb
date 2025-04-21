Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class SomeShit
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.Users", "FirstName", Function(c) c.String(nullable := False, maxLength := 50))
            AlterColumn("dbo.Users", "LastName", Function(c) c.String(nullable := False, maxLength := 50))
            AlterColumn("dbo.Users", "Username", Function(c) c.String(nullable := False, maxLength := 20))
            AlterColumn("dbo.Users", "PasswordHash", Function(c) c.String(nullable := False))
            AlterColumn("dbo.Users", "Email", Function(c) c.String(nullable := False, maxLength := 100))
            AlterColumn("dbo.Users", "Role", Function(c) c.String(nullable := False, maxLength := 20))
            AlterColumn("dbo.Users", "Address", Function(c) c.String(maxLength := 200))
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.Users", "Address", Function(c) c.String())
            AlterColumn("dbo.Users", "Role", Function(c) c.String())
            AlterColumn("dbo.Users", "Email", Function(c) c.String())
            AlterColumn("dbo.Users", "PasswordHash", Function(c) c.String())
            AlterColumn("dbo.Users", "Username", Function(c) c.String())
            AlterColumn("dbo.Users", "LastName", Function(c) c.String())
            AlterColumn("dbo.Users", "FirstName", Function(c) c.String())
        End Sub
    End Class
End Namespace
