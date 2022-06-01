Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FormAdd.Show()
        Me.Hide()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        FindRecord.Show()
        Me.Hide()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        FormAdd.Show()
        Me.Hide()
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        FindRecord.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form4.Show()
    End Sub
    Public Sub UpdateSub()
        On Error Resume Next
        ds.Clear()
        cmd = con.CreateCommand
        cmd.CommandText = "select * from tbl_item"
        da.SelectCommand = cmd
        da.Fill(ds, "tbl_item")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateSub()
    End Sub
End Class
