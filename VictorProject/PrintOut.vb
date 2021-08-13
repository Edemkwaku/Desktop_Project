Public Class PrintOut
    Private bitmap As Bitmap
    Dim photoPath As String

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.PrinterSettings.PrinterName = My.Settings.printer
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim dm As New Bitmap(Me.GunaPanel1.Width, Me.GunaPanel1.Height)
        GunaPanel1.DrawToBitmap(dm, New Rectangle(0, 0, Me.GunaPanel1.Width, Me.GunaPanel1.Height))
        e.Graphics.DrawImage(dm, 0, 0)

        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub


    Private Sub PrintOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtName.Text = fname
        txtID.Text = Identity
        txtStart.Text = sdate
        txtEnd.Text = eDate

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        photoPath = OpenFileDialog1.FileName
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        OpenFileDialog1.ShowDialog()
        Dim img As Image = Image.FromFile(photoPath)
        PictureBox1.Show()
        PictureBox1.Image = img
    End Sub

    Private Sub btnChoosePrinter_Click(sender As Object, e As EventArgs) Handles btnChoosePrinter.Click
        Printer.ShowDialog()
    End Sub
End Class