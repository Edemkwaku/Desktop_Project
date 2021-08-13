<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintOut))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New Guna.UI.WinForms.GunaButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnImport = New Guna.UI.WinForms.GunaButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GunaImageReplaceColor1 = New Guna.UI.WinForms.GunaImageReplaceColor(Me.components)
        Me.btnChoosePrinter = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.txtEnd = New System.Windows.Forms.Label()
        Me.txtStart = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.AnimationHoverSpeed = 0.07!
        Me.btnPrint.AnimationSpeed = 0.03!
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.BorderColor = System.Drawing.Color.Black
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrint.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPrint.Location = New System.Drawing.Point(92, 304)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPrint.OnHoverImage = Nothing
        Me.btnPrint.OnPressedColor = System.Drawing.Color.Black
        Me.btnPrint.Radius = 5
        Me.btnPrint.Size = New System.Drawing.Size(129, 30)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrintDocument1
        '
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnImport
        '
        Me.btnImport.AnimationHoverSpeed = 0.07!
        Me.btnImport.AnimationSpeed = 0.03!
        Me.btnImport.BackColor = System.Drawing.Color.Transparent
        Me.btnImport.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnImport.BorderColor = System.Drawing.Color.Black
        Me.btnImport.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnImport.FocusedColor = System.Drawing.Color.Empty
        Me.btnImport.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.btnImport.ForeColor = System.Drawing.Color.White
        Me.btnImport.Image = Nothing
        Me.btnImport.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnImport.Location = New System.Drawing.Point(242, 304)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnImport.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnImport.OnHoverForeColor = System.Drawing.Color.White
        Me.btnImport.OnHoverImage = Nothing
        Me.btnImport.OnPressedColor = System.Drawing.Color.Black
        Me.btnImport.Radius = 5
        Me.btnImport.Size = New System.Drawing.Size(147, 30)
        Me.btnImport.TabIndex = 12
        Me.btnImport.Text = "Select Photo"
        Me.btnImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(144, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "MEMBERSHIP CARD"
        '
        'GunaImageReplaceColor1
        '
        Me.GunaImageReplaceColor1.Image = Nothing
        Me.GunaImageReplaceColor1.NewColor = System.Drawing.Color.Empty
        Me.GunaImageReplaceColor1.OldColor = System.Drawing.Color.White
        '
        'btnChoosePrinter
        '
        Me.btnChoosePrinter.AnimationHoverSpeed = 0.07!
        Me.btnChoosePrinter.AnimationSpeed = 0.03!
        Me.btnChoosePrinter.BackColor = System.Drawing.Color.Transparent
        Me.btnChoosePrinter.BaseColor = System.Drawing.Color.Gray
        Me.btnChoosePrinter.BorderColor = System.Drawing.Color.Black
        Me.btnChoosePrinter.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnChoosePrinter.FocusedColor = System.Drawing.Color.Empty
        Me.btnChoosePrinter.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoosePrinter.ForeColor = System.Drawing.Color.White
        Me.btnChoosePrinter.Image = Nothing
        Me.btnChoosePrinter.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnChoosePrinter.Location = New System.Drawing.Point(418, 304)
        Me.btnChoosePrinter.Name = "btnChoosePrinter"
        Me.btnChoosePrinter.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.btnChoosePrinter.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.btnChoosePrinter.OnHoverForeColor = System.Drawing.Color.White
        Me.btnChoosePrinter.OnHoverImage = Nothing
        Me.btnChoosePrinter.OnPressedColor = System.Drawing.Color.Gray
        Me.btnChoosePrinter.Radius = 5
        Me.btnChoosePrinter.Size = New System.Drawing.Size(138, 30)
        Me.btnChoosePrinter.TabIndex = 15
        Me.btnChoosePrinter.Text = "Choose Printer"
        Me.btnChoosePrinter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.BackgroundImage = CType(resources.GetObject("GunaPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaPanel1.Controls.Add(Me.Panel2)
        Me.GunaPanel1.Controls.Add(Me.txtEnd)
        Me.GunaPanel1.Controls.Add(Me.txtStart)
        Me.GunaPanel1.Controls.Add(Me.txtID)
        Me.GunaPanel1.Controls.Add(Me.txtName)
        Me.GunaPanel1.Controls.Add(Me.Label9)
        Me.GunaPanel1.Controls.Add(Me.Label8)
        Me.GunaPanel1.Controls.Add(Me.Label7)
        Me.GunaPanel1.Controls.Add(Me.Label6)
        Me.GunaPanel1.Controls.Add(Me.Panel1)
        Me.GunaPanel1.Controls.Add(Me.Label5)
        Me.GunaPanel1.Controls.Add(Me.PictureBox1)
        Me.GunaPanel1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaPanel1.Location = New System.Drawing.Point(92, 36)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(464, 230)
        Me.GunaPanel1.TabIndex = 16
        '
        'txtEnd
        '
        Me.txtEnd.AutoSize = True
        Me.txtEnd.BackColor = System.Drawing.Color.White
        Me.txtEnd.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnd.Location = New System.Drawing.Point(296, 173)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(59, 20)
        Me.txtEnd.TabIndex = 16
        Me.txtEnd.Text = "Label10"
        '
        'txtStart
        '
        Me.txtStart.AutoSize = True
        Me.txtStart.BackColor = System.Drawing.Color.White
        Me.txtStart.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStart.Location = New System.Drawing.Point(296, 135)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(59, 20)
        Me.txtStart.TabIndex = 16
        Me.txtStart.Text = "Label10"
        '
        'txtID
        '
        Me.txtID.AutoSize = True
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(269, 98)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(59, 20)
        Me.txtID.TabIndex = 16
        Me.txtID.Text = "Label10"
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(268, 65)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(59, 20)
        Me.txtName.TabIndex = 16
        Me.txtName.Text = "Label10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(214, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 21)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "EndDate:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(214, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 21)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "StartDate:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(214, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(214, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Name:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Location = New System.Drawing.Point(214, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(251, 3)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Location = New System.Drawing.Point(461, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 225)
        Me.Panel2.TabIndex = 17
        '
        'PrintOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 369)
        Me.Controls.Add(Me.btnChoosePrinter)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Name = "PrintOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PrintOut"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnPrint As Guna.UI.WinForms.GunaButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnImport As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GunaImageReplaceColor1 As Guna.UI.WinForms.GunaImageReplaceColor
    Friend WithEvents btnChoosePrinter As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEnd As System.Windows.Forms.Label
    Friend WithEvents txtStart As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
