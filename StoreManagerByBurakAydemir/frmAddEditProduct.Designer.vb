<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditProduct))
        Me.txtDepartmentDisplay = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblUnitsSold = New System.Windows.Forms.Label()
        Me.txtUnitsSold = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtUnitsInStock = New System.Windows.Forms.TextBox()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.txtWholesalePrice = New System.Windows.Forms.TextBox()
        Me.lblUnitsInStock = New System.Windows.Forms.Label()
        Me.lblRetailPrice = New System.Windows.Forms.Label()
        Me.lblWholesalePrice = New System.Windows.Forms.Label()
        Me.lblModelNumber = New System.Windows.Forms.Label()
        Me.txtModelNumber = New System.Windows.Forms.TextBox()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtDateUpdated = New System.Windows.Forms.TextBox()
        Me.lblDateUpdated = New System.Windows.Forms.Label()
        Me.lblProductIDDisplay = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDepartmentDisplay
        '
        Me.txtDepartmentDisplay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartmentDisplay.Location = New System.Drawing.Point(118, 87)
        Me.txtDepartmentDisplay.Name = "txtDepartmentDisplay"
        Me.txtDepartmentDisplay.ReadOnly = True
        Me.txtDepartmentDisplay.Size = New System.Drawing.Size(133, 21)
        Me.txtDepartmentDisplay.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(235, 365)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "&Cancel"
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancel and close")
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(126, 365)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 22
        Me.btnOK.Text = "&OK"
        Me.ToolTip1.SetToolTip(Me.btnOK, "Save entry and close")
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(39, 301)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(73, 15)
        Me.lblDescription.TabIndex = 20
        Me.lblDescription.Text = "Description:"
        '
        'lblUnitsSold
        '
        Me.lblUnitsSold.AutoSize = True
        Me.lblUnitsSold.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitsSold.Location = New System.Drawing.Point(45, 275)
        Me.lblUnitsSold.Name = "lblUnitsSold"
        Me.lblUnitsSold.Size = New System.Drawing.Size(67, 15)
        Me.lblUnitsSold.TabIndex = 18
        Me.lblUnitsSold.Text = "Units Sold:"
        '
        'txtUnitsSold
        '
        Me.txtUnitsSold.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitsSold.Location = New System.Drawing.Point(118, 272)
        Me.txtUnitsSold.Name = "txtUnitsSold"
        Me.txtUnitsSold.Size = New System.Drawing.Size(70, 21)
        Me.txtUnitsSold.TabIndex = 19
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(118, 298)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(307, 54)
        Me.txtDescription.TabIndex = 21
        '
        'txtUnitsInStock
        '
        Me.txtUnitsInStock.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitsInStock.Location = New System.Drawing.Point(118, 246)
        Me.txtUnitsInStock.Name = "txtUnitsInStock"
        Me.txtUnitsInStock.Size = New System.Drawing.Size(70, 21)
        Me.txtUnitsInStock.TabIndex = 17
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetailPrice.Location = New System.Drawing.Point(118, 220)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(95, 21)
        Me.txtRetailPrice.TabIndex = 15
        '
        'txtWholesalePrice
        '
        Me.txtWholesalePrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWholesalePrice.Location = New System.Drawing.Point(118, 194)
        Me.txtWholesalePrice.Name = "txtWholesalePrice"
        Me.txtWholesalePrice.Size = New System.Drawing.Size(95, 21)
        Me.txtWholesalePrice.TabIndex = 13
        '
        'lblUnitsInStock
        '
        Me.lblUnitsInStock.AutoSize = True
        Me.lblUnitsInStock.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitsInStock.Location = New System.Drawing.Point(27, 249)
        Me.lblUnitsInStock.Name = "lblUnitsInStock"
        Me.lblUnitsInStock.Size = New System.Drawing.Size(85, 15)
        Me.lblUnitsInStock.TabIndex = 16
        Me.lblUnitsInStock.Text = "Units In Stock:"
        '
        'lblRetailPrice
        '
        Me.lblRetailPrice.AutoSize = True
        Me.lblRetailPrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetailPrice.Location = New System.Drawing.Point(39, 223)
        Me.lblRetailPrice.Name = "lblRetailPrice"
        Me.lblRetailPrice.Size = New System.Drawing.Size(73, 15)
        Me.lblRetailPrice.TabIndex = 14
        Me.lblRetailPrice.Text = "Retail Price:"
        '
        'lblWholesalePrice
        '
        Me.lblWholesalePrice.AutoSize = True
        Me.lblWholesalePrice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWholesalePrice.Location = New System.Drawing.Point(12, 197)
        Me.lblWholesalePrice.Name = "lblWholesalePrice"
        Me.lblWholesalePrice.Size = New System.Drawing.Size(100, 15)
        Me.lblWholesalePrice.TabIndex = 12
        Me.lblWholesalePrice.Text = "Wholesale Price:"
        '
        'lblModelNumber
        '
        Me.lblModelNumber.AutoSize = True
        Me.lblModelNumber.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelNumber.Location = New System.Drawing.Point(21, 170)
        Me.lblModelNumber.Name = "lblModelNumber"
        Me.lblModelNumber.Size = New System.Drawing.Size(91, 15)
        Me.lblModelNumber.TabIndex = 10
        Me.lblModelNumber.Text = "Model Number:"
        '
        'txtModelNumber
        '
        Me.txtModelNumber.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelNumber.Location = New System.Drawing.Point(118, 167)
        Me.txtModelNumber.Name = "txtModelNumber"
        Me.txtModelNumber.Size = New System.Drawing.Size(213, 21)
        Me.txtModelNumber.TabIndex = 11
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManufacturer.Location = New System.Drawing.Point(118, 141)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(213, 21)
        Me.txtManufacturer.TabIndex = 9
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufacturer.Location = New System.Drawing.Point(31, 144)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(81, 15)
        Me.lblManufacturer.TabIndex = 8
        Me.lblManufacturer.Text = "Manufacturer:"
        '
        'txtProduct
        '
        Me.txtProduct.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct.Location = New System.Drawing.Point(118, 115)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(167, 21)
        Me.txtProduct.TabIndex = 7
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(60, 118)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(52, 15)
        Me.lblProduct.TabIndex = 6
        Me.lblProduct.Text = "Product:"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(37, 90)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(75, 15)
        Me.lblDepartment.TabIndex = 4
        Me.lblDepartment.Text = "Department:"
        '
        'txtDateUpdated
        '
        Me.txtDateUpdated.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateUpdated.Location = New System.Drawing.Point(118, 60)
        Me.txtDateUpdated.Name = "txtDateUpdated"
        Me.txtDateUpdated.Size = New System.Drawing.Size(70, 21)
        Me.txtDateUpdated.TabIndex = 3
        '
        'lblDateUpdated
        '
        Me.lblDateUpdated.AutoSize = True
        Me.lblDateUpdated.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateUpdated.Location = New System.Drawing.Point(26, 63)
        Me.lblDateUpdated.Name = "lblDateUpdated"
        Me.lblDateUpdated.Size = New System.Drawing.Size(86, 15)
        Me.lblDateUpdated.TabIndex = 2
        Me.lblDateUpdated.Text = "Date Updated:"
        '
        'lblProductIDDisplay
        '
        Me.lblProductIDDisplay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductIDDisplay.Location = New System.Drawing.Point(118, 37)
        Me.lblProductIDDisplay.Name = "lblProductIDDisplay"
        Me.lblProductIDDisplay.Size = New System.Drawing.Size(66, 13)
        Me.lblProductIDDisplay.TabIndex = 1
        Me.lblProductIDDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.Location = New System.Drawing.Point(45, 37)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(67, 15)
        Me.lblProductID.TabIndex = 0
        Me.lblProductID.Text = "Product ID:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(437, 24)
        Me.MenuStrip1.TabIndex = 24
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
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(93, 26)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'frmAddEditProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(437, 400)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.txtDepartmentDisplay)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblUnitsSold)
        Me.Controls.Add(Me.txtUnitsSold)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtUnitsInStock)
        Me.Controls.Add(Me.txtRetailPrice)
        Me.Controls.Add(Me.txtWholesalePrice)
        Me.Controls.Add(Me.lblUnitsInStock)
        Me.Controls.Add(Me.lblRetailPrice)
        Me.Controls.Add(Me.lblWholesalePrice)
        Me.Controls.Add(Me.lblModelNumber)
        Me.Controls.Add(Me.txtModelNumber)
        Me.Controls.Add(Me.txtManufacturer)
        Me.Controls.Add(Me.lblManufacturer)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.txtDateUpdated)
        Me.Controls.Add(Me.lblDateUpdated)
        Me.Controls.Add(Me.lblProductIDDisplay)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddEditProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Product"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDepartmentDisplay As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblUnitsSold As System.Windows.Forms.Label
    Friend WithEvents txtUnitsSold As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitsInStock As System.Windows.Forms.TextBox
    Friend WithEvents txtRetailPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtWholesalePrice As System.Windows.Forms.TextBox
    Friend WithEvents lblUnitsInStock As System.Windows.Forms.Label
    Friend WithEvents lblRetailPrice As System.Windows.Forms.Label
    Friend WithEvents lblWholesalePrice As System.Windows.Forms.Label
    Friend WithEvents lblModelNumber As System.Windows.Forms.Label
    Friend WithEvents txtModelNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents lblManufacturer As System.Windows.Forms.Label
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents txtDateUpdated As System.Windows.Forms.TextBox
    Friend WithEvents lblDateUpdated As System.Windows.Forms.Label
    Friend WithEvents lblProductIDDisplay As System.Windows.Forms.Label
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
