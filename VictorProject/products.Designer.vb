<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUCTS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRODUCTS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProductCombo = New System.Windows.Forms.ComboBox()
        Me.txtProductName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProductQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSellingPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBuyingPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.productDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.btnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.productDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Thistle
        Me.Label5.Location = New System.Drawing.Point(12, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 26)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ProductQuantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Thistle
        Me.Label4.Location = New System.Drawing.Point(12, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Selling Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Thistle
        Me.Label3.Location = New System.Drawing.Point(12, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Buying Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Thistle
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.Controls.Add(Me.ProductCombo)
        Me.Panel1.Controls.Add(Me.txtProductName)
        Me.Panel1.Controls.Add(Me.txtProductQuantity)
        Me.Panel1.Controls.Add(Me.txtSellingPrice)
        Me.Panel1.Controls.Add(Me.txtBuyingPrice)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(18, 82)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(427, 342)
        Me.Panel1.TabIndex = 1
        '
        'ProductCombo
        '
        Me.ProductCombo.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ProductCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProductCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.ProductCombo.ForeColor = System.Drawing.Color.Thistle
        Me.ProductCombo.FormattingEnabled = True
        Me.ProductCombo.Location = New System.Drawing.Point(17, 286)
        Me.ProductCombo.Name = "ProductCombo"
        Me.ProductCombo.Size = New System.Drawing.Size(148, 28)
        Me.ProductCombo.TabIndex = 4
        '
        'txtProductName
        '
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductName.DefaultText = ""
        Me.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductName.DisabledState.Parent = Me.txtProductName
        Me.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductName.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.txtProductName.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProductName.FocusedState.Parent = Me.txtProductName
        Me.txtProductName.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.HoverState.BorderColor = System.Drawing.Color.Lime
        Me.txtProductName.HoverState.Parent = Me.txtProductName
        Me.txtProductName.HoverState.PlaceholderForeColor = System.Drawing.Color.Blue
        Me.txtProductName.Location = New System.Drawing.Point(184, 37)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductName.PlaceholderText = "Enter Product name"
        Me.txtProductName.SelectedText = ""
        Me.txtProductName.ShadowDecoration.Parent = Me.txtProductName
        Me.txtProductName.Size = New System.Drawing.Size(207, 40)
        Me.txtProductName.TabIndex = 1
        '
        'txtProductQuantity
        '
        Me.txtProductQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductQuantity.DefaultText = ""
        Me.txtProductQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductQuantity.DisabledState.Parent = Me.txtProductQuantity
        Me.txtProductQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductQuantity.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.txtProductQuantity.FocusedState.Parent = Me.txtProductQuantity
        Me.txtProductQuantity.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProductQuantity.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductQuantity.HoverState.BorderColor = System.Drawing.Color.Lime
        Me.txtProductQuantity.HoverState.Parent = Me.txtProductQuantity
        Me.txtProductQuantity.HoverState.PlaceholderForeColor = System.Drawing.Color.Blue
        Me.txtProductQuantity.Location = New System.Drawing.Point(184, 233)
        Me.txtProductQuantity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProductQuantity.Name = "txtProductQuantity"
        Me.txtProductQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductQuantity.PlaceholderText = "Enter Quantity"
        Me.txtProductQuantity.SelectedText = ""
        Me.txtProductQuantity.ShadowDecoration.Parent = Me.txtProductQuantity
        Me.txtProductQuantity.Size = New System.Drawing.Size(207, 40)
        Me.txtProductQuantity.TabIndex = 2
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSellingPrice.DefaultText = ""
        Me.txtSellingPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSellingPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSellingPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSellingPrice.DisabledState.Parent = Me.txtSellingPrice
        Me.txtSellingPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSellingPrice.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.txtSellingPrice.FocusedState.Parent = Me.txtSellingPrice
        Me.txtSellingPrice.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSellingPrice.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSellingPrice.HoverState.BorderColor = System.Drawing.Color.Lime
        Me.txtSellingPrice.HoverState.Parent = Me.txtSellingPrice
        Me.txtSellingPrice.HoverState.PlaceholderForeColor = System.Drawing.Color.Blue
        Me.txtSellingPrice.Location = New System.Drawing.Point(184, 169)
        Me.txtSellingPrice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSellingPrice.PlaceholderText = "Enter Selling price"
        Me.txtSellingPrice.SelectedText = ""
        Me.txtSellingPrice.ShadowDecoration.Parent = Me.txtSellingPrice
        Me.txtSellingPrice.Size = New System.Drawing.Size(207, 40)
        Me.txtSellingPrice.TabIndex = 2
        '
        'txtBuyingPrice
        '
        Me.txtBuyingPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuyingPrice.DefaultText = ""
        Me.txtBuyingPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBuyingPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBuyingPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuyingPrice.DisabledState.Parent = Me.txtBuyingPrice
        Me.txtBuyingPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuyingPrice.FocusedState.BorderColor = System.Drawing.Color.Red
        Me.txtBuyingPrice.FocusedState.Parent = Me.txtBuyingPrice
        Me.txtBuyingPrice.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuyingPrice.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuyingPrice.HoverState.BorderColor = System.Drawing.Color.Lime
        Me.txtBuyingPrice.HoverState.Parent = Me.txtBuyingPrice
        Me.txtBuyingPrice.HoverState.PlaceholderForeColor = System.Drawing.Color.Blue
        Me.txtBuyingPrice.Location = New System.Drawing.Point(184, 103)
        Me.txtBuyingPrice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBuyingPrice.Name = "txtBuyingPrice"
        Me.txtBuyingPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuyingPrice.PlaceholderText = "Enter Buying price"
        Me.txtBuyingPrice.SelectedText = ""
        Me.txtBuyingPrice.ShadowDecoration.Parent = Me.txtBuyingPrice
        Me.txtBuyingPrice.Size = New System.Drawing.Size(207, 40)
        Me.txtBuyingPrice.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(892, 72)
        Me.Panel2.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(839, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Close"
        Me.Label6.Visible = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 1)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(91, 69)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.btnClose.Font = New System.Drawing.Font("Webdings", 20.25!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.btnClose.HoverState.ForeColor = System.Drawing.Color.Red
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(823, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(63, 45)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Arial", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Thistle
        Me.Label2.Location = New System.Drawing.Point(334, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 40)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PRODUCTS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 539)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(892, 21)
        Me.Panel3.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Thistle
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(18, 430)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(122, 45)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        '
        'btnUpdate
        '
        Me.btnUpdate.CheckedState.Parent = Me.btnUpdate
        Me.btnUpdate.CustomImages.Parent = Me.btnUpdate
        Me.btnUpdate.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Thistle
        Me.btnUpdate.HoverState.Parent = Me.btnUpdate
        Me.btnUpdate.Location = New System.Drawing.Point(163, 430)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(122, 45)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        '
        'btnDelete
        '
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Thistle
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(323, 430)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(122, 45)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        '
        'btnBack
        '
        Me.btnBack.CheckedState.Parent = Me.btnBack
        Me.btnBack.CustomImages.Parent = Me.btnBack
        Me.btnBack.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Thistle
        Me.btnBack.HoverState.Parent = Me.btnBack
        Me.btnBack.Location = New System.Drawing.Point(277, 486)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(122, 45)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel4.Controls.Add(Me.productDataGrid)
        Me.Panel4.Location = New System.Drawing.Point(463, 82)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(403, 429)
        Me.Panel4.TabIndex = 9
        '
        'productDataGrid
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.productDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.productDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.productDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.productDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.productDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.productDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.productDataGrid.ColumnHeadersHeight = 25
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.productDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.productDataGrid.EnableHeadersVisualStyles = False
        Me.productDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productDataGrid.Location = New System.Drawing.Point(17, 22)
        Me.productDataGrid.Name = "productDataGrid"
        Me.productDataGrid.RowHeadersVisible = False
        Me.productDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.productDataGrid.ShowEditingIcon = False
        Me.productDataGrid.Size = New System.Drawing.Size(364, 391)
        Me.productDataGrid.TabIndex = 0
        Me.productDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.productDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.productDataGrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.productDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.productDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.productDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.productDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.productDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.productDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.productDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.productDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.productDataGrid.ThemeStyle.HeaderStyle.Height = 25
        Me.productDataGrid.ThemeStyle.ReadOnly = False
        Me.productDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.productDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.productDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.productDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.productDataGrid.ThemeStyle.RowsStyle.Height = 22
        Me.productDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 72)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(11, 467)
        Me.Panel5.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(881, 72)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(11, 467)
        Me.Panel6.TabIndex = 8
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.Label1
        '
        'btnReset
        '
        Me.btnReset.CheckedState.Parent = Me.btnReset
        Me.btnReset.CustomImages.Parent = Me.btnReset
        Me.btnReset.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Thistle
        Me.btnReset.HoverState.Parent = Me.btnReset
        Me.btnReset.Location = New System.Drawing.Point(106, 486)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.ShadowDecoration.Parent = Me.btnReset
        Me.btnReset.Size = New System.Drawing.Size(122, 45)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        '
        'PRODUCTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 560)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PRODUCTS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PRODUCTS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.productDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents ProductCombo As ComboBox
    Friend WithEvents productDataGrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtProductName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProductQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSellingPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBuyingPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label6 As Label
End Class
