Imports System.Data
Imports System.Data.OleDb
Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Hide()
        Dim Frg As New FrmRegistration
        Frg.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles forgot_password_link.LinkClicked

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_button.Click
        If Len(Trim(UserName.Text)) = 0 Then
            MessageBox.Show("Please Enter Username", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UserName.Focus()
        End If
        If Len(Trim(Password.Text)) = 0 Then
            MessageBox.Show("Please Enter Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Password.Focus()
        End If
        Try
            Dim myConnection As OleDbConnection
            myConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Imran\Documents\inventory.accdb")
            Dim myCommand As OleDbCommand
            myCommand = New OleDbCommand("SELECT UserName,Password FROM Users WHERE UserName=@UserName AND Password=@Password", myConnection)
            Dim uName As New OleDbParameter("@UserName", SqlDbType.VarChar)
            Dim uPassword As New OleDbParameter("@Password", SqlDbType.VarChar)
            uName.Value = UserName.Text
            uPassword.Value = Password.Text
            myCommand.Parameters.Add(uName)
            myCommand.Parameters.Add(uPassword)
            myCommand.Connection.Open()
            Dim myReader As OleDbDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim Login As Object = 0
            If myReader.HasRows Then
                myReader.Read()
                Login = myReader(Login)
            End If
            If Login = Nothing Then
                MsgBox("Login is failed..... Try Again", MsgBoxStyle.Critical, "Login Denied")
                UserName.Clear()
                Password.Clear()
                UserName.Focus()
            Else
                ProgressBar1.Visible = True
                ProgressBar1.Maximum = 5000
                ProgressBar1.Minimum = 0
                ProgressBar1.Value = 4
                ProgressBar1.Step = 1
                For i = 0 To 5000
                    ProgressBar1.PerformStep()
                Next
                Dim frm As New Form2
                frm.ToolStripStatusLabel2.Text = UserName.Text
                Hide()
                frm.Show()




            End If
            myCommand.Dispose()
            myConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MsgBox(v1 As String, critical As MsgBoxStyle, v2 As String)
        Throw New NotImplementedException()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UserName.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Hide()
        Dim Ulog As New userLogin
        Ulog.Show()
    End Sub
End Class
