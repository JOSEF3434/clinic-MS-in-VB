Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class DiagnosisForm
    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JOICE\source\repos\HMS\HMS\HMSDB.mdf;Integrated Security=True")
    Public Property DiagnosisDesplay As Object

    Public Sub FillPacieIdCombo()
        conn.Open()
        Dim sql = "select * from PatientTB "
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        Dim ds As DataTable = New DataTable()
        adapter.Fill(ds)
        PacientId.DataSource = ds
        PacientId.DisplayMember = "PacieId"
        PacientId.ValueMember = "PacieId"
        conn.Close()
    End Sub
    Public Sub FillTreatMentIdCombo()
        conn.Open()
        Dim cmd As New SqlCommand("select * from TreatmentTB", conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim ds As New DataTable()
        adapter.Fill(ds)
        Treatment.DataSource = ds
        Treatment.DisplayMember = "TreatDisc"
        Treatment.ValueMember = "Treatdisc"
        conn.Close()
    End Sub
    Public Sub populet()
        conn.Open()
        Dim sql = "select * from DiagnosisTB "
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet = New DataSet
        adapter.Fill(ds)
        DiagnDesplay.DataSource = ds.Tables(0)
        conn.Close()
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Try
            ' Ensure the connection is open
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Prepare the SQL query using parameters
            Dim query As String = "INSERT INTO DiagnosisTB (DiagnId, PacientId, PacieName, Symptom, Madicin, Diagnosis, Treatment, Cost) VALUES (@DiagnId, @PacientId, @PacieName, @Symptom, @Madicin, @Diagnosis, @Treatment, @Cost)"

            Using cmd As New SqlCommand(query, conn)
                ' Add parameters with values
                cmd.Parameters.AddWithValue("@DiagnId", DiagnId.Text)
                cmd.Parameters.AddWithValue("@PacientId", PacientId.SelectedValue)
                cmd.Parameters.AddWithValue("@PacieName", PacieName.Text)
                cmd.Parameters.AddWithValue("@Symptom", Symptom.Text)
                cmd.Parameters.AddWithValue("@Madicin", Madicin.Text)
                cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis.Text)
                cmd.Parameters.AddWithValue("@Treatment", Treatment.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@Cost", Cost.Text)

                ' Execute the command
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("New row added into Diagnosis Table")
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        populet()
    End Sub


    Private Sub DiagnosisForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillPacieIdCombo()
        FillTreatMentIdCombo()
        populet()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub
    Private Sub Treatment_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Treatment.SelectionChangeCommitted
        conn.Open()
        Dim query = "select * from TreatmentTB where TreatDisc = '" & Treatment.SelectedValue.ToString() & "'"
        Dim cmd As New SqlCommand(query, conn)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            Cost.Text = reader(2)
        End While
        conn.Close()
    End Sub

    Private Sub PacieId_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles PacientId.SelectionChangeCommitted
        conn.Open()
        Dim query = "select * from PatientTB where PacieId = " & PacientId.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, conn)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            PacieName.Text = reader(1)
        End While
        conn.Close()
    End Sub

    Private Sub EditeBtn_Click(sender As Object, e As EventArgs) Handles EditeBtn.Click
        If DiagnId.Text = "" Or PacieName.Text = "" Or Symptom.Text = "" Or Madicin.Text = "" Or Diagnosis.Text = "" Or Treatment.Text = "" Or Cost.Text = "" Then
            MsgBox("In Complet Information")
        Else
            conn.Open()
            Dim cmd As New SqlCommand("update DiagnosisTB set PacientId='" & PacientId.Text & "',PacieName ='" & PacieName.Text & "', Symptom = '" & Symptom.Text & "',Madicin = '" & Madicin.Text & "',Diagnosis = '" & Diagnosis.Text & "',Treatment = '" & Treatment.Text & "',Cost = '" & Cost.Text & "' where DiagnId = '" & DiagnId.Text & "' ", conn)
            cmd.ExecuteNonQuery()
            MsgBox("One Row is updated SuccessFully IN Diagnosis List")
            conn.Close()
            populet()
        End If
    End Sub

    Private Sub DeletBtn_Click(sender As Object, e As EventArgs) Handles DeletBtn.Click
        If DiagnId.Text = "" Then
            MsgBox("Enter Diagnosis id")
        Else
            conn.Open()
            Dim query = "delete from DiagnosisTB Where DiagnId =" & DiagnId.Text & ""
            Dim cmd = New SqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("ONE RoW  is deleted SuccessFully in Diagnosis list")
            conn.Close()
            populet()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Set up font and brush
        Dim font As New Font("Century Gothic", 14)
        Dim brush As New SolidBrush(Color.Crimson)

        ' Draw the diagnosis title
        e.Graphics.DrawString("Diagnosis", font, brush, 250, 40)

        ' Additional text to print
        Dim diagnosisDetails As String = "Patient shows signs of improvement." & vbCrLf &
                                          "Recommended follow-up in two weeks."
        Dim detailsFont As New Font("Arial", 12)

        ' Draw the diagnosis details
        e.Graphics.DrawString(diagnosisDetails, detailsFont, Brushes.Black, 50, 100)

        ' Indicate that there are no more pages to print
        e.HasMorePages = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintPreviewDialog1.Show()
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
        TrearMent.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        LogInPage.Show()
        Me.Hide()
    End Sub
End Class