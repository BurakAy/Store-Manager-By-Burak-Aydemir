'Burak Aydemir
'MIS 239
'Final Project

Option Strict On
Option Explicit On

Imports System.Data.OleDb

Public Class InventoryDB

    'Connection string to the database
    Public Shared Function GetConnection() As OleDbConnection
        Dim connectionString As String =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Inventory.accdb;Persist Security Info=True"
        Return New OleDbConnection(connectionString)
    End Function

End Class
