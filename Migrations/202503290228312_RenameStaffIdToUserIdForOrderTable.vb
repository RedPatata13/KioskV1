Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class RenameStaffIdToUserIdForOrderTable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            RenameColumn("dbo.Orders", "StaffId", "UserId")

            ' Update Foreign Key
            DropForeignKey("dbo.Orders", "StaffId", "dbo.Users")
            AddForeignKey("dbo.Orders", "UserId", "dbo.Users", "UserId")

            ' Create Index for UserId
            DropIndex("dbo.Orders", New String() {"StaffId"})
            CreateIndex("dbo.Orders", "UserId")
        End Sub
        
        Public Overrides Sub Down()
            RenameColumn("dbo.Orders", "UserId", "StaffId")

            ' Revert Foreign Key
            DropForeignKey("dbo.Orders", "UserId", "dbo.Users")
            AddForeignKey("dbo.Orders", "StaffId", "dbo.Users", "UserId")

            ' Restore Index for StaffId
            DropIndex("dbo.Orders", New String() {"UserId"})
            CreateIndex("dbo.Orders", "StaffId")
        End Sub
    End Class
End Namespace
