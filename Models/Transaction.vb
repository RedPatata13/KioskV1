﻿Imports Microsoft.VisualBasic.ApplicationServices
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Transaction
    Public Property TransactionId As Integer

    Public Property UserId As Integer ' fk to staff woho handled the transac

    Public Property TotalAmount As Decimal
    Public Property Quantity As Integer

    Public Property Price As Decimal

    Public Property MenuId As Integer
    Public Property CreatedAt As DateTime
    Public Overridable Property User As User
    Public Overridable Property Menu As Menu
End Class
