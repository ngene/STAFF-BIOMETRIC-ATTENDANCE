Public Class ATTEND

    Dim Count As Integer = 0

    Dim Work As Integer = 0



    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Static start_time As DateTime
        Static stop_time As DateTime
        Dim elapsed_time As TimeSpan

        If btnStart.Text = "Start" Then
            lblElapsed.Text = ""
            start_time = Now
            btnStart.Text = "Stop"

        Else
            stop_time = Now
            elapsed_time = stop_time.Subtract(start_time)

            lblElapsed.Text = elapsed_time.TotalSeconds.ToString("0.000000")
            btnStart.Text = "Start"



        End If

    End Sub

    Private Sub ATTEND_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.SelectionStart = 0
        TextBox2.SelectionStart = 0
        Timer1.Interval = 1000
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 1200 ' 1200 = 20 minutes

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Count = Count + 1
        If Count = 1200 Then
            Label1.Enabled = False
            Label2.Enabled = False
            Label3.Enabled = False
            Label4.Enabled = False
            Timer1.Stop()
        End If
        ProgressBar1.Value = Count
    End Sub

    Private Sub lblElapsed_Click(sender As Object, e As EventArgs) Handles lblElapsed.Click
        If Work = 0 Then
            Work = 1
            Timer1.Start()
        End If
        Label1.BackColor = Color.LimeGreen
        Label2.BackColor = Color.Red
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Work = 0 Then
            Work = 1
            Timer1.Start()
        End If
        Label2.BackColor = Color.LimeGreen
        Label1.BackColor = Color.Red
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Work = 0 Then
            Work = 1
            Timer1.Start()
        End If
        Label3.BackColor = Color.LimeGreen
        Label4.BackColor = Color.Red
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label9.Click
        If Work = 0 Then
            Work = 1
            Timer1.Start()
        End If
        Label4.BackColor = Color.LimeGreen
        Label3.BackColor = Color.Red
    End Sub
End Class