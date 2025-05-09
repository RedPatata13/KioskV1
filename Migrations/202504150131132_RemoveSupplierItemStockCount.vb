﻿Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class RemoveSupplierItemStockCount
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropColumn("dbo.SupplierItems", "StockCount")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.SupplierItems", "StockCount", Function(c) c.Int(nullable := False))
        End Sub
    End Class
End Namespace
