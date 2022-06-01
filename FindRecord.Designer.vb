<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FindRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.cbCate = New System.Windows.Forms.ComboBox()
        Me.txtQuan = New System.Windows.Forms.TextBox()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rdbName = New System.Windows.Forms.RadioButton()
        Me.rdbCate = New System.Windows.Forms.RadioButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cbCate1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem1, Me.AddToolStripMenuItem, Me.ExitToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(976, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem1
        '
        Me.HomeToolStripMenuItem1.Name = "HomeToolStripMenuItem1"
        Me.HomeToolStripMenuItem1.Size = New System.Drawing.Size(64, 24)
        Me.HomeToolStripMenuItem1.Text = "Home"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.AboutToolStripMenuItem.Text = "About "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Inventory Management System (IMS)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Item Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Category :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Quantity :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Location :"
        '
        'lblID
        '
        Me.lblID.Location = New System.Drawing.Point(105, 88)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(55, 22)
        Me.lblID.TabIndex = 9
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(105, 116)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(314, 22)
        Me.txtItem.TabIndex = 10
        '
        'cbCate
        '
        Me.cbCate.FormattingEnabled = True
        Me.cbCate.Items.AddRange(New Object() {"Cargo Pants", "Hoodie", "Sock", "Sweatshirt", "Jeans", "Sneakers", "Tshirt", "Cap"})
        Me.cbCate.Location = New System.Drawing.Point(105, 145)
        Me.cbCate.Name = "cbCate"
        Me.cbCate.Size = New System.Drawing.Size(314, 24)
        Me.cbCate.TabIndex = 11
        '
        'txtQuan
        '
        Me.txtQuan.Location = New System.Drawing.Point(105, 175)
        Me.txtQuan.Name = "txtQuan"
        Me.txtQuan.Size = New System.Drawing.Size(314, 22)
        Me.txtQuan.TabIndex = 12
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(105, 203)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(314, 22)
        Me.txtLoc.TabIndex = 13
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(85, 247)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 29)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(184, 247)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 29)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(285, 247)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 29)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear "
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(490, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Search"
        '
        'rdbName
        '
        Me.rdbName.AutoSize = True
        Me.rdbName.Location = New System.Drawing.Point(495, 148)
        Me.rdbName.Name = "rdbName"
        Me.rdbName.Size = New System.Drawing.Size(65, 20)
        Me.rdbName.TabIndex = 18
        Me.rdbName.TabStop = True
        Me.rdbName.Text = "Name"
        Me.rdbName.UseVisualStyleBackColor = True
        '
        'rdbCate
        '
        Me.rdbCate.AutoSize = True
        Me.rdbCate.Location = New System.Drawing.Point(495, 178)
        Me.rdbCate.Name = "rdbCate"
        Me.rdbCate.Size = New System.Drawing.Size(83, 20)
        Me.rdbCate.TabIndex = 19
        Me.rdbCate.TabStop = True
        Me.rdbCate.Text = "Category"
        Me.rdbCate.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(587, 150)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(153, 22)
        Me.txtName.TabIndex = 20
        '
        'cbCate1
        '
        Me.cbCate1.FormattingEnabled = True
        Me.cbCate1.Items.AddRange(New Object() {"Cargo Pants", "Hoodie", "Sock", "Sweatshirt", "Jeans", "Sneakers", "Tshirt", "Cap"})
        Me.cbCate1.Location = New System.Drawing.Point(587, 178)
        Me.cbCate1.Name = "cbCate1"
        Me.cbCate1.Size = New System.Drawing.Size(153, 24)
        Me.cbCate1.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bodoni MT Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(790, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 27)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "BORN 2002"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(495, 216)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 29)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 291)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(943, 160)
        Me.DataGridView1.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LabTask4.My.Resources.Resources.Undefeated
        Me.PictureBox1.Location = New System.Drawing.Point(765, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'FindRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 463)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbCate1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.rdbCate)
        Me.Controls.Add(Me.rdbName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtLoc)
        Me.Controls.Add(Me.txtQuan)
        Me.Controls.Add(Me.cbCate)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FindRecord"
        Me.Text = "Find Record"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblID As TextBox
    Friend WithEvents txtItem As TextBox
    Friend WithEvents cbCate As ComboBox
    Friend WithEvents txtQuan As TextBox
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents rdbName As RadioButton
    Friend WithEvents rdbCate As RadioButton
    Friend WithEvents txtName As TextBox
    Friend WithEvents cbCate1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
