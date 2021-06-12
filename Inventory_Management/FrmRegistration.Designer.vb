<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistration
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GetDetails = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Update_Record = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.New_Record = New System.Windows.Forms.Button()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.UserName = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(194, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registration"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(-2, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 10)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Phone)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Password)
        Me.GroupBox1.Controls.Add(Me.UserName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 253)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.GetDetails)
        Me.Panel2.Controls.Add(Me.Delete)
        Me.Panel2.Controls.Add(Me.Update_Record)
        Me.Panel2.Controls.Add(Me.Save)
        Me.Panel2.Controls.Add(Me.New_Record)
        Me.Panel2.Location = New System.Drawing.Point(36, 173)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(355, 44)
        Me.Panel2.TabIndex = 10
        '
        'GetDetails
        '
        Me.GetDetails.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GetDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GetDetails.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GetDetails.Location = New System.Drawing.Point(283, 10)
        Me.GetDetails.Name = "GetDetails"
        Me.GetDetails.Size = New System.Drawing.Size(63, 23)
        Me.GetDetails.TabIndex = 4
        Me.GetDetails.Text = "&Get Data"
        Me.GetDetails.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Delete.Enabled = False
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Delete.Location = New System.Drawing.Point(214, 10)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(63, 23)
        Me.Delete.TabIndex = 3
        Me.Delete.Text = "&Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Update_Record
        '
        Me.Update_Record.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Update_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Update_Record.Enabled = False
        Me.Update_Record.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Update_Record.Location = New System.Drawing.Point(145, 10)
        Me.Update_Record.Name = "Update_Record"
        Me.Update_Record.Size = New System.Drawing.Size(63, 23)
        Me.Update_Record.TabIndex = 2
        Me.Update_Record.Text = "&Update"
        Me.Update_Record.UseVisualStyleBackColor = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Save.Location = New System.Drawing.Point(76, 10)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(63, 23)
        Me.Save.TabIndex = 1
        Me.Save.Text = "&Save"
        Me.Save.UseVisualStyleBackColor = False
        '
        'New_Record
        '
        Me.New_Record.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.New_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.New_Record.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.New_Record.Location = New System.Drawing.Point(7, 10)
        Me.New_Record.Name = "New_Record"
        Me.New_Record.Size = New System.Drawing.Size(63, 23)
        Me.New_Record.TabIndex = 0
        Me.New_Record.Text = "&New"
        Me.New_Record.UseVisualStyleBackColor = False
        '
        'Phone
        '
        Me.Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Phone.Location = New System.Drawing.Point(204, 119)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(207, 23)
        Me.Phone.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(204, 90)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(207, 23)
        Me.txtName.TabIndex = 8
        '
        'Password
        '
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Password.Location = New System.Drawing.Point(204, 61)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(207, 23)
        Me.Password.TabIndex = 6
        '
        'UserName
        '
        Me.UserName.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.UserName.FormattingEnabled = True
        Me.UserName.Location = New System.Drawing.Point(204, 32)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(207, 23)
        Me.UserName.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(24, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Mobile Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(24, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(24, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(24, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "User Name"
        '
        'FrmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 326)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Phone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents UserName As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GetDetails As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Update_Record As Button
    Friend WithEvents Save As Button
    Friend WithEvents New_Record As Button
End Class
