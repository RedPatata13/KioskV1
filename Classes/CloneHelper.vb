Imports System.Reflection

Public Module CloneHelper
    Public Function CloneObject(Of T)(source As T) As T
        If source Is Nothing Then
            Throw New ArgumentNullException(NameOf(source))
        End If

        Dim newInstance As T = Activator.CreateInstance(Of T)() ' Create a new instance of the same type

        For Each prop As PropertyInfo In GetType(T).GetProperties()
            If prop.CanWrite Then
                prop.SetValue(newInstance, prop.GetValue(source))
            End If
        Next

        Return newInstance
    End Function

    Public Function MirrorObject(Of T)(source As T, destination As T) As T
        If source Is Nothing Then
            Throw New ArgumentNullException(NameOf(source))
        End If

        For Each prop As PropertyInfo In GetType(T).GetProperties()
            If prop.CanWrite Then
                prop.SetValue(destination, prop.GetValue(source))
            End If
        Next

        Return destination
    End Function
End Module
