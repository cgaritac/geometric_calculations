Public Class FrmAreaOctagono

    Private Sub btnOctCalcular_Click(sender As Object, e As EventArgs) Handles btnOctCalcular.Click
        If txtOctLado.Text = "0" Or txtOctLado.Text = "" Then

            If txtOctLado.Text = "0" Then
                MessageBox.Show("Error, por favor ingrese un valor de lado superior a cero", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtOctLado.Text = "" Then
                MessageBox.Show("Error, por favor ingrese un valor de lado para efectuar el cálculo", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Else
            Dim Resultado, lado As Double

            lado = txtOctLado.Text

            Resultado = (4.8284271244 * lado * lado)

            txtOctResultado.Text = FormatNumber(Resultado, 2)
        End If
    End Sub

    Private Sub txtOctLado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOctLado.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub
End Class