<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Printer
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnChooseprinter = New Guna.UI.WinForms.GunaButton()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(345, 20)
        Me.TextBox1.TabIndex = 0
        '
        'btnChooseprinter
        '
        Me.btnChooseprinter.AnimationHoverSpeed = 0.07!
        Me.btnChooseprinter.AnimationSpeed = 0.03!
        Me.btnChooseprinter.BackColor = System.Drawing.Color.Transparent
        Me.btnChooseprinter.BaseColor = System.Drawing.Color.Gray
        Me.btnChooseprinter.BorderColor = System.Drawing.Color.Black
        Me.btnChooseprinter.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnChooseprinter.FocusedColor = System.Drawing.Color.Empty
        Me.btnChooseprinter.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseprinter.ForeColor = System.Drawing.Color.White
        Me.btnChooseprinter.Image = Nothing
        Me.btnChooseprinter.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnChooseprinter.Location = New System.Drawing.Point(230, 78)
        Me.btnChooseprinter.Name = "btnChooseprinter"
        Me.btnChooseprinter.OnHoverBaseColor = System.Drawing.Color.Silver
        Me.btnChooseprinter.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btnChooseprinter.OnHoverForeColor = System.Drawing.Color.White
        Me.btnChooseprinter.OnHoverImage = Nothing
        Me.btnChooseprinter.OnPressedColor = System.Drawing.Color.Gray
        Me.btnChooseprinter.Radius = 5
        Me.btnChooseprinter.Size = New System.Drawing.Size(128, 27)
        Me.btnChooseprinter.TabIndex = 1
        Me.btnChooseprinter.Text = "Choose"
        Me.btnChooseprinter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Printer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 138)
        Me.Controls.Add(Me.btnChooseprinter)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Printer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Printer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnChooseprinter As Guna.UI.WinForms.GunaButton
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
