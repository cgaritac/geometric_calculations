<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAreaTrapecio
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
        Me.lblTrapFormula = New System.Windows.Forms.Label()
        Me.lblTrapTitulo = New System.Windows.Forms.Label()
        Me.gbTrapecio = New System.Windows.Forms.GroupBox()
        Me.lblTrapAlt = New System.Windows.Forms.Label()
        Me.txtTrapAlt = New System.Windows.Forms.TextBox()
        Me.lblTrapBasMay = New System.Windows.Forms.Label()
        Me.txtTrapResultado = New System.Windows.Forms.TextBox()
        Me.txtTrapBasMay = New System.Windows.Forms.TextBox()
        Me.lblTrapResultado = New System.Windows.Forms.Label()
        Me.btnTrapCalcular = New System.Windows.Forms.Button()
        Me.txtTrapBasMen = New System.Windows.Forms.TextBox()
        Me.lblTrapBasMen = New System.Windows.Forms.Label()
        Me.pbTrapecio = New System.Windows.Forms.PictureBox()
        Me.gbTrapecio.SuspendLayout()
        CType(Me.pbTrapecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTrapFormula
        '
        Me.lblTrapFormula.AutoSize = True
        Me.lblTrapFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTrapFormula.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblTrapFormula.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTrapFormula.Location = New System.Drawing.Point(57, 110)
        Me.lblTrapFormula.Name = "lblTrapFormula"
        Me.lblTrapFormula.Size = New System.Drawing.Size(476, 25)
        Me.lblTrapFormula.TabIndex = 14
        Me.lblTrapFormula.Text = "Área = ((Base mayor + base menor) * Altura) / 2"
        '
        'lblTrapTitulo
        '
        Me.lblTrapTitulo.AutoSize = True
        Me.lblTrapTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTrapTitulo.ForeColor = System.Drawing.Color.Navy
        Me.lblTrapTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTrapTitulo.Location = New System.Drawing.Point(151, 40)
        Me.lblTrapTitulo.Name = "lblTrapTitulo"
        Me.lblTrapTitulo.Size = New System.Drawing.Size(294, 36)
        Me.lblTrapTitulo.TabIndex = 11
        Me.lblTrapTitulo.Text = "Área de un trapecio"
        '
        'gbTrapecio
        '
        Me.gbTrapecio.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbTrapecio.Controls.Add(Me.lblTrapAlt)
        Me.gbTrapecio.Controls.Add(Me.txtTrapAlt)
        Me.gbTrapecio.Controls.Add(Me.lblTrapBasMay)
        Me.gbTrapecio.Controls.Add(Me.txtTrapResultado)
        Me.gbTrapecio.Controls.Add(Me.txtTrapBasMay)
        Me.gbTrapecio.Controls.Add(Me.lblTrapResultado)
        Me.gbTrapecio.Controls.Add(Me.btnTrapCalcular)
        Me.gbTrapecio.Controls.Add(Me.txtTrapBasMen)
        Me.gbTrapecio.Controls.Add(Me.lblTrapBasMen)
        Me.gbTrapecio.Location = New System.Drawing.Point(12, 201)
        Me.gbTrapecio.Name = "gbTrapecio"
        Me.gbTrapecio.Size = New System.Drawing.Size(776, 237)
        Me.gbTrapecio.TabIndex = 13
        Me.gbTrapecio.TabStop = False
        '
        'lblTrapAlt
        '
        Me.lblTrapAlt.AutoSize = True
        Me.lblTrapAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTrapAlt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTrapAlt.Location = New System.Drawing.Point(550, 47)
        Me.lblTrapAlt.Name = "lblTrapAlt"
        Me.lblTrapAlt.Size = New System.Drawing.Size(89, 20)
        Me.lblTrapAlt.TabIndex = 9
        Me.lblTrapAlt.Text = "Altura (m):"
        '
        'txtTrapAlt
        '
        Me.txtTrapAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTrapAlt.Location = New System.Drawing.Point(654, 44)
        Me.txtTrapAlt.Name = "txtTrapAlt"
        Me.txtTrapAlt.Size = New System.Drawing.Size(100, 26)
        Me.txtTrapAlt.TabIndex = 8
        '
        'lblTrapBasMay
        '
        Me.lblTrapBasMay.AutoSize = True
        Me.lblTrapBasMay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTrapBasMay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTrapBasMay.Location = New System.Drawing.Point(6, 47)
        Me.lblTrapBasMay.Name = "lblTrapBasMay"
        Me.lblTrapBasMay.Size = New System.Drawing.Size(135, 20)
        Me.lblTrapBasMay.TabIndex = 3
        Me.lblTrapBasMay.Text = "Base mayor (m):"
        '
        'txtTrapResultado
        '
        Me.txtTrapResultado.Enabled = False
        Me.txtTrapResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTrapResultado.Location = New System.Drawing.Point(430, 154)
        Me.txtTrapResultado.Name = "txtTrapResultado"
        Me.txtTrapResultado.Size = New System.Drawing.Size(100, 26)
        Me.txtTrapResultado.TabIndex = 7
        '
        'txtTrapBasMay
        '
        Me.txtTrapBasMay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTrapBasMay.Location = New System.Drawing.Point(162, 44)
        Me.txtTrapBasMay.Name = "txtTrapBasMay"
        Me.txtTrapBasMay.Size = New System.Drawing.Size(100, 26)
        Me.txtTrapBasMay.TabIndex = 0
        '
        'lblTrapResultado
        '
        Me.lblTrapResultado.AutoSize = True
        Me.lblTrapResultado.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblTrapResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTrapResultado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTrapResultado.Location = New System.Drawing.Point(178, 157)
        Me.lblTrapResultado.Name = "lblTrapResultado"
        Me.lblTrapResultado.Size = New System.Drawing.Size(204, 20)
        Me.lblTrapResultado.TabIndex = 5
        Me.lblTrapResultado.Text = "Área de Trapecio (m2):"
        '
        'btnTrapCalcular
        '
        Me.btnTrapCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTrapCalcular.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTrapCalcular.Location = New System.Drawing.Point(625, 150)
        Me.btnTrapCalcular.Name = "btnTrapCalcular"
        Me.btnTrapCalcular.Size = New System.Drawing.Size(106, 35)
        Me.btnTrapCalcular.TabIndex = 6
        Me.btnTrapCalcular.Text = "Calcular"
        Me.btnTrapCalcular.UseVisualStyleBackColor = True
        '
        'txtTrapBasMen
        '
        Me.txtTrapBasMen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTrapBasMen.Location = New System.Drawing.Point(430, 44)
        Me.txtTrapBasMen.Name = "txtTrapBasMen"
        Me.txtTrapBasMen.Size = New System.Drawing.Size(100, 26)
        Me.txtTrapBasMen.TabIndex = 1
        '
        'lblTrapBasMen
        '
        Me.lblTrapBasMen.AutoSize = True
        Me.lblTrapBasMen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTrapBasMen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTrapBasMen.Location = New System.Drawing.Point(278, 47)
        Me.lblTrapBasMen.Name = "lblTrapBasMen"
        Me.lblTrapBasMen.Size = New System.Drawing.Size(133, 20)
        Me.lblTrapBasMen.TabIndex = 4
        Me.lblTrapBasMen.Text = "base menor (m):"
        '
        'pbTrapecio
        '
        Me.pbTrapecio.Image = Global.Calculos_Geometricos.My.Resources.Resources.areatrapecio
        Me.pbTrapecio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbTrapecio.Location = New System.Drawing.Point(580, 12)
        Me.pbTrapecio.Name = "pbTrapecio"
        Me.pbTrapecio.Size = New System.Drawing.Size(208, 169)
        Me.pbTrapecio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTrapecio.TabIndex = 12
        Me.pbTrapecio.TabStop = False
        '
        'FrmAreaTrapecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTrapFormula)
        Me.Controls.Add(Me.pbTrapecio)
        Me.Controls.Add(Me.lblTrapTitulo)
        Me.Controls.Add(Me.gbTrapecio)
        Me.Name = "FrmAreaTrapecio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cálculo Área Trapecio"
        Me.gbTrapecio.ResumeLayout(False)
        Me.gbTrapecio.PerformLayout()
        CType(Me.pbTrapecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTrapFormula As Label
    Friend WithEvents pbTrapecio As PictureBox
    Friend WithEvents lblTrapTitulo As Label
    Friend WithEvents gbTrapecio As GroupBox
    Friend WithEvents lblTrapBasMay As Label
    Friend WithEvents txtTrapResultado As TextBox
    Friend WithEvents txtTrapBasMay As TextBox
    Friend WithEvents lblTrapResultado As Label
    Friend WithEvents btnTrapCalcular As Button
    Friend WithEvents txtTrapBasMen As TextBox
    Friend WithEvents lblTrapBasMen As Label
    Friend WithEvents lblTrapAlt As Label
    Friend WithEvents txtTrapAlt As TextBox
End Class
