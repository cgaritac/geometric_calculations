<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPiramide
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
        Me.lblPiramAreaFormula = New System.Windows.Forms.Label()
        Me.pbPiramide = New System.Windows.Forms.PictureBox()
        Me.lblPiramTitulo = New System.Windows.Forms.Label()
        Me.lblPiramAreaLadoBas = New System.Windows.Forms.Label()
        Me.lblPiramAreaApot = New System.Windows.Forms.Label()
        Me.txtPiramAreaApot = New System.Windows.Forms.TextBox()
        Me.btnPiramAreaCalcular = New System.Windows.Forms.Button()
        Me.lblPiramAreaResultado = New System.Windows.Forms.Label()
        Me.txtPiramAreaLadoBas = New System.Windows.Forms.TextBox()
        Me.txtPiramAreaResultado = New System.Windows.Forms.TextBox()
        Me.tbcPiram = New System.Windows.Forms.TabControl()
        Me.tbcAreaPiram = New System.Windows.Forms.TabPage()
        Me.tbcVolPiram = New System.Windows.Forms.TabPage()
        Me.txtPiramVolAltura = New System.Windows.Forms.TextBox()
        Me.txtPiramVolResultado = New System.Windows.Forms.TextBox()
        Me.lblPiramVolResultado = New System.Windows.Forms.Label()
        Me.btnPiramVolCalcular = New System.Windows.Forms.Button()
        Me.lblPiramVolAltura = New System.Windows.Forms.Label()
        Me.txtPiramVolLadoBas = New System.Windows.Forms.TextBox()
        Me.lblPiramVolLadoBas = New System.Windows.Forms.Label()
        Me.lblPiramVolFormula = New System.Windows.Forms.Label()
        CType(Me.pbPiramide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcPiram.SuspendLayout()
        Me.tbcAreaPiram.SuspendLayout()
        Me.tbcVolPiram.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPiramAreaFormula
        '
        Me.lblPiramAreaFormula.AutoSize = True
        Me.lblPiramAreaFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPiramAreaFormula.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblPiramAreaFormula.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPiramAreaFormula.Location = New System.Drawing.Point(22, 80)
        Me.lblPiramAreaFormula.Name = "lblPiramAreaFormula"
        Me.lblPiramAreaFormula.Size = New System.Drawing.Size(490, 18)
        Me.lblPiramAreaFormula.TabIndex = 18
        Me.lblPiramAreaFormula.Text = "Área = LadoBase*LadoBase+(4*LadoBase*ApotemaPirámide)/2 "
        '
        'pbPiramide
        '
        Me.pbPiramide.Image = Global.Calculos_Geometricos.My.Resources.Resources.Area_piramide
        Me.pbPiramide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbPiramide.Location = New System.Drawing.Point(580, 12)
        Me.pbPiramide.Name = "pbPiramide"
        Me.pbPiramide.Size = New System.Drawing.Size(208, 169)
        Me.pbPiramide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPiramide.TabIndex = 16
        Me.pbPiramide.TabStop = False
        '
        'lblPiramTitulo
        '
        Me.lblPiramTitulo.AutoSize = True
        Me.lblPiramTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblPiramTitulo.ForeColor = System.Drawing.Color.Navy
        Me.lblPiramTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPiramTitulo.Location = New System.Drawing.Point(110, 26)
        Me.lblPiramTitulo.Name = "lblPiramTitulo"
        Me.lblPiramTitulo.Size = New System.Drawing.Size(341, 36)
        Me.lblPiramTitulo.TabIndex = 15
        Me.lblPiramTitulo.Text = "Pirámide Cuadrangular"
        '
        'lblPiramAreaLadoBas
        '
        Me.lblPiramAreaLadoBas.AutoSize = True
        Me.lblPiramAreaLadoBas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPiramAreaLadoBas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPiramAreaLadoBas.Location = New System.Drawing.Point(34, 65)
        Me.lblPiramAreaLadoBas.Name = "lblPiramAreaLadoBas"
        Me.lblPiramAreaLadoBas.Size = New System.Drawing.Size(164, 20)
        Me.lblPiramAreaLadoBas.TabIndex = 3
        Me.lblPiramAreaLadoBas.Text = "Lado de la base (m):"
        '
        'lblPiramAreaApot
        '
        Me.lblPiramAreaApot.AutoSize = True
        Me.lblPiramAreaApot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPiramAreaApot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPiramAreaApot.Location = New System.Drawing.Point(366, 65)
        Me.lblPiramAreaApot.Name = "lblPiramAreaApot"
        Me.lblPiramAreaApot.Size = New System.Drawing.Size(221, 20)
        Me.lblPiramAreaApot.TabIndex = 4
        Me.lblPiramAreaApot.Text = "Apotema de la pirámide (m):"
        '
        'txtPiramAreaApot
        '
        Me.txtPiramAreaApot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPiramAreaApot.Location = New System.Drawing.Point(618, 62)
        Me.txtPiramAreaApot.Name = "txtPiramAreaApot"
        Me.txtPiramAreaApot.Size = New System.Drawing.Size(100, 26)
        Me.txtPiramAreaApot.TabIndex = 1
        '
        'btnPiramAreaCalcular
        '
        Me.btnPiramAreaCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPiramAreaCalcular.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPiramAreaCalcular.Location = New System.Drawing.Point(575, 162)
        Me.btnPiramAreaCalcular.Name = "btnPiramAreaCalcular"
        Me.btnPiramAreaCalcular.Size = New System.Drawing.Size(106, 35)
        Me.btnPiramAreaCalcular.TabIndex = 6
        Me.btnPiramAreaCalcular.Text = "Calcular"
        Me.btnPiramAreaCalcular.UseVisualStyleBackColor = True
        '
        'lblPiramAreaResultado
        '
        Me.lblPiramAreaResultado.AutoSize = True
        Me.lblPiramAreaResultado.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblPiramAreaResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPiramAreaResultado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPiramAreaResultado.Location = New System.Drawing.Point(146, 169)
        Me.lblPiramAreaResultado.Name = "lblPiramAreaResultado"
        Me.lblPiramAreaResultado.Size = New System.Drawing.Size(205, 20)
        Me.lblPiramAreaResultado.TabIndex = 5
        Me.lblPiramAreaResultado.Text = "Área de Pirámide (m2):"
        '
        'txtPiramAreaLadoBas
        '
        Me.txtPiramAreaLadoBas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPiramAreaLadoBas.Location = New System.Drawing.Point(225, 62)
        Me.txtPiramAreaLadoBas.Name = "txtPiramAreaLadoBas"
        Me.txtPiramAreaLadoBas.Size = New System.Drawing.Size(100, 26)
        Me.txtPiramAreaLadoBas.TabIndex = 0
        '
        'txtPiramAreaResultado
        '
        Me.txtPiramAreaResultado.Enabled = False
        Me.txtPiramAreaResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtPiramAreaResultado.Location = New System.Drawing.Point(383, 166)
        Me.txtPiramAreaResultado.Name = "txtPiramAreaResultado"
        Me.txtPiramAreaResultado.Size = New System.Drawing.Size(100, 26)
        Me.txtPiramAreaResultado.TabIndex = 7
        '
        'tbcPiram
        '
        Me.tbcPiram.Controls.Add(Me.tbcAreaPiram)
        Me.tbcPiram.Controls.Add(Me.tbcVolPiram)
        Me.tbcPiram.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcPiram.Location = New System.Drawing.Point(12, 158)
        Me.tbcPiram.Name = "tbcPiram"
        Me.tbcPiram.SelectedIndex = 0
        Me.tbcPiram.Size = New System.Drawing.Size(776, 280)
        Me.tbcPiram.TabIndex = 19
        '
        'tbcAreaPiram
        '
        Me.tbcAreaPiram.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tbcAreaPiram.Controls.Add(Me.txtPiramAreaApot)
        Me.tbcAreaPiram.Controls.Add(Me.txtPiramAreaResultado)
        Me.tbcAreaPiram.Controls.Add(Me.lblPiramAreaResultado)
        Me.tbcAreaPiram.Controls.Add(Me.btnPiramAreaCalcular)
        Me.tbcAreaPiram.Controls.Add(Me.lblPiramAreaApot)
        Me.tbcAreaPiram.Controls.Add(Me.txtPiramAreaLadoBas)
        Me.tbcAreaPiram.Controls.Add(Me.lblPiramAreaLadoBas)
        Me.tbcAreaPiram.Location = New System.Drawing.Point(4, 29)
        Me.tbcAreaPiram.Name = "tbcAreaPiram"
        Me.tbcAreaPiram.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcAreaPiram.Size = New System.Drawing.Size(768, 247)
        Me.tbcAreaPiram.TabIndex = 0
        Me.tbcAreaPiram.Text = "Área Pirámide"
        '
        'tbcVolPiram
        '
        Me.tbcVolPiram.BackColor = System.Drawing.Color.LightBlue
        Me.tbcVolPiram.Controls.Add(Me.txtPiramVolAltura)
        Me.tbcVolPiram.Controls.Add(Me.txtPiramVolResultado)
        Me.tbcVolPiram.Controls.Add(Me.lblPiramVolResultado)
        Me.tbcVolPiram.Controls.Add(Me.btnPiramVolCalcular)
        Me.tbcVolPiram.Controls.Add(Me.lblPiramVolAltura)
        Me.tbcVolPiram.Controls.Add(Me.txtPiramVolLadoBas)
        Me.tbcVolPiram.Controls.Add(Me.lblPiramVolLadoBas)
        Me.tbcVolPiram.Location = New System.Drawing.Point(4, 29)
        Me.tbcVolPiram.Name = "tbcVolPiram"
        Me.tbcVolPiram.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcVolPiram.Size = New System.Drawing.Size(768, 247)
        Me.tbcVolPiram.TabIndex = 1
        Me.tbcVolPiram.Text = "Volumen Pirámide"
        '
        'txtPiramVolAltura
        '
        Me.txtPiramVolAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPiramVolAltura.Location = New System.Drawing.Point(622, 56)
        Me.txtPiramVolAltura.Name = "txtPiramVolAltura"
        Me.txtPiramVolAltura.Size = New System.Drawing.Size(100, 26)
        Me.txtPiramVolAltura.TabIndex = 9
        '
        'txtPiramVolResultado
        '
        Me.txtPiramVolResultado.Enabled = False
        Me.txtPiramVolResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtPiramVolResultado.Location = New System.Drawing.Point(387, 160)
        Me.txtPiramVolResultado.Name = "txtPiramVolResultado"
        Me.txtPiramVolResultado.Size = New System.Drawing.Size(100, 26)
        Me.txtPiramVolResultado.TabIndex = 14
        '
        'lblPiramVolResultado
        '
        Me.lblPiramVolResultado.AutoSize = True
        Me.lblPiramVolResultado.BackColor = System.Drawing.Color.LightBlue
        Me.lblPiramVolResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPiramVolResultado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPiramVolResultado.Location = New System.Drawing.Point(109, 163)
        Me.lblPiramVolResultado.Name = "lblPiramVolResultado"
        Me.lblPiramVolResultado.Size = New System.Drawing.Size(238, 20)
        Me.lblPiramVolResultado.TabIndex = 12
        Me.lblPiramVolResultado.Text = "Volumen de Pirámide (m2):"
        '
        'btnPiramVolCalcular
        '
        Me.btnPiramVolCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPiramVolCalcular.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPiramVolCalcular.Location = New System.Drawing.Point(579, 156)
        Me.btnPiramVolCalcular.Name = "btnPiramVolCalcular"
        Me.btnPiramVolCalcular.Size = New System.Drawing.Size(106, 35)
        Me.btnPiramVolCalcular.TabIndex = 13
        Me.btnPiramVolCalcular.Text = "Calcular"
        Me.btnPiramVolCalcular.UseVisualStyleBackColor = True
        '
        'lblPiramVolAltura
        '
        Me.lblPiramVolAltura.AutoSize = True
        Me.lblPiramVolAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPiramVolAltura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPiramVolAltura.Location = New System.Drawing.Point(395, 59)
        Me.lblPiramVolAltura.Name = "lblPiramVolAltura"
        Me.lblPiramVolAltura.Size = New System.Drawing.Size(199, 20)
        Me.lblPiramVolAltura.TabIndex = 11
        Me.lblPiramVolAltura.Text = "Altura de la pirámide (m):"
        '
        'txtPiramVolLadoBas
        '
        Me.txtPiramVolLadoBas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPiramVolLadoBas.Location = New System.Drawing.Point(229, 56)
        Me.txtPiramVolLadoBas.Name = "txtPiramVolLadoBas"
        Me.txtPiramVolLadoBas.Size = New System.Drawing.Size(100, 26)
        Me.txtPiramVolLadoBas.TabIndex = 8
        '
        'lblPiramVolLadoBas
        '
        Me.lblPiramVolLadoBas.AutoSize = True
        Me.lblPiramVolLadoBas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPiramVolLadoBas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPiramVolLadoBas.Location = New System.Drawing.Point(38, 59)
        Me.lblPiramVolLadoBas.Name = "lblPiramVolLadoBas"
        Me.lblPiramVolLadoBas.Size = New System.Drawing.Size(164, 20)
        Me.lblPiramVolLadoBas.TabIndex = 10
        Me.lblPiramVolLadoBas.Text = "Lado de la base (m):"
        '
        'lblPiramVolFormula
        '
        Me.lblPiramVolFormula.AutoSize = True
        Me.lblPiramVolFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPiramVolFormula.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblPiramVolFormula.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPiramVolFormula.Location = New System.Drawing.Point(81, 118)
        Me.lblPiramVolFormula.Name = "lblPiramVolFormula"
        Me.lblPiramVolFormula.Size = New System.Drawing.Size(392, 18)
        Me.lblPiramVolFormula.TabIndex = 20
        Me.lblPiramVolFormula.Text = "Volumen = (LadoBase*LadoBase*AlturaPirámide)/3"
        '
        'FrmPiramide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPiramVolFormula)
        Me.Controls.Add(Me.pbPiramide)
        Me.Controls.Add(Me.lblPiramAreaFormula)
        Me.Controls.Add(Me.lblPiramTitulo)
        Me.Controls.Add(Me.tbcPiram)
        Me.Name = "FrmPiramide"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cálculos Pirámide Cuadrangular"
        CType(Me.pbPiramide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcPiram.ResumeLayout(False)
        Me.tbcAreaPiram.ResumeLayout(False)
        Me.tbcAreaPiram.PerformLayout()
        Me.tbcVolPiram.ResumeLayout(False)
        Me.tbcVolPiram.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPiramAreaFormula As Label
    Friend WithEvents pbPiramide As PictureBox
    Friend WithEvents lblPiramTitulo As Label
    Friend WithEvents lblPiramAreaLadoBas As Label
    Friend WithEvents lblPiramAreaApot As Label
    Friend WithEvents txtPiramAreaApot As TextBox
    Friend WithEvents btnPiramAreaCalcular As Button
    Friend WithEvents lblPiramAreaResultado As Label
    Friend WithEvents txtPiramAreaLadoBas As TextBox
    Friend WithEvents txtPiramAreaResultado As TextBox
    Friend WithEvents tbcPiram As TabControl
    Friend WithEvents tbcAreaPiram As TabPage
    Friend WithEvents tbcVolPiram As TabPage
    Friend WithEvents txtPiramVolAltura As TextBox
    Friend WithEvents txtPiramVolResultado As TextBox
    Friend WithEvents lblPiramVolResultado As Label
    Friend WithEvents btnPiramVolCalcular As Button
    Friend WithEvents lblPiramVolAltura As Label
    Friend WithEvents txtPiramVolLadoBas As TextBox
    Friend WithEvents lblPiramVolLadoBas As Label
    Friend WithEvents lblPiramVolFormula As Label
End Class
