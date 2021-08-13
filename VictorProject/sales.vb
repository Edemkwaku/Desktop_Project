Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Guna.UI.WinForms

Public Class SALES
    Dim Sqlconn As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
    Dim SqlRd As MySqlDataReader
    Dim SqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String

    Dim iExit As DialogResult


    Private bitmap As Bitmap

    Private Sub FillCombo()
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

        Sqlconn.Open()
        Dim mysqlcmd As New MySqlCommand("select * from product", Sqlconn)
        Dim adapter As New MySqlDataAdapter(mysqlcmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        selectProductComboBox.DataSource = Tbl
        selectProductComboBox.DisplayMember = "Product_Name"
        selectProductComboBox.ValueMember = "Product_Name"

        Sqlconn.Close()
    End Sub


    Dim stock, Uprice
    Private Sub FetchQuantity()
        Sqlconn.Open()
        sqlQuery = "select * from product where Product_Name='" & selectProductComboBox.SelectedValue.ToString & "'"
        Dim cmd As New MySqlCommand(sqlQuery, Sqlconn)
        Dim dt As New DataTable
        Dim reader As MySqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            stock = reader(3)
            Uprice = reader(2)
            lblAvialableStock.Text = "Avialable Stock Is :" + reader(3).ToString()
        End While
        Sqlconn.Close()
    End Sub

    Private Sub btnProductForm_Click(sender As Object, e As EventArgs)
        PRODUCTS.Show()
        Me.Hide()
    End Sub

    Private Sub btnSaleForm_Click(sender As Object, e As EventArgs)
        CUSTOMER.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        iExit = MessageBox.Show("Are you sure you want to Exit", "Confirm to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
    End Sub


    Private Sub SALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
    End Sub

    Private Sub selectProductComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles selectProductComboBox.SelectionChangeCommitted
        FetchQuantity()
    End Sub

    Dim i = 0, totalPrice

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim height As Integer = BillingDataGridView.Height
        BillingDataGridView.Height = BillingDataGridView.RowCount * BillingDataGridView.RowTemplate.Height
        bitmap = New Bitmap(Me.BillingDataGridView.Width, Me.BillingDataGridView.Height)
        BillingDataGridView.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.BillingDataGridView.Width, Me.BillingDataGridView.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        BillingDataGridView.Height = height
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim recP As RectangleF = e.PageSettings.PrintableArea

        If Me.BillingDataGridView.Height - recP.Height > 0 Then e.HasMorePages = True
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub


    Dim GrossTotal As Double = 0


    Private Sub btnAddBill_Click(sender As Object, e As EventArgs) Handles btnAddBill.Click
        If txtQuantity.Text > stock Then
            MessageBox.Show(" There is No Enough In Stock", "No Enough Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtQuantity.Text = "" Then
            MessageBox.Show("Enter a Quantity", "Quantity required", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Sqlconn.Open()
            sqlQuery = "select * from product where Product_Name='" & selectProductComboBox.SelectedValue.ToString & "'"
            Dim cmd As New MySqlCommand(sqlQuery, Sqlconn)
            Dim dt As New DataTable
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                stock = reader(3)
                stock = (txtQuantity.Text)
            End While
            Sqlconn.Close()

            Dim rnum As Integer = BillingDataGridView.Rows.Add()
            i = i + 1
            BillingDataGridView.Rows.Item(rnum).Cells("Column1").Value = selectProductComboBox.SelectedValue.ToString
            BillingDataGridView.Rows.Item(rnum).Cells("Column2").Value = txtQuantity.Text
            BillingDataGridView.Rows.Item(rnum).Cells("Column3").Value = Uprice
            BillingDataGridView.Rows.Item(rnum).Cells("Column4").Value = txtQuantity.Text * Uprice

            Label2.Visible = True
            Dim SubTotal = txtQuantity.Text * Uprice
            GrossTotal = GrossTotal + SubTotal
            lblTotal.Text = "Ghc " & (GrossTotal).ToString("N2")
        End If

        updateProduct()

    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        Label5.Visible = True
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        Label5.Visible = False
    End Sub


    Private Sub updateTable()
        Dim pro As New PRODUCTS
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

        Sqlconn.Open()
        SqlCmd.Connection = Sqlconn
        SqlCmd.CommandText = ("SELECT * FROM `product` ")
        SqlRd = SqlCmd.ExecuteReader
        SqlDt.Load(SqlRd)
        SqlRd.Close()
        Sqlconn.Close()
        pro.productDataGrid.DataSource = SqlDt

    End Sub


    Private Sub updateProduct()
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

        Sqlconn.Open()
        sqlQuery = "Update victor.product set Quantity= Quantity -'" & txtQuantity.Text & "' where Product_Name='" & selectProductComboBox.Text & "'"
        SqlCmd = New MySqlCommand(sqlQuery, Sqlconn)
        SqlRd = SqlCmd.ExecuteReader

        Sqlconn.Close()
        Sqlconn.Dispose()
        updateTable()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim rnum As Integer = BillingDataGridView.Rows.Add()
        i = i + 1
        For Each txt In BillingDataGridView.Rows
            BillingDataGridView.Rows.Clear()
            lblTotal.Text = ""
        Next
    End Sub
End Class