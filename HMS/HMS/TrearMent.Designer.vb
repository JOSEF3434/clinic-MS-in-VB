﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrearMent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrearMent))
        Panel2 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TreatDesplay = New DataGridView()
        DeletBtn = New Button()
        EditeBtn = New Button()
        addBtn = New Button()
        TreatCost = New TextBox()
        Label5 = New Label()
        TreatDisc = New TextBox()
        Label4 = New Label()
        TreatId = New TextBox()
        Label3 = New Label()
        LogOutBtn = New Button()
        PictureBox1 = New PictureBox()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(TreatDesplay, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(167, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1027, 48)
        Panel2.TabIndex = 13
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
        Label2.Location = New Point(452, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(374, 38)
        Label2.TabIndex = 12
        Label2.Text = "TREATMENT MANAGMENT"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(167, 707)
        Panel1.TabIndex = 11
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DodgerBlue
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.SaddleBrown
        Button4.Location = New Point(-3, 251)
        Button4.Name = "Button4"
        Button4.Size = New Size(213, 55)
        Button4.TabIndex = 3
        Button4.Text = "Doctor"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DodgerBlue
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.SaddleBrown
        Button2.Location = New Point(-3, 373)
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
        Button1.Location = New Point(-3, 312)
        Button1.Name = "Button1"
        Button1.Size = New Size(213, 55)
        Button1.TabIndex = 0
        Button1.Text = "Patients"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TreatDesplay
        ' 
        TreatDesplay.BackgroundColor = Color.White
        TreatDesplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TreatDesplay.Location = New Point(496, 119)
        TreatDesplay.Name = "TreatDesplay"
        TreatDesplay.RowHeadersWidth = 62
        TreatDesplay.Size = New Size(686, 588)
        TreatDesplay.TabIndex = 59
        ' 
        ' DeletBtn
        ' 
        DeletBtn.BackColor = Color.DodgerBlue
        DeletBtn.FlatAppearance.BorderSize = 0
        DeletBtn.FlatStyle = FlatStyle.Flat
        DeletBtn.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeletBtn.ForeColor = Color.White
        DeletBtn.Location = New Point(371, 532)
        DeletBtn.Name = "DeletBtn"
        DeletBtn.Size = New Size(95, 55)
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
        EditeBtn.ForeColor = Color.White
        EditeBtn.Location = New Point(265, 532)
        EditeBtn.Name = "EditeBtn"
        EditeBtn.Size = New Size(83, 55)
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
        addBtn.ForeColor = Color.White
        addBtn.Location = New Point(188, 532)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(71, 55)
        addBtn.TabIndex = 56
        addBtn.Text = "add"
        addBtn.UseVisualStyleBackColor = False
        ' 
        ' TreatCost
        ' 
        TreatCost.Font = New Font("Microsoft Sans Serif", 11F)
        TreatCost.Location = New Point(306, 356)
        TreatCost.Name = "TreatCost"
        TreatCost.Size = New Size(184, 32)
        TreatCost.TabIndex = 51
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 11F)
        Label5.ForeColor = Color.DodgerBlue
        Label5.Location = New Point(185, 356)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 26)
        Label5.TabIndex = 50
        Label5.Text = "Cost"
        ' 
        ' TreatDisc
        ' 
        TreatDisc.Font = New Font("Microsoft Sans Serif", 11F)
        TreatDisc.Location = New Point(306, 298)
        TreatDisc.Name = "TreatDisc"
        TreatDisc.Size = New Size(184, 32)
        TreatDisc.TabIndex = 49
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 11F)
        Label4.ForeColor = Color.DodgerBlue
        Label4.Location = New Point(176, 298)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 26)
        Label4.TabIndex = 48
        Label4.Text = "Description"
        ' 
        ' TreatId
        ' 
        TreatId.Font = New Font("Microsoft Sans Serif", 11F)
        TreatId.Location = New Point(306, 243)
        TreatId.Name = "TreatId"
        TreatId.Size = New Size(184, 32)
        TreatId.TabIndex = 47
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 11F)
        Label3.ForeColor = Color.DodgerBlue
        Label3.Location = New Point(176, 246)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 26)
        Label3.TabIndex = 46
        Label3.Text = "TreatmentId"
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.BackColor = Color.DodgerBlue
        LogOutBtn.FlatAppearance.BorderSize = 0
        LogOutBtn.FlatStyle = FlatStyle.Flat
        LogOutBtn.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogOutBtn.ForeColor = Color.White
        LogOutBtn.Location = New Point(324, 615)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(129, 73)
        LogOutBtn.TabIndex = 60
        LogOutBtn.Text = "LogOut"
        LogOutBtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(164, 209)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' TrearMent
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1194, 707)
        Controls.Add(LogOutBtn)
        Controls.Add(TreatDesplay)
        Controls.Add(DeletBtn)
        Controls.Add(EditeBtn)
        Controls.Add(addBtn)
        Controls.Add(TreatCost)
        Controls.Add(Label5)
        Controls.Add(TreatDisc)
        Controls.Add(Label4)
        Controls.Add(TreatId)
        Controls.Add(Label3)
        Controls.Add(Panel2)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "TrearMent"
        Text = "TrearMent"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(TreatDesplay, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TreatDesplay As DataGridView
    Friend WithEvents DeletBtn As Button
    Friend WithEvents EditeBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents TreatCost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TreatDisc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TreatId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
