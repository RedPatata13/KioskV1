Namespace KioskV0.Model
    Public Class AuthModel
        Inherits BaseModel
        Public Property UID As String
        Public Property Password As String
        Public UserType As UserType = UserType.Null
    End Class
End Namespace