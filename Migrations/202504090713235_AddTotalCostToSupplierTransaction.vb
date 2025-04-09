Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddTotalCostToSupplierTransaction
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.SupplierTransactions", "TotalCost", Function(c) c.Decimal(nullable := False, precision := 18, scale := 2))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.SupplierTransactions", "TotalCost")
        End Sub
    End Class
End Namespace
