<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDeveloper = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.myProgressBar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.lbMessage = New System.Windows.Forms.Label()
        Me.red1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.yellow1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.green4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.green2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.green6 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.red5 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.green1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.green5 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.yellow4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.yellow2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.green3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.yellow6 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.red6 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.red2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.red4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.red3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.yellow3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.yellow5 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(121, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sale Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtDeveloper)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 314)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(573, 49)
        Me.Panel1.TabIndex = 1
        '
        'txtDeveloper
        '
        Me.txtDeveloper.AutoSize = True
        Me.txtDeveloper.Font = New System.Drawing.Font("Segoe UI Emoji", 10.0!)
        Me.txtDeveloper.ForeColor = System.Drawing.Color.White
        Me.txtDeveloper.Location = New System.Drawing.Point(122, 12)
        Me.txtDeveloper.Name = "txtDeveloper"
        Me.txtDeveloper.Size = New System.Drawing.Size(260, 19)
        Me.txtDeveloper.TabIndex = 0
        Me.txtDeveloper.Text = "Copyright© Edem Kwaku Avorley, 2021"
        Me.txtDeveloper.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
        '
        'myProgressBar
        '
        Me.myProgressBar.AnimationSpeed = 0.2!
        Me.myProgressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.myProgressBar.FillThickness = 35
        Me.myProgressBar.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myProgressBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.myProgressBar.Location = New System.Drawing.Point(172, 60)
        Me.myProgressBar.Name = "myProgressBar"
        Me.myProgressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.myProgressBar.ProgressColor2 = System.Drawing.Color.Yellow
        Me.myProgressBar.ProgressThickness = 35
        Me.myProgressBar.ShadowDecoration.BorderRadius = 8
        Me.myProgressBar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.myProgressBar.ShadowDecoration.Enabled = True
        Me.myProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.myProgressBar.ShadowDecoration.Parent = Me.myProgressBar
        Me.myProgressBar.ShowPercentage = True
        Me.myProgressBar.Size = New System.Drawing.Size(210, 209)
        Me.myProgressBar.TabIndex = 2
        '
        'lbMessage
        '
        Me.lbMessage.AutoSize = True
        Me.lbMessage.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMessage.ForeColor = System.Drawing.Color.White
        Me.lbMessage.Location = New System.Drawing.Point(35, 269)
        Me.lbMessage.Name = "lbMessage"
        Me.lbMessage.Size = New System.Drawing.Size(0, 30)
        Me.lbMessage.TabIndex = 0
        Me.lbMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'red1
        '
        Me.red1.BorderRadius = 20
        Me.red1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.red1.DefaultText = ""
        Me.red1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.red1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.red1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.red1.DisabledState.Parent = Me.red1
        Me.red1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.red1.FillColor = System.Drawing.Color.Red
        Me.red1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.red1.FocusedState.Parent = Me.red1
        Me.red1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.red1.HoverState.Parent = Me.red1
        Me.red1.Location = New System.Drawing.Point(409, 48)
        Me.red1.Name = "red1"
        Me.red1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.red1.PlaceholderText = ""
        Me.red1.ReadOnly = True
        Me.red1.SelectedText = ""
        Me.red1.ShadowDecoration.Parent = Me.red1
        Me.red1.Size = New System.Drawing.Size(29, 30)
        Me.red1.TabIndex = 3
        Me.red1.Visible = False
        '
        'yellow1
        '
        Me.yellow1.BorderRadius = 20
        Me.yellow1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.yellow1.DefaultText = ""
        Me.yellow1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.yellow1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.yellow1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yellow1.DisabledState.Parent = Me.yellow1
        Me.yellow1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yellow1.FillColor = System.Drawing.Color.Yellow
        Me.yellow1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yellow1.FocusedState.Parent = Me.yellow1
        Me.yellow1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yellow1.HoverState.Parent = Me.yellow1
        Me.yellow1.Location = New System.Drawing.Point(521, 48)
        Me.yellow1.Name = "yellow1"
        Me.yellow1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.yellow1.PlaceholderText = ""
        Me.yellow1.ReadOnly = True
        Me.yellow1.SelectedText = ""
        Me.yellow1.ShadowDecoration.Parent = Me.yellow1
        Me.yellow1.Size = New System.Drawing.Size(29, 30)
        Me.yellow1.TabIndex = 3
        Me.yellow1.Visible = False
        '
        'green4
        '
        Me.green4.BorderRadius = 20
        Me.green4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.green4.DefaultText = ""
        Me.green4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.green4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.green4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.green4.DisabledState.Parent = Me.green4
        Me.green4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.green4.FillColor = System.Drawing.Color.Lime
        Me.green4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.green4.FocusedState.Parent = Me.green4
        Me.green4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.green4.HoverState.Parent = Me.green4
        Me.green4.Location = New System.Drawing.Point(374, 48)
        Me.green4.Name = "green4"
        Me.green4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.green4.PlaceholderText = ""
        Me.green4.ReadOnly = True
        Me.green4.SelectedText = ""
        Me.green4.ShadowDecoration.Parent = Me.green4
        Me.green4.Size = New System.Drawing.Size(29, 30)
        Me.green4.TabIndex = 3
        Me.green4.Visible = False
        '
        'green2
        '
        Me.green2.BorderRadius = 20
        Me.green2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.green2.DefaultText = ""
        Me.green2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.green2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.green2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.green2.DisabledState.Parent = Me.green2
        Me.green2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.green2.FillColor = System.Drawing.Color.Lime
        Me.green2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.green2.FocusedState.Parent = Me.green2
        Me.green2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.green2.HoverState.Parent = Me.green2
        Me.green2.Location = New System.Drawing.Point(486, 140)
        Me.green2.Name = "green2"
        Me.green2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.green2.PlaceholderText = ""
        Me.green2.ReadOnly = True
        Me.green2.SelectedText = ""
        Me.green2.ShadowDecoration.Parent = Me.green2
        Me.green2.Size = New System.Drawing.Size(29, 30)
        Me.green2.TabIndex = 3
        Me.green2.Visible = False
        '
        'green6
        '
        Me.green6.BorderRadius = 20
        Me.green6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.green6.DefaultText = ""
        Me.green6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.green6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.green6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.green6.DisabledState.Parent = Me.green6
        Me.green6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.green6.FillColor = System.Drawing.Color.Lime
        Me.green6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.green6.FocusedState.Parent = Me.green6
        Me.green6.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.green6.HoverState.Parent = Me.green6
        Me.green6.Location = New System.Drawing.Point(374, 269)
        Me.green6.Name = "green6"
        Me.green6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.green6.PlaceholderText = ""
        Me.green6.ReadOnly = True
        Me.green6.SelectedText = ""
        Me.green6.ShadowDecoration.Parent = Me.green6
        Me.green6.Size = New System.Drawing.Size(29, 30)
        Me.green6.TabIndex = 3
        Me.green6.Visible = False
        '
        'red5
        '
        Me.red5.BorderRadius = 20
        Me.red5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.red5.DefaultText = ""
        Me.red5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.red5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.red5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.red5.DisabledState.Parent = Me.red5
        Me.red5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.red5.FillColor = System.Drawing.Color.Red
        Me.red5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.red5.FocusedState.Parent = Me.red5
        Me.red5.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.red5.HoverState.Parent = Me.red5
        Me.red5.Location = New System.Drawing.Point(409, 269)
        Me.red5.Name = "red5"
        Me.red5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.red5.PlaceholderText = ""
        Me.red5.ReadOnly = True
        Me.red5.SelectedText = ""
        Me.red5.ShadowDecoration.Parent = Me.red5
        Me.red5.Size = New System.Drawing.Size(29, 30)
        Me.red5.TabIndex = 3
        Me.red5.Visible = False
        '
        'green1
        '
        Me.green1.BorderRadius = 20
        Me.green1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.green1.DefaultText = ""
        Me.green1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.green1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.green1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.green1.DisabledState.Parent = Me.green1
        Me.green1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.green1.FillColor = System.Drawing.Color.Lime
        Me.green1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.green1.FocusedState.Parent = Me.green1
        Me.green1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.green1.HoverState.Parent = Me.green1
        Me.green1.Location = New System.Drawing.Point(112, 48)
        Me.green1.Name = "green1"
        Me.green1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.green1.PlaceholderText = ""
        Me.green1.ReadOnly = True
        Me.green1.SelectedText = ""
        Me.green1.ShadowDecoration.Parent = Me.green1
        Me.green1.Size = New System.Drawing.Size(29, 30)
        Me.green1.TabIndex = 3
        Me.green1.Visible = False
        '
        'green5
        '
        Me.green5.BorderRadius = 20
        Me.green5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.green5.DefaultText = ""
        Me.green5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.green5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.green5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.green5.DisabledState.Parent = Me.green5
        Me.green5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.green5.FillColor = System.Drawing.Color.Lime
        Me.green5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.green5.FocusedState.Parent = Me.green5
        Me.green5.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.green5.HoverState.Parent = Me.green5
        Me.green5.Location = New System.Drawing.Point(102, 235)
        Me.green5.Name = "green5"
        Me.green5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.green5.PlaceholderText = ""
        Me.green5.ReadOnly = True
        Me.green5.SelectedText = ""
        Me.green5.ShadowDecoration.Parent = Me.green5
        Me.green5.Size = New System.Drawing.Size(29, 30)
        Me.green5.TabIndex = 3
        Me.green5.Visible = False
        '
        'yellow4
        '
        Me.yellow4.BorderRadius = 20
        Me.yellow4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.yellow4.DefaultText = ""
        Me.yellow4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.yellow4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.yellow4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yellow4.DisabledState.Parent = Me.yellow4
        Me.yellow4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yellow4.FillColor = System.Drawing.Color.Yellow
        Me.yellow4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yellow4.FocusedState.Parent = Me.yellow4
        Me.yellow4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yellow4.HoverState.Parent = Me.yellow4
        Me.yellow4.Location = New System.Drawing.Point(21, 228)
        Me.yellow4.Name = "yellow4"
        Me.yellow4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.yellow4.PlaceholderText = ""
        Me.yellow4.ReadOnly = True
        Me.yellow4.SelectedText = ""
        Me.yellow4.ShadowDecoration.Parent = Me.yellow4
        Me.yellow4.Size = New System.Drawing.Size(29, 30)
        Me.yellow4.TabIndex = 3
        Me.yellow4.Visible = False
        '
        'yellow2
        '
        Me.yellow2.BorderRadius = 20
        Me.yellow2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.yellow2.DefaultText = ""
        Me.yellow2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.yellow2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.yellow2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yellow2.DisabledState.Parent = Me.yellow2
        Me.yellow2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yellow2.FillColor = System.Drawing.Color.Yellow
        Me.yellow2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yellow2.FocusedState.Parent = Me.yellow2
        Me.yellow2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yellow2.HoverState.Parent = Me.yellow2
        Me.yellow2.Location = New System.Drawing.Point(112, 126)
        Me.yellow2.Name = "yellow2"
        Me.yellow2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.yellow2.PlaceholderText = ""
        Me.yellow2.ReadOnly = True
        Me.yellow2.SelectedText = ""
        Me.yellow2.ShadowDecoration.Parent = Me.yellow2
        Me.yellow2.Size = New System.Drawing.Size(29, 30)
        Me.yellow2.TabIndex = 3
        Me.yellow2.Visible = False
        '
        'green3
        '
        Me.green3.BorderRadius = 20
        Me.green3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.green3.DefaultText = ""
        Me.green3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.green3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.green3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.green3.DisabledState.Parent = Me.green3
        Me.green3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.green3.FillColor = System.Drawing.Color.Lime
        Me.green3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.green3.FocusedState.Parent = Me.green3
        Me.green3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.green3.HoverState.Parent = Me.green3
        Me.green3.Location = New System.Drawing.Point(46, 127)
        Me.green3.Name = "green3"
        Me.green3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.green3.PlaceholderText = ""
        Me.green3.ReadOnly = True
        Me.green3.SelectedText = ""
        Me.green3.ShadowDecoration.Parent = Me.green3
        Me.green3.Size = New System.Drawing.Size(29, 30)
        Me.green3.TabIndex = 3
        Me.green3.Visible = False
        '
        'yellow6
        '
        Me.yellow6.BorderRadius = 20
        Me.yellow6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.yellow6.DefaultText = ""
        Me.yellow6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.yellow6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.yellow6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yellow6.DisabledState.Parent = Me.yellow6
        Me.yellow6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yellow6.FillColor = System.Drawing.Color.Yellow
        Me.yellow6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yellow6.FocusedState.Parent = Me.yellow6
        Me.yellow6.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yellow6.HoverState.Parent = Me.yellow6
        Me.yellow6.Location = New System.Drawing.Point(12, 48)
        Me.yellow6.Name = "yellow6"
        Me.yellow6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.yellow6.PlaceholderText = ""
        Me.yellow6.ReadOnly = True
        Me.yellow6.SelectedText = ""
        Me.yellow6.ShadowDecoration.Parent = Me.yellow6
        Me.yellow6.Size = New System.Drawing.Size(29, 30)
        Me.yellow6.TabIndex = 3
        Me.yellow6.Visible = False
        '
        'red6
        '
        Me.red6.BorderRadius = 20
        Me.red6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.red6.DefaultText = ""
        Me.red6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.red6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.red6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.red6.DisabledState.Parent = Me.red6
        Me.red6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.red6.FillColor = System.Drawing.Color.Red
        Me.red6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.red6.FocusedState.Parent = Me.red6
        Me.red6.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.red6.HoverState.Parent = Me.red6
        Me.red6.Location = New System.Drawing.Point(149, 48)
        Me.red6.Name = "red6"
        Me.red6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.red6.PlaceholderText = ""
        Me.red6.ReadOnly = True
        Me.red6.SelectedText = ""
        Me.red6.ShadowDecoration.Parent = Me.red6
        Me.red6.Size = New System.Drawing.Size(29, 30)
        Me.red6.TabIndex = 3
        Me.red6.Visible = False
        '
        'red2
        '
        Me.red2.BorderRadius = 20
        Me.red2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.red2.DefaultText = ""
        Me.red2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.red2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.red2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.red2.DisabledState.Parent = Me.red2
        Me.red2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.red2.FillColor = System.Drawing.Color.Red
        Me.red2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.red2.FocusedState.Parent = Me.red2
        Me.red2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.red2.HoverState.Parent = Me.red2
        Me.red2.Location = New System.Drawing.Point(137, 235)
        Me.red2.Name = "red2"
        Me.red2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.red2.PlaceholderText = ""
        Me.red2.ReadOnly = True
        Me.red2.SelectedText = ""
        Me.red2.ShadowDecoration.Parent = Me.red2
        Me.red2.Size = New System.Drawing.Size(29, 30)
        Me.red2.TabIndex = 3
        Me.red2.Visible = False
        '
        'red4
        '
        Me.red4.BorderRadius = 20
        Me.red4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.red4.DefaultText = ""
        Me.red4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.red4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.red4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.red4.DisabledState.Parent = Me.red4
        Me.red4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.red4.FillColor = System.Drawing.Color.Red
        Me.red4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.red4.FocusedState.Parent = Me.red4
        Me.red4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.red4.HoverState.Parent = Me.red4
        Me.red4.Location = New System.Drawing.Point(11, 127)
        Me.red4.Name = "red4"
        Me.red4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.red4.PlaceholderText = ""
        Me.red4.ReadOnly = True
        Me.red4.SelectedText = ""
        Me.red4.ShadowDecoration.Parent = Me.red4
        Me.red4.Size = New System.Drawing.Size(29, 30)
        Me.red4.TabIndex = 3
        Me.red4.Visible = False
        '
        'red3
        '
        Me.red3.BorderRadius = 20
        Me.red3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.red3.DefaultText = ""
        Me.red3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.red3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.red3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.red3.DisabledState.Parent = Me.red3
        Me.red3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.red3.FillColor = System.Drawing.Color.Red
        Me.red3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.red3.FocusedState.Parent = Me.red3
        Me.red3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.red3.HoverState.Parent = Me.red3
        Me.red3.Location = New System.Drawing.Point(521, 140)
        Me.red3.Name = "red3"
        Me.red3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.red3.PlaceholderText = ""
        Me.red3.ReadOnly = True
        Me.red3.SelectedText = ""
        Me.red3.ShadowDecoration.Parent = Me.red3
        Me.red3.Size = New System.Drawing.Size(29, 30)
        Me.red3.TabIndex = 3
        Me.red3.Visible = False
        '
        'yellow3
        '
        Me.yellow3.BorderRadius = 20
        Me.yellow3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.yellow3.DefaultText = ""
        Me.yellow3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.yellow3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.yellow3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yellow3.DisabledState.Parent = Me.yellow3
        Me.yellow3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yellow3.FillColor = System.Drawing.Color.Yellow
        Me.yellow3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yellow3.FocusedState.Parent = Me.yellow3
        Me.yellow3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yellow3.HoverState.Parent = Me.yellow3
        Me.yellow3.Location = New System.Drawing.Point(512, 252)
        Me.yellow3.Name = "yellow3"
        Me.yellow3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.yellow3.PlaceholderText = ""
        Me.yellow3.ReadOnly = True
        Me.yellow3.SelectedText = ""
        Me.yellow3.ShadowDecoration.Parent = Me.yellow3
        Me.yellow3.Size = New System.Drawing.Size(29, 30)
        Me.yellow3.TabIndex = 3
        Me.yellow3.Visible = False
        '
        'yellow5
        '
        Me.yellow5.BorderRadius = 20
        Me.yellow5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.yellow5.DefaultText = ""
        Me.yellow5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.yellow5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.yellow5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yellow5.DisabledState.Parent = Me.yellow5
        Me.yellow5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yellow5.FillColor = System.Drawing.Color.Yellow
        Me.yellow5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yellow5.FocusedState.Parent = Me.yellow5
        Me.yellow5.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yellow5.HoverState.Parent = Me.yellow5
        Me.yellow5.Location = New System.Drawing.Point(409, 140)
        Me.yellow5.Name = "yellow5"
        Me.yellow5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.yellow5.PlaceholderText = ""
        Me.yellow5.ReadOnly = True
        Me.yellow5.SelectedText = ""
        Me.yellow5.ShadowDecoration.Parent = Me.yellow5
        Me.yellow5.Size = New System.Drawing.Size(29, 30)
        Me.yellow5.TabIndex = 3
        Me.yellow5.Visible = False
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrchid
        Me.ClientSize = New System.Drawing.Size(573, 363)
        Me.Controls.Add(Me.green5)
        Me.Controls.Add(Me.red5)
        Me.Controls.Add(Me.green6)
        Me.Controls.Add(Me.yellow3)
        Me.Controls.Add(Me.green2)
        Me.Controls.Add(Me.yellow5)
        Me.Controls.Add(Me.red3)
        Me.Controls.Add(Me.green4)
        Me.Controls.Add(Me.red4)
        Me.Controls.Add(Me.red6)
        Me.Controls.Add(Me.yellow6)
        Me.Controls.Add(Me.red2)
        Me.Controls.Add(Me.green3)
        Me.Controls.Add(Me.yellow2)
        Me.Controls.Add(Me.yellow4)
        Me.Controls.Add(Me.green1)
        Me.Controls.Add(Me.yellow1)
        Me.Controls.Add(Me.red1)
        Me.Controls.Add(Me.myProgressBar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbMessage)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtDeveloper As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents myProgressBar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents lbMessage As Label
    Friend WithEvents red1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents yellow1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents green4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents green2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents green6 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents red5 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents green1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents green5 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents yellow4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents yellow2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents green3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents yellow6 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents red6 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents red2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents red4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents red3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents yellow3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents yellow5 As Guna.UI2.WinForms.Guna2TextBox
End Class
