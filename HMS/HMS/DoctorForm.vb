Imports System.Data.SqlClient
Imports System.Net

Public Class DoctorForm
    Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JOICE\source\repos\HMS\HMS\HMSDB.mdf;Integrated Security=True")
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        conn.Open()
        Dim query As String = "insert into DoctorTB values(" & DoctId.Text & ",'" & DoctName.Text & "','" & Exprience.Text & "','" & Gender.Text & "','" & Spacialist.Text & "','" & Password.Text & "')"
        Dim cmd As SqlCommand = New SqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        MsgBox("New Doctor is added into Doctor Table")
        conn.Close()
        populet()
    End Sub
    Public Sub populet()
        conn.Open()
        Dim sql = "select * from DoctorTB "
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet = New DataSet
        adapter.Fill(ds)
        DoctorDesplay.DataSource = ds.Tables(0)
        conn.Close()
    End Sub

    Private Sub DoctorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populet()
    End Sub

    Private Sub DeletBtn_Click(sender As Object, e As EventArgs) Handles DeletBtn.Click
        If DoctId.Text = "" Then
            MsgBox("Enter Doctor id")
        Else
            conn.Open()
            Dim query As String = "delete from DoctorTB Where DoctId =" & DoctId.Text & ""
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Ro  is deleted SuccessFully in Doctor list")
            conn.Close()
            populet()
        End If
    End Sub

    Private Sub EditeBtn_Click(sender As Object, e As EventArgs) Handles EditeBtn.Click
        If DoctId.Text = "" Or DoctName.Text = "" Or Password.Text = "" Or Exprience.Text = "" Or Gender.Text = "" Or Spacialist.Text = "" Then
            MsgBox("In Complet Information")
        Else
            conn.Open()
            ' Dim query As String = "delete from ReceptionTB Where RecepId =" & RecepId.Text & ""
            Dim cmd As New SqlCommand("update DoctorTB set DoctName='" & DoctName.Text & "',Password ='" & Password.Text & "', Gender = '" & Gender.Text & "',Spacialist = '" & Spacialist.Text & "',Exprience = '" & Exprience.Text & "' where DoctId = '" & DoctId.Text & "' ", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Doctor List  is updated SuccessFully")
            conn.Close()
            populet()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PecientForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DiagnosisForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TrearMent.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        LogInPage.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class