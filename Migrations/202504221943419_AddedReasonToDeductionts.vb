Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddedReasonToDeductionts
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.ItemToBatchDeductions", "CausedBy", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.ItemToBatchDeductions", "CausedBy")
        End Sub
    End Class
End Namespace
