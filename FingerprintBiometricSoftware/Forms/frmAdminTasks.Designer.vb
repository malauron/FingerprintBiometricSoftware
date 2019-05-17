<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminTasks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminTasks))
        Me.btnEmployeeInfo = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSchedules = New System.Windows.Forms.Button()
        Me.btnGenerateDTR = New System.Windows.Forms.Button()
        Me.btnDTRAdjustments = New System.Windows.Forms.Button()
        Me.btnPrintDTR = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnCutoffPeriods = New System.Windows.Forms.Button()
        Me.btnAssignSchedules = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEmployeeInfo
        '
        Me.btnEmployeeInfo.Image = CType(resources.GetObject("btnEmployeeInfo.Image"), System.Drawing.Image)
        Me.btnEmployeeInfo.Location = New System.Drawing.Point(14, 293)
        Me.btnEmployeeInfo.Name = "btnEmployeeInfo"
        Me.btnEmployeeInfo.Size = New System.Drawing.Size(121, 120)
        Me.btnEmployeeInfo.TabIndex = 48
        Me.btnEmployeeInfo.Text = "Employee Information"
        Me.btnEmployeeInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmployeeInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEmployeeInfo.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(268, 293)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(121, 120)
        Me.btnBack.TabIndex = 49
        Me.btnBack.Text = "      Back                      "
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
        Me.Label6.Size = New System.Drawing.Size(174, 26)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Administrative Tasks"
        '
        'btnSchedules
        '
        Me.btnSchedules.Image = CType(resources.GetObject("btnSchedules.Image"), System.Drawing.Image)
        Me.btnSchedules.Location = New System.Drawing.Point(14, 41)
        Me.btnSchedules.Name = "btnSchedules"
        Me.btnSchedules.Size = New System.Drawing.Size(121, 120)
        Me.btnSchedules.TabIndex = 124
        Me.btnSchedules.Text = "  Schedules        "
        Me.btnSchedules.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSchedules.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSchedules.UseVisualStyleBackColor = True
        '
        'btnGenerateDTR
        '
        Me.btnGenerateDTR.Image = CType(resources.GetObject("btnGenerateDTR.Image"), System.Drawing.Image)
        Me.btnGenerateDTR.Location = New System.Drawing.Point(268, 41)
        Me.btnGenerateDTR.Name = "btnGenerateDTR"
        Me.btnGenerateDTR.Size = New System.Drawing.Size(121, 120)
        Me.btnGenerateDTR.TabIndex = 125
        Me.btnGenerateDTR.Text = "Holiday Schedules"
        Me.btnGenerateDTR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGenerateDTR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnGenerateDTR.UseVisualStyleBackColor = True
        '
        'btnDTRAdjustments
        '
        Me.btnDTRAdjustments.Image = CType(resources.GetObject("btnDTRAdjustments.Image"), System.Drawing.Image)
        Me.btnDTRAdjustments.Location = New System.Drawing.Point(14, 167)
        Me.btnDTRAdjustments.Name = "btnDTRAdjustments"
        Me.btnDTRAdjustments.Size = New System.Drawing.Size(121, 120)
        Me.btnDTRAdjustments.TabIndex = 126
        Me.btnDTRAdjustments.Text = " Import DTR     "
        Me.btnDTRAdjustments.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDTRAdjustments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDTRAdjustments.UseVisualStyleBackColor = True
        '
        'btnPrintDTR
        '
        Me.btnPrintDTR.Image = CType(resources.GetObject("btnPrintDTR.Image"), System.Drawing.Image)
        Me.btnPrintDTR.Location = New System.Drawing.Point(268, 167)
        Me.btnPrintDTR.Name = "btnPrintDTR"
        Me.btnPrintDTR.Size = New System.Drawing.Size(121, 120)
        Me.btnPrintDTR.TabIndex = 127
        Me.btnPrintDTR.Text = "  Print DTR              "
        Me.btnPrintDTR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrintDTR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrintDTR.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.Location = New System.Drawing.Point(141, 293)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(121, 120)
        Me.btnUsers.TabIndex = 128
        Me.btnUsers.Text = "     Users                      "
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnCutoffPeriods
        '
        Me.btnCutoffPeriods.Image = CType(resources.GetObject("btnCutoffPeriods.Image"), System.Drawing.Image)
        Me.btnCutoffPeriods.Location = New System.Drawing.Point(141, 41)
        Me.btnCutoffPeriods.Name = "btnCutoffPeriods"
        Me.btnCutoffPeriods.Size = New System.Drawing.Size(121, 120)
        Me.btnCutoffPeriods.TabIndex = 129
        Me.btnCutoffPeriods.Text = "Cutoff Periods"
        Me.btnCutoffPeriods.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCutoffPeriods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCutoffPeriods.UseVisualStyleBackColor = True
        '
        'btnAssignSchedules
        '
        Me.btnAssignSchedules.Image = CType(resources.GetObject("btnAssignSchedules.Image"), System.Drawing.Image)
        Me.btnAssignSchedules.Location = New System.Drawing.Point(141, 167)
        Me.btnAssignSchedules.Name = "btnAssignSchedules"
        Me.btnAssignSchedules.Size = New System.Drawing.Size(121, 120)
        Me.btnAssignSchedules.TabIndex = 130
        Me.btnAssignSchedules.Text = "Assign Schedules"
        Me.btnAssignSchedules.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAssignSchedules.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAssignSchedules.UseVisualStyleBackColor = True
        '
        'frmAdminTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(403, 425)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAssignSchedules)
        Me.Controls.Add(Me.btnCutoffPeriods)
        Me.Controls.Add(Me.btnUsers)
        Me.Controls.Add(Me.btnPrintDTR)
        Me.Controls.Add(Me.btnDTRAdjustments)
        Me.Controls.Add(Me.btnGenerateDTR)
        Me.Controls.Add(Me.btnSchedules)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEmployeeInfo)
        Me.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdminTasks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEmployeeInfo As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSchedules As System.Windows.Forms.Button
    Friend WithEvents btnGenerateDTR As System.Windows.Forms.Button
    Friend WithEvents btnDTRAdjustments As System.Windows.Forms.Button
    Friend WithEvents btnPrintDTR As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnCutoffPeriods As System.Windows.Forms.Button
    Friend WithEvents btnAssignSchedules As System.Windows.Forms.Button
End Class
