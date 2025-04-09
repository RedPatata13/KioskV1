Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddSupplierTransactionTable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.SupplierTransactions",
                Function(c) New With
                    {
                        .BatchId = c.String(nullable := False, maxLength := 10),
                        .MenuId = c.String(nullable := False, maxLength := 128),
                        .Quantity = c.Int(nullable := False),
                        .DateRelease = c.DateTime(),
                        .Returned = c.String(),
                        .Status = c.String(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.BatchId) _
                .ForeignKey("dbo.Menus", Function(t) t.MenuId, cascadeDelete := True) _
                .Index(Function(t) t.MenuId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.SupplierTransactions", "MenuId", "dbo.Menus")
            DropIndex("dbo.SupplierTransactions", New String() { "MenuId" })
            DropTable("dbo.SupplierTransactions")
        End Sub
    End Class
End Namespace
