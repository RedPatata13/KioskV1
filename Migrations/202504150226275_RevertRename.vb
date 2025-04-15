Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class RevertRename
        Inherits DbMigration
    
        Public Overrides Sub Up()
            RenameColumn(table := "dbo.OrderDetails", name := "AdminItemId", newName := "CustomerItemId")
            RenameIndex(table := "dbo.OrderDetails", name := "IX_AdminItemId", newName := "IX_CustomerItemId")
        End Sub
        
        Public Overrides Sub Down()
            RenameIndex(table := "dbo.OrderDetails", name := "IX_CustomerItemId", newName := "IX_AdminItemId")
            RenameColumn(table := "dbo.OrderDetails", name := "CustomerItemId", newName := "AdminItemId")
        End Sub
    End Class
End Namespace
