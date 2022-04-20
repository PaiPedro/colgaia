<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Txt_operando1 = New System.Windows.Forms.TextBox()
        Me.Txt_operando2 = New System.Windows.Forms.TextBox()
        Me.Lab_sinal = New System.Windows.Forms.Label()
        Me.Btn_soma = New System.Windows.Forms.Button()
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Txt_operando1
        '
        Me.Txt_operando1.Location = New System.Drawing.Point(203, 110)
        Me.Txt_operando1.Name = "Txt_operando1"
        Me.Txt_operando1.Size = New System.Drawing.Size(120, 23)
        Me.Txt_operando1.TabIndex = 0
        '
        'Txt_operando2
        '
        Me.Txt_operando2.Location = New System.Drawing.Point(485, 110)
        Me.Txt_operando2.Name = "Txt_operando2"
        Me.Txt_operando2.Size = New System.Drawing.Size(133, 23)
        Me.Txt_operando2.TabIndex = 1
        '
        'Lab_sinal
        '
        Me.Lab_sinal.AutoSize = True
        Me.Lab_sinal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lab_sinal.Location = New System.Drawing.Point(385, 101)
        Me.Lab_sinal.Name = "Lab_sinal"
        Me.Lab_sinal.Size = New System.Drawing.Size(30, 32)
        Me.Lab_sinal.TabIndex = 2
        Me.Lab_sinal.Text = "+"
        '
        'Btn_soma
        '
        Me.Btn_soma.Location = New System.Drawing.Point(357, 189)
        Me.Btn_soma.Name = "Btn_soma"
        Me.Btn_soma.Size = New System.Drawing.Size(84, 27)
        Me.Btn_soma.TabIndex = 3
        Me.Btn_soma.Text = "Somar"
        Me.Btn_soma.UseVisualStyleBackColor = True
        '
        'txt_result
        '
        Me.txt_result.Enabled = False
        Me.txt_result.Location = New System.Drawing.Point(331, 292)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(128, 23)
        Me.txt_result.TabIndex = 4
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_result)
        Me.Controls.Add(Me.Btn_soma)
        Me.Controls.Add(Me.Lab_sinal)
        Me.Controls.Add(Me.Txt_operando2)
        Me.Controls.Add(Me.Txt_operando1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_operando1 As TextBox
    Friend WithEvents Txt_operando2 As TextBox
    Friend WithEvents Lab_sinal As Label
    Friend WithEvents Btn_soma As Button
    Friend WithEvents txt_result As TextBox
End Class
