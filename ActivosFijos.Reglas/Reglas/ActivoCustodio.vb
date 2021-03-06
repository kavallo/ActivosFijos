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


#Region "ActivoCustodio"
Public Class ActivoCustodio
    
    Const _Procedimiento As String = "proc_ActivoCustodio"
    
    Private mActivo As Activo = Nothing
    
    Private mEmpleado As Empleado = Nothing

  Private mTransaccionActivo As TransaccionActivo = Nothing

  Private mPardetAprobadoNuevoCustodio As WWTSParametroDet = Nothing

    Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
        MyBase.New
        OperadorDatos = _OperadorDatos
        EsNuevo = _EsNuevo
    End Sub
    
    Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _Activo_Codigo As Integer, ByVal _ActCus_Secuencia As Integer)
        Me.New(_OperadorDatos, false)
        Activo_Codigo = _Activo_Codigo
        ActCus_Secuencia = _ActCus_Secuencia
        If Me.Recargar Then
        Else
            Throw New System.Exception("No se puede cargar objeto ActivoCustodio")
        End If
    End Sub
    
  'Activo
  Public Overridable Property Activo() As Activo
    Get
      If mActivo Is Nothing AndAlso Activo_Codigo > 0 Then
        mActivo = New Activo(OperadorDatos, Activo_Codigo)
      End If
      Return Me.mActivo
    End Get
    Set(value As Activo)
      Me.mActivo = value
      Activo_Codigo = value.Activo_Codigo
    End Set
  End Property

  'Empleado
  Public Overridable Property Empleado() As Empleado
    Get
      If mEmpleado Is Nothing AndAlso Emplea_Custodio > 0 Then
        mEmpleado = New Empleado(OperadorDatos, Emplea_Custodio)
      End If
      Return Me.mEmpleado
    End Get
    Set(value As Empleado)
      Me.mEmpleado = Value
      Emplea_Custodio = Value.Entida_Codigo
    End Set
  End Property

  'TransaccionActivo
  Public Overridable Property TransaccionActivo() As TransaccionActivo
    Get
      If mTransaccionActivo Is Nothing AndAlso mTransa_Codigo > 0 Then
        mTransaccionActivo = New TransaccionActivo(OperadorDatos, mTransa_Codigo)
      End If
      Return Me.mTransaccionActivo
    End Get
    Set(value As TransaccionActivo)
      Me.mTransaccionActivo = value
      If value Is Nothing Then
        mTransa_Codigo = 0
      Else
        mTransa_Codigo = value.Transa_Codigo
      End If
    End Set
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Estado", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Logico, 45, True)> _
  Public ReadOnly Property esActivo() As Boolean
    Get
      Return ActCus_Activo
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Activo", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 250, True)> _
  Public ReadOnly Property ActivoString() As String
    Get
      If Activo Is Nothing Then
        Return String.Empty
      Else
        Return Activo.Descripcion
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Custodio", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 150, True)> _
  Public ReadOnly Property CustodioString() As String
    Get
      If Empleado Is Nothing Then
        Return String.Empty
      Else
        Return Empleado.NombreCompleto
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Desde", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 100, True)> _
  Public ReadOnly Property DesdeString() As String
    Get
      Return ActCus_FechaDesde.ToShortDateString
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Hasta", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 100, True)> _
  Public ReadOnly Property HastaString() As String
    Get
      If ActCus_FechaHasta = Nothing Then
        Return String.Empty
      Else
        Return ActCus_FechaHasta.ToShortDateString
      End If
    End Get
  End Property

  <Infoware.Reportes.CampoReporteAtributo("Aprobado", Infoware.Reportes.CampoReporteAtributo.EnumTipoDato.Texto, 120, True)> _
  Public ReadOnly Property AprobadoNuevoCustodioString() As String
    Get
      If PardetAprobadoNuevoCustodio Is Nothing Then
        Return String.Empty
      Else
        Return PardetAprobadoNuevoCustodio.Descripcion
      End If
    End Get
  End Property

  'Parametrodet
  Public Overridable Overloads Property PardetAprobadoNuevoCustodio As WWTSParametroDet
    Get
      If mPardetAprobadoNuevoCustodio Is Nothing AndAlso Pardet_AprobadoNuevoCustodio > 0 Then
        mPardetAprobadoNuevoCustodio = New WWTSParametroDet(OperadorDatos, Parame_AprobadoNuevoCustodio, Pardet_AprobadoNuevoCustodio)
      End If
      Return Me.mPardetAprobadoNuevoCustodio
    End Get
    Set(value As WWTSParametroDet)
      Me.mPardetAprobadoNuevoCustodio = value
      Parame_AprobadoNuevoCustodio = value.Parame_Codigo
      Pardet_AprobadoNuevoCustodio = value.Pardet_Secuencia
    End Set
  End Property

  Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
    Activo_Codigo = CType(Fila("Activo_Codigo"), Integer)
    ActCus_Secuencia = CType(Fila("ActCus_Secuencia"), Integer)
    ActCus_Activo = CType(Fila("ActCus_Activo"), Boolean)
    Parame_AprobadoNuevoCustodio = CType(Fila("Parame_AprobadoNuevoCustodio"), Integer)
    Pardet_AprobadoNuevoCustodio = CType(Fila("Pardet_AprobadoNuevoCustodio"), Integer)
    ActCus_FechaDesde = CDate(Fila("ActCus_FechaDesde"))
    If TypeOf Fila("ActCus_FechaHasta") Is DBNull Then
      ActCus_FechaHasta = Nothing
    Else
      ActCus_FechaHasta = CDate(Fila("ActCus_FechaHasta"))
    End If
    If TypeOf Fila("Transa_Codigo") Is DBNull Then
      Transa_Codigo = 0
    Else
      Transa_Codigo = CInt(Fila("Transa_Codigo"))
    End If
    Emplea_Custodio = CType(Fila("Emplea_Custodio"), Integer)
    ActCus_Observacion = CType(Fila("ActCus_Observacion"), String)
    mActivo = Nothing
    mEmpleado = Nothing
    mPardetAprobadoNuevoCustodio = Nothing
  End Sub
    
    Public Overridable Function Recargar() As Boolean
        Dim Result As System.Data.DataTable = New System.Data.DataTable
        Dim bReturn As Boolean = true
        OperadorDatos.AgregarParametro("@accion", "C")
        OperadorDatos.AgregarParametro("@Activo_Codigo", Activo_Codigo)
        OperadorDatos.AgregarParametro("@ActCus_Secuencia", ActCus_Secuencia)
        OperadorDatos.Procedimiento = _Procedimiento
        bReturn = OperadorDatos.Ejecutar(Result)
        OperadorDatos.LimpiarParametros
        Try 
      Me.MapearDataRowaObjeto(Result.Rows(0))
            EsNuevo = false
            EsModificado = false
        Catch ex As System.Exception
            bReturn = false
        End Try
        Return bReturn
    End Function
    
  Public Overridable Function Guardar() As Boolean
    Dim Result As Integer = 0
    Dim bReturn As Boolean = True
    Dim sAccion As String = "M"
    If EsNuevo Then
      sAccion = "I"
    End If
    OperadorDatos.AgregarParametro("@accion", sAccion)
    OperadorDatos.AgregarParametro("@Activo_Codigo", Activo_Codigo)
    OperadorDatos.AgregarParametro("@ActCus_Secuencia", ActCus_Secuencia)
    OperadorDatos.AgregarParametro("@ActCus_Activo", ActCus_Activo)
    OperadorDatos.AgregarParametro("@Parame_AprobadoNuevoCustodio", Parame_AprobadoNuevoCustodio)
    OperadorDatos.AgregarParametro("@Pardet_AprobadoNuevoCustodio", Pardet_AprobadoNuevoCustodio)
    OperadorDatos.AgregarParametro("@ActCus_FechaDesde", ActCus_FechaDesde)
    If Not ActCus_FechaHasta = Nothing Then
      OperadorDatos.AgregarParametro("@ActCus_FechaHasta", ActCus_FechaHasta)
    End If
    OperadorDatos.AgregarParametro("@Emplea_Custodio", Emplea_Custodio)
    OperadorDatos.AgregarParametro("@ActCus_Observacion", ActCus_Observacion)
    If Transa_Codigo > 0 Then
      OperadorDatos.AgregarParametro("@Transa_Codigo", Transa_Codigo)
    End If
    OperadorDatos.Procedimiento = _Procedimiento
    bReturn = OperadorDatos.Ejecutar(Result)
    OperadorDatos.LimpiarParametros()
    If bReturn Then
      If EsNuevo Then
        ActCus_Secuencia = Result
      End If

      If Not OperadorDatos.EstaenTransaccion Then
        Me.AceptarCambios()
      End If
    End If
    Return bReturn
  End Function
    
    Public Overridable Sub AceptarCambios()
        EsNuevo = false
        EsModificado = false
    End Sub
    
    Public Overridable Function Eliminar() As Boolean
        Dim bReturn As Boolean = true
        OperadorDatos.AgregarParametro("@accion", "E")
        OperadorDatos.AgregarParametro("@Activo_Codigo", Activo_Codigo)
        OperadorDatos.AgregarParametro("@ActCus_Secuencia", ActCus_Secuencia)
        OperadorDatos.Procedimiento = _Procedimiento
        bReturn = OperadorDatos.Ejecutar
        OperadorDatos.LimpiarParametros
        Return bReturn
    End Function
End Class
#End Region

#Region "ActivoCustodioList"
Public Class ActivoCustodioList
  Inherits System.ComponentModel.BindingList(Of ActivoCustodio)

  Public Shared Function ObtenerLista(ByVal _Activo As Activo, Optional ByVal _filtro As String = "") As ActivoCustodioList
    Dim oResult As New ActivoCustodioList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Activo.OperadorDatos
      .AgregarParametro("@Accion", "F")
      .AgregarParametro("@Activo_Codigo", _Activo.Activo_Codigo)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_ActivoCustodio"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New ActivoCustodio(_Activo.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
  Public Shared Function ObtenerLista(ByVal _TransaccionActivo As TransaccionActivo, Optional ByVal _filtro As String = "") As ActivoCustodioList
    Dim oResult As New ActivoCustodioList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _TransaccionActivo.OperadorDatos
      .AgregarParametro("@Accion", "FT")
      .AgregarParametro("@Transa_Codigo", _TransaccionActivo.Transa_Codigo)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_ActivoCustodio"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New ActivoCustodio(_TransaccionActivo.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
  Public Shared Function ObtenerActivos(ByVal _Activo As Activo, Optional ByVal _filtro As String = "") As ActivoCustodioList
    Dim oResult As New ActivoCustodioList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Activo.OperadorDatos
      .AgregarParametro("@Accion", "Fa")
      .AgregarParametro("@Activo_Codigo", _Activo.Activo_Codigo)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_ActivoCustodio"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New ActivoCustodio(_Activo.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
  Public Shared Function ObtenerPendientesAprobacion(ByVal _Custodio As Empleado, Optional ByVal _filtro As String = "") As ActivoCustodioList
    Dim oResult As New ActivoCustodioList
    Dim bReturn As Boolean
    Dim ds As DataTable = Nothing
    With _Custodio.OperadorDatos
      .AgregarParametro("@Accion", "FP")
      .AgregarParametro("@Emplea_Custodio", _Custodio.Entida_Codigo)
      .AgregarParametro("@filtro", _filtro)
      .Procedimiento = "proc_ActivoCustodio"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      For Each _dr As DataRow In ds.Rows
        Dim _fila As New ActivoCustodio(_Custodio.OperadorDatos, False)
        _fila.MapearDataRowaObjeto(_dr)
        oResult.Add(_fila)
      Next
    End If
    Return oResult
  End Function
End Class
#End Region
