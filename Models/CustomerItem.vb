Public Class CustomerItem
    Public Property Id As String
    Public Property Name As String
    Public Property Description As String
    ' Other relevant properties for CustomerItem
    Public Property AdminItemId As String ' Foreign Key for AdminItem
    Public Property AdminItem As AdminItem ' Navigation Property

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
