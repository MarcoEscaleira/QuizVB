<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class indexForm
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
        Me.userIdTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.goToHome = New System.Windows.Forms.Button()
        Me.goToLogin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.goToRegistration = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.userIdTextBox)
        Me.Panel1.Location = New System.Drawing.Point(191, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(916, 732)
        Me.Panel1.TabIndex = 0
        '
        'userIdTextBox
        '
        Me.userIdTextBox.BackColor = System.Drawing.Color.LightGray
        Me.userIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userIdTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.userIdTextBox.Location = New System.Drawing.Point(3, 707)
        Me.userIdTextBox.Name = "userIdTextBox"
        Me.userIdTextBox.Size = New System.Drawing.Size(160, 22)
        Me.userIdTextBox.TabIndex = 4
        Me.userIdTextBox.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.goToRegistration)
        Me.Panel2.Controls.Add(Me.goToHome)
        Me.Panel2.Controls.Add(Me.goToLogin)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(2, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(183, 732)
        Me.Panel2.TabIndex = 4
        '
        'goToHome
        '
        Me.goToHome.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.goToHome.Location = New System.Drawing.Point(43, 12)
        Me.goToHome.Name = "goToHome"
        Me.goToHome.Size = New System.Drawing.Size(88, 32)
        Me.goToHome.TabIndex = 3
        Me.goToHome.Text = "Home"
        Me.goToHome.UseVisualStyleBackColor = True
        '
        'goToLogin
        '
        Me.goToLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.goToLogin.Location = New System.Drawing.Point(43, 50)
        Me.goToLogin.Name = "goToLogin"
        Me.goToLogin.Size = New System.Drawing.Size(88, 32)
        Me.goToLogin.TabIndex = 2
        Me.goToLogin.Text = "Login"
        Me.goToLogin.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoEllipsis = True
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(10, 643)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'goToRegistration
        '
        Me.goToRegistration.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.goToRegistration.Location = New System.Drawing.Point(43, 88)
        Me.goToRegistration.Name = "goToRegistration"
        Me.goToRegistration.Size = New System.Drawing.Size(88, 32)
        Me.goToRegistration.TabIndex = 4
        Me.goToRegistration.Text = "Register"
        Me.goToRegistration.UseVisualStyleBackColor = True
        '
        'indexForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 735)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "indexForm"
        Me.Text = "Quizzly"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents goToLogin As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents goToHome As Button
    Friend WithEvents userIdTextBox As TextBox
    Friend WithEvents goToRegistration As Button
End Class
