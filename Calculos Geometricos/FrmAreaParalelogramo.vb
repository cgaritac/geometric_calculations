Public Class FrmAreaParalelogramo
    Private Sub btnTrapCalcular_Click(sender As Object, e As EventArgs) Handles btnParalCalcular.Click
        If txtParalAlt.Text = "0" Or txtParalBase.Text = "0" Or txtParalAlt.Text = "" Or txtParalBase.Text = "" Then

            If txtParalAlt.Text = "0" Then
                MessageBox.Show("Error, por favor ingrese un valor de altura superior a cero", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtParalAlt.Text = "" Then
                MessageBox.Show("Error, por favor ingrese un valor de altura para efectuar el cálculo", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtParalBase.Text = "0" Then
                MessageBox.Show("Error, por favor ingrese un valor de Base superior a cero", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtParalBase.Text = "" Then
                MessageBox.Show("Error, por favor ingrese un valor de Base para efectuar el cálculo", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Else
            Dim Resultado, Base, altura As Double

            Base = txtParalBase.Text
            altura = txtParalAlt.Text

            Resultado = Base * altura

            txtParalResultado.Text = FormatNumber(Resultado, 2)
        End If
    End Sub

    Private Sub txtParalBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtParalBase.KeyPress
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

    Private Sub txtParalAlt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtParalAlt.KeyPress
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