Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Validation
Imports System.Data.SqlClient
Imports System.Web.Management
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class Mediator(Of TKey)
        Private Property _Login As LoginViewModel
        Private Property _Projector As Projector
        Private ReadOnly _unitOfWork As IUnitOfWork
        Private Property _actionManager As New ActionManager
        Private Property VMMap As Dictionary(Of TKey, IProjectable)
        Private VMMap_Instantiated As Boolean = False


        Public Sub New(projector As Projector, login As LoginViewModel, unitOfWork As IUnitOfWork)
            _Projector = projector
            _Login = login
            _unitOfWork = unitOfWork
        End Sub

        Public Sub AddAction(action As Action)
            _actionManager.Enqueue(action)
        End Sub

        Public Sub AddPostAction(action As Action)
            _actionManager.EnqueuePost(action)
        End Sub
        Public Sub InvokeNext()
            _actionManager.ProcessNext()
        End Sub
        Public Sub InvokeAllAction()
            _actionManager.ProcessAll()
        End Sub

        Public Sub SetupMap(map As Dictionary(Of TKey, IProjectable))
            If VMMap_Instantiated Then Throw New Exception($"{GetType(TKey).Name} Mediator Instantiated Twice")
            VMMap = map
            VMMap_Instantiated = True
        End Sub
        Public Sub UpdateMenu(id As String, model As Menu)
            _unitOfWork.Menus.Update(model)
        End Sub

        Public Sub CreateMenu(model As Menu)
            _unitOfWork.Menus.Add(model)
        End Sub
        Public Sub SwapPage(pageKey As TKey)
            VerifyKey(pageKey)
            _Projector.Project(VMMap(pageKey))
        End Sub

        Public Function GetVM(pageKey As TKey) As IProjectable
            VerifyKey(pageKey)
            Return VMMap(pageKey)
        End Function

        Public Sub VerifyKey(pageKey As TKey)
            If VMMap.ContainsKey(pageKey) Then
                Return
            End If

            Throw New KeyNotFoundException($"Page {pageKey} not found in {GetType(TKey).Name} mediator.")
        End Sub

        Public Function GetUserList() As List(Of User)
            Return _unitOfWork.Users.GetAll()
        End Function


        Public Sub LayoutAction(action As Action)
            _Projector.LayoutAction(action)
        End Sub

        Public Function GetMenuList()
            Return _unitOfWork.Menus.GetAll()
        End Function

        Public Function GetItemList()
            Return _unitOfWork.OrderItems.GetAll()
        End Function

        Public Function GetOrderList()
            Return _unitOfWork.Orders.GetAll()
        End Function

        Public Sub DeleteMenu(model As Menu)
            _unitOfWork.Menus.Delete(model.MenuId)
        End Sub

        'test adding user
        Public Sub CreateUser(model As User)
            Try
                Dim validationResults As New List(Of ValidationResult)()
                Dim validationContext As New ValidationContext(model, Nothing, Nothing)

                If Not Validator.TryValidateObject(model, validationContext, validationResults, True) Then
                    Dim errorMessages As String = String.Join(Environment.NewLine, validationResults.Select(Function(r) r.ErrorMessage))
                    Throw New Exception(errorMessages)
                End If

                _unitOfWork.Users.Add(model)
                _unitOfWork.SaveChanges()

                MessageBox.Show("User added successfully!")

            Catch ex As ValidationException
                MessageBox.Show("Validation Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Catch ex As DbEntityValidationException
                ' Entity Framework validation errors
                Dim errors = String.Join(Environment.NewLine, ex.EntityValidationErrors.SelectMany(Function(e) e.ValidationErrors).Select(Function(e) e.ErrorMessage))
                MessageBox.Show("Database Validation Error: " & errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Catch ex As DbUpdateException
                ' Handles EF database update errors (like duplicate keys, foreign key violations)
                Dim innerExceptionMessage As String = GetInnerExceptionMessage(ex)
                MessageBox.Show("Database Update Error: " & innerExceptionMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Catch ex As SqlException
                ' Handles SQL-related errors
                MessageBox.Show("SQL Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Catch ex As Exception
                ' Log and display unexpected errors
                Dim innerExceptionMessage As String = GetInnerExceptionMessage(ex)
                LogException(ex) ' Log the full error
                MessageBox.Show("An unexpected error occurred. Please check the logs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub
        Private Function GetInnerExceptionMessage(ex As Exception) As String
            Dim message As String = ex.Message
            Dim innerEx As Exception = ex.InnerException
            While innerEx IsNot Nothing
                message &= Environment.NewLine & "Inner: " & innerEx.Message
                innerEx = innerEx.InnerException
            End While
            Return message
        End Function
        Private Sub LogException(ex As Exception)
            Dim logFilePath As String = "error_log.txt"
            Dim logMessage As String = $"[{DateTime.Now}] ERROR: {ex.Message}{Environment.NewLine}STACK TRACE: {ex.StackTrace}"

            Dim innerEx As Exception = ex.InnerException
            While innerEx IsNot Nothing
                logMessage &= Environment.NewLine & $"INNER EXCEPTION: {innerEx.Message}{Environment.NewLine}STACK TRACE: {innerEx.StackTrace}"
                innerEx = innerEx.InnerException
            End While

            System.IO.File.AppendAllText(logFilePath, logMessage & Environment.NewLine & "----------------------------------" & Environment.NewLine)
        End Sub

    End Class
End Namespace
