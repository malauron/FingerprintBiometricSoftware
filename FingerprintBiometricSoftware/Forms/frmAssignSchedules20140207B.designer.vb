<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignSchedules20140207
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssignSchedules20140207))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnBrowseEmployee = New System.Windows.Forms.Button()
        Me.gbxEmployeeInfo = New System.Windows.Forms.GroupBox()
        Me.cboSchedules = New C1.Win.C1List.C1Combo()
        Me.tdbAssignSchedules = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.txtCutoffPeriod = New C1.Win.C1Input.C1TextBox()
        Me.btnBrowseCutoffPeriod = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New C1.Win.C1Input.C1TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxEmployeeInfo.SuspendLayout()
        CType(Me.cboSchedules, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbAssignSchedules, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCutoffPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmployeeName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(769, 483)
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
        Me.btnBack.Location = New System.Drawing.Point(858, 483)
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
        Me.Label6.Size = New System.Drawing.Size(151, 26)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Assign Schedules"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(680, 483)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(88, 61)
        Me.btnNew.TabIndex = 124
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNew.UseVisualStyleBackColor = True
        Me.btnNew.Visible = False
        '
        'btnBrowseEmployee
        '
        Me.btnBrowseEmployee.BackgroundImage = CType(resources.GetObject("btnBrowseEmployee.BackgroundImage"), System.Drawing.Image)
        Me.btnBrowseEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBrowseEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowseEmployee.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseEmployee.ForeColor = System.Drawing.Color.Black
        Me.btnBrowseEmployee.Location = New System.Drawing.Point(509, 48)
        Me.btnBrowseEmployee.Name = "btnBrowseEmployee"
        Me.btnBrowseEmployee.Size = New System.Drawing.Size(26, 26)
        Me.btnBrowseEmployee.TabIndex = 142
        Me.btnBrowseEmployee.TabStop = False
        Me.btnBrowseEmployee.UseVisualStyleBackColor = True
        '
        'gbxEmployeeInfo
        '
        Me.gbxEmployeeInfo.BackColor = System.Drawing.Color.Transparent
        Me.gbxEmployeeInfo.Controls.Add(Me.cboSchedules)
        Me.gbxEmployeeInfo.Controls.Add(Me.tdbAssignSchedules)
        Me.gbxEmployeeInfo.Controls.Add(Me.txtCutoffPeriod)
        Me.gbxEmployeeInfo.Controls.Add(Me.btnBrowseCutoffPeriod)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label1)
        Me.gbxEmployeeInfo.Controls.Add(Me.txtEmployeeName)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label2)
        Me.gbxEmployeeInfo.Controls.Add(Me.btnBrowseEmployee)
        Me.gbxEmployeeInfo.Location = New System.Drawing.Point(5, 27)
        Me.gbxEmployeeInfo.Name = "gbxEmployeeInfo"
        Me.gbxEmployeeInfo.Size = New System.Drawing.Size(941, 455)
        Me.gbxEmployeeInfo.TabIndex = 44
        Me.gbxEmployeeInfo.TabStop = False
        '
        'cboSchedules
        '
        Me.cboSchedules.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboSchedules.AllowColMove = False
        Me.cboSchedules.AutoCompletion = True
        Me.cboSchedules.AutoDropDown = True
        Me.cboSchedules.Caption = ""
        Me.cboSchedules.CaptionHeight = 17
        Me.cboSchedules.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSchedules.ColumnCaptionHeight = 17
        Me.cboSchedules.ColumnFooterHeight = 17
        Me.cboSchedules.ColumnHeaders = False
        Me.cboSchedules.ColumnWidth = 100
        Me.cboSchedules.ContentHeight = 22
        Me.cboSchedules.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboSchedules.DropDownWidth = 476
        Me.cboSchedules.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboSchedules.EditorFont = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSchedules.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSchedules.EditorHeight = 22
        Me.cboSchedules.ExtendRightColumn = True
        Me.cboSchedules.Images.Add(CType(resources.GetObject("cboSchedules.Images"), System.Drawing.Image))
        Me.cboSchedules.ItemHeight = 20
        Me.cboSchedules.LimitToList = True
        Me.cboSchedules.Location = New System.Drawing.Point(135, 241)
        Me.cboSchedules.MatchEntryTimeout = CType(2000, Long)
        Me.cboSchedules.MaxDropDownItems = CType(20, Short)
        Me.cboSchedules.MaxLength = 32767
        Me.cboSchedules.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboSchedules.Name = "cboSchedules"
        Me.cboSchedules.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboSchedules.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboSchedules.Size = New System.Drawing.Size(476, 28)
        Me.cboSchedules.TabIndex = 211
        Me.cboSchedules.Visible = False
        Me.cboSchedules.PropBag = resources.GetString("cboSchedules.PropBag")
        '
        'tdbAssignSchedules
        '
        Me.tdbAssignSchedules.AllowColMove = False
        Me.tdbAssignSchedules.AllowColSelect = False
        Me.tdbAssignSchedules.AllowFilter = False
        Me.tdbAssignSchedules.AllowRowSelect = False
        Me.tdbAssignSchedules.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbAssignSchedules.AllowSort = False
        Me.tdbAssignSchedules.AllowUpdateOnBlur = False
        Me.tdbAssignSchedules.CaptionHeight = 17
        Me.tdbAssignSchedules.ExtendRightColumn = True
        Me.tdbAssignSchedules.Images.Add(CType(resources.GetObject("tdbAssignSchedules.Images"), System.Drawing.Image))
        Me.tdbAssignSchedules.Location = New System.Drawing.Point(7, 80)
        Me.tdbAssignSchedules.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell
        Me.tdbAssignSchedules.Name = "tdbAssignSchedules"
        Me.tdbAssignSchedules.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbAssignSchedules.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbAssignSchedules.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbAssignSchedules.PrintInfo.PageSettings = CType(resources.GetObject("tdbAssignSchedules.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbAssignSchedules.PropBag = resources.GetString("tdbAssignSchedules.PropBag")
        Me.tdbAssignSchedules.RecordSelectors = False
        Me.tdbAssignSchedules.RowHeight = 25
        Me.tdbAssignSchedules.Size = New System.Drawing.Size(928, 369)
        Me.tdbAssignSchedules.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.GridNavigation
        Me.tdbAssignSchedules.TabIndex = 210
        '
        'txtCutoffPeriod
        '
        Me.txtCutoffPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCutoffPeriod.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCutoffPeriod.Location = New System.Drawing.Point(120, 16)
        Me.txtCutoffPeriod.MaxLength = 20
        Me.txtCutoffPeriod.Name = "txtCutoffPeriod"
        Me.txtCutoffPeriod.ReadOnly = True
        Me.txtCutoffPeriod.Size = New System.Drawing.Size(390, 26)
        Me.txtCutoffPeriod.TabIndex = 209
        Me.txtCutoffPeriod.Tag = Nothing
        Me.txtCutoffPeriod.TextDetached = True
        '
        'btnBrowseCutoffPeriod
        '
        Me.btnBrowseCutoffPeriod.BackgroundImage = CType(resources.GetObject("btnBrowseCutoffPeriod.BackgroundImage"), System.Drawing.Image)
        Me.btnBrowseCutoffPeriod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBrowseCutoffPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowseCutoffPeriod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseCutoffPeriod.ForeColor = System.Drawing.Color.Black
        Me.btnBrowseCutoffPeriod.Location = New System.Drawing.Point(509, 16)
        Me.btnBrowseCutoffPeriod.Name = "btnBrowseCutoffPeriod"
        Me.btnBrowseCutoffPeriod.Size = New System.Drawing.Size(26, 26)
        Me.btnBrowseCutoffPeriod.TabIndex = 208
        Me.btnBrowseCutoffPeriod.TabStop = False
        Me.btnBrowseCutoffPeriod.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "Cutoff Period"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeName.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName.Location = New System.Drawing.Point(120, 48)
        Me.txtEmployeeName.MaxLength = 20
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.ReadOnly = True
        Me.txtEmployeeName.Size = New System.Drawing.Size(390, 26)
        Me.txtEmployeeName.TabIndex = 205
        Me.txtEmployeeName.Tag = Nothing
        Me.txtEmployeeName.TextDetached = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 202
        Me.Label2.Text = "Employee"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAssignSchedules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(950, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbxEmployeeInfo)
        Me.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmAssignSchedules"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbxEmployeeInfo.ResumeLayout(False)
        Me.gbxEmployeeInfo.PerformLayout()
        CType(Me.cboSchedules, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbAssignSchedules, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCutoffPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmployeeName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnBrowseEmployee As System.Windows.Forms.Button
    Friend WithEvents gbxEmployeeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeName As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCutoffPeriod As C1.Win.C1Input.C1TextBox
    Friend WithEvents btnBrowseCutoffPeriod As System.Windows.Forms.Button
    Friend WithEvents cboSchedules As C1.Win.C1List.C1Combo
    Friend WithEvents tdbAssignSchedules As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
