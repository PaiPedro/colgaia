<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Lab_ola = New System.Windows.Forms.Label()
        Me.btn_ola = New System.Windows.Forms.Button()
        Me.Lbl_ola = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lab_ola
        '
        Me.Lab_ola.AutoSize = True
        Me.Lab_ola.Enabled = False
        Me.Lab_ola.Location = New System.Drawing.Point(344, 122)
        Me.Lab_ola.Name = "Lab_ola"
        Me.Lab_ola.Size = New System.Drawing.Size(0, 15)
        Me.Lab_ola.TabIndex = 0
        '
        'btn_ola
        '
        Me.btn_ola.Location = New System.Drawing.Point(311, 159)
        Me.btn_ola.Name = "btn_ola"
        Me.btn_ola.Size = New System.Drawing.Size(181, 43)
        Me.btn_ola.TabIndex = 1
        Me.btn_ola.Text = "Quem sou eu?"
        Me.btn_ola.UseVisualStyleBackColor = True
        '
        'Lbl_ola
        '
        Me.Lbl_ola.AutoSize = True
        Me.Lbl_ola.Location = New System.Drawing.Point(350, 122)
        Me.Lbl_ola.Name = "Lbl_ola"
        Me.Lbl_ola.Size = New System.Drawing.Size(112, 15)
        Me.Lbl_ola.TabIndex = 2
        Me.Lbl_ola.Text = "Olá eu sou o Noddy"
        Me.Lbl_ola.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_ola)
        Me.Controls.Add(Me.btn_ola)
        Me.Controls.Add(Me.Lab_ola)
        Me.Name = "Form1"
        Me.Text = "Meu primeiro exercício"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lab_ola As Label
    Friend WithEvents btn_ola As Button
    Friend WithEvents Lbl_ola As Label
End Class
