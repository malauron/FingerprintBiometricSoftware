<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPDTRs
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPDTRs))
        Me.cboCutoffPeriods = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDepartments = New System.Windows.Forms.DataGridView()
        Me.department_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isChecked = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboSortBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.rpv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCutoffPeriods
        '
        Me.cboCutoffPeriods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCutoffPeriods.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCutoffPeriods.FormattingEnabled = True
        Me.cboCutoffPeriods.Location = New System.Drawing.Point(6, 107)
        Me.cboCutoffPeriods.Name = "cboCutoffPeriods"
        Me.cboCutoffPeriods.Size = New System.Drawing.Size(226, 23)
        Me.cboCutoffPeriods.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 15)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Cutoff Period"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvDepartments)
        Me.GroupBox1.Controls.Add(Me.cboSortBy)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboCutoffPeriods)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnView)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 493)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'dgvDepartments
        '
        Me.dgvDepartments.AllowUserToAddRows = False
        Me.dgvDepartments.AllowUserToDeleteRows = False
        Me.dgvDepartments.AllowUserToResizeColumns = False
        Me.dgvDepartments.AllowUserToResizeRows = False
        Me.dgvDepartments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDepartments.BackgroundColor = System.Drawing.Color.White
        Me.dgvDepartments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDepartments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDepartments.ColumnHeadersHeight = 20
        Me.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDepartments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.department_id, Me.isChecked, Me.description})
        Me.dgvDepartments.Location = New System.Drawing.Point(9, 210)
        Me.dgvDepartments.MultiSelect = False
        Me.dgvDepartments.Name = "dgvDepartments"
        Me.dgvDepartments.RowHeadersVisible = False
        Me.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDepartments.Size = New System.Drawing.Size(222, 207)
        Me.dgvDepartments.TabIndex = 43
        '
        'department_id
        '
        Me.department_id.DataPropertyName = "department_id"
        Me.department_id.HeaderText = "Department ID"
        Me.department_id.Name = "department_id"
        Me.department_id.ReadOnly = True
        Me.department_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.department_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.department_id.Visible = False
        '
        'isChecked
        '
        Me.isChecked.DataPropertyName = "isChecked"
        Me.isChecked.HeaderText = ""
        Me.isChecked.Name = "isChecked"
        Me.isChecked.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.isChecked.Width = 20
        '
        'description
        '
        Me.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.description.DataPropertyName = "description"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description.DefaultCellStyle = DataGridViewCellStyle1
        Me.description.FillWeight = 98.47716!
        Me.description.HeaderText = "Department"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cboSortBy
        '
        Me.cboSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSortBy.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSortBy.FormattingEnabled = True
        Me.cboSortBy.Location = New System.Drawing.Point(6, 161)
        Me.cboSortBy.Name = "cboSortBy"
        Me.cboSortBy.Size = New System.Drawing.Size(226, 23)
        Me.cboSortBy.TabIndex = 37
        Me.cboSortBy.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 23)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Sort by"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Image)
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(6, 16)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(134, 32)
        Me.btnView.TabIndex = 27
        Me.btnView.Text = "View"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnView.UseVisualStyleBackColor = True
        '
        'rpv
        '
        Me.rpv.ActiveViewIndex = -1
        Me.rpv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rpv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rpv.Cursor = System.Windows.Forms.Cursors.Default
        Me.rpv.EnableRefresh = False
        Me.rpv.Location = New System.Drawing.Point(246, 1)
        Me.rpv.Name = "rpv"
        Me.rpv.ShowGroupTreeButton = False
        Me.rpv.ShowParameterPanelButton = False
        Me.rpv.ShowRefreshButton = False
        Me.rpv.Size = New System.Drawing.Size(686, 493)
        Me.rpv.TabIndex = 4
        Me.rpv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmRPDTRs
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(934, 496)
        Me.Controls.Add(Me.rpv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(939, 534)
        Me.Name = "frmRPDTRs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DTRs"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboCutoffPeriods As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents cboSortBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents rpv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dgvDepartments As System.Windows.Forms.DataGridView
    Friend WithEvents department_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isChecked As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents description As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
