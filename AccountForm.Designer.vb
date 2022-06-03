<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.BirthdateBox = New System.Windows.Forms.TextBox()
        Me.DescriptionBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.AutoEllipsis = True
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(2, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.QuizProject.My.Resources.Resources.userCircle
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(316, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(284, 249)
        Me.Panel2.TabIndex = 5
        '
        'backBtn
        '
        Me.backBtn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.backBtn.Location = New System.Drawing.Point(818, 12)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(99, 37)
        Me.backBtn.TabIndex = 9
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'NameBox
        '
        Me.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NameBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NameBox.Location = New System.Drawing.Point(316, 343)
        Me.NameBox.MaxLength = 256
        Me.NameBox.Name = "NameBox"
        Me.NameBox.ReadOnly = True
        Me.NameBox.Size = New System.Drawing.Size(284, 18)
        Me.NameBox.TabIndex = 10
        '
        'BirthdateBox
        '
        Me.BirthdateBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BirthdateBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BirthdateBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BirthdateBox.Location = New System.Drawing.Point(316, 552)
        Me.BirthdateBox.MaxLength = 256
        Me.BirthdateBox.Name = "BirthdateBox"
        Me.BirthdateBox.ReadOnly = True
        Me.BirthdateBox.Size = New System.Drawing.Size(284, 18)
        Me.BirthdateBox.TabIndex = 14
        '
        'DescriptionBox
        '
        Me.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescriptionBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DescriptionBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DescriptionBox.Location = New System.Drawing.Point(316, 415)
        Me.DescriptionBox.MaxLength = 256
        Me.DescriptionBox.Name = "DescriptionBox"
        Me.DescriptionBox.Size = New System.Drawing.Size(284, 25)
        Me.DescriptionBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(316, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 391)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 528)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Birthdate"
        '
        'SaveBtn
        '
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Location = New System.Drawing.Point(504, 605)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(96, 30)
        Me.SaveBtn.TabIndex = 20
        Me.SaveBtn.Text = "Save Details"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(316, 459)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 15)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Email"
        '
        'EmailBox
        '
        Me.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmailBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmailBox.Location = New System.Drawing.Point(316, 483)
        Me.EmailBox.MaxLength = 256
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.ReadOnly = True
        Me.EmailBox.Size = New System.Drawing.Size(284, 18)
        Me.EmailBox.TabIndex = 21
        '
        'AccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 732)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EmailBox)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DescriptionBox)
        Me.Controls.Add(Me.BirthdateBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountForm"
        Me.Text = "User Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents backBtn As Button
    Friend WithEvents NameBox As TextBox
    Friend WithEvents BirthdateBox As TextBox
    Friend WithEvents DescriptionBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents EmailBox As TextBox
End Class
