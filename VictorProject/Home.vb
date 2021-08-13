Imports MySql.Data.MySqlClient
Public Class Home
    Dim iExit As DialogResult
    Dim Sqlconn As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
    Dim SqlRd As MySqlDataReader
    Dim SqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String
    Dim result As String

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        'Panel6.Location.X(1)
    End Sub


    Private Sub btnDashPower_Click(sender As Object, e As EventArgs) Handles btnDashPower.Click
        iExit = MessageBox.Show("Are you sure you want to Exit The Program", "Confirm to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnDashBoardCustomer_Click(sender As Object, e As EventArgs) Handles btnDashBoardCustomer.Click
        Dim cus As New CUSTOMER
        cus.ShowDialog()
    End Sub

    Private Sub btnDashBoardProduct_Click(sender As Object, e As EventArgs) Handles btnDashBoardProduct.Click

        PRODUCTS.ShowDialog()
    End Sub

    Private Sub btnDashBoardSale_Click(sender As Object, e As EventArgs) Handles btnDashBoardSale.Click
        SALES.ShowDialog()
    End Sub

    Private Sub btnDeveloper_Click(sender As Object, e As EventArgs) Handles btnDeveloper.Click
        About.ShowDialog()
    End Sub

    Private Sub btnGym_Click(sender As Object, e As EventArgs) Handles btnGym.Click
        GymMain.ShowDialog()
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.ExitThread()
    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        Label3.Visible = True
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        Label3.Visible = False
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Me.Click
        gymAttendantCount()
        productCount()
        customer()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        checkEndDate()
        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

        Me.WindowState = FormWindowState.Maximized

        customer()
        productCount()
        gymAttendantCount()

        txtDate.Text = (Today.Day & "-" & Today.Month & "-" & Today.Year)

        txtTime.Text = (TimeOfDay.Hour & ":" & TimeOfDay.Minute & ":" & TimeOfDay.Second)

    End Sub

    Sub customer()
        sqlQuery = ("SELECT * FROM `customer`")
        Sqlconn.Open()

        SqlCmd = New MySqlCommand(sqlQuery, Sqlconn)
        DtA = New MySqlDataAdapter(SqlCmd)
        Dim dt As DataTable = New DataTable()
        DtA.Fill(dt)
        txtCustomerCount.Text = dt.Rows.Count
        Sqlconn.Close()
    End Sub
    Sub productCount()
        sqlQuery = ("SELECT* FROM `product`")
        Sqlconn.Open()

        SqlCmd = New MySqlCommand(sqlQuery, Sqlconn)
        DtA = New MySqlDataAdapter(SqlCmd)
        Dim dt As DataTable = New DataTable()
        DtA.Fill(dt)
        txtProductCount.Text = dt.Rows.Count
        Dim Qmessage As String
        'Dim x As Integer
        For i = 0 To dt.Rows.Count - 1
            If (dt.Rows(i)(3)) < 10 Then
                Qmessage = MsgBox(dt.Rows(i)(0) & " is getting out of Stock, Quantity is " & dt.Rows(i)(3))
            End If
        Next

        Sqlconn.Close()

    End Sub
    Sub gymAttendantCount()
        sqlQuery = ("SELECT * FROM `gym`")
        Sqlconn.Open()

        SqlCmd = New MySqlCommand(sqlQuery, Sqlconn)
        DtA = New MySqlDataAdapter(SqlCmd)
        Dim dt As DataTable = New DataTable()
        DtA.Fill(dt)
        gymCount.Text = dt.Rows.Count
        Sqlconn.Close()
    End Sub


    Private Sub attendantPanel_MouseHover(sender As Object, e As EventArgs) Handles attendantPanel.MouseHover
        attendantPanel.ShadowShift = 8
        attendantPanel.ShadowDepth = 200
        attendantPanel.ShadowColor = Color.Navy
    End Sub

    Private Sub attendantPanel_MouseLeave(sender As Object, e As EventArgs) Handles attendantPanel.MouseLeave
        attendantPanel.ShadowColor = Color.Black
        attendantPanel.ShadowDepth = 100
        attendantPanel.ShadowShift = 5
    End Sub

    Private Sub productPanel_MouseHover(sender As Object, e As EventArgs) Handles productPanel.MouseHover
        productPanel.ShadowShift = 8
        productPanel.ShadowDepth = 200
        productPanel.ShadowColor = Color.Navy
    End Sub

    Private Sub productPanel_MouseLeave(sender As Object, e As EventArgs) Handles productPanel.MouseLeave
        productPanel.ShadowDepth = 100
        productPanel.ShadowColor = Color.Black
        productPanel.ShadowShift = 5
    End Sub

    Private Sub customerPanel_MouseHover(sender As Object, e As EventArgs) Handles customerPanel.MouseHover
        customerPanel.ShadowShift = 8
        customerPanel.ShadowDepth = 200
        customerPanel.ShadowColor = Color.Navy
    End Sub

    Private Sub customerPanel_MouseLeave(sender As Object, e As EventArgs) Handles customerPanel.MouseLeave
        customerPanel.ShadowDepth = 100
        customerPanel.ShadowShift = 5
        customerPanel.ShadowColor = Color.Black
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTime.Text = Date.Now.ToString("dd-MM-yyyy")
        txtDate.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Sub checkEndDate()
        Dim gym As New GymMain
        ' Dim sql As String = "Select  last_name, round(months_between(sysdate,hire_date),0) Months_worked "

        Sqlconn.ConnectionString = ("datasource=localhost;port=3306;username=root;password=;database=victor")

        Try
            Sqlconn.Open()
            sqlQuery = "Delete from victor.gym  where endDate <'" & Date.Now.ToString("yyyy-MM-dd") & "'"

            Dim Cmd As New MySqlCommand()
            Cmd = New MySqlCommand(sqlQuery, Sqlconn)

            SqlRd = Cmd.ExecuteReader

            Sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Sqlconn.Dispose()

        End Try

        gym.updateTable()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Login.Show()
        Me.Hide()
    End Sub

   

    Private Sub ComboBox1_SystemColorsChanged(sender As Object, e As EventArgs)
        If ComboBox1.SelectedText = "red" Then
            Panel1.BackColor = Color.Red

        End If
    End Sub
End Class