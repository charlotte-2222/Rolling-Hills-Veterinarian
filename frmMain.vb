Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading.Tasks

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBvetProjectData.owners' table. You can move, or remove it, as needed.



    End Sub




    Private Sub btnInsertOwner_Click(sender As Object, e As EventArgs) Handles btnInsertOwner.Click

        Dim db As String = Path.Combine(Directory.GetCurrentDirectory(), "VBvetProject.mdf")
        Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & (db) & ";Integrated Security=True")

        Using cmd As New SqlCommand("INSERT INTO owners VALUES (@fullname,@email,@phone,@dob)", conn)


            cmd.Parameters.AddWithValue("@fullname", txtOwnerFullName.Text)
            cmd.Parameters.AddWithValue("@email", txtOwnerEmail.Text)
            cmd.Parameters.AddWithValue("@phone", txtOwnerPhone.Text)
            cmd.Parameters.AddWithValue("@dob", txtOwnerDoB.Text)
            Dim adapter As New SqlDataAdapter(cmd)

            conn.Open()
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            adapter.Update(dt)
            conn.Close()



        End Using

        MessageBox.Show("New owner created!")

    End Sub


End Class
