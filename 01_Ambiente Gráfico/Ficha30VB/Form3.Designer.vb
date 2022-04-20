<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Txt_nom = New System.Windows.Forms.TextBox()
        Me.lab_nom = New System.Windows.Forms.Label()
        Me.Txt_com = New System.Windows.Forms.TextBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.btn_limpa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt_nom
        '
        Me.Txt_nom.Location = New System.Drawing.Point(89, 107)
        Me.Txt_nom.Name = "Txt_nom"
        Me.Txt_nom.Size = New System.Drawing.Size(417, 23)
        Me.Txt_nom.TabIndex = 0
        '
        'lab_nom
        '
        Me.lab_nom.AutoSize = True
        Me.lab_nom.Location = New System.Drawing.Point(89, 89)
        Me.lab_nom.Name = "lab_nom"
        Me.lab_nom.Size = New System.Drawing.Size(40, 15)
        Me.lab_nom.TabIndex = 1
        Me.lab_nom.Text = "Nome"
        '
        'Txt_com
        '
        Me.Txt_com.Location = New System.Drawing.Point(89, 287)
        Me.Txt_com.Name = "Txt_com"
        Me.Txt_com.Size = New System.Drawing.Size(417, 23)
        Me.Txt_com.TabIndex = 2
        Me.Txt_com.Visible = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(89, 172)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(129, 65)
        Me.btn_confirmar.TabIndex = 3
        Me.btn_confirmar.Text = "Confirma Nome"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'btn_limpa
        '
        Me.btn_limpa.Location = New System.Drawing.Point(363, 172)
        Me.btn_limpa.Name = "btn_limpa"
        Me.btn_limpa.Size = New System.Drawing.Size(143, 65)
        Me.btn_limpa.TabIndex = 4
        Me.btn_limpa.Text = "Limpar"
        Me.btn_limpa.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_limpa)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.Txt_com)
        Me.Controls.Add(Me.lab_nom)
        Me.Controls.Add(Me.Txt_nom)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_nom As TextBox
    Friend WithEvents lab_nom As Label
    Friend WithEvents Txt_com As TextBox
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents btn_limpa As Button
End Class
