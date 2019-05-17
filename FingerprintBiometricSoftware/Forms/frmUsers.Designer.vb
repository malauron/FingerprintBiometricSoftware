<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        Me.gbUser = New System.Windows.Forms.GroupBox()
        Me.btnShowResetPassword = New System.Windows.Forms.Button()
        Me.txtConfirm = New C1.Win.C1Input.C1TextBox()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.chkMnu_Cutoff_Periods = New System.Windows.Forms.CheckBox()
        Me.chkMnu_Assign_Schedules = New System.Windows.Forms.CheckBox()
        Me.chkMnu_Print_DTR = New System.Windows.Forms.CheckBox()
        Me.chkMnu_DTR_Adjustments = New System.Windows.Forms.CheckBox()
        Me.chkMnu_Generate_DTR = New System.Windows.Forms.CheckBox()
        Me.chkMnu_Employee_Info = New System.Windows.Forms.CheckBox()
        Me.chkMnu_Schedules = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkMnu_Users = New System.Windows.Forms.CheckBox()
        Me.txtUser_Password = New C1.Win.C1Input.C1TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New C1.Win.C1Input.C1TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFullname = New C1.Win.C1Input.C1TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.gbResetPassword = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtRConfirm = New C1.Win.C1Input.C1TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRPassword = New C1.Win.C1Input.C1TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbUser.SuspendLayout()
        CType(Me.txtConfirm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser_Password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFullname, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResetPassword.SuspendLayout()
        CType(Me.txtRConfirm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbUser
        '
        Me.gbUser.BackColor = System.Drawing.Color.White
        Me.gbUser.Controls.Add(Me.btnShowResetPassword)
        Me.gbUser.Controls.Add(Me.txtConfirm)
        Me.gbUser.Controls.Add(Me.lblConfirm)
        Me.gbUser.Controls.Add(Me.chkMnu_Cutoff_Periods)
        Me.gbUser.Controls.Add(Me.chkMnu_Assign_Schedules)
        Me.gbUser.Controls.Add(Me.chkMnu_Print_DTR)
        Me.gbUser.Controls.Add(Me.chkMnu_DTR_Adjustments)
        Me.gbUser.Controls.Add(Me.chkMnu_Generate_DTR)
        Me.gbUser.Controls.Add(Me.chkMnu_Employee_Info)
        Me.gbUser.Controls.Add(Me.chkMnu_Schedules)
        Me.gbUser.Controls.Add(Me.Label1)
        Me.gbUser.Controls.Add(Me.chkMnu_Users)
        Me.gbUser.Controls.Add(Me.txtUser_Password)
        Me.gbUser.Controls.Add(Me.lblPassword)
        Me.gbUser.Controls.Add(Me.txtUsername)
        Me.gbUser.Controls.Add(Me.Label13)
        Me.gbUser.Controls.Add(Me.btnBrowse)
        Me.gbUser.Controls.Add(Me.txtFullname)
        Me.gbUser.Controls.Add(Me.Label2)
        Me.gbUser.Location = New System.Drawing.Point(7, 30)
        Me.gbUser.Name = "gbUser"
        Me.gbUser.Size = New System.Drawing.Size(461, 214)
        Me.gbUser.TabIndex = 47
        Me.gbUser.TabStop = False
        '
        'btnShowResetPassword
        '
        Me.btnShowResetPassword.Image = CType(resources.GetObject("btnShowResetPassword.Image"), System.Drawing.Image)
        Me.btnShowResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowResetPassword.Location = New System.Drawing.Point(149, 73)
        Me.btnShowResetPassword.Name = "btnShowResetPassword"
        Me.btnShowResetPassword.Size = New System.Drawing.Size(162, 45)
        Me.btnShowResetPassword.TabIndex = 124
        Me.btnShowResetPassword.Text = "Reset Password"
        Me.btnShowResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowResetPassword.UseVisualStyleBackColor = True
        Me.btnShowResetPassword.Visible = False
        '
        'txtConfirm
        '
        Me.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirm.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirm.Location = New System.Drawing.Point(91, 93)
        Me.txtConfirm.MaxLength = 20
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtConfirm.Size = New System.Drawing.Size(358, 26)
        Me.txtConfirm.TabIndex = 143
        Me.txtConfirm.Tag = Nothing
        Me.txtConfirm.TextDetached = True
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.Location = New System.Drawing.Point(6, 95)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(66, 20)
        Me.lblConfirm.TabIndex = 144
        Me.lblConfirm.Text = "Confirm"
        '
        'chkMnu_Cutoff_Periods
        '
        Me.chkMnu_Cutoff_Periods.AutoSize = True
        Me.chkMnu_Cutoff_Periods.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMnu_Cutoff_Periods.Location = New System.Drawing.Point(178, 167)
        Me.chkMnu_Cutoff_Periods.Name = "chkMnu_Cutoff_Periods"
        Me.chkMnu_Cutoff_Periods.Size = New System.Drawing.Size(101, 19)
        Me.chkMnu_Cutoff_Periods.TabIndex = 142
        Me.chkMnu_Cutoff_Periods.Text = "Cutoff Periods"
        Me.chkMnu_Cutoff_Periods.UseVisualStyleBackColor = True
        '
        'chkMnu_Assign_Schedules
        '
        Me.chkMnu_Assign_Schedules.AutoSize = True
        Me.chkMnu_Assign_Schedules.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMnu_Assign_Schedules.Location = New System.Drawing.Point(178, 189)
        Me.chkMnu_Assign_Schedules.Name = "chkMnu_Assign_Schedules"
        Me.chkMnu_Assign_Schedules.Size = New System.Drawing.Size(119, 19)
        Me.chkMnu_Assign_Schedules.TabIndex = 141
        Me.chkMnu_Assign_Schedules.Text = "Assign Schedules"
        Me.chkMnu_Assign_Schedules.UseVisualStyleBackColor = True
        '
        'chkMnu_Print_DTR
        '
        Me.chkMnu_Print_DTR.AutoSize = True
        Me.chkMnu_Print_DTR.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMnu_Print_DTR.Location = New System.Drawing.Point(325, 189)
        Me.chkMnu_Print_DTR.Name = "chkMnu_Print_DTR"
        Me.chkMnu_Print_DTR.Size = New System.Drawing.Size(77, 19)
        Me.chkMnu_Print_DTR.TabIndex = 140
        Me.chkMnu_Print_DTR.Text = "Print DTR"
        Me.chkMnu_Print_DTR.UseVisualStyleBackColor = True
        '
        'chkMnu_DTR_Adjustments
        '
        Me.chkMnu_DTR_Adjustments.AutoSize = True
        Me.chkMnu_DTR_Adjustments.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMnu_DTR_Adjustments.Location = New System.Drawing.Point(325, 167)
        Me.chkMnu_DTR_Adjustments.Name = "chkMnu_DTR_Adjustments"
        Me.chkMnu_DTR_Adjustments.Size = New System.Drawing.Size(119, 19)
        Me.chkMnu_DTR_Adjustments.TabIndex = 139
        Me.chkMnu_DTR_Adjustments.Text = "DTR Adjustments"
        Me.chkMnu_DTR_Adjustments.UseVisualStyleBackColor = True
        '
        'chkMnu_Generate_DTR
        '
        Me.chkMnu_Generate_DTR.AutoSize = True
        Me.chkMnu_Generate_DTR.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMnu_Generate_DTR.Location = New System.Drawing.Point(325, 145)
        Me.chkMnu_Generate_DTR.Name = "chkMnu_Generate_DTR"
        Me.chkMnu_Generate_DTR.Size = New System.Drawing.Size(100, 19)
        Me.chkMnu_Generate_DTR.TabIndex = 138
        Me.chkMnu_Generate_DTR.Text = "Generate DTR"
        Me.chkMnu_Generate_DTR.UseVisualStyleBackColor = True
        '
        'chkMnu_Employee_Info
        '
        Me.chkMnu_Employee_Info.AutoSize = True
        Me.chkMnu_Employee_Info.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMnu_Employee_Info.Location = New System.Drawing.Point(10, 167)
        Me.chkMnu_Employee_Info.Name = "chkMnu_Employee_Info"
        Me.chkMnu_Employee_Info.Size = New System.Drawing.Size(143, 19)
        Me.chkMnu_Employee_Info.TabIndex = 137
        Me.chkMnu_Employee_Info.Text = "Employee Information"
        Me.chkMnu_Employee_Info.UseVisualStyleBackColor = True
        '
        'chkMnu_Schedules
        '
        Me.chkMnu_Schedules.AutoSize = True
        Me.chkMnu_Schedules.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMnu_Schedules.Location = New System.Drawing.Point(178, 145)
        Me.chkMnu_Schedules.Name = "chkMnu_Schedules"
        Me.chkMnu_Schedules.Size = New System.Drawing.Size(80, 19)
        Me.chkMnu_Schedules.TabIndex = 136
        Me.chkMnu_Schedules.Text = "Schedules"
        Me.chkMnu_Schedules.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 20)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Menu Access:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkMnu_Users
        '
        Me.chkMnu_Users.AutoSize = True
        Me.chkMnu_Users.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMnu_Users.Location = New System.Drawing.Point(10, 145)
        Me.chkMnu_Users.Name = "chkMnu_Users"
        Me.chkMnu_Users.Size = New System.Drawing.Size(56, 19)
        Me.chkMnu_Users.TabIndex = 134
        Me.chkMnu_Users.Text = "Users"
        Me.chkMnu_Users.UseVisualStyleBackColor = True
        '
        'txtUser_Password
        '
        Me.txtUser_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser_Password.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser_Password.Location = New System.Drawing.Point(91, 68)
        Me.txtUser_Password.MaxLength = 20
        Me.txtUser_Password.Name = "txtUser_Password"
        Me.txtUser_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtUser_Password.Size = New System.Drawing.Size(358, 26)
        Me.txtUser_Password.TabIndex = 132
        Me.txtUser_Password.Tag = Nothing
        Me.txtUser_Password.TextDetached = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(6, 70)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(83, 20)
        Me.lblPassword.TabIndex = 133
        Me.lblPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(91, 43)
        Me.txtUsername.MaxLength = 20
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(358, 26)
        Me.txtUsername.TabIndex = 130
        Me.txtUsername.Tag = Nothing
        Me.txtUsername.TextDetached = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 20)
        Me.Label13.TabIndex = 131
        Me.Label13.Text = "Username"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackgroundImage = CType(resources.GetObject("btnBrowse.BackgroundImage"), System.Drawing.Image)
        Me.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowse.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Location = New System.Drawing.Point(422, 18)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(27, 27)
        Me.btnBrowse.TabIndex = 127
        Me.btnBrowse.TabStop = False
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFullname
        '
        Me.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullname.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(91, 18)
        Me.txtFullname.MaxLength = 20
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(334, 26)
        Me.txtFullname.TabIndex = 108
        Me.txtFullname.Tag = Nothing
        Me.txtFullname.TextDetached = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Full name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Helvetica Condensed", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(-1, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 26)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Users"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(279, 247)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 61)
        Me.btnSave.TabIndex = 48
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(373, 247)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(88, 61)
        Me.btnBack.TabIndex = 49
        Me.btnBack.Text = "Back"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(185, 247)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(88, 61)
        Me.btnNew.TabIndex = 123
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'gbResetPassword
        '
        Me.gbResetPassword.BackColor = System.Drawing.Color.White
        Me.gbResetPassword.Controls.Add(Me.btnReset)
        Me.gbResetPassword.Controls.Add(Me.btnCancel)
        Me.gbResetPassword.Controls.Add(Me.txtRConfirm)
        Me.gbResetPassword.Controls.Add(Me.Label3)
        Me.gbResetPassword.Controls.Add(Me.Label4)
        Me.gbResetPassword.Controls.Add(Me.txtRPassword)
        Me.gbResetPassword.Controls.Add(Me.Label5)
        Me.gbResetPassword.Location = New System.Drawing.Point(486, 37)
        Me.gbResetPassword.Name = "gbResetPassword"
        Me.gbResetPassword.Size = New System.Drawing.Size(461, 271)
        Me.gbResetPassword.TabIndex = 124
        Me.gbResetPassword.TabStop = False
        Me.gbResetPassword.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.Location = New System.Drawing.Point(273, 204)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(88, 61)
        Me.btnReset.TabIndex = 145
        Me.btnReset.Text = "Save"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(367, 204)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 61)
        Me.btnCancel.TabIndex = 146
        Me.btnCancel.Text = "Back"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtRConfirm
        '
        Me.txtRConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRConfirm.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRConfirm.Location = New System.Drawing.Point(91, 93)
        Me.txtRConfirm.MaxLength = 20
        Me.txtRConfirm.Name = "txtRConfirm"
        Me.txtRConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtRConfirm.Size = New System.Drawing.Size(358, 26)
        Me.txtRConfirm.TabIndex = 143
        Me.txtRConfirm.Tag = Nothing
        Me.txtRConfirm.TextDetached = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Confirm"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(461, 20)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Reset Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRPassword
        '
        Me.txtRPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRPassword.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRPassword.Location = New System.Drawing.Point(91, 68)
        Me.txtRPassword.MaxLength = 20
        Me.txtRPassword.Name = "txtRPassword"
        Me.txtRPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtRPassword.Size = New System.Drawing.Size(358, 26)
        Me.txtRPassword.TabIndex = 132
        Me.txtRPassword.Tag = Nothing
        Me.txtRPassword.TextDetached = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "Password"
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(479, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbResetPassword)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gbUser)
        Me.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbUser.ResumeLayout(False)
        Me.gbUser.PerformLayout()
        CType(Me.txtConfirm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser_Password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFullname, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResetPassword.ResumeLayout(False)
        Me.gbResetPassword.PerformLayout()
        CType(Me.txtRConfirm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbUser As System.Windows.Forms.GroupBox
    Friend WithEvents txtUser_Password As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUsername As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFullname As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents chkMnu_Schedules As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkMnu_Users As System.Windows.Forms.CheckBox
    Friend WithEvents chkMnu_Print_DTR As System.Windows.Forms.CheckBox
    Friend WithEvents chkMnu_DTR_Adjustments As System.Windows.Forms.CheckBox
    Friend WithEvents chkMnu_Generate_DTR As System.Windows.Forms.CheckBox
    Friend WithEvents chkMnu_Employee_Info As System.Windows.Forms.CheckBox
    Friend WithEvents chkMnu_Assign_Schedules As System.Windows.Forms.CheckBox
    Friend WithEvents chkMnu_Cutoff_Periods As System.Windows.Forms.CheckBox
    Friend WithEvents txtConfirm As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents btnShowResetPassword As System.Windows.Forms.Button
    Friend WithEvents gbResetPassword As System.Windows.Forms.GroupBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtRConfirm As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRPassword As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
