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
        Dim db As String = Path.Combine(Directory.GetCurrentDirectory(), "VBvetProject.mdf")
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & (db) & ";Integrated Security=True")
        Dim command As New SqlCommand("select * from login where user_name = @username and pass_word = @pass", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUsername.Text
        command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text
        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()
        adapter.Fill(table)


        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username or Password are Invalid")

        Else
            Me.Hide()
            frmMain.Show()

        End If






    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure you wish to exit?",
                           "Exiting login...", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class