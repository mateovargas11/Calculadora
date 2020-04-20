<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaCalc
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
        Me.bttnResult = New System.Windows.Forms.Button()
        Me.CB_operador = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.bttnVaciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bttnResult
        '
        Me.bttnResult.Location = New System.Drawing.Point(76, 315)
        Me.bttnResult.Name = "bttnResult"
        Me.bttnResult.Size = New System.Drawing.Size(83, 26)
        Me.bttnResult.TabIndex = 0
        Me.bttnResult.Text = "Ver resultado"
        Me.bttnResult.UseVisualStyleBackColor = True
        '
        'CB_operador
        '
        Me.CB_operador.FormattingEnabled = True
        Me.CB_operador.Items.AddRange(New Object() {"SUMAR", "RESTAR", "MULTIPLICAR", "DIVIDIR"})
        Me.CB_operador.Location = New System.Drawing.Point(12, 193)
        Me.CB_operador.Name = "CB_operador"
        Me.CB_operador.Size = New System.Drawing.Size(333, 21)
        Me.CB_operador.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Operador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CALCULADORA"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(56, 109)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(86, 20)
        Me.txtValor1.TabIndex = 4
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(198, 109)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(86, 20)
        Me.txtValor2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Primer valor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Segundo valor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Resultado:"
        '
        'txt_resultado
        '
        Me.txt_resultado.Enabled = False
        Me.txt_resultado.Location = New System.Drawing.Point(76, 269)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(198, 20)
        Me.txt_resultado.TabIndex = 9
        '
        'bttnVaciar
        '
        Me.bttnVaciar.Location = New System.Drawing.Point(191, 315)
        Me.bttnVaciar.Name = "bttnVaciar"
        Me.bttnVaciar.Size = New System.Drawing.Size(83, 26)
        Me.bttnVaciar.TabIndex = 10
        Me.bttnVaciar.Text = "Vaciar"
        Me.bttnVaciar.UseVisualStyleBackColor = True
        '
        'VentanaCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 365)
        Me.Controls.Add(Me.bttnVaciar)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_operador)
        Me.Controls.Add(Me.bttnResult)
        Me.Name = "VentanaCalc"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttnResult As Button
    Friend WithEvents CB_operador As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents bttnVaciar As Button
End Class
