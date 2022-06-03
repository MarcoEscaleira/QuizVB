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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProfileBtn = New FontAwesome.Sharp.IconButton()
        Me.LogoutBtn = New FontAwesome.Sharp.IconButton()
        Me.RegisterBtn = New FontAwesome.Sharp.IconButton()
        Me.LoginBtn = New FontAwesome.Sharp.IconButton()
        Me.HomeBtn = New FontAwesome.Sharp.IconButton()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(178, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(929, 732)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.ProfileBtn)
        Me.Panel2.Controls.Add(Me.LogoutBtn)
        Me.Panel2.Controls.Add(Me.RegisterBtn)
        Me.Panel2.Controls.Add(Me.LoginBtn)
        Me.Panel2.Controls.Add(Me.HomeBtn)
        Me.Panel2.Controls.Add(Me.UserLabel)
        Me.Panel2.Location = New System.Drawing.Point(2, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(183, 732)
        Me.Panel2.TabIndex = 4
        '
        'ProfileBtn
        '
        Me.ProfileBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProfileBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProfileBtn.FlatAppearance.BorderSize = 0
        Me.ProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProfileBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProfileBtn.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.ProfileBtn.IconColor = System.Drawing.Color.Black
        Me.ProfileBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ProfileBtn.IconSize = 24
        Me.ProfileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProfileBtn.Location = New System.Drawing.Point(0, 656)
        Me.ProfileBtn.Name = "ProfileBtn"
        Me.ProfileBtn.Size = New System.Drawing.Size(183, 38)
        Me.ProfileBtn.TabIndex = 12
        Me.ProfileBtn.Text = "My Profile"
        Me.ProfileBtn.UseVisualStyleBackColor = True
        '
        'LogoutBtn
        '
        Me.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogoutBtn.FlatAppearance.BorderSize = 0
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutBtn.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft
        Me.LogoutBtn.IconColor = System.Drawing.Color.Black
        Me.LogoutBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.LogoutBtn.IconSize = 24
        Me.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutBtn.Location = New System.Drawing.Point(0, 694)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(183, 38)
        Me.LogoutBtn.TabIndex = 11
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'RegisterBtn
        '
        Me.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RegisterBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.RegisterBtn.FlatAppearance.BorderSize = 0
        Me.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RegisterBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.RegisterBtn.IconColor = System.Drawing.Color.Black
        Me.RegisterBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RegisterBtn.IconSize = 24
        Me.RegisterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RegisterBtn.Location = New System.Drawing.Point(0, 76)
        Me.RegisterBtn.Name = "RegisterBtn"
        Me.RegisterBtn.Size = New System.Drawing.Size(183, 38)
        Me.RegisterBtn.TabIndex = 10
        Me.RegisterBtn.Text = "Register"
        Me.RegisterBtn.UseVisualStyleBackColor = True
        '
        'LoginBtn
        '
        Me.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.LoginBtn.FlatAppearance.BorderSize = 0
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LoginBtn.IconChar = FontAwesome.Sharp.IconChar.ChevronRight
        Me.LoginBtn.IconColor = System.Drawing.Color.Black
        Me.LoginBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.LoginBtn.IconSize = 24
        Me.LoginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoginBtn.Location = New System.Drawing.Point(0, 38)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(183, 38)
        Me.LoginBtn.TabIndex = 9
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'HomeBtn
        '
        Me.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.HomeBtn.FlatAppearance.BorderSize = 0
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.HomeBtn.IconColor = System.Drawing.Color.Black
        Me.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.HomeBtn.IconSize = 24
        Me.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HomeBtn.Location = New System.Drawing.Point(0, 0)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(183, 38)
        Me.HomeBtn.TabIndex = 8
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UserLabel.Location = New System.Drawing.Point(3, 633)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(0, 20)
        Me.UserLabel.TabIndex = 6
        Me.UserLabel.Visible = False
        '
        'indexForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 735)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "indexForm"
        Me.Text = "Quizzly"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UserLabel As Label
    Friend WithEvents HomeBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents RegisterBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents LoginBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents ProfileBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents LogoutBtn As FontAwesome.Sharp.IconButton
End Class
