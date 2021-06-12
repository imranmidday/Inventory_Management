Imports System.Data.OleDb
Imports System.Data
Public Class FrmRegistration

    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Imran\Documents\inventory.accdb"
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub FrmRegistration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Hide()
        Dim Frm2 As New Form2
        Frm2.Show()

    End Sub
    Sub fillcombo()
        Try
            Dim Cn As New OleDbConnection(cs)
            Cn.Open()
            adp = New OleDbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct (UserName) FROM Registration", Cn)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            UserName.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                UserName.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FrmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillcombo()
    End Sub

    Private Sub DSE_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserName.SelectedIndexChanged
        Try
            Delete.Enabled = True
            Update_Record.Enabled = True

            con = New OleDbConnection(cs)
            con.Open()

            Dim ct As String = "SELECT * FROM Registration WHERE UserName=@find"
            cmd = New OleDbCommand(ct) With {
                .Connection = con
            }
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "username"))
            cmd.Parameters("@find").Value = Trim(UserName.Text)
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                Password.Text = Trim(rdr.GetString(1))
                txtName.Text = Trim(rdr.GetString(2))
                Phone.Text = Trim(rdr.GetString(3))
            End If

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub New_Record_Click(sender As Object, e As EventArgs) Handles New_Record.Click
        UserName.Text = ""
        Password.Text = ""
        Phone.Text = ""
        txtName.Text = ""
        Save.Enabled = True
        Update_Record.Enabled = False
        Delete.Enabled = False
    End Sub

    Private Sub Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Phone.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub UserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
            And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
            Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then

            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) Then
                e.Handled = True
            End If
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If


    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If Len(Trim(UserName.Text)) = 0 Then
            MessageBox.Show("Please Enter User Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UserName.Focus()
            Exit Sub
        End If
        If Len(Trim(Password.Text)) = 0 Then
            MessageBox.Show("Please Enter Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Password.Focus()
            Exit Sub
        End If
        If Len(Trim(txtName.Text)) = 0 Then
            MessageBox.Show("Please Enter Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
            Exit Sub
        End If
        If Len(Trim(Phone.Text)) = 0 Then
            MessageBox.Show("Please Enter Phone Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Phone.Focus()
            Exit Sub
        End If
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select Username from registration where Username=@find"

            cmd = New OleDbCommand(ct) With {
                .Connection = con
            }
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "username"))
            cmd.Parameters("@find").Value = UserName.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("User Name Already Exists ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UserName.Text = ""


                If rdr IsNot Nothing Then
                    rdr.Close()
                End If
            Else
                con = New OleDbConnection(cs)
                con.Open()

                Dim cb As String = "insert into Registration(Username,User_Password,Name,Phone) VALUES (@d1,@d2,@d3,@d4)"

                cmd = New OleDbCommand(cb) With {
                    .Connection = con
                }
                cmd.Parameters.Add(New OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 30, "Username"))

                cmd.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "User_Password"))

                cmd.Parameters.Add(New OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 30, "Name"))

                cmd.Parameters.Add(New OleDbParameter("@d4", System.Data.OleDb.OleDbType.VarChar, 15, "Phone"))

                cmd.Parameters("@d1").Value = Trim(UserName.Text)

                cmd.Parameters("@d2").Value = Trim(Password.Text)

                cmd.Parameters("@d3").Value = Trim(txtName.Text)

                cmd.Parameters("@d4").Value = Trim(Phone.Text)

                cmd.ExecuteReader()


                MessageBox.Show("successfully registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Save.Enabled = False

                fillcombo()
                con.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetDetails_Click(sender As Object, e As EventArgs) Handles GetDetails.Click
        Hide()
        Dim Fdetail As New FrmRegistrationDetails
        Fdetail.Show()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Try
            If UserName.Text = "" Then
                MessageBox.Show("Please select username", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If UserName.Items.Count > 0 Then
                If MsgBox("Do you really want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    Delete_records()

                    Delete.Enabled = False
                    Update_Record.Enabled = False
                    fillcombo()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Delete_records()
        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()

            Dim cq As String = "delete from registration where username=@DELETE1;"

            cmd = New OleDbCommand(cq) With {
                .Connection = con
            }
            cmd.Parameters.Add(New OleDbParameter("@DELETE1", System.Data.OleDb.OleDbType.VarChar, 30, "username"))

            cmd.Parameters("@DELETE1").Value = Trim(UserName.Text)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("Sorry no record deleted ")
                UserName.Text = ""
                Password.Text = ""
                Phone.Text = ""
                txtName.Text = ""

                cmd.ExecuteReader()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()
            End If
            UserName.Text = ""
            Password.Text = ""
            Phone.Text = ""
            txtName.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MsgBox(v As String)
        Throw New NotImplementedException()
    End Sub

    Private Function MsgBox(v As String, msgBoxStyle As MsgBoxStyle) As MsgBoxResult
        Throw New NotImplementedException()
    End Function

    Private Sub Update_Record_Click(sender As Object, e As EventArgs) Handles Update_Record.Click
        Try
            If UserName.Text = "" Then
                MessageBox.Show("Please Select user name", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()

            Dim cb As String = "update registration set user_password='" & Password.Text & "',name='" & txtName.Text & "',phone='" & Phone.Text & "'Where username='" & UserName.Text & "'"

            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()


            MessageBox.Show("Successfully Updated", "User Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Update_Record.Enabled = False
            fillcombo()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class