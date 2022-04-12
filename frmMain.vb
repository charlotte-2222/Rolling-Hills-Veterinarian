Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading.Tasks

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Vet_Clinic_RHDataSet.owners' table. You can move, or remove it, as needed.
        Me.OwnersTableAdapter.Fill(Me._Vet_Clinic_RHDataSet.owners)
        'TODO: This line of code loads data into the '_Vet_Clinic_RHDataSet.owners' table. You can move, or remove it, as needed.
        Me.OwnersTableAdapter.Fill(Me._Vet_Clinic_RHDataSet.owners)



    End Sub




    Private Sub btnInsertOwner_Click(sender As Object, e As EventArgs) Handles btnInsertOwner.Click

        Dim db As String = Path.Combine(Directory.GetCurrentDirectory(), "Vet-Clinic-RH.mdf")
        Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & (db) & ";Integrated Security=True")

        Using cmd As New SqlCommand("INSERT INTO owners (owners_id,full_name, age, email) VALUES (@ownId, @fullname,@age,@email)", conn)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            Dim count As Integer
            count = dt.Rows.Count()

            'cmd.Parameters.Add("@ownId", SqlDbType.Int).SqlValue

            cmd.Parameters.Add("@fullname", SqlDbType.VarChar).Value = txtOwnerFullName.Text
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtOwnerEmail.Text
            cmd.Parameters.Add("@age", SqlDbType.Date).Value = txtOwnerDoB.Text


            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()



        End Using


        Using cmd As New SqlCommand("INSERT INTO animals (animal_name, escape_attempts, species, age) VALUES (@name,@escape,@spec, @age)", conn)

            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtPetName.Text
            cmd.Parameters.Add("@age", SqlDbType.VarChar).Value = txtPetAge.Text
            cmd.Parameters.Add("@spec", SqlDbType.VarChar).Value = txtPetBreed.Text
            cmd.Parameters.Add("@escape", SqlDbType.VarChar).Value = txtEscapeAttempts.Text



            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

        End Using

        MessageBox.Show("New patient file created!")

    End Sub



    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtPetOwner.Text = row.Cells(1).Value.ToString
        End If
    End Sub


    Private Sub TxtboxEmailToolStripButton_Click(sender As Object, e As EventArgs) Handles TxtboxEmailToolStripButton.Click
        Try
            Me.OwnersTableAdapter.txtboxEmail(Me._Vet_Clinic_RHDataSet.owners, EmailToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
