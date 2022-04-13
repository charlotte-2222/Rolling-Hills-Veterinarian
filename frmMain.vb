Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading.Tasks

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Vet_Clinic_RHDataSet.vets' table. You can move, or remove it, as needed.
        Me.VetsTableAdapter.Fill(Me._Vet_Clinic_RHDataSet.vets)
        'TODO: This line of code loads data into the '_Vet_Clinic_RHDataSet.owners' table. You can move, or remove it, as needed.
        Me.OwnersTableAdapter.Fill(Me._Vet_Clinic_RHDataSet.owners)
        'TODO: This line of code loads data into the '_Vet_Clinic_RHDataSet.owners' table. You can move, or remove it, as needed.
        Me.OwnersTableAdapter.Fill(Me._Vet_Clinic_RHDataSet.owners)





    End Sub




    Private Sub btnInsertOwner_Click(sender As Object, e As EventArgs) Handles btnInsertOwner.Click

        Dim db As String = Path.Combine(Directory.GetCurrentDirectory(), "Vet-Clinic-RH.mdf")
        Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & (db) & ";Integrated Security=True")

        Using cmd As New SqlCommand("INSERT INTO owners (full_name, age, email) VALUES (@fullname,@age,@email)", conn)


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
            txtApptOwnerEmail.Text = row.Cells(3).Value.ToString
        End If
    End Sub


    Private Sub TxtboxEmailToolStripButton_Click(sender As Object, e As EventArgs) Handles TxtboxEmailToolStripButton.Click
        Try
            Me.OwnersTableAdapter.txtboxEmail(Me._Vet_Clinic_RHDataSet.owners, EmailToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Me.OwnersTableAdapter.Fill(Me._Vet_Clinic_RHDataSet.owners)

    End Sub

    Private Sub comboContacts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboContacts.SelectedIndexChanged
        If comboContacts.SelectedIndex = 1 Then
            lblInvisPhone.Visible = True
            txtInvisPhone.Visible = True
        Else
            lblInvisPhone.Visible = False
            txtInvisPhone.Visible = False
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim db As String = Path.Combine(Directory.GetCurrentDirectory(), "Vet-Clinic-RH.mdf")
        Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & (db) & ";Integrated Security=True")



        Using cmd As New SqlCommand("INSERT INTO appointments (owner, reason, staff, pref_contact, email, phone,appt_date ,notes) VALUES (@owner, @reason, @vet, @contact, @email, @phone,@date, @notes)", conn)



            cmd.Parameters.Add("@owner", SqlDbType.VarChar).Value = txtPetOwner.Text
            cmd.Parameters.Add("@reason", SqlDbType.VarChar).Value = comboReasonForVisit.SelectedItem.ToString()
            cmd.Parameters.Add("@vet", SqlDbType.VarChar).Value = comboStaff.SelectedValue.ToString()
            cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = comboContacts.SelectedItem.ToString()
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtApptOwnerEmail.Text
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = txtInvisPhone.Text
            cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = apptDate.Value.ToString()
            cmd.Parameters.Add("@notes", SqlDbType.VarChar).Value = txtAddDetails.Text


            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()



        End Using

        MessageBox.Show("Appointment made!")
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        login.Show()
    End Sub


End Class
