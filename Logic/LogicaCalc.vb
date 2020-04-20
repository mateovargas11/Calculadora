Public Class LogicaCalc

    Private num1 As Double
    Private num2 As Double

    Public Sub New(num1 As Double, num2 As Double)
        Me.num1 = num1
        Me.num2 = num2
    End Sub

    Public Property propNum1() As Double
        Get
            Return num1
        End Get
        Set(value As Double)
            Me.num1 = value
        End Set
    End Property

    Public Property propNum2() As Double
        Get
            Return num2
        End Get
        Set(value As Double)
            Me.num2 = value
        End Set
    End Property

    Public Function Sumar() As Double
        Return (num1 + num2)
    End Function

    Public Function Restar() As Double
        Return (num1 - num2)
    End Function

    Public Function Multi() As Double
        Return (num1 * num2)
    End Function

    Public Function Dividir() As Double
        If num2 <> 0 Then
            Return (num1 / num2)
        Else
            Return MsgBox("No se puede dividir entre 0!!")
        End If
    End Function

End Class
