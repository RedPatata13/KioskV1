Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddTemp
        Inherits DbMigration

        Public Overrides Sub Up()
            AddForeignKey("dbo.OrderDetails", "CustomerItemId", "dbo.AdminItems", "Id")
        End Sub

        Public Overrides Sub Down()
            DropForeignKey("dbo.OrderDetails", "CustomerItemId", "dbo.AdminItems")
        End Sub
    End Class
End Namespace
