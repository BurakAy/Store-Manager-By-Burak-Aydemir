'Burak Aydemir


Option Strict On
Option Explicit On

Public Class Department

    'Module level variables for Department fields
    Private m_DepartmentID As Integer
    Private m_DepartmentName As String
    Private m_Manager As String
    Private m_Extension As String


    'Constructor with no parameters for new Department
    Public Sub New()

    End Sub


    'Parameterized method for new department when created
    Public Sub New(aDepartmentID As Integer, aDepartmentName As String, aManager As String, anExtension As String)
        Me.DepartmentID = aDepartmentID
        Me.DepartmentName = aDepartmentName
        Me.Manager = aManager
        Me.Extension = anExtension
    End Sub


    'Get value from module level variable, DepartmentID property of Department
    Public Property DepartmentID As Integer
        Get
            Return m_DepartmentID
        End Get
        Set(value As Integer)
            m_DepartmentID = value
        End Set
    End Property


    'Get value from module level variable, DepartmentName property of Department
    Public Property DepartmentName As String
        Get
            Return m_DepartmentName
        End Get
        Set(value As String)
            'Error if null
            If value.ToString = "" Then
                Throw New ArgumentNullException("Department Name is required.")
            Else
                m_DepartmentName = value
            End If
        End Set
    End Property


    'Get value from module level variable, Manager property of Department
    Public Property Manager As String
        Get
            Return m_Manager
        End Get
        Set(value As String)
            'Error if null
            If value.ToString = "" Then
                Throw New ArgumentNullException("Manager is required.")
            Else
                m_Manager = value
            End If
        End Set
    End Property


    'Get value from module level variable, Extension property of Department
    Public Property Extension As String
        Get
            Return m_Extension
        End Get
        Set(value As String)
            If CDbl(value) <= 0 Then
                'Error if Extension is null or less than 0
                Throw New ArgumentException("Extension must be greater than 0.")
            ElseIf value.ToString = "" Then
                Throw New ArgumentNullException("Extension is required.")
            Else
                m_Extension = value
            End If
        End Set
    End Property


    'Return DepartmentName, to be displayed in the ComboBox
    Public Overrides Function ToString() As String
        Try
            Return Me.DepartmentName
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Function



End Class
