Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class BatchRequestAddRecipientSave
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropIndex("dbo.BatchRequests", New String() { "Recipient_UserId" })
            DropColumn("dbo.BatchRequests", "RecipientID")
            RenameColumn(table := "dbo.BatchRequests", name := "Recipient_UserId", newName := "RecipientID")
            AlterColumn("dbo.BatchRequests", "RecipientID", Function(c) c.String(maxLength := 128))
            CreateIndex("dbo.BatchRequests", "RecipientID")
        End Sub
        
        Public Overrides Sub Down()
            DropIndex("dbo.BatchRequests", New String() { "RecipientID" })
            AlterColumn("dbo.BatchRequests", "RecipientID", Function(c) c.String())
            RenameColumn(table := "dbo.BatchRequests", name := "RecipientID", newName := "Recipient_UserId")
            AddColumn("dbo.BatchRequests", "RecipientID", Function(c) c.String())
            CreateIndex("dbo.BatchRequests", "Recipient_UserId")
        End Sub
    End Class
End Namespace
