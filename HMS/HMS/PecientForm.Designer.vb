﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PecientForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PecientForm))
        Panel2 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Button2 = New Button()
        Gender = New ComboBox()
        DiagnosisDesplay = New DataGridView()
        DeletBtn = New Button()
        EditeBtn = New Button()
        addBtn = New Button()
        Diseas = New TextBox()
        Label7 = New Label()
        Age = New TextBox()
        Label5 = New Label()
        PacieName = New TextBox()
        Label4 = New Label()
        PacieId = New TextBox()
        Label3 = New Label()
        BloodGroup = New ComboBox()
        LogOutBtn = New Button()
        PictureBox1 = New PictureBox()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DiagnosisDesplay, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(216, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(975, 48)
        Panel2.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(931, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 38)
        Label1.TabIndex = 3
        Label1.Text = "X"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Firebrick
        Label2.Location = New Point(508, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(324, 38)
        Label2.TabIndex = 15
        Label2.Text = "PATIENT MANAGMENT"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(216, 681)
        Panel1.TabIndex = 14
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DodgerBlue
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.SaddleBrown
        Button2.Location = New Point(0, 228)
        Button2.Name = "Button2"
        Button2.Size = New Size(213, 55)
        Button2.TabIndex = 1
        Button2.Text = "Reception"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Gender
        ' 
        Gender.FormattingEnabled = True
        Gender.Items.AddRange(New Object() {"Male", "Female"})
        Gender.Location = New Point(311, 326)
        Gender.Name = "Gender"
        Gender.Size = New Size(244, 33)
        Gender.TabIndex = 60
        Gender.Text = "Gender"
        Gender.UseWaitCursor = True
        ' 
        ' DiagnosisDesplay
        ' 
        DiagnosisDesplay.BackgroundColor = Color.White
        DiagnosisDesplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DiagnosisDesplay.Location = New Point(603, 118)
        DiagnosisDesplay.Name = "DiagnosisDesplay"
        DiagnosisDesplay.RowHeadersWidth = 62
        DiagnosisDesplay.Size = New Size(581, 563)
        DiagnosisDesplay.TabIndex = 59
        ' 
        ' DeletBtn
        ' 
        DeletBtn.BackColor = Color.DodgerBlue
        DeletBtn.FlatAppearance.BorderSize = 0
        DeletBtn.FlatStyle = FlatStyle.Flat
        DeletBtn.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeletBtn.ForeColor = Color.SaddleBrown
        DeletBtn.Location = New Point(473, 500)
        DeletBtn.Name = "DeletBtn"
        DeletBtn.Size = New Size(100, 55)
        DeletBtn.TabIndex = 58
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
        EditeBtn.Location = New Point(368, 500)
        EditeBtn.Name = "EditeBtn"
        EditeBtn.Size = New Size(87, 55)
        EditeBtn.TabIndex = 57
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
        addBtn.Location = New Point(246, 500)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(87, 55)
        addBtn.TabIndex = 56
        addBtn.Text = "add"
        addBtn.UseVisualStyleBackColor = False
        ' 
        ' Diseas
        ' 
        Diseas.Font = New Font("Microsoft Sans Serif", 11F)
        Diseas.Location = New Point(354, 416)
        Diseas.Name = "Diseas"
        Diseas.Size = New Size(233, 32)
        Diseas.TabIndex = 55
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 11F)
        Label7.ForeColor = Color.OrangeRed
        Label7.Location = New Point(228, 422)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 26)
        Label7.TabIndex = 54
        Label7.Text = "Diseas"
        ' 
        ' Age
        ' 
        Age.Font = New Font("Microsoft Sans Serif", 11F)
        Age.Location = New Point(354, 269)
        Age.Name = "Age"
        Age.Size = New Size(233, 32)
        Age.TabIndex = 51
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 11F)
        Label5.ForeColor = Color.OrangeRed
        Label5.Location = New Point(233, 269)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 26)
        Label5.TabIndex = 50
        Label5.Text = "Age"
        ' 
        ' PacieName
        ' 
        PacieName.Font = New Font("Microsoft Sans Serif", 11F)
        PacieName.Location = New Point(354, 211)
        PacieName.Name = "PacieName"
        PacieName.Size = New Size(233, 32)
        PacieName.TabIndex = 49
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 11F)
        Label4.ForeColor = Color.OrangeRed
        Label4.Location = New Point(224, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 26)
        Label4.TabIndex = 48
        Label4.Text = "PacieName"
        ' 
        ' PacieId
        ' 
        PacieId.Font = New Font("Microsoft Sans Serif", 11F)
        PacieId.Location = New Point(354, 156)
        PacieId.Name = "PacieId"
        PacieId.Size = New Size(233, 32)
        PacieId.TabIndex = 47
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 11F)
        Label3.ForeColor = Color.OrangeRed
        Label3.Location = New Point(224, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 26)
        Label3.TabIndex = 46
        Label3.Text = "PatientId"
        ' 
        ' BloodGroup
        ' 
        BloodGroup.FormattingEnabled = True
        BloodGroup.Items.AddRange(New Object() {"A", "A+", "B", "B+", "AB", "AB+", "O", "O-", "O+"})
        BloodGroup.Location = New Point(311, 373)
        BloodGroup.Name = "BloodGroup"
        BloodGroup.Size = New Size(244, 33)
        BloodGroup.TabIndex = 61
        BloodGroup.Text = "BloodGroup"
        BloodGroup.UseWaitCursor = True
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.BackColor = Color.DodgerBlue
        LogOutBtn.FlatAppearance.BorderSize = 0
        LogOutBtn.FlatStyle = FlatStyle.Flat
        LogOutBtn.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogOutBtn.ForeColor = Color.SaddleBrown
        LogOutBtn.Location = New Point(392, 572)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(118, 55)
        LogOutBtn.TabIndex = 73
        LogOutBtn.Text = "LogOut "
        LogOutBtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(-3, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(216, 201)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PecientForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1191, 681)
        Controls.Add(LogOutBtn)
        Controls.Add(BloodGroup)
        Controls.Add(Gender)
        Controls.Add(DiagnosisDesplay)
        Controls.Add(DeletBtn)
        Controls.Add(EditeBtn)
        Controls.Add(addBtn)
        Controls.Add(Diseas)
        Controls.Add(Label7)
        Controls.Add(Age)
        Controls.Add(Label5)
        Controls.Add(PacieName)
        Controls.Add(Label4)
        Controls.Add(PacieId)
        Controls.Add(Label3)
        Controls.Add(Panel2)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "PecientForm"
        Text = "PecientForm"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(DiagnosisDesplay, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Gender As ComboBox
    Friend WithEvents DiagnosisDesplay As DataGridView
    Friend WithEvents DeletBtn As Button
    Friend WithEvents EditeBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents Diseas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Age As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PacieName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PacieId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BloodGroup As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
