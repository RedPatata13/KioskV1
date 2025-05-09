﻿Public Interface IBaseRepository(Of T)
    Function GetAll() As IEnumerable(Of T)
    Function GetById(id As String) As T
    Sub Add(entity As T)
    Sub AddRange(list As IEnumerable(Of T))
    Sub Update(entity As T)
    Sub Delete(id As String)
End Interface