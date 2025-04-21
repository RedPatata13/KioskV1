Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Rename
        Inherits DbMigration
    
        Public Overrides Sub Up()
            RenameColumn(table := "dbo.OrderDetails", name := "CustomerItemId", newName := "VersionId")
            RenameIndex(table := "dbo.OrderDetails", name := "IX_CustomerItemId", newName := "IX_VersionId")
        End Sub
        
        Public Overrides Sub Down()
            RenameIndex(table := "dbo.OrderDetails", name := "IX_VersionId", newName := "IX_CustomerItemId")
            RenameColumn(table := "dbo.OrderDetails", name := "VersionId", newName := "CustomerItemId")
        End Sub
    End Class
End Namespace
