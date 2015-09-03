'Burak Aydemir
'MIS 239
'Final Project

Option Strict On
Option Explicit On

Imports System.Data
Imports System.Data.OleDb

Public Class ProductDB

    Public Shared Function GetProductsForDepartment(aDepartmentID As Integer) As List(Of Product)

        'Connection object
        Dim connection As OleDbConnection = InventoryDB.GetConnection

        Try
            'Variable for new list of products
            Dim productList As New List(Of Product)

            'SQL statement to select from Inventory table where DepartmentID is value from selected department
            Dim selectStatement As String =
                "SELECT ProductID, DateUpdated, Departments.DepartmentID, Product, Manufacturer, ModelNumber, WholesalePrice, RetailPrice, UnitsInStock, UnitsSold, Description " &
                "FROM Inventory " &
                "WHERE DepartmentID = " & aDepartmentID.ToString

            'Command to hold selectStatement
            Dim selectCommand As New OleDbCommand(selectStatement, connection)

            'Parameter to select value with DepartmentID
            selectCommand.Parameters.AddWithValue("DepartmentID", aDepartmentID)

            'Open the connection
            connection.Open()

            'Execute the reader with select command sql statement
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader

            'Read through the Inventory table
            Do While reader.Read

                'Object to hold product values
                Dim product As New Product

                'Retrieve the field values for product and insert into product property of product object
                product.ProductID = CInt(reader("ProductID"))
                product.DateUpdated = CDate(reader("DateUpdated"))
                product.DepartmentID = CInt(reader("DepartmentID"))
                product.Product = reader("Product").ToString
                product.Manufacturer = reader("Manufacturer").ToString
                product.ModelNumber = reader("ModelNumber").ToString
                product.WholesalePrice = CDec(reader("WholesalePrice"))
                product.RetailPrice = CDec(reader("RetailPrice"))
                product.UnitsInStock = CInt(reader("UnitsInStock"))
                product.UnitsSold = CInt(reader("UnitsSold"))
                product.Description = reader("Description").ToString

                'Add product values to product list, loop back through the table
                productList.Add(product)
            Loop

            'Close the reader when no more records to be read
            reader.Close()

            'Return values which were added to productList
            Return productList
        Catch ex As OleDbException
            Throw
        Finally
            'Close the connection
            connection.Close()
        End Try
    End Function


    Public Shared Function AddProduct(product As Product) As Boolean

        'Connection object
        Dim connection As OleDbConnection = InventoryDB.GetConnection

        Try
            'SQL command to insert into the Inventory table
            Dim insertStatement As String =
                "INSERT INTO Inventory " &
                "(DateUpdated, DepartmentID, Product, Manufacturer, ModelNumber, WholesalePrice, RetailPrice, UnitsInStock, UnitsSold, Description) " &
                "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

            'Command to hold insertStatement
            Dim insertCommand As New OleDbCommand(insertStatement, connection)

            'Create parameters with their values
            insertCommand.Parameters.AddWithValue("DateUpdated", product.DateUpdated)
            insertCommand.Parameters("DateUpdated").DbType = DbType.Date
            insertCommand.Parameters.AddWithValue("DepartmentID", product.DepartmentID)
            insertCommand.Parameters.AddWithValue("Product", product.Product)
            insertCommand.Parameters.AddWithValue("Manufacturer", product.Manufacturer)
            insertCommand.Parameters.AddWithValue("ModelNumber", product.ModelNumber)
            insertCommand.Parameters.AddWithValue("WholesalePrice", product.WholesalePrice)
            insertCommand.Parameters("WholesalePrice").DbType = DbType.Currency
            insertCommand.Parameters.AddWithValue("RetailPrice", product.RetailPrice)
            insertCommand.Parameters("RetailPrice").DbType = DbType.Currency
            insertCommand.Parameters.AddWithValue("UnitsInStock", product.UnitsInStock)
            insertCommand.Parameters.AddWithValue("UnitsSold", product.UnitsSold)
            insertCommand.Parameters.AddWithValue("Description", product.Description)

            'Open the connection
            connection.Open()

            'Count records, insert command if records greater than 0
            Dim count As Integer = insertCommand.ExecuteNonQuery()
            If count > 0 Then

                'Get ProductID
                Dim selectStatement As String = "Select @@IDENTITY"
                Dim selectCommand As New OleDbCommand(selectStatement, connection)
                product.ProductID = CInt(selectCommand.ExecuteScalar)

                'Return with ID value if successful, else, false
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


    Public Shared Function UpdateProduct(oldProduct As Product, newProduct As Product) As Boolean

        'Connection object
        Dim connection As OleDbConnection = InventoryDB.GetConnection

        Try
            'SQL statement to update the Inventory table
            Dim updateStatement As String =
                "UPDATE Inventory SET " &
                "DateUpdated = ?, " &
                "DepartmentID = ?, " &
                "Product = ?, " &
                "Manufacturer = ?, " &
                "ModelNumber = ?, " &
                "WholesalePrice = ?, " &
                "RetailPrice = ?, " &
                "UnitsInStock = ?, " &
                "UnitsSold = ?, " &
                "Description = ? " &
                "WHERE ProductID = ? " &
                "AND DateUpdated = ? " &
                "AND DepartmentID = ? " &
                "AND Product = ? " &
                "AND Manufacturer = ? " &
                "AND ModelNumber = ? " &
                "AND WholesalePrice = ? " &
                "AND RetailPrice = ? " &
                "AND UnitsInStock = ? " &
                "AND UnitsSold = ? " &
                "AND Description = ?"

            'Command to hold updateStatement
            Dim updateCommand As New OleDbCommand(updateStatement, connection)

            'Create parameters for new values
            updateCommand.Parameters.AddWithValue("newDateUpdated", newProduct.DateUpdated)
            updateCommand.Parameters("newDateUpdated").DbType = DbType.Date
            updateCommand.Parameters.AddWithValue("newDepartmentID", newProduct.DepartmentID)
            updateCommand.Parameters.AddWithValue("newProduct", newProduct.Product)
            updateCommand.Parameters.AddWithValue("newManufacturer", newProduct.Manufacturer)
            updateCommand.Parameters.AddWithValue("newModelNumber", newProduct.ModelNumber)
            updateCommand.Parameters.AddWithValue("newWholesalePrice", newProduct.WholesalePrice)
            updateCommand.Parameters("newWholesalePrice").DbType = DbType.Currency
            updateCommand.Parameters.AddWithValue("newRetailPrice", newProduct.RetailPrice)
            updateCommand.Parameters("newRetailPrice").DbType = DbType.Currency
            updateCommand.Parameters.AddWithValue("newUnitsInStock", newProduct.UnitsInStock)
            updateCommand.Parameters.AddWithValue("newUnitsSold", newProduct.UnitsSold)
            updateCommand.Parameters.AddWithValue("newDescription", newProduct.Description)

            'Parameters for old values
            updateCommand.Parameters.AddWithValue("oldProductID", oldProduct.ProductID)
            updateCommand.Parameters.AddWithValue("oldDateUpdated", oldProduct.DateUpdated)
            updateCommand.Parameters("oldDateUpdated").DbType = DbType.Date
            updateCommand.Parameters.AddWithValue("oldDepartmentID", oldProduct.DepartmentID)
            updateCommand.Parameters.AddWithValue("oldProduct", oldProduct.Product)
            updateCommand.Parameters.AddWithValue("oldManufacturer", oldProduct.Manufacturer)
            updateCommand.Parameters.AddWithValue("oldModelNumber", oldProduct.ModelNumber)
            updateCommand.Parameters.AddWithValue("oldWholesalePrice", oldProduct.WholesalePrice)
            updateCommand.Parameters("oldWholesalePrice").DbType = DbType.Currency
            updateCommand.Parameters.AddWithValue("oldRetailPrice", oldProduct.RetailPrice)
            updateCommand.Parameters("oldRetailPrice").DbType = DbType.Currency
            updateCommand.Parameters.AddWithValue("oldUnitsInStock", oldProduct.UnitsInStock)
            updateCommand.Parameters.AddWithValue("oldUnitsSold", oldProduct.UnitsSold)
            updateCommand.Parameters.AddWithValue("oldDescription", oldProduct.Description)

            'Open the connection
            connection.Open()

            'Count records, update command if count greater than 0
            Dim count As Integer = updateCommand.ExecuteNonQuery
            If count > 0 Then

                'Return true if records exist, else, false
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


    Public Shared Function DeleteProduct(product As Product) As Boolean

        'Connection object
        Dim connection As OleDbConnection = InventoryDB.GetConnection

        Try
            'SQL statement to delete values from Inventory table
            Dim deleteStatement As String =
                "DELETE FROM Inventory " &
                "WHERE ProductID = ? " &
                "AND DateUpdated = ? " &
                "AND DepartmentID = ? " &
                "AND Product = ? " &
                "AND Manufacturer = ? " &
                "AND ModelNumber = ? " &
                "AND WholesalePrice = ? " &
                "AND RetailPrice = ? " &
                "AND UnitsInStock = ? " &
                "AND UnitsSold = ? " &
                "AND Description = ? "

            'Command to hold deleteStatement
            Dim deleteCommand As New OleDbCommand(deleteStatement, connection)

            'Create parameters with values to be deleted
            deleteCommand.Parameters.AddWithValue("ProductID", product.ProductID)
            deleteCommand.Parameters.AddWithValue("DateUpdated", product.DateUpdated)
            deleteCommand.Parameters("DateUpdated").DbType = DbType.Date
            deleteCommand.Parameters.AddWithValue("DepartmentID", product.DepartmentID)
            deleteCommand.Parameters.AddWithValue("Product", product.Product)
            deleteCommand.Parameters.AddWithValue("Manufacturer", product.Manufacturer)
            deleteCommand.Parameters.AddWithValue("ModelNumber", product.ModelNumber)
            deleteCommand.Parameters.AddWithValue("WholesalePrice", product.WholesalePrice)
            deleteCommand.Parameters("WholesalePrice").DbType = DbType.Currency
            deleteCommand.Parameters.AddWithValue("RetailPrice", product.RetailPrice)
            deleteCommand.Parameters("RetailPrice").DbType = DbType.Currency
            deleteCommand.Parameters.AddWithValue("UnitsInStock", product.UnitsInStock)
            deleteCommand.Parameters.AddWithValue("UnitsSold", product.UnitsSold)
            deleteCommand.Parameters.AddWithValue("Description", product.Description)

            'Open the connection
            connection.Open()

            'Count records, delete command if count is greater than 0
            Dim count As Integer = deleteCommand.ExecuteNonQuery
            If count > 0 Then

                'Return true if records exist, else, return false
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
