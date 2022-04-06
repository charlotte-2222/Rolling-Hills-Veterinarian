Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading.Tasks

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBvetProjectData.owners' table. You can move, or remove it, as needed.



    End Sub




    Private Sub btnInsertOwner_Click(sender As Object, e As EventArgs) Handles btnInsertOwner.Click
        Dim db As String = Path.Combine(Directory.GetCurrentDirectory(), "VBvetProject.mdf")
        Dim sqlConnection1 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & (db) & ";Integrated Security=True")



        Try
            'Dim cmd As New SqlCommand
            'cmd.CommandType = CommandType.Text
            'sqlConnection1.Open()

            'Dim fullname As New String(txtOwnerFullName.Text)
            'Dim email As New String(txtOwnerEmail.Text)
            'Dim phone As New String(txtOwnerPhone.Text)
            'Dim dob As New String(txtOwnerDoB.Text)


            'cmd.CommandText = "INSERT INTO owners (fullname, email, phone, dob) Values ('" & txtOwnerFullName.Text & "', '" & txtOwnerEmail.Text & "', '" & txtOwnerPhone.Text & "', '" & txtOwnerDoB.Text & "')"
            'cmd.Connection = sqlConnection1

            Dim cmd As New SqlCommand("INSERT INTO owners (fullname, email, phone, dob) VALUES (@fullname,@email,@phone,@dob)", sqlConnection1)


            cmd.Parameters.Add("@fullname", SqlDbType.VarChar).Value = txtOwnerFullName.Text
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtOwnerEmail.Text
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = txtOwnerPhone.Text
            cmd.Parameters.Add("@dob", SqlDbType.VarChar).Value = txtOwnerDoB.Text


            'cmd.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Update(table)
            'sqlConnection1.Close()

            MessageBox.Show("New owner created!")



        Catch ex As Exception
            Throw ex
            MessageBox.Show("Error running process")

        End Try

        ' Dim adapter As New SqlDataAdapter(command)
        'Dim dataset As New DataSet()
        'adapter.Fill(dataset)


    End Sub


End Class
