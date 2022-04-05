Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading.Tasks

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBvetProjectData.owners' table. You can move, or remove it, as needed.



    End Sub

    Private Sub btnInsertOwner_Click(sender As Object, e As EventArgs) Handles btnInsertOwner.Click
        Try
            Dim db As String = Path.Combine(Directory.GetCurrentDirectory(), "VBvetProject.mdf")
            Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & (db) & ";Integrated Security=True")
            'Dim command As New SqlCommand("INSERT INTO owners(fullname, email, phone, dob) values ('" & txtOwnerFullName.Text & "','" & txtOwnerDoB.Text & "','" & txtOwnerEmail.Text & "','" & txtOwnerPhone.Text & "')", connection)
            connection.Open()

            Dim command As New SqlCommand("INSERT INTO owners Values (@name, @mail, @number, @d)", connection)

            command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = txtOwnerFullName.Text
            command.Parameters.AddWithValue("@mail", SqlDbType.VarChar).Value = txtOwnerEmail.Text
            command.Parameters.AddWithValue("@number", SqlDbType.VarChar).Value = txtOwnerPhone.Text
            command.Parameters.AddWithValue("@d", SqlDbType.VarChar).Value = txtOwnerDoB.Text


            command.ExecuteNonQuery()
            connection.Close()

            MessageBox.Show("Inserted")
        Catch Exception As Exception
            MessageBox.Show("Failed")
        End Try

    End Sub
End Class
