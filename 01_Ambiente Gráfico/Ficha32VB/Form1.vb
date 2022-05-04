Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim flagCor As Boolean = False
        'flag posteriormente usada para verificar se foi selecionada pelo menos 1 cor

        If CheckBoxServ1.Checked = True Then

            TextBox2.Text = "Lavagem"

        Else

            TextBox2.Text = "-----"

        End If
        'verificação das checkboxs selecionadas

        If CheckBoxServ2.Checked = True Then

            TextBox3.Text = "Mudança de Oléo"

        Else

            TextBox3.Text = "-----"
        End If
        'verificação das checkboxs selecionadas

        If CheckBoxServ3.Checked = True Then

            TextBox4.Text = "Troca de Pneus"

        Else

            TextBox4.Text = "-----"
        End If
        'verificação das checkboxs selecionadas

        If RtbPreto.Checked = True Then

            flagCor = True
            TextBox1.Text = "Preto"

        ElseIf RtbVermelho.Checked = True Then

            flagCor = True
            TextBox1.Text = "Vermelho"

        End If
        'verificação do radio burron selecionado

        If flagCor = False Then

            MessageBox.Show("É necessário indicar pelo menos uma cor")

        End If
        'mensagem de erro

    End Sub
End Class
