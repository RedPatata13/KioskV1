﻿Public Class CustomersRepository
    Inherits BaseRepository(Of Customer)
    Public Sub New(context As AppDbContext)
        MyBase.New(context)
    End Sub
End Class
