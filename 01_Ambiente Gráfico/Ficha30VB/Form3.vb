Public Class Form3
    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Txt_com.Visible = True
        Txt_com.Text = Txt_nom.Text
    End Sub

    Private Sub btn_limpa_Click(sender As Object, e As EventArgs) Handles btn_limpa.Click
        Txt_com.Text = ""
        Txt_nom.Text = ""
        Txt_com.Visible = False
    End Sub

    Private Sub Txt_nom_LostFocus(sender As Object, e As EventArgs) Handles Txt_nom.LostFocus
        If (Trim(Txt_nom.Text) = "" And Txt_nom.Text.Length > 0) Then
            MessageBox.Show("Aviso: tem que introduzir um nome para o programa funcionar.", "Mensagem de aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Txt_nom.Text = ""
            Txt_nom.Select()
        End If
    End Sub
End Class