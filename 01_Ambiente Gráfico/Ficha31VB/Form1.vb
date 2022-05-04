Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim N As Integer = Val(TextBox1.Text)
        Dim aux As Integer = 1
        Dim cont As Integer

        If Trim(TextBox1.Text) = "" Then

            MessageBox.Show("Erro!Introduza um número")

        ElseIf TextBox1.Text = " " Then

            MessageBox.Show("Erro!Introduza um número")

        End If
        'verificação do valor inserido na TextBox1

        Do

            If N Mod aux = 0 Then

                cont += 1

            End If

            aux += 1

        Loop While aux <= N
        'verificação se o número é primo ou não

        If cont = 2 Then

            MessageBox.Show("O número é primo")

        Else

            MessageBox.Show("O número não é primo")

        End If
    End Sub
End Class
