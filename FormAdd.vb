﻿Public Class FormAdd
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        On Error Resume Next
        cmd.Connection = con
        cmd.Connection.Open()
        cmd.CommandText = "INSERT INTO tbl_item (item_name, category, quantity, location)" _
        & "Values (" _
        & "'" & UCase(txtItem.Text) & "'," _
        & "'" & UCase(cbCate.Text) & "'," _
        & "'" & UCase(txtQuan.Text) & "'," _
        & "'" & UCase(txtLoc.Text) & "')"
        MessageBox.Show("Data Have Been Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmd.ExecuteNonQuery()
        UpdateSub()
        con.Close()

        txtItem.Text = ""
        cbCate.Text = ""
        txtQuan.Text = ""
        txtLoc.Text = ""
        txtItem.Focus()

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

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        FindRecord.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtItem.Text = ""
        cbCate.Text = ""
        txtQuan.Text = ""
        txtLoc.Text = ""
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
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

End Class