Imports System.Data.SqlClient
Imports System.Net

Public Class PecientForm
    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JOICE\source\repos\HMS\HMS\HMSDB.mdf;Integrated Security=True")
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        conn.Open()
        Dim query As String = "insert into PatientTB values(" & PacieId.Text & ",'" & PacieName.Text & "','" & Age.Text & "','" & Gender.Text & "','" & BloodGroup.Text & "','" & Diseas.Text & "')"
        Dim cmd As SqlCommand = New SqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        MsgBox("New Patient is added into Pctient Table")
        conn.Close()
        populet()
    End Sub
    Public Sub populet()
        conn.Open()
        Dim sql = "select * from PatientTB "
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet = New DataSet
        adapter.Fill(ds)
        DiagnosisDesplay.DataSource = ds.Tables(0)
        conn.Close()
    End Sub
    Private Sub DeletBtn_Click(sender As Object, e As EventArgs) Handles DeletBtn.Click
        If PacieId.Text = "" Then
            MsgBox("Enter Pacient id")
        Else
            conn.Open()
            Dim query As String = "delete from PatientTB Where PacieId =" & PacieId.Text & ""
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("One Row  is deleted SuccessFully in Pcient list")
            conn.Close()
            populet()
        End If
    End Sub

    Private Sub PecientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populet()
    End Sub

    Private Sub EditeBtn_Click(sender As Object, e As EventArgs) Handles EditeBtn.Click
        If PacieId.Text = "" Or PacieName.Text = "" Or Age.Text = "" Or Gender.Text = "" Or BloodGroup.Text = "" Or Diseas.Text = "" Then
            MsgBox("In Complet Information")
        Else
            conn.Open()
            Dim cmd As New SqlCommand("update PatientTB set PacieName ='" & PacieName.Text & "',Age ='" & Age.Text & "', Gender = '" & Gender.Text & "',BloodGroup = '" & BloodGroup.Text & "',Diseas ='" & Diseas.Text & "' where PacieId = '" & PacieId.Text & "' ", conn)
            cmd.ExecuteNonQuery()
            MsgBox("One Row is update SuccessFully In Pacient List")
            conn.Close()
            populet()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReceptionssForm.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        LogInPage.Show()
        Me.Hide()
    End Sub
End Class