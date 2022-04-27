<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class emailForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtMailFrom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMailMessage = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMailSubject = New System.Windows.Forms.TextBox()
        Me.txtMailTo = New System.Windows.Forms.TextBox()
        Me.btnMailSend = New System.Windows.Forms.Button()
        Me.logLbl = New System.Windows.Forms.Label()
        Me.btnCloseEmail = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtMailFrom
        '
        Me.txtMailFrom.Location = New System.Drawing.Point(131, 53)
        Me.txtMailFrom.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtMailFrom.Name = "txtMailFrom"
        Me.txtMailFrom.ReadOnly = True
        Me.txtMailFrom.Size = New System.Drawing.Size(271, 25)
        Me.txtMailFrom.TabIndex = 0
        Me.txtMailFrom.TabStop = False
        Me.txtMailFrom.Text = "rollinghillsvetservices@gmail.com"
        Me.ToolTip1.SetToolTip(Me.txtMailFrom, "Prefilled Company Email")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(66, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "From:"
        '
        'txtMailMessage
        '
        Me.txtMailMessage.Location = New System.Drawing.Point(65, 213)
        Me.txtMailMessage.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtMailMessage.Name = "txtMailMessage"
        Me.txtMailMessage.Size = New System.Drawing.Size(502, 353)
        Me.txtMailMessage.TabIndex = 2
        Me.txtMailMessage.Text = ""
        Me.ToolTip1.SetToolTip(Me.txtMailMessage, " Prefilled message - Additions can be made")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(66, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Subject:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(66, 136)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(66, 192)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Message"
        '
        'txtMailSubject
        '
        Me.txtMailSubject.Location = New System.Drawing.Point(133, 93)
        Me.txtMailSubject.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtMailSubject.Name = "txtMailSubject"
        Me.txtMailSubject.Size = New System.Drawing.Size(300, 25)
        Me.txtMailSubject.TabIndex = 0
        Me.txtMailSubject.Text = "RH | Info Regarding Your Appointment"
        Me.ToolTip1.SetToolTip(Me.txtMailSubject, "Prefilled Subject")
        '
        'txtMailTo
        '
        Me.txtMailTo.Location = New System.Drawing.Point(131, 136)
        Me.txtMailTo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtMailTo.Name = "txtMailTo"
        Me.txtMailTo.Size = New System.Drawing.Size(302, 25)
        Me.txtMailTo.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtMailTo, "Prefilled Email" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Can be changed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or void if owner not selected)")
        '
        'btnMailSend
        '
        Me.btnMailSend.BackColor = System.Drawing.Color.Salmon
        Me.btnMailSend.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnMailSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnMailSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnMailSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMailSend.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMailSend.ForeColor = System.Drawing.Color.Black
        Me.btnMailSend.Location = New System.Drawing.Point(273, 593)
        Me.btnMailSend.Name = "btnMailSend"
        Me.btnMailSend.Size = New System.Drawing.Size(87, 41)
        Me.btnMailSend.TabIndex = 3
        Me.btnMailSend.Text = "Send"
        Me.ToolTip1.SetToolTip(Me.btnMailSend, "Send email")
        Me.btnMailSend.UseVisualStyleBackColor = False
        '
        'logLbl
        '
        Me.logLbl.AutoSize = True
        Me.logLbl.BackColor = System.Drawing.Color.Transparent
        Me.logLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logLbl.ForeColor = System.Drawing.Color.White
        Me.logLbl.Location = New System.Drawing.Point(12, 9)
        Me.logLbl.Name = "logLbl"
        Me.logLbl.Size = New System.Drawing.Size(199, 21)
        Me.logLbl.TabIndex = 30
        Me.logLbl.Text = "Rolling Hills Email Service"
        '
        'btnCloseEmail
        '
        Me.btnCloseEmail.BackColor = System.Drawing.Color.Salmon
        Me.btnCloseEmail.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnCloseEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnCloseEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCloseEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseEmail.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseEmail.Location = New System.Drawing.Point(604, 3)
        Me.btnCloseEmail.Name = "btnCloseEmail"
        Me.btnCloseEmail.Size = New System.Drawing.Size(26, 26)
        Me.btnCloseEmail.TabIndex = 31
        Me.btnCloseEmail.Text = "X"
        Me.ToolTip1.SetToolTip(Me.btnCloseEmail, "Exit Email Form")
        Me.btnCloseEmail.UseVisualStyleBackColor = False
        '
        'emailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(633, 646)
        Me.Controls.Add(Me.btnCloseEmail)
        Me.Controls.Add(Me.logLbl)
        Me.Controls.Add(Me.btnMailSend)
        Me.Controls.Add(Me.txtMailTo)
        Me.Controls.Add(Me.txtMailSubject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMailMessage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMailFrom)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "emailForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMailFrom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMailMessage As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMailSubject As TextBox
    Friend WithEvents txtMailTo As TextBox
    Friend WithEvents btnMailSend As Button
    Friend WithEvents logLbl As Label
    Friend WithEvents btnCloseEmail As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
