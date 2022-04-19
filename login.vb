Option Explicit On
Option Strict On
Option Infer Off

Imports System.Data.SqlClient
Imports System.IO
Public Class login



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        label_time.Text = DateTime.Now.ToString("F")
        ' Shows a splash screen depicting
        ' Along with Date / Time
        ' Name at time
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim db As String = Path.Combine(Directory.GetCurrentDirectory(), "Vet-Clinic-RH.mdf")
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & (db) & ";Integrated Security=True")
        Using cmd As New SqlCommand("select * from login where username = @username and pass = @pass", connection)

            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text)
            Dim adapter As New SqlDataAdapter(cmd)

            connection.Open()
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            adapter.Fill(dt)

            connection.Close()
            If dt.Rows.Count <= 0 Then
                MessageBox.Show("Username or Password are Invalid")
                txtUsername.Clear()
                txtPassword.Clear()
            Else
                Me.Hide()
                frmMain.Show()
                frmMain.loginUser.Text = txtUsername.Text
                txtUsername.Clear()
                txtPassword.Clear()




            End If

        End Using


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure you wish to exit?",
                           "Exiting login...", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class