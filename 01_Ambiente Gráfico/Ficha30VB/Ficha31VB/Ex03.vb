Public Class Ex03
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim vetChar() As Char
        Dim c As Integer

        If TextBox1.Text = " " Then

            MessageBox.Show("Erro!Introduza um número")

        ElseIf Trim(TextBox1.Text) = "" Then

            MessageBox.Show("Erro!Introduza um número")

        End If

        vetChar = (TextBox1.Text).ToCharArray

        For i = 0 To vetChar.Length - 1

            If vetChar(i) <> " " Then
                c += 1
            End If

        Next

        TextBox2.Text = c
    End Sub
End Class