<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVintage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVintage))
        Me.gboVintage2 = New System.Windows.Forms.GroupBox()
        Me.chkYes = New System.Windows.Forms.CheckBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.picVintage = New System.Windows.Forms.PictureBox()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.cboHeelCounter = New System.Windows.Forms.ComboBox()
        Me.cboEyestay = New System.Windows.Forms.ComboBox()
        Me.cboVamp = New System.Windows.Forms.ComboBox()
        Me.cboQuarter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtVintagePrice = New System.Windows.Forms.TextBox()
        Me.gboVintage2.SuspendLayout()
        CType(Me.picVintage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gboVintage2
        '
        Me.gboVintage2.Controls.Add(Me.chkYes)
        Me.gboVintage2.Controls.Add(Me.btnUpload)
        Me.gboVintage2.Controls.Add(Me.picVintage)
        Me.gboVintage2.Controls.Add(Me.txtText)
        Me.gboVintage2.Controls.Add(Me.cboHeelCounter)
        Me.gboVintage2.Controls.Add(Me.cboEyestay)
        Me.gboVintage2.Controls.Add(Me.cboVamp)
        Me.gboVintage2.Controls.Add(Me.cboQuarter)
        Me.gboVintage2.Controls.Add(Me.Label1)
        Me.gboVintage2.Controls.Add(Me.Label2)
        Me.gboVintage2.Controls.Add(Me.Label3)
        Me.gboVintage2.Controls.Add(Me.Label5)
        Me.gboVintage2.Controls.Add(Me.Label6)
        Me.gboVintage2.Controls.Add(Me.Label7)
        Me.gboVintage2.Location = New System.Drawing.Point(10, 63)
        Me.gboVintage2.Name = "gboVintage2"
        Me.gboVintage2.Size = New System.Drawing.Size(778, 266)
        Me.gboVintage2.TabIndex = 23
        Me.gboVintage2.TabStop = False
        Me.gboVintage2.Text = "Step 2 Customisation"
        '
        'chkYes
        '
        Me.chkYes.AutoSize = True
        Me.chkYes.Location = New System.Drawing.Point(113, 48)
        Me.chkYes.Name = "chkYes"
        Me.chkYes.Size = New System.Drawing.Size(44, 17)
        Me.chkYes.TabIndex = 45
        Me.chkYes.Text = "Yes"
        Me.chkYes.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(239, 40)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(96, 38)
        Me.btnUpload.TabIndex = 44
        Me.btnUpload.Text = "Upload Image"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'picVintage
        '
        Me.picVintage.Image = CType(resources.GetObject("picVintage.Image"), System.Drawing.Image)
        Me.picVintage.Location = New System.Drawing.Point(365, 13)
        Me.picVintage.Name = "picVintage"
        Me.picVintage.Size = New System.Drawing.Size(403, 247)
        Me.picVintage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVintage.TabIndex = 42
        Me.picVintage.TabStop = False
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(214, 227)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(121, 20)
        Me.txtText.TabIndex = 41
        '
        'cboHeelCounter
        '
        Me.cboHeelCounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHeelCounter.FormattingEnabled = True
        Me.cboHeelCounter.Items.AddRange(New Object() {"White", "Red", "Blue", "Green", "Light Grey", "Orange", "PUrple", "Violet"})
        Me.cboHeelCounter.Location = New System.Drawing.Point(214, 187)
        Me.cboHeelCounter.Name = "cboHeelCounter"
        Me.cboHeelCounter.Size = New System.Drawing.Size(121, 21)
        Me.cboHeelCounter.TabIndex = 39
        '
        'cboEyestay
        '
        Me.cboEyestay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEyestay.FormattingEnabled = True
        Me.cboEyestay.Items.AddRange(New Object() {"White", "Red", "Blue", "Green", "Light Grey", "Orange", "Purple", "Violet"})
        Me.cboEyestay.Location = New System.Drawing.Point(214, 152)
        Me.cboEyestay.Name = "cboEyestay"
        Me.cboEyestay.Size = New System.Drawing.Size(121, 21)
        Me.cboEyestay.TabIndex = 37
        '
        'cboVamp
        '
        Me.cboVamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVamp.FormattingEnabled = True
        Me.cboVamp.Items.AddRange(New Object() {"White", "Red", "Blue", "Green", "Light Grey", "Orange", "Purple", "Violet"})
        Me.cboVamp.Location = New System.Drawing.Point(214, 114)
        Me.cboVamp.Name = "cboVamp"
        Me.cboVamp.Size = New System.Drawing.Size(121, 21)
        Me.cboVamp.TabIndex = 36
        '
        'cboQuarter
        '
        Me.cboQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQuarter.FormattingEnabled = True
        Me.cboQuarter.Items.AddRange(New Object() {"White", "Red ", "Blue", "Green", "Light Grey", "Orange", "Purple", "Violet"})
        Me.cboQuarter.Location = New System.Drawing.Point(214, 84)
        Me.cboQuarter.Name = "cboQuarter"
        Me.cboQuarter.Size = New System.Drawing.Size(121, 21)
        Me.cboQuarter.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Text(Up to 10 characters .45c extra after."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Logo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Heel/Back Counter"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Eyestay"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Vamp"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Quater"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(575, 374)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(97, 23)
        Me.btnCalculate.TabIndex = 24
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtVintagePrice
        '
        Me.txtVintagePrice.Location = New System.Drawing.Point(678, 374)
        Me.txtVintagePrice.Name = "txtVintagePrice"
        Me.txtVintagePrice.ReadOnly = True
        Me.txtVintagePrice.Size = New System.Drawing.Size(100, 20)
        Me.txtVintagePrice.TabIndex = 25
        '
        'frmVintage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtVintagePrice)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gboVintage2)
        Me.Name = "frmVintage"
        Me.Text = "Vintage"
        Me.gboVintage2.ResumeLayout(False)
        Me.gboVintage2.PerformLayout()
        CType(Me.picVintage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gboVintage2 As GroupBox
    Friend WithEvents picVintage As PictureBox
    Friend WithEvents txtText As TextBox
    Friend WithEvents cboHeelCounter As ComboBox
    Friend WithEvents cboEyestay As ComboBox
    Friend WithEvents cboVamp As ComboBox
    Friend WithEvents cboQuarter As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtVintagePrice As TextBox
    Friend WithEvents chkYes As CheckBox
    Friend WithEvents btnUpload As Button
End Class
