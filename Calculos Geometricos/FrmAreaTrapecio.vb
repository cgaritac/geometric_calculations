Public Class FrmAreaTrapecio
    Private Sub btnTrapCalcular_Click(sender As Object, e As EventArgs) Handles btnTrapCalcular.Click

        If txtTrapAlt.Text = "0" Or txtTrapBasMay.Text = "0" Or txtTrapAlt.Text = "" Or txtTrapBasMay.Text = "" Or txtTrapBasMen.Text = "0" Or txtTrapBasMen.Text = "" Then

            If txtTrapAlt.Text = "0" Then
                MessageBox.Show("Error, por favor ingrese un valor de altura superior a cero", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtTrapAlt.Text = "" Then
                MessageBox.Show("Error, por favor ingrese un valor de altura para efectuar el cálculo", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtTrapBasMay.Text = "0" Then
                MessageBox.Show("Error, por favor ingrese un valor de Base mayor superior a cero", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtTrapBasMay.Text = "" Then
                MessageBox.Show("Error, por favor ingrese un valor de Base mayor para efectuar el cálculo", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtTrapBasMen.Text = "0" Then
                MessageBox.Show("Error, por favor ingrese un valor de base menor superior a cero", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtTrapBasMen.Text = "" Then
                MessageBox.Show("Error, por favor ingrese un valor de base menor para efectuar el cálculo", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Else

            Dim Bmayor, bmenor As Double

            Bmayor = txtTrapBasMay.Text
            bmenor = txtTrapBasMen.Text

            If Bmayor < bmenor Then

                If Bmayor < bmenor Then
                    MessageBox.Show("Error, por favor ingrese un valor de Base mayor superior al valor de base menor para efectuar el cálculo", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Else
                Dim Resultado, altura As Double

                altura = txtTrapAlt.Text

                Resultado = ((Bmayor + bmenor) * altura) / 2

                txtTrapResultado.Text = FormatNumber(Resultado, 2)
            End If
        End If
    End Sub

    Private Sub txtTrapAlt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTrapAlt.KeyPress
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

    Private Sub txtTrapBasMay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTrapBasMay.KeyPress
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

    Private Sub txtTrapBasMen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTrapBasMen.KeyPress
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