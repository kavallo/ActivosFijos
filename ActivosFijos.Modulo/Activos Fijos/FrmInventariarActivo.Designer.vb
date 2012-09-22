<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventariarActivo
  Inherits Infoware.Consola.Base.FrmMantenimientoSimpleBase

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
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.dgActivos = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CtlBuscaActivos1 = New ActivosFijos.Modulo.CtlBuscaActivos()
    Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.CtlGrupoTipoClase = New ActivosFijos.Modulo.CtlParametroDetAnidado()
    Me.cbomarca = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtmodelo = New Infoware.Controles.Base.TextBoxStd()
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtcodigoauxiliar = New Infoware.Controles.Base.TextBoxStd()
    Me.txtcodigobarra = New Infoware.Controles.Base.TextBoxStd()
    Me.txtserie = New Infoware.Controles.Base.TextBoxStd()
    Me.Label28 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label21 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label22 = New System.Windows.Forms.Label()
    Me.CtlUbicacionActivo1 = New ActivosFijos.Modulo.CtlParametroDetAnidado()
    Me.CtlBuscaCustodio = New ActivosFijos.Modulo.CtlBuscaEmpleado()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CtlActivo1 = New ActivosFijos.Modulo.CtlActivo()
    Me.lnkCambiarCustodioUbicacion = New System.Windows.Forms.LinkLabel()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    CType(Me.dgActivos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel2.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.TabControl1)
    Me.pnlcuerpo.Size = New System.Drawing.Size(842, 629)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.TabControl1, 0)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.dgActivos)
    Me.Panel1.Controls.Add(Me.CtlBuscaActivos1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel1.Location = New System.Drawing.Point(3, 3)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(235, 572)
    Me.Panel1.TabIndex = 3
    '
    'dgActivos
    '
    Me.dgActivos.AgruparRepetidos = False
    Me.dgActivos.AllowUserToAddRows = False
    Me.dgActivos.AllowUserToDeleteRows = False
    Me.dgActivos.AutoGenerateColumns = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgActivos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgActivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
    Me.dgActivos.DataSource = Me.BindingSource1
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgActivos.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgActivos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgActivos.Location = New System.Drawing.Point(0, 340)
    Me.dgActivos.Name = "dgActivos"
    Me.dgActivos.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgActivos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgActivos.RowHeadersVisible = False
    Me.dgActivos.Size = New System.Drawing.Size(235, 232)
    Me.dgActivos.TabIndex = 3
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    '
    'CtlBuscaActivos1
    '
    Me.CtlBuscaActivos1.BackColor = System.Drawing.SystemColors.Info
    Me.CtlBuscaActivos1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlBuscaActivos1.Location = New System.Drawing.Point(0, 0)
    Me.CtlBuscaActivos1.Name = "CtlBuscaActivos1"
    Me.CtlBuscaActivos1.OperadorDatos = Nothing
    Me.CtlBuscaActivos1.PuedeExportaryBarCode = False
    Me.CtlBuscaActivos1.Size = New System.Drawing.Size(235, 340)
    Me.CtlBuscaActivos1.TabIndex = 0
    '
    'BindingSource1
    '
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.lnkCambiarCustodioUbicacion)
    Me.Panel2.Controls.Add(Me.CtlBuscaCustodio)
    Me.Panel2.Controls.Add(Me.Label22)
    Me.Panel2.Controls.Add(Me.CtlUbicacionActivo1)
    Me.Panel2.Controls.Add(Me.CtlGrupoTipoClase)
    Me.Panel2.Controls.Add(Me.cbomarca)
    Me.Panel2.Controls.Add(Me.Label8)
    Me.Panel2.Controls.Add(Me.txtmodelo)
    Me.Panel2.Controls.Add(Me.txtdescripcion)
    Me.Panel2.Controls.Add(Me.Label7)
    Me.Panel2.Controls.Add(Me.txtcodigoauxiliar)
    Me.Panel2.Controls.Add(Me.txtcodigobarra)
    Me.Panel2.Controls.Add(Me.txtserie)
    Me.Panel2.Controls.Add(Me.Label28)
    Me.Panel2.Controls.Add(Me.Label6)
    Me.Panel2.Controls.Add(Me.Label21)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.txtcodigo)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(238, 3)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(593, 572)
    Me.Panel2.TabIndex = 0
    '
    'CtlGrupoTipoClase
    '
    Me.CtlGrupoTipoClase.Enabled = False
    Me.CtlGrupoTipoClase.Location = New System.Drawing.Point(138, 109)
    Me.CtlGrupoTipoClase.Name = "CtlGrupoTipoClase"
    Me.CtlGrupoTipoClase.ParametroDet = Nothing
    Me.CtlGrupoTipoClase.ParametroEnum = ActivosFijos.Reglas.Enumerados.EnumParametros.UbicacionActivo
    Me.CtlGrupoTipoClase.PardetRaiz = Nothing
    Me.CtlGrupoTipoClase.Size = New System.Drawing.Size(248, 157)
    Me.CtlGrupoTipoClase.TabIndex = 9
    '
    'cbomarca
    '
    Me.cbomarca.AbriralEntrar = False
    Me.cbomarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbomarca.Enabled = False
    Me.cbomarca.FormattingEnabled = True
    Me.cbomarca.Location = New System.Drawing.Point(138, 295)
    Me.cbomarca.Margin = New System.Windows.Forms.Padding(2)
    Me.cbomarca.MostrarRutaCompleta = False
    Me.cbomarca.Name = "cbomarca"
    Me.cbomarca.OperadorDatos = Nothing
    Me.cbomarca.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbomarca.ParametroDet = Nothing
    Me.cbomarca.PuedeActualizar = True
    Me.cbomarca.PuedeEliminar = True
    Me.cbomarca.PuedeModificar = True
    Me.cbomarca.PuedeNuevo = True
    Me.cbomarca.Size = New System.Drawing.Size(248, 21)
    Me.cbomarca.TabIndex = 13
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(11, 298)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(40, 13)
    Me.Label8.TabIndex = 12
    Me.Label8.Text = "Marca:"
    '
    'txtmodelo
    '
    Me.txtmodelo.Enabled = False
    Me.txtmodelo.Location = New System.Drawing.Point(138, 320)
    Me.txtmodelo.Margin = New System.Windows.Forms.Padding(2)
    Me.txtmodelo.Mensaje = ""
    Me.txtmodelo.Name = "txtmodelo"
    Me.txtmodelo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtmodelo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtmodelo.PromptText = ""
    Me.txtmodelo.Size = New System.Drawing.Size(248, 20)
    Me.txtmodelo.TabIndex = 15
    Me.txtmodelo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Enabled = False
    Me.txtdescripcion.Location = New System.Drawing.Point(138, 271)
    Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(2)
    Me.txtdescripcion.Mensaje = ""
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdescripcion.PromptText = ""
    Me.txtdescripcion.Size = New System.Drawing.Size(248, 20)
    Me.txtdescripcion.TabIndex = 11
    Me.txtdescripcion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(11, 323)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(45, 13)
    Me.Label7.TabIndex = 14
    Me.Label7.Text = "Modelo:"
    '
    'txtcodigoauxiliar
    '
    Me.txtcodigoauxiliar.Enabled = False
    Me.txtcodigoauxiliar.Location = New System.Drawing.Point(138, 60)
    Me.txtcodigoauxiliar.Margin = New System.Windows.Forms.Padding(2)
    Me.txtcodigoauxiliar.Mensaje = ""
    Me.txtcodigoauxiliar.Name = "txtcodigoauxiliar"
    Me.txtcodigoauxiliar.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigoauxiliar.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigoauxiliar.PromptText = ""
    Me.txtcodigoauxiliar.Size = New System.Drawing.Size(248, 20)
    Me.txtcodigoauxiliar.TabIndex = 5
    Me.txtcodigoauxiliar.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'txtcodigobarra
    '
    Me.txtcodigobarra.Enabled = False
    Me.txtcodigobarra.Location = New System.Drawing.Point(138, 36)
    Me.txtcodigobarra.Margin = New System.Windows.Forms.Padding(2)
    Me.txtcodigobarra.Mensaje = ""
    Me.txtcodigobarra.Name = "txtcodigobarra"
    Me.txtcodigobarra.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigobarra.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigobarra.PromptText = ""
    Me.txtcodigobarra.Size = New System.Drawing.Size(248, 20)
    Me.txtcodigobarra.TabIndex = 3
    Me.txtcodigobarra.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'txtserie
    '
    Me.txtserie.Enabled = False
    Me.txtserie.Location = New System.Drawing.Point(138, 84)
    Me.txtserie.Margin = New System.Windows.Forms.Padding(2)
    Me.txtserie.Mensaje = ""
    Me.txtserie.Name = "txtserie"
    Me.txtserie.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtserie.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtserie.PromptText = ""
    Me.txtserie.Size = New System.Drawing.Size(248, 20)
    Me.txtserie.TabIndex = 7
    Me.txtserie.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label28
    '
    Me.Label28.AutoSize = True
    Me.Label28.Location = New System.Drawing.Point(11, 63)
    Me.Label28.Name = "Label28"
    Me.Label28.Size = New System.Drawing.Size(78, 13)
    Me.Label28.TabIndex = 4
    Me.Label28.Text = "Código auxiliar:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(11, 274)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(66, 13)
    Me.Label6.TabIndex = 10
    Me.Label6.Text = "Descripción:"
    '
    'Label21
    '
    Me.Label21.AutoSize = True
    Me.Label21.Location = New System.Drawing.Point(11, 39)
    Me.Label21.Name = "Label21"
    Me.Label21.Size = New System.Drawing.Size(90, 13)
    Me.Label21.TabIndex = 2
    Me.Label21.Text = "Código de barras:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 112)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(39, 13)
    Me.Label3.TabIndex = 8
    Me.Label3.Text = "Grupo:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(11, 87)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(34, 13)
    Me.Label2.TabIndex = 6
    Me.Label2.Text = "Serie:"
    '
    'txtcodigo
    '
    Me.txtcodigo.BackColor = System.Drawing.SystemColors.Window
    Me.txtcodigo.Enabled = False
    Me.txtcodigo.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtcodigo.Location = New System.Drawing.Point(138, 12)
    Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2)
    Me.txtcodigo.Mensaje = ""
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigo.PromptText = ""
    Me.txtcodigo.Size = New System.Drawing.Size(248, 20)
    Me.txtcodigo.TabIndex = 1
    Me.txtcodigo.Text = "0"
    Me.txtcodigo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtcodigo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtcodigo.Value = 0.0R
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(11, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Código:"
    '
    'Label22
    '
    Me.Label22.AutoSize = True
    Me.Label22.Location = New System.Drawing.Point(11, 345)
    Me.Label22.Name = "Label22"
    Me.Label22.Size = New System.Drawing.Size(87, 13)
    Me.Label22.TabIndex = 16
    Me.Label22.Text = "Ubicación inicial:"
    '
    'CtlUbicacionActivo1
    '
    Me.CtlUbicacionActivo1.Enabled = False
    Me.CtlUbicacionActivo1.Location = New System.Drawing.Point(138, 345)
    Me.CtlUbicacionActivo1.Name = "CtlUbicacionActivo1"
    Me.CtlUbicacionActivo1.ParametroDet = Nothing
    Me.CtlUbicacionActivo1.ParametroEnum = ActivosFijos.Reglas.Enumerados.EnumParametros.UbicacionActivo
    Me.CtlUbicacionActivo1.PardetRaiz = Nothing
    Me.CtlUbicacionActivo1.Size = New System.Drawing.Size(248, 144)
    Me.CtlUbicacionActivo1.TabIndex = 17
    '
    'CtlBuscaCustodio
    '
    Me.CtlBuscaCustodio.Empleado = Nothing
    Me.CtlBuscaCustodio.EmpleadoText = "Custodio"
    Me.CtlBuscaCustodio.Enabled = False
    Me.CtlBuscaCustodio.ItemText = "Custodio"
    Me.CtlBuscaCustodio.Location = New System.Drawing.Point(14, 495)
    Me.CtlBuscaCustodio.Name = "CtlBuscaCustodio"
    Me.CtlBuscaCustodio.Size = New System.Drawing.Size(372, 22)
    Me.CtlBuscaCustodio.TabIndex = 18
    Me.CtlBuscaCustodio.TipoEmpleado = Nothing
    Me.CtlBuscaCustodio.Ubicacion = ActivosFijos.Modulo.CtlBuscaEmpleado.EnumUbicacion.Normal
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 25)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(842, 604)
    Me.TabControl1.TabIndex = 4
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.Panel2)
    Me.TabPage1.Controls.Add(Me.Panel1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(834, 578)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Existente"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.CtlActivo1)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(834, 578)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Nuevo"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'CtlActivo1
    '
    Me.CtlActivo1.Activo = Nothing
    Me.CtlActivo1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlActivo1.Location = New System.Drawing.Point(3, 3)
    Me.CtlActivo1.Name = "CtlActivo1"
    Me.CtlActivo1.Size = New System.Drawing.Size(828, 572)
    Me.CtlActivo1.TabIndex = 0
    '
    'lnkCambiarCustodioUbicacion
    '
    Me.lnkCambiarCustodioUbicacion.AutoSize = True
    Me.lnkCambiarCustodioUbicacion.Location = New System.Drawing.Point(135, 520)
    Me.lnkCambiarCustodioUbicacion.Name = "lnkCambiarCustodioUbicacion"
    Me.lnkCambiarCustodioUbicacion.Size = New System.Drawing.Size(156, 13)
    Me.lnkCambiarCustodioUbicacion.TabIndex = 19
    Me.lnkCambiarCustodioUbicacion.TabStop = True
    Me.lnkCambiarCustodioUbicacion.Text = "Cambiar custodio y/o ubicación"
    '
    'FrmInventariarActivo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(842, 678)
    Me.Name = "FrmInventariarActivo"
    Me.Text = "Inventariar Activo"
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    CType(Me.dgActivos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents dgActivos As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CtlBuscaActivos1 As ActivosFijos.Modulo.CtlBuscaActivos
  Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents CtlGrupoTipoClase As ActivosFijos.Modulo.CtlParametroDetAnidado
  Friend WithEvents cbomarca As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtmodelo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtcodigoauxiliar As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txtcodigobarra As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txtserie As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label28 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label21 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label22 As System.Windows.Forms.Label
  Friend WithEvents CtlUbicacionActivo1 As ActivosFijos.Modulo.CtlParametroDetAnidado
  Friend WithEvents CtlBuscaCustodio As ActivosFijos.Modulo.CtlBuscaEmpleado
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents lnkCambiarCustodioUbicacion As System.Windows.Forms.LinkLabel
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents CtlActivo1 As ActivosFijos.Modulo.CtlActivo
End Class
