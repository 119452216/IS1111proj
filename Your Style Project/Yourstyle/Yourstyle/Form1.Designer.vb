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
        Me.gboTypeOfShoe.Controls.Add(Me.lblType)
        Me.gboTypeOfShoe.Location = New System.Drawing.Point(211, 87)
        Me.gboTypeOfShoe.Name = "gboTypeOfShoe"
        Me.gboTypeOfShoe.Size = New System.Drawing.Size(317, 214)
        Me.gboTypeOfShoe.TabIndex = 24
        Me.gboTypeOfShoe.TabStop = False
        Me.gboTypeOfShoe.Text = "Step one select type of shoe"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(192, 93)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 24
        Me.btnNext.Text = "Next Page"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'radVintage
        '
        Me.radVintage.AutoSize = True
        Me.radVintage.Location = New System.Drawing.Point(80, 124)
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
        Me.radRetro.Location = New System.Drawing.Point(80, 99)
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
        Me.radClassic.Location = New System.Drawing.Point(80, 76)
        Me.radClassic.Name = "radClassic"
        Me.radClassic.Size = New System.Drawing.Size(58, 17)
        Me.radClassic.TabIndex = 4
        Me.radClassic.TabStop = True
        Me.radClassic.Text = "Classic"
        Me.radClassic.UseVisualStyleBackColor = True
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(6, 101)
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
    Friend WithEvents lblType As Label
End Class
