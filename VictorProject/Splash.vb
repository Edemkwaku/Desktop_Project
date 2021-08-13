Public Class Splash


    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        myProgressBar.Increment(1)
        If myProgressBar.Value > 0 And myProgressBar.Value <= 30 Then
            lbMessage.Text = "System loading...."
            red1.Visible = True
            red2.Visible = True
            red3.Visible = True
            red4.Visible = True
            red5.Visible = True
            red6.Visible = True
            txtDeveloper.ForeColor = Color.DarkOrange

        End If
        If myProgressBar.Value > 30 And myProgressBar.Value <= 60 Then
            lbMessage.Text = "Updating system data..."
            red1.Visible = True
            red3.Visible = True
            red5.Visible = True
            red6.Visible = False
            red2.Visible = False
            red4.Visible = False
            yellow2.Visible = True
            yellow4.Visible = True
            yellow6.Visible = True
            txtDeveloper.ForeColor = Color.LightGreen
        End If

        If myProgressBar.Value > 60 And myProgressBar.Value <= 85 Then
            lbMessage.Text = "Synchronizing ...."
            yellow1.Visible = True
            yellow2.Visible = True
            yellow3.Visible = True
            yellow4.Visible = True
            yellow5.Visible = True
            yellow6.Visible = True
            red1.Visible = False
            red2.Visible = False
            red3.Visible = False
            red4.Visible = False
            red5.Visible = False
            red6.Visible = False
            txtDeveloper.ForeColor = Color.Yellow
        End If

        If myProgressBar.Value > 85 And myProgressBar.Value <= 99 Then
            lbMessage.Text = "Program starting..."
            green1.Visible = True
            green2.Visible = True
            green3.Visible = True
            green4.Visible = True
            green5.Visible = True
            green6.Visible = True
            yellow1.Visible = False
            yellow2.Visible = False
            yellow3.Visible = False
            yellow4.Visible = False
            yellow5.Visible = False
            yellow6.Visible = False
            txtDeveloper.ForeColor = Color.Lime
        End If

        If myProgressBar.Value = 100 Then
            Me.Hide()
            Login.Show()
            Timer1.Enabled = False
        End If
    End Sub
End Class