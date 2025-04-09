Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Partial Public Class RemoveComputedFromCreatedAt
        Inherits DbMigration

        Public Overrides Sub Up()
            ' Remove computed property and make CreatedAt NOT NULL
            AlterColumn("dbo.Orders", "CreatedAt", Function(c) c.DateTime(nullable:=False))
        End Sub

        Public Overrides Sub Down()
            ' Revert to previous state: Set CreatedAt as a computed column again
            AlterColumn("dbo.Orders", "CreatedAt", Function(c) c.DateTime(nullable:=False, storeType:="datetime2"))
        End Sub
    End Class
End Namespace
