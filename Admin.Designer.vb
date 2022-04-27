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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.btnCloseAdmin = New System.Windows.Forms.Button()
        Me.dgVetStaff = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VetsnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofgraduationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Vet_Clinic_RHDataSet = New Charlotte_Childers_CPT_206_Final_Project._Vet_Clinic_RHDataSet()
        Me.VetsTableAdapter = New Charlotte_Childers_CPT_206_Final_Project._Vet_Clinic_RHDataSetTableAdapters.vetsTableAdapter()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.txtDoB = New System.Windows.Forms.TextBox()
        Me.txtGradDate = New System.Windows.Forms.TextBox()
        Me.txtStaffFullName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vetLbl = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.dgVetStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Vet_Clinic_RHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnCloseAdmin.Location = New System.Drawing.Point(687, 271)
        Me.btnCloseAdmin.Name = "btnCloseAdmin"
        Me.btnCloseAdmin.Size = New System.Drawing.Size(81, 35)
        Me.btnCloseAdmin.TabIndex = 29
        Me.btnCloseAdmin.Text = "Close"
        Me.btnCloseAdmin.UseVisualStyleBackColor = False
        '
        'dgVetStaff
        '
        Me.dgVetStaff.AutoGenerateColumns = False
        Me.dgVetStaff.BackgroundColor = System.Drawing.Color.Lavender
        Me.dgVetStaff.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgVetStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVetStaff.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.VetsnameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.DateofgraduationDataGridViewTextBoxColumn})
        Me.dgVetStaff.DataSource = Me.VetsBindingSource
        Me.dgVetStaff.Location = New System.Drawing.Point(316, 309)
        Me.dgVetStaff.Name = "dgVetStaff"
        Me.dgVetStaff.Size = New System.Drawing.Size(456, 286)
        Me.dgVetStaff.TabIndex = 30
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "vets_id"
        Me.Column1.HeaderText = "StaffID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'VetsnameDataGridViewTextBoxColumn
        '
        Me.VetsnameDataGridViewTextBoxColumn.DataPropertyName = "vets_name"
        Me.VetsnameDataGridViewTextBoxColumn.HeaderText = "Full Name"
        Me.VetsnameDataGridViewTextBoxColumn.Name = "VetsnameDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Date of Birth"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.Width = 110
        '
        'DateofgraduationDataGridViewTextBoxColumn
        '
        Me.DateofgraduationDataGridViewTextBoxColumn.DataPropertyName = "date_of_graduation"
        Me.DateofgraduationDataGridViewTextBoxColumn.HeaderText = "Graduation Date"
        Me.DateofgraduationDataGridViewTextBoxColumn.Name = "DateofgraduationDataGridViewTextBoxColumn"
        Me.DateofgraduationDataGridViewTextBoxColumn.Width = 110
        '
        'VetsBindingSource
        '
        Me.VetsBindingSource.DataMember = "vets"
        Me.VetsBindingSource.DataSource = Me._Vet_Clinic_RHDataSet
        '
        '_Vet_Clinic_RHDataSet
        '
        Me._Vet_Clinic_RHDataSet.DataSetName = "_Vet_Clinic_RHDataSet"
        Me._Vet_Clinic_RHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VetsTableAdapter
        '
        Me.VetsTableAdapter.ClearBeforeFill = True
        '
        'btnAddRecord
        '
        Me.btnAddRecord.BackColor = System.Drawing.Color.LightGreen
        Me.btnAddRecord.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnAddRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnAddRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRecord.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRecord.Location = New System.Drawing.Point(336, 272)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(96, 34)
        Me.btnAddRecord.TabIndex = 31
        Me.btnAddRecord.Text = "Add Staff"
        Me.btnAddRecord.UseVisualStyleBackColor = False
        '
        'txtDoB
        '
        Me.txtDoB.BackColor = System.Drawing.SystemColors.Info
        Me.txtDoB.Location = New System.Drawing.Point(632, 45)
        Me.txtDoB.Name = "txtDoB"
        Me.txtDoB.Size = New System.Drawing.Size(118, 20)
        Me.txtDoB.TabIndex = 34
        '
        'txtGradDate
        '
        Me.txtGradDate.BackColor = System.Drawing.SystemColors.Info
        Me.txtGradDate.Location = New System.Drawing.Point(632, 78)
        Me.txtGradDate.Name = "txtGradDate"
        Me.txtGradDate.Size = New System.Drawing.Size(118, 20)
        Me.txtGradDate.TabIndex = 37
        '
        'txtStaffFullName
        '
        Me.txtStaffFullName.BackColor = System.Drawing.SystemColors.Info
        Me.txtStaffFullName.Location = New System.Drawing.Point(623, 12)
        Me.txtStaffFullName.Name = "txtStaffFullName"
        Me.txtStaffFullName.Size = New System.Drawing.Size(127, 20)
        Me.txtStaffFullName.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(514, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Date of Birth:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(485, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 23)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Graduation Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(514, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 23)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Full Name:"
        '
        'vetLbl
        '
        Me.vetLbl.AutoSize = True
        Me.vetLbl.BackColor = System.Drawing.Color.Transparent
        Me.vetLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!, System.Drawing.FontStyle.Bold)
        Me.vetLbl.ForeColor = System.Drawing.Color.White
        Me.vetLbl.Location = New System.Drawing.Point(3, 3)
        Me.vetLbl.Name = "vetLbl"
        Me.vetLbl.Size = New System.Drawing.Size(232, 50)
        Me.vetLbl.TabIndex = 33
        Me.vetLbl.Text = "Admin Panel | Rolling Hills" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      - Edit Vet Information"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.LightGreen
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(453, 272)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(96, 34)
        Me.btnEdit.TabIndex = 39
        Me.btnEdit.Text = "Edit Staff"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Info
        Me.txtID.Location = New System.Drawing.Point(632, 111)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(51, 20)
        Me.txtID.TabIndex = 41
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.BackColor = System.Drawing.Color.Transparent
        Me.ID.Font = New System.Drawing.Font("Segoe UI Semibold", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.ForeColor = System.Drawing.Color.White
        Me.ID.Location = New System.Drawing.Point(554, 111)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(72, 23)
        Me.ID.TabIndex = 42
        Me.ID.Text = "Staff ID:"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(570, 272)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(96, 34)
        Me.btnRefresh.TabIndex = 43
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(771, 595)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtDoB)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtGradDate)
        Me.Controls.Add(Me.txtStaffFullName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vetLbl)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.dgVetStaff)
        Me.Controls.Add(Me.btnCloseAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        CType(Me.dgVetStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Vet_Clinic_RHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCloseAdmin As Button
    Friend WithEvents dgVetStaff As DataGridView
    Friend WithEvents _Vet_Clinic_RHDataSet As _Vet_Clinic_RHDataSet
    Friend WithEvents VetsBindingSource As BindingSource
    Friend WithEvents VetsTableAdapter As _Vet_Clinic_RHDataSetTableAdapters.vetsTableAdapter
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents txtDoB As TextBox
    Friend WithEvents txtGradDate As TextBox
    Friend WithEvents txtStaffFullName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents vetLbl As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents VetsnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateofgraduationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents ID As Label
    Friend WithEvents btnRefresh As Button
End Class
