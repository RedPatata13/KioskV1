Imports System.ComponentModel.DataAnnotations
Imports System.Reflection

Namespace KioskV0.Model
    Public MustInherit Class BaseModel
        ''' <summary>
        ''' I have no clue why I made this but just in case we'll need it
        ''' </summary>
        ''' <returns>List of errors as string</returns>
        Public Function ValidateOrGetErrors() As Boolean
            Dim validationResults As New List(Of ValidationResult)()
            Dim validationContext As New ValidationContext(Me, Nothing, Nothing)

            If Not Validator.TryValidateObject(Me, validationContext, validationResults, True) Then
                Dim errorMessages As String = String.Join(Environment.NewLine, validationResults.Select(Function(r) r.ErrorMessage))
                MessageBox.Show(errorMessages, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Return True
        End Function
        ''' <summary>
        ''' Simpify verification for each Model type
        ''' </summary>
        Public Sub Validate()
            Dim validationResults As New List(Of ValidationResult)()
            Dim validationContext As New ValidationContext(Me, Nothing, Nothing)

            If Not Validator.TryValidateObject(Me, validationContext, validationResults, True) Then
                Dim errorMessages As String = String.Join(Environment.NewLine, validationResults.Select(Function(r) r.ErrorMessage))
                MessageBox.Show(errorMessages, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub
    End Class
End Namespace
