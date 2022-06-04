<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizQuestionForm
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
        Me.QuizTitleLabel = New System.Windows.Forms.Label()
        Me.QuestionLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CurrentLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.QuestionsTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(38, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quiz: "
        '
        'QuizTitleLabel
        '
        Me.QuizTitleLabel.AutoSize = True
        Me.QuizTitleLabel.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.QuizTitleLabel.Location = New System.Drawing.Point(82, 90)
        Me.QuizTitleLabel.Name = "QuizTitleLabel"
        Me.QuizTitleLabel.Size = New System.Drawing.Size(98, 30)
        Me.QuizTitleLabel.TabIndex = 1
        Me.QuizTitleLabel.Text = "QuizTitle"
        '
        'QuestionLabel
        '
        Me.QuestionLabel.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.QuestionLabel.Location = New System.Drawing.Point(38, 149)
        Me.QuestionLabel.Name = "QuestionLabel"
        Me.QuestionLabel.Size = New System.Drawing.Size(847, 30)
        Me.QuestionLabel.TabIndex = 3
        Me.QuestionLabel.Text = "Question"
        Me.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(175, 221)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 184)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(724, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Questions: "
        '
        'CurrentLabel
        '
        Me.CurrentLabel.AutoSize = True
        Me.CurrentLabel.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CurrentLabel.Location = New System.Drawing.Point(806, 92)
        Me.CurrentLabel.Name = "CurrentLabel"
        Me.CurrentLabel.Size = New System.Drawing.Size(25, 30)
        Me.CurrentLabel.TabIndex = 6
        Me.CurrentLabel.Text = "0"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TotalLabel.Location = New System.Drawing.Point(827, 92)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(52, 30)
        Me.TotalLabel.TabIndex = 7
        Me.TotalLabel.Text = "/ 10"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(509, 221)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(243, 184)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(175, 439)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(243, 184)
        Me.Panel3.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(509, 439)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(243, 184)
        Me.Panel4.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(38, 137)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(850, 2)
        Me.Panel5.TabIndex = 13
        '
        'QuestionsTotal
        '
        Me.QuestionsTotal.AutoSize = True
        Me.QuestionsTotal.Location = New System.Drawing.Point(1, 2)
        Me.QuestionsTotal.Name = "QuestionsTotal"
        Me.QuestionsTotal.Size = New System.Drawing.Size(71, 15)
        Me.QuestionsTotal.TabIndex = 14
        Me.QuestionsTotal.Text = "HiddenTotal"
        Me.QuestionsTotal.Visible = False
        '
        'QuizQuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 732)
        Me.Controls.Add(Me.QuestionsTotal)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.CurrentLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.QuestionLabel)
        Me.Controls.Add(Me.QuizTitleLabel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QuizQuestionForm"
        Me.Text = "Quiz Question"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents QuizTitleLabel As Label
    Friend WithEvents QuestionLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CurrentLabel As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents QuestionsTotal As Label
End Class
