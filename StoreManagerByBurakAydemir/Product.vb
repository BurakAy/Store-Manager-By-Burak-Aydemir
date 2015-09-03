'Burak Aydemir


Option Strict On
Option Explicit On

Public Class Product

    'Module level variables for Product fields
    Private m_ProductID As Integer
    Private m_DateUpdated As Date
    Private m_DepartmentID As Integer
    Private m_Product As String
    Private m_Manufacturer As String
    Private m_ModelNumber As String
    Private m_WholesalePrice As Decimal
    Private m_RetailPrice As Decimal
    Private m_UnitsInStock As Integer
    Private m_UnitsSold As Integer
    Private m_Description As String


    'Constructor with no parameters for new Product
    Public Sub New()

    End Sub


    'Get value from module level variable, ProductID property of Product
    Public Property ProductID As Integer
        Get
            Return m_ProductID
        End Get
        Set(value As Integer)
            m_ProductID = value
        End Set
    End Property


    'Get value from module level variable, DateUpdated property of Product
    Public Property DateUpdated As Date
        Get
            Return m_DateUpdated
        End Get
        Set(value As Date)
            'Error if null
            If value.ToString = "" Then
                Throw New ArgumentNullException("Date is required.")
            Else
                m_DateUpdated = value
            End If
        End Set
    End Property


    'Get value from module level variable, DepartmentID property of Product
    Public Property DepartmentID As Integer
        Get
            Return m_DepartmentID
        End Get
        Set(value As Integer)
            m_DepartmentID = value
        End Set
    End Property


    'Get value from module level variable, Product property of Product
    Public Property Product As String
        Get
            Return m_Product
        End Get
        Set(value As String)
            'Error if null
            If value.ToString = "" Then
                Throw New ArgumentNullException("Product is required.")
            Else
                m_Product = value
            End If
        End Set
    End Property


    'Get value from module level variable, Manufacturer property of Product
    Public Property Manufacturer As String
        Get
            Return m_Manufacturer
        End Get
        Set(value As String)
            'Error if null
            If value.ToString = "" Then
                Throw New ArgumentNullException("Manufacturer is required.")
            Else
                m_Manufacturer = value
            End If
        End Set
    End Property


    'Get value from module level variable, ModelNumber property of Product
    Public Property ModelNumber As String
        Get
            Return m_ModelNumber
        End Get
        Set(value As String)
            'Error if null
            If value.ToString = "" Then
                Throw New ArgumentNullException("Model Number is required.")
            Else
                m_ModelNumber = value
            End If
        End Set
    End Property


    'Get value from module level variable, WholesalePrice property of Product
    Public Property WholesalePrice As Decimal
        Get
            Return m_WholesalePrice
        End Get
        Set(value As Decimal)
            'Error if null
            If value.ToString = "" Then
                Throw New ArgumentNullException("Wholesale Price is required.")
            Else
                m_WholesalePrice = value
            End If
        End Set
    End Property


    'Get value from module level variable, RetailPrice property of Product
    Public Property RetailPrice As Decimal
        Get
            Return m_RetailPrice
        End Get
        Set(value As Decimal)
            'Error if null
            If value.ToString = "" Then
                Throw New ArgumentNullException("Retail Price is required.")
            Else
                m_RetailPrice = value
            End If
        End Set
    End Property


    'Get value from module level variable, UnitsInStock property of Product
    Public Property UnitsInStock As Integer
        Get
            Return m_UnitsInStock
        End Get
        Set(value As Integer)
            'Error if null
            If value.ToString = "" Then
                Throw New ArgumentNullException("Units In Stock is required.")
            Else
                m_UnitsInStock = value
            End If
        End Set
    End Property


    'Get value from module level variable, UnitsSold property of Product
    Public Property UnitsSold As Integer
        Get
            Return m_UnitsSold
        End Get
        Set(value As Integer)
            'Error if null
            If value.ToString = "" Then
                Throw New ArgumentNullException("Units Sold is required.")
            Else
                m_UnitsSold = value
            End If
        End Set
    End Property


    'Get value from module level variable, Description property of Product
    Public Property Description As String
        Get
            Return m_Description
        End Get
        Set(value As String)
            'Error if null
            If value.ToString = "" Then
                Throw New ArgumentNullException("Description is required.")
            Else
                m_Description = value
            End If
        End Set
    End Property


    'Return values to be displayed in the listbox
    Public Overrides Function ToString() As String
        Try
            Return Me.Manufacturer & ", " & Me.Product & ", " & Me.UnitsInStock & " units in stock, " & Me.RetailPrice.ToString("C") & " (retail price)"
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Function


End Class
