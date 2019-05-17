<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtSearch = New C1.Win.C1Input.C1TextBox()
        Me.tdbSearch = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Location = New System.Drawing.Point(547, 39)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(25, 26)
        Me.btnSearch.TabIndex = 44
        Me.btnSearch.TabStop = False
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Image = CType(resources.GetObject("btnSelect.Image"), System.Drawing.Image)
        Me.btnSelect.Location = New System.Drawing.Point(390, 300)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(88, 61)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "Select"
        Me.btnSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(484, 300)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(88, 61)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(6, 39)
        Me.txtSearch.MaxLength = 70
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(542, 26)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Tag = Nothing
        Me.txtSearch.TextDetached = True
        '
        'tdbSearch
        '
        Me.tdbSearch.AllowColMove = False
        Me.tdbSearch.AllowColSelect = False
        Me.tdbSearch.AllowFilter = False
        Me.tdbSearch.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbSearch.AllowSort = False
        Me.tdbSearch.AllowUpdate = False
        Me.tdbSearch.AllowUpdateOnBlur = False
        Me.tdbSearch.CaptionHeight = 17
        Me.tdbSearch.ExtendRightColumn = True
        Me.tdbSearch.Images.Add(CType(resources.GetObject("tdbSearch.Images"), System.Drawing.Image))
        Me.tdbSearch.Location = New System.Drawing.Point(6, 63)
        Me.tdbSearch.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdbSearch.Name = "tdbSearch"
        Me.tdbSearch.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbSearch.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbSearch.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbSearch.PrintInfo.PageSettings = CType(resources.GetObject("tdbSearch.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbSearch.PropBag = resources.GetString("tdbSearch.PropBag")
        Me.tdbSearch.RecordSelectors = False
        Me.tdbSearch.RowHeight = 27
        Me.tdbSearch.Size = New System.Drawing.Size(566, 231)
        Me.tdbSearch.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.GridNavigation
        Me.tdbSearch.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Helvetica Condensed", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(-1, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 26)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Search"
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(578, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.tdbSearch)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("HelveticaNeueLT Com 45 Lt", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtSearch As C1.Win.C1Input.C1TextBox
    Friend WithEvents tdbSearch As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
