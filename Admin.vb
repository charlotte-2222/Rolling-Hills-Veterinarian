
Option Explicit On
Option Strict On
Option Infer Off

Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading.Tasks

Public Class Admin
    Private Sub btnCloseAdmin_Click(sender As Object, e As EventArgs) Handles btnCloseAdmin.Click
        Me.Close()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Vet_Clinic_RHDataSet.vets' table. You can move, or remove it, as needed.
        Me.VetsTableAdapter.Fill(Me._Vet_Clinic_RHDataSet.vets)

    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click


        Dim db As String = Path.Combine(Directory.GetCurrentDirectory(), "Vet-Clinic-RH.mdf")
        Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & (db) & ";Integrated Security=True")



        Using cmd As New SqlCommand("INSERT INTO vets (vets_name, age, date_of_graduation) VALUES (@name, @dob, @grad)", conn)


            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtStaffFullName.Text
            cmd.Parameters.Add("@dob", SqlDbType.VarChar).Value = txtDoB.Text
            cmd.Parameters.Add("@grad", SqlDbType.VarChar).Value = txtGradDate.Text

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

        End Using

        MessageBox.Show("Staff Updated")

        txtStaffFullName.Clear()
        txtDoB.Clear()
        txtGradDate.Clear()
    End Sub



    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim db As String = Path.Combine(Directory.GetCurrentDirectory(), "Vet-Clinic-RH.mdf")
        Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & (db) & ";Integrated Security=True")



        Using cmd As New SqlCommand("UPDATE vets SET vets_name=@name, age=@dob, date_of_graduation=@grad where vets_id=@id", conn)

            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtStaffFullName.Text
            cmd.Parameters.Add("@dob", SqlDbType.VarChar).Value = txtDoB.Text
            cmd.Parameters.Add("@grad", SqlDbType.VarChar).Value = txtGradDate.Text
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtID.Text

            conn.Open()
            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Vet Staff Updated")
            Else
                MessageBox.Show("Failure to update")
            End If
            conn.Close()

        End Using

        txtStaffFullName.Clear()
        txtDoB.Clear()
        txtGradDate.Clear()
        txtID.Clear()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        Dim db As String = Path.Combine(Directory.GetCurrentDirectory(), "Vet-Clinic-RH.mdf")
            Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & (db) & ";Integrated Security=True")

            Using cmd As New SqlCommand("DELETE FROM vets where vets_id=@id", conn)

            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtID.Text

            conn.Open()

            If MessageBox.Show("Are you sure you wish to delete this record?", "Caution...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MsgBox("Operation Cancelled")
                Exit Sub

            ElseIf DialogResult.Yes Then
                cmd.ExecuteNonQuery()
            End If
            conn.Close()
        End Using


        txtStaffFullName.Clear()
        txtDoB.Clear()
        txtGradDate.Clear()
        txtID.Clear()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ''simple refresh
        Me.VetsTableAdapter.Fill(Me._Vet_Clinic_RHDataSet.vets)
    End Sub
End Class