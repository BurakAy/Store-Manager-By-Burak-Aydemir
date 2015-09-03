'Burak Aydemir


Option Strict On
Option Explicit On

Public Class DepartmentList
    Inherits List(Of Department)

    'Event handler, raised when the department list changes
    Public Event DepartmentListChanged()


    'Adding a newDeparment to inherited Dpeartment list, called from the DepartmentDB class
    Public Overloads Sub Add(aDepartmentID As Integer, aDepartmentName As String, aManager As String, anExtension As String)
        'A new Deparment
        Dim newDepartment As New Department

        'Values to be added for a new department
        With newDepartment
            .DepartmentID = aDepartmentID
            .DepartmentName = aDepartmentName
            .Manager = aManager
            .Extension = anExtension
        End With
        MyBase.Add(newDepartment)
    End Sub


    'Add aDepartment to inherited Department list, raise changed event
    Public Overloads Sub Add(aDeparmtment As Department)
        DepartmentDB.AddDepartment(aDeparmtment)
        MyBase.Add(aDeparmtment)
        RaiseEvent DepartmentListChanged()
    End Sub


    'Update oldDepartment values with newDepartment values, raise changed event
    Public Sub Update(oldDepartment As Department, newDepartment As Department)
        If DepartmentDB.UpdateDepartment(oldDepartment, newDepartment) Then

            'Old department values to be updated with new department values
            With oldDepartment
                .DepartmentName = newDepartment.DepartmentName
                .Manager = newDepartment.Manager
                .Extension = newDepartment.Extension
            End With
            RaiseEvent DepartmentListChanged()
        End If
    End Sub


    'Remove aDepartment from inherited Department list, raise changed event
    Public Overloads Sub Remove(aDeparmtment As Department)
        DepartmentDB.DeleteDepartment(aDeparmtment)
        MyBase.Remove(aDeparmtment)
        RaiseEvent DepartmentListChanged()
    End Sub


End Class
