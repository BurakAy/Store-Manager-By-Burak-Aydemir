'Burak Aydemir
'MIS 239
'Final Project

Option Strict On
Option Explicit On

Public Class frmAbout

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Set text for label
            lblAbout.Text = "This program was created by Burak Aydemir."
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            'Close the form
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub



End Class