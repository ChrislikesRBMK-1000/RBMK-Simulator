Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Public Power = 0
    Public Temp = 20
    Public TempTarget = 600
    Public PowerTarget = 1200
    Dim speedhack As Boolean = False
    Public WaterPump = False
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TempTarget = 600
        PowerTarget = 1200
        If Not Power >= 1200 Then
            Timer1.Start()
            TextBox5.Text += "Reactor Starting"
        End If
        If Not Temp >= 600 Then
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox2.Text = Power
        TextBox3.Text = Temp
        If WaterPump = False Then
            TempTarget = 2750
            PowerTarget = 100000
            speedhack = True
        Else
            TempTarget = 600
            PowerTarget = 1200
            speedhack = False
        End If
        If Power > PowerTarget Then
            If speedhack Then Power -= 20 Else Power -= 3
        ElseIf Power < PowerTarget AndAlso Temp >= 100 Then
            If speedhack Then Power += 20 Else Power += 3
            End If
            If Temp > TempTarget Then
                If speedhack Then Temp -= 20 Else Temp -= 2
            ElseIf Temp < TempTarget Then
                If speedhack Then Temp += 20 Else Temp += 2
            End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = Power
        TextBox3.Text = Temp
        TextBox4.Text = "Off"
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PowerTarget = 0
        TempTarget = 20
        TextBox5.Text += "Reactor Stopping"
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.S Then
            speedhack = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WaterPump = True
        TextBox4.Text = "On"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WaterPump = False
        TextBox4.Text = "Off"
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub
End Class
