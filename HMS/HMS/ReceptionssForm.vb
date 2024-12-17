Imports System.Data.SqlClient
Public Class ReceptionssForm
    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JOICE\source\repos\HMS\HMS\HMSDB.mdf;Integrated Security=True")
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        conn.Open
        Dim query = "insert into ReceptionTB values(" & RecepId.Text & ",'" & RecepName.Text & "','" & Password.Text & "','" & Phone.Text & "','" & address.Text & "')"
        Dim cmd = New SqlCommand(query, conn)
        cmd.ExecuteNonQuery
        MsgBox("New Reception is added into Receptionist Table")
        conn.Close
        populet
    End Sub
    Public Sub populet()
        conn.Open()
        Dim sql = "select * from ReceptionTB "
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet = New DataSet
        adapter.Fill(ds)
        ReceptionistDesplay.DataSource = ds.Tables(0)
        conn.Close()
    End Sub
    Private Sub ReceptionistDesplay_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReceptionistDesplay.CellContentClick

    End Sub

    Private Sub ReceptionssForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populet()
    End Sub

    Private Sub DeletBtn_Click(sender As Object, e As EventArgs) Handles DeletBtn.Click
        If RecepId.Text = "" Then
            MsgBox("Enter Receptionst id")
        Else
            conn.Open()
            Dim query As String = "delete from ReceptionTB Where RecepId =" & RecepId.Text & ""
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("One Row is delete SuccessFully in Reciptionist list")
            conn.Close()
            populet()
        End If
    End Sub

    Private Sub EditeBtn_Click(sender As Object, e As EventArgs) Handles EditeBtn.Click
        If RecepId.Text = "" Or RecepName.Text = "" Or Password.Text = "" Or Phone.Text = "" Or address.Text = "" Then
            MsgBox("In Complet Information")
        Else
            conn.Open()
            ' Dim query As String = "delete from ReceptionTB Where RecepId =" & RecepId.Text & ""
            Dim cmd As New SqlCommand("update ReceptionTB set RecepName='" & RecepName.Text & "',Password ='" & Password.Text & "', Phone = '" & Phone.Text & "',address = '" & address.Text & "' where RecepId = '" & RecepId.Text & "' ", conn)
            cmd.ExecuteNonQuery()
            MsgBox("One Row is update SuccessFully In Reception List")
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

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        LogInPage.Show()
        Me.Hide()
    End Sub
End Class