Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddedReasonToDeductionPlusVersiodIDa
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropIndex("dbo.StockDebts", New String() { "VersionId" })
            AlterColumn("dbo.ItemToBatchDeductions", "CausedBy", Function(c) c.String(nullable := False))
            AlterColumn("dbo.StockDebts", "VersionId", Function(c) c.String(nullable := False, maxLength := 50))
            CreateIndex("dbo.StockDebts", "VersionId")
        End Sub
        
        Public Overrides Sub Down()
            DropIndex("dbo.StockDebts", New String() { "VersionId" })
            AlterColumn("dbo.StockDebts", "VersionId", Function(c) c.String(maxLength := 50))
            AlterColumn("dbo.ItemToBatchDeductions", "CausedBy", Function(c) c.String())
            CreateIndex("dbo.StockDebts", "VersionId")
        End Sub
    End Class
End Namespace
