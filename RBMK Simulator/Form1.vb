Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Public Power = 0
    Public Temp = 0
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not Power = 1200 Then
            Timer2.Start()
        End If
        If Not Temp = 600 Then
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox2.Text = Power
        TextBox3.Text = Temp
        If Power = 1200 Then
            Timer1.Stop()
        End If
        Power += 2
        If Temp = 602 Then
            Temp -= 2
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = Power
        TextBox3.Text = Temp
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TextBox2.Text = Power
        TextBox3.Text = Temp
        If Temp = 600 Then
            Timer2.Stop()
        End If
        Temp += 2
        If Temp = 100 Then
            Timer1.Start()
        End If
    End Sub
End Class
