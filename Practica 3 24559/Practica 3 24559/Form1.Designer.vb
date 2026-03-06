<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Materia1 = New System.Windows.Forms.TextBox()
        Me.Materia2 = New System.Windows.Forms.TextBox()
        Me.Materia3 = New System.Windows.Forms.TextBox()
        Me.Materia4 = New System.Windows.Forms.TextBox()
        Me.Materia5 = New System.Windows.Forms.TextBox()
        Me.Promedio = New System.Windows.Forms.Label()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Materia13 = New System.Windows.Forms.TextBox()
        Me.Materia12 = New System.Windows.Forms.TextBox()
        Me.Materia11 = New System.Windows.Forms.TextBox()
        Me.Materia10 = New System.Windows.Forms.TextBox()
        Me.Materia9 = New System.Windows.Forms.TextBox()
        Me.Materia8 = New System.Windows.Forms.TextBox()
        Me.Materia7 = New System.Windows.Forms.TextBox()
        Me.Materia6 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sociedad y Cultura IV"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matematicas IV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Medios y tecnologia IV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ingles IV"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Orientacion Vocacional II"
        '
        'Materia1
        '
        Me.Materia1.Location = New System.Drawing.Point(194, 59)
        Me.Materia1.Name = "Materia1"
        Me.Materia1.Size = New System.Drawing.Size(100, 20)
        Me.Materia1.TabIndex = 5
        '
        'Materia2
        '
        Me.Materia2.Location = New System.Drawing.Point(194, 101)
        Me.Materia2.Name = "Materia2"
        Me.Materia2.Size = New System.Drawing.Size(100, 20)
        Me.Materia2.TabIndex = 6
        '
        'Materia3
        '
        Me.Materia3.Location = New System.Drawing.Point(194, 141)
        Me.Materia3.Name = "Materia3"
        Me.Materia3.Size = New System.Drawing.Size(100, 20)
        Me.Materia3.TabIndex = 7
        '
        'Materia4
        '
        Me.Materia4.Location = New System.Drawing.Point(194, 178)
        Me.Materia4.Name = "Materia4"
        Me.Materia4.Size = New System.Drawing.Size(100, 20)
        Me.Materia4.TabIndex = 8
        '
        'Materia5
        '
        Me.Materia5.Location = New System.Drawing.Point(194, 222)
        Me.Materia5.Name = "Materia5"
        Me.Materia5.Size = New System.Drawing.Size(100, 20)
        Me.Materia5.TabIndex = 9
        '
        'Promedio
        '
        Me.Promedio.AutoSize = True
        Me.Promedio.Location = New System.Drawing.Point(356, 66)
        Me.Promedio.Name = "Promedio"
        Me.Promedio.Size = New System.Drawing.Size(51, 13)
        Me.Promedio.TabIndex = 10
        Me.Promedio.Text = "Promedio"
        '
        'Resultado
        '
        Me.Resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultado.Location = New System.Drawing.Point(446, 55)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(100, 29)
        Me.Resultado.TabIndex = 12
        Me.Resultado.Text = "0"
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(359, 205)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(78, 37)
        Me.Calcular.TabIndex = 13
        Me.Calcular.Text = "Calcular Promedio"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Biologia II"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Educacion fisica IV"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Fisica II"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 379)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Formacion Humana IV"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(45, 416)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Literatura II"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(45, 452)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Paraescolar IV"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(45, 491)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Talle de comunicacion II"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(45, 530)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Taller de habilidades II"
        '
        'Materia13
        '
        Me.Materia13.Location = New System.Drawing.Point(194, 527)
        Me.Materia13.Name = "Materia13"
        Me.Materia13.Size = New System.Drawing.Size(100, 20)
        Me.Materia13.TabIndex = 25
        '
        'Materia12
        '
        Me.Materia12.Location = New System.Drawing.Point(194, 488)
        Me.Materia12.Name = "Materia12"
        Me.Materia12.Size = New System.Drawing.Size(100, 20)
        Me.Materia12.TabIndex = 26
        '
        'Materia11
        '
        Me.Materia11.Location = New System.Drawing.Point(194, 449)
        Me.Materia11.Name = "Materia11"
        Me.Materia11.Size = New System.Drawing.Size(100, 20)
        Me.Materia11.TabIndex = 27
        '
        'Materia10
        '
        Me.Materia10.Location = New System.Drawing.Point(194, 413)
        Me.Materia10.Name = "Materia10"
        Me.Materia10.Size = New System.Drawing.Size(100, 20)
        Me.Materia10.TabIndex = 28
        '
        'Materia9
        '
        Me.Materia9.Location = New System.Drawing.Point(194, 376)
        Me.Materia9.Name = "Materia9"
        Me.Materia9.Size = New System.Drawing.Size(100, 20)
        Me.Materia9.TabIndex = 29
        '
        'Materia8
        '
        Me.Materia8.Location = New System.Drawing.Point(194, 338)
        Me.Materia8.Name = "Materia8"
        Me.Materia8.Size = New System.Drawing.Size(100, 20)
        Me.Materia8.TabIndex = 30
        '
        'Materia7
        '
        Me.Materia7.Location = New System.Drawing.Point(194, 300)
        Me.Materia7.Name = "Materia7"
        Me.Materia7.Size = New System.Drawing.Size(100, 20)
        Me.Materia7.TabIndex = 31
        '
        'Materia6
        '
        Me.Materia6.Location = New System.Drawing.Point(194, 262)
        Me.Materia6.Name = "Materia6"
        Me.Materia6.Size = New System.Drawing.Size(100, 20)
        Me.Materia6.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(367, 279)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(123, 27)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "EXCELENTE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 585)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Materia6)
        Me.Controls.Add(Me.Materia7)
        Me.Controls.Add(Me.Materia8)
        Me.Controls.Add(Me.Materia9)
        Me.Controls.Add(Me.Materia10)
        Me.Controls.Add(Me.Materia11)
        Me.Controls.Add(Me.Materia12)
        Me.Controls.Add(Me.Materia13)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Promedio)
        Me.Controls.Add(Me.Materia5)
        Me.Controls.Add(Me.Materia4)
        Me.Controls.Add(Me.Materia3)
        Me.Controls.Add(Me.Materia2)
        Me.Controls.Add(Me.Materia1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Materia1 As TextBox
    Friend WithEvents Materia2 As TextBox
    Friend WithEvents Materia3 As TextBox
    Friend WithEvents Materia4 As TextBox
    Friend WithEvents Materia5 As TextBox
    Friend WithEvents Promedio As Label
    Friend WithEvents Resultado As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Materia13 As TextBox
    Friend WithEvents Materia12 As TextBox
    Friend WithEvents Materia11 As TextBox
    Friend WithEvents Materia10 As TextBox
    Friend WithEvents Materia9 As TextBox
    Friend WithEvents Materia8 As TextBox
    Friend WithEvents Materia7 As TextBox
    Friend WithEvents Materia6 As TextBox
    Friend WithEvents Label15 As Label
End Class
