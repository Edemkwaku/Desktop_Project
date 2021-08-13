Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class Login



    Dim iExit As DialogResult


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub txtCreateAccount_Click(sender As Object, e As EventArgs)
        Me.Close()
        User.Show()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        Dim conn As New MY_CONNECTION()
        ' Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dReader As MySqlDataReader
        Dim sql As String


        If txtUsername.Text = "" Or txtUsername.Text.ToLower = "enter username" Then
            iExit = MessageBox.Show("Enter Your Username To Login", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf txtPassword.Text = "" Or txtPassword.Text.ToLower = "enter password" Then
            iExit = MessageBox.Show("Enter Your Password To Login", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else


            sql = "SELECT count(*) as result, Username, Password FROM users WHERE Username='" & txtUsername.Text & "' And Password='" & txtPassword.Text & "';"

            Try
                conn.openConnection()
                Dim query As New MySqlCommand(sql, conn.getConnection)
                dReader = query.ExecuteReader()

                Do While dReader.Read = True
                    If dReader("result") = 1 Then
                        Me.Hide()
                        txtUsername.Clear()
                        txtPassword.Clear()
                        Home.Show()
                    Else
                        MsgBox("Wrong username or password!", MsgBoxStyle.Exclamation, "ERROR!")
                    End If
                Loop

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Finally
                conn.closeConnection()
                da.Dispose()
            End Try

        End If


    End Sub

    Private Sub txtHaveAccount_Click(sender As Object, e As EventArgs) Handles txtHaveAccount.Click
        Me.Hide()
        User.Show()
    End Sub

    Private Sub txtHaveAccount_MouseEnter(sender As Object, e As EventArgs) Handles txtHaveAccount.MouseEnter
        txtHaveAccount.ForeColor = Color.Blue
    End Sub

    Private Sub txtHaveAccount_MouseLeave(sender As Object, e As EventArgs) Handles txtHaveAccount.MouseLeave
        txtHaveAccount.ForeColor = Color.Plum
    End Sub

End Class
