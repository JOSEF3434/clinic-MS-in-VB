<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInPage))
        Panel1 = New Panel()
        Label8 = New Label()
        Panel2 = New Panel()
        Label5 = New Label()
        Label1 = New Label()
        Role = New ComboBox()
        LogInBtn = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Password = New TextBox()
        UserName = New TextBox()
        CanslBtn = New Label()
        ChBox = New CheckBox()
        Label4 = New Label()
        SignUpBtn = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label8)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(432, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(605, 617)
        Panel1.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(561, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 45)
        Label8.TabIndex = 22
        Label8.Text = "X"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(432, 93)
        Panel2.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(190, 63)
        Label5.Name = "Label5"
        Label5.Size = New Size(210, 30)
        Label5.TabIndex = 3
        Label5.Text = "HMS LOGIN PASGE"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(303, 45)
        Label1.TabIndex = 2
        Label1.Text = "WELLCOM TO OUR"
        ' 
        ' Role
        ' 
        Role.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Role.ForeColor = Color.DodgerBlue
        Role.FormattingEnabled = True
        Role.Items.AddRange(New Object() {"Doctor", "Receptionist"})
        Role.Location = New Point(73, 166)
        Role.Name = "Role"
        Role.Size = New Size(251, 38)
        Role.TabIndex = 2
        Role.Text = "Select Role"
        ' 
        ' LogInBtn
        ' 
        LogInBtn.BackColor = Color.DodgerBlue
        LogInBtn.FlatStyle = FlatStyle.Flat
        LogInBtn.Font = New Font("Comic Sans MS", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LogInBtn.Location = New Point(73, 388)
        LogInBtn.Name = "LogInBtn"
        LogInBtn.Size = New Size(178, 65)
        LogInBtn.TabIndex = 3
        LogInBtn.Text = "Login"
        LogInBtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Label2.ForeColor = Color.DodgerBlue
        Label2.Location = New Point(12, 238)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 30)
        Label2.TabIndex = 5
        Label2.Text = "UserName"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Label3.ForeColor = Color.DodgerBlue
        Label3.Location = New Point(12, 305)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 30)
        Label3.TabIndex = 6
        Label3.Text = "Password "
        ' 
        ' Password
        ' 
        Password.Font = New Font("Segoe UI", 11F)
        Password.Location = New Point(112, 305)
        Password.Name = "Password"
        Password.Size = New Size(231, 37)
        Password.TabIndex = 7
        ' 
        ' UserName
        ' 
        UserName.Font = New Font("Segoe UI", 11F)
        UserName.Location = New Point(133, 231)
        UserName.Name = "UserName"
        UserName.Size = New Size(225, 37)
        UserName.TabIndex = 8
        ' 
        ' CanslBtn
        ' 
        CanslBtn.AutoSize = True
        CanslBtn.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CanslBtn.ForeColor = Color.DodgerBlue
        CanslBtn.Location = New Point(286, 415)
        CanslBtn.Name = "CanslBtn"
        CanslBtn.Size = New Size(86, 38)
        CanslBtn.TabIndex = 3
        CanslBtn.Text = "Cansl"
        ' 
        ' ChBox
        ' 
        ChBox.AutoSize = True
        ChBox.BackColor = Color.DodgerBlue
        ChBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ChBox.Location = New Point(298, 348)
        ChBox.Name = "ChBox"
        ChBox.Size = New Size(139, 36)
        ChBox.TabIndex = 9
        ChBox.Text = "showPass"
        ChBox.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DodgerBlue
        Label4.Location = New Point(0, 503)
        Label4.Name = "Label4"
        Label4.Size = New Size(399, 38)
        Label4.TabIndex = 10
        Label4.Text = "If You Have No Account Firse"
        ' 
        ' SignUpBtn
        ' 
        SignUpBtn.AutoSize = True
        SignUpBtn.BackColor = Color.ForestGreen
        SignUpBtn.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignUpBtn.ForeColor = Color.White
        SignUpBtn.Location = New Point(320, 503)
        SignUpBtn.Name = "SignUpBtn"
        SignUpBtn.Size = New Size(112, 38)
        SignUpBtn.TabIndex = 11
        SignUpBtn.Text = "SignUp"
        ' 
        ' LogInPage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1037, 617)
        Controls.Add(SignUpBtn)
        Controls.Add(Label4)
        Controls.Add(ChBox)
        Controls.Add(CanslBtn)
        Controls.Add(UserName)
        Controls.Add(Password)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(LogInBtn)
        Controls.Add(Role)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "LogInPage"
        Text = "LogInPage"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Role As ComboBox
    Friend WithEvents LogInBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents UserName As TextBox
    Friend WithEvents CanslBtn As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ChBox As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SignUpBtn As Label


End Class
