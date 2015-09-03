'Burak Aydemir


Option Strict On
Option Explicit On

Public Class frmAddEditDepartment

    'Module level variables to hold values
    Private mDepartment As Department = Nothing
    Private mDepartmentList As DepartmentList


    'Opening the form for adding a new department
    Public Sub OpenForAdd(theDepartments As DepartmentList)
        Try
            'Set DepartmentID label for a new ID
            lblDepartmentIDDisplay.Text = "<new>"

            'Store to module level variable for a new department
            mDepartmentList = theDepartments

            'Show the form
            Me.ShowDialog()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    'Open the form for editing an existing department
    Public Sub OpenForEdit(aDepartment As Department, theDepartments As DepartmentList)
        Try
            'Set form window text to that of the department being edited
            Me.Text = "Edit Department: " & aDepartment.DepartmentName

            'Populate form fields with data from the selected department
            With aDepartment
                lblDepartmentIDDisplay.Text = .DepartmentID.ToString
                txtDepartmentName.Text = .DepartmentName
                txtManager.Text = .Manager
                txtExtension.Text = .Extension
            End With

            'Pass in values of aDepartment and theDepartments
            mDepartment = aDepartment
            mDepartmentList = theDepartments

            'Show the form
            Me.ShowDialog()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    'Open the form to view the selected department
    Public Sub OpenToView(aDepartment As Department)
        Try
            'Set form window text to that of the department being viewed
            Me.Text = "Viewing Department: " & aDepartment.DepartmentName

            'Disable OK button and set text boxes to read only so values can not be changed
            btnOK.Enabled = False
            txtDepartmentName.ReadOnly = True
            txtManager.ReadOnly = True
            txtExtension.ReadOnly = True

            'Populate form fields with data from the selected department
            With aDepartment
                lblDepartmentIDDisplay.Text = .DepartmentID.ToString
                txtDepartmentName.Text = .DepartmentName
                txtManager.Text = .Manager
                txtExtension.Text = .Extension
            End With

            'Show the form
            Me.ShowDialog()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            'Variable for a new department
            Dim newDepartment As New Department

            'Call function to validate user input
            If IsValidData() Then

                'New department values filled with user entered field valued
                With newDepartment
                    .DepartmentName = txtDepartmentName.Text
                    .Manager = txtManager.Text
                    .Extension = txtExtension.Text
                End With

                'If DepartmentName or Manager name are numeric, show error
                If IsNumeric(newDepartment.DepartmentName) Or IsNumeric(newDepartment.Manager) Then
                    MessageBox.Show("Deparment Name and/or Manager must not contain numeric values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    'If module level variable is empty, add newDepartment values for a new department
                    If mDepartment Is Nothing Then
                        mDepartmentList.Add(newDepartment)
                    Else
                        'Update the module level variable values with those of the newDepartment values
                        mDepartmentList.Update(mDepartment, newDepartment)
                    End If

                    'Close the form
                    Me.Close()
                End If
            End If
        Catch ex As FormatException
            MessageBox.Show("A format exception has occurred.  Check your entries", "Format Error")
        Catch ex As ArgumentNullException
            MessageBox.Show("A null exception has occurred.  Check your entries", " Null Entry Error")
        Catch ex As ArgumentException
            MessageBox.Show("Invalid argument", ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            'Close the form when cancel button is clicked
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    'Function to check for input validadion
    Private Function IsValidData() As Boolean
        Try
            'Called from Validation class to check values
            Return Validation.IsPresent(txtDepartmentName, "Department") AndAlso
                   Validation.IsPresent(txtManager, "Manager") AndAlso
                   Validation.IsPresent(txtExtension, "Extension") AndAlso
                   Validation.IsInt32(txtExtension, "Extension")
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            Return Nothing
        End Try
    End Function


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Try
            'Close the form when exit is selected from the toolstrip
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    'Open frmAbout when selected from toolstrip
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Try
            'Variable for new frmAbout
            Dim frm As New frmAbout

            'Show frmAbout
            frm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub



    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Try
            'Close the form when exit is selected from context menu
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


End Class