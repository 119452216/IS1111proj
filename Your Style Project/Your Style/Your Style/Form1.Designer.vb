<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gboTypeOfShoe = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.radVintage = New System.Windows.Forms.RadioButton()
        Me.radRetro = New System.Windows.Forms.RadioButton()
        Me.radClassic = New System.Windows.Forms.RadioButton()
        Me.cboTypeOfShoe = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.gboTypeOfShoe.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboTypeOfShoe
        '
        Me.gboTypeOfShoe.Controls.Add(Me.btnNext)
        Me.gboTypeOfShoe.Controls.Add(Me.radVintage)
        Me.gboTypeOfShoe.Controls.Add(Me.radRetro)
        Me.gboTypeOfShoe.Controls.Add(Me.radClassic)
        Me.gboTypeOfShoe.Controls.Add(Me.cboTypeOfShoe)
        Me.gboTypeOfShoe.Controls.Add(Me.lblType)
        Me.gboTypeOfShoe.Location = New System.Drawing.Point(29, 38)
        Me.gboTypeOfShoe.Name = "gboTypeOfShoe"
        Me.gboTypeOfShoe.Size = New System.Drawing.Size(553, 105)
        Me.gboTypeOfShoe.TabIndex = 24
        Me.gboTypeOfShoe.TabStop = False
        Me.gboTypeOfShoe.Text = "Step one select type of shoe"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(462, 76)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 24
        Me.btnNext.Text = "Next Page"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'radVintage
        '
        Me.radVintage.AutoSize = True
        Me.radVintage.Location = New System.Drawing.Point(395, 68)
        Me.radVintage.Name = "radVintage"
        Me.radVintage.Size = New System.Drawing.Size(61, 17)
        Me.radVintage.TabIndex = 6
        Me.radVintage.TabStop = True
        Me.radVintage.Text = "Vintage"
        Me.radVintage.UseVisualStyleBackColor = True
        '
        'radRetro
        '
        Me.radRetro.AutoSize = True
        Me.radRetro.Location = New System.Drawing.Point(395, 44)
        Me.radRetro.Name = "radRetro"
        Me.radRetro.Size = New System.Drawing.Size(51, 17)
        Me.radRetro.TabIndex = 5
        Me.radRetro.TabStop = True
        Me.radRetro.Text = "Retro"
        Me.radRetro.UseVisualStyleBackColor = True
        '
        'radClassic
        '
        Me.radClassic.AutoSize = True
        Me.radClassic.Location = New System.Drawing.Point(395, 20)
        Me.radClassic.Name = "radClassic"
        Me.radClassic.Size = New System.Drawing.Size(58, 17)
        Me.radClassic.TabIndex = 4
        Me.radClassic.TabStop = True
        Me.radClassic.Text = "Classic"
        Me.radClassic.UseVisualStyleBackColor = True
        '
        'cboTypeOfShoe
        '
        Me.cboTypeOfShoe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTypeOfShoe.FormattingEnabled = True
        Me.cboTypeOfShoe.Items.AddRange(New Object() {"Classic", "Retro ", "Vintage"})
        Me.cboTypeOfShoe.Location = New System.Drawing.Point(236, 34)
        Me.cboTypeOfShoe.Name = "cboTypeOfShoe"
        Me.cboTypeOfShoe.Size = New System.Drawing.Size(121, 21)
        Me.cboTypeOfShoe.TabIndex = 3
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(6, 34)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(69, 13)
        Me.lblType.TabIndex = 2
        Me.lblType.Text = "Type of shoe"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gboTypeOfShoe)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gboTypeOfShoe.ResumeLayout(False)
        Me.gboTypeOfShoe.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gboTypeOfShoe As GroupBox
    Friend WithEvents btnNext As Button
    Friend WithEvents radVintage As RadioButton
    Friend WithEvents radRetro As RadioButton
    Friend WithEvents radClassic As RadioButton
    Friend WithEvents cboTypeOfShoe As ComboBox
    Friend WithEvents lblType As Label
End Class
