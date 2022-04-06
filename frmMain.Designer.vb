<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.logLbl = New System.Windows.Forms.Label()
        Me.patientsTab = New System.Windows.Forms.TabControl()
        Me.ownerPage = New System.Windows.Forms.TabPage()
        Me.btnInsertOwner = New System.Windows.Forms.Button()
        Me.txtOwnerPhone = New System.Windows.Forms.TextBox()
        Me.txtOwnerEmail = New System.Windows.Forms.TextBox()
        Me.txtOwnerDoB = New System.Windows.Forms.TextBox()
        Me.txtOwnerFullName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ownLabel = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.patientsTab.SuspendLayout()
        Me.ownerPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'logLbl
        '
        Me.logLbl.AutoSize = True
        Me.logLbl.BackColor = System.Drawing.Color.Transparent
        Me.logLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logLbl.ForeColor = System.Drawing.Color.White
        Me.logLbl.Location = New System.Drawing.Point(2, 3)
        Me.logLbl.Name = "logLbl"
        Me.logLbl.Size = New System.Drawing.Size(203, 21)
        Me.logLbl.TabIndex = 0
        Me.logLbl.Text = "Logged into RH Vet Service"
        '
        'patientsTab
        '
        Me.patientsTab.Controls.Add(Me.ownerPage)
        Me.patientsTab.Controls.Add(Me.TabPage2)
        Me.patientsTab.Location = New System.Drawing.Point(702, 192)
        Me.patientsTab.Name = "patientsTab"
        Me.patientsTab.SelectedIndex = 0
        Me.patientsTab.Size = New System.Drawing.Size(374, 446)
        Me.patientsTab.TabIndex = 1
        '
        'ownerPage
        '
        Me.ownerPage.AllowDrop = True
        Me.ownerPage.Controls.Add(Me.btnInsertOwner)
        Me.ownerPage.Controls.Add(Me.txtOwnerPhone)
        Me.ownerPage.Controls.Add(Me.txtOwnerEmail)
        Me.ownerPage.Controls.Add(Me.txtOwnerDoB)
        Me.ownerPage.Controls.Add(Me.txtOwnerFullName)
        Me.ownerPage.Controls.Add(Me.Label4)
        Me.ownerPage.Controls.Add(Me.Label3)
        Me.ownerPage.Controls.Add(Me.Label2)
        Me.ownerPage.Controls.Add(Me.Label1)
        Me.ownerPage.Controls.Add(Me.ownLabel)
        Me.ownerPage.Location = New System.Drawing.Point(4, 22)
        Me.ownerPage.Name = "ownerPage"
        Me.ownerPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ownerPage.Size = New System.Drawing.Size(366, 420)
        Me.ownerPage.TabIndex = 0
        Me.ownerPage.Text = "New Patient"
        Me.ownerPage.UseVisualStyleBackColor = True
        '
        'btnInsertOwner
        '
        Me.btnInsertOwner.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold)
        Me.btnInsertOwner.Location = New System.Drawing.Point(117, 325)
        Me.btnInsertOwner.Name = "btnInsertOwner"
        Me.btnInsertOwner.Size = New System.Drawing.Size(114, 45)
        Me.btnInsertOwner.TabIndex = 9
        Me.btnInsertOwner.Text = "Complete"
        Me.btnInsertOwner.UseVisualStyleBackColor = True
        '
        'txtOwnerPhone
        '
        Me.txtOwnerPhone.BackColor = System.Drawing.SystemColors.Info
        Me.txtOwnerPhone.Location = New System.Drawing.Point(149, 184)
        Me.txtOwnerPhone.Name = "txtOwnerPhone"
        Me.txtOwnerPhone.Size = New System.Drawing.Size(127, 20)
        Me.txtOwnerPhone.TabIndex = 8
        '
        'txtOwnerEmail
        '
        Me.txtOwnerEmail.BackColor = System.Drawing.SystemColors.Info
        Me.txtOwnerEmail.Location = New System.Drawing.Point(149, 138)
        Me.txtOwnerEmail.Name = "txtOwnerEmail"
        Me.txtOwnerEmail.Size = New System.Drawing.Size(127, 20)
        Me.txtOwnerEmail.TabIndex = 7
        '
        'txtOwnerDoB
        '
        Me.txtOwnerDoB.BackColor = System.Drawing.SystemColors.Info
        Me.txtOwnerDoB.Location = New System.Drawing.Point(149, 230)
        Me.txtOwnerDoB.Name = "txtOwnerDoB"
        Me.txtOwnerDoB.Size = New System.Drawing.Size(127, 20)
        Me.txtOwnerDoB.TabIndex = 6
        '
        'txtOwnerFullName
        '
        Me.txtOwnerFullName.BackColor = System.Drawing.SystemColors.Info
        Me.txtOwnerFullName.Location = New System.Drawing.Point(149, 92)
        Me.txtOwnerFullName.Name = "txtOwnerFullName"
        Me.txtOwnerFullName.Size = New System.Drawing.Size(127, 20)
        Me.txtOwnerFullName.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Phone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date of Birth:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Full Name:"
        '
        'ownLabel
        '
        Me.ownLabel.AutoSize = True
        Me.ownLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!, System.Drawing.FontStyle.Bold)
        Me.ownLabel.Location = New System.Drawing.Point(6, 6)
        Me.ownLabel.Name = "ownLabel"
        Me.ownLabel.Size = New System.Drawing.Size(172, 25)
        Me.ownLabel.TabIndex = 0
        Me.ownLabel.Text = "Owner Information"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(366, 420)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1076, 640)
        Me.Controls.Add(Me.patientsTab)
        Me.Controls.Add(Me.logLbl)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Rolling Hills"
        Me.patientsTab.ResumeLayout(False)
        Me.ownerPage.ResumeLayout(False)
        Me.ownerPage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logLbl As Label
    Friend WithEvents patientsTab As TabControl
    Friend WithEvents ownerPage As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtOwnerPhone As TextBox
    Friend WithEvents txtOwnerEmail As TextBox
    Friend WithEvents txtOwnerDoB As TextBox
    Friend WithEvents txtOwnerFullName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ownLabel As Label
    Friend WithEvents btnInsertOwner As Button
End Class
