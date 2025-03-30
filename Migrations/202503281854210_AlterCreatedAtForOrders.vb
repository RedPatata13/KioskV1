Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Partial Public Class AlterCreatedAtForOrders
        Inherits DbMigration

        Public Overrides Sub Up()
            ' Alter the CreatedAt column to set a default value (GETDATE())
            AlterColumn("dbo.Orders", "CreatedAt", Function(c) c.DateTime(nullable:=False, defaultValueSql:="GETDATE()"))
        End Sub

        Public Overrides Sub Down()
            ' Revert the CreatedAt column to its previous state (removing the default value)
            AlterColumn("dbo.Orders", "CreatedAt", Function(c) c.DateTime(nullable:=False))
        End Sub
    End Class
End Namespace
