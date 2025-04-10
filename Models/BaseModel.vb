Imports System.ComponentModel.DataAnnotations

Public MustInherit Class BaseModel
    Public Sub Validate()
        Dim validationResults As New List(Of ValidationResult)()
        Dim context As New ValidationContext(Me)

        If Not Validator.TryValidateObject(Me, context, validationResults, True) Then
            Dim errors As String = String.Join(Environment.NewLine, validationResults.Select(Function(r) r.ErrorMessage))
            Throw New ValidationException($"Validation failed: {Environment.NewLine}{errors}")
        End If
    End Sub
End Class
