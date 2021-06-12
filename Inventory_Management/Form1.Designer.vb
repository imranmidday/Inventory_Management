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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.forgot_password_link = New System.Windows.Forms.LinkLabel()
        Me.login_button = New System.Windows.Forms.Button()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.forgot_password_link)
        Me.Panel1.Controls.Add(Me.login_button)
        Me.Panel1.Controls.Add(Me.Password)
        Me.Panel1.Controls.Add(Me.UserName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(338, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 245)
        Me.Panel1.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel1.Location = New System.Drawing.Point(225, 202)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(63, 15)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "User Login"
        '
        'forgot_password_link
        '
        Me.forgot_password_link.AutoSize = True
        Me.forgot_password_link.Location = New System.Drawing.Point(193, 148)
        Me.forgot_password_link.Name = "forgot_password_link"
        Me.forgot_password_link.Size = New System.Drawing.Size(95, 15)
        Me.forgot_password_link.TabIndex = 7
        Me.forgot_password_link.TabStop = True
        Me.forgot_password_link.Text = "Forgot Password"
        '
        'login_button
        '
        Me.login_button.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.login_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.login_button.FlatAppearance.BorderSize = 5
        Me.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.login_button.Location = New System.Drawing.Point(73, 171)
        Me.login_button.Name = "login_button"
        Me.login_button.Size = New System.Drawing.Size(215, 28)
        Me.login_button.TabIndex = 5
        Me.login_button.Text = "LOGIN"
        Me.login_button.UseVisualStyleBackColor = False
        '
        'Password
        '
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Password.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Password.Location = New System.Drawing.Point(73, 122)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(212, 23)
        Me.Password.TabIndex = 4
        Me.Password.UseSystemPasswordChar = True
        '
        'UserName
        '
        Me.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UserName.Location = New System.Drawing.Point(73, 78)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(212, 23)
        Me.UserName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(73, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(73, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "UserID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(96, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADMIN LOGIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(27, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 30)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "INVENTORY MANAGEMENT"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(688, 10)
        Me.ProgressBar1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(687, 242)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents login_button As Button
    Friend WithEvents Password As TextBox
    Friend WithEvents UserName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents forgot_password_link As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
