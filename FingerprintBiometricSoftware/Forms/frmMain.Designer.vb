<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblNotice = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAdminTasks = New System.Windows.Forms.Button()
        Me.gbxEmployeeInfo = New System.Windows.Forms.GroupBox()
        Me.lblTimeLog = New System.Windows.Forms.Label()
        Me.lblInOut = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.picEmployee = New System.Windows.Forms.PictureBox()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.employee_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.logstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxEmployeeInfo.SuspendLayout()
        CType(Me.picEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNotice
        '
        Me.lblNotice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNotice.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice.ForeColor = System.Drawing.Color.White
        Me.lblNotice.Location = New System.Drawing.Point(0, 405)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(543, 43)
        Me.lblNotice.TabIndex = 9
        Me.lblNotice.Text = "Place your finger on the scanner."
        Me.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 143)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(544, 263)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.White
        Me.lblDate.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 14.0!)
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(0, 89)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(542, 42)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Wendesday, September 30, 2012"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.White
        Me.lblTime.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(-1, 126)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(543, 25)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "12:00:00 AM"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSettings
        '
        Me.btnSettings.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 10.0!)
        Me.btnSettings.Location = New System.Drawing.Point(270, 447)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(272, 44)
        Me.btnSettings.TabIndex = 12
        Me.btnSettings.TabStop = False
        Me.btnSettings.Text = "Database Connection Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(543, 95)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnAdminTasks
        '
        Me.btnAdminTasks.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 10.0!)
        Me.btnAdminTasks.Location = New System.Drawing.Point(-1, 447)
        Me.btnAdminTasks.Name = "btnAdminTasks"
        Me.btnAdminTasks.Size = New System.Drawing.Size(272, 44)
        Me.btnAdminTasks.TabIndex = 18
        Me.btnAdminTasks.TabStop = False
        Me.btnAdminTasks.Text = "Administrative Tasks"
        Me.btnAdminTasks.UseVisualStyleBackColor = True
        '
        'gbxEmployeeInfo
        '
        Me.gbxEmployeeInfo.BackColor = System.Drawing.Color.White
        Me.gbxEmployeeInfo.Controls.Add(Me.lblTimeLog)
        Me.gbxEmployeeInfo.Controls.Add(Me.lblInOut)
        Me.gbxEmployeeInfo.Controls.Add(Me.pb)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label5)
        Me.gbxEmployeeInfo.Controls.Add(Me.lblFullname)
        Me.gbxEmployeeInfo.Controls.Add(Me.picEmployee)
        Me.gbxEmployeeInfo.Location = New System.Drawing.Point(1, 154)
        Me.gbxEmployeeInfo.Name = "gbxEmployeeInfo"
        Me.gbxEmployeeInfo.Size = New System.Drawing.Size(539, 252)
        Me.gbxEmployeeInfo.TabIndex = 20
        Me.gbxEmployeeInfo.TabStop = False
        Me.gbxEmployeeInfo.Visible = False
        '
        'lblTimeLog
        '
        Me.lblTimeLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTimeLog.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLog.ForeColor = System.Drawing.Color.White
        Me.lblTimeLog.Location = New System.Drawing.Point(207, 89)
        Me.lblTimeLog.Name = "lblTimeLog"
        Me.lblTimeLog.Size = New System.Drawing.Size(329, 63)
        Me.lblTimeLog.TabIndex = 205
        Me.lblTimeLog.Text = "IN/OUT"
        Me.lblTimeLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInOut
        '
        Me.lblInOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInOut.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInOut.ForeColor = System.Drawing.Color.White
        Me.lblInOut.Location = New System.Drawing.Point(207, 13)
        Me.lblInOut.Name = "lblInOut"
        Me.lblInOut.Size = New System.Drawing.Size(329, 76)
        Me.lblInOut.TabIndex = 204
        Me.lblInOut.Text = "IN/OUT"
        Me.lblInOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(4, 218)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(531, 27)
        Me.pb.TabIndex = 203
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(207, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(329, 19)
        Me.Label5.TabIndex = 202
        Me.Label5.Text = "Employee Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFullname
        '
        Me.lblFullname.BackColor = System.Drawing.Color.Silver
        Me.lblFullname.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 14.0!)
        Me.lblFullname.ForeColor = System.Drawing.Color.Black
        Me.lblFullname.Location = New System.Drawing.Point(207, 171)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(329, 42)
        Me.lblFullname.TabIndex = 201
        Me.lblFullname.Text = "MARK ANTHONY M. LAURON"
        Me.lblFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picEmployee
        '
        Me.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEmployee.Location = New System.Drawing.Point(4, 13)
        Me.picEmployee.Name = "picEmployee"
        Me.picEmployee.Size = New System.Drawing.Size(200, 200)
        Me.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmployee.TabIndex = 196
        Me.picEmployee.TabStop = False
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.AllowUserToResizeColumns = False
        Me.dgvList.AllowUserToResizeRows = False
        Me.dgvList.BackgroundColor = System.Drawing.Color.White
        Me.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.employee_name, Me.logstatus})
        Me.dgvList.GridColor = System.Drawing.Color.White
        Me.dgvList.Location = New System.Drawing.Point(542, 33)
        Me.dgvList.MultiSelect = False
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvList.Size = New System.Drawing.Size(425, 456)
        Me.dgvList.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(542, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(425, 34)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Today's Log"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStatus
        '
        Me.btnStatus.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 35.0!, System.Drawing.FontStyle.Bold)
        Me.btnStatus.ForeColor = System.Drawing.Color.Red
        Me.btnStatus.Location = New System.Drawing.Point(172, 341)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(190, 61)
        Me.btnStatus.TabIndex = 204
        Me.btnStatus.TabStop = False
        Me.btnStatus.Text = "OUT"
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'employee_name
        '
        Me.employee_name.DataPropertyName = "employee_name"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.employee_name.DefaultCellStyle = DataGridViewCellStyle3
        Me.employee_name.HeaderText = "Name"
        Me.employee_name.Name = "employee_name"
        Me.employee_name.ReadOnly = True
        Me.employee_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.employee_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.employee_name.Width = 300
        '
        'logstatus
        '
        Me.logstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.logstatus.DataPropertyName = "logstatus"
        DataGridViewCellStyle4.Format = "g"
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.logstatus.DefaultCellStyle = DataGridViewCellStyle4
        Me.logstatus.HeaderText = "Status"
        Me.logstatus.Name = "logstatus"
        Me.logstatus.ReadOnly = True
        Me.logstatus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.logstatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(967, 490)
        Me.Controls.Add(Me.gbxEmployeeInfo)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnAdminTasks)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvList)
        Me.Controls.Add(Me.lblNotice)
        Me.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fingerprint Biometric Sofware"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxEmployeeInfo.ResumeLayout(False)
        CType(Me.picEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblNotice As System.Windows.Forms.Label
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnAdminTasks As System.Windows.Forms.Button
    Friend WithEvents gbxEmployeeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblFullname As System.Windows.Forms.Label
    Friend WithEvents picEmployee As System.Windows.Forms.PictureBox
    Friend WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
    Friend WithEvents lblTimeLog As System.Windows.Forms.Label
    Friend WithEvents lblInOut As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnStatus As System.Windows.Forms.Button
    Friend WithEvents employee_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents logstatus As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
