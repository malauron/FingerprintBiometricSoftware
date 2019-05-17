<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnrollFingerprints
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
        Dim Label1 As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnrollFingerprints))
        Me.gbxMain = New System.Windows.Forms.GroupBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.txtPrompt = New System.Windows.Forms.TextBox()
        Me.Pic3 = New System.Windows.Forms.PictureBox()
        Me.Pic2 = New System.Windows.Forms.PictureBox()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.Pic4 = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Me.gbxMain.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(262, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 18)
        Label1.TabIndex = 43
        Label1.Text = "Prompt:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(262, 70)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(50, 18)
        StatusLabel.TabIndex = 40
        StatusLabel.Text = "Status:"
        '
        'gbxMain
        '
        Me.gbxMain.BackColor = System.Drawing.Color.White
        Me.gbxMain.Controls.Add(Me.txtStatus)
        Me.gbxMain.Controls.Add(Me.Picture)
        Me.gbxMain.Controls.Add(Label1)
        Me.gbxMain.Controls.Add(StatusLabel)
        Me.gbxMain.Controls.Add(Me.txtPrompt)
        Me.gbxMain.Controls.Add(Me.Pic3)
        Me.gbxMain.Controls.Add(Me.Pic2)
        Me.gbxMain.Controls.Add(Me.picMain)
        Me.gbxMain.Controls.Add(Me.pic1)
        Me.gbxMain.Controls.Add(Me.Pic4)
        Me.gbxMain.Controls.Add(Me.btnSave)
        Me.gbxMain.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxMain.Location = New System.Drawing.Point(2, 43)
        Me.gbxMain.Name = "gbxMain"
        Me.gbxMain.Size = New System.Drawing.Size(608, 406)
        Me.gbxMain.TabIndex = 20
        Me.gbxMain.TabStop = False
        '
        'txtStatus
        '
        Me.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStatus.BackColor = System.Drawing.SystemColors.Window
        Me.txtStatus.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.Black
        Me.txtStatus.Location = New System.Drawing.Point(260, 91)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtStatus.Size = New System.Drawing.Size(342, 266)
        Me.txtStatus.TabIndex = 41
        '
        'Picture
        '
        Me.Picture.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Picture.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picture.Location = New System.Drawing.Point(6, 15)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(248, 288)
        Me.Picture.TabIndex = 44
        Me.Picture.TabStop = False
        '
        'txtPrompt
        '
        Me.txtPrompt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrompt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrompt.ForeColor = System.Drawing.Color.Black
        Me.txtPrompt.Location = New System.Drawing.Point(260, 41)
        Me.txtPrompt.Name = "txtPrompt"
        Me.txtPrompt.ReadOnly = True
        Me.txtPrompt.Size = New System.Drawing.Size(341, 26)
        Me.txtPrompt.TabIndex = 39
        '
        'Pic3
        '
        Me.Pic3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic3.Location = New System.Drawing.Point(131, 309)
        Me.Pic3.Name = "Pic3"
        Me.Pic3.Size = New System.Drawing.Size(48, 48)
        Me.Pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Pic3.TabIndex = 38
        Me.Pic3.TabStop = False
        '
        'Pic2
        '
        Me.Pic2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic2.Location = New System.Drawing.Point(77, 309)
        Me.Pic2.Name = "Pic2"
        Me.Pic2.Size = New System.Drawing.Size(48, 48)
        Me.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Pic2.TabIndex = 37
        Me.Pic2.TabStop = False
        '
        'picMain
        '
        Me.picMain.Image = CType(resources.GetObject("picMain.Image"), System.Drawing.Image)
        Me.picMain.Location = New System.Drawing.Point(272, 352)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(48, 48)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMain.TabIndex = 31
        Me.picMain.TabStop = False
        Me.picMain.Visible = False
        '
        'pic1
        '
        Me.pic1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic1.Location = New System.Drawing.Point(23, 309)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(48, 48)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic1.TabIndex = 36
        Me.pic1.TabStop = False
        '
        'Pic4
        '
        Me.Pic4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pic4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic4.Location = New System.Drawing.Point(185, 309)
        Me.Pic4.Name = "Pic4"
        Me.Pic4.Size = New System.Drawing.Size(48, 48)
        Me.Pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Pic4.TabIndex = 34
        Me.Pic4.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(502, 363)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 32)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(-4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(627, 50)
        Me.lblTitle.TabIndex = 19
        Me.lblTitle.Text = "Fingerprint Registration"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEnrollFingerprints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 450)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.gbxMain)
        Me.KeyPreview = True
        Me.Name = "frmEnrollFingerprints"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enroll Fingerprint"
        Me.gbxMain.ResumeLayout(False)
        Me.gbxMain.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxMain As System.Windows.Forms.GroupBox
    Private WithEvents Picture As System.Windows.Forms.PictureBox
    Private WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtPrompt As System.Windows.Forms.TextBox
    Friend WithEvents Pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
