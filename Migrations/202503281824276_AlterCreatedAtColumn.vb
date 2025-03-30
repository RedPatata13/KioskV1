Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Partial Public Class AlterCreatedAtColumn
        Inherits DbMigration

        Public Overrides Sub Up()
            AlterColumn("dbo.Customers", "CreatedAt", Function(c) c.DateTime(nullable:=False, defaultValueSql:="GETDATE()"))
        End Sub

        Public Overrides Sub Down()
            AlterColumn("dbo.Customers", "CreatedAt", Function(c) c.DateTime(nullable:=False))
        End Sub
    End Class
End Namespace
