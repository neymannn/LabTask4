Public Class FindRecord
    Dim searchKey, sqlCond As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Enabled = False
        cbCate1.Enabled = False

        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnClear.Enabled = False

    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        On Error Resume Next
        con.Open()
        cmd.CommandText = "UPDATE tbl_item SET item_name = '" & UCase(txtItem.Text) & " ', " _
        & "category = '" & UCase(cbCate.Text) & " ', " _
        & "quantity = '" & UCase(txtQuan.Text) & " ', " _
        & "location = '" & UCase(txtLoc.Text) & " ' " _
        & "WHERE ID=" & lblID.Text
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
        UpdateSub()

        MessageBox.Show("Information Update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub UpdateSub()
        On Error Resume Next
        ds.Clear()
        cmd = con.CreateCommand
        cmd.CommandText = "select * from tbl_item"
        da.SelectCommand = cmd
        da.Fill(ds, "tbl_item")
        lblID.DataBindings.Add("Text", ds.Tables("tbl_item"), "ID")
        txtItem.DataBindings.Add("Text", ds.Tables("tbl_item"), "item_name")
        cbCate.DataBindings.Add("Text", ds.Tables("tbl_item"), "category")
        txtQuan.DataBindings.Add("Text", ds.Tables("tbl_item"), "quantity")
        txtLoc.DataBindings.Add("Text", ds.Tables("tbl_item"), "location")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Private Sub SearchSelection()
        If rdbName.Checked = True Then
            searchKey = UCase(txtName.Text)
            sqlCond = "item_name"

        Else rdbCate.Checked = True
            searchKey = UCase(cbCate1.SelectedItem)
            sqlCond = "category"
        End If
    End Sub
    Private Sub rdbName_CheckedChanged(sender As Object, e As EventArgs) Handles rdbName.CheckedChanged
        txtName.Enabled = True
        cbCate1.Enabled = False
    End Sub

    Private Sub rdbCate_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCate.CheckedChanged
        txtName.Enabled = False
        cbCate1.Enabled = True
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (MessageBox.Show("Are you sure you want to delete this record?", "DeleteRecord",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
            con.Open()
            Dim Del As OleDb.OleDbCommand = New OleDb.OleDbCommand()
            Del.CommandText = "Delete From tbl_item Where ID = " & lblID.Text
            Del.Connection = con
            Del.ExecuteNonQuery()

            Me.BindingContext(ds.Tables("tbl_item")).RemoveAt _
            (Me.BindingContext(ds.Tables("tbl_item")).Position)
            con.Close()
            MessageBox.Show("Data Have Been Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Me.Refresh()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchSelection()

        On Error Resume Next
        ds.Clear()
        cmd = con.CreateCommand
        cmd.CommandText = "select * from tbl_item where " & sqlCond & " Like '" & searchKey & "'"
        da.SelectCommand = cmd

        da.Fill(ds, "tbl_item")
        lblID.DataBindings.Add("Text", ds.Tables("tbl_item"), "ID")
        txtItem.DataBindings.Add("Text", ds.Tables("tbl_item"), "item_name")
        cbCate.DataBindings.Add("Text", ds.Tables("tbl_item"), "category")
        txtQuan.DataBindings.Add("Text", ds.Tables("tbl_item"), "quantity")
        txtLoc.DataBindings.Add("Text", ds.Tables("tbl_item"), "location")
        DataGridView1.DataSource = ds.Tables(0)

        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnClear.Enabled = True
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblID.Text = ""
        txtItem.Text = ""
        cbCate.Text = ""
        txtQuan.Text = ""
        txtLoc.Text = ""

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        FormAdd.Show()
        Me.Hide()
    End Sub

    Private Sub HomeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form4.Show()
    End Sub
End Class