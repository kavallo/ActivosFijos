<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteActaEntregaCustodio
  Inherits Infoware.Consola.Base.FrmReporteBase

  'Form overrides dispose to clean up the component list.
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

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.CtlBuscaCustodio = New ActivosFijos.Modulo.CtlBuscaEmpleado()
    Me.cbociudad = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.btnmostrar = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Size = New System.Drawing.Size(820, 446)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.DateTimePicker1)
    Me.Panel1.Controls.Add(Me.btnmostrar)
    Me.Panel1.Controls.Add(Me.cbociudad)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.Label18)
    Me.Panel1.Controls.Add(Me.CtlBuscaCustodio)
    Me.Panel1.Size = New System.Drawing.Size(820, 137)
    '
    'CtlBuscaCustodio
    '
    Me.CtlBuscaCustodio.Empleado = Nothing
    Me.CtlBuscaCustodio.EmpleadoText = "Custodio"
    Me.CtlBuscaCustodio.ItemText = "Custodio"
    Me.CtlBuscaCustodio.Location = New System.Drawing.Point(12, 17)
    Me.CtlBuscaCustodio.Name = "CtlBuscaCustodio"
    Me.CtlBuscaCustodio.Size = New System.Drawing.Size(372, 22)
    Me.CtlBuscaCustodio.TabIndex = 0
    Me.CtlBuscaCustodio.TipoEmpleado = Nothing
    Me.CtlBuscaCustodio.Ubicacion = ActivosFijos.Modulo.CtlBuscaEmpleado.EnumUbicacion.Normal
    '
    'cbociudad
    '
    Me.cbociudad.AbriralEntrar = False
    Me.cbociudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbociudad.FormattingEnabled = True
    Me.cbociudad.Location = New System.Drawing.Point(134, 44)
    Me.cbociudad.Margin = New System.Windows.Forms.Padding(2)
    Me.cbociudad.MostrarRutaCompleta = False
    Me.cbociudad.Name = "cbociudad"
    Me.cbociudad.OperadorDatos = Nothing
    Me.cbociudad.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbociudad.ParametroDet = Nothing
    Me.cbociudad.PuedeActualizar = True
    Me.cbociudad.PuedeEliminar = True
    Me.cbociudad.PuedeModificar = True
    Me.cbociudad.PuedeNuevo = True
    Me.cbociudad.Size = New System.Drawing.Size(250, 21)
    Me.cbociudad.TabIndex = 2
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Location = New System.Drawing.Point(12, 47)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(43, 13)
    Me.Label18.TabIndex = 1
    Me.Label18.Text = "Ciudad:"
    '
    'btnmostrar
    '
    Me.btnmostrar.Location = New System.Drawing.Point(134, 107)
    Me.btnmostrar.Name = "btnmostrar"
    Me.btnmostrar.Size = New System.Drawing.Size(75, 23)
    Me.btnmostrar.TabIndex = 5
    Me.btnmostrar.Text = "Mostrar"
    Me.btnmostrar.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 76)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(40, 13)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Fecha:"
    '
    'DateTimePicker1
    '
    Me.DateTimePicker1.Location = New System.Drawing.Point(134, 70)
    Me.DateTimePicker1.Name = "DateTimePicker1"
    Me.DateTimePicker1.Size = New System.Drawing.Size(250, 20)
    Me.DateTimePicker1.TabIndex = 4
    '
    'FrmReporteActaEntregaCustodio
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(820, 495)
    Me.Name = "FrmReporteActaEntregaCustodio"
    Me.PuedeImprimir = True
    Me.Text = "Acta de Entrega a Custodio"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CtlBuscaCustodio As ActivosFijos.Modulo.CtlBuscaEmpleado
  Friend WithEvents btnmostrar As System.Windows.Forms.Button
  Friend WithEvents cbociudad As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
