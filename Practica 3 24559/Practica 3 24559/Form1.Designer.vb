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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sociedad y Cultura IV"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matematicas IV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Medios y tecnologia IV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ingles IV"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Orientacion Vocacional II"
        '
        'Materia1
        '
        Me.Materia1.Location = New System.Drawing.Point(187, 55)
        Me.Materia1.Name = "Materia1"
        Me.Materia1.Size = New System.Drawing.Size(100, 20)
        Me.Materia1.TabIndex = 5
        '
        'Materia2
        '
        Me.Materia2.Location = New System.Drawing.Point(187, 97)
        Me.Materia2.Name = "Materia2"
        Me.Materia2.Size = New System.Drawing.Size(100, 20)
        Me.Materia2.TabIndex = 6
        '
        'Materia3
        '
        Me.Materia3.Location = New System.Drawing.Point(187, 137)
        Me.Materia3.Name = "Materia3"
        Me.Materia3.Size = New System.Drawing.Size(100, 20)
        Me.Materia3.TabIndex = 7
        '
        'Materia4
        '
        Me.Materia4.Location = New System.Drawing.Point(187, 174)
        Me.Materia4.Name = "Materia4"
        Me.Materia4.Size = New System.Drawing.Size(100, 20)
        Me.Materia4.TabIndex = 8
        '
        'Materia5
        '
        Me.Materia5.Location = New System.Drawing.Point(187, 218)
        Me.Materia5.Name = "Materia5"
        Me.Materia5.Size = New System.Drawing.Size(100, 20)
        Me.Materia5.TabIndex = 9
        '
        'Promedio
        '
        Me.Promedio.AutoSize = True
        Me.Promedio.Location = New System.Drawing.Point(349, 62)
        Me.Promedio.Name = "Promedio"
        Me.Promedio.Size = New System.Drawing.Size(51, 13)
        Me.Promedio.TabIndex = 10
        Me.Promedio.Text = "Promedio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(412, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 11
        '
        'Resultado
        '
        Me.Resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultado.Location = New System.Drawing.Point(439, 51)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(100, 29)
        Me.Resultado.TabIndex = 12
        Me.Resultado.Text = "0"
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(352, 201)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(78, 37)
        Me.Calcular.TabIndex = 13
        Me.Calcular.Text = "Calcular Promedio"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 543)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Label7)
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Resultado As TextBox
    Friend WithEvents Calcular As Button
End Class
