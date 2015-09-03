'Burak Aydemir
'MIS 239
'Final Project

Option Strict On
Option Explicit On

Public Class frmStoreManager

    'Module level variables with events
    Private WithEvents mDepartmentList As DepartmentList
    Private WithEvents mProductList As ProductList

    'Handle the event of DepartmentList being changed
    Private Sub mDepartmentList_DepartmentListChanged() Handles mDepartmentList.DepartmentListChanged
        Try
            'Call DisplayDepartments
            DisplayDepartments()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    'Handle the event of ProductList being changed
    Private Sub mProductList_ProductListChanged() Handles mProductList.ProductListChanged
        Try
            'Call DisplayProducts
            DisplayProducts()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub frmStoreManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Store departments to mDepartmentList, called from DepartmentDB
            mDepartmentList = DepartmentDB.GetDepartmentList

            'Call to add departments to the combo box
            DisplayDepartments()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub cmbDepartmentName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartmentName.SelectedIndexChanged
        Try
            'If a department is selected from the combobox, aDepartment is the selected department
            If cmbDepartmentName.SelectedIndex >= 0 Then
                Dim aDepartment As Department = CType(cmbDepartmentName.SelectedItem, Department)

                'Fill the module level variable of mProdoductList with products found in the selected department based on the DepartmentID
                mProductList = New ProductList
                mProductList.FillFor(aDepartment.DepartmentID)

                
                'If there are items in the module level variable mProducList, set the listbox selected index so no products are selected when populated
                If mProductList.Count > 0 Then
                    lstInventory.SelectedIndex = -1
                End If

                'Change the groupbox text to that of the selected department's name
                grpInventory.Text = aDepartment.DepartmentName & " Inventory"
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub DisplayDepartments()
        Try
            'Clear the combobox
            cmbDepartmentName.Items.Clear()

            'Add departments stored in module level variable mDepartmentList into the combobox
            For Each aDepartment As Department In mDepartmentList
                cmbDepartmentName.Items.Add(aDepartment)
            Next
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub DisplayProducts()
        Try
            'Clear the listbox
            lstInventory.Items.Clear()

            'If there are no products in the department, display message.
            If mProductList.Count = 0 Then
                MessageBox.Show("There are currently no products in this department", "Empty Department", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Get products stored in module level variable mProductList, add to the listbox
                For Each aProduct As Product In mProductList
                    lstInventory.Items.Add(aProduct)
                Next
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub btnAddDepartment_Click(sender As Object, e As EventArgs) Handles btnAddDepartment.Click
        Try
            'Call for opening frmAddEditDepartment
            AddDepartment()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Public Sub AddDepartment()
        Try
            'Variable for new form
            Dim frm As New frmAddEditDepartment

            'Open frmAddEditDepartment for adding a new department
            frm.OpenForAdd(mDepartmentList)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub btnEditDepartment_Click(sender As Object, e As EventArgs) Handles btnEditDepartment.Click
        Try
            'Call for opening frmAddEditDepartment
            EditDepartment()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Public Sub EditDepartment()
        Try
            'Variable for new form
            Dim frm As New frmAddEditDepartment

            'If no department is selected, show message
            If cmbDepartmentName.SelectedIndex < 0 Then
                MessageBox.Show("Select a department to edit.", "Edit Department", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                'Open frmAddEditDepartment for editing the selected department
                frm.OpenForEdit(CType(cmbDepartmentName.SelectedItem, Department), mDepartmentList)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub btnDeleteDepartment_Click(sender As Object, e As EventArgs) Handles btnDeleteDepartment.Click
        Try
            'Call for deleting a department
            DeleteDepartment()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Public Sub DeleteDepartment()
        Try
            'Variable for DialogResult
            Dim dr As DialogResult

            'If no department is selected, prompt user to select a department
            If cmbDepartmentName.SelectedIndex < 0 Then
                MessageBox.Show("Select a department to delete.", "Delete Department", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                'If there are still products in the deparment, warn user, disallows deletion of department 
            ElseIf lstInventory.Items.Count > 0 Then
                MessageBox.Show("There are products in this department. You must delete the products first if you would like to delete the department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Show messagebox which returns a value selected by the user, OK or Cancel
                dr = MessageBox.Show("Are you sure you want to delete this department?", "Delete Department", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                'If user selects OK, delete the selected department
                If dr = Windows.Forms.DialogResult.OK Then
                    mDepartmentList.Remove(CType(cmbDepartmentName.SelectedItem, Department))

                    'Reset the text of the combobox to remove deleted department from selection
                    cmbDepartmentName.ResetText()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub btnViewDepartmentDetails_Click(sender As Object, e As EventArgs) Handles btnViewDepartmentDetails.Click
        Try
            'Call to open frmAddEditDepartment for viewing department details
            ViewDepartment()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Public Sub ViewDepartment()
        Try
            'Variable for the new form
            Dim frm As New frmAddEditDepartment

            'If no department is selected, prompt user to select one
            If cmbDepartmentName.SelectedIndex < 0 Then
                MessageBox.Show("Select a department to view.", "View Department", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                'Open the form to view details fo the selected department
                frm.OpenToView(CType(cmbDepartmentName.SelectedItem, Department))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Try
            'Call to open frmAddEditProduct for adding a new product
            AddProduct()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Public Sub AddProduct()
        Try
            'Variable for the new form
            Dim frm As New frmAddEditProduct

            'If no deparment is selected from the combobox, prompt user to select a department for the new product
            If cmbDepartmentName.SelectedIndex < 0 Then
                MessageBox.Show("Select a department for the product you would like to add", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                'Open frmAddEditProduct for adding a new product, get the department selected and the product stored in the module level variable
                frm.OpenForAdd(CType(cmbDepartmentName.SelectedItem, Department), mProductList)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub btnEditProduct_Click(sender As Object, e As EventArgs) Handles btnEditProduct.Click
        Try
            'Call to open frmAddEditProduct for editing a product
            EditProduct()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Public Sub EditProduct()
        Try
            'Variable for new form
            Dim frm As New frmAddEditProduct

            'If no product is selected from the listbox, prompt user to select one
            If lstInventory.SelectedIndex < 0 Then
                MessageBox.Show("Select a product to edit.", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                'Open the form to edit the selected product from the listbox, get department selected in combobox, and the product stored in the module level variable
                frm.OpenForEdit(CType(lstInventory.SelectedItem, Product), CType(cmbDepartmentName.SelectedItem, Department), mProductList)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        Try
            'Call to delete the selected product
            DeleteProduct()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Public Sub DeleteProduct()
        Try
            'Variable for DialogResult
            Dim dr As DialogResult

            'If no product is selected, prompt user to select one
            If lstInventory.SelectedIndex < 0 Then
                MessageBox.Show("Select a product to delete.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                'If user selects OK from messagebox, delete the selected product
                dr = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If dr = Windows.Forms.DialogResult.OK Then
                    mProductList.Remove(CType(lstInventory.SelectedItem, Product))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub btnViewProductDetails_Click(sender As Object, e As EventArgs) Handles btnViewProductDetails.Click
        Try
            'Call to open frmAddEditProdut for viewing product details
            ViewProduct()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Public Sub ViewProduct()
        Try
            'Variable for new form
            Dim frm As New frmAddEditProduct

            'If no product is selected, prompt user to select a product
            If lstInventory.SelectedIndex < 0 Then
                MessageBox.Show("Select a product to view details.", "View Product", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                'Open the form to view product details
                frm.OpenToView(CType(lstInventory.SelectedItem, Product), CType(cmbDepartmentName.SelectedItem, Department), mProductList)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub AddDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDepartmentToolStripMenuItem.Click
        Try
            'Call to open frmAddEditDepartment for adding when selected from toolstrip
            AddDepartment()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub EditDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDepartmentToolStripMenuItem.Click
        Try
            'Call to open frmAddEditDepartment for editing when selected from toolstrip
            EditDepartment()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub DeleteDeparmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteDeparmentToolStripMenuItem.Click
        Try
            'Call to delete a department when selected from toolstrip
            DeleteDepartment()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub ViewDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDepartmentToolStripMenuItem.Click
        Try
            'Call to open frmAddEditDepartment for viewing department details when selected from toolstrip
            ViewDepartment()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub AddProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductToolStripMenuItem.Click
        Try
            'Call to open frmAddEditProduct for adding when selected from toolstrip
            AddProduct()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub EditProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProductToolStripMenuItem.Click
        Try
            'Call to open frmAddEditProduct for editing when selected from toolstrip
            EditProduct()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub DeleteProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteProductToolStripMenuItem.Click
        Try
            'Call to delete a product when selected from toolstrip
            DeleteProduct()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub ViewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProductToolStripMenuItem.Click
        Try
            'Call to open frmAddEditProduct for viewing details when selected from toolstrip
            ViewProduct()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            'Close the form
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Try
            'Close the form when selected from toolstrip
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Try
            'Variable for new form
            Dim frm As New frmAbout

            'Open frmAbout when selected from toolstrip
            frm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Try
            'Variable for new form
            Dim frm As New frmAbout

            'Open frmAbout when selected from the context menu
            frm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Try
            'Close the form when selected from context menu
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub




End Class
