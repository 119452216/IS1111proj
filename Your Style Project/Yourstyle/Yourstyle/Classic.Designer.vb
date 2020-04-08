<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClassic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassic))
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtFinalPriceClassic = New System.Windows.Forms.TextBox()
        Me.gboCustomizationRetroClassic = New System.Windows.Forms.GroupBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.picClassic = New System.Windows.Forms.PictureBox()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.cboHeelCounter = New System.Windows.Forms.ComboBox()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.cboHeelTab = New System.Windows.Forms.ComboBox()
        Me.chkYes = New System.Windows.Forms.CheckBox()
        Me.cboEyestay = New System.Windows.Forms.ComboBox()
        Me.cboVamp = New System.Windows.Forms.ComboBox()
        Me.cboQuarter = New System.Windows.Forms.ComboBox()
        Me.chkYesText = New System.Windows.Forms.CheckBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblHeel = New System.Windows.Forms.Label()
        Me.lblHeelTab = New System.Windows.Forms.Label()
        Me.lblEyestay = New System.Windows.Forms.Label()
        Me.lblVamp = New System.Windows.Forms.Label()
        Me.lblQuater = New System.Windows.Forms.Label()
        Me.gboCustomizationRetroClassic.SuspendLayout()
        CType(Me.picClassic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(483, 366)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 15
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtFinalPriceClassic
        '
        Me.txtFinalPriceClassic.Location = New System.Drawing.Point(564, 368)
        Me.txtFinalPriceClassic.Name = "txtFinalPriceClassic"
        Me.txtFinalPriceClassic.ReadOnly = True
        Me.txtFinalPriceClassic.Size = New System.Drawing.Size(133, 20)
        Me.txtFinalPriceClassic.TabIndex = 14
        '
        'gboCustomizationRetroClassic
        '
        Me.gboCustomizationRetroClassic.Controls.Add(Me.btnUpload)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.picClassic)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.txtText)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.cboHeelCounter)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.lblLogo)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.cboHeelTab)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.chkYes)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.cboEyestay)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.cboVamp)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.cboQuarter)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.chkYesText)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.lblText)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.lblHeel)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.lblHeelTab)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.lblEyestay)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.lblVamp)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.lblQuater)
        Me.gboCustomizationRetroClassic.Location = New System.Drawing.Point(3, 62)
        Me.gboCustomizationRetroClassic.Name = "gboCustomizationRetroClassic"
        Me.gboCustomizationRetroClassic.Size = New System.Drawing.Size(794, 274)
        Me.gboCustomizationRetroClassic.TabIndex = 13
        Me.gboCustomizationRetroClassic.TabStop = False
        Me.gboCustomizationRetroClassic.Text = "Step 2: Customization"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(260, 29)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 35)
        Me.btnUpload.TabIndex = 23
        Me.btnUpload.Text = "Upload Image"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'picClassic
        '
        Me.picClassic.Image = CType(resources.GetObject("picClassic.Image"), System.Drawing.Image)
        Me.picClassic.Location = New System.Drawing.Point(392, 19)
        Me.picClassic.Name = "picClassic"
        Me.picClassic.Size = New System.Drawing.Size(376, 249)
        Me.picClassic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClassic.TabIndex = 22
        Me.picClassic.TabStop = False
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(286, 219)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(100, 20)
        Me.txtText.TabIndex = 20
        '
        'cboHeelCounter
        '
        Me.cboHeelCounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHeelCounter.FormattingEnabled = True
        Me.cboHeelCounter.Items.AddRange(New Object() {"White", "Red", "Blue", "Green", "Light Grey", "Orange", "PUrple", "Violet"})
        Me.cboHeelCounter.Location = New System.Drawing.Point(214, 195)
        Me.cboHeelCounter.Name = "cboHeelCounter"
        Me.cboHeelCounter.Size = New System.Drawing.Size(121, 21)
        Me.cboHeelCounter.TabIndex = 18
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Location = New System.Drawing.Point(12, 39)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(31, 13)
        Me.lblLogo.TabIndex = 5
        Me.lblLogo.Text = "Logo"
        '
        'cboHeelTab
        '
        Me.cboHeelTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHeelTab.FormattingEnabled = True
        Me.cboHeelTab.Items.AddRange(New Object() {"White", "Red", "Blue", "Green", "Light Grey", "Orange", "Purple", "Violet"})
        Me.cboHeelTab.Location = New System.Drawing.Point(214, 161)
        Me.cboHeelTab.Name = "cboHeelTab"
        Me.cboHeelTab.Size = New System.Drawing.Size(121, 21)
        Me.cboHeelTab.TabIndex = 17
        '
        'chkYes
        '
        Me.chkYes.AutoSize = True
        Me.chkYes.Location = New System.Drawing.Point(112, 39)
        Me.chkYes.Name = "chkYes"
        Me.chkYes.Size = New System.Drawing.Size(44, 17)
        Me.chkYes.TabIndex = 12
        Me.chkYes.Text = "Yes"
        Me.chkYes.UseVisualStyleBackColor = True
        '
        'cboEyestay
        '
        Me.cboEyestay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEyestay.FormattingEnabled = True
        Me.cboEyestay.Items.AddRange(New Object() {"White", "Red", "Blue", "Green", "Light Grey", "Orange", "Purple", "Violet"})
        Me.cboEyestay.Location = New System.Drawing.Point(214, 129)
        Me.cboEyestay.Name = "cboEyestay"
        Me.cboEyestay.Size = New System.Drawing.Size(121, 21)
        Me.cboEyestay.TabIndex = 16
        '
        'cboVamp
        '
        Me.cboVamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVamp.FormattingEnabled = True
        Me.cboVamp.Items.AddRange(New Object() {"White", "Red", "Blue", "Green", "Light Grey", "Orange", "Purple", "Violet"})
        Me.cboVamp.Location = New System.Drawing.Point(214, 100)
        Me.cboVamp.Name = "cboVamp"
        Me.cboVamp.Size = New System.Drawing.Size(121, 21)
        Me.cboVamp.TabIndex = 15
        '
        'cboQuarter
        '
        Me.cboQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuarter.FormattingEnabled = True
        Me.cboQuarter.Items.AddRange(New Object() {"White", "Red ", "Blue", "Green", "Light Grey", "Orange", "Purple", "Violet"})
        Me.cboQuarter.Location = New System.Drawing.Point(214, 70)
        Me.cboQuarter.Name = "cboQuarter"
        Me.cboQuarter.Size = New System.Drawing.Size(121, 21)
        Me.cboQuarter.TabIndex = 14
        '
        'chkYesText
        '
        Me.chkYesText.AutoSize = True
        Me.chkYesText.Location = New System.Drawing.Point(236, 222)
        Me.chkYesText.Name = "chkYesText"
        Me.chkYesText.Size = New System.Drawing.Size(44, 17)
        Me.chkYesText.TabIndex = 13
        Me.chkYesText.Text = "Yes"
        Me.chkYesText.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(12, 227)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(202, 13)
        Me.lblText.TabIndex = 6
        Me.lblText.Text = "Text(Up to 10 characters .45c extra after."
        '
        'lblHeel
        '
        Me.lblHeel.AutoSize = True
        Me.lblHeel.Location = New System.Drawing.Point(12, 198)
        Me.lblHeel.Name = "lblHeel"
        Me.lblHeel.Size = New System.Drawing.Size(99, 13)
        Me.lblHeel.TabIndex = 4
        Me.lblHeel.Text = "Heel/Back Counter"
        '
        'lblHeelTab
        '
        Me.lblHeelTab.AutoSize = True
        Me.lblHeelTab.Location = New System.Drawing.Point(12, 169)
        Me.lblHeelTab.Name = "lblHeelTab"
        Me.lblHeelTab.Size = New System.Drawing.Size(51, 13)
        Me.lblHeelTab.TabIndex = 3
        Me.lblHeelTab.Text = "Heel Tab"
        '
        'lblEyestay
        '
        Me.lblEyestay.AutoSize = True
        Me.lblEyestay.Location = New System.Drawing.Point(12, 137)
        Me.lblEyestay.Name = "lblEyestay"
        Me.lblEyestay.Size = New System.Drawing.Size(44, 13)
        Me.lblEyestay.TabIndex = 2
        Me.lblEyestay.Text = "Eyestay"
        '
        'lblVamp
        '
        Me.lblVamp.AutoSize = True
        Me.lblVamp.Location = New System.Drawing.Point(12, 108)
        Me.lblVamp.Name = "lblVamp"
        Me.lblVamp.Size = New System.Drawing.Size(34, 13)
        Me.lblVamp.TabIndex = 1
        Me.lblVamp.Text = "Vamp"
        '
        'lblQuater
        '
        Me.lblQuater.AutoSize = True
        Me.lblQuater.Location = New System.Drawing.Point(12, 78)
        Me.lblQuater.Name = "lblQuater"
        Me.lblQuater.Size = New System.Drawing.Size(39, 13)
        Me.lblQuater.TabIndex = 0
        Me.lblQuater.Text = "Quater"
        '
        'frmClassic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtFinalPriceClassic)
        Me.Controls.Add(Me.gboCustomizationRetroClassic)
        Me.Name = "frmClassic"
        Me.Text = " Classic"
        Me.gboCustomizationRetroClassic.ResumeLayout(False)
        Me.gboCustomizationRetroClassic.PerformLayout()
        CType(Me.picClassic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtFinalPriceClassic As TextBox
    Friend WithEvents gboCustomizationRetroClassic As GroupBox
    Friend WithEvents picClassic As PictureBox
    Friend WithEvents txtText As TextBox
    Friend WithEvents cboHeelCounter As ComboBox
    Friend WithEvents cboHeelTab As ComboBox
    Friend WithEvents cboEyestay As ComboBox
    Friend WithEvents cboVamp As ComboBox
    Friend WithEvents cboQuarter As ComboBox
    Friend WithEvents chkYesText As CheckBox
    Friend WithEvents chkYes As CheckBox
    Friend WithEvents lblText As Label
    Friend WithEvents lblLogo As Label
    Friend WithEvents lblHeel As Label
    Friend WithEvents lblHeelTab As Label
    Friend WithEvents lblEyestay As Label
    Friend WithEvents lblVamp As Label
    Friend WithEvents lblQuater As Label
    Friend WithEvents btnUpload As Button
End Class
