<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAreaParalelogramo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblParalFormula = New System.Windows.Forms.Label()
        Me.lblParalTitulo = New System.Windows.Forms.Label()
        Me.gbParal = New System.Windows.Forms.GroupBox()
        Me.lblParalAlt = New System.Windows.Forms.Label()
        Me.txtParalAlt = New System.Windows.Forms.TextBox()
        Me.lblParalBase = New System.Windows.Forms.Label()
        Me.txtParalResultado = New System.Windows.Forms.TextBox()
        Me.txtParalBase = New System.Windows.Forms.TextBox()
        Me.lblParalResultado = New System.Windows.Forms.Label()
        Me.btnParalCalcular = New System.Windows.Forms.Button()
        Me.pbParal = New System.Windows.Forms.PictureBox()
        Me.gbParal.SuspendLayout()
        CType(Me.pbParal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblParalFormula
        '
        Me.lblParalFormula.AutoSize = True
        Me.lblParalFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblParalFormula.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblParalFormula.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParalFormula.Location = New System.Drawing.Point(226, 111)
        Me.lblParalFormula.Name = "lblParalFormula"
        Me.lblParalFormula.Size = New System.Drawing.Size(210, 25)
        Me.lblParalFormula.TabIndex = 18
        Me.lblParalFormula.Text = "Área = Base * Altura"
        '
        'lblParalTitulo
        '
        Me.lblParalTitulo.AutoSize = True
        Me.lblParalTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblParalTitulo.ForeColor = System.Drawing.Color.Navy
        Me.lblParalTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParalTitulo.Location = New System.Drawing.Point(135, 40)
        Me.lblParalTitulo.Name = "lblParalTitulo"
        Me.lblParalTitulo.Size = New System.Drawing.Size(382, 36)
        Me.lblParalTitulo.TabIndex = 15
        Me.lblParalTitulo.Text = "Área de un paralelogramo"
        '
        'gbParal
        '
        Me.gbParal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbParal.Controls.Add(Me.lblParalAlt)
        Me.gbParal.Controls.Add(Me.txtParalAlt)
        Me.gbParal.Controls.Add(Me.lblParalBase)
        Me.gbParal.Controls.Add(Me.txtParalResultado)
        Me.gbParal.Controls.Add(Me.txtParalBase)
        Me.gbParal.Controls.Add(Me.lblParalResultado)
        Me.gbParal.Controls.Add(Me.btnParalCalcular)
        Me.gbParal.Location = New System.Drawing.Point(12, 201)
        Me.gbParal.Name = "gbParal"
        Me.gbParal.Size = New System.Drawing.Size(776, 237)
        Me.gbParal.TabIndex = 17
        Me.gbParal.TabStop = False
        '
        'lblParalAlt
        '
        Me.lblParalAlt.AutoSize = True
        Me.lblParalAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblParalAlt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParalAlt.Location = New System.Drawing.Point(480, 57)
        Me.lblParalAlt.Name = "lblParalAlt"
        Me.lblParalAlt.Size = New System.Drawing.Size(89, 20)
        Me.lblParalAlt.TabIndex = 9
        Me.lblParalAlt.Text = "Altura (m):"
        '
        'txtParalAlt
        '
        Me.txtParalAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtParalAlt.Location = New System.Drawing.Point(585, 54)
        Me.txtParalAlt.Name = "txtParalAlt"
        Me.txtParalAlt.Size = New System.Drawing.Size(100, 26)
        Me.txtParalAlt.TabIndex = 8
        '
        'lblParalBase
        '
        Me.lblParalBase.AutoSize = True
        Me.lblParalBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblParalBase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParalBase.Location = New System.Drawing.Point(78, 57)
        Me.lblParalBase.Name = "lblParalBase"
        Me.lblParalBase.Size = New System.Drawing.Size(191, 20)
        Me.lblParalBase.TabIndex = 3
        Me.lblParalBase.Text = "Longitud de la base (m):"
        '
        'txtParalResultado
        '
        Me.txtParalResultado.Enabled = False
        Me.txtParalResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtParalResultado.Location = New System.Drawing.Point(443, 154)
        Me.txtParalResultado.Name = "txtParalResultado"
        Me.txtParalResultado.Size = New System.Drawing.Size(100, 26)
        Me.txtParalResultado.TabIndex = 7
        '
        'txtParalBase
        '
        Me.txtParalBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtParalBase.Location = New System.Drawing.Point(305, 54)
        Me.txtParalBase.Name = "txtParalBase"
        Me.txtParalBase.Size = New System.Drawing.Size(100, 26)
        Me.txtParalBase.TabIndex = 0
        '
        'lblParalResultado
        '
        Me.lblParalResultado.AutoSize = True
        Me.lblParalResultado.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblParalResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblParalResultado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParalResultado.Location = New System.Drawing.Point(142, 157)
        Me.lblParalResultado.Name = "lblParalResultado"
        Me.lblParalResultado.Size = New System.Drawing.Size(252, 20)
        Me.lblParalResultado.TabIndex = 5
        Me.lblParalResultado.Text = "Área de Paralelogramo (m2):"
        '
        'btnParalCalcular
        '
        Me.btnParalCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnParalCalcular.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnParalCalcular.Location = New System.Drawing.Point(625, 150)
        Me.btnParalCalcular.Name = "btnParalCalcular"
        Me.btnParalCalcular.Size = New System.Drawing.Size(106, 35)
        Me.btnParalCalcular.TabIndex = 6
        Me.btnParalCalcular.Text = "Calcular"
        Me.btnParalCalcular.UseVisualStyleBackColor = True
        '
        'pbParal
        '
        Me.pbParal.Image = Global.Calculos_Geometricos.My.Resources.Resources.images
        Me.pbParal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbParal.Location = New System.Drawing.Point(580, 12)
        Me.pbParal.Name = "pbParal"
        Me.pbParal.Size = New System.Drawing.Size(208, 169)
        Me.pbParal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbParal.TabIndex = 16
        Me.pbParal.TabStop = False
        '
        'FrmAreaParalelogramo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblParalFormula)
        Me.Controls.Add(Me.pbParal)
        Me.Controls.Add(Me.lblParalTitulo)
        Me.Controls.Add(Me.gbParal)
        Me.Name = "FrmAreaParalelogramo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cálculo Área Paralelogramo"
        Me.gbParal.ResumeLayout(False)
        Me.gbParal.PerformLayout()
        CType(Me.pbParal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblParalFormula As Label
    Friend WithEvents pbParal As PictureBox
    Friend WithEvents lblParalTitulo As Label
    Friend WithEvents gbParal As GroupBox
    Friend WithEvents lblParalAlt As Label
    Friend WithEvents txtParalAlt As TextBox
    Friend WithEvents lblParalBase As Label
    Friend WithEvents txtParalResultado As TextBox
    Friend WithEvents txtParalBase As TextBox
    Friend WithEvents lblParalResultado As Label
    Friend WithEvents btnParalCalcular As Button
End Class
