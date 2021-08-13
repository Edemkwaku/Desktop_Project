<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogOut = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnGym = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnDashPower = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeveloper = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashBoardSale = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashBoardProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashBoardCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCustomerCount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProductCount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gymCount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.customerPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.productPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.attendantPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.txtTime = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.customerPanel.SuspendLayout()
        Me.productPanel.SuspendLayout()
        Me.attendantPanel.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.Guna2ShadowPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Guna2Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Navy
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1363, 57)
        Me.Panel1.TabIndex = 0
        '
        'btnLogOut
        '
        Me.btnLogOut.AnimationHoverSpeed = 0.07!
        Me.btnLogOut.AnimationSpeed = 0.03!
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogOut.BorderColor = System.Drawing.Color.Black
        Me.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogOut.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogOut.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Image = Nothing
        Me.btnLogOut.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogOut.Location = New System.Drawing.Point(1143, 12)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogOut.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogOut.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogOut.OnHoverImage = Nothing
        Me.btnLogOut.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogOut.Radius = 5
        Me.btnLogOut.Size = New System.Drawing.Size(112, 33)
        Me.btnLogOut.TabIndex = 73
        Me.btnLogOut.Text = "LOGOUT"
        Me.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1309, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Close"
        Me.Label3.Visible = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.Navy
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.BorderColor = System.Drawing.Color.Navy
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.Navy
        Me.btnClose.HoverState.ForeColor = System.Drawing.Color.Red
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(1303, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(47, 27)
        Me.btnClose.TabIndex = 71
        Me.btnClose.Text = "X"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderColor = System.Drawing.Color.Navy
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Navy
        Me.Guna2Button2.Font = New System.Drawing.Font("Webdings", 30.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.Navy
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.Navy
        Me.Guna2Button2.HoverState.ForeColor = System.Drawing.Color.Red
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(1261, -9)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.PressedColor = System.Drawing.Color.Empty
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(58, 46)
        Me.Guna2Button2.TabIndex = 70
        Me.Guna2Button2.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 20.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Label1.Location = New System.Drawing.Point(440, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sale Management System"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Magenta
        Me.Panel4.Location = New System.Drawing.Point(711, 68)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(22, 324)
        Me.Panel4.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 725)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1363, 35)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 8.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Orchid
        Me.Label2.Location = New System.Drawing.Point(26, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Copyright© Edem Kwaku Avorley, 2021"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 668)
        Me.Panel3.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Navy
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1348, 57)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(15, 668)
        Me.Panel5.TabIndex = 5
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.Panel1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Navy
        Me.Guna2Panel2.BorderThickness = 2
        Me.Guna2Panel2.Controls.Add(Me.btnGym)
        Me.Guna2Panel2.Controls.Add(Me.Label7)
        Me.Guna2Panel2.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2Panel2.Controls.Add(Me.btnDashPower)
        Me.Guna2Panel2.Controls.Add(Me.btnDeveloper)
        Me.Guna2Panel2.Controls.Add(Me.btnDashBoardSale)
        Me.Guna2Panel2.Controls.Add(Me.btnDashBoardProduct)
        Me.Guna2Panel2.Controls.Add(Me.btnDashBoardCustomer)
        Me.Guna2Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Panel2.Location = New System.Drawing.Point(9, 57)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(189, 676)
        Me.Guna2Panel2.TabIndex = 8
        '
        'btnGym
        '
        Me.btnGym.CheckedState.Parent = Me.btnGym
        Me.btnGym.CustomImages.Parent = Me.btnGym
        Me.btnGym.FillColor = System.Drawing.Color.Navy
        Me.btnGym.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGym.ForeColor = System.Drawing.Color.DarkOrchid
        Me.btnGym.HoverState.BorderColor = System.Drawing.Color.Navy
        Me.btnGym.HoverState.FillColor = System.Drawing.Color.DarkBlue
        Me.btnGym.HoverState.Parent = Me.btnGym
        Me.btnGym.Location = New System.Drawing.Point(0, 373)
        Me.btnGym.Name = "btnGym"
        Me.btnGym.ShadowDecoration.BorderRadius = 2
        Me.btnGym.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.btnGym.ShadowDecoration.Enabled = True
        Me.btnGym.ShadowDecoration.Parent = Me.btnGym
        Me.btnGym.Size = New System.Drawing.Size(189, 107)
        Me.btnGym.TabIndex = 16
        Me.btnGym.Text = "Gym"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Arial", 20.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.BlueViolet
        Me.Label7.Location = New System.Drawing.Point(10, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 33)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Dash Board"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Navy
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(60, 66)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(65, 65)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 1
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'btnDashPower
        '
        Me.btnDashPower.BorderColor = System.Drawing.Color.Navy
        Me.btnDashPower.BorderThickness = 2
        Me.btnDashPower.CheckedState.Parent = Me.btnDashPower
        Me.btnDashPower.CustomImages.Parent = Me.btnDashPower
        Me.btnDashPower.FillColor = System.Drawing.Color.Navy
        Me.btnDashPower.Font = New System.Drawing.Font("Segoe UI Emoji", 18.25!, System.Drawing.FontStyle.Bold)
        Me.btnDashPower.ForeColor = System.Drawing.Color.DarkOrchid
        Me.btnDashPower.HoverState.BorderColor = System.Drawing.Color.Navy
        Me.btnDashPower.HoverState.FillColor = System.Drawing.Color.DarkBlue
        Me.btnDashPower.HoverState.Parent = Me.btnDashPower
        Me.btnDashPower.Location = New System.Drawing.Point(0, 602)
        Me.btnDashPower.Name = "btnDashPower"
        Me.btnDashPower.PressedColor = System.Drawing.Color.Navy
        Me.btnDashPower.ShadowDecoration.BorderRadius = 2
        Me.btnDashPower.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.btnDashPower.ShadowDecoration.Enabled = True
        Me.btnDashPower.ShadowDecoration.Parent = Me.btnDashPower
        Me.btnDashPower.Size = New System.Drawing.Size(185, 63)
        Me.btnDashPower.TabIndex = 0
        Me.btnDashPower.Text = "Exit"
        '
        'btnDeveloper
        '
        Me.btnDeveloper.BorderColor = System.Drawing.Color.Navy
        Me.btnDeveloper.BorderThickness = 2
        Me.btnDeveloper.CheckedState.Parent = Me.btnDeveloper
        Me.btnDeveloper.CustomImages.Parent = Me.btnDeveloper
        Me.btnDeveloper.FillColor = System.Drawing.Color.Navy
        Me.btnDeveloper.Font = New System.Drawing.Font("Segoe UI Emoji", 18.25!, System.Drawing.FontStyle.Bold)
        Me.btnDeveloper.ForeColor = System.Drawing.Color.DarkOrchid
        Me.btnDeveloper.HoverState.BorderColor = System.Drawing.Color.Navy
        Me.btnDeveloper.HoverState.FillColor = System.Drawing.Color.DarkBlue
        Me.btnDeveloper.HoverState.Parent = Me.btnDeveloper
        Me.btnDeveloper.Location = New System.Drawing.Point(0, 503)
        Me.btnDeveloper.Name = "btnDeveloper"
        Me.btnDeveloper.PressedColor = System.Drawing.Color.Navy
        Me.btnDeveloper.ShadowDecoration.BorderRadius = 2
        Me.btnDeveloper.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.btnDeveloper.ShadowDecoration.Enabled = True
        Me.btnDeveloper.ShadowDecoration.Parent = Me.btnDeveloper
        Me.btnDeveloper.Size = New System.Drawing.Size(189, 64)
        Me.btnDeveloper.TabIndex = 0
        Me.btnDeveloper.Text = "Developer"
        '
        'btnDashBoardSale
        '
        Me.btnDashBoardSale.BorderColor = System.Drawing.Color.Navy
        Me.btnDashBoardSale.BorderThickness = 2
        Me.btnDashBoardSale.CheckedState.Parent = Me.btnDashBoardSale
        Me.btnDashBoardSale.CustomImages.Parent = Me.btnDashBoardSale
        Me.btnDashBoardSale.FillColor = System.Drawing.Color.Navy
        Me.btnDashBoardSale.Font = New System.Drawing.Font("Segoe UI Emoji", 18.25!, System.Drawing.FontStyle.Bold)
        Me.btnDashBoardSale.ForeColor = System.Drawing.Color.DarkOrchid
        Me.btnDashBoardSale.HoverState.BorderColor = System.Drawing.Color.Navy
        Me.btnDashBoardSale.HoverState.FillColor = System.Drawing.Color.DarkBlue
        Me.btnDashBoardSale.HoverState.Parent = Me.btnDashBoardSale
        Me.btnDashBoardSale.Location = New System.Drawing.Point(2, 290)
        Me.btnDashBoardSale.Name = "btnDashBoardSale"
        Me.btnDashBoardSale.PressedColor = System.Drawing.Color.Navy
        Me.btnDashBoardSale.ShadowDecoration.BorderRadius = 2
        Me.btnDashBoardSale.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.btnDashBoardSale.ShadowDecoration.Enabled = True
        Me.btnDashBoardSale.ShadowDecoration.Parent = Me.btnDashBoardSale
        Me.btnDashBoardSale.Size = New System.Drawing.Size(187, 65)
        Me.btnDashBoardSale.TabIndex = 0
        Me.btnDashBoardSale.Text = "Sale"
        '
        'btnDashBoardProduct
        '
        Me.btnDashBoardProduct.BorderColor = System.Drawing.Color.Navy
        Me.btnDashBoardProduct.BorderThickness = 2
        Me.btnDashBoardProduct.CheckedState.Parent = Me.btnDashBoardProduct
        Me.btnDashBoardProduct.CustomImages.Parent = Me.btnDashBoardProduct
        Me.btnDashBoardProduct.FillColor = System.Drawing.Color.Navy
        Me.btnDashBoardProduct.Font = New System.Drawing.Font("Segoe UI Emoji", 18.25!, System.Drawing.FontStyle.Bold)
        Me.btnDashBoardProduct.ForeColor = System.Drawing.Color.DarkOrchid
        Me.btnDashBoardProduct.HoverState.BorderColor = System.Drawing.Color.Navy
        Me.btnDashBoardProduct.HoverState.FillColor = System.Drawing.Color.DarkBlue
        Me.btnDashBoardProduct.HoverState.Parent = Me.btnDashBoardProduct
        Me.btnDashBoardProduct.Location = New System.Drawing.Point(0, 213)
        Me.btnDashBoardProduct.Name = "btnDashBoardProduct"
        Me.btnDashBoardProduct.PressedColor = System.Drawing.Color.Navy
        Me.btnDashBoardProduct.ShadowDecoration.BorderRadius = 2
        Me.btnDashBoardProduct.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.btnDashBoardProduct.ShadowDecoration.Enabled = True
        Me.btnDashBoardProduct.ShadowDecoration.Parent = Me.btnDashBoardProduct
        Me.btnDashBoardProduct.Size = New System.Drawing.Size(189, 61)
        Me.btnDashBoardProduct.TabIndex = 0
        Me.btnDashBoardProduct.Text = "Product"
        '
        'btnDashBoardCustomer
        '
        Me.btnDashBoardCustomer.BorderColor = System.Drawing.Color.Navy
        Me.btnDashBoardCustomer.BorderThickness = 2
        Me.btnDashBoardCustomer.CheckedState.Parent = Me.btnDashBoardCustomer
        Me.btnDashBoardCustomer.CustomImages.Parent = Me.btnDashBoardCustomer
        Me.btnDashBoardCustomer.FillColor = System.Drawing.Color.Navy
        Me.btnDashBoardCustomer.Font = New System.Drawing.Font("Segoe UI Emoji", 18.25!, System.Drawing.FontStyle.Bold)
        Me.btnDashBoardCustomer.ForeColor = System.Drawing.Color.DarkOrchid
        Me.btnDashBoardCustomer.HoverState.BorderColor = System.Drawing.Color.Navy
        Me.btnDashBoardCustomer.HoverState.FillColor = System.Drawing.Color.DarkBlue
        Me.btnDashBoardCustomer.HoverState.Parent = Me.btnDashBoardCustomer
        Me.btnDashBoardCustomer.Location = New System.Drawing.Point(0, 139)
        Me.btnDashBoardCustomer.Name = "btnDashBoardCustomer"
        Me.btnDashBoardCustomer.PressedColor = System.Drawing.Color.Navy
        Me.btnDashBoardCustomer.ShadowDecoration.BorderRadius = 2
        Me.btnDashBoardCustomer.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.btnDashBoardCustomer.ShadowDecoration.Enabled = True
        Me.btnDashBoardCustomer.ShadowDecoration.Parent = Me.btnDashBoardCustomer
        Me.btnDashBoardCustomer.Size = New System.Drawing.Size(189, 59)
        Me.btnDashBoardCustomer.TabIndex = 0
        Me.btnDashBoardCustomer.Text = "Customer"
        '
        'txtCustomerCount
        '
        Me.txtCustomerCount.AutoSize = True
        Me.txtCustomerCount.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerCount.ForeColor = System.Drawing.Color.DarkOrchid
        Me.txtCustomerCount.Location = New System.Drawing.Point(92, 55)
        Me.txtCustomerCount.Name = "txtCustomerCount"
        Me.txtCustomerCount.Size = New System.Drawing.Size(136, 50)
        Me.txtCustomerCount.TabIndex = 10
        Me.txtCustomerCount.Text = "Label4"
        Me.txtCustomerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(47, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 30)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CUSTOMER"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProductCount
        '
        Me.txtProductCount.AutoSize = True
        Me.txtProductCount.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductCount.ForeColor = System.Drawing.Color.DarkOrchid
        Me.txtProductCount.Location = New System.Drawing.Point(99, 54)
        Me.txtProductCount.Name = "txtProductCount"
        Me.txtProductCount.Size = New System.Drawing.Size(136, 50)
        Me.txtProductCount.TabIndex = 10
        Me.txtProductCount.Text = "Label4"
        Me.txtProductCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(59, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 30)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "PRODUCT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gymCount
        '
        Me.gymCount.AutoSize = True
        Me.gymCount.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gymCount.ForeColor = System.Drawing.Color.DarkOrchid
        Me.gymCount.Location = New System.Drawing.Point(87, 54)
        Me.gymCount.Name = "gymCount"
        Me.gymCount.Size = New System.Drawing.Size(136, 50)
        Me.gymCount.TabIndex = 10
        Me.gymCount.Text = "Label4"
        Me.gymCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(19, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 30)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "GYM ATTENDANTS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'customerPanel
        '
        Me.customerPanel.BackColor = System.Drawing.Color.Transparent
        Me.customerPanel.Controls.Add(Me.Label5)
        Me.customerPanel.Controls.Add(Me.txtCustomerCount)
        Me.customerPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customerPanel.FillColor = System.Drawing.Color.White
        Me.customerPanel.Location = New System.Drawing.Point(296, 207)
        Me.customerPanel.Name = "customerPanel"
        Me.customerPanel.Radius = 5
        Me.customerPanel.ShadowColor = System.Drawing.Color.Black
        Me.customerPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.customerPanel.Size = New System.Drawing.Size(238, 131)
        Me.customerPanel.TabIndex = 12
        '
        'productPanel
        '
        Me.productPanel.BackColor = System.Drawing.Color.Transparent
        Me.productPanel.Controls.Add(Me.Label6)
        Me.productPanel.Controls.Add(Me.txtProductCount)
        Me.productPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.productPanel.FillColor = System.Drawing.Color.White
        Me.productPanel.Location = New System.Drawing.Point(645, 207)
        Me.productPanel.Name = "productPanel"
        Me.productPanel.Radius = 5
        Me.productPanel.ShadowColor = System.Drawing.Color.Black
        Me.productPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.productPanel.Size = New System.Drawing.Size(238, 131)
        Me.productPanel.TabIndex = 13
        '
        'attendantPanel
        '
        Me.attendantPanel.BackColor = System.Drawing.Color.Transparent
        Me.attendantPanel.Controls.Add(Me.Label9)
        Me.attendantPanel.Controls.Add(Me.gymCount)
        Me.attendantPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.attendantPanel.FillColor = System.Drawing.Color.White
        Me.attendantPanel.Location = New System.Drawing.Point(990, 207)
        Me.attendantPanel.Name = "attendantPanel"
        Me.attendantPanel.Radius = 5
        Me.attendantPanel.ShadowColor = System.Drawing.Color.Black
        Me.attendantPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.attendantPanel.Size = New System.Drawing.Size(238, 131)
        Me.attendantPanel.TabIndex = 14
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(22, 13)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(102, 37)
        Me.txtDate.TabIndex = 15
        Me.txtDate.Text = "Label4"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtDate)
        Me.Guna2ShadowPanel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.ForeColor = System.Drawing.Color.Navy
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(1135, 63)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowDepth = 50
        Me.Guna2ShadowPanel1.ShadowShift = 3
        Me.Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(200, 63)
        Me.Guna2ShadowPanel1.TabIndex = 16
        '
        'txtTime
        '
        Me.txtTime.AutoSize = True
        Me.txtTime.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(22, 13)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(102, 37)
        Me.txtTime.TabIndex = 15
        Me.txtTime.Text = "Label4"
        '
        'Guna2ShadowPanel2
        '
        Me.Guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel2.Controls.Add(Me.txtTime)
        Me.Guna2ShadowPanel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ShadowPanel2.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel2.ForeColor = System.Drawing.Color.Navy
        Me.Guna2ShadowPanel2.Location = New System.Drawing.Point(215, 63)
        Me.Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
        Me.Guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel2.ShadowDepth = 50
        Me.Guna2ShadowPanel2.ShadowShift = 3
        Me.Guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.Guna2ShadowPanel2.Size = New System.Drawing.Size(212, 63)
        Me.Guna2ShadowPanel2.TabIndex = 17
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1363, 760)
        Me.Controls.Add(Me.Guna2ShadowPanel2)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.attendantPanel)
        Me.Controls.Add(Me.productPanel)
        Me.Controls.Add(Me.customerPanel)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.DarkOrchid
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.customerPanel.ResumeLayout(False)
        Me.customerPanel.PerformLayout()
        Me.productPanel.ResumeLayout(False)
        Me.productPanel.PerformLayout()
        Me.attendantPanel.ResumeLayout(False)
        Me.attendantPanel.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.Guna2ShadowPanel2.ResumeLayout(False)
        Me.Guna2ShadowPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnDashPower As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeveloper As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDashBoardSale As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDashBoardProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDashBoardCustomer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGym As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCustomerCount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProductCount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents gymCount As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents customerPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents productPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents attendantPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents txtDate As System.Windows.Forms.Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents txtTime As System.Windows.Forms.Label
    Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnLogOut As Guna.UI.WinForms.GunaButton
End Class
