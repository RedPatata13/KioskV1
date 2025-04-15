Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class ChangedOrderDetails
        Inherits DbMigration
    
        Public Overrides Sub Up()
            RenameColumn(table := "dbo.OrderDetails", name := "CustomerItemId", newName := "AdminItemId")
            RenameIndex(table := "dbo.OrderDetails", name := "IX_CustomerItemId", newName := "IX_AdminItemId")
        End Sub
        
        Public Overrides Sub Down()
            RenameIndex(table := "dbo.OrderDetails", name := "IX_AdminItemId", newName := "IX_CustomerItemId")
            RenameColumn(table := "dbo.OrderDetails", name := "AdminItemId", newName := "CustomerItemId")
        End Sub
    End Class
End Namespace
