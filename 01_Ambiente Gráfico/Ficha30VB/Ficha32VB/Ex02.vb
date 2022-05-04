Public Class Ex02
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim FlagIngrediente As Boolean = False
        Dim FlagMassa As Boolean = False
        Dim FlagQueijo As Boolean = False
        Dim MensagemIngredientes As String
        Dim MensagemMassa As String
        Dim MensagemQueijo As String

        If CheckBox1.Checked = True Then

            FlagIngrediente = True
            MensagemIngredientes += "pepperoni, "

        End If

        If CheckBox2.Checked = True Then

            FlagIngrediente = True
            MensagemIngredientes += "fiambre, "

        End If

        If CheckBox3.Checked = True Then

            FlagIngrediente = True
            MensagemIngredientes += "cogumelos, "

        End If

        If RadioButton1.Checked = True Then

            FlagMassa = True
            mensagemMassa = "fina"

        End If

        If RadioButton2.Checked = True Then

            FlagMassa = True
            mensagemMassa = "normal"

        End If

        If RadioButton3.Checked = True Then

            FlagQueijo = True
            MensagemQueijo = "Mozzarela"

        End If

        If RadioButton4.Checked = True Then

            FlagQueijo = True
            MensagemQueijo = "Parmessão"

        End If

        If FlagIngrediente = False Then

            MessageBox.Show("Erro!Introduza pelo menos um ingrediente")

        End If

        If FlagMassa = False Then

            MessageBox.Show("Erro!Introduza pelo menos um tipo de massa")

        End If

        If FlagQueijo = False Then

            MessageBox.Show("Erro!Introduza pelo menos um tipo de queijo")

        End If

        If FlagIngrediente = True And FlagMassa = True And FlagQueijo = True Then

            MessageBox.Show("A sua pizza contém como ingredientes " & MensagemIngredientes & " com massa do tipo " & mensagemMassa & " e queijo " & MensagemQueijo)

        End If
    End Sub
End Class