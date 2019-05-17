<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedules
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchedules))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxEmployeeInfo = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt3rd_outsched = New C1.Win.C1Input.C1DateEdit()
        Me.txt3rd_insched = New C1.Win.C1Input.C1DateEdit()
        Me.txt2nd_outsched = New C1.Win.C1Input.C1DateEdit()
        Me.txt2nd_insched = New C1.Win.C1Input.C1DateEdit()
        Me.txt1st_outsched = New C1.Win.C1Input.C1DateEdit()
        Me.txt1st_insched = New C1.Win.C1Input.C1DateEdit()
        Me.txtDescription = New C1.Win.C1Input.C1TextBox()
        Me.gbxEmployeeInfo.SuspendLayout()
        CType(Me.txt3rd_outsched, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3rd_insched, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2nd_outsched, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2nd_insched, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1st_outsched, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1st_insched, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(332, 234)
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
        Me.btnBack.Location = New System.Drawing.Point(426, 234)
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
        Me.Label6.Size = New System.Drawing.Size(94, 26)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Schedules"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(238, 234)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(88, 61)
        Me.btnNew.TabIndex = 124
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(199, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 20)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "IN"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(262, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 20)
        Me.Label13.TabIndex = 131
        Me.Label13.Text = "OUT"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "Description"
        '
        'gbxEmployeeInfo
        '
        Me.gbxEmployeeInfo.BackColor = System.Drawing.Color.Transparent
        Me.gbxEmployeeInfo.Controls.Add(Me.Label5)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label4)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label3)
        Me.gbxEmployeeInfo.Controls.Add(Me.txt3rd_outsched)
        Me.gbxEmployeeInfo.Controls.Add(Me.txt3rd_insched)
        Me.gbxEmployeeInfo.Controls.Add(Me.txt2nd_outsched)
        Me.gbxEmployeeInfo.Controls.Add(Me.txt2nd_insched)
        Me.gbxEmployeeInfo.Controls.Add(Me.txt1st_outsched)
        Me.gbxEmployeeInfo.Controls.Add(Me.txt1st_insched)
        Me.gbxEmployeeInfo.Controls.Add(Me.txtDescription)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label1)
        Me.gbxEmployeeInfo.Controls.Add(Me.btnBrowse)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label13)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label2)
        Me.gbxEmployeeInfo.Location = New System.Drawing.Point(5, 27)
        Me.gbxEmployeeInfo.Name = "gbxEmployeeInfo"
        Me.gbxEmployeeInfo.Size = New System.Drawing.Size(509, 201)
        Me.gbxEmployeeInfo.TabIndex = 44
        Me.gbxEmployeeInfo.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(107, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 217
        Me.Label5.Text = "3RD"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 216
        Me.Label4.Text = "2ND"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 215
        Me.Label3.Text = "1ST"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt3rd_outsched
        '
        Me.txt3rd_outsched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txt3rd_outsched.Calendar.DayNameLength = 1
        Me.txt3rd_outsched.DisplayFormat.EmptyAsNull = False
        Me.txt3rd_outsched.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txt3rd_outsched.EditFormat.EmptyAsNull = False
        Me.txt3rd_outsched.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txt3rd_outsched.EmptyAsNull = True
        Me.txt3rd_outsched.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortTime
        Me.txt3rd_outsched.Location = New System.Drawing.Point(252, 159)
        Me.txt3rd_outsched.Name = "txt3rd_outsched"
        Me.txt3rd_outsched.Size = New System.Drawing.Size(83, 26)
        Me.txt3rd_outsched.TabIndex = 214
        Me.txt3rd_outsched.Tag = Nothing
        Me.txt3rd_outsched.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txt3rd_insched
        '
        Me.txt3rd_insched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txt3rd_insched.Calendar.DayNameLength = 1
        Me.txt3rd_insched.DisplayFormat.EmptyAsNull = False
        Me.txt3rd_insched.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txt3rd_insched.EditFormat.EmptyAsNull = False
        Me.txt3rd_insched.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txt3rd_insched.EmptyAsNull = True
        Me.txt3rd_insched.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortTime
        Me.txt3rd_insched.Location = New System.Drawing.Point(163, 159)
        Me.txt3rd_insched.Name = "txt3rd_insched"
        Me.txt3rd_insched.Size = New System.Drawing.Size(83, 26)
        Me.txt3rd_insched.TabIndex = 213
        Me.txt3rd_insched.Tag = Nothing
        Me.txt3rd_insched.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txt2nd_outsched
        '
        Me.txt2nd_outsched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txt2nd_outsched.Calendar.DayNameLength = 1
        Me.txt2nd_outsched.DisplayFormat.EmptyAsNull = False
        Me.txt2nd_outsched.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txt2nd_outsched.EditFormat.EmptyAsNull = False
        Me.txt2nd_outsched.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txt2nd_outsched.EmptyAsNull = True
        Me.txt2nd_outsched.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortTime
        Me.txt2nd_outsched.Location = New System.Drawing.Point(252, 128)
        Me.txt2nd_outsched.Name = "txt2nd_outsched"
        Me.txt2nd_outsched.Size = New System.Drawing.Size(83, 26)
        Me.txt2nd_outsched.TabIndex = 212
        Me.txt2nd_outsched.Tag = Nothing
        Me.txt2nd_outsched.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txt2nd_insched
        '
        Me.txt2nd_insched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txt2nd_insched.Calendar.DayNameLength = 1
        Me.txt2nd_insched.DisplayFormat.EmptyAsNull = False
        Me.txt2nd_insched.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txt2nd_insched.EditFormat.EmptyAsNull = False
        Me.txt2nd_insched.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txt2nd_insched.EmptyAsNull = True
        Me.txt2nd_insched.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortTime
        Me.txt2nd_insched.Location = New System.Drawing.Point(163, 128)
        Me.txt2nd_insched.Name = "txt2nd_insched"
        Me.txt2nd_insched.Size = New System.Drawing.Size(83, 26)
        Me.txt2nd_insched.TabIndex = 211
        Me.txt2nd_insched.Tag = Nothing
        Me.txt2nd_insched.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txt1st_outsched
        '
        Me.txt1st_outsched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txt1st_outsched.Calendar.DayNameLength = 1
        Me.txt1st_outsched.DisplayFormat.EmptyAsNull = False
        Me.txt1st_outsched.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txt1st_outsched.EditFormat.EmptyAsNull = False
        Me.txt1st_outsched.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txt1st_outsched.EmptyAsNull = True
        Me.txt1st_outsched.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortTime
        Me.txt1st_outsched.Location = New System.Drawing.Point(252, 96)
        Me.txt1st_outsched.Name = "txt1st_outsched"
        Me.txt1st_outsched.Size = New System.Drawing.Size(83, 26)
        Me.txt1st_outsched.TabIndex = 210
        Me.txt1st_outsched.Tag = Nothing
        Me.txt1st_outsched.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txt1st_insched
        '
        Me.txt1st_insched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txt1st_insched.Calendar.DayNameLength = 1
        Me.txt1st_insched.DisplayFormat.EmptyAsNull = False
        Me.txt1st_insched.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txt1st_insched.EditFormat.EmptyAsNull = False
        Me.txt1st_insched.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txt1st_insched.EmptyAsNull = True
        Me.txt1st_insched.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortTime
        Me.txt1st_insched.Location = New System.Drawing.Point(163, 96)
        Me.txt1st_insched.Name = "txt1st_insched"
        Me.txt1st_insched.Size = New System.Drawing.Size(83, 26)
        Me.txt1st_insched.TabIndex = 201
        Me.txt1st_insched.Tag = Nothing
        Me.txt1st_insched.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(111, 37)
        Me.txtDescription.MaxLength = 50
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(365, 26)
        Me.txtDescription.TabIndex = 0
        Me.txtDescription.Tag = Nothing
        Me.txtDescription.TextDetached = True
        '
        'frmSchedules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(521, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbxEmployeeInfo)
        Me.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmSchedules"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbxEmployeeInfo.ResumeLayout(False)
        Me.gbxEmployeeInfo.PerformLayout()
        CType(Me.txt3rd_outsched, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3rd_insched, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2nd_outsched, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2nd_insched, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1st_outsched, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1st_insched, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbxEmployeeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescription As C1.Win.C1Input.C1TextBox
    Friend WithEvents txt1st_insched As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txt3rd_outsched As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txt3rd_insched As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txt2nd_outsched As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txt2nd_insched As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txt1st_outsched As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
