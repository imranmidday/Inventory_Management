Imports System.Data.OleDb
Imports System.IO
Public Class Form2

    Dim sSql As String
    Dim rdr As OleDbDataReader = Nothing
    Dim Con As OleDbConnection = Nothing
    Dim cmd As OleDbCommand = Nothing
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Frm1 As New Form1
        ToolStripStatusLabel4.Text = Now()
        ToolStripStatusLabel2.Text = Frm1.UserName.Text
        Me.Refresh()
        Button1.PerformClick()
        Timer2.Start()
        Timer2.Interval = 1000
    End Sub

    Private Const ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\Users\Imran\Documents\inventory.accdb"
    Private ReadOnly Property Connection() As OleDbConnection
        Get
            Dim connectionToFetch As New OleDbConnection(ConnectionString)
            connectionToFetch.Open()
            Return connectionToFetch
        End Get
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.DataSource = GetData()
    End Sub
    Public Function GetData() As DataView
        Dim SelectQry = "SELECT(StockID) as [Stock ID],(ProductCode) as [Product Code],(ProductName) as [Product Name],(Weight) as [Weight],sum(Cartons) as [Cartons],Packets,sum(TotalPackets) as [Total Packets] FROM Stock Where Cartons>0 and TotalPackets > 0 group by StockID,ProductCode,ProductName,Weight,Packets order by ProductName"
        Dim SampleSource As New DataSet
        Dim TableView As DataView
        Try
            Dim SampleCommand As New OleDbCommand()
            Dim SampleDataAdapter = New OleDbDataAdapter()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = Connection
            SampleDataAdapter.SelectCommand = SampleCommand
            SampleDataAdapter.Fill(SampleSource)
            TableView = SampleSource.Tables(0).DefaultView
        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return TableView
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        ToolStripStatusLabel4.Text = Now
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Button1.PerformClick()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Hide()
        Dim Frm1 As New Form1
        Frm1.Show()
        Frm1.UserName.Text = ""
        Frm1.Password.Text = ""
        Frm1.UserName.Focus()

    End Sub

    Private Sub RegistrationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem1.Click
        Hide()
        Dim Frg As New FrmRegistration
        Frg.Show()

    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        Hide()
        Dim Frg As New FrmRegistration
        Frg.Show()
    End Sub
End Class