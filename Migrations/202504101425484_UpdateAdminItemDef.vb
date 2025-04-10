Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class UpdateAdminItemDef
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Categories",
                Function(c) New With
                    {
                        .CategoryId = c.String(nullable := False, maxLength := 128),
                        .CategoryName = c.String(nullable := False, maxLength := 100)
                    }) _
                .PrimaryKey(Function(t) t.CategoryId)
            
            AddColumn("dbo.AdminItems", "CategoryId", Function(c) c.String(nullable := False, maxLength := 128))
            CreateIndex("dbo.AdminItems", "CategoryId")
            AddForeignKey("dbo.AdminItems", "CategoryId", "dbo.Categories", "CategoryId")
        End Sub
        
        Public Overrides Sub Down()
            'DropForeignKey("dbo.AdminItems", "CategoryId", "dbo.Categories")
            DropIndex("dbo.AdminItems", New String() { "CategoryId" })
            DropColumn("dbo.AdminItems", "CategoryId")
            DropTable("dbo.Categories")
        End Sub
    End Class
End Namespace
