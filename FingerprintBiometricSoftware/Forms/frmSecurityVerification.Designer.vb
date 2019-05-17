<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecurityVerification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSecurityVerification))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPassword = New C1.Win.C1Input.C1TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtUsername = New C1.Win.C1Input.C1TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(184, 151)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 61)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(278, 151)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(88, 61)
        Me.btnBack.TabIndex = 3
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
        Me.Label6.Size = New System.Drawing.Size(170, 26)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Security Verification"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(8, 119)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtPassword.Size = New System.Drawing.Size(358, 26)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Tag = Nothing
        Me.txtPassword.TextDetached = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(4, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 20)
        Me.Label14.TabIndex = 144
        Me.Label14.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(8, 67)
        Me.txtUsername.MaxLength = 20
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(358, 26)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.Tag = Nothing
        Me.txtUsername.TextDetached = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(4, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 20)
        Me.Label13.TabIndex = 142
        Me.Label13.Text = "Username"
        '
        'frmSecurityVerification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(376, 220)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label13)
        Me.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "frmSecurityVerification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
