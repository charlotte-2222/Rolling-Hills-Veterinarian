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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPetBreed = New System.Windows.Forms.TextBox()
        Me.txtPetAge = New System.Windows.Forms.TextBox()
        Me.txtEscapeAttempts = New System.Windows.Forms.TextBox()
        Me.txtPetName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnInsertOwner = New System.Windows.Forms.Button()
        Me.txtOwnerEmail = New System.Windows.Forms.TextBox()
        Me.txtOwnerDoB = New System.Windows.Forms.TextBox()
        Me.txtOwnerFullName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ownLabel = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.OwnersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtPetOwner = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAddDetails = New System.Windows.Forms.RichTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.comboStaff = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.comboContacts = New System.Windows.Forms.ComboBox()
        Me.comboReasonForVisit = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.OwnersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtboxEmailToolStrip = New System.Windows.Forms.ToolStrip()
        Me.EmailToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.EmailToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.TxtboxEmailToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.VetClinicRHDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Vet_Clinic_RHDataSet = New Charlotte_Childers_CPT_206_Final_Project._Vet_Clinic_RHDataSet()
        Me.OwnersidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OwnersTableAdapter = New Charlotte_Childers_CPT_206_Final_Project._Vet_Clinic_RHDataSetTableAdapters.ownersTableAdapter()
        Me.patientsTab.SuspendLayout()
        Me.ownerPage.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.OwnersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OwnersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TxtboxEmailToolStrip.SuspendLayout()
        CType(Me.VetClinicRHDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Vet_Clinic_RHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.patientsTab.Location = New System.Drawing.Point(522, 12)
        Me.patientsTab.Name = "patientsTab"
        Me.patientsTab.SelectedIndex = 0
        Me.patientsTab.Size = New System.Drawing.Size(554, 626)
        Me.patientsTab.TabIndex = 0
        '
        'ownerPage
        '
        Me.ownerPage.AllowDrop = True
        Me.ownerPage.Controls.Add(Me.Label9)
        Me.ownerPage.Controls.Add(Me.txtPetBreed)
        Me.ownerPage.Controls.Add(Me.txtPetAge)
        Me.ownerPage.Controls.Add(Me.txtEscapeAttempts)
        Me.ownerPage.Controls.Add(Me.txtPetName)
        Me.ownerPage.Controls.Add(Me.Label5)
        Me.ownerPage.Controls.Add(Me.Label6)
        Me.ownerPage.Controls.Add(Me.Label7)
        Me.ownerPage.Controls.Add(Me.Label8)
        Me.ownerPage.Controls.Add(Me.btnInsertOwner)
        Me.ownerPage.Controls.Add(Me.txtOwnerEmail)
        Me.ownerPage.Controls.Add(Me.txtOwnerDoB)
        Me.ownerPage.Controls.Add(Me.txtOwnerFullName)
        Me.ownerPage.Controls.Add(Me.Label3)
        Me.ownerPage.Controls.Add(Me.Label2)
        Me.ownerPage.Controls.Add(Me.Label1)
        Me.ownerPage.Controls.Add(Me.ownLabel)
        Me.ownerPage.Location = New System.Drawing.Point(4, 22)
        Me.ownerPage.Name = "ownerPage"
        Me.ownerPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ownerPage.Size = New System.Drawing.Size(546, 600)
        Me.ownerPage.TabIndex = 0
        Me.ownerPage.Text = "New Patient"
        Me.ownerPage.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(149, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 25)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Pet Information"
        '
        'txtPetBreed
        '
        Me.txtPetBreed.BackColor = System.Drawing.SystemColors.Info
        Me.txtPetBreed.Location = New System.Drawing.Point(295, 416)
        Me.txtPetBreed.Name = "txtPetBreed"
        Me.txtPetBreed.Size = New System.Drawing.Size(103, 20)
        Me.txtPetBreed.TabIndex = 6
        '
        'txtPetAge
        '
        Me.txtPetAge.BackColor = System.Drawing.SystemColors.Info
        Me.txtPetAge.Location = New System.Drawing.Point(271, 370)
        Me.txtPetAge.Name = "txtPetAge"
        Me.txtPetAge.Size = New System.Drawing.Size(127, 20)
        Me.txtPetAge.TabIndex = 5
        '
        'txtEscapeAttempts
        '
        Me.txtEscapeAttempts.BackColor = System.Drawing.SystemColors.Info
        Me.txtEscapeAttempts.Location = New System.Drawing.Point(295, 462)
        Me.txtEscapeAttempts.Name = "txtEscapeAttempts"
        Me.txtEscapeAttempts.Size = New System.Drawing.Size(103, 20)
        Me.txtEscapeAttempts.TabIndex = 7
        '
        'txtPetName
        '
        Me.txtPetName.BackColor = System.Drawing.SystemColors.Info
        Me.txtPetName.Location = New System.Drawing.Point(271, 324)
        Me.txtPetName.Name = "txtPetName"
        Me.txtPetName.Size = New System.Drawing.Size(127, 20)
        Me.txtPetName.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(165, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Species:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(165, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Age:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(165, 462)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Escape Attempts:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(165, 324)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Pet Name:"
        '
        'btnInsertOwner
        '
        Me.btnInsertOwner.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold)
        Me.btnInsertOwner.Location = New System.Drawing.Point(265, 549)
        Me.btnInsertOwner.Name = "btnInsertOwner"
        Me.btnInsertOwner.Size = New System.Drawing.Size(114, 45)
        Me.btnInsertOwner.TabIndex = 9
        Me.btnInsertOwner.Text = "Complete"
        Me.btnInsertOwner.UseVisualStyleBackColor = True
        '
        'txtOwnerEmail
        '
        Me.txtOwnerEmail.BackColor = System.Drawing.SystemColors.Info
        Me.txtOwnerEmail.Location = New System.Drawing.Point(271, 119)
        Me.txtOwnerEmail.Name = "txtOwnerEmail"
        Me.txtOwnerEmail.Size = New System.Drawing.Size(127, 20)
        Me.txtOwnerEmail.TabIndex = 1
        '
        'txtOwnerDoB
        '
        Me.txtOwnerDoB.BackColor = System.Drawing.SystemColors.Info
        Me.txtOwnerDoB.Location = New System.Drawing.Point(271, 165)
        Me.txtOwnerDoB.Name = "txtOwnerDoB"
        Me.txtOwnerDoB.Size = New System.Drawing.Size(127, 20)
        Me.txtOwnerDoB.TabIndex = 3
        '
        'txtOwnerFullName
        '
        Me.txtOwnerFullName.BackColor = System.Drawing.SystemColors.Info
        Me.txtOwnerFullName.Location = New System.Drawing.Point(271, 73)
        Me.txtOwnerFullName.Name = "txtOwnerFullName"
        Me.txtOwnerFullName.Size = New System.Drawing.Size(127, 20)
        Me.txtOwnerFullName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(165, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(165, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date of Birth:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Full Name:"
        '
        'ownLabel
        '
        Me.ownLabel.AutoSize = True
        Me.ownLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!, System.Drawing.FontStyle.Bold)
        Me.ownLabel.Location = New System.Drawing.Point(149, 36)
        Me.ownLabel.Name = "ownLabel"
        Me.ownLabel.Size = New System.Drawing.Size(172, 25)
        Me.ownLabel.TabIndex = 0
        Me.ownLabel.Text = "Owner Information"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.TxtboxEmailToolStrip)
        Me.TabPage2.Controls.Add(Me.BindingNavigator1)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.btnInsert)
        Me.TabPage2.Controls.Add(Me.txtPetOwner)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtAddDetails)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.comboStaff)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.comboContacts)
        Me.TabPage2.Controls.Add(Me.comboReasonForVisit)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(546, 600)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Appointment"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Gainsboro
        Me.BindingNavigator1.BindingSource = Me.OwnersBindingSource1
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(245, 164)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(203, 25)
        Me.BindingNavigator1.TabIndex = 29
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'OwnersBindingSource1
        '
        Me.OwnersBindingSource1.DataMember = "owners"
        Me.OwnersBindingSource1.DataSource = Me.VetClinicRHDataSetBindingSource
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OwnersidDataGridViewTextBoxColumn, Me.FullnameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OwnersBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(3, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(445, 127)
        Me.DataGridView1.TabIndex = 28
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.LightGreen
        Me.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(382, 547)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(147, 35)
        Me.btnInsert.TabIndex = 27
        Me.btnInsert.Text = "Make Appointment"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'txtPetOwner
        '
        Me.txtPetOwner.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPetOwner.Location = New System.Drawing.Point(156, 216)
        Me.txtPetOwner.Name = "txtPetOwner"
        Me.txtPetOwner.ReadOnly = True
        Me.txtPetOwner.Size = New System.Drawing.Size(131, 20)
        Me.txtPetOwner.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Pet Owner:"
        '
        'txtAddDetails
        '
        Me.txtAddDetails.BackColor = System.Drawing.SystemColors.Info
        Me.txtAddDetails.Location = New System.Drawing.Point(30, 407)
        Me.txtAddDetails.Name = "txtAddDetails"
        Me.txtAddDetails.Size = New System.Drawing.Size(310, 175)
        Me.txtAddDetails.TabIndex = 20
        Me.txtAddDetails.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(26, 384)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(134, 20)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Additional Details:"
        '
        'comboStaff
        '
        Me.comboStaff.FormattingEnabled = True
        Me.comboStaff.Location = New System.Drawing.Point(166, 297)
        Me.comboStaff.Name = "comboStaff"
        Me.comboStaff.Size = New System.Drawing.Size(151, 21)
        Me.comboStaff.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(26, 295)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 20)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Preferred Staff:"
        '
        'comboContacts
        '
        Me.comboContacts.FormattingEnabled = True
        Me.comboContacts.Items.AddRange(New Object() {"Email", "Phone"})
        Me.comboContacts.Location = New System.Drawing.Point(224, 347)
        Me.comboContacts.Name = "comboContacts"
        Me.comboContacts.Size = New System.Drawing.Size(93, 21)
        Me.comboContacts.TabIndex = 16
        '
        'comboReasonForVisit
        '
        Me.comboReasonForVisit.FormattingEnabled = True
        Me.comboReasonForVisit.Items.AddRange(New Object() {"Sick Visit", "Wellness Exam", "Vaccinations", "Recheck", "Laser Therapy: Call for appointment", "Nail Trim", "Anal Glands", "Injection", "Other: Reason in notes"})
        Me.comboReasonForVisit.Location = New System.Drawing.Point(156, 254)
        Me.comboReasonForVisit.Name = "comboReasonForVisit"
        Me.comboReasonForVisit.Size = New System.Drawing.Size(161, 21)
        Me.comboReasonForVisit.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(26, 345)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(192, 20)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Preferred Contact Method:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(26, 252)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Reason for Visit:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(3, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(183, 25)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Create Appointment"
        '
        'OwnersBindingSource
        '
        Me.OwnersBindingSource.DataMember = "owners"
        Me.OwnersBindingSource.DataSource = Me.VetClinicRHDataSetBindingSource
        '
        'TxtboxEmailToolStrip
        '
        Me.TxtboxEmailToolStrip.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtboxEmailToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.TxtboxEmailToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmailToolStripLabel, Me.EmailToolStripTextBox, Me.TxtboxEmailToolStripButton})
        Me.TxtboxEmailToolStrip.Location = New System.Drawing.Point(3, 164)
        Me.TxtboxEmailToolStrip.Name = "TxtboxEmailToolStrip"
        Me.TxtboxEmailToolStrip.Size = New System.Drawing.Size(227, 25)
        Me.TxtboxEmailToolStrip.TabIndex = 1
        Me.TxtboxEmailToolStrip.Text = " "
        '
        'EmailToolStripLabel
        '
        Me.EmailToolStripLabel.Name = "EmailToolStripLabel"
        Me.EmailToolStripLabel.Size = New System.Drawing.Size(90, 22)
        Me.EmailToolStripLabel.Text = "Search by Email"
        '
        'EmailToolStripTextBox
        '
        Me.EmailToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EmailToolStripTextBox.Name = "EmailToolStripTextBox"
        Me.EmailToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'TxtboxEmailToolStripButton
        '
        Me.TxtboxEmailToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TxtboxEmailToolStripButton.Name = "TxtboxEmailToolStripButton"
        Me.TxtboxEmailToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.TxtboxEmailToolStripButton.Text = " "
        '
        'VetClinicRHDataSetBindingSource
        '
        Me.VetClinicRHDataSetBindingSource.DataSource = Me._Vet_Clinic_RHDataSet
        Me.VetClinicRHDataSetBindingSource.Position = 0
        '
        '_Vet_Clinic_RHDataSet
        '
        Me._Vet_Clinic_RHDataSet.DataSetName = "_Vet_Clinic_RHDataSet"
        Me._Vet_Clinic_RHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OwnersidDataGridViewTextBoxColumn
        '
        Me.OwnersidDataGridViewTextBoxColumn.DataPropertyName = "owners_id"
        Me.OwnersidDataGridViewTextBoxColumn.HeaderText = "owners_id"
        Me.OwnersidDataGridViewTextBoxColumn.Name = "OwnersidDataGridViewTextBoxColumn"
        Me.OwnersidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "full_name"
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        Me.FullnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OwnersTableAdapter
        '
        Me.OwnersTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnInsertOwner
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
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.OwnersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OwnersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TxtboxEmailToolStrip.ResumeLayout(False)
        Me.TxtboxEmailToolStrip.PerformLayout()
        CType(Me.VetClinicRHDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Vet_Clinic_RHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logLbl As Label
    Friend WithEvents patientsTab As TabControl
    Friend WithEvents ownerPage As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtOwnerEmail As TextBox
    Friend WithEvents txtOwnerDoB As TextBox
    Friend WithEvents txtOwnerFullName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ownLabel As Label
    Friend WithEvents btnInsertOwner As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPetBreed As TextBox
    Friend WithEvents txtPetAge As TextBox
    Friend WithEvents txtEscapeAttempts As TextBox
    Friend WithEvents txtPetName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAddDetails As RichTextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents comboStaff As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents comboContacts As ComboBox
    Friend WithEvents comboReasonForVisit As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPetOwner As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents VetClinicRHDataSetBindingSource As BindingSource
    Friend WithEvents _Vet_Clinic_RHDataSet As _Vet_Clinic_RHDataSet
    Friend WithEvents OwnersBindingSource As BindingSource
    Friend WithEvents OwnersTableAdapter As _Vet_Clinic_RHDataSetTableAdapters.ownersTableAdapter
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OwnersBindingSource1 As BindingSource
    Friend WithEvents OwnersidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TxtboxEmailToolStrip As ToolStrip
    Friend WithEvents EmailToolStripLabel As ToolStripLabel
    Friend WithEvents EmailToolStripTextBox As ToolStripTextBox
    Friend WithEvents TxtboxEmailToolStripButton As ToolStripButton
End Class
