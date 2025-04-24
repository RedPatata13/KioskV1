Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class BatchRequestAddRecipient
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.BatchRequests", "RecipientID", Function(c) c.String())
            AddColumn("dbo.BatchRequests", "Recipient_UserId", Function(c) c.String(maxLength := 128))
            CreateIndex("dbo.BatchRequests", "Recipient_UserId")
            AddForeignKey("dbo.BatchRequests", "Recipient_UserId", "dbo.Users", "UserId")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.BatchRequests", "Recipient_UserId", "dbo.Users")
            DropIndex("dbo.BatchRequests", New String() { "Recipient_UserId" })
            DropColumn("dbo.BatchRequests", "Recipient_UserId")
            DropColumn("dbo.BatchRequests", "RecipientID")
        End Sub
    End Class
End Namespace
