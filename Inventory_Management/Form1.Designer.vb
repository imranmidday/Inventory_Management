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
        Me.forgot_password_link = New System.Windows.Forms.LinkLabel()
        Me.register_button = New System.Windows.Forms.Button()
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
        Me.Panel1.Controls.Add(Me.forgot_password_link)
        Me.Panel1.Controls.Add(Me.register_button)
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
        'forgot_password_link
        '
        Me.forgot_password_link.AutoSize = True
        Me.forgot_password_link.Location = New System.Drawing.Point(222, 134)
        Me.forgot_password_link.Name = "forgot_password_link"
        Me.forgot_password_link.Size = New System.Drawing.Size(95, 15)
        Me.forgot_password_link.TabIndex = 7
        Me.forgot_password_link.TabStop = True
        Me.forgot_password_link.Text = "Forgot Password"
        '
        'register_button
        '
        Me.register_button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.register_button.Location = New System.Drawing.Point(239, 172)
        Me.register_button.Name = "register_button"
        Me.register_button.Size = New System.Drawing.Size(75, 28)
        Me.register_button.TabIndex = 6
        Me.register_button.Text = "Register"
        Me.register_button.UseVisualStyleBackColor = True
        '
        'login_button
        '
        Me.login_button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.login_button.Location = New System.Drawing.Point(102, 172)
        Me.login_button.Name = "login_button"
        Me.login_button.Size = New System.Drawing.Size(75, 28)
        Me.login_button.TabIndex = 5
        Me.login_button.Text = "LOGIN"
        Me.login_button.UseVisualStyleBackColor = True
        '
        'Password
        '
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Password.Location = New System.Drawing.Point(102, 108)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(212, 23)
        Me.Password.TabIndex = 4
        Me.Password.UseSystemPasswordChar = True
        '
        'UserName
        '
        Me.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserName.Location = New System.Drawing.Point(102, 64)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(212, 23)
        Me.UserName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(30, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(30, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "UserID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(157, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
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
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents register_button As Button
    Friend WithEvents login_button As Button
    Friend WithEvents Password As TextBox
    Friend WithEvents UserName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents forgot_password_link As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
