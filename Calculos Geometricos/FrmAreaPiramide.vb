Public Class FrmPiramide

    Private Sub btnPiramAreaCalcular_Click(sender As Object, e As EventArgs) Handles btnPiramAreaCalcular.Click
        If txtPiramAreaApot.Text = "0" Or txtPiramAreaLadoBas.Text = "0" Or txtPiramAreaApot.Text = "" Or txtPiramAreaLadoBas.Text = "" Then

            If txtPiramAreaApot.Text = "0" Then
                MessageBox.Show("Error, por favor ingrese un valor de apotema superior a cero", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtPiramAreaApot.Text = "" Then
                MessageBox.Show("Error, por favor ingrese un valor de apotema para efectuar el cálculo", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtPiramAreaLadoBas.Text = "0" Then
                MessageBox.Show("Error, por favor ingrese un valor de lado de la base superior a cero", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtPiramAreaLadoBas.Text = "" Then
                MessageBox.Show("Error, por favor ingrese un valor de lado de la base para efectuar el cálculo", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Else
            Dim Resultado, Lado, Apotema As Double

            Lado = txtPiramAreaLadoBas.Text
            Apotema = txtPiramAreaApot.Text

            Resultado = Lado * Lado + (4 * Lado * Apotema) / 2

            txtPiramAreaResultado.Text = FormatNumber(Resultado, 2)
        End If
    End Sub

    Private Sub txtPiramAreaLadoBas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPiramAreaLadoBas.KeyPress
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

    Private Sub txtPiramAreaApot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPiramAreaApot.KeyPress
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

    Private Sub txtPiramVolLadoBas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPiramVolLadoBas.KeyPress
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

    Private Sub txtPiramVolAltura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPiramVolAltura.KeyPress
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

    Private Sub btnPiramVolCalcular_Click(sender As Object, e As EventArgs) Handles btnPiramVolCalcular.Click
        If txtPiramVolLadoBas.Text = "0" Or txtPiramVolAltura.Text = "0" Or txtPiramVolLadoBas.Text = "" Or txtPiramVolAltura.Text = "" Then

            If txtPiramVolLadoBas.Text = "0" Then
                MessageBox.Show("Error, por favor ingrese un valor de lado de la base superior a cero", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtPiramVolLadoBas.Text = "" Then
                MessageBox.Show("Error, por favor ingrese un valor de lado de la base para efectuar el cálculo", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtPiramVolAltura.Text = "0" Then
                MessageBox.Show("Error, por favor ingrese un valor de altura superior a cero", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If txtPiramVolAltura.Text = "" Then
                MessageBox.Show("Error, por favor ingrese un valor de altura para efectuar el cálculo", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Else
            Dim Resultado, Lado, Altura As Double

            Lado = txtPiramVolLadoBas.Text
            Altura = txtPiramVolAltura.Text

            Resultado = (Lado * Lado * Altura) / 3

            txtPiramVolResultado.Text = FormatNumber(Resultado, 2)
        End If
    End Sub
End Class
