Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class User

    Dim iExit As DialogResult


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            Dim fname As String = txtFirstName.Text
            Dim lname As String = txtLastName.Text
            Dim username$ = txtUserName.Text
            Dim phone$ = txtPhone.Text
            Dim password$ = txtPassword.Text
            Dim conPassword$ = txtConfirmPassword.Text
            If (fname = "" Or fname.ToLower() = "enter first name") Or (lname = "" Or lname.ToLower() = "enter last name") Or (username = "" Or username.ToLower() = "enter username") Or (phone = "" Or phone.ToLower() = "enter phone") Or (password = "" Or password.ToLower() = "enter password") Then
                iExit = MessageBox.Show("One or More filds is required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf Not String.Equals(password, conPassword) Then
                iExit = MessageBox.Show("Wrong Confirmation", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf usernameExit(username) Then
                iExit = MessageBox.Show("This Username Already Exit, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim conn As New MY_CONNECTION
                Dim table As New DataTable
                Dim adapter As New MySqlDataAdapter
                Dim command As New MySqlCommand("INSERT INTO `users`(`fName`, `lName`, `Username`, `Phone`, `Password`) VALUES(@fName,@lName,@Username,@Phone,@Password)", conn.getConnection())
                command.Parameters.Add("@fName", MySqlDbType.VarChar).Value = fname
                command.Parameters.Add("@lName", MySqlDbType.VarChar).Value = lname
                command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = username
                command.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = phone
                command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = password


                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    iExit = MessageBox.Show("Registration Completed Successfully", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conn.closeConnection()
                    Try
                        For Each txt In Guna2Panel.Controls
                            If TypeOf txt Is Guna2TextBox Then
                                txt.text = ""
                            End If
                        Next
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                Else
                    MessageBox.Show("Something Happen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    conn.closeConnection()
                    Try
                        For Each txt In Guna2Panel.Controls
                            If TypeOf txt Is Guna2TextBox Then
                                txt.text = ""
                            End If
                        Next
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("This Username Already Exit, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Login.Show()
    End Sub


    Private Sub txtHaveAccount_Click(sender As Object, e As EventArgs) Handles txtHaveAccount.Click
        Me.Close()
        Login.Show()
    End Sub

    Public Function usernameExit(ByVal username As String) As Boolean
        Dim conn As New MY_CONNECTION
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter
        Dim command As New MySqlCommand("SELECT * FROM `users` WHERE `Username`=@`Username`", conn.getConnection())
        command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = username

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 1 Then
            Return True
        Else
            Return False
        End If

    End Function


    Private Sub txtHaveAccount_MouseEnter(sender As Object, e As EventArgs) Handles txtHaveAccount.MouseEnter
        txtHaveAccount.ForeColor = Color.Blue
    End Sub

    Private Sub txtHaveAccount_MouseLeave(sender As Object, e As EventArgs) Handles txtHaveAccount.MouseLeave
        txtHaveAccount.ForeColor = Color.Plum
    End Sub


End Class