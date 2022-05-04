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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxServ3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxServ2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxServ1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RtbVermelho = New System.Windows.Forms.RadioButton()
        Me.RtbPreto = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(703, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 63)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxServ3)
        Me.GroupBox1.Controls.Add(Me.CheckBoxServ2)
        Me.GroupBox1.Controls.Add(Me.CheckBoxServ1)
        Me.GroupBox1.Location = New System.Drawing.Point(415, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 92)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Troca de Pneus"
        '
        'CheckBoxServ3
        '
        Me.CheckBoxServ3.AutoSize = True
        Me.CheckBoxServ3.Location = New System.Drawing.Point(270, 40)
        Me.CheckBoxServ3.Name = "CheckBoxServ3"
        Me.CheckBoxServ3.Size = New System.Drawing.Size(105, 19)
        Me.CheckBoxServ3.TabIndex = 2
        Me.CheckBoxServ3.Text = "Troca de Pneus"
        Me.CheckBoxServ3.UseVisualStyleBackColor = True
        '
        'CheckBoxServ2
        '
        Me.CheckBoxServ2.AutoSize = True
        Me.CheckBoxServ2.Location = New System.Drawing.Point(127, 40)
        Me.CheckBoxServ2.Name = "CheckBoxServ2"
        Me.CheckBoxServ2.Size = New System.Drawing.Size(120, 19)
        Me.CheckBoxServ2.TabIndex = 1
        Me.CheckBoxServ2.Text = "Mudança de Oléo"
        Me.CheckBoxServ2.UseVisualStyleBackColor = True
        '
        'CheckBoxServ1
        '
        Me.CheckBoxServ1.AutoSize = True
        Me.CheckBoxServ1.Location = New System.Drawing.Point(20, 40)
        Me.CheckBoxServ1.Name = "CheckBoxServ1"
        Me.CheckBoxServ1.Size = New System.Drawing.Size(74, 19)
        Me.CheckBoxServ1.TabIndex = 0
        Me.CheckBoxServ1.Text = "Lavagem"
        Me.CheckBoxServ1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RtbVermelho)
        Me.GroupBox2.Controls.Add(Me.RtbPreto)
        Me.GroupBox2.Location = New System.Drawing.Point(415, 219)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 92)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cor"
        '
        'RtbVermelho
        '
        Me.RtbVermelho.AutoSize = True
        Me.RtbVermelho.Location = New System.Drawing.Point(145, 38)
        Me.RtbVermelho.Name = "RtbVermelho"
        Me.RtbVermelho.Size = New System.Drawing.Size(75, 19)
        Me.RtbVermelho.TabIndex = 1
        Me.RtbVermelho.TabStop = True
        Me.RtbVermelho.Text = "Vermelho"
        Me.RtbVermelho.UseVisualStyleBackColor = True
        '
        'RtbPreto
        '
        Me.RtbPreto.AutoSize = True
        Me.RtbPreto.Location = New System.Drawing.Point(23, 38)
        Me.RtbPreto.Name = "RtbPreto"
        Me.RtbPreto.Size = New System.Drawing.Size(53, 19)
        Me.RtbPreto.TabIndex = 0
        Me.RtbPreto.TabStop = True
        Me.RtbPreto.Text = "Preto"
        Me.RtbPreto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(413, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "1º Serviço"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(413, 421)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "2º Serviço"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(413, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "3º Serviço"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(478, 346)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 23)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(478, 382)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(131, 23)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(478, 421)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(131, 23)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(478, 460)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(131, 23)
        Me.TextBox4.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 852)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxServ3 As CheckBox
    Friend WithEvents CheckBoxServ2 As CheckBox
    Friend WithEvents CheckBoxServ1 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RtbVermelho As RadioButton
    Friend WithEvents RtbPreto As RadioButton
End Class
