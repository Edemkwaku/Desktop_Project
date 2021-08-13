Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class PRODUCTS
    Dim Sqlconn As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
    Dim SqlRd As MySqlDataReader
    Dim SqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String

    Dim iExit As DialogResult


    Private Sub updateTable()
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

        Sqlconn.Open()
        SqlCmd.Connection = Sqlconn
        SqlCmd.CommandText = ("SELECT * FROM `product` ")
        SqlRd = SqlCmd.ExecuteReader
        SqlDt.Load(SqlRd)
        SqlRd.Close()
        Sqlconn.Close()
        productDataGrid.DataSource = SqlDt

    End Sub
    Private Sub FillCombo()
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")
        Sqlconn.Open()
        Dim mysqlcmd As New MySqlCommand("select * from product", Sqlconn)
        Dim adapter As New MySqlDataAdapter(mysqlcmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        ProductCombo.DataSource = Tbl
        ProductCombo.DisplayMember = "Product_Name"
        ProductCombo.ValueMember = "Product_Name"

        Sqlconn.Close()


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

        If txtProductName.Text = "Enter Product name" Or txtProductName.Text = "" Then
            iExit = MessageBox.Show("Product-Name fild can't be empty", "Required fild", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf (txtBuyingPrice.Text) = "Enter Buying price" Or txtBuyingPrice.Text = "" Then
            iExit = MessageBox.Show("Buying-Price fild can't be empty", "Required fild", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf (txtSellingPrice.Text) = "Enter Selling price" Or txtSellingPrice.Text = "" Then
            iExit = MessageBox.Show("Selling-Price fild can't be empty", "Required fild", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf (txtProductQuantity.Text) = "Enter Quantity" Or txtProductQuantity.Text = "" Then
            iExit = MessageBox.Show("Quantity fild can't be empty", "Required fild", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Try

                Sqlconn.Open()
                sqlQuery = "Insert into `product` (Product_Name,Buying_Price,Selling_Price,Quantity) values('" & txtProductName.Text & "','" & txtBuyingPrice.Text & "','" & txtSellingPrice.Text & "','" & txtProductQuantity.Text & "' )"

                SqlCmd = New MySqlCommand(sqlQuery, Sqlconn)
                SqlRd = SqlCmd.ExecuteReader
                iExit = MessageBox.Show("Record Added Successfull", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Sqlconn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Mysql connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                Sqlconn.Dispose()

            End Try
            updateTable()
        End If

    End Sub

    Private Sub PRODUCTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        updateTable()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")
        If ((txtProductName.Text = "Enter Product name" Or txtProductName.Text = "") Or (txtBuyingPrice.Text = "Enter Buying price" Or txtBuyingPrice.Text = "") Or (txtSellingPrice.Text = "Enter Selling price" Or txtSellingPrice.Text = "") Or (txtProductQuantity.Text = "Enter Quantity" Or txtProductQuantity.Text = "")) Then
            iExit = MessageBox.Show("One Or More filds Is/Are Required", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                Sqlconn.Open()
                sqlQuery = "Update victor.product set Product_Name='" & txtProductName.Text & "',Buying_Price='" & txtBuyingPrice.Text & "',Selling_Price='" & txtSellingPrice.Text & "',Quantity= Quantity +'" & txtProductQuantity.Text & "' where Product_Name='" & txtProductName.Text & "'"


                SqlCmd = New MySqlCommand(sqlQuery, Sqlconn)
                SqlRd = SqlCmd.ExecuteReader

                Sqlconn.Close()

                iExit = MessageBox.Show("Record Update Successfully", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Sqlconn.Dispose()

            End Try
        End If
        updateTable()


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try
            iExit = MessageBox.Show("Are you sure you want to delete this record", "Confirm to delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If iExit = DialogResult.Yes Then

                Sqlconn.Open()
                sqlQuery = "Delete from victor.product  where Product_Name='" & txtProductName.Text & "'"

                Dim Cmd As New MySqlCommand()
                Cmd = New MySqlCommand(sqlQuery, Sqlconn)

                SqlRd = Cmd.ExecuteReader

                Sqlconn.Close()
                iExit = MessageBox.Show("Record Deleted Successfully", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Sqlconn.Dispose()

        End Try

        updateTable()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub productDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            txtProductName.Text = productDataGrid.SelectedRows(0).Cells(0).Value.ToString
            txtBuyingPrice.Text = productDataGrid.SelectedRows(0).Cells(1).Value.ToString
            txtSellingPrice.Text = productDataGrid.SelectedRows(0).Cells(4).Value.ToString
            txtProductQuantity.Text = productDataGrid.SelectedRows(0).Cells(2).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        Try

            Dim search_command As New MySqlCommand("SELECT * FROM `product` WHERE `Product_Name`=@Product_Name", Sqlconn)
            search_command.Parameters.Add("@Product_Name", MySqlDbType.VarChar).Value = txtProductName.Text
            Dim adapter As New MySqlDataAdapter(search_command)
            Dim table As New DataTable()

            adapter.Fill(table)
            txtProductName.Text = table(0)(0)
            txtBuyingPrice.Text = table(0)(1)
            txtSellingPrice = table(0)(2)
            txtProductQuantity.Text = table(0)(3)

        Catch ex As Exception
            MessageBox.Show(ex.Message & "Record not find")
        End Try
        updateTable()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Try
            For Each txt In Panel1.Controls
                If TypeOf txt Is Guna2TextBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        updateTable()
    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        Label6.Visible = True
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        Label6.Visible = False
    End Sub

    Private Sub productDataGrid_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles productDataGrid.CellClick
        txtProductName.Text = productDataGrid.SelectedRows(0).Cells(0).Value.ToString
        txtBuyingPrice.Text = productDataGrid.SelectedRows(0).Cells(1).Value.ToString
        txtSellingPrice.Text = productDataGrid.SelectedRows(0).Cells(2).Value.ToString
        txtProductQuantity.Text = productDataGrid.SelectedRows(0).Cells(3).Value.ToString
    End Sub
End Class