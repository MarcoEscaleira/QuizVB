<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizPageForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BackBtn = New FontAwesome.Sharp.IconButton()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QuestionsLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.QuizCategoryLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PlayBtn = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ResultsLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(169, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Description"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(169, 371)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(600, 2)
        Me.Panel4.TabIndex = 12
        '
        'BackBtn
        '
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BackBtn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BackBtn.IconColor = System.Drawing.Color.Black
        Me.BackBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BackBtn.Location = New System.Drawing.Point(829, 35)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(75, 35)
        Me.BackBtn.TabIndex = 13
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DescriptionLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DescriptionLabel.Location = New System.Drawing.Point(169, 163)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(391, 157)
        Me.DescriptionLabel.TabIndex = 15
        Me.DescriptionLabel.Text = "DescriptionLabel"
        '
        'TitleLabel
        '
        Me.TitleLabel.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.Location = New System.Drawing.Point(169, 35)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(600, 43)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Title Label"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(641, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Questions: "
        '
        'QuestionsLabel
        '
        Me.QuestionsLabel.AutoSize = True
        Me.QuestionsLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.QuestionsLabel.Location = New System.Drawing.Point(750, 150)
        Me.QuestionsLabel.Name = "QuestionsLabel"
        Me.QuestionsLabel.Size = New System.Drawing.Size(19, 21)
        Me.QuestionsLabel.TabIndex = 17
        Me.QuestionsLabel.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(169, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Category: "
        '
        'QuizCategoryLabel
        '
        Me.QuizCategoryLabel.AutoSize = True
        Me.QuizCategoryLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.QuizCategoryLabel.Location = New System.Drawing.Point(235, 330)
        Me.QuizCategoryLabel.Name = "QuizCategoryLabel"
        Me.QuizCategoryLabel.Size = New System.Drawing.Size(35, 21)
        Me.QuizCategoryLabel.TabIndex = 19
        Me.QuizCategoryLabel.Text = "Cat"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateLabel.Location = New System.Drawing.Point(681, 333)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(44, 21)
        Me.DateLabel.TabIndex = 21
        Me.DateLabel.Text = "date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(610, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Created on "
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UserLabel.Location = New System.Drawing.Point(455, 331)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(44, 21)
        Me.UserLabel.TabIndex = 23
        Me.UserLabel.Text = "User"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(382, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 19)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Created by "
        '
        'PlayBtn
        '
        Me.PlayBtn.BackColor = System.Drawing.Color.Green
        Me.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayBtn.Flip = FontAwesome.Sharp.FlipOrientation.Vertical
        Me.PlayBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PlayBtn.ForeColor = System.Drawing.Color.White
        Me.PlayBtn.IconChar = FontAwesome.Sharp.IconChar.Play
        Me.PlayBtn.IconColor = System.Drawing.Color.White
        Me.PlayBtn.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.PlayBtn.IconSize = 24
        Me.PlayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PlayBtn.Location = New System.Drawing.Point(645, 185)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.Size = New System.Drawing.Size(124, 92)
        Me.PlayBtn.TabIndex = 24
        Me.PlayBtn.Text = "Play"
        Me.PlayBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Location = New System.Drawing.Point(169, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(600, 37)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Your recent results on this quiz"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ResultsLabel
        '
        Me.ResultsLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResultsLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResultsLabel.Location = New System.Drawing.Point(169, 427)
        Me.ResultsLabel.Name = "ResultsLabel"
        Me.ResultsLabel.Size = New System.Drawing.Size(600, 203)
        Me.ResultsLabel.TabIndex = 26
        Me.ResultsLabel.Text = "N/A"
        Me.ResultsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'QuizPageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(929, 732)
        Me.Controls.Add(Me.ResultsLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PlayBtn)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.QuizCategoryLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.QuestionsLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QuizPageForm"
        Me.Text = "Quiz Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BackBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents QuestionsLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents QuizCategoryLabel As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents UserLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PlayBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents ResultsLabel As Label
End Class
