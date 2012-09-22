<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoFacturaActivo
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.txtvalortotal = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtnumerofactura = New Infoware.Controles.Base.TextBoxStd()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dtfecfactura = New System.Windows.Forms.DateTimePicker()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.CtlBuscaProveedor1 = New ActivosFijos.Modulo.CtlBuscaProveedor()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.txtvalortotal)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.txtnumerofactura)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.dtfecfactura)
    Me.Panel1.Controls.Add(Me.Label13)
    Me.Panel1.Controls.Add(Me.CtlBuscaProveedor1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(521, 133)
    Me.Panel1.TabIndex = 0
    '
    'txtvalortotal
    '
    Me.txtvalortotal.Location = New System.Drawing.Point(136, 97)
    Me.txtvalortotal.Margin = New System.Windows.Forms.Padding(2)
    Me.txtvalortotal.Mensaje = ""
    Me.txtvalortotal.Name = "txtvalortotal"
    Me.txtvalortotal.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvalortotal.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvalortotal.PromptText = ""
    Me.txtvalortotal.Size = New System.Drawing.Size(200, 20)
    Me.txtvalortotal.TabIndex = 6
    Me.txtvalortotal.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvalortotal.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtvalortotal.Value = 0.0R
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(9, 100)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(70, 13)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Valor factura:"
    '
    'txtnumerofactura
    '
    Me.txtnumerofactura.Location = New System.Drawing.Point(136, 47)
    Me.txtnumerofactura.Margin = New System.Windows.Forms.Padding(2)
    Me.txtnumerofactura.Mensaje = ""
    Me.txtnumerofactura.Name = "txtnumerofactura"
    Me.txtnumerofactura.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtnumerofactura.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtnumerofactura.PromptText = ""
    Me.txtnumerofactura.Size = New System.Drawing.Size(200, 20)
    Me.txtnumerofactura.TabIndex = 2
    Me.txtnumerofactura.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(9, 50)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(98, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Número de factura:"
    '
    'dtfecfactura
    '
    Me.dtfecfactura.Location = New System.Drawing.Point(136, 72)
    Me.dtfecfactura.Name = "dtfecfactura"
    Me.dtfecfactura.Size = New System.Drawing.Size(200, 20)
    Me.dtfecfactura.TabIndex = 4
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(9, 76)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(91, 13)
    Me.Label13.TabIndex = 3
    Me.Label13.Text = "Fecha de factura:"
    '
    'CtlBuscaProveedor1
    '
    Me.CtlBuscaProveedor1.ItemText = "Proveedor"
    Me.CtlBuscaProveedor1.Location = New System.Drawing.Point(12, 20)
    Me.CtlBuscaProveedor1.Name = "CtlBuscaProveedor1"
    Me.CtlBuscaProveedor1.Proveedor = Nothing
    Me.CtlBuscaProveedor1.ProveedorText = "Proveedor"
    Me.CtlBuscaProveedor1.Size = New System.Drawing.Size(478, 22)
    Me.CtlBuscaProveedor1.TabIndex = 0
    Me.CtlBuscaProveedor1.Ubicacion = ActivosFijos.Modulo.CtlBuscaProveedor.EnumUbicacion.Normal
    '
    'FrmMantenimientoFacturaActivo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(521, 182)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoFacturaActivo"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Text = "Factura"
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents CtlBuscaProveedor1 As ActivosFijos.Modulo.CtlBuscaProveedor
  Friend WithEvents dtfecfactura As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents txtnumerofactura As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtvalortotal As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
