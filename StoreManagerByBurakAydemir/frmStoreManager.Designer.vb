<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStoreManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblDepartmentName As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStoreManager))
        Me.grpInventory = New System.Windows.Forms.GroupBox()
        Me.lstInventory = New System.Windows.Forms.ListBox()
        Me.btnViewDepartmentDetails = New System.Windows.Forms.Button()
        Me.btnViewProductDetails = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDeleteProduct = New System.Windows.Forms.Button()
        Me.btnEditProduct = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnDeleteDepartment = New System.Windows.Forms.Button()
        Me.btnEditDepartment = New System.Windows.Forms.Button()
        Me.btnAddDepartment = New System.Windows.Forms.Button()
        Me.cmbDepartmentName = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteDeparmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        lblDepartmentName = New System.Windows.Forms.Label()
        Me.grpInventory.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDepartmentName
        '
        lblDepartmentName.AutoSize = True
        lblDepartmentName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDepartmentName.Location = New System.Drawing.Point(47, 73)
        lblDepartmentName.Name = "lblDepartmentName"
        lblDepartmentName.Size = New System.Drawing.Size(112, 15)
        lblDepartmentName.TabIndex = 0
        lblDepartmentName.Text = "Department Name:"
        '
        'grpInventory
        '
        Me.grpInventory.BackColor = System.Drawing.SystemColors.Window
        Me.grpInventory.Controls.Add(Me.lstInventory)
        Me.grpInventory.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInventory.Location = New System.Drawing.Point(21, 155)
        Me.grpInventory.Name = "grpInventory"
        Me.grpInventory.Size = New System.Drawing.Size(523, 148)
        Me.grpInventory.TabIndex = 6
        Me.grpInventory.TabStop = False
        Me.grpInventory.Text = "Department Inventory"
        '
        'lstInventory
        '
        Me.lstInventory.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInventory.FormattingEnabled = True
        Me.lstInventory.ItemHeight = 16
        Me.lstInventory.Location = New System.Drawing.Point(7, 20)
        Me.lstInventory.Name = "lstInventory"
        Me.lstInventory.Size = New System.Drawing.Size(510, 116)
        Me.lstInventory.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstInventory, "Inventory within the selected department")
        '
        'btnViewDepartmentDetails
        '
        Me.btnViewDepartmentDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnViewDepartmentDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnViewDepartmentDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnViewDepartmentDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDepartmentDetails.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDepartmentDetails.Location = New System.Drawing.Point(412, 126)
        Me.btnViewDepartmentDetails.Name = "btnViewDepartmentDetails"
        Me.btnViewDepartmentDetails.Size = New System.Drawing.Size(105, 23)
        Me.btnViewDepartmentDetails.TabIndex = 5
        Me.btnViewDepartmentDetails.Text = "&View Details"
        Me.ToolTip1.SetToolTip(Me.btnViewDepartmentDetails, "View details of the selected department")
        Me.btnViewDepartmentDetails.UseVisualStyleBackColor = False
        '
        'btnViewProductDetails
        '
        Me.btnViewProductDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnViewProductDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnViewProductDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnViewProductDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewProductDetails.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewProductDetails.Location = New System.Drawing.Point(336, 316)
        Me.btnViewProductDetails.Name = "btnViewProductDetails"
        Me.btnViewProductDetails.Size = New System.Drawing.Size(99, 23)
        Me.btnViewProductDetails.TabIndex = 10
        Me.btnViewProductDetails.Text = "Vie&w Details"
        Me.ToolTip1.SetToolTip(Me.btnViewProductDetails, "View details of the selected product")
        Me.btnViewProductDetails.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(469, 316)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit the program")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDeleteProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnDeleteProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteProduct.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteProduct.Location = New System.Drawing.Point(231, 316)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(99, 23)
        Me.btnDeleteProduct.TabIndex = 9
        Me.btnDeleteProduct.Text = "De&lete Product"
        Me.ToolTip1.SetToolTip(Me.btnDeleteProduct, "Delete the selected product")
        Me.btnDeleteProduct.UseVisualStyleBackColor = False
        '
        'btnEditProduct
        '
        Me.btnEditProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnEditProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditProduct.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditProduct.Location = New System.Drawing.Point(126, 316)
        Me.btnEditProduct.Name = "btnEditProduct"
        Me.btnEditProduct.Size = New System.Drawing.Size(99, 23)
        Me.btnEditProduct.TabIndex = 8
        Me.btnEditProduct.Text = "E&dit Product"
        Me.ToolTip1.SetToolTip(Me.btnEditProduct, "Edit the selected product")
        Me.btnEditProduct.UseVisualStyleBackColor = False
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProduct.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.Location = New System.Drawing.Point(21, 316)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(99, 23)
        Me.btnAddProduct.TabIndex = 7
        Me.btnAddProduct.Text = "Add &Product"
        Me.ToolTip1.SetToolTip(Me.btnAddProduct, "Add a new product")
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'btnDeleteDepartment
        '
        Me.btnDeleteDepartment.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDeleteDepartment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnDeleteDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDeleteDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteDepartment.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteDepartment.Location = New System.Drawing.Point(412, 97)
        Me.btnDeleteDepartment.Name = "btnDeleteDepartment"
        Me.btnDeleteDepartment.Size = New System.Drawing.Size(105, 23)
        Me.btnDeleteDepartment.TabIndex = 4
        Me.btnDeleteDepartment.Text = "&Delete Department"
        Me.ToolTip1.SetToolTip(Me.btnDeleteDepartment, "Delete the selected department")
        Me.btnDeleteDepartment.UseVisualStyleBackColor = False
        '
        'btnEditDepartment
        '
        Me.btnEditDepartment.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditDepartment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnEditDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnEditDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditDepartment.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDepartment.Location = New System.Drawing.Point(412, 68)
        Me.btnEditDepartment.Name = "btnEditDepartment"
        Me.btnEditDepartment.Size = New System.Drawing.Size(105, 23)
        Me.btnEditDepartment.TabIndex = 3
        Me.btnEditDepartment.Text = "&Edit Department"
        Me.ToolTip1.SetToolTip(Me.btnEditDepartment, "Edit the selected department")
        Me.btnEditDepartment.UseVisualStyleBackColor = False
        '
        'btnAddDepartment
        '
        Me.btnAddDepartment.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAddDepartment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnAddDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDepartment.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDepartment.Location = New System.Drawing.Point(412, 38)
        Me.btnAddDepartment.Name = "btnAddDepartment"
        Me.btnAddDepartment.Size = New System.Drawing.Size(105, 23)
        Me.btnAddDepartment.TabIndex = 2
        Me.btnAddDepartment.Text = "&Add Department"
        Me.ToolTip1.SetToolTip(Me.btnAddDepartment, "Add a new department")
        Me.btnAddDepartment.UseVisualStyleBackColor = False
        '
        'cmbDepartmentName
        '
        Me.cmbDepartmentName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartmentName.FormattingEnabled = True
        Me.cmbDepartmentName.Location = New System.Drawing.Point(163, 70)
        Me.cmbDepartmentName.Name = "cmbDepartmentName"
        Me.cmbDepartmentName.Size = New System.Drawing.Size(213, 23)
        Me.cmbDepartmentName.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cmbDepartmentName, "Select a department")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(565, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDepartmentToolStripMenuItem, Me.EditDepartmentToolStripMenuItem, Me.DeleteDeparmentToolStripMenuItem, Me.ViewDepartmentToolStripMenuItem, Me.ToolStripMenuItem1, Me.AddProductToolStripMenuItem, Me.EditProductToolStripMenuItem, Me.DeleteProductToolStripMenuItem, Me.ViewProductToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'AddDepartmentToolStripMenuItem
        '
        Me.AddDepartmentToolStripMenuItem.Name = "AddDepartmentToolStripMenuItem"
        Me.AddDepartmentToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AddDepartmentToolStripMenuItem.Text = "Add Department"
        '
        'EditDepartmentToolStripMenuItem
        '
        Me.EditDepartmentToolStripMenuItem.Name = "EditDepartmentToolStripMenuItem"
        Me.EditDepartmentToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EditDepartmentToolStripMenuItem.Text = "Edit Department"
        '
        'DeleteDeparmentToolStripMenuItem
        '
        Me.DeleteDeparmentToolStripMenuItem.Name = "DeleteDeparmentToolStripMenuItem"
        Me.DeleteDeparmentToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DeleteDeparmentToolStripMenuItem.Text = "Delete Deparment"
        '
        'ViewDepartmentToolStripMenuItem
        '
        Me.ViewDepartmentToolStripMenuItem.Name = "ViewDepartmentToolStripMenuItem"
        Me.ViewDepartmentToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ViewDepartmentToolStripMenuItem.Text = "View Department"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(166, 6)
        '
        'AddProductToolStripMenuItem
        '
        Me.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem"
        Me.AddProductToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AddProductToolStripMenuItem.Text = "Add Product"
        '
        'EditProductToolStripMenuItem
        '
        Me.EditProductToolStripMenuItem.Name = "EditProductToolStripMenuItem"
        Me.EditProductToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EditProductToolStripMenuItem.Text = "Edit Product"
        '
        'DeleteProductToolStripMenuItem
        '
        Me.DeleteProductToolStripMenuItem.Name = "DeleteProductToolStripMenuItem"
        Me.DeleteProductToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DeleteProductToolStripMenuItem.Text = "Delete Product"
        '
        'ViewProductToolStripMenuItem
        '
        Me.ViewProductToolStripMenuItem.Name = "ViewProductToolStripMenuItem"
        Me.ViewProductToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ViewProductToolStripMenuItem.Text = "View Product"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 48)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'frmStoreManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(565, 354)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.grpInventory)
        Me.Controls.Add(Me.btnViewDepartmentDetails)
        Me.Controls.Add(Me.btnViewProductDetails)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDeleteProduct)
        Me.Controls.Add(Me.btnEditProduct)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.btnDeleteDepartment)
        Me.Controls.Add(Me.btnEditDepartment)
        Me.Controls.Add(Me.btnAddDepartment)
        Me.Controls.Add(lblDepartmentName)
        Me.Controls.Add(Me.cmbDepartmentName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStoreManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Store Manager"
        Me.grpInventory.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpInventory As System.Windows.Forms.GroupBox
    Friend WithEvents lstInventory As System.Windows.Forms.ListBox
    Friend WithEvents btnViewDepartmentDetails As System.Windows.Forms.Button
    Friend WithEvents btnViewProductDetails As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDeleteProduct As System.Windows.Forms.Button
    Friend WithEvents btnEditProduct As System.Windows.Forms.Button
    Friend WithEvents btnAddProduct As System.Windows.Forms.Button
    Friend WithEvents btnDeleteDepartment As System.Windows.Forms.Button
    Friend WithEvents btnEditDepartment As System.Windows.Forms.Button
    Friend WithEvents btnAddDepartment As System.Windows.Forms.Button
    Friend WithEvents cmbDepartmentName As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddDepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditDepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteDeparmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
