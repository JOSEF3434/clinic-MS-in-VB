<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorForm))
        Label2 = New Label()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        DeletBtn = New Button()
        EditeBtn = New Button()
        addBtn = New Button()
        Password = New TextBox()
        Label7 = New Label()
        Spacialist = New TextBox()
        Label6 = New Label()
        Exprience = New TextBox()
        Label5 = New Label()
        DoctName = New TextBox()
        Label4 = New Label()
        DoctId = New TextBox()
        Label3 = New Label()
        DoctorDesplay = New DataGridView()
        Gender = New ComboBox()
        LogOutBtn = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DoctorDesplay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Firebrick
        Label2.Location = New Point(508, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(328, 38)
        Label2.TabIndex = 9
        Label2.Text = "DOCTOR MANAGMENT"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(185, 707)
        Panel1.TabIndex = 7
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(188, 199)
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DodgerBlue
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.SaddleBrown
        Button4.Location = New Point(-25, 385)
        Button4.Name = "Button4"
        Button4.Size = New Size(213, 55)
        Button4.TabIndex = 3
        Button4.Text = "Treatment"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DodgerBlue
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.SaddleBrown
        Button2.Location = New Point(-28, 306)
        Button2.Name = "Button2"
        Button2.Size = New Size(213, 55)
        Button2.TabIndex = 1
        Button2.Text = "Diagnosis"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DodgerBlue
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.SaddleBrown
        Button1.Location = New Point(-28, 246)
        Button1.Name = "Button1"
        Button1.Size = New Size(213, 55)
        Button1.TabIndex = 0
        Button1.Text = "Patients"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(185, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1062, 48)
        Panel2.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(993, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 38)
        Label1.TabIndex = 3
        Label1.Text = "X"
        ' 
        ' DeletBtn
        ' 
        DeletBtn.BackColor = Color.DodgerBlue
        DeletBtn.FlatAppearance.BorderSize = 0
        DeletBtn.FlatStyle = FlatStyle.Flat
        DeletBtn.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeletBtn.ForeColor = Color.SaddleBrown
        DeletBtn.Location = New Point(440, 506)
        DeletBtn.Name = "DeletBtn"
        DeletBtn.Size = New Size(100, 55)
        DeletBtn.TabIndex = 43
        DeletBtn.Text = "Delet"
        DeletBtn.UseVisualStyleBackColor = False
        ' 
        ' EditeBtn
        ' 
        EditeBtn.BackColor = Color.DodgerBlue
        EditeBtn.FlatAppearance.BorderSize = 0
        EditeBtn.FlatStyle = FlatStyle.Flat
        EditeBtn.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EditeBtn.ForeColor = Color.SaddleBrown
        EditeBtn.Location = New Point(335, 506)
        EditeBtn.Name = "EditeBtn"
        EditeBtn.Size = New Size(87, 55)
        EditeBtn.TabIndex = 42
        EditeBtn.Text = "Edit"
        EditeBtn.UseVisualStyleBackColor = False
        ' 
        ' addBtn
        ' 
        addBtn.BackColor = Color.DodgerBlue
        addBtn.FlatAppearance.BorderSize = 0
        addBtn.FlatStyle = FlatStyle.Flat
        addBtn.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addBtn.ForeColor = Color.SaddleBrown
        addBtn.Location = New Point(213, 506)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(87, 55)
        addBtn.TabIndex = 41
        addBtn.Text = "add"
        addBtn.UseVisualStyleBackColor = False
        ' 
        ' Password
        ' 
        Password.Font = New Font("Microsoft Sans Serif", 11F)
        Password.Location = New Point(321, 422)
        Password.Name = "Password"
        Password.Size = New Size(233, 32)
        Password.TabIndex = 40
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 11F)
        Label7.ForeColor = Color.OrangeRed
        Label7.Location = New Point(195, 428)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 26)
        Label7.TabIndex = 39
        Label7.Text = "Password"
        ' 
        ' Spacialist
        ' 
        Spacialist.Font = New Font("Microsoft Sans Serif", 11F)
        Spacialist.Location = New Point(321, 371)
        Spacialist.Name = "Spacialist"
        Spacialist.Size = New Size(233, 32)
        Spacialist.TabIndex = 38
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 11F)
        Label6.ForeColor = Color.OrangeRed
        Label6.Location = New Point(200, 374)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 26)
        Label6.TabIndex = 37
        Label6.Text = "Spacialist"
        ' 
        ' Exprience
        ' 
        Exprience.Font = New Font("Microsoft Sans Serif", 11F)
        Exprience.Location = New Point(321, 275)
        Exprience.Name = "Exprience"
        Exprience.Size = New Size(233, 32)
        Exprience.TabIndex = 36
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 11F)
        Label5.ForeColor = Color.OrangeRed
        Label5.Location = New Point(200, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 26)
        Label5.TabIndex = 35
        Label5.Text = "Exprience"
        ' 
        ' DoctName
        ' 
        DoctName.Font = New Font("Microsoft Sans Serif", 11F)
        DoctName.Location = New Point(321, 217)
        DoctName.Name = "DoctName"
        DoctName.Size = New Size(233, 32)
        DoctName.TabIndex = 34
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 11F)
        Label4.ForeColor = Color.OrangeRed
        Label4.Location = New Point(191, 217)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 26)
        Label4.TabIndex = 33
        Label4.Text = "DoctName"
        ' 
        ' DoctId
        ' 
        DoctId.Font = New Font("Microsoft Sans Serif", 11F)
        DoctId.Location = New Point(321, 162)
        DoctId.Name = "DoctId"
        DoctId.Size = New Size(233, 32)
        DoctId.TabIndex = 32
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 11F)
        Label3.ForeColor = Color.OrangeRed
        Label3.Location = New Point(191, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 26)
        Label3.TabIndex = 31
        Label3.Text = "DoctorId"
        ' 
        ' DoctorDesplay
        ' 
        DoctorDesplay.BackgroundColor = Color.White
        DoctorDesplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DoctorDesplay.Location = New Point(560, 102)
        DoctorDesplay.Name = "DoctorDesplay"
        DoctorDesplay.RowHeadersWidth = 62
        DoctorDesplay.Size = New Size(675, 605)
        DoctorDesplay.TabIndex = 44
        ' 
        ' Gender
        ' 
        Gender.FormattingEnabled = True
        Gender.Items.AddRange(New Object() {"Male", "Female"})
        Gender.Location = New Point(278, 332)
        Gender.Name = "Gender"
        Gender.Size = New Size(244, 33)
        Gender.TabIndex = 45
        Gender.Text = "Gender"
        Gender.UseWaitCursor = True
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.BackColor = Color.DodgerBlue
        LogOutBtn.FlatAppearance.BorderSize = 0
        LogOutBtn.FlatStyle = FlatStyle.Flat
        LogOutBtn.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogOutBtn.ForeColor = Color.SaddleBrown
        LogOutBtn.Location = New Point(357, 597)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(122, 62)
        LogOutBtn.TabIndex = 73
        LogOutBtn.Text = "LogOut"
        LogOutBtn.UseVisualStyleBackColor = False
        ' 
        ' DoctorForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 707)
        Controls.Add(LogOutBtn)
        Controls.Add(Gender)
        Controls.Add(DoctorDesplay)
        Controls.Add(DeletBtn)
        Controls.Add(EditeBtn)
        Controls.Add(addBtn)
        Controls.Add(Password)
        Controls.Add(Label7)
        Controls.Add(Spacialist)
        Controls.Add(Label6)
        Controls.Add(Exprience)
        Controls.Add(Label5)
        Controls.Add(DoctName)
        Controls.Add(Label4)
        Controls.Add(DoctId)
        Controls.Add(Label3)
        Controls.Add(Panel2)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "DoctorForm"
        Text = "DoctorForm"
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DoctorDesplay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DeletBtn As Button
    Friend WithEvents EditeBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents Password As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Spacialist As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Exprience As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DoctName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DoctId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DoctorDesplay As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Gender As ComboBox
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
