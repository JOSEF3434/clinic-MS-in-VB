Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MyProgressBar.Increment(1)
        If MyProgressBar.Value = 100 Then
            Me.Hide()
            Dim log = New LogInPage
            log.Show()
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Application.Exit()
    End Sub

    Private Sub Guna2CircleProgressBar1_ValueChanged(sender As Object, e As EventArgs) Handles MyProgressBar.ValueChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        MyProgressBar.ProgressColor = Color.Red

    End Sub
End Class
