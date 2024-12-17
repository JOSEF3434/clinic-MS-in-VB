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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Label8 = New Label()
        MyProgressBar = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Label5 = New Label()
        Label2 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(6, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(831, 45)
        Label1.TabIndex = 3
        Label1.Text = "WELLCOM TO OUR  HOSPITAL MANAGMENT SYSTEM"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(843, -3)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 45)
        Label8.TabIndex = 23
        Label8.Text = "X"
        ' 
        ' MyProgressBar
        ' 
        MyProgressBar.FillColor = Color.FromArgb(CByte(200), CByte(213), CByte(218), CByte(223))
        MyProgressBar.Font = New Font("Segoe UI", 12F)
        MyProgressBar.ForeColor = Color.White
        MyProgressBar.Location = New Point(288, 155)
        MyProgressBar.Minimum = 0
        MyProgressBar.Name = "MyProgressBar"
        MyProgressBar.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        MyProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        MyProgressBar.Size = New Size(266, 266)
        MyProgressBar.TabIndex = 24
        MyProgressBar.Text = "MyProgressBar"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(606, 101)
        Label5.Name = "Label5"
        Label5.Size = New Size(164, 30)
        Label5.TabIndex = 25
        Label5.Text = "VERSION 1.0.0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(228, 486)
        Label2.Name = "Label2"
        Label2.Size = New Size(528, 30)
        Label2.TabIndex = 26
        Label2.Text = "POWERED BY IT 3rd YEAR GROUP ONE STUDENTs"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        ClientSize = New Size(883, 543)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(MyProgressBar)
        Controls.Add(Label8)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "WELCOME PAGE"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MyProgressBar As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer

End Class
