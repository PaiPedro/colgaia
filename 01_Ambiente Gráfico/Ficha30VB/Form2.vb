Public Class Form2



    Private Sub Btn_soma_Click(sender As Object, e As EventArgs) Handles Btn_soma.Click

        Dim soma As Decimal
        soma = Val(Txt_operando1.Text) + Val(Txt_operando2.Text)
        txt_result.Text = soma
    End Sub

    Private Sub Txt_operando1_LostFocus(sender As Object, e As EventArgs) Handles Txt_operando1.LostFocus


        If (Not IsNumeric(Txt_operando1.Text) And Txt_operando1.Text.Length > 0) Then
            MessageBox.Show("Erro: o valor digitado não é numérico", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Txt_operando1.Text = ""
            Txt_operando1.Select()
        End If
    End Sub

    Private Sub Txt_operando2_LostFocus(sender As Object, e As EventArgs) Handles Txt_operando2.LostFocus

        If (Not IsNumeric(Txt_operando2.Text) And Txt_operando2.Text.Length > 0) Then
            MessageBox.Show("Erro: o valor digitado não é numérico", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Txt_operando2.Text = ""
            Txt_operando2.Select()
        End If
    End Sub
End Class