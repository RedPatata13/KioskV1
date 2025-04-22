Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddedReasonToDeductionPlusVersiodID
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.StockDebts", "VersionId", Function(c) c.String(maxLength := 50))
            CreateIndex("dbo.StockDebts", "VersionId")
            AddForeignKey("dbo.StockDebts", "VersionId", "dbo.AdminItemVersions", "VersionId")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.StockDebts", "VersionId", "dbo.AdminItemVersions")
            DropIndex("dbo.StockDebts", New String() { "VersionId" })
            DropColumn("dbo.StockDebts", "VersionId")
        End Sub
    End Class
End Namespace
