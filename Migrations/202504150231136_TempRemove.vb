Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class TempRemove
        Inherits DbMigration

        Public Overrides Sub Up()
            DropForeignKey("dbo.OrderDetails", "CustomerItemId", "dbo.CustomerItems")
        End Sub

        Public Overrides Sub Down()
            AddForeignKey("dbo.OrderDetails", "CustomerItemId", "dbo.CustomerItems", "Id")
        End Sub
    End Class
End Namespace
