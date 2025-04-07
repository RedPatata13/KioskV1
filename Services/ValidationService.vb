Imports System.ComponentModel.DataAnnotations
Imports System.Windows.Forms
Imports KioskV0.KioskV0.Services

Public Class ValidationService
    Private ReadOnly _unitOfWork As IUnitOfWork
    Public Sub New(unitOfWork As IUnitOfWork)
        _unitOfWork = unitOfWork
    End Sub
    Public Function ValidateUser(user As User) As Boolean
        Dim existingUser = _unitOfWork.Users.GetAll.FirstOrDefault(Function(u) u.Username = user.Username)
        If existingUser IsNot Nothing Then
            MessageBox.Show("Username already exists. Please choose a different username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function



End Class
