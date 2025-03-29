Imports System
Imports System.Data.Entity.Migrations

Namespace Migrations
    Partial Public Class RenameStaffIdToUserId
        Inherits DbMigration

        Public Overrides Sub Up()
            ' Rename the column StaffId to UserId
            RenameColumn("dbo.Transactions", "StaffId", "UserId")

            ' Update Foreign Key
            DropForeignKey("dbo.Transactions", "StaffId", "dbo.Users")
            AddForeignKey("dbo.Transactions", "UserId", "dbo.Users", "UserId")

            ' Create Index for UserId
            DropIndex("dbo.Transactions", New String() {"StaffId"})
            CreateIndex("dbo.Transactions", "UserId")
        End Sub

        Public Overrides Sub Down()
            ' Revert the column name change from UserId to StaffId
            RenameColumn("dbo.Transactions", "UserId", "StaffId")

            ' Revert Foreign Key
            DropForeignKey("dbo.Transactions", "UserId", "dbo.Users")
            AddForeignKey("dbo.Transactions", "StaffId", "dbo.Users", "UserId")

            ' Restore Index for StaffId
            DropIndex("dbo.Transactions", New String() {"UserId"})
            CreateIndex("dbo.Transactions", "StaffId")
        End Sub
    End Class
End Namespace
