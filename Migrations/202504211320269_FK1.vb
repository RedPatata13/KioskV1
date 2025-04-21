Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class FK1
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.OrderDetails", "VersionId", "dbo.AdminItemVersions")
            AddForeignKey("dbo.OrderDetails", "VersionId", "dbo.AdminItemVersions", "VersionId")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.OrderDetails", "VersionId", "dbo.AdminItemVersions")
            AddForeignKey("dbo.OrderDetails", "VersionId", "dbo.AdminItemVersions", "VersionId", cascadeDelete := True)
        End Sub
    End Class
End Namespace
