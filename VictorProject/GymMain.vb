Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class GymMain


    Private bitmap As Bitmap
    Dim Sqlconn As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
    Dim SqlRd As MySqlDataReader
    Dim SqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String

    'Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=victor")
    Dim iExit As DialogResult

    Private Sub Guna2Button1_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        Label1.Visible = True
    End Sub

    Private Sub Guna2Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        Label1.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Public Sub updateTable()
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

        Sqlconn.Open()
        SqlCmd.Connection = Sqlconn
        SqlCmd.CommandText = ("SELECT identity,Name,point, DoB as 'BirthDate',startDate as Start,endDate as End FROM `gym`")
        SqlRd = SqlCmd.ExecuteReader
        SqlDt.Load(SqlRd)
        SqlRd.Close()
        Sqlconn.Close()
        attendantTable.DataSource = SqlDt

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

        If txtId.Text = "" Then
            iExit = MessageBox.Show("Identification field can't be empty", "Required fild", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf txtFirstName.Text = "Enter fisrt name" Or txtFirstName.Text = "" Then
            iExit = MessageBox.Show("First name can't be empty", "Required fild", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
        Try

            Sqlconn.Open()
                sqlQuery = "Insert into `gym` (identity,Name,point,DoB,startDate,endDate) values('" & txtId.Text & "','" & txtFirstName.Text & "','" & txtPoint.Text & "','" & txtDoB.Value.ToString("yyyy-MM-dd") & "','" & txtStartDate.Value.ToString("yyyy-MM-dd") & "','" & txtEndDate.Value.ToString("yyyy-MM-dd") & "' )"

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

        Identity = "GYM-" & txtId.Text
        fname = txtFirstName.Text
        sdate = txtStartDate.Value.ToString("yyyy-MM-dd")
        eDate = txtEndDate.Value.ToString("yyyy-MM-dd")
        clear()
        PrintOut.ShowDialog()
    End Sub

    Private Sub GymMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        'Dim Days As Date = (Today.Da - txtEndDate.Value)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

        Try
            Sqlconn.Open()
            sqlQuery = "Update victor.gym set Name='" & txtFirstName.Text & "',point=point +'" & txtPoint.Text & "',DoB='" & txtDoB.Value.ToString("yyyy-MM-dd") & "',startDate='" & txtStartDate.Value.ToString("yyyy-MM-dd") & "',endDate='" & txtEndDate.Value.ToString("yyyy-MM-dd") & "' where identity='" & txtId.Text & "'"

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

        clear()

        updateTable()

       
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

        Try
            Sqlconn.Open()
            sqlQuery = "Delete from victor.gym  where identity='" & txtId.Text & "'"

            Dim Cmd As New MySqlCommand()
            Cmd = New MySqlCommand(sqlQuery, Sqlconn)

            SqlRd = Cmd.ExecuteReader

            Sqlconn.Close()
            iExit = MessageBox.Show("Record Deleted Successfully", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Sqlconn.Dispose()

        End Try

        updateTable()
    End Sub

    Private Sub GymMain_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        updateTable()
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            For Each txt In attendantTable.Rows
                attendantTable.Rows.Clear()
            Next

            Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

            Sqlconn.Open()
            SqlCmd.Connection = Sqlconn
            SqlCmd.CommandText = ("SELECT identity,Name    ,point, DoB as 'BirthDate',startDate as Start,endDate as End FROM `gym` where id=" & txtId.Text)
            SqlRd = SqlCmd.ExecuteReader
            SqlDt.Load(SqlRd)
            SqlRd.Close()
            Sqlconn.Close()
            attendantTable.DataSource = SqlDt
        Catch ex As Exception
            MessageBox.Show("Record not find")
        End Try
        updateTable()
    End Sub

    Private Sub attendantTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles attendantTable.CellClick
        Try
            txtId.Text = attendantTable.SelectedRows(0).Cells(0).Value.ToString
            txtFirstName.Text = attendantTable.SelectedRows(0).Cells(1).Value.ToString
            txtPoint.Text = attendantTable.SelectedRows(0).Cells(2).Value.ToString
            txtDoB.Text = attendantTable.SelectedRows(0).Cells(3).Value.ToString
            txtStartDate.Text = attendantTable.SelectedRows(0).Cells(4).Value.ToString
            txtEndDate.Text = attendantTable.SelectedRows(0).Cells(5).Value.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        clear()
        updateTable()
    End Sub

    Private Sub clear()
        txtFirstName.Text = ""
        txtDoB.Value = Today.Date
        txtEndDate.Value = Today.Date
        txtId.Text = ""
        txtPoint.Text = ""
        txtStartDate.Value = Today.Date
    End Sub
End Class