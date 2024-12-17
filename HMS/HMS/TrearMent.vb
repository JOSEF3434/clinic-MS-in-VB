Imports System.Data.SqlClient

Public Class TrearMent
    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JOICE\source\repos\HMS\HMS\HMSDB.mdf;Integrated Security=True")
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        conn.Open()
        Dim query = "insert into TreatmentTB values(" & TreatId.Text & ",'" & TreatDisc.Text & "','" & TreatCost.Text & "')"
        Dim cmd = New SqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        MsgBox("New TreatMent  is added into Treatment Table")
        conn.Close()
        populet()
    End Sub
    Public Sub populet()
        conn.Open()
        Dim sql = "select * from TreatmentTB "
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet = New DataSet
        adapter.Fill(ds)
        TreatDesplay.DataSource = ds.Tables(0)
        conn.Close()
    End Sub

    Private Sub TrearMent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populet()
    End Sub

    Private Sub DeletBtn_Click(sender As Object, e As EventArgs) Handles DeletBtn.Click
        If TreatId.Text = "" Then
            MsgBox("Enter treatment id")
        Else
            conn.Open()
            Dim query As String = "delete from TreatmentTB Where TreatId =" & TreatId.Text & ""
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("One Row  is deleted SuccessFully in Treatment list")
            conn.Close()
            populet()
        End If
    End Sub

    Private Sub EditeBtn_Click(sender As Object, e As EventArgs) Handles EditeBtn.Click
        If String.IsNullOrWhiteSpace(TreatId.Text) Then
            MsgBox("Incomplete Information")
        Else
            Try
                conn.Open()
                Dim cmd As New SqlCommand("UPDATE TreatmentTB SET TreatDisc = @TreatDisc, TreatCost = @TreatCost WHERE TreatId = @TreatId", conn)
                cmd.Parameters.AddWithValue("@TreatDisc", TreatDisc.Text)
                cmd.Parameters.AddWithValue("@TreatCost", TreatCost.Text)
                cmd.Parameters.AddWithValue("@TreatId", TreatId.Text)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("One row updated successfully in Treatment List")
                Else
                    MsgBox("No rows were updated. Please check the TreatId.")
                End If
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            Finally
                conn.Close()
            End Try
            populet()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DoctorForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PecientForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DiagnosisForm.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        LogInPage.Show()
        Me.Hide()
    End Sub
End Class