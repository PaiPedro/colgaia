Public Class Ex02
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim secs As Integer = Val(TextBox1.Text)
        Dim horas As Integer
        Dim mins As Integer

        If TextBox1.Text = " " Then

            MessageBox.Show("Erro!Introduza um valor em segundos")

        ElseIf Trim(TextBox1.Text) = "" Then

            MessageBox.Show("Erro!Introduza um valor em segundos")

        End If

        horas = secs / 3600
        secs = secs - horas * 3600
        mins = secs / 60
        secs = secs - mins * 60

        TextBox2.Text = horas & " horas " & mins & " minutos " & secs & " segundos "

    End Sub
End Class