Public Class Form1

    'Tipos de variables
    'Integer: numero entero
    'single: numero decimal corto
    'double: numero largo
    'Char: Un unico caracter
    'String: Una cadena de datos

    Sub HolaMundo()
        Dim nombre, nombre2 As String
        nombre = txbN1.Text
        lblSalida.Text = "Hola Mundo"
        'Argb(0-255(transparencia),0-255(rojo),0-255(verde),0-255(azul))
        lblSalida.ForeColor = Color.FromArgb(255, 192, 0, 0)
        'MsgBox(Prompt(Enunciado de mensaje),Style,Titulo)
        MsgBox("Este es mi primer codigo", MsgBoxStyle.Critical + vbYesNoCancel, "Programa")
        'Ocupar variables
        MsgBox("Hola " & nombre, 0, "saludo")
        'Inputbox
        nombre2 = InputBox("Ingrese un nombre", "Nombre", "Ingrese aqui su nombre")
        lblSalida.Text = "Hola " & nombre2


    End Sub

    Sub Calculadora()
        Dim n1, n2 As Single

        n1 = Val(txbN1.Text)
        n2 = Val(txbN2.Text)

        lblSalida.Text = n1 & " + " & n2 & " = " & (n1 + n2) & vbNewLine & n1 & " - " & n2 & " = " & (n1 - n2) & vbNewLine & n1 & " * " & n2 & " = " & (n1 * n2) & vbNewLine & n1 & " / " & n2 & " = " & (n1 / n2) & vbNewLine & n1 & " ^ " & n2 & " = " & (n1 ^ n2)

    End Sub
   
    Private Sub btnEjecutar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click

        Calculadora()
    End Sub
End Class
