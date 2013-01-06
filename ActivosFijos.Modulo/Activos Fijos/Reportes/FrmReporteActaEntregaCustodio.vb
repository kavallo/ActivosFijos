Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class FrmReporteActaEntregaCustodio
  Public Property Custodio As Empleado
    Get
      Return CtlBuscaCustodio.Empleado
    End Get
    Set(value As Empleado)
      CtlBuscaCustodio.Empleado = value
    End Set
  End Property

  Sub llenar_datos()
    If Custodio Is Nothing OrElse cbociudad.ParametroDet Is Nothing Then
      Exit Sub
    End If
    Try
      Dim info As New crpActaRecepcionCustodio
      info.DataDefinition.FormulaFields("Fecha").Text = String.Format("'{0}'", Me.DateTimePicker1.Value.ToLongDateString)
      info.DataDefinition.FormulaFields("Ciudad").Text = String.Format("'{0}'", Me.cbociudad.ParametroDet.Descripcion)
      'info.DataDefinition.FormulaFields("PeriodoInventario").Text = String.Format("'{0}'", mPeriodoInventarioString)
      info.DataDefinition.FormulaFields("Empresa").Text = String.Format("'{0}'", New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EmpresaActivo, 1).Descripcion)

      info.SetDataSource(clsReporteActivo.RetornarActaEntregaCustodioDS(Custodio))
      info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
      'Me.CrystalReportViewer1.Zoom(1)
      Me.ReporteDatos = info
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    'Me.CtlPersona1.PuedeElegirTipoEntidad = True
    FrmMantenimientoActivo_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub FrmMantenimientoActivo_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.cbociudad.Parametro = Enumerados.EnumParametros.Ciudad
    Me.cbociudad.OperadorDatos = Sistema.OperadorDatos
    Me.cbociudad.Llenar_Datos()
    Me.cbociudad.SelectedValue = My.Settings.ciudadactual

    Me.cboPeriodoInventario.Parametro = Enumerados.EnumParametros.PeriodoInventario
    Me.cboPeriodoInventario.OperadorDatos = Sistema.OperadorDatos
    Me.cboPeriodoInventario.Llenar_Datos()

    cboInventario.MostrarRutaCompleta = True
    cboInventario.Parametro = Enumerados.EnumParametros.UbicacionActivo
    cboInventario.OperadorDatos = Sistema.OperadorDatos
    Me.cboInventario.Llenar_Datos(InventarioList.ObtenerUbicaciones(Sistema.OperadorDatos, Me.cboPeriodoInventario.ParametroDet))

    Me.CtlBuscaCustodio.OperadorDatos = Sistema.OperadorDatos
    Me.CtlBuscaCustodio.Llenar_Datos()
  End Sub
#End Region

  Private Sub btnmostrar_Click(sender As System.Object, e As System.EventArgs) Handles btnmostrar.Click
    Me.Custodio = Me.CtlBuscaCustodio.Empleado
    My.Settings.ciudadactual = Me.cbociudad.SelectedValue
    My.Settings.Save()
    llenar_datos()
  End Sub

  Private Sub btnActaConstatacion_Click(sender As System.Object, e As System.EventArgs) Handles btnActaConstatacion.Click
    mostrar_ActaConstatacion()
  End Sub

  Sub mostrar_ActaConstatacion()
    If Custodio Is Nothing OrElse cbociudad.ParametroDet Is Nothing Then
      Exit Sub
    End If
    Try
      Dim info As New crpSriActaRecepcion
      info.DataDefinition.FormulaFields("titulo").Text = String.Format("'{0}'", Me.cboPeriodoInventario.ParametroDet.Descripcion.ToUpper)
      'info.DataDefinition.FormulaFields("Ciudad").Text = String.Format("'{0}'", Me.cbociudad.ParametroDet.Descripcion)
      ''info.DataDefinition.FormulaFields("PeriodoInventario").Text = String.Format("'{0}'", mPeriodoInventarioString)
      'info.DataDefinition.FormulaFields("Empresa").Text = String.Format("'{0}'", New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EmpresaActivo, 1).Descripcion)

      info.SetDataSource(clsReporteSRIActaRecepcion.RetornarReporteActaRecepcionDS(Custodio, Me.cboPeriodoInventario.ParametroDet, Me.cboInventario.ParametroDet, Me.chkSoloInventariados.Checked))
      info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
      'Me.CrystalReportViewer1.Zoom(1)
      Me.ReporteDatos = info
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub btnCambioCustodioSRI_Click(sender As System.Object, e As System.EventArgs) Handles btnCambioCustodioSRI.Click
    mostrar_CambioCustodioSRI()
  End Sub

  Sub mostrar_CambioCustodioSRI()
    If Custodio Is Nothing OrElse cbociudad.ParametroDet Is Nothing Then
      Exit Sub
    End If
    Try
      Dim info As New crpSRIcambioCustodioConst
      'info.DataDefinition.FormulaFields("Fecha").Text = String.Format("'{0}'", Me.DateTimePicker1.Value.ToLongDateString)
      'info.DataDefinition.FormulaFields("Ciudad").Text = String.Format("'{0}'", Me.cbociudad.ParametroDet.Descripcion)
      ''info.DataDefinition.FormulaFields("PeriodoInventario").Text = String.Format("'{0}'", mPeriodoInventarioString)
      'info.DataDefinition.FormulaFields("Empresa").Text = String.Format("'{0}'", New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EmpresaActivo, 1).Descripcion)

      info.SetDataSource(clsReporteSRIActaRecepcion.RetornarReporteCambioCustodioDS(Custodio, Me.cboPeriodoInventario.ParametroDet, Me.cboInventario.ParametroDet))
      info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
      'Me.CrystalReportViewer1.Zoom(1)
      Me.ReporteDatos = info
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
    End Sub

  Private Sub cboPeriodoInventario_CambioItem(sender As Object, e As System.EventArgs) Handles cboPeriodoInventario.CambioItem
    Me.cboInventario.Llenar_Datos(InventarioList.ObtenerUbicaciones(Sistema.OperadorDatos, Me.cboPeriodoInventario.ParametroDet))
  End Sub

  Private Sub rdoActaEntrega_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoActaEntrega.CheckedChanged, rdoConstatacion.CheckedChanged
    Me.pnlActaEntrega.Visible = rdoActaEntrega.Checked
    Me.pnlsoloinventariados.Visible = rdoConstatacion.Checked
  End Sub

  Private Sub cboPeriodoInventario_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPeriodoInventario.SelectedIndexChanged

  End Sub
End Class