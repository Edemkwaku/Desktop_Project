<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GymMain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GymMain))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPoint = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.attendantTable = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDoB = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel3 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel4 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ParentPanel = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.attendantTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ParentPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnClose)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Purple
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2GradientPanel1.ShadowDecoration.Enabled = True
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(956, 55)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 24)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Gym Attendants Registration"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(897, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Close"
        Me.Label1.Visible = False
        '
        'btnClose
        '
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.Purple
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.BorderColor = System.Drawing.Color.Purple
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.Purple
        Me.btnClose.HoverState.ForeColor = System.Drawing.Color.Red
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(894, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(47, 45)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.Guna2GradientPanel1
        '
        'txtFirstName
        '
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.Parent = Me.txtFirstName
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.FocusedState.Parent = Me.txtFirstName
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.HoverState.Parent = Me.txtFirstName
        Me.txtFirstName.Location = New System.Drawing.Point(150, 182)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderText = ""
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.ShadowDecoration.Parent = Me.txtFirstName
        Me.txtFirstName.Size = New System.Drawing.Size(259, 36)
        Me.txtFirstName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "First Name"
        '
        'txtPoint
        '
        Me.txtPoint.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPoint.DefaultText = ""
        Me.txtPoint.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPoint.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPoint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPoint.DisabledState.Parent = Me.txtPoint
        Me.txtPoint.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPoint.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPoint.FocusedState.Parent = Me.txtPoint
        Me.txtPoint.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoint.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPoint.HoverState.Parent = Me.txtPoint
        Me.txtPoint.Location = New System.Drawing.Point(150, 239)
        Me.txtPoint.Name = "txtPoint"
        Me.txtPoint.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoint.PlaceholderText = ""
        Me.txtPoint.SelectedText = ""
        Me.txtPoint.ShadowDecoration.Parent = Me.txtPoint
        Me.txtPoint.Size = New System.Drawing.Size(142, 36)
        Me.txtPoint.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Start Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "End Date"
        '
        'attendantTable
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.attendantTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.attendantTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.attendantTable.BackgroundColor = System.Drawing.Color.White
        Me.attendantTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.attendantTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.attendantTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.attendantTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.attendantTable.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.attendantTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.attendantTable.EnableHeadersVisualStyles = False
        Me.attendantTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.attendantTable.Location = New System.Drawing.Point(415, 124)
        Me.attendantTable.Name = "attendantTable"
        Me.attendantTable.RowHeadersVisible = False
        Me.attendantTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.attendantTable.Size = New System.Drawing.Size(521, 345)
        Me.attendantTable.TabIndex = 29
        Me.attendantTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.attendantTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.attendantTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.attendantTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.attendantTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.attendantTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.attendantTable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.attendantTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.attendantTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.attendantTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.attendantTable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.attendantTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.attendantTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.attendantTable.ThemeStyle.HeaderStyle.Height = 30
        Me.attendantTable.ThemeStyle.ReadOnly = False
        Me.attendantTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.attendantTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.attendantTable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.attendantTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.attendantTable.ThemeStyle.RowsStyle.Height = 22
        Me.attendantTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.attendantTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'txtStartDate
        '
        Me.txtStartDate.CheckedState.Parent = Me.txtStartDate
        Me.txtStartDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.txtStartDate.HoverState.Parent = Me.txtStartDate
        Me.txtStartDate.Location = New System.Drawing.Point(150, 337)
        Me.txtStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.ShadowDecoration.Parent = Me.txtStartDate
        Me.txtStartDate.Size = New System.Drawing.Size(259, 36)
        Me.txtStartDate.TabIndex = 4
        Me.txtStartDate.Value = New Date(2021, 7, 13, 12, 49, 18, 571)
        '
        'txtEndDate
        '
        Me.txtEndDate.CheckedState.Parent = Me.txtEndDate
        Me.txtEndDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.txtEndDate.HoverState.Parent = Me.txtEndDate
        Me.txtEndDate.Location = New System.Drawing.Point(150, 398)
        Me.txtEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.ShadowDecoration.Parent = Me.txtEndDate
        Me.txtEndDate.Size = New System.Drawing.Size(259, 36)
        Me.txtEndDate.TabIndex = 5
        Me.txtEndDate.Value = New Date(2021, 7, 13, 12, 49, 18, 571)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Point"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 20)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "DateOfBirth"
        '
        'txtDoB
        '
        Me.txtDoB.CheckedState.Parent = Me.txtDoB
        Me.txtDoB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoB.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.txtDoB.HoverState.Parent = Me.txtDoB
        Me.txtDoB.Location = New System.Drawing.Point(150, 285)
        Me.txtDoB.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txtDoB.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txtDoB.Name = "txtDoB"
        Me.txtDoB.ShadowDecoration.Parent = Me.txtDoB
        Me.txtDoB.Size = New System.Drawing.Size(259, 36)
        Me.txtDoB.TabIndex = 4
        Me.txtDoB.Value = New Date(2021, 7, 13, 12, 49, 18, 571)
        '
        'btnAdd
        '
        Me.btnAdd.BorderRadius = 5
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.FillColor = System.Drawing.Color.Green
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.BorderColor = System.Drawing.Color.Green
        Me.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(74, 473)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(86, 45)
        Me.btnAdd.TabIndex = 35
        Me.btnAdd.Text = "Add"
        '
        'btnUpdate
        '
        Me.btnUpdate.BorderRadius = 5
        Me.btnUpdate.CheckedState.Parent = Me.btnUpdate
        Me.btnUpdate.CustomImages.Parent = Me.btnUpdate
        Me.btnUpdate.FillColor = System.Drawing.Color.Orange
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.BorderColor = System.Drawing.Color.Orange
        Me.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.HoverState.Parent = Me.btnUpdate
        Me.btnUpdate.Location = New System.Drawing.Point(184, 473)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(96, 45)
        Me.btnUpdate.TabIndex = 36
        Me.btnUpdate.Text = "Update"
        '
        'btnDelete
        '
        Me.btnDelete.BorderRadius = 5
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.FillColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.BorderColor = System.Drawing.Color.Red
        Me.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(296, 473)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(96, 45)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "Delete"
        '
        'btnSearch
        '
        Me.btnSearch.BorderRadius = 5
        Me.btnSearch.CheckedState.Parent = Me.btnSearch
        Me.btnSearch.CustomImages.Parent = Me.btnSearch
        Me.btnSearch.FillColor = System.Drawing.Color.Purple
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.HoverState.BorderColor = System.Drawing.Color.Purple
        Me.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.HoverState.Parent = Me.btnSearch
        Me.btnSearch.Location = New System.Drawing.Point(124, 524)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShadowDecoration.Parent = Me.btnSearch
        Me.btnSearch.Size = New System.Drawing.Size(96, 45)
        Me.btnSearch.TabIndex = 36
        Me.btnSearch.Text = "Search"
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.Purple
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.Magenta
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(0, 596)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.Parent = Me.Guna2GradientPanel2
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(956, 14)
        Me.Guna2GradientPanel2.TabIndex = 37
        '
        'Guna2GradientPanel3
        '
        Me.Guna2GradientPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2GradientPanel3.FillColor = System.Drawing.Color.Fuchsia
        Me.Guna2GradientPanel3.FillColor2 = System.Drawing.Color.Purple
        Me.Guna2GradientPanel3.Location = New System.Drawing.Point(0, 55)
        Me.Guna2GradientPanel3.Name = "Guna2GradientPanel3"
        Me.Guna2GradientPanel3.ShadowDecoration.Parent = Me.Guna2GradientPanel3
        Me.Guna2GradientPanel3.Size = New System.Drawing.Size(13, 541)
        Me.Guna2GradientPanel3.TabIndex = 38
        '
        'Guna2GradientPanel4
        '
        Me.Guna2GradientPanel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2GradientPanel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GradientPanel4.Location = New System.Drawing.Point(943, 55)
        Me.Guna2GradientPanel4.Name = "Guna2GradientPanel4"
        Me.Guna2GradientPanel4.ShadowDecoration.Parent = Me.Guna2GradientPanel4
        Me.Guna2GradientPanel4.Size = New System.Drawing.Size(13, 541)
        Me.Guna2GradientPanel4.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Identity No"
        '
        'txtId
        '
        Me.txtId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtId.DefaultText = ""
        Me.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtId.DisabledState.Parent = Me.txtId
        Me.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtId.FocusedState.Parent = Me.txtId
        Me.txtId.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtId.HoverState.Parent = Me.txtId
        Me.txtId.Location = New System.Drawing.Point(150, 126)
        Me.txtId.MaxLength = 10
        Me.txtId.Name = "txtId"
        Me.txtId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtId.PlaceholderText = ""
        Me.txtId.SelectedText = ""
        Me.txtId.ShadowDecoration.Parent = Me.txtId
        Me.txtId.Size = New System.Drawing.Size(259, 36)
        Me.txtId.TabIndex = 3
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ParentPanel
        '
        Me.ParentPanel.Controls.Add(Me.Guna2Button1)
        Me.ParentPanel.Controls.Add(Me.btnSearch)
        Me.ParentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParentPanel.Location = New System.Drawing.Point(0, 0)
        Me.ParentPanel.Name = "ParentPanel"
        Me.ParentPanel.Size = New System.Drawing.Size(956, 610)
        Me.ParentPanel.TabIndex = 40
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Magenta
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(238, 524)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(115, 45)
        Me.Guna2Button1.TabIndex = 37
        Me.Guna2Button1.Text = "Refresh"
        '
        'GymMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 610)
        Me.Controls.Add(Me.Guna2GradientPanel4)
        Me.Controls.Add(Me.Guna2GradientPanel3)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtEndDate)
        Me.Controls.Add(Me.txtDoB)
        Me.Controls.Add(Me.txtStartDate)
        Me.Controls.Add(Me.attendantTable)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtPoint)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.ParentPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GymMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GymMain"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.attendantTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ParentPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPoint As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents attendantTable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDoB As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel3 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel4 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ParentPanel As System.Windows.Forms.Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
