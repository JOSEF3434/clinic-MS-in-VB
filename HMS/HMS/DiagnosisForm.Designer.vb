<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiagnosisForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiagnosisForm))
        Panel2 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Treatment = New ComboBox()
        PacientId = New ComboBox()
        DeletBtn = New Button()
        EditeBtn = New Button()
        addBtn = New Button()
        Cost = New TextBox()
        Label7 = New Label()
        Diagnosis = New TextBox()
        Label5 = New Label()
        DiagnId = New TextBox()
        Label3 = New Label()
        PacieName = New TextBox()
        Label6 = New Label()
        Symptom = New TextBox()
        Label8 = New Label()
        Madicin = New TextBox()
        Label9 = New Label()
        DiagnDesplay = New DataGridView()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Button3 = New Button()
        LogOutBtn = New Button()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DiagnDesplay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(149, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1181, 48)
        Panel2.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(1088, 10)
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
        Label2.Location = New Point(533, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 38)
        Label2.TabIndex = 18
        Label2.Text = "DIAGNOSIS"
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
        Panel1.Size = New Size(149, 655)
        Panel1.TabIndex = 17
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(149, 178)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DodgerBlue
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.SaddleBrown
        Button4.Location = New Point(-25, 251)
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
        Button2.Location = New Point(-25, 373)
        Button2.Name = "Button2"
        Button2.Size = New Size(213, 55)
        Button2.TabIndex = 1
        Button2.Text = "Treatment"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DodgerBlue
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.SaddleBrown
        Button1.Location = New Point(-25, 312)
        Button1.Name = "Button1"
        Button1.Size = New Size(213, 55)
        Button1.TabIndex = 0
        Button1.Text = "Patients"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Treatment
        ' 
        Treatment.FormattingEnabled = True
        Treatment.Items.AddRange(New Object() {"A", "A+", "B", "B+", "AB", "AB+", "O", "O-", "O+"})
        Treatment.Location = New Point(257, 441)
        Treatment.Name = "Treatment"
        Treatment.Size = New Size(244, 33)
        Treatment.TabIndex = 75
        Treatment.Text = "Treatment"
        Treatment.UseWaitCursor = True
        ' 
        ' PacientId
        ' 
        PacientId.FormattingEnabled = True
        PacientId.Items.AddRange(New Object() {"Male", "Female"})
        PacientId.Location = New Point(251, 200)
        PacientId.Name = "PacientId"
        PacientId.Size = New Size(244, 33)
        PacientId.TabIndex = 74
        PacientId.Text = "PacientId"
        PacientId.UseWaitCursor = True
        ' 
        ' DeletBtn
        ' 
        DeletBtn.BackColor = Color.DodgerBlue
        DeletBtn.FlatAppearance.BorderSize = 0
        DeletBtn.FlatStyle = FlatStyle.Flat
        DeletBtn.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeletBtn.ForeColor = Color.SaddleBrown
        DeletBtn.Location = New Point(386, 518)
        DeletBtn.Name = "DeletBtn"
        DeletBtn.Size = New Size(100, 55)
        DeletBtn.TabIndex = 72
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
        EditeBtn.Location = New Point(278, 518)
        EditeBtn.Name = "EditeBtn"
        EditeBtn.Size = New Size(87, 55)
        EditeBtn.TabIndex = 71
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
        addBtn.Location = New Point(172, 518)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(87, 55)
        addBtn.TabIndex = 70
        addBtn.Text = "add"
        addBtn.UseVisualStyleBackColor = False
        ' 
        ' Cost
        ' 
        Cost.Font = New Font("Microsoft Sans Serif", 11F)
        Cost.Location = New Point(269, 480)
        Cost.Name = "Cost"
        Cost.Size = New Size(233, 32)
        Cost.TabIndex = 69
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 11F)
        Label7.ForeColor = Color.OrangeRed
        Label7.Location = New Point(155, 480)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 26)
        Label7.TabIndex = 68
        Label7.Text = "Cost"
        ' 
        ' Diagnosis
        ' 
        Diagnosis.Font = New Font("Microsoft Sans Serif", 11F)
        Diagnosis.Location = New Point(269, 396)
        Diagnosis.Name = "Diagnosis"
        Diagnosis.Size = New Size(233, 32)
        Diagnosis.TabIndex = 67
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 11F)
        Label5.ForeColor = Color.OrangeRed
        Label5.Location = New Point(155, 396)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 26)
        Label5.TabIndex = 66
        Label5.Text = "Diagnosis"
        ' 
        ' DiagnId
        ' 
        DiagnId.Font = New Font("Microsoft Sans Serif", 11F)
        DiagnId.Location = New Point(269, 146)
        DiagnId.Name = "DiagnId"
        DiagnId.Size = New Size(233, 32)
        DiagnId.TabIndex = 63
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 11F)
        Label3.ForeColor = Color.OrangeRed
        Label3.Location = New Point(152, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 26)
        Label3.TabIndex = 62
        Label3.Text = "DiagnosisId"
        ' 
        ' PacieName
        ' 
        PacieName.Enabled = False
        PacieName.Font = New Font("Microsoft Sans Serif", 11F)
        PacieName.Location = New Point(269, 239)
        PacieName.Name = "PacieName"
        PacieName.Size = New Size(233, 32)
        PacieName.TabIndex = 77
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 11F)
        Label6.ForeColor = Color.OrangeRed
        Label6.Location = New Point(152, 242)
        Label6.Name = "Label6"
        Label6.Size = New Size(126, 26)
        Label6.TabIndex = 76
        Label6.Text = "PacieName"
        ' 
        ' Symptom
        ' 
        Symptom.Font = New Font("Microsoft Sans Serif", 11F)
        Symptom.Location = New Point(269, 287)
        Symptom.Name = "Symptom"
        Symptom.Size = New Size(233, 32)
        Symptom.TabIndex = 81
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 11F)
        Label8.ForeColor = Color.OrangeRed
        Label8.Location = New Point(152, 290)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 26)
        Label8.TabIndex = 80
        Label8.Text = "Symptom"
        ' 
        ' Madicin
        ' 
        Madicin.Font = New Font("Microsoft Sans Serif", 11F)
        Madicin.Location = New Point(269, 329)
        Madicin.Name = "Madicin"
        Madicin.Size = New Size(233, 32)
        Madicin.TabIndex = 79
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 11F)
        Label9.ForeColor = Color.OrangeRed
        Label9.Location = New Point(152, 346)
        Label9.Name = "Label9"
        Label9.Size = New Size(98, 26)
        Label9.TabIndex = 78
        Label9.Text = "Medicins"
        ' 
        ' DiagnDesplay
        ' 
        DiagnDesplay.BackgroundColor = Color.White
        DiagnDesplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DiagnDesplay.Location = New Point(508, 93)
        DiagnDesplay.Name = "DiagnDesplay"
        DiagnDesplay.RowHeadersWidth = 62
        DiagnDesplay.Size = New Size(810, 517)
        DiagnDesplay.TabIndex = 82
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DodgerBlue
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.SaddleBrown
        Button3.Location = New Point(749, 616)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 55)
        Button3.TabIndex = 83
        Button3.Text = "Print"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' LogOutBtn
        ' 
        LogOutBtn.BackColor = Color.DodgerBlue
        LogOutBtn.FlatAppearance.BorderSize = 0
        LogOutBtn.FlatStyle = FlatStyle.Flat
        LogOutBtn.Font = New Font("Franklin Gothic Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogOutBtn.ForeColor = Color.SaddleBrown
        LogOutBtn.Location = New Point(346, 588)
        LogOutBtn.Name = "LogOutBtn"
        LogOutBtn.Size = New Size(117, 55)
        LogOutBtn.TabIndex = 84
        LogOutBtn.Text = "LogOut "
        LogOutBtn.UseVisualStyleBackColor = False
        ' 
        ' DiagnosisForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1330, 655)
        Controls.Add(LogOutBtn)
        Controls.Add(Button3)
        Controls.Add(DiagnDesplay)
        Controls.Add(Symptom)
        Controls.Add(Label8)
        Controls.Add(Madicin)
        Controls.Add(Label9)
        Controls.Add(PacieName)
        Controls.Add(Label6)
        Controls.Add(Treatment)
        Controls.Add(PacientId)
        Controls.Add(DeletBtn)
        Controls.Add(EditeBtn)
        Controls.Add(addBtn)
        Controls.Add(Cost)
        Controls.Add(Label7)
        Controls.Add(Diagnosis)
        Controls.Add(Label5)
        Controls.Add(DiagnId)
        Controls.Add(Label3)
        Controls.Add(Panel2)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "DiagnosisForm"
        Text = "DiagnosisForm"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DiagnDesplay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Treatment As ComboBox
    Friend WithEvents PacientId As ComboBox
    Friend WithEvents DiagnosisDesplay As DataGridView
    Friend WithEvents DeletBtn As Button
    Friend WithEvents EditeBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents Cost As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Diagnosis As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DiagnId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PacieName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Symptom As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Madicin As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DiagnDesplay As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents LogOutBtn As Button
End Class
