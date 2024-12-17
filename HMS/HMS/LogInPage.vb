Imports System.Data.SqlClient

Public Class LogInPage
    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub LogInPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide the password by default
        Password.UseSystemPasswordChar = True
    End Sub

    Private Sub LogInBtn_Click(sender As Object, e As EventArgs) Handles LogInBtn.Click
        Dim connString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JOICE\source\repos\HMS\HMS\HMSDB.mdf;Integrated Security=True"

        Using conn As New SqlConnection(connString)
            Dim query = "SELECT * FROM SinUpTB WHERE Role = @Role AND UserName = @UserName AND Password = @Password"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Role", Role.SelectedItem)
                cmd.Parameters.AddWithValue("@UserName", UserName.Text)
                cmd.Parameters.AddWithValue("@Password", Password.Text)

                Dim sdt As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                conn.Open()
                sdt.Fill(dt)

                If dt.Rows.Count > 0 Then
                    MsgBox("You Are Logged in as " & dt.Rows(0)("Role").ToString)
                    If Role.SelectedIndex = 0 Then
                        Dim doctorForm As New DoctorForm
                        doctorForm.Show()
                    Else
                        Dim receptionForm As New ReceptionssForm
                        receptionForm.Show()
                    End If
                    Hide()
                Else
                    MsgBox("Login failed. Please check your credentials.")
                End If
            End Using
        End Using
    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ChBox.CheckedChanged
        If ChBox.Checked Then
            Password.UseSystemPasswordChar = False ' Show password
        Else
            Password.UseSystemPasswordChar = True ' Hide password
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles CanslBtn.Click
        UserName.Text = String.Empty
        Password.Text = String.Empty
        Role.SelectedIndex = -1 ' Deselect any selected role
        ChBox.Checked = False ' Uncheck the checkbox
        Password.UseSystemPasswordChar = True ' Ensure password is hidden
    End Sub
    Private Sub SignUpBtn_Click(sender As Object, e As EventArgs) Handles SignUpBtn.Click
        SignUpForm.Show()
        Me.Hide()
    End Sub
End Class