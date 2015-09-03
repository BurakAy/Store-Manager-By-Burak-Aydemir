'Burak Aydemir


Option Strict On
Option Explicit On

Public Class frmAddEditProduct

    'Module level variables to hold values
    Private mProduct As Product = Nothing
    Private mDepartment As Department
    Private mProductList As ProductList


    'Opening the form for adding a new product
    Public Sub OpenForAdd(aDepartment As Department, theProducts As ProductList)
        Try
            'Set ProductID label for a new ID
            lblProductIDDisplay.Text = "<new>"

            'Pass in values of aDepartment and theProducts
            mDepartment = aDepartment
            mProductList = theProducts

            'Set date updated to today's date
            txtDateUpdated.Text = Date.Today.ToShortDateString

            'Set DepartmentID display textbox to read only so value isn't changed
            txtDepartmentDisplay.ReadOnly = True

            'Set DepartmentID display textbox to the name of the selected department
            txtDepartmentDisplay.Text = mDepartment.DepartmentName

            'Show the form
            Me.ShowDialog()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    'Open the form for editing an existing product
    Public Sub OpenForEdit(oldProduct As Product, aDepartment As Department, theProducts As ProductList)
        Try
            'Set form window text to that of the product being edited
            Me.Text = "Edit Product: " & oldProduct.Product

            'Populate form fields with data from the selected product
            With oldProduct
                lblProductIDDisplay.Text = CStr(.ProductID)
                txtDateUpdated.Text = CStr(oldProduct.DateUpdated)
                txtDepartmentDisplay.Text = aDepartment.DepartmentName
                txtProduct.Text = .Product
                txtManufacturer.Text = .Manufacturer
                txtModelNumber.Text = .ModelNumber
                txtWholesalePrice.Text = CStr(.WholesalePrice)
                txtRetailPrice.Text = CStr(.RetailPrice)
                txtUnitsInStock.Text = CStr(.UnitsInStock)
                txtUnitsSold.Text = CStr(.UnitsSold)
                txtDescription.Text = .Description
            End With

            'Pass in values of oldProduct, aDepartment, theProducts
            mProduct = oldProduct
            mDepartment = aDepartment
            mProductList = theProducts

            'Show the form
            Me.ShowDialog()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    'Open the form to view the selected department
    Public Sub OpenToView(aProduct As Product, aDepartment As Department, theProducts As ProductList)
        Try
            'Set form window text to that of the product being viewed
            Me.Text = "Viewing Product: " & aProduct.Product

            'Disable OK button and set text boxes to read only so values can not be changed
            btnOK.Enabled = False
            txtDateUpdated.ReadOnly = True
            txtDepartmentDisplay.ReadOnly = True
            txtProduct.ReadOnly = True
            txtManufacturer.ReadOnly = True
            txtModelNumber.ReadOnly = True
            txtWholesalePrice.ReadOnly = True
            txtRetailPrice.ReadOnly = True
            txtUnitsInStock.ReadOnly = True
            txtUnitsSold.ReadOnly = True
            txtDescription.ReadOnly = True

            'Populate form fields with data from the selected product
            With aProduct
                lblProductIDDisplay.Text = .ProductID.ToString
                txtDateUpdated.Text = .DateUpdated.ToShortDateString
                txtDepartmentDisplay.Text = aDepartment.DepartmentName
                txtProduct.Text = .Product
                txtManufacturer.Text = .Manufacturer
                txtModelNumber.Text = .ModelNumber
                txtWholesalePrice.Text = .WholesalePrice.ToString("C")
                txtRetailPrice.Text = .RetailPrice.ToString("C")
                txtUnitsInStock.Text = .UnitsInStock.ToString
                txtUnitsSold.Text = .UnitsSold.ToString
                txtDescription.Text = .Description
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
            'Variable for a new Product
            Dim newProduct As New Product

            'Call function to validate user input
            If IsValidData() Then

                'New product values filled with user entered field valued
                With newProduct
                    .DateUpdated = CDate(txtDateUpdated.Text)
                    .DepartmentID = mDepartment.DepartmentID
                    .Product = txtProduct.Text
                    .Manufacturer = txtManufacturer.Text
                    .ModelNumber = txtModelNumber.Text
                    .WholesalePrice = CDec(txtWholesalePrice.Text)
                    .RetailPrice = CDec(txtRetailPrice.Text)
                    .UnitsInStock = CInt(txtUnitsInStock.Text)
                    .UnitsSold = CInt(txtUnitsSold.Text)
                    .Description = txtDescription.Text
                End With

                'If module level variable is empty, add newProduct values for a new product
                If mProduct Is Nothing Then
                    mProductList.Add(newProduct)
                Else
                    'Update the module level variable values with those of the newProduct values
                    mProductList.Update(mProduct, newProduct)
                End If

                'Close the form
                Me.Close()
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
            Return Validation.IsDate(txtDateUpdated, "Date Updated") AndAlso
                   Validation.IsPresent(txtDateUpdated, "Date Updated") AndAlso
                   Validation.IsPresent(txtProduct, "Product") AndAlso
                   Validation.IsPresent(txtDepartmentDisplay, "Department") AndAlso
                   Validation.IsPresent(txtManufacturer, "Manufacturer") AndAlso
                   Validation.IsPresent(txtModelNumber, "ModelNumber") AndAlso
                   Validation.IsPresent(txtWholesalePrice, "Wholesale Price") AndAlso
                   Validation.IsDecimal(txtWholesalePrice, "Wholesale Price") AndAlso
                   Validation.IsPresent(txtRetailPrice, "Retail Price") AndAlso
                   Validation.IsDecimal(txtRetailPrice, "Retail Price") AndAlso
                   Validation.IsPresent(txtUnitsInStock, "Units in Stock") AndAlso
                   Validation.IsInt32(txtUnitsInStock, "Units in Stock") AndAlso
                   Validation.IsPresent(txtUnitsSold, "Units Sold") AndAlso
                   Validation.IsInt32(txtUnitsSold, "Units Sold") AndAlso
                   Validation.IsPresent(txtDescription, "Description")
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            Return False
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