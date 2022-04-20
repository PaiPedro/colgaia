Public Class Form4
    Private Sub RedefinirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedefinirToolStripMenuItem.Click
        If (Trim(TextBox1.Text) = "") Then
            MessageBox.Show("Deve digitar pelo menos um caracter diferente de espaço", "Mensagem de aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Text = ""
        Else
            TextBox1.Text = ""
        End If
    End Sub


End Class