<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeInfo))
        Me.txtMiddlename = New C1.Win.C1Input.C1TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFirstname = New C1.Win.C1Input.C1TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastname = New C1.Win.C1Input.C1TextBox()
        Me.gbxEmployeeInfo = New System.Windows.Forms.GroupBox()
        Me.btnBrowseDepartment = New System.Windows.Forms.Button()
        Me.txtDepartment = New C1.Win.C1Input.C1TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBrowseSchedules = New System.Windows.Forms.Button()
        Me.txtSchedule = New C1.Win.C1Input.C1TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDeletePicture = New System.Windows.Forms.Button()
        Me.btnCamera = New System.Windows.Forms.Button()
        Me.txtCode = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.picEmployee = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkLLF = New System.Windows.Forms.CheckBox()
        Me.chkLRF = New System.Windows.Forms.CheckBox()
        Me.chkLMF = New System.Windows.Forms.CheckBox()
        Me.chkLIF = New System.Windows.Forms.CheckBox()
        Me.chkLTF = New System.Windows.Forms.CheckBox()
        Me.chkRLF = New System.Windows.Forms.CheckBox()
        Me.chkRRF = New System.Windows.Forms.CheckBox()
        Me.chkRMF = New System.Windows.Forms.CheckBox()
        Me.chkRIF = New System.Windows.Forms.CheckBox()
        Me.chkRTF = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.ofdBrowse = New System.Windows.Forms.OpenFileDialog()
        CType(Me.txtMiddlename, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirstname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastname, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxEmployeeInfo.SuspendLayout()
        CType(Me.txtDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMiddlename
        '
        Me.txtMiddlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddlename.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.Location = New System.Drawing.Point(111, 112)
        Me.txtMiddlename.MaxLength = 20
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(390, 26)
        Me.txtMiddlename.TabIndex = 3
        Me.txtMiddlename.Tag = Nothing
        Me.txtMiddlename.TextDetached = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 20)
        Me.Label14.TabIndex = 133
        Me.Label14.Text = "Middle name"
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstname.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(111, 87)
        Me.txtFirstname.MaxLength = 20
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(390, 26)
        Me.txtFirstname.TabIndex = 2
        Me.txtFirstname.Tag = Nothing
        Me.txtFirstname.TextDetached = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 20)
        Me.Label13.TabIndex = 131
        Me.Label13.Text = "First name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Last name"
        '
        'txtLastname
        '
        Me.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastname.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(111, 62)
        Me.txtLastname.MaxLength = 20
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(390, 26)
        Me.txtLastname.TabIndex = 1
        Me.txtLastname.Tag = Nothing
        Me.txtLastname.TextDetached = True
        '
        'gbxEmployeeInfo
        '
        Me.gbxEmployeeInfo.BackColor = System.Drawing.Color.Transparent
        Me.gbxEmployeeInfo.Controls.Add(Me.btnBrowseDepartment)
        Me.gbxEmployeeInfo.Controls.Add(Me.txtDepartment)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label4)
        Me.gbxEmployeeInfo.Controls.Add(Me.btnBrowseSchedules)
        Me.gbxEmployeeInfo.Controls.Add(Me.txtSchedule)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label3)
        Me.gbxEmployeeInfo.Controls.Add(Me.btnDeletePicture)
        Me.gbxEmployeeInfo.Controls.Add(Me.btnCamera)
        Me.gbxEmployeeInfo.Controls.Add(Me.txtCode)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label1)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label15)
        Me.gbxEmployeeInfo.Controls.Add(Me.picEmployee)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label5)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label7)
        Me.gbxEmployeeInfo.Controls.Add(Me.chkLLF)
        Me.gbxEmployeeInfo.Controls.Add(Me.chkLRF)
        Me.gbxEmployeeInfo.Controls.Add(Me.chkLMF)
        Me.gbxEmployeeInfo.Controls.Add(Me.chkLIF)
        Me.gbxEmployeeInfo.Controls.Add(Me.chkLTF)
        Me.gbxEmployeeInfo.Controls.Add(Me.chkRLF)
        Me.gbxEmployeeInfo.Controls.Add(Me.chkRRF)
        Me.gbxEmployeeInfo.Controls.Add(Me.chkRMF)
        Me.gbxEmployeeInfo.Controls.Add(Me.chkRIF)
        Me.gbxEmployeeInfo.Controls.Add(Me.chkRTF)
        Me.gbxEmployeeInfo.Controls.Add(Me.PictureBox1)
        Me.gbxEmployeeInfo.Controls.Add(Me.btnBrowse)
        Me.gbxEmployeeInfo.Controls.Add(Me.txtMiddlename)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label14)
        Me.gbxEmployeeInfo.Controls.Add(Me.txtFirstname)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label13)
        Me.gbxEmployeeInfo.Controls.Add(Me.txtLastname)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label2)
        Me.gbxEmployeeInfo.Location = New System.Drawing.Point(5, 27)
        Me.gbxEmployeeInfo.Name = "gbxEmployeeInfo"
        Me.gbxEmployeeInfo.Size = New System.Drawing.Size(509, 437)
        Me.gbxEmployeeInfo.TabIndex = 44
        Me.gbxEmployeeInfo.TabStop = False
        Me.gbxEmployeeInfo.Tag = "0"
        '
        'btnBrowseDepartment
        '
        Me.btnBrowseDepartment.BackgroundImage = CType(resources.GetObject("btnBrowseDepartment.BackgroundImage"), System.Drawing.Image)
        Me.btnBrowseDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBrowseDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowseDepartment.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseDepartment.ForeColor = System.Drawing.Color.Black
        Me.btnBrowseDepartment.Location = New System.Drawing.Point(475, 137)
        Me.btnBrowseDepartment.Name = "btnBrowseDepartment"
        Me.btnBrowseDepartment.Size = New System.Drawing.Size(26, 26)
        Me.btnBrowseDepartment.TabIndex = 207
        Me.btnBrowseDepartment.TabStop = False
        Me.btnBrowseDepartment.UseVisualStyleBackColor = True
        '
        'txtDepartment
        '
        Me.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepartment.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.Location = New System.Drawing.Point(111, 137)
        Me.txtDepartment.MaxLength = 20
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.ReadOnly = True
        Me.txtDepartment.Size = New System.Drawing.Size(365, 26)
        Me.txtDepartment.TabIndex = 205
        Me.txtDepartment.Tag = Nothing
        Me.txtDepartment.TextDetached = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 206
        Me.Label4.Text = "Department"
        '
        'btnBrowseSchedules
        '
        Me.btnBrowseSchedules.BackgroundImage = CType(resources.GetObject("btnBrowseSchedules.BackgroundImage"), System.Drawing.Image)
        Me.btnBrowseSchedules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBrowseSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowseSchedules.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseSchedules.ForeColor = System.Drawing.Color.Black
        Me.btnBrowseSchedules.Location = New System.Drawing.Point(475, 162)
        Me.btnBrowseSchedules.Name = "btnBrowseSchedules"
        Me.btnBrowseSchedules.Size = New System.Drawing.Size(26, 26)
        Me.btnBrowseSchedules.TabIndex = 204
        Me.btnBrowseSchedules.TabStop = False
        Me.btnBrowseSchedules.UseVisualStyleBackColor = True
        '
        'txtSchedule
        '
        Me.txtSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSchedule.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchedule.Location = New System.Drawing.Point(111, 162)
        Me.txtSchedule.MaxLength = 20
        Me.txtSchedule.Name = "txtSchedule"
        Me.txtSchedule.ReadOnly = True
        Me.txtSchedule.Size = New System.Drawing.Size(365, 26)
        Me.txtSchedule.TabIndex = 202
        Me.txtSchedule.Tag = Nothing
        Me.txtSchedule.TextDetached = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 203
        Me.Label3.Text = "Schedule"
        '
        'btnDeletePicture
        '
        Me.btnDeletePicture.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePicture.Image = CType(resources.GetObject("btnDeletePicture.Image"), System.Drawing.Image)
        Me.btnDeletePicture.Location = New System.Drawing.Point(182, 404)
        Me.btnDeletePicture.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDeletePicture.Name = "btnDeletePicture"
        Me.btnDeletePicture.Size = New System.Drawing.Size(24, 24)
        Me.btnDeletePicture.TabIndex = 201
        Me.btnDeletePicture.TabStop = False
        Me.btnDeletePicture.Tag = "Upload picture"
        Me.btnDeletePicture.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeletePicture.UseVisualStyleBackColor = True
        '
        'btnCamera
        '
        Me.btnCamera.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCamera.Image = CType(resources.GetObject("btnCamera.Image"), System.Drawing.Image)
        Me.btnCamera.Location = New System.Drawing.Point(159, 404)
        Me.btnCamera.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCamera.Name = "btnCamera"
        Me.btnCamera.Size = New System.Drawing.Size(24, 24)
        Me.btnCamera.TabIndex = 200
        Me.btnCamera.TabStop = False
        Me.btnCamera.Tag = "Upload picture"
        Me.btnCamera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCamera.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(111, 37)
        Me.txtCode.MaxLength = 20
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(365, 26)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = Nothing
        Me.txtCode.TextDetached = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "Biometric ID"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Helvetica Condensed", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(306, 210)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 17)
        Me.Label15.TabIndex = 197
        Me.Label15.Text = "Fingerprint Samples"
        '
        'picEmployee
        '
        Me.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEmployee.Location = New System.Drawing.Point(8, 231)
        Me.picEmployee.Name = "picEmployee"
        Me.picEmployee.Size = New System.Drawing.Size(200, 200)
        Me.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmployee.TabIndex = 195
        Me.picEmployee.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Helvetica Condensed", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "Picture"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Helvetica Condensed", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 17)
        Me.Label7.TabIndex = 185
        Me.Label7.Text = "Personal Information"
        '
        'chkLLF
        '
        Me.chkLLF.AutoSize = True
        Me.chkLLF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLLF.Location = New System.Drawing.Point(214, 288)
        Me.chkLLF.Name = "chkLLF"
        Me.chkLLF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkLLF.Size = New System.Drawing.Size(15, 14)
        Me.chkLLF.TabIndex = 182
        Me.chkLLF.TabStop = False
        Me.chkLLF.UseVisualStyleBackColor = True
        '
        'chkLRF
        '
        Me.chkLRF.AutoSize = True
        Me.chkLRF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLRF.Location = New System.Drawing.Point(239, 264)
        Me.chkLRF.Name = "chkLRF"
        Me.chkLRF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkLRF.Size = New System.Drawing.Size(15, 14)
        Me.chkLRF.TabIndex = 181
        Me.chkLRF.TabStop = False
        Me.chkLRF.UseVisualStyleBackColor = True
        '
        'chkLMF
        '
        Me.chkLMF.AutoSize = True
        Me.chkLMF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLMF.Location = New System.Drawing.Point(271, 252)
        Me.chkLMF.Name = "chkLMF"
        Me.chkLMF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkLMF.Size = New System.Drawing.Size(15, 14)
        Me.chkLMF.TabIndex = 180
        Me.chkLMF.TabStop = False
        Me.chkLMF.UseVisualStyleBackColor = True
        '
        'chkLIF
        '
        Me.chkLIF.AutoSize = True
        Me.chkLIF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLIF.Location = New System.Drawing.Point(303, 259)
        Me.chkLIF.Name = "chkLIF"
        Me.chkLIF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkLIF.Size = New System.Drawing.Size(15, 14)
        Me.chkLIF.TabIndex = 179
        Me.chkLIF.TabStop = False
        Me.chkLIF.UseVisualStyleBackColor = True
        '
        'chkLTF
        '
        Me.chkLTF.AutoSize = True
        Me.chkLTF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLTF.Location = New System.Drawing.Point(340, 317)
        Me.chkLTF.Name = "chkLTF"
        Me.chkLTF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkLTF.Size = New System.Drawing.Size(15, 14)
        Me.chkLTF.TabIndex = 178
        Me.chkLTF.TabStop = False
        Me.chkLTF.UseVisualStyleBackColor = True
        '
        'chkRLF
        '
        Me.chkRLF.AutoSize = True
        Me.chkRLF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRLF.Location = New System.Drawing.Point(487, 289)
        Me.chkRLF.Name = "chkRLF"
        Me.chkRLF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkRLF.Size = New System.Drawing.Size(15, 14)
        Me.chkRLF.TabIndex = 177
        Me.chkRLF.TabStop = False
        Me.chkRLF.UseVisualStyleBackColor = True
        '
        'chkRRF
        '
        Me.chkRRF.AutoSize = True
        Me.chkRRF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRRF.Location = New System.Drawing.Point(463, 264)
        Me.chkRRF.Name = "chkRRF"
        Me.chkRRF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkRRF.Size = New System.Drawing.Size(15, 14)
        Me.chkRRF.TabIndex = 176
        Me.chkRRF.TabStop = False
        Me.chkRRF.UseVisualStyleBackColor = True
        '
        'chkRMF
        '
        Me.chkRMF.AutoSize = True
        Me.chkRMF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRMF.Location = New System.Drawing.Point(431, 252)
        Me.chkRMF.Name = "chkRMF"
        Me.chkRMF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkRMF.Size = New System.Drawing.Size(15, 14)
        Me.chkRMF.TabIndex = 175
        Me.chkRMF.TabStop = False
        Me.chkRMF.UseVisualStyleBackColor = True
        '
        'chkRIF
        '
        Me.chkRIF.AutoSize = True
        Me.chkRIF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRIF.Location = New System.Drawing.Point(398, 259)
        Me.chkRIF.Name = "chkRIF"
        Me.chkRIF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkRIF.Size = New System.Drawing.Size(15, 14)
        Me.chkRIF.TabIndex = 174
        Me.chkRIF.TabStop = False
        Me.chkRIF.UseVisualStyleBackColor = True
        '
        'chkRTF
        '
        Me.chkRTF.AutoSize = True
        Me.chkRTF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRTF.Location = New System.Drawing.Point(361, 317)
        Me.chkRTF.Name = "chkRTF"
        Me.chkRTF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkRTF.Size = New System.Drawing.Size(15, 14)
        Me.chkRTF.TabIndex = 173
        Me.chkRTF.TabStop = False
        Me.chkRTF.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(214, 265)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(287, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 172
        Me.PictureBox1.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackgroundImage = CType(resources.GetObject("btnBrowse.BackgroundImage"), System.Drawing.Image)
        Me.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowse.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Location = New System.Drawing.Point(475, 37)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(26, 26)
        Me.btnBrowse.TabIndex = 142
        Me.btnBrowse.TabStop = False
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "Hand copy.png")
        Me.img.Images.SetKeyName(1, "Hand.png")
        Me.img.Images.SetKeyName(2, "Trash copy.png")
        Me.img.Images.SetKeyName(3, "Trash.png")
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(332, 467)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 61)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(426, 467)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(88, 61)
        Me.btnBack.TabIndex = 46
        Me.btnBack.Text = "Back"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Helvetica Condensed", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(-1, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 26)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Employee Information"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(238, 467)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(88, 61)
        Me.btnNew.TabIndex = 124
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'ofdBrowse
        '
        Me.ofdBrowse.Filter = "All Image Formats (*.bmp;*.jpg;*.jpeg;*.gif;*.tif)|*.bmp;*.jpg;*.jpeg;*.gif;*.tif" & _
            "|Bitmaps (*.bmp)|*.bmp|GIFs (*.gif)|*.gif|JPEGs (*.jpg)|*.jpg;*.jpeg|TIFs (*.tif" & _
            ")|*.tif"
        '
        'frmEmployeeInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(521, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbxEmployeeInfo)
        Me.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmEmployeeInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtMiddlename, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirstname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastname, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxEmployeeInfo.ResumeLayout(False)
        Me.gbxEmployeeInfo.PerformLayout()
        CType(Me.txtDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMiddlename As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFirstname As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLastname As C1.Win.C1Input.C1TextBox
    Friend WithEvents gbxEmployeeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents chkLLF As System.Windows.Forms.CheckBox
    Friend WithEvents chkLRF As System.Windows.Forms.CheckBox
    Friend WithEvents chkLMF As System.Windows.Forms.CheckBox
    Friend WithEvents chkLIF As System.Windows.Forms.CheckBox
    Friend WithEvents chkLTF As System.Windows.Forms.CheckBox
    Friend WithEvents chkRLF As System.Windows.Forms.CheckBox
    Friend WithEvents chkRRF As System.Windows.Forms.CheckBox
    Friend WithEvents chkRMF As System.Windows.Forms.CheckBox
    Friend WithEvents chkRIF As System.Windows.Forms.CheckBox
    Friend WithEvents chkRTF As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents picEmployee As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnDeletePicture As System.Windows.Forms.Button
    Friend WithEvents btnCamera As System.Windows.Forms.Button
    Friend WithEvents txtCode As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents ofdBrowse As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnBrowseSchedules As System.Windows.Forms.Button
    Friend WithEvents txtSchedule As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseDepartment As System.Windows.Forms.Button
    Friend WithEvents txtDepartment As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
