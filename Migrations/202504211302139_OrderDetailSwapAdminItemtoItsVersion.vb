Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class OrderDetailSwapAdminItemtoItsVersion
        Inherits DbMigration

        Public Overrides Sub Up()
            DropForeignKey("dbo.OrderDetails", "CustomerItemId", "dbo.AdminItems")
        End Sub

        Public Overrides Sub Down()
            AddForeignKey("dbo.OrderDetails", "CustomerItemId", "dbo.AdminItems", "Id")
        End Sub
    End Class
End Namespace
