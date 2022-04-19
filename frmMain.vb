'Charlotte Childers
'Matthew Alimagham
'CPT-206 | Visual Basic, Final Project
'Rolling Hills Veterinary Clinic Application
'04/27/22
'This project is a Vet-Technician portal for creating patient accounts,
'Creating appointments, and 

Option Explicit On
Option Strict On
Option Infer Off

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

        '' pre-establishes lst item details for patient file

        lstDataCommit.Items.Add("Owner Name: " & txtOwnerFullName.Text & "")
        lstDataCommit.Items.Add("Email: " & txtOwnerEmail.Text & "")
        lstDataCommit.Items.Add("DoB: " & txtOwnerDoB.Text & "")
        lstDataCommit.Items.Add("Pet Name: " & txtPetName.Text & "")
        lstDataCommit.Items.Add("Pet Age: " & txtPetAge.Text & "")
        lstDataCommit.Items.Add("Species: " & txtPetBreed.Text & "")
        lstDataCommit.Items.Add("Escape Attempts: " & txtEscapeAttempts.Text & "")



    End Sub




    Private Sub btnInsertOwner_Click(sender As Object, e As EventArgs) Handles btnInsertOwner.Click
        '' patient creation / inserts into owner and animal tables.
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

        '' Clear text boxes and list on patient add
        txtOwnerFullName.Clear()
        txtOwnerEmail.Clear()
        txtOwnerDoB.Clear()
        txtPetName.Clear()
        txtPetAge.Clear()
        txtPetBreed.Clear()
        txtEscapeAttempts.Clear()

        'Will reset to original posistion
        lstDataCommit.Items.Clear()
        btnLoadList.PerformClick()

    End Sub



    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        ''Will auto fill appropriate text boxes when creating an appointment

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtPetOwner.Text = row.Cells(1).Value.ToString
            txtApptOwnerEmail.Text = row.Cells(3).Value.ToString
        End If
    End Sub


    Private Sub TxtboxEmailToolStripButton_Click(sender As Object, e As EventArgs) Handles TxtboxEmailToolStripButton.Click
        '' search by email
        Try
            Me.OwnersTableAdapter.txtboxEmail(Me._Vet_Clinic_RHDataSet.owners, EmailToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ''simple refresh
        Me.OwnersTableAdapter.Fill(Me._Vet_Clinic_RHDataSet.owners)

    End Sub

    Private Sub comboContacts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboContacts.SelectedIndexChanged
        ''If the patient prefers email, pull from patient DB.
        ''If the patient prefers mobile/landline contact, insert updated phonenum.
        '' Text/label hidden by default.
        If comboContacts.SelectedIndex = 1 Then
            lblInvisPhone.Visible = True
            txtInvisPhone.Visible = True
        Else
            lblInvisPhone.Visible = False
            txtInvisPhone.Visible = False
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        '' Will create and insert appointment details into table, some fields are auto filled
        Dim db As String = Path.Combine(Directory.GetCurrentDirectory(), "Vet-Clinic-RH.mdf")
        Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & (db) & ";Integrated Security=True")



        Using cmd As New SqlCommand("INSERT INTO appointments (owner, reason, staff, pref_contact, email, phone,appt_date ,notes) VALUES (@owner, @reason, @vet, @contact, @email, @phone,@date, @notes)", conn)



            cmd.Parameters.Add("@owner", SqlDbType.VarChar).Value = txtPetOwner.Text
            cmd.Parameters.Add("@reason", SqlDbType.VarChar).Value = comboReasonForVisit.SelectedItem.ToString()
            cmd.Parameters.Add("@vet", SqlDbType.VarChar).Value = comboStaff.SelectedValue.ToString()
            cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = comboContacts.SelectedItem.ToString()
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtApptOwnerEmail.Text
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = txtInvisPhone.Text
            cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = apptDate.Value.Date & " - " & apptTime.Value.TimeOfDay.ToString()
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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ''Clears Patient creation textboxes



        txtEscapeAttempts.Clear()
        txtOwnerFullName.Clear()
        txtOwnerEmail.Clear()
        txtOwnerDoB.Clear()

        txtPetName.Clear()
        txtPetAge.Clear()
        txtPetBreed.Clear()

        'Will reset to original posistion
        lstDataCommit.Items.Clear()
        btnLoadList.PerformClick()


    End Sub

    Private Sub btnLoadList_Click(sender As Object, e As EventArgs) Handles btnLoadList.Click

        lstDataCommit.Items.Clear()
        lstDataCommit.Items.Add("Owner Name: " & txtOwnerFullName.Text & "")
        lstDataCommit.Items.Add("Email: " & txtOwnerEmail.Text & "")
        lstDataCommit.Items.Add("DoB: " & txtOwnerDoB.Text & "")
        lstDataCommit.Items.Add("Pet Name: " & txtPetName.Text & "")
        lstDataCommit.Items.Add("Pet Age: " & txtPetAge.Text & "")
        lstDataCommit.Items.Add("Species: " & txtPetBreed.Text & "")
        lstDataCommit.Items.Add("Escape Attempts: " & txtEscapeAttempts.Text & "")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("F")
    End Sub

    Private Sub btnAdminCtrl_Click(sender As Object, e As EventArgs) Handles btnAdminCtrl.Click
        adminBox.Visible = True
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you wish to exit?", "Exiting...", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            login.Close()
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAdminSubmit_Click(sender As Object, e As EventArgs) Handles btnAdminSubmit.Click
        Dim user, pass As String
        user = "Admin"
        pass = "Admin"

        If txtAdmUser.Text = user And txtAdmPass.Text = pass Then
            Admin.Show()
            txtAdmUser.Clear()
            txtAdmPass.Clear()
        Else
            MessageBox.Show("Incorrect Username or Password - You must have Administrative Privileges to access this form.", "Insufficient Access Level", MessageBoxButtons.OKCancel
                            )
            If DialogResult.Cancel Then
                adminBox.Visible = False
                txtAdmUser.Clear()
                txtAdmPass.Clear()
            ElseIf DialogResult.OK Then
                adminBox.Visible = True
                txtAdmUser.Clear()
                txtAdmPass.Clear()
            End If
        End If



    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        adminBox.Visible = False
    End Sub
End Class
