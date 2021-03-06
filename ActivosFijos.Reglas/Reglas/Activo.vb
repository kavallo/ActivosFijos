'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión del motor en tiempo de ejecución:2.0.50727.5446
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Infoware.Datos
Imports System.IO


#Region "Activo"
Public Class Activo
  Implements ICloneable

  Const _Procedimiento As String = "proc_Activo"

  Private mPardetClaseActivo As WWTSParametroDet = Nothing

  Private mPardetMarca As WWTSParametroDet = Nothing

  Private mPardetEstadoDepreciacion As WWTSParametroDet = Nothing

  Private mPardetEstadoActivo As WWTSParametroDet = Nothing

  Private mPardetCentroCosto As WWTSParametroDet = Nothing

  Private mPardetTipoBajaActivo As WWTSParametroDet = Nothing

  Private mFacturaactivo As FacturaActivo = Nothing

  Private mActivo_Imagen As System.Drawing.Image = Nothing

  Private mCambio_Imagen As Boolean = False

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
    MyBase.New()
    OperadorDatos = _OperadorDatos
    EsNuevo = _EsNuevo
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Activo_Codigo As Integer)
    Me.New(_OperadorDatos, False)
    Activo_Codigo = _Activo_Codigo
    If Me.Recargar Then
    Else
      Throw New System.Exception("No se puede cargar objeto Activo")
    End If
  End Sub

  Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Activo_CodigoBarra As String)
    Me.New(_OperadorDatos, False)
    Activo_CodigoBarra = _Activo_CodigoBarra
    If Me.RecargarporCodigoBarra Then
    Else
      Throw New System.Exception("No se puede cargar objeto Activo")
    End If
  End Sub

  Public ReadOnly Property Descripcion As String
    Get
      If PardetClaseActivo Is Nothing Then
        Return String.Empty
      End If
      Return String.Format("{0} {1} {2}", PardetClaseActivo.DescripcionLarga, ModeloString, Serie)
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Activo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Logico, 45, True)> _
  Public ReadOnly Property Activo() As Boolean
    Get
      Return Activo_FechaBaja = Nothing
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Código", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Numero, 50, True)> _
  Public ReadOnly Property Codigo() As Integer
    Get
      Return Activo_Codigo
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Código Barra", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 100, True)> _
  Public ReadOnly Property CodigoBarra() As String
    Get
      Return Activo_CodigoBarra
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Serie", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 120, True)> _
  Public ReadOnly Property Serie() As String
    Get
      Return Activo_Serie
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Grupo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property GrupoString() As String
    Get
      If PardetGrupoActivo Is Nothing Then
        Return String.Empty
      Else
        Return PardetGrupoActivo.Descripcion
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Tipo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property TipoString() As String
    Get
      If PardetTipoActivo Is Nothing Then
        Return String.Empty
      Else
        Return PardetTipoActivo.Descripcion
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Clase", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property ClaseString() As String
    Get
      If PardetClaseActivo Is Nothing Then
        Return String.Empty
      Else
        Return PardetClaseActivo.Descripcion
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Marca", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 120, True)> _
  Public ReadOnly Property MarcaString() As String
    Get
      If PardetMarca Is Nothing Then
        Return String.Empty
      Else
        Return PardetMarca.Descripcion
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Modelo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 120, True)> _
  Public ReadOnly Property ModeloString() As String
    Get
      Return Activo_Modelo
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Tipo Baja Activo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property TipoBajaActivoString() As String
    Get
      If PardetTipoBajaActivo Is Nothing Then
        Return String.Empty
      Else
        Return PardetTipoBajaActivo.Descripcion
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Código Auxiliar", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 100, True)> _
  Public ReadOnly Property CodigoAuxiliar() As String
    Get
      Return Activo_CodigoAux
    End Get
  End Property

  'Parametrodet
  Public ReadOnly Property PardetGrupoActivo() As WWTSParametroDet
    Get
      If PardetTipoActivo Is Nothing Then
        Return Nothing
      Else
        Return PardetTipoActivo.PardetPadre
      End If
    End Get
  End Property

  'Parametrodet
  Public ReadOnly Property PardetTipoActivo() As WWTSParametroDet
    Get
      If PardetClaseActivo Is Nothing Then
        Return Nothing
      Else
        Return PardetClaseActivo.PardetPadre
      End If
    End Get
  End Property

  'Parametrodet
  Public Overridable Overloads Property PardetClaseActivo() As WWTSParametroDet
    Get
      If mPardetClaseActivo Is Nothing AndAlso Pardet_ClaseActivo > 0 Then
        mPardetClaseActivo = New WWTSParametroDet(OperadorDatos, Parame_ClaseActivo, Pardet_ClaseActivo)
      End If
      Return Me.mPardetClaseActivo
    End Get
    Set(value As WWTSParametroDet)
      Me.mPardetClaseActivo = value
      Parame_ClaseActivo = value.Parame_Codigo
      Pardet_ClaseActivo = value.Pardet_Secuencia
    End Set
  End Property

  'Parametrodet
  Public Overridable Overloads Property PardetMarca As WWTSParametroDet
    Get
      If mPardetMarca Is Nothing AndAlso Pardet_Marca > 0 Then
        mPardetMarca = New WWTSParametroDet(OperadorDatos, Parame_Marca, Pardet_Marca)
      End If
      Return Me.mPardetMarca
    End Get
    Set(value As WWTSParametroDet)
      Me.mPardetMarca = value
      Parame_Marca = value.Parame_Codigo
      Pardet_Marca = value.Pardet_Secuencia
    End Set
  End Property

  'Parametrodet
  Public Overridable Overloads Property PardetEstadoDepreciacion As WWTSParametroDet
    Get
      If mPardetEstadoDepreciacion Is Nothing AndAlso Pardet_EstadoDepreciacion > 0 Then
        mPardetEstadoDepreciacion = New WWTSParametroDet(OperadorDatos, Parame_EstadoDepreciacion, Pardet_EstadoDepreciacion)
      End If
      Return Me.mPardetEstadoDepreciacion
    End Get
    Set(value As WWTSParametroDet)
      Me.mPardetEstadoDepreciacion = value
      Parame_EstadoDepreciacion = value.Parame_Codigo
      Pardet_EstadoDepreciacion = value.Pardet_Secuencia
    End Set
  End Property

  'Parametrodet
  Public Overridable Overloads Property PardetEstadoActivo As WWTSParametroDet
    Get
      If mPardetEstadoActivo Is Nothing AndAlso Pardet_EstadoActivo > 0 Then
        mPardetEstadoActivo = New WWTSParametroDet(OperadorDatos, Parame_EstadoActivo, Pardet_EstadoActivo)
      End If
      Return Me.mPardetEstadoActivo
    End Get
    Set(value As WWTSParametroDet)
      Me.mPardetEstadoActivo = value
      Parame_EstadoActivo = value.Parame_Codigo
      Pardet_EstadoActivo = value.Pardet_Secuencia
    End Set
  End Property

  'Parametrodet
  Public Overridable Overloads Property PardetCentroCosto As WWTSParametroDet
    Get
      If mPardetCentroCosto Is Nothing AndAlso Pardet_CentroCosto > 0 Then
        mPardetCentroCosto = New WWTSParametroDet(OperadorDatos, Parame_CentroCosto, Pardet_CentroCosto)
      End If
      Return Me.mPardetCentroCosto
    End Get
    Set(value As WWTSParametroDet)
      Me.mPardetCentroCosto = value
      Parame_CentroCosto = value.Parame_Codigo
      Pardet_CentroCosto = value.Pardet_Secuencia
    End Set
  End Property

  'Parametrodet
  Public Overridable Overloads Property PardetTipoBajaActivo As WWTSParametroDet
    Get
      If mPardetTipoBajaActivo Is Nothing AndAlso Pardet_TipoBajaActivo > 0 Then
        mPardetTipoBajaActivo = New WWTSParametroDet(OperadorDatos, Parame_TipoBajaActivo, Pardet_TipoBajaActivo)
      End If
      Return Me.mPardetTipoBajaActivo
    End Get
    Set(value As WWTSParametroDet)
      Me.mPardetTipoBajaActivo = value
      If value Is Nothing Then
        Parame_TipoBajaActivo = 0
        Pardet_TipoBajaActivo = 0
      Else
        Parame_TipoBajaActivo = value.Parame_Codigo
        Pardet_TipoBajaActivo = value.Pardet_Secuencia
      End If
    End Set
  End Property

  'Facturaactivo
  Public Overridable Property Facturaactivo() As FacturaActivo
    Get
      If mFacturaactivo Is Nothing AndAlso Factura_Codigo > 0 Then
        mFacturaactivo = New FacturaActivo(OperadorDatos, Factura_Codigo)
      End If
      Return Me.mFacturaactivo
    End Get
    Set(value As FacturaActivo)
      Me.mFacturaactivo = value
      Factura_Codigo = value.Factura_Codigo
    End Set
  End Property

  Public Overridable ReadOnly Property Activo_ImagenStream() As Byte()
    Get
      Dim imagen() As Byte
      Dim Result As Object = Nothing
      Dim bReturn As Boolean = True
      OperadorDatos.AgregarParametro("@accion", "Pl")
      OperadorDatos.AgregarParametro("@Activo_Codigo", Activo_Codigo)
      OperadorDatos.Procedimiento = _Procedimiento
      bReturn = OperadorDatos.Ejecutar(Result)
      OperadorDatos.LimpiarParametros()
      Try
        imagen = CType(Result, Byte())
      Catch ex As System.Exception
        bReturn = False
        imagen = Nothing
      End Try
      Return imagen
    End Get
  End Property

  'Activo_Imagen
  Public Overridable ReadOnly Property Activo_Imagen(Optional ByVal heightwidth As Integer = 0) As System.Drawing.Image
    Get
      If mActivo_Imagen Is Nothing Then
        Try
          Dim imagen() As Byte
          imagen = Activo_ImagenStream
          Dim ms As New MemoryStream
          ms.Write(imagen, 0, imagen.GetUpperBound(0) + 1)
          mActivo_Imagen = System.Drawing.Image.FromStream(ms)
          ms.Close()
        Catch ex As System.Exception
          mActivo_Imagen = Nothing
        End Try
      End If
      If heightwidth > 0 AndAlso mActivo_Imagen IsNot Nothing Then
        Dim imagenbm = New System.Drawing.Bitmap(mActivo_Imagen)
        Return imagenbm.GetThumbnailImage(heightwidth, heightwidth, Nothing, New IntPtr())
      Else
        Return mActivo_Imagen
      End If
    End Get
  End Property

  Private mArchivoImagen As String = String.Empty
  Public WriteOnly Property ArchivoImagen() As String
    Set(ByVal value As String)
      mArchivoImagen = value
      EsModificado = True
      mCambio_Imagen = True
    End Set
  End Property

#Region "Caracteristicas"
  Private WithEvents mCaracteristicas As ActivoCaracteristicaList = Nothing
  Public Property Caracteristicas As ActivoCaracteristicaList
    Get
      If mCaracteristicas Is Nothing Then
        If EsNuevo Then
          mCaracteristicas = New ActivoCaracteristicaList
        Else
          mCaracteristicas = ActivoCaracteristicaList.ObtenerLista(Me)
        End If
      End If
      Return mCaracteristicas
    End Get
    Set(value As ActivoCaracteristicaList)
      mCaracteristicas = value
    End Set
  End Property

  Private Sub mCaracteristicas_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs) Handles mCaracteristicas.AddingNew
    Dim _caract = New ActivoCaracteristica(OperadorDatos, True)
    _caract.Activo = Me
    e.NewObject = _caract
  End Sub
#End Region

#Region "Componentes"
  Private WithEvents mComponentes As ActivoComponenteList = Nothing
  Private mComponentesEli As ActivoComponenteList = Nothing

  Public Property Componentes As ActivoComponenteList
    Get
      If mComponentes Is Nothing Then
        If EsNuevo Then
          mComponentes = New ActivoComponenteList
        Else
          mComponentes = ActivoComponenteList.ObtenerLista(Me)
        End If
      End If
      Return mComponentes
    End Get
    Set(value As ActivoComponenteList)
      mComponentes = value
    End Set
  End Property

  Public Property ComponentesEli As ActivoComponenteList
    Get
      If mComponentesEli Is Nothing Then
        mComponentesEli = New ActivoComponenteList
      End If
      Return mComponentesEli
    End Get
    Set(value As ActivoComponenteList)
      mComponentesEli = value
    End Set
  End Property

  Private Sub mComponentes_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs) Handles mComponentes.AddingNew
    Dim _caract = New ActivoComponente(OperadorDatos, True)
    _caract.Activo = Me
    e.NewObject = _caract
  End Sub
#End Region

#Region "Inventarios"
  Private WithEvents mInventarios As InventarioDetList = Nothing

  Public Property Inventarios As InventarioDetList
    Get
      If mInventarios Is Nothing Then
        If EsNuevo Then
          mInventarios = New InventarioDetList
        Else
          mInventarios = InventarioDetList.ObtenerLista(Me)
        End If
      End If
      Return mInventarios
    End Get
    Set(value As InventarioDetList)
      mInventarios = value
    End Set
  End Property
#End Region

  Public ReadOnly Property ActivoUbicaciones As ActivoUbicacionList
    Get
      If EsNuevo Then
        Return Nothing
      Else
        Return ActivoUbicacionList.ObtenerLista(Me)
      End If
    End Get
  End Property

  Public ReadOnly Property UbicacionActual As WWTSParametroDet
    Get
      If Not ActivoUbicaciones Is Nothing Then
        For Each _ubicacion As ActivoUbicacion In ActivoUbicaciones
          If _ubicacion.ActUbi_Activo Then
            Return _ubicacion.PardetUbicacion
          End If
        Next
      End If
      Return Nothing
    End Get
  End Property

  Public ReadOnly Property ActivoUbicacionActual As ActivoUbicacion
    Get
      If Not ActivoUbicaciones Is Nothing Then
        For Each _ubicacion As ActivoUbicacion In ActivoUbicaciones
          If _ubicacion.ActUbi_Activo Then
            Return _ubicacion
          End If
        Next
      End If
      Return Nothing
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Proveedor", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property ProveedorString() As String
    Get
      If Facturaactivo Is Nothing Then
        Return String.Empty
      End If
      Return Facturaactivo.ProveedorString
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Factura", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 100, True)> _
  Public ReadOnly Property FacturaNumero() As String
    Get
      If Facturaactivo Is Nothing Then
        Return String.Empty
      End If
      Return Facturaactivo.Factura_Numero
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Fecha factura", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Fecha, 100, True)> _
  Public ReadOnly Property FacturaFecha() As Date
    Get
      If Facturaactivo Is Nothing Then
        Return Now.Date
      End If
      Return Facturaactivo.Factura_Fecha
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Valor original", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Decimales, 100, True)> _
  Public ReadOnly Property ValorOriginal() As Decimal
    Get
      If Valoraciones Is Nothing OrElse Valoraciones.Count = 0 Then
        Return 0
      End If
      Dim mvalororiginal As Decimal = 0
      For Each _valor As ActivoValor In Valoraciones
        If _valor.Pardet_TipoDepreciacion = Enumerados.enumTipoDepreciacion.Tributaria AndAlso _valor.ActVal_Activo Then
          mvalororiginal = _valor.ActVal_Costo
          Exit For
        End If
      Next
      Return mvalororiginal
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Ubicación", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 350, True)> _
  Public ReadOnly Property UbicacionNombre() As String
    Get
      Dim ubicacion As WWTSParametroDet = UbicacionActual
      If ubicacion Is Nothing Then
        Return String.Empty
      End If
      Return ubicacion.DescripcionLarga
    End Get
  End Property

  Public ReadOnly Property ActivoCustodios As ActivoCustodioList
    Get
      If EsNuevo Then
        Return Nothing
      Else
        Return ActivoCustodioList.ObtenerLista(Me)
      End If
    End Get
  End Property

  Public ReadOnly Property CustodioActual As Empleado
    Get
      If Not ActivoCustodios Is Nothing Then
        For Each _custodio As ActivoCustodio In ActivoCustodios
          If _custodio.ActCus_Activo Then
            Return _custodio.Empleado
          End If
        Next
      End If
      Return Nothing
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Custodio", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 200, True)> _
  Public ReadOnly Property CustodioNombre() As String
    Get
      Dim custodio As Empleado = CustodioActual
      If custodio Is Nothing Then
        Return String.Empty
      End If
      Return custodio.NombreCompleto
    End Get
  End Property

  Public ReadOnly Property ActivoCustodioActual As ActivoCustodio
    Get
      If Not ActivoCustodios Is Nothing Then
        For Each _custodio As ActivoCustodio In ActivoCustodios
          If _custodio.ActCus_Activo Then
            Return _custodio
          End If
        Next
      End If
      Return Nothing
    End Get
  End Property

  Public ReadOnly Property Polizas As PolizaList
    Get
      If EsNuevo Then
        Return Nothing
      Else
        Return PolizaList.ObtenerLista(OperadorDatos, Me)
      End If
    End Get
  End Property

  Public ReadOnly Property Valoraciones As ActivoValorList
    Get
      If EsNuevo Then
        Return Nothing
      Else
        Return ActivoValorList.ObtenerLista(Me)
      End If
    End Get
  End Property

  Public ReadOnly Property CostoActual As Decimal
    Get
      If Not Valoraciones Is Nothing Then
        For Each _costo As ActivoValor In Valoraciones
          If _costo.ActVal_Activo And _costo.Pardet_TipoValoracion = Enumerados.enumTipoValoracion.Inicial Then
            Return _costo.ActVal_Costo
          End If
        Next
      End If
      Return Nothing
    End Get
  End Property

  Public ReadOnly Property SalvamentoActual As Decimal
    Get
      If Not Valoraciones Is Nothing Then
        For Each _costo As ActivoValor In Valoraciones
          If _costo.ActVal_Activo And _costo.Pardet_TipoValoracion = Enumerados.enumTipoValoracion.Inicial Then
            Return _costo.ActVal_Salvamento
          End If
        Next
      End If
      Return Nothing
    End Get
  End Property

  Public ReadOnly Property PeriodosDepreciablesActual As Integer
    Get
      If Not Valoraciones Is Nothing Then
        For Each _costo As ActivoValor In Valoraciones
          If _costo.ActVal_Activo And _costo.Pardet_TipoValoracion = Enumerados.enumTipoValoracion.Inicial Then
            Return _costo.ActVal_PeriodosDepreciables
          End If
        Next
      End If
      Return Nothing
    End Get
  End Property

  Public ReadOnly Property FrecuenciaDepreciacionActual As WWTSParametroDet
    Get
      If Not Valoraciones Is Nothing Then
        For Each _costo As ActivoValor In Valoraciones
          If _costo.ActVal_Activo And _costo.Pardet_TipoValoracion = Enumerados.enumTipoValoracion.Inicial Then
            Return _costo.PardetFrecuenciaDepreciacion
          End If
        Next
      End If
      Return Nothing
    End Get
  End Property

  Public Shared Function EstaEnInventario(ByVal _OperadorDatos As OperadorDatos, ByVal _Codigo As Integer, ByVal _PeriodoInventario As WWTSParametroDet) As Boolean
    Dim oResult As Integer = 0
    Dim bReturn As Boolean
    With _OperadorDatos
      .AgregarParametro("@Accion", "FP")
      .AgregarParametro("@Activo_Codigo", _Codigo)
      .AgregarParametro("@Parame_PeriodoInventario", _PeriodoInventario.Parame_Codigo)
      .AgregarParametro("@Pardet_PeriodoInventario", _PeriodoInventario.Pardet_Secuencia)
      .Procedimiento = "proc_Activo"
      bReturn = .Ejecutar(oResult)
      .LimpiarParametros()
    End With
    Return bReturn AndAlso oResult = 1
  End Function

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Activo_Codigo = CType(Fila("Activo_Codigo"), Integer)
    Activo_CodigoBarra = CStr(Fila("Activo_CodigoBarra"))
    If TypeOf Fila("Activo_CodigoBarraCruce") Is DBNull Then
      Activo_CodigoBarraCruce = String.Empty
    Else
      Activo_CodigoBarraCruce = CStr(Fila("Activo_CodigoBarraCruce"))
    End If
    Activo_CodigoAux = CStr(Fila("Activo_CodigoAux"))
    Activo_Serie = CType(Fila("Activo_Serie"), String)
    Parame_ClaseActivo = CType(Fila("Parame_ClaseActivo"), Integer)
    Pardet_ClaseActivo = CType(Fila("Pardet_ClaseActivo"), Integer)
    Activo_Descripcion = CType(Fila("Activo_Descripcion"), String)
    Parame_Marca = CType(Fila("Parame_Marca"), Integer)
    Pardet_Marca = CType(Fila("Pardet_Marca"), Integer)
    Activo_Modelo = CType(Fila("Activo_Modelo"), String)
    Activo_Observacion = CType(Fila("Activo_Observacion"), String)
    Parame_EstadoDepreciacion = CType(Fila("Parame_EstadoDepreciacion"), Integer)
    Pardet_EstadoDepreciacion = CType(Fila("Pardet_EstadoDepreciacion"), Integer)
    Parame_EstadoActivo = CType(Fila("Parame_EstadoActivo"), Integer)
    Pardet_EstadoActivo = CType(Fila("Pardet_EstadoActivo"), Integer)
    Activo_ResponsableMantenimiento = CType(Fila("Activo_ResponsableMantenimiento"), String)
    Activo_FechaIngreso = CDate(Fila("Activo_FechaIngreso"))
    Activo_FechaCompra = CDate(Fila("Activo_FechaCompra"))
    If TypeOf Fila("Activo_FechaUso") Is DBNull Then
      Activo_FechaUso = Nothing
    Else
      Activo_FechaUso = CDate(Fila("Activo_FechaUso"))
    End If
    Parame_CentroCosto = CType(Fila("Parame_CentroCosto"), Integer)
    Pardet_CentroCosto = CType(Fila("Pardet_CentroCosto"), Integer)
    Factura_Codigo = CType(Fila("Factura_Codigo"), Integer)
    If TypeOf Fila("Activo_FechaBaja") Is DBNull OrElse TypeOf Fila("Pardet_TipoBajaActivo") Is DBNull Then
      Activo_FechaBaja = Nothing
      Parame_TipoBajaActivo = 0
      Pardet_TipoBajaActivo = 0
    Else
      Activo_FechaBaja = CType(Fila("Activo_FechaBaja"), String)
      Parame_TipoBajaActivo = CType(Fila("Parame_TipoBajaActivo"), Integer)
      Pardet_TipoBajaActivo = CType(Fila("Pardet_TipoBajaActivo"), Integer)
    End If
    mPardetClaseActivo = Nothing
    mPardetMarca = Nothing
    mPardetEstadoDepreciacion = Nothing
    mPardetCentroCosto = Nothing
    mPardetTipoBajaActivo = Nothing
    mPardetEstadoActivo = Nothing
    mFacturaactivo = Nothing
    mCaracteristicas = Nothing
    mComponentes = Nothing
    mComponentesEli = Nothing
  End Sub

  Public Overridable Function Recargar() As Boolean
    Dim Result As System.Data.DataTable = New System.Data.DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "C")
    OperadorDatos.AgregarParametro("@Activo_Codigo", Activo_Codigo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    Try
      Me.MapearDataRowaObjeto(Result.Rows(0))
      EsNuevo = False
      EsModificado = False
    Catch ex As System.Exception
      bReturn = False
    End Try
    Return bReturn
  End Function

  Public Overridable Function RecargarporCodigoBarra() As Boolean
    Dim Result As System.Data.DataTable = New System.Data.DataTable
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "CB")
    OperadorDatos.AgregarParametro("@Activo_CodigoBarra", Activo_CodigoBarra)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    Try
      Me.MapearDataRowaObjeto(Result.Rows(0))
      EsNuevo = False
      EsModificado = False
    Catch ex As System.Exception
      bReturn = False
    End Try
    Return bReturn
  End Function

  Public Overridable Function Guardar(Optional _Ubicacion As WWTSParametroDet = Nothing, Optional _Custodio As Empleado = Nothing, Optional _Costo As Decimal = 0, Optional _Salvamento As Decimal = 0, Optional _PeriodosDepreciables As Integer = 0, Optional _FrecuenciaDepreciacion As WWTSParametroDet = Nothing) As Boolean
    Dim Result As Integer = 0
    Dim bReturn As Boolean = True
    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If

    Dim _comenzotransaccion As Boolean = False
    If Not OperadorDatos.EstaenTransaccion Then
      OperadorDatos.ComenzarTransaccion()
      _comenzotransaccion = True
    End If

    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Activo_Codigo", Activo_Codigo)
    OperadorDatos.AgregarParametro("@Activo_CodigoBarra", Activo_CodigoBarra)
    If Not String.IsNullOrWhiteSpace(Activo_CodigoBarraCruce) Then
      OperadorDatos.AgregarParametro("@Activo_CodigoBarraCruce", Activo_CodigoBarraCruce)
    End If
    OperadorDatos.AgregarParametro("@Activo_CodigoAux", Activo_CodigoAux)
    OperadorDatos.AgregarParametro("@Activo_Serie", Activo_Serie)
    OperadorDatos.AgregarParametro("@Parame_ClaseActivo", Parame_ClaseActivo)
    OperadorDatos.AgregarParametro("@Pardet_ClaseActivo", Pardet_ClaseActivo)
    OperadorDatos.AgregarParametro("@Activo_Descripcion", Activo_Descripcion)
    OperadorDatos.AgregarParametro("@Parame_Marca", Parame_Marca)
    OperadorDatos.AgregarParametro("@Pardet_Marca", Pardet_Marca)
    OperadorDatos.AgregarParametro("@Activo_Modelo", Activo_Modelo)
    OperadorDatos.AgregarParametro("@Activo_Observacion", Activo_Observacion)
    OperadorDatos.AgregarParametro("@Parame_EstadoDepreciacion", Parame_EstadoDepreciacion)
    OperadorDatos.AgregarParametro("@Pardet_EstadoDepreciacion", Pardet_EstadoDepreciacion)
    OperadorDatos.AgregarParametro("@Parame_EstadoActivo", Parame_EstadoActivo)
    OperadorDatos.AgregarParametro("@Pardet_EstadoActivo", Pardet_EstadoActivo)
    OperadorDatos.AgregarParametro("@Activo_ResponsableMantenimiento", Activo_ResponsableMantenimiento)
    OperadorDatos.AgregarParametro("@Activo_FechaIngreso", Activo_FechaIngreso)
    OperadorDatos.AgregarParametro("@Activo_FechaCompra", Activo_FechaCompra)
    If Not Activo_FechaUso = Nothing Then
      OperadorDatos.AgregarParametro("@Activo_FechaUso", Activo_FechaUso)
    End If
    OperadorDatos.AgregarParametro("@Parame_CentroCosto", Parame_CentroCosto)
    OperadorDatos.AgregarParametro("@Pardet_CentroCosto", Pardet_CentroCosto)
    OperadorDatos.AgregarParametro("@Factura_Codigo", Factura_Codigo)

    If Not Activo_FechaBaja = Nothing Then
      OperadorDatos.AgregarParametro("@Activo_FechaBaja", Activo_FechaBaja)
      OperadorDatos.AgregarParametro("@Parame_TipoBajaActivo", Parame_TipoBajaActivo)
      OperadorDatos.AgregarParametro("@Pardet_TipoBajaActivo", Pardet_TipoBajaActivo)
    End If

    If EsNuevo Then
      OperadorDatos.AgregarParametro("@Parame_Ubicacion", _Ubicacion.Parame_Codigo)
      OperadorDatos.AgregarParametro("@Pardet_Ubicacion", _Ubicacion.Pardet_Secuencia)
      OperadorDatos.AgregarParametro("@Entida_Custodio", _Custodio.Entida_Codigo)

      OperadorDatos.AgregarParametro("@Costo", _Costo)
      OperadorDatos.AgregarParametro("@Salvamento", _Salvamento)
      OperadorDatos.AgregarParametro("@PeriodosDepreciables", _PeriodosDepreciables)
      OperadorDatos.AgregarParametro("@Parame_FrecuenciaDepreciacion", _FrecuenciaDepreciacion.Parame_Codigo)
      OperadorDatos.AgregarParametro("@Pardet_FrecuenciaDepreciacion", _FrecuenciaDepreciacion.Pardet_Secuencia)
    End If
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        Activo_Codigo = Result
      End If

      For Each _caract As ActivoCaracteristica In Caracteristicas
        _caract.Activo = Me
        If Not _caract.Guardar Then
          bReturn = False
          Exit For
        End If
      Next

      For Each _compte As ActivoComponente In ComponentesEli
        _compte.Activo = Me
        If Not _compte.EsNuevo Then
          If Not _compte.Eliminar Then
            bReturn = False
            Exit For
          End If
        End If
      Next

      For Each _compte As ActivoComponente In Componentes
        _compte.Activo = Me
        If Not _compte.Guardar Then
          bReturn = False
          Exit For
        End If
      Next

      If bReturn AndAlso mCambio_Imagen Then
        Guardar_Imagen()
      End If
    End If

    If _comenzotransaccion Then
      If bReturn Then
        OperadorDatos.TerminarTransaccion()
        AceptarCambios()
      Else
        OperadorDatos.CancelarTransaccion()
      End If
    End If
    Return bReturn
  End Function

  Public Overridable Function Guardar_Imagen() As Boolean
    If EsNuevo Then
      Return False
    End If
    If Not mCambio_Imagen Then
      Return True
    End If
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "ps")
    OperadorDatos.AgregarParametro("@Activo_Codigo", Activo_Codigo)
    OperadorDatos.AgregarParametroImagen("@Activo_Imagen", mArchivoImagen)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar()
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      mActivo_Imagen = Nothing
      mCambio_Imagen = False
    End If
    Return bReturn
  End Function

  Public Overridable Sub AceptarCambios()
    EsNuevo = False
    EsModificado = False
    For Each _caract As ActivoCaracteristica In Caracteristicas
      _caract.AceptarCambios()
    Next
    mComponentesEli = Nothing
    For Each _compte As ActivoComponente In Componentes
      _compte.AceptarCambios()
    Next
  End Sub

  Public Overridable Function Eliminar() As Boolean
    Dim bReturn As Boolean = True
    OperadorDatos.AgregarParametro("@accion", "E")
    OperadorDatos.AgregarParametro("@Activo_Codigo", Activo_Codigo)
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar
    OperadorDatos.LimpiarParametros()
    Return bReturn
  End Function

  Public Function Clone() As Object Implements System.ICloneable.Clone
    Dim _activo As New Activo(OperadorDatos, Activo_Codigo)
    Dim obj = _activo.Caracteristicas
    _activo.EsNuevo = True
    _activo.Activo_Codigo = 0
    _activo.Activo_CodigoBarra = ""
    _activo.Activo_CodigoAux = ""
    _activo.Activo_Serie = ""
    Return _activo
  End Function
End Class
#End Region

#Region "ActivoList"
Public Class ActivoList
  Inherits System.ComponentModel.BindingList(Of Activo)

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, Optional ByVal _filtro As String = "") As ActivoList
    Dim oResult As New ActivoList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_Activo"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Activo(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function

  'Tipo Rango Fechas
  '0 Compra entre
  '1 Ingreso entre
  '2 Uso entre
  '3 Baja entre
  '4 Sin fecha de uso
  '5 Sin fecha de baja

  Public Shared Function ObtenerLista(ByVal _OperadorDatos As OperadorDatos, ByVal _CodigoBarras As String, ByVal _CodigoAux As String, ByVal _Serie As String, ByVal _Descripcion As String, ByVal _Clase As WWTSParametroDet, ByVal _Marca As WWTSParametroDet, ByVal _Modelo As String, ByVal _Proveedor As Proveedor, ByVal _Factura As FacturaActivo, ByVal _Custodio As Empleado, ByVal _Ubicacion As WWTSParametroDet, ByVal _Estadoinv As WWTSParametroDet, ByVal _SoloActivos As Boolean, ByVal _RangoFecha As Integer, ByVal _Desde As Date, ByVal _Hasta As Date, ByVal _TipoBaja As WWTSParametroDet) As ActivoList
    Dim oResult As New ActivoList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@Activo_CodigoBarra", _CodigoBarras)
      .AgregarParametro("@Activo_CodigoAux", _CodigoAux)
      .AgregarParametro("@Activo_Serie", _Serie)
      .AgregarParametro("@Activo_Descripcion", _Descripcion)
      If _Clase IsNot Nothing Then
        .AgregarParametro("@Parame_ClaseActivo", _Clase.Parame_Codigo)
        .AgregarParametro("@Pardet_ClaseActivo", _Clase.Pardet_Secuencia)
      End If
      If _Marca IsNot Nothing Then
        .AgregarParametro("@Pardet_Marca", _Marca.Pardet_Secuencia)
      End If
      .AgregarParametro("@Activo_Modelo", _Modelo)
      If _Proveedor IsNot Nothing Then
        .AgregarParametro("@Entida_Proveedor", _Proveedor.Entida_Codigo)
        If _Factura IsNot Nothing Then
          .AgregarParametro("@Factura_Codigo", _Factura.Factura_Codigo)
        End If
      End If
      If _Custodio IsNot Nothing Then
        .AgregarParametro("@Entida_Custodio", _Custodio.Entida_Codigo)
      End If
      If _Ubicacion IsNot Nothing Then
        .AgregarParametro("@Parame_Ubicacion", _Ubicacion.Parame_Codigo)
        .AgregarParametro("@Pardet_Ubicacion", _Ubicacion.Pardet_Secuencia)
      End If
      If _Estadoinv IsNot Nothing Then
        .AgregarParametro("@Parame_EstadoInventario", _Estadoinv.Parame_Codigo)
        .AgregarParametro("@Pardet_EstadoInventario", _Estadoinv.Pardet_Secuencia)
      End If
      If _SoloActivos Then
        .AgregarParametro("@SoloActivos", _SoloActivos)
      End If
      .AgregarParametro("@RangoFecha", _RangoFecha)
      If _RangoFecha >= 0 Then
        .AgregarParametro("@FechaDesde", _Desde.Date)
        .AgregarParametro("@FechaHasta", _Hasta.Date)
      End If
      If _TipoBaja IsNot Nothing Then
        .AgregarParametro("@Parame_TipoBajaActivo", _TipoBaja.Parame_Codigo)
        .AgregarParametro("@Pardet_TipoBajaActivo", _TipoBaja.Pardet_Secuencia)
      End If
      .Procedimiento = "proc_Activo"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New Activo(_OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
  'Public Shared Function ObtenerLista(_TransaccionActivo As TransaccionActivo, Optional ByVal _filtro As String = "") As ActivoList
  '  Dim oResult As New ActivoList
  '  Dim bReturn As Boolean
  '  Dim ds As DataTable = Nothing
  '  With _TransaccionActivo.OperadorDatos
  '    .AgregarParametro("@Accion", "FT")
  '    .AgregarParametro("@Transa_Codigo", _TransaccionActivo.Transa_Codigo)

  '    .AgregarParametro("@filtro", _filtro)
  '    .Procedimiento = "proc_Activo"
  '    bReturn = .Ejecutar(ds)
  '    .LimpiarParametros()
  '  End With
  '  If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
  '    For Each _dr As DataRow In ds.Rows
  '      Dim _fila As New Activo(_TransaccionActivo.OperadorDatos, False)
  '      _fila.MapearDataRowaObjeto(_dr)
  '      oResult.Add(_fila)
  '    Next
  '  End If
  '  Return oResult
  'End Function

End Class
#End Region
