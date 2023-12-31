<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAreaOctagono
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAreaOctagono))
        Me.txtOctLado = New System.Windows.Forms.TextBox()
        Me.lblOctTitulo = New System.Windows.Forms.Label()
        Me.lblOctLado = New System.Windows.Forms.Label()
        Me.lblOctResultado = New System.Windows.Forms.Label()
        Me.btnOctCalcular = New System.Windows.Forms.Button()
        Me.txtOctResultado = New System.Windows.Forms.TextBox()
        Me.gbOctagono = New System.Windows.Forms.GroupBox()
        Me.lblOctFormula = New System.Windows.Forms.Label()
        Me.pbOctagono = New System.Windows.Forms.PictureBox()
        Me.gbOctagono.SuspendLayout()
        CType(Me.pbOctagono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOctLado
        '
        resources.ApplyResources(Me.txtOctLado, "txtOctLado")
        Me.txtOctLado.Name = "txtOctLado"
        '
        'lblOctTitulo
        '
        resources.ApplyResources(Me.lblOctTitulo, "lblOctTitulo")
        Me.lblOctTitulo.ForeColor = System.Drawing.Color.Navy
        Me.lblOctTitulo.Name = "lblOctTitulo"
        '
        'lblOctLado
        '
        resources.ApplyResources(Me.lblOctLado, "lblOctLado")
        Me.lblOctLado.Name = "lblOctLado"
        '
        'lblOctResultado
        '
        resources.ApplyResources(Me.lblOctResultado, "lblOctResultado")
        Me.lblOctResultado.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblOctResultado.Name = "lblOctResultado"
        '
        'btnOctCalcular
        '
        resources.ApplyResources(Me.btnOctCalcular, "btnOctCalcular")
        Me.btnOctCalcular.Name = "btnOctCalcular"
        Me.btnOctCalcular.UseVisualStyleBackColor = True
        '
        'txtOctResultado
        '
        resources.ApplyResources(Me.txtOctResultado, "txtOctResultado")
        Me.txtOctResultado.Name = "txtOctResultado"
        '
        'gbOctagono
        '
        Me.gbOctagono.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbOctagono.Controls.Add(Me.lblOctLado)
        Me.gbOctagono.Controls.Add(Me.txtOctResultado)
        Me.gbOctagono.Controls.Add(Me.txtOctLado)
        Me.gbOctagono.Controls.Add(Me.lblOctResultado)
        Me.gbOctagono.Controls.Add(Me.btnOctCalcular)
        resources.ApplyResources(Me.gbOctagono, "gbOctagono")
        Me.gbOctagono.Name = "gbOctagono"
        Me.gbOctagono.TabStop = False
        '
        'lblOctFormula
        '
        resources.ApplyResources(Me.lblOctFormula, "lblOctFormula")
        Me.lblOctFormula.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblOctFormula.Name = "lblOctFormula"
        '
        'pbOctagono
        '
        Me.pbOctagono.Image = Global.Calculos_Geometricos.My.Resources.Resources.areaheptagonoregular
        resources.ApplyResources(Me.pbOctagono, "pbOctagono")
        Me.pbOctagono.Name = "pbOctagono"
        Me.pbOctagono.TabStop = False
        '
        'FrmAreaOctagono
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.Controls.Add(Me.lblOctFormula)
        Me.Controls.Add(Me.pbOctagono)
        Me.Controls.Add(Me.lblOctTitulo)
        Me.Controls.Add(Me.gbOctagono)
        Me.Name = "FrmAreaOctagono"
        Me.ShowIcon = False
        Me.gbOctagono.ResumeLayout(False)
        Me.gbOctagono.PerformLayout()
        CType(Me.pbOctagono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOctLado As TextBox
    Friend WithEvents lblOctTitulo As Label
    Friend WithEvents lblOctLado As Label
    Friend WithEvents lblOctResultado As Label
    Friend WithEvents btnOctCalcular As Button
    Friend WithEvents txtOctResultado As TextBox
    Friend WithEvents pbOctagono As PictureBox
    Friend WithEvents gbOctagono As GroupBox
    Friend WithEvents lblOctFormula As Label
End Class
