<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRetro))
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtFinalPriceRetro = New System.Windows.Forms.TextBox()
        Me.gboCustomizationRetroClassic = New System.Windows.Forms.GroupBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.chkYes = New System.Windows.Forms.CheckBox()
        Me.picRet = New System.Windows.Forms.PictureBox()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.cboHeelCounter = New System.Windows.Forms.ComboBox()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.cboHeelTab = New System.Windows.Forms.ComboBox()
        Me.cboEyestay = New System.Windows.Forms.ComboBox()
        Me.cboVamp = New System.Windows.Forms.ComboBox()
        Me.cboQuarter = New System.Windows.Forms.ComboBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblHeel = New System.Windows.Forms.Label()
        Me.lblHeelTab = New System.Windows.Forms.Label()
        Me.lblEyestay = New System.Windows.Forms.Label()
        Me.lblVamp = New System.Windows.Forms.Label()
        Me.lblQuater = New System.Windows.Forms.Label()
        Me.gboCustomizationRetroClassic.SuspendLayout()
        CType(Me.picRet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(574, 358)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 17
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtFinalPriceRetro
        '
        Me.txtFinalPriceRetro.Location = New System.Drawing.Point(655, 360)
        Me.txtFinalPriceRetro.Name = "txtFinalPriceRetro"
        Me.txtFinalPriceRetro.ReadOnly = True
        Me.txtFinalPriceRetro.Size = New System.Drawing.Size(133, 20)
        Me.txtFinalPriceRetro.TabIndex = 16
        '
        'gboCustomizationRetroClassic
        '
        Me.gboCustomizationRetroClassic.Controls.Add(Me.btnUpload)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.chkYes)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.picRet)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.txtText)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.cboHeelCounter)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.lblLogo)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.cboHeelTab)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.cboEyestay)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.cboVamp)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.cboQuarter)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.lblText)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.lblHeel)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.lblHeelTab)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.lblEyestay)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.lblVamp)
        Me.gboCustomizationRetroClassic.Controls.Add(Me.lblQuater)
        Me.gboCustomizationRetroClassic.Location = New System.Drawing.Point(13, 70)
        Me.gboCustomizationRetroClassic.Name = "gboCustomizationRetroClassic"
        Me.gboCustomizationRetroClassic.Size = New System.Drawing.Size(774, 255)
        Me.gboCustomizationRetroClassic.TabIndex = 15
        Me.gboCustomizationRetroClassic.TabStop = False
        Me.gboCustomizationRetroClassic.Text = "Step 2: Customization"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(269, 19)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(83, 35)
        Me.btnUpload.TabIndex = 23
        Me.btnUpload.Text = "Upload Logo"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'chkYes
        '
        Me.chkYes.AutoSize = True
        Me.chkYes.Location = New System.Drawing.Point(126, 31)
        Me.chkYes.Name = "chkYes"
        Me.chkYes.Size = New System.Drawing.Size(44, 17)
        Me.chkYes.TabIndex = 22
        Me.chkYes.Text = "Yes"
        Me.chkYes.UseVisualStyleBackColor = True
        '
        'picRet
        '
        Me.picRet.Image = CType(resources.GetObject("picRet.Image"), System.Drawing.Image)
        Me.picRet.Location = New System.Drawing.Point(375, 20)
        Me.picRet.Name = "picRet"
        Me.picRet.Size = New System.Drawing.Size(393, 229)
        Me.picRet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRet.TabIndex = 21
        Me.picRet.TabStop = False
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(231, 195)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(100, 20)
        Me.txtText.TabIndex = 20
        '
        'cboHeelCounter
        '
        Me.cboHeelCounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHeelCounter.FormattingEnabled = True
        Me.cboHeelCounter.Items.AddRange(New Object() {"White", "Red", "Blue", "Green", "Light Grey", "Orange", "PUrple", "Violet"})
        Me.cboHeelCounter.Location = New System.Drawing.Point(231, 171)
        Me.cboHeelCounter.Name = "cboHeelCounter"
        Me.cboHeelCounter.Size = New System.Drawing.Size(121, 21)
        Me.cboHeelCounter.TabIndex = 18
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Location = New System.Drawing.Point(15, 31)
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
        Me.cboHeelTab.Location = New System.Drawing.Point(231, 146)
        Me.cboHeelTab.Name = "cboHeelTab"
        Me.cboHeelTab.Size = New System.Drawing.Size(121, 21)
        Me.cboHeelTab.TabIndex = 17
        '
        'cboEyestay
        '
        Me.cboEyestay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEyestay.FormattingEnabled = True
        Me.cboEyestay.Items.AddRange(New Object() {"White", "Red", "Blue", "Green", "Light Grey", "Orange", "Purple", "Violet"})
        Me.cboEyestay.Location = New System.Drawing.Point(231, 119)
        Me.cboEyestay.Name = "cboEyestay"
        Me.cboEyestay.Size = New System.Drawing.Size(121, 21)
        Me.cboEyestay.TabIndex = 16
        '
        'cboVamp
        '
        Me.cboVamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVamp.FormattingEnabled = True
        Me.cboVamp.Items.AddRange(New Object() {"White", "Red", "Blue", "Green", "Light Grey", "Orange", "Purple", "Violet"})
        Me.cboVamp.Location = New System.Drawing.Point(231, 90)
        Me.cboVamp.Name = "cboVamp"
        Me.cboVamp.Size = New System.Drawing.Size(121, 21)
        Me.cboVamp.TabIndex = 15
        '
        'cboQuarter
        '
        Me.cboQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuarter.FormattingEnabled = True
        Me.cboQuarter.Items.AddRange(New Object() {"White", "Red ", "Blue", "Green", "Light Grey", "Orange", "Purple", "Violet"})
        Me.cboQuarter.Location = New System.Drawing.Point(231, 64)
        Me.cboQuarter.Name = "cboQuarter"
        Me.cboQuarter.Size = New System.Drawing.Size(121, 21)
        Me.cboQuarter.TabIndex = 14
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(12, 202)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(202, 13)
        Me.lblText.TabIndex = 6
        Me.lblText.Text = "Text(Up to 10 characters .45c extra after."
        '
        'lblHeel
        '
        Me.lblHeel.AutoSize = True
        Me.lblHeel.Location = New System.Drawing.Point(12, 180)
        Me.lblHeel.Name = "lblHeel"
        Me.lblHeel.Size = New System.Drawing.Size(99, 13)
        Me.lblHeel.TabIndex = 4
        Me.lblHeel.Text = "Heel/Back Counter"
        '
        'lblHeelTab
        '
        Me.lblHeelTab.AutoSize = True
        Me.lblHeelTab.Location = New System.Drawing.Point(12, 151)
        Me.lblHeelTab.Name = "lblHeelTab"
        Me.lblHeelTab.Size = New System.Drawing.Size(51, 13)
        Me.lblHeelTab.TabIndex = 3
        Me.lblHeelTab.Text = "Heel Tab"
        '
        'lblEyestay
        '
        Me.lblEyestay.AutoSize = True
        Me.lblEyestay.Location = New System.Drawing.Point(12, 119)
        Me.lblEyestay.Name = "lblEyestay"
        Me.lblEyestay.Size = New System.Drawing.Size(44, 13)
        Me.lblEyestay.TabIndex = 2
        Me.lblEyestay.Text = "Eyestay"
        '
        'lblVamp
        '
        Me.lblVamp.AutoSize = True
        Me.lblVamp.Location = New System.Drawing.Point(12, 90)
        Me.lblVamp.Name = "lblVamp"
        Me.lblVamp.Size = New System.Drawing.Size(34, 13)
        Me.lblVamp.TabIndex = 1
        Me.lblVamp.Text = "Vamp"
        '
        'lblQuater
        '
        Me.lblQuater.AutoSize = True
        Me.lblQuater.Location = New System.Drawing.Point(12, 60)
        Me.lblQuater.Name = "lblQuater"
        Me.lblQuater.Size = New System.Drawing.Size(39, 13)
        Me.lblQuater.TabIndex = 0
        Me.lblQuater.Text = "Quater"
        '
        'frmRetro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtFinalPriceRetro)
        Me.Controls.Add(Me.gboCustomizationRetroClassic)
        Me.Name = "frmRetro"
        Me.Text = "Retro"
        Me.gboCustomizationRetroClassic.ResumeLayout(False)
        Me.gboCustomizationRetroClassic.PerformLayout()
        CType(Me.picRet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtFinalPriceRetro As TextBox
    Friend WithEvents gboCustomizationRetroClassic As GroupBox
    Friend WithEvents picRet As PictureBox
    Friend WithEvents txtText As TextBox
    Friend WithEvents cboHeelCounter As ComboBox
    Friend WithEvents cboHeelTab As ComboBox
    Friend WithEvents cboEyestay As ComboBox
    Friend WithEvents cboVamp As ComboBox
    Friend WithEvents cboQuarter As ComboBox
    Friend WithEvents lblText As Label
    Friend WithEvents lblLogo As Label
    Friend WithEvents lblHeel As Label
    Friend WithEvents lblHeelTab As Label
    Friend WithEvents lblEyestay As Label
    Friend WithEvents lblVamp As Label
    Friend WithEvents lblQuater As Label
    Friend WithEvents chkYes As CheckBox
    Friend WithEvents btnUpload As Button
End Class
