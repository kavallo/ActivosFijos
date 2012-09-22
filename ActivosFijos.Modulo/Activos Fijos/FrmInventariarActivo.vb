Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class FrmInventariarActivo
  Private mInventario As Inventario = Nothing
  Public Property Inventario As Inventario
    Get
      Return mInventario
    End Get
    Set(value As Inventario)
      mInventario = value
    End Set
  End Property

  Public ReadOnly Property Activo As Activo
    Get
      Return BindingSource1.Current
    End Get
  End Property

  Private Sub BindingSource1_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles BindingSource1.CurrentChanged
    llenar_datos()
  End Sub

  Sub llenar_datos()
    If Activo Is Nothing Then
      Exit Sub
    End If
    Me.txtcodigo.Text = Activo.Activo_Codigo
    Me.txtcodigobarra.Text = Activo.Activo_CodigoBarra
    Me.txtcodigoauxiliar.Text = Activo.Activo_CodigoAux
    Me.txtserie.Text = Activo.Serie

    Me.CtlGrupoTipoClase.ParametroDet = Activo.PardetClaseActivo
    Me.txtdescripcion.Text = Activo.Activo_Descripcion
    Me.cbomarca.ParametroDet = Activo.PardetMarca
    Me.txtmodelo.Text = Activo.Activo_Modelo
    Me.CtlUbicacionActivo1.ParametroDet = Activo.UbicacionActual
    Me.CtlBuscaCustodio.Empleado = Activo.CustodioActual
  End Sub

  Private Sub lnkCambiarCustodioUbicacion_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCambiarCustodioUbicacion.LinkClicked
    If Activo Is Nothing Then
      Exit Sub
    End If

    Dim mactivos As New ActivoList
    mactivos.Add(Activo)

    Dim mtransaccion As New TransaccionActivo(Sistema.OperadorDatos, True)
    mtransaccion.Activos = mactivos

    Dim f As New FrmMantenimientoTransaccionActivo(Sistema, Enumerados.EnumOpciones.ListadoTransaccionActivos)
    f.TransaccionActivo = mtransaccion
    f.Custodio = Activo.CustodioActual
    f.Ubicacion = Activo.UbicacionActual
    f.ShowDialog()

    Activo.Recargar()
    llenar_datos()
  End Sub


#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.InventarioActivo)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    'AddHandler Me.DataGridView1.CellMouseMove, AddressOf Me.DataGridView1_CellMouseMove
    FrmListaActivos_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.InventarioActivo)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub FrmInventariarActivo_Guardar(sender As Object, e As System.EventArgs) Handles Me.Guardar
    Dim invdet As InventarioDet = Nothing

    If Me.TabControl1.SelectedIndex = 0 Then 'existente
      If Activo Is Nothing Then
        Exit Sub
      End If
      Try
        invdet = New InventarioDet(Sistema.OperadorDatos, mInventario.Parame_Ubicacion, mInventario.Pardet_Ubicacion, mInventario.Parame_PeriodoInventario, mInventario.Pardet_PeriodoInventario, Activo.Activo_Codigo)
        If Not invdet.Pardet_EstadoInventario = Enumerados.enumEstadoInventarioActivo.NoInventariado Then
          MsgBox("El activo ya fue inventariado", MsgBoxStyle.Critical, "Error")
          Exit Sub
        End If
        invdet.PardetEstadoInventario = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoInventarioActivo, Enumerados.enumEstadoInventarioActivo.Inventariado)
      Catch ex As Exception
        invdet = New InventarioDet(Sistema.OperadorDatos, True)
        invdet.Inventario = mInventario
        invdet.Activocustodio = Activo.ActivoCustodioActual
        invdet.Activoubicacion = Activo.ActivoUbicacionActual
        invdet.InvDet_Activo = True
        invdet.PardetEstadoInventario = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoInventarioActivo, Enumerados.enumEstadoInventarioActivo.EncontradoExistente)
      End Try


    Else
      'nuevo
      Try
        Me.CtlActivo1.Mapear_datos()
        If Me.CtlActivo1.Guardar Then
          invdet = New InventarioDet(Sistema.OperadorDatos, True)
          invdet.Inventario = mInventario
          invdet.Activocustodio = Me.CtlActivo1.Activo.ActivoCustodioActual
          invdet.Activoubicacion = Me.CtlActivo1.Activo.ActivoUbicacionActual
          invdet.InvDet_Activo = True
          invdet.PardetEstadoInventario = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoInventarioActivo, Enumerados.enumEstadoInventarioActivo.EncontradoNuevo)
          Me.CtlActivo1.Activo.Recargar()
          Me.CtlActivo1.llenar_datos()

        Else
          MsgBox(Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
          Exit Sub
        End If
      Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Exit Sub
      End Try
    End If

    If invdet Is Nothing Then
      Exit Sub
    End If

    If invdet.Guardar Then
      'Me.Close()
      MsgBox("Inventario correctamente registrado", MsgBoxStyle.Information, "Información")
      Me.CtlActivo1.Activo = New Activo(Sistema.OperadorDatos, True)
    Else
      MsgBox(invdet.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If
  End Sub

  Private Sub FrmListaActivos_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.Tabla = "Inventariar activo"
    Me.CtlBuscaActivos1.OperadorDatos = Sistema.OperadorDatos
    Me.CtlBuscaActivos1.Llenar_Datos()

    Me.CtlGrupoTipoClase.ParametroEnum = Enumerados.EnumParametros.ClaseActivo
    Me.CtlGrupoTipoClase.llenar_Datos()

    Me.CtlUbicacionActivo1.PardetRaiz = New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo).PardetUbicacion
    Me.CtlUbicacionActivo1.llenar_Datos()

    Me.CtlBuscaCustodio.OperadorDatos = Sistema.OperadorDatos
    Me.CtlBuscaCustodio.TipoEmpleado = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.TipoEmpleado, Enumerados.enumTipoEmpleado.Custodio)
    Me.CtlBuscaCustodio.Llenar_Datos()

    Me.cbomarca.OperadorDatos = Sistema.OperadorDatos
    Me.cbomarca.Parametro = Enumerados.EnumParametros.MarcaActivo
    Me.cbomarca.Llenar_Datos()

    Me.CtlActivo1.Activo = New Activo(Sistema.OperadorDatos, True)
  End Sub
#End Region

  Private Sub CtlBuscaActivos1_Buscar(sender As Object, e As System.EventArgs) Handles CtlBuscaActivos1.Buscar
    Me.BindingSource1.DataSource = Me.CtlBuscaActivos1.Activos
    Me.dgActivos.AutoDiscover()
  End Sub

End Class