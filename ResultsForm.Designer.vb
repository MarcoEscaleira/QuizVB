<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultsForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PercentageLabel = New System.Windows.Forms.Label()
        Me.SuccessLabel = New System.Windows.Forms.Label()
        Me.TrackBar = New System.Windows.Forms.TrackBar()
        Me.QuizTitleLabel = New System.Windows.Forms.Label()
        Me.HomeBtn = New FontAwesome.Sharp.IconButton()
        Me.TryAgainBtn = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PercentageLabel)
        Me.Panel1.Controls.Add(Me.SuccessLabel)
        Me.Panel1.Controls.Add(Me.TrackBar)
        Me.Panel1.Location = New System.Drawing.Point(59, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 227)
        Me.Panel1.TabIndex = 0
        '
        'PercentageLabel
        '
        Me.PercentageLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PercentageLabel.Location = New System.Drawing.Point(0, 0)
        Me.PercentageLabel.Name = "PercentageLabel"
        Me.PercentageLabel.Size = New System.Drawing.Size(808, 79)
        Me.PercentageLabel.TabIndex = 16
        Me.PercentageLabel.Text = "75%"
        Me.PercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SuccessLabel
        '
        Me.SuccessLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SuccessLabel.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SuccessLabel.Location = New System.Drawing.Point(0, 164)
        Me.SuccessLabel.Name = "SuccessLabel"
        Me.SuccessLabel.Size = New System.Drawing.Size(807, 61)
        Me.SuccessLabel.TabIndex = 3
        Me.SuccessLabel.Text = "Good job, you did well !"
        Me.SuccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrackBar
        '
        Me.TrackBar.Enabled = False
        Me.TrackBar.Location = New System.Drawing.Point(100, 82)
        Me.TrackBar.Maximum = 4
        Me.TrackBar.Name = "TrackBar"
        Me.TrackBar.Size = New System.Drawing.Size(616, 45)
        Me.TrackBar.TabIndex = 0
        Me.TrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBar.Value = 3
        '
        'QuizTitleLabel
        '
        Me.QuizTitleLabel.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.QuizTitleLabel.Location = New System.Drawing.Point(59, 58)
        Me.QuizTitleLabel.Name = "QuizTitleLabel"
        Me.QuizTitleLabel.Size = New System.Drawing.Size(808, 51)
        Me.QuizTitleLabel.TabIndex = 2
        Me.QuizTitleLabel.Text = "QuizTitle"
        Me.QuizTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HomeBtn
        '
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.HomeBtn.IconColor = System.Drawing.Color.Black
        Me.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.HomeBtn.IconSize = 24
        Me.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HomeBtn.Location = New System.Drawing.Point(715, 387)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(153, 35)
        Me.HomeBtn.TabIndex = 15
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'TryAgainBtn
        '
        Me.TryAgainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TryAgainBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TryAgainBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.TryAgainBtn.IconColor = System.Drawing.Color.Black
        Me.TryAgainBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.TryAgainBtn.IconSize = 24
        Me.TryAgainBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TryAgainBtn.Location = New System.Drawing.Point(59, 387)
        Me.TryAgainBtn.Name = "TryAgainBtn"
        Me.TryAgainBtn.Size = New System.Drawing.Size(153, 35)
        Me.TryAgainBtn.TabIndex = 14
        Me.TryAgainBtn.Text = "Try again"
        Me.TryAgainBtn.UseVisualStyleBackColor = True
        '
        'ResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 732)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.TryAgainBtn)
        Me.Controls.Add(Me.QuizTitleLabel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ResultsForm"
        Me.Text = "ResultsForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TrackBar As TrackBar
    Friend WithEvents QuizTitleLabel As Label
    Friend WithEvents SuccessLabel As Label
    Friend WithEvents HomeBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents TryAgainBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PercentageLabel As Label
End Class
