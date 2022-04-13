<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.btnCloseAdmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCloseAdmin
        '
        Me.btnCloseAdmin.BackColor = System.Drawing.Color.Salmon
        Me.btnCloseAdmin.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnCloseAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnCloseAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCloseAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseAdmin.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseAdmin.Location = New System.Drawing.Point(514, 552)
        Me.btnCloseAdmin.Name = "btnCloseAdmin"
        Me.btnCloseAdmin.Size = New System.Drawing.Size(81, 35)
        Me.btnCloseAdmin.TabIndex = 29
        Me.btnCloseAdmin.Text = "Close"
        Me.btnCloseAdmin.UseVisualStyleBackColor = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 599)
        Me.Controls.Add(Me.btnCloseAdmin)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCloseAdmin As Button
End Class
