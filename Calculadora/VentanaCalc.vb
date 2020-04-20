Imports Logic

Public Class VentanaCalc
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttnResult.Click
        If txtValor1.Text <> "" And txtValor2.Text <> "" Then
            Dim val1 As Double = Double.Parse(txtValor1.Text)
            Dim val2 As Double = Double.Parse(txtValor2.Text)
            Dim operador As String = CB_operador.Text

            Dim calculo As LogicaCalc = New LogicaCalc(val1, val2)

            Select Case operador
                Case "SUMAR"
                    txt_resultado.Text = calculo.Sumar()

                Case "RESTAR"
                    txt_resultado.Text = calculo.Restar()

                Case "MULTIPLICAR"
                    txt_resultado.Text = calculo.Multi()

                Case "DIVIDIR"
                    txt_resultado.Text = calculo.Dividir()

                Case Else
                    MsgBox("Debe seleccionar un operador para ver un resultado :)")
            End Select
        Else
            MsgBox("No ingresó todos los valores requeridos para realizar algun tipo de operacion :(")
        End If

    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_operador.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtValor1.TextChanged

    End Sub

    Private Sub bttnVaciar_Click(sender As Object, e As EventArgs) Handles bttnVaciar.Click
        txtValor1.Text = ""
        txtValor2.Text = ""
        txt_resultado.Text = ""
        CB_operador.Text = ""
    End Sub
End Class
