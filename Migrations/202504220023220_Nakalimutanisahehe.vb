Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Nakalimutanisahehe
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropIndex("dbo.ItemToBatchDeductions", New String() { "BaseItemId" })
            AlterColumn("dbo.ItemToBatchDeductions", "BaseItemId", Function(c) c.String(nullable := False, maxLength := 50))
            CreateIndex("dbo.ItemToBatchDeductions", "BaseItemId")
        End Sub
        
        Public Overrides Sub Down()
            DropIndex("dbo.ItemToBatchDeductions", New String() { "BaseItemId" })
            AlterColumn("dbo.ItemToBatchDeductions", "BaseItemId", Function(c) c.String(maxLength := 50))
            CreateIndex("dbo.ItemToBatchDeductions", "BaseItemId")
        End Sub
    End Class
End Namespace
