Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class JsonConfigReader
    Public Shared Function GetConnectionString() As String
        Dim jsonPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json")

        If Not File.Exists(jsonPath) Then
            Throw New FileNotFoundException("Configuration file not found: " & jsonPath)
        End If

        Dim jsonText As String = File.ReadAllText(jsonPath)
        Dim jsonObject As JObject = JObject.Parse(jsonText)
        Return jsonObject("ConnectionStrings")("DefaultConnection").ToString()
    End Function
End Class
