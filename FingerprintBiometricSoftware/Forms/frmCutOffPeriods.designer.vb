<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCutOffPeriods
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCutOffPeriods))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.gbxEmployeeInfo = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateUntil = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.gbxEmployeeInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(332, 148)
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
        Me.btnBack.Location = New System.Drawing.Point(426, 148)
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
        Me.Label6.Size = New System.Drawing.Size(121, 26)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Cut-off Period"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(238, 148)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(88, 61)
        Me.btnNew.TabIndex = 124
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNew.UseVisualStyleBackColor = True
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
        'gbxEmployeeInfo
        '
        Me.gbxEmployeeInfo.BackColor = System.Drawing.Color.Transparent
        Me.gbxEmployeeInfo.Controls.Add(Me.Label3)
        Me.gbxEmployeeInfo.Controls.Add(Me.Label2)
        Me.gbxEmployeeInfo.Controls.Add(Me.dtpDateUntil)
        Me.gbxEmployeeInfo.Controls.Add(Me.dtpDateFrom)
        Me.gbxEmployeeInfo.Controls.Add(Me.btnBrowse)
        Me.gbxEmployeeInfo.Location = New System.Drawing.Point(5, 27)
        Me.gbxEmployeeInfo.Name = "gbxEmployeeInfo"
        Me.gbxEmployeeInfo.Size = New System.Drawing.Size(509, 115)
        Me.gbxEmployeeInfo.TabIndex = 44
        Me.gbxEmployeeInfo.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 203
        Me.Label3.Text = "Until"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 202
        Me.Label2.Text = "From"
        '
        'dtpDateUntil
        '
        Me.dtpDateUntil.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateUntil.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateUntil.Location = New System.Drawing.Point(327, 36)
        Me.dtpDateUntil.Name = "dtpDateUntil"
        Me.dtpDateUntil.Size = New System.Drawing.Size(115, 27)
        Me.dtpDateUntil.TabIndex = 201
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateFrom.Location = New System.Drawing.Point(131, 36)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(115, 27)
        Me.dtpDateFrom.TabIndex = 200
        '
        'frmCutOffPeriods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(521, 216)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbxEmployeeInfo)
        Me.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmCutOffPeriods"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbxEmployeeInfo.ResumeLayout(False)
        Me.gbxEmployeeInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents gbxEmployeeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateUntil As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
