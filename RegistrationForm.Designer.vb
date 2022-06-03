<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrationForm
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
        Dim CancelBtn As FontAwesome.Sharp.IconButton
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.PasswordConfirmationBox = New System.Windows.Forms.TextBox()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BirthdayBox = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CreateBtn = New FontAwesome.Sharp.IconButton()
        CancelBtn = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'CancelBtn
        '
        CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        CancelBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        CancelBtn.IconChar = FontAwesome.Sharp.IconChar.Napster
        CancelBtn.IconColor = System.Drawing.Color.Black
        CancelBtn.IconFont = FontAwesome.Sharp.IconFont.Solid
        CancelBtn.IconSize = 20
        CancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        CancelBtn.Location = New System.Drawing.Point(595, 512)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New System.Drawing.Size(92, 40)
        CancelBtn.TabIndex = 7
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = True
        AddHandler CancelBtn.Click, AddressOf Me.CancelBtn_Click
        '
        'UsernameBox
        '
        Me.UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsernameBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UsernameBox.Location = New System.Drawing.Point(594, 194)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(222, 25)
        Me.UsernameBox.TabIndex = 1
        '
        'EmailBox
        '
        Me.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmailBox.Location = New System.Drawing.Point(595, 255)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(222, 25)
        Me.EmailBox.TabIndex = 2
        '
        'PasswordConfirmationBox
        '
        Me.PasswordConfirmationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordConfirmationBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PasswordConfirmationBox.Location = New System.Drawing.Point(595, 452)
        Me.PasswordConfirmationBox.MaxLength = 50
        Me.PasswordConfirmationBox.Name = "PasswordConfirmationBox"
        Me.PasswordConfirmationBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordConfirmationBox.Size = New System.Drawing.Size(222, 25)
        Me.PasswordConfirmationBox.TabIndex = 5
        Me.PasswordConfirmationBox.UseSystemPasswordChar = True
        '
        'PasswordBox
        '
        Me.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PasswordBox.Location = New System.Drawing.Point(594, 390)
        Me.PasswordBox.MaxLength = 50
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox.Size = New System.Drawing.Size(223, 25)
        Me.PasswordBox.TabIndex = 4
        Me.PasswordBox.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(591, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(594, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "E-mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(591, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Birthday Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(594, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(594, 430)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Confirm Password"
        '
        'BirthdayBox
        '
        Me.BirthdayBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BirthdayBox.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthdayBox.Location = New System.Drawing.Point(594, 326)
        Me.BirthdayBox.MaxDate = New Date(2022, 12, 31, 0, 0, 0, 0)
        Me.BirthdayBox.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.BirthdayBox.Name = "BirthdayBox"
        Me.BirthdayBox.Size = New System.Drawing.Size(224, 25)
        Me.BirthdayBox.TabIndex = 3
        Me.BirthdayBox.Value = New Date(2022, 3, 6, 0, 0, 0, 0)
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.QuizProject.My.Resources.Resources.fadeBackgroundd
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 733)
        Me.Panel1.TabIndex = 13
        '
        'CreateBtn
        '
        Me.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CreateBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.CreateBtn.IconColor = System.Drawing.Color.Green
        Me.CreateBtn.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.CreateBtn.IconSize = 20
        Me.CreateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreateBtn.Location = New System.Drawing.Point(726, 512)
        Me.CreateBtn.Name = "CreateBtn"
        Me.CreateBtn.Size = New System.Drawing.Size(92, 40)
        Me.CreateBtn.TabIndex = 6
        Me.CreateBtn.Text = "Create"
        Me.CreateBtn.UseVisualStyleBackColor = True
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 732)
        Me.Controls.Add(CancelBtn)
        Me.Controls.Add(Me.CreateBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BirthdayBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.PasswordConfirmationBox)
        Me.Controls.Add(Me.EmailBox)
        Me.Controls.Add(Me.UsernameBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrationForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsernameBox As TextBox
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents PasswordConfirmationBox As TextBox
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BirthdayBox As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CreateBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents CancelBtn As FontAwesome.Sharp.IconButton
End Class
