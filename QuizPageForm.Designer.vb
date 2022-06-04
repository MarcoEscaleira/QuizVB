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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BackBtn = New FontAwesome.Sharp.IconButton()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Orange
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(645, 177)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 92)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Play"
        Me.Button3.UseVisualStyleBackColor = False
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
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"", "", "* AnimalKing", "* Sssnake", "* TheLion07"})
        Me.ListBox1.Location = New System.Drawing.Point(566, 397)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(203, 124)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RichTextBox2)
        Me.Panel3.Location = New System.Drawing.Point(170, 397)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(266, 124)
        Me.Panel3.TabIndex = 11
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Location = New System.Drawing.Point(67, 44)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(141, 43)
        Me.RichTextBox2.TabIndex = 0
        Me.RichTextBox2.Text = "Your recent results for this quiz: 12/16"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(169, 362)
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
        Me.DescriptionLabel.Size = New System.Drawing.Size(391, 176)
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
        'QuizPageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(929, 732)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QuizPageForm"
        Me.Text = "Quiz Page"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BackBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents TitleLabel As Label
End Class
