<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
        Label1 = New Label()
        Panel3 = New Panel()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.Name = "Panel1"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label2)
        resources.ApplyResources(Panel2, "Panel2")
        Panel2.Name = "Panel2"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(TextBox1, "TextBox1")
        TextBox1.Name = "TextBox1"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.Name = "Label2"
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label5)
        resources.ApplyResources(Panel3, "Panel3")
        Panel3.Name = "Panel3"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaptionText
        TextBox3.BorderStyle = BorderStyle.None
        resources.ApplyResources(TextBox3, "TextBox3")
        TextBox3.ForeColor = Color.Tomato
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ActiveCaptionText
        TextBox2.BorderStyle = BorderStyle.None
        resources.ApplyResources(TextBox2, "TextBox2")
        TextBox2.ForeColor = Color.YellowGreen
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.Name = "Label3"
        ' 
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        Label4.Name = "Label4"
        ' 
        ' Label5
        ' 
        resources.ApplyResources(Label5, "Label5")
        Label5.Name = "Label5"
        ' 
        ' Timer1
        ' 
        ' 
        ' Timer2
        ' 
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer2 As Timer

End Class
