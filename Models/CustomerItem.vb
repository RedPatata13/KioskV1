Public Class CustomerItem
    Public Property Id As String
    Public Property Name As String
    Public Property Description As String
    ' Other relevant properties for CustomerItem
    Public Property AdminItemId As String ' Foreign Key for AdminItem
    Public Property AdminItem As AdminItem ' Navigation Property
End Class
