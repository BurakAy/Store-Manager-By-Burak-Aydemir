'Burak Aydemir
'MIS 239
'Final Project

Option Strict On
Option Explicit On

Imports System.Data
Imports System.Data.OleDb

Public Class DepartmentDB

    Public Shared Function GetDepartmentList() As DepartmentList
        'Connection object
        Dim connection As OleDbConnection = InventoryDB.GetConnection

        Try
            Dim departmentList As DepartmentList

            'SQL command to select from Departments table
            Dim selectStatement As String =
                "SELECT DepartmentID, DepartmentName, Manager, Extension " &
                "FROM Departments"

            'Command to hold selectStatement
            Dim selectCommand As New OleDbCommand(selectStatement, connection)

            'Open the connection
            connection.Open()

            'Reader object to execute Command
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader()
            departmentList = New DepartmentList

            'Check for records
            If reader.HasRows Then

                'Read the first row in database, add to list, loop through
                Do While reader.Read()
                    departmentList.Add(CInt(reader("DepartmentID")), reader("DepartmentName").ToString, reader("Manager").ToString, reader("Extension").ToString)
                Loop
            End If

            'Return list of department
            Return departmentList

        Catch ex As Exception
            Throw
        Finally
            'Close the connection
            connection.Close()
        End Try
    End Function


    Public Shared Function AddDepartment(department As Department) As Boolean

        'Connection object
        Dim connection As OleDbConnection = InventoryDB.GetConnection

        Try
            'SQL command to insert into the Departments table
            Dim insertStatement As String =
                "INSERT INTO Departments " &
                "(DepartmentName, Manager, Extension) " &
                "VALUES (?, ?, ?)"

            'Command to hold insertStatement
            Dim insertCommand As New OleDbCommand(insertStatement, connection)

            'Create parameters with their values
            insertCommand.Parameters.AddWithValue("DepartmentName", department.DepartmentName)
            insertCommand.Parameters.AddWithValue("Manager", department.Manager)
            insertCommand.Parameters.AddWithValue("Extension", department.Extension)

            'Open the connection
            connection.Open()

            'Count records, insert command
            Dim count As Integer = insertCommand.ExecuteNonQuery
            If count > 0 Then

                'Get DepartmentID
                Dim selectStatement As String = "Select @@IDENTITY"
                Dim selectCommand As New OleDbCommand(selectStatement, connection)
                department.DepartmentID = CInt(selectCommand.ExecuteScalar)

                'Return true if Add successful, else, false
                Return True
            Else
                Return False
            End If
        Catch ex As OleDbException
            Throw
        Finally
            'Close the connection
            connection.Close()
        End Try
    End Function


    Public Shared Function UpdateDepartment(oldDepartment As Department, newDepartment As Department) As Boolean

        'Connection object
        Dim connection As OleDbConnection = InventoryDB.GetConnection

        Try
            'SQL statement to update the Departments table
            Dim updateStatement As String =
                "UPDATE Departments SET " &
                "DepartmentName = ?, " &
                "Manager = ?, " &
                "Extension = ? " &
                "WHERE DepartmentID = ? " &
                "AND DepartmentName = ? " &
                "AND Manager = ? " &
                "AND Extension = ?"

            'Command to hold updateStatement
            Dim updateCommand As New OleDbCommand(updateStatement, connection)

            'Create parameters for new values
            updateCommand.Parameters.AddWithValue("newDepartmentName", newDepartment.DepartmentName)
            updateCommand.Parameters.AddWithValue("newManager", newDepartment.Manager)
            updateCommand.Parameters.AddWithValue("newExtension", newDepartment.Extension)

            'Parameters for old values
            updateCommand.Parameters.AddWithValue("oldDepartmentID", oldDepartment.DepartmentID)
            updateCommand.Parameters.AddWithValue("oldDepartmentName", oldDepartment.DepartmentName)
            updateCommand.Parameters.AddWithValue("oldManager", oldDepartment.Manager)
            updateCommand.Parameters.AddWithValue("oldExtension", oldDepartment.Extension)

            'Open the connection
            connection.Open()

            'Count records, update command
            Dim count As Integer = updateCommand.ExecuteNonQuery
            If count > 0 Then

                'Return true if update successful, else, false
                Return True
            Else
                Return False
            End If
        Catch ex As OleDbException
            Throw
        Finally
            'Close the connection
            connection.Close()
        End Try
    End Function


    Public Shared Function DeleteDepartment(department As Department) As Boolean

        'Connection object
        Dim connection As OleDbConnection = InventoryDB.GetConnection

        Try
            'SQL statement to delete values from Departments table
            Dim deleteStatement As String =
                "DELETE FROM Departments " &
                "WHERE DepartmentID = ? " &
                "AND DepartmentName = ? " &
                "AND Manager = ? " &
                "AND Extension = ?"

            'Command to hold deleteStatement
            Dim deleteCommand As New OleDbCommand(deleteStatement, connection)

            'Create parameters with values to be deleted
            deleteCommand.Parameters.AddWithValue("DepartmentID", department.DepartmentID)
            deleteCommand.Parameters.AddWithValue("DepartmentName", department.DepartmentName)
            deleteCommand.Parameters.AddWithValue("Manager", department.Manager)
            deleteCommand.Parameters.AddWithValue("Extension", department.Extension)

            'Open the connection
            connection.Open()

            'Count records, delete command
            Dim count As Integer = deleteCommand.ExecuteNonQuery
            If count > 0 Then

                'Return true if delete successful, else, return false
                Return True
            Else
                Return False
            End If
        Catch ex As OleDbException
            Throw
        Finally
            'Close the connection
            connection.Close()
        End Try
    End Function



End Class
