Imports System.Net.Mail
Public Class emailForm
    Private Sub email_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub btnMailSend_Click(sender As Object, e As EventArgs) Handles btnMailSend.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("rollinghillsvetservices@gmail.com", "SomePassword")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage
            e_mail.From = New MailAddress("rollinghillsvetservices@gmail.com")
            e_mail.To.Add(txtMailTo.Text)
            e_mail.Subject = txtMailSubject.Text()
            e_mail.Body = txtMailMessage.Text
            Smtp_Server.Send(e_mail)
            MsgBox("Email Sent")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCloseEmail_Click(sender As Object, e As EventArgs) Handles btnCloseEmail.Click
        Me.Close()
    End Sub
End Class