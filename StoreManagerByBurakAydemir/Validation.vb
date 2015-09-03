'Burak Aydemir
'MIS 239
'Final Project

Option Strict On
Option Explicit On

'Class for validating user input
Public Class Validation

    'Messagebox title
    Public Shared Property Title As String = "Entry Error"


    'Function to check that no fields are null
    Public Shared Function IsPresent(ByVal textbox As TextBox, ByVal name As String) As Boolean
        Try
            If textbox.Text = "" Then
                MessageBox.Show(name & " is a required field.", Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                textbox.Select()
                Return False
            Else
                Return True
            End If
        Catch ex As FormatException
            MessageBox.Show("Field cannot be null", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            Return False
        End Try
    End Function


    'Function to check that field is an integer
    Public Shared Function IsInt32(ByVal textbox As TextBox, ByVal name As String) As Boolean
        Try
            Dim number As Integer = 0
            If Int32.TryParse(textBox.Text, number) Then
                Return True
            Else
                MessageBox.Show(name & " must be an integer value.", Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                textBox.Select()
                textBox.SelectAll()
                Return False
            End If
        Catch ex As FormatException
            MessageBox.Show("Field must be a numeric value", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            Return False
        End Try
    End Function


    'Function to check that field is a decimal
    Public Shared Function IsDecimal(ByVal textbox As TextBox, ByVal name As String) As Boolean
        Try
            Dim number As Decimal = 0
            If Decimal.TryParse(textbox.Text, number) Then
                Return True
            Else
                'Message displays field's name and message
                MessageBox.Show(name & " must be a decimal value.", Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                textbox.Select()
                textbox.SelectAll()
                Return False
            End If
        Catch ex As FormatException
            MessageBox.Show("Field must be a decimal value", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            Return False
        End Try
    End Function


    'Function to check that field is a date
    Public Shared Function IsDate(ByVal textBox As TextBox, ByVal name As String) As Boolean
        Try
            Dim registrationDate As Date
            If Date.TryParse(textBox.Text, registrationDate) Then
                Return True
            Else
                MessageBox.Show(name & " must be a valid date format.", Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                textBox.Select()
                textBox.SelectAll()
                Return False
            End If
        Catch ex As FormatException
            MessageBox.Show("Field must be a date value. ex: 12/11/2014", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            Return False
        End Try
    End Function



End Class
