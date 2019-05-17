<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectionSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnectionSettings))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsername = New C1.Win.C1Input.C1TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtServerName = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPort = New C1.Win.C1Input.C1TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New C1.Win.C1Input.C1TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cboDatabase = New C1.Win.C1List.C1Combo()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(140, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "User"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(180, 91)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(139, 21)
        Me.txtUsername.TabIndex = 40
        Me.txtUsername.Tag = Nothing
        Me.txtUsername.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(91, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 15)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Server Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtServerName
        '
        Me.txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServerName.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerName.Location = New System.Drawing.Point(180, 64)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(212, 21)
        Me.txtServerName.TabIndex = 38
        Me.txtServerName.Tag = Nothing
        Me.txtServerName.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Port"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPort
        '
        Me.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPort.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.Location = New System.Drawing.Point(180, 146)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(139, 21)
        Me.txtPort.TabIndex = 44
        Me.txtPort.Tag = Nothing
        Me.txtPort.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(180, 119)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(139, 21)
        Me.txtPassword.TabIndex = 42
        Me.txtPassword.Tag = Nothing
        Me.txtPassword.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Database Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(7, 203)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 40)
        Me.btnSave.TabIndex = 48
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(91, 203)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 40)
        Me.btnCancel.TabIndex = 49
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'cboDatabase
        '
        Me.cboDatabase.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cboDatabase.Caption = ""
        Me.cboDatabase.CaptionHeight = 17
        Me.cboDatabase.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboDatabase.ColumnCaptionHeight = 17
        Me.cboDatabase.ColumnFooterHeight = 17
        Me.cboDatabase.ColumnHeaders = False
        Me.cboDatabase.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboDatabase.ContentHeight = 18
        Me.cboDatabase.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.cboDatabase.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboDatabase.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboDatabase.EditorFont = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDatabase.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDatabase.EditorHeight = 18
        Me.cboDatabase.ExtendRightColumn = True
        Me.cboDatabase.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDatabase.Images.Add(CType(resources.GetObject("cboDatabase.Images"), System.Drawing.Image))
        Me.cboDatabase.ItemHeight = 15
        Me.cboDatabase.Location = New System.Drawing.Point(180, 173)
        Me.cboDatabase.MatchEntryTimeout = CType(2000, Long)
        Me.cboDatabase.MaxDropDownItems = CType(5, Short)
        Me.cboDatabase.MaxLength = 32767
        Me.cboDatabase.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboDatabase.Name = "cboDatabase"
        Me.cboDatabase.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboDatabase.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboDatabase.Size = New System.Drawing.Size(212, 22)
        Me.cboDatabase.TabIndex = 53
        Me.cboDatabase.PropBag = resources.GetString("cboDatabase.PropBag")
        '
        'frmConnectionSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(492, 249)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboDatabase)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtServerName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConnectionSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtServerName As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPort As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cboDatabase As C1.Win.C1List.C1Combo
End Class
