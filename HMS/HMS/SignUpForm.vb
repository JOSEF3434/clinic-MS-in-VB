Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class SignUpForm
    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JOICE\source\repos\HMS\HMS\HMSDB.mdf;Integrated Security=True")
    Private Sub SignUpBtn_Click(sender As Object, e As EventArgs) Handles SignUpBtn.Click
        conn.Open()
        Dim query As String = "insert into SinUpTB values(" & UserId.Text & ",'" & Role.Text & "','" & UserName.Text & "','" & UserEmail.Text & "','" & Password.Text & "')"
        Dim cmd As SqlCommand = New SqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        MsgBox("SignUp SuccessFully")
        LogInPage.Show()
        Me.Hide()
        conn.Close()
        'populet()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        LogInPage.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Application.Exit()
    End Sub
End Class