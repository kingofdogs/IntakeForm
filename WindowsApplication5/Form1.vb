Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem1.Click
        Format.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CutCtrlXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutCtrlXToolStripMenuItem.Click

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.Text = Nothing
    End Sub

    Private Sub UndoCtrlZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoCtrlZToolStripMenuItem.Click


    End Sub

    Private Sub CopyCtrlCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyCtrlCToolStripMenuItem.Click

    End Sub

    Private Sub PasteCtrlVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteCtrlVToolStripMenuItem.Click

    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        RichTextBox1.Text = Nothing
        ComboBox1.Text = Nothing
        ComboBox3.Text = Nothing

    End Sub
End Class
