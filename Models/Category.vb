Public Class Category
    Public Property CategoryId As String
    Public Property CategoryName As String

    Public Overrides Function ToString() As String
        Return CategoryName
    End Function
End Class
