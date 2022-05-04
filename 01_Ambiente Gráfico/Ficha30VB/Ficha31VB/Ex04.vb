Public Class Ex04
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = " " Then

            MessageBox.Show("Erro!Introduza um valor na primeira caixa de texto")

        ElseIf Trim(TextBox1.Text) = "" Then

            MessageBox.Show("Erro!Introduza um valor na primeira caixa de texto")

        End If

        If TextBox2.Text = " " Then

            MessageBox.Show("Erro!Introduza um valor na segunda caixa de texto")

        ElseIf Trim(TextBox2.Text) = "" Then

            MessageBox.Show("Erro!Introduza um valor na segunda caixa de texto")

        End If

        TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text = " " Then

            MessageBox.Show("Erro!Introduza um valor na primeira caixa de texto")

        ElseIf Trim(TextBox1.Text) = "" Then

            MessageBox.Show("Erro!Introduza um valor na primeira caixa de texto")

        End If

        If TextBox2.Text = " " Then

            MessageBox.Show("Erro!Introduza um valor na segunda caixa de texto")

        ElseIf Trim(TextBox2.Text) = "" Then

            MessageBox.Show("Erro!Introduza um valor na segunda caixa de texto")

        End If

        TextBox3.Text = Val(TextBox2.Text) / Val(TextBox1.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox1.Text = " " Then

            MessageBox.Show("Erro!Introduza um valor na primeira caixa de texto")

        ElseIf Trim(TextBox1.Text) = "" Then

            MessageBox.Show("Erro!Introduza um valor na primeira caixa de texto")

        End If

        If TextBox2.Text = " " Then

            MessageBox.Show("Erro!Introduza um valor na segunda caixa de texto")

        ElseIf Trim(TextBox2.Text) = "" Then

            MessageBox.Show("Erro!Introduza um valor na segunda caixa de texto")

        End If

        TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub
End Class