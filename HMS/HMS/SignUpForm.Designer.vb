<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpForm))
        Panel1 = New Panel()
        Label8 = New Label()
        Label1 = New Label()
        UserName = New TextBox()
        Password = New TextBox()
        SignUpBtn = New Button()
        Role = New ComboBox()
        Panel2 = New Panel()
        Label6 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        UserId = New TextBox()
        Label5 = New Label()
        UserEmail = New TextBox()
        Label7 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Right
        Panel1.ForeColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(444, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(583, 600)
        Panel1.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(539, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 45)
        Label8.TabIndex = 21
        Label8.Text = "X"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(19, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(413, 45)
        Label1.TabIndex = 2
        Label1.Text = "WELL COME TO OUR HMS"
        ' 
        ' UserName
        ' 
        UserName.Font = New Font("Segoe UI", 11F)
        UserName.Location = New Point(134, 241)
        UserName.Name = "UserName"
        UserName.Size = New Size(225, 37)
        UserName.TabIndex = 13
        ' 
        ' Password
        ' 
        Password.Font = New Font("Segoe UI", 11F)
        Password.Location = New Point(128, 367)
        Password.Name = "Password"
        Password.Size = New Size(231, 37)
        Password.TabIndex = 12
        ' 
        ' SignUpBtn
        ' 
        SignUpBtn.BackColor = Color.DodgerBlue
        SignUpBtn.FlatAppearance.BorderSize = 0
        SignUpBtn.FlatStyle = FlatStyle.Flat
        SignUpBtn.Font = New Font("Comic Sans MS", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        SignUpBtn.ForeColor = Color.White
        SignUpBtn.Location = New Point(108, 420)
        SignUpBtn.Name = "SignUpBtn"
        SignUpBtn.Size = New Size(178, 65)
        SignUpBtn.TabIndex = 11
        SignUpBtn.Text = "SinUp"
        SignUpBtn.UseVisualStyleBackColor = False
        ' 
        ' Role
        ' 
        Role.Font = New Font("Segoe UI Variable Text", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Role.ForeColor = Color.Black
        Role.FormattingEnabled = True
        Role.Items.AddRange(New Object() {"Receptionist", "Doctor"})
        Role.Location = New Point(108, 182)
        Role.Name = "Role"
        Role.Size = New Size(251, 38)
        Role.TabIndex = 10
        Role.Text = "Select Role"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Controls.Add(Label6)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(444, 93)
        Panel2.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(37, 29)
        Label6.Name = "Label6"
        Label6.Size = New Size(321, 45)
        Label6.TabIndex = 3
        Label6.Text = " HMS SIGNUP PAGE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold Or FontStyle.Italic)
        Label2.Location = New Point(13, 248)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 30)
        Label2.TabIndex = 14
        Label2.Text = "UserName"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold Or FontStyle.Italic)
        Label3.Location = New Point(13, 374)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 30)
        Label3.TabIndex = 15
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold Or FontStyle.Italic)
        Label4.Location = New Point(22, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 30)
        Label4.TabIndex = 17
        Label4.Text = "UserId"
        ' 
        ' UserId
        ' 
        UserId.Font = New Font("Segoe UI", 11F)
        UserId.Location = New Point(134, 126)
        UserId.Name = "UserId"
        UserId.Size = New Size(225, 37)
        UserId.TabIndex = 16
        UserId.Text = "56"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold Or FontStyle.Italic)
        Label5.Location = New Point(16, 314)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 30)
        Label5.TabIndex = 19
        Label5.Text = "UserEmail"
        ' 
        ' UserEmail
        ' 
        UserEmail.Font = New Font("Segoe UI", 11F)
        UserEmail.Location = New Point(137, 307)
        UserEmail.Name = "UserEmail"
        UserEmail.Size = New Size(225, 37)
        UserEmail.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(22, 488)
        Label7.Name = "Label7"
        Label7.Size = New Size(347, 45)
        Label7.TabIndex = 20
        Label7.Text = "BACL TO LOGIN PAGE"
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DodgerBlue
        ClientSize = New Size(1027, 600)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(UserEmail)
        Controls.Add(Label4)
        Controls.Add(UserId)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(UserName)
        Controls.Add(Password)
        Controls.Add(SignUpBtn)
        Controls.Add(Role)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SignUpForm"
        Text = "SignUpForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserName As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents SignUpBtn As Button
    Friend WithEvents Role As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UserId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents UserEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
