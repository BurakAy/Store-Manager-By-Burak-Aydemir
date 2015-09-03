'Burak Aydemir


Option Strict On
Option Explicit On

Public Class ProductList
    Inherits List(Of Product)

    'Event handler, raised when the product list changes
    Public Event ProductListChanged(sender As Object)


    'Add a new product to inherited Product list
    Public Overloads Sub Add(aProductID As Integer, aDateUpdated As Date, aDepartmentID As Integer, aProductName As String, aManufacurer As String, aModelNumber As String, aWholesalePrice As Decimal, aRetailPrice As Decimal, aUnitsInStock As Integer, aUnitsSold As Integer, aDescription As String)
        Dim newProduct As New Product

        'New product values
        With newProduct
            .ProductID = aProductID
            .DateUpdated = aDateUpdated
            .DepartmentID = aDepartmentID
            .Product = aProductName
            .Manufacturer = aManufacurer
            .ModelNumber = aModelNumber
            .WholesalePrice = aWholesalePrice
            .RetailPrice = aRetailPrice
            .UnitsInStock = aUnitsInStock
            .UnitsSold = aUnitsSold
            .Description = aDescription
        End With
        MyBase.Add(newProduct)
    End Sub


    'Call method from ProductDB to load products with aDepartmentID, save to inherited Product list, raise changed event
    Public Sub FillFor(aDepartmentID As Integer)
        For Each aProduct As Product In ProductDB.GetProductsForDepartment(aDepartmentID)
            MyBase.Add(aProduct)
        Next
        RaiseEvent ProductListChanged(aDepartmentID)
    End Sub


    'Add aProduct to inherited Product list, raise changed event
    Public Overloads Sub Add(aProduct As Product)
        ProductDB.AddProduct(aProduct)
        MyBase.Add(aProduct)
        RaiseEvent ProductListChanged(aProduct)
    End Sub


    'Update oldProduct values with newProduct values, raise changed event
    Public Sub Update(oldProduct As Product, newProduct As Product)
        If ProductDB.UpdateProduct(oldProduct, newProduct) Then

            'Old product values to be updated with new product values
            With oldProduct
                .DateUpdated = newProduct.DateUpdated
                .DepartmentID = newProduct.DepartmentID
                .Product = newProduct.Product
                .Manufacturer = newProduct.Manufacturer
                .ModelNumber = newProduct.ModelNumber
                .WholesalePrice = newProduct.WholesalePrice
                .RetailPrice = newProduct.RetailPrice
                .UnitsInStock = newProduct.UnitsInStock
                .UnitsSold = newProduct.UnitsSold
                .Description = newProduct.Description
            End With
            RaiseEvent ProductListChanged(oldProduct)
        End If
    End Sub


    'Remove aProduct from inherited Product list, raise changed event
    Public Overloads Sub Remove(aProduct As Product)
        ProductDB.DeleteProduct(aProduct)
        MyBase.Remove(aProduct)
        RaiseEvent ProductListChanged(aProduct)
    End Sub


End Class
