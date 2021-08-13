Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports Guna.UI2.Material
Public Class CUSTOMER
    Dim Sqlconn As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
    Dim SqlRd As MySqlDataReader
    Dim SqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String

    'Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=victor")
    Dim iExit As DialogResult


    Private Sub CUSTOMER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchComboBox.SelectedIndex = 0
        updateTable()

    End Sub

    Private Sub updateTable()
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

        Sqlconn.Open()
        SqlCmd.Connection = Sqlconn
        SqlCmd.CommandText = ("SELECT * FROM `customer`")
        SqlRd = SqlCmd.ExecuteReader
        SqlDt.Load(SqlRd)
        SqlRd.Close()
        Sqlconn.Close()
        DataGridView1.DataSource = SqlDt

    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

        If txtFirstName.Text = "" Or txtFirstName.Text = "Enter First Name" Then
            MsgBox("Fisrt Name can't be empty", MsgBoxStyle.Information, "Required fild")

        ElseIf txtPhoneNo.Text = "" Or txtPhoneNo.Text = "Enter Phone Number" Then
            MsgBox("Phone Number can't be empty", MsgBoxStyle.Information, "Required fild")

        ElseIf txtGender.Text = "" Or txtGender.Text = "Enter Gender" Then
            MsgBox("Gender fild can't be empty", MsgBoxStyle.Information, "Required fild")

        ElseIf txtCity.Text = "" Or txtCity.Text = "Enter City/Town " Then
            MsgBox("City fild can't be empty", MsgBoxStyle.Information, "Required fild")

        ElseIf txtHouseNo.Text = "" Or txtHouseNo.Text = "Enter House number" Then
            MsgBox("House Number can't be empty", MsgBoxStyle.Information, "Required fild")

        ElseIf (txtBringerName.Text <> "" Or txtBringerName.Text = "Gurrantor's name") And txtBringerPhone.Text = "" Or txtBringerPhone.Text = "Gurrantor's Phone number" Then
            MsgBox("Phone number of Gurrantor is required", MsgBoxStyle.Information, "Required fild")

        Else
            Try

                Sqlconn.Open()
                sqlQuery = "Insert into `customer`(firstName,LastName,BringerName,BringerPhone,gender,city,houseNumber,phoneNumber,point) values('" & txtFirstName.Text & "','" & txtLastName.Text & "','" & txtBringerName.Text & "','" & txtBringerPhone.Text & "','" & txtGender.Text & "','" & txtCity.Text & "','" & txtHouseNo.Text & "','" & txtPhoneNo.Text & "','" & txtPoint.Text & "' )"

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

    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        Try
            For Each txt In Panel2.Controls
                If TypeOf txt Is Guna2TextBox Then
                    txt.text = ""
                End If
            Next
            txtSearch.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

        Try
            Sqlconn.Open()
            sqlQuery = "Update victor.customer set firstName='" & txtFirstName.Text & "',LastName='" & txtLastName.Text & "',BringerName='" & txtBringerName.Text & "',BringerPhone='" & txtBringerPhone.Text & "',gender='" & txtGender.Text & "',city='" & txtCity.Text & "',houseNumber='" & txtHouseNo.Text & "',phoneNumber='" & txtPhoneNo.Text & "',point='" & txtPoint.Text & "' where phoneNumber='" & txtPhoneNo.Text & "'"

            Dim Cmd As New MySqlCommand()
            Cmd = New MySqlCommand(sqlQuery, Sqlconn)

            SqlRd = Cmd.ExecuteReader

            Sqlconn.Close()
            iExit = MessageBox.Show("Record Update Successfully", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Sqlconn.Dispose()

        End Try

        updateTable()

    End Sub

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If searchComboBox.SelectedIndex = 1 Then
                Try
                    Dim search_command As New MySqlCommand("SELECT * FROM `customer` WHERE `phoneNumber`=@phoneNumber", Sqlconn)
                    search_command.Parameters.Add("@phoneNumber", MySqlDbType.VarChar).Value = txtSearch.Text
                    Dim adapter As New MySqlDataAdapter(search_command)
                    Dim table As New DataTable()

                    adapter.Fill(table)
                    txtFirstName.Text = table(0)(0)
                    txtLastName.Text = table(0)(1)
                    txtBringerName.Text = table(0)(2)
                    txtBringerPhone.Text = table(0)(3)
                    txtGender.Text = table(0)(4)
                    txtCity.Text = table(0)(5)
                    txtHouseNo.Text = table(0)(6)
                    txtPhoneNo.Text = table(0)(7)
                    txtPoint.Text = table(0)(8)
                Catch ex As Exception
                    MessageBox.Show("Record not find")
                End Try
                updateTable()

            ElseIf searchComboBox.SelectedIndex = 2 Then
                Try
                    Dim search_command As New MySqlCommand("SELECT * FROM `customer` WHERE `firstName`=@firstName", Sqlconn)
                    search_command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = txtSearch.Text
                    Dim adapter As New MySqlDataAdapter(search_command)
                    Dim table As New DataTable()

                    adapter.Fill(table)
                    txtFirstName.Text = table(0)(0)
                    txtLastName.Text = table(0)(1)
                    txtBringerName.Text = table(0)(2)
                    txtBringerPhone.Text = table(0)(3)
                    txtGender.Text = table(0)(4)
                    txtCity.Text = table(0)(5)
                    txtHouseNo.Text = table(0)(6)
                    txtPhoneNo.Text = table(0)(7)
                    txtPoint.Text = table(0)(8)
                Catch ex As Exception
                    MessageBox.Show("Record not find")
                End Try
                updateTable()

            ElseIf searchComboBox.SelectedIndex = 3 Then
                Try
                    Dim search_command As New MySqlCommand("SELECT * FROM `customer` WHERE `BringerName`=@BringerName", Sqlconn)
                    search_command.Parameters.Add("@BringerName", MySqlDbType.VarChar).Value = txtSearch.Text
                    Dim adapter As New MySqlDataAdapter(search_command)
                    Dim table As New DataTable()

                    adapter.Fill(table)
                    txtFirstName.Text = table(0)(0)
                    txtLastName.Text = table(0)(1)
                    txtBringerName.Text = table(0)(2)
                    txtBringerPhone.Text = table(0)(3)
                    txtGender.Text = table(0)(4)
                    txtCity.Text = table(0)(5)
                    txtHouseNo.Text = table(0)(6)
                    txtPhoneNo.Text = table(0)(7)
                    txtPoint.Text = table(0)(8)
                Catch ex As Exception
                    MessageBox.Show("Record not find")
                End Try
                updateTable()
            Else
                iExit = MessageBox.Show("Please you search for a record using Phone Number or First Name or Bringer's Name", "Record Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Column not set for seach")
        End Try
        updateTable()
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txtFirstName.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            txtLastName.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            txtGender.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            txtBringerName.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            txtBringerPhone.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            txtCity.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
            txtHouseNo.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString
            txtPhoneNo.Text = DataGridView1.SelectedRows(0).Cells(7).Value.ToString
            txtPoint.Text = DataGridView1.SelectedRows(0).Cells(8).Value.ToString
            txtSearch.Text = DataGridView1.SelectedRows(0).Cells(7).Value.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            iExit = MessageBox.Show("Are you sure you want to delete this record", "Confirm to delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If iExit = DialogResult.Yes Then

                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    DataGridView1.Rows.Remove(row)
                Next

                Dim search_command As New MySqlCommand("DELETE FROM `customer` WHERE `customer`.`phoneNumber` =@phoneNumber", Sqlconn)
                search_command.Parameters.Add("@phoneNumber", MySqlDbType.VarChar).Value = txtSearch.Text
                Dim adapter As New MySqlDataAdapter(search_command)
                Dim table As New DataTable()

                adapter.Fill(table)
                txtFirstName.Text = table(0)(0)
                txtLastName.Text = table(0)(1)
                txtBringerName.Text = table(0)(2)
                txtBringerPhone.Text = table(0)(3)
                txtGender.Text = table(0)(4)
                txtCity.Text = table(0)(5)
                txtHouseNo.Text = table(0)(6)
                txtPhoneNo.Text = table(0)(7)
                txtPoint.Text = table(0)(8)

                iExit = MessageBox.Show("Delete sucessfully", "Record deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            updateTable()
        Catch ex As Exception

        End Try
        Sqlconn.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        Label2.Visible = True
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        Label2.Visible = False
    End Sub
End Class
