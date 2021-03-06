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


#Region "asientocontable"
Public Class asientocontable
    
    Const _Procedimiento As String = "proc_asientocontable"
    
    Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _EsNuevo As Boolean)
        MyBase.New
        OperadorDatos = _OperadorDatos
        EsNuevo = _EsNuevo
    End Sub
    
    Public Sub New(ByVal _OperadorDatos As OperadorDatos, ByVal _fecha_proceso As String, ByVal _cabecera As Integer, ByVal _secuencia As Integer)
        Me.New(_OperadorDatos, false)
        fecha_proceso = _fecha_proceso
        cabecera = _cabecera
        secuencia = _secuencia
        If Me.Recargar Then
        Else
            Throw New System.Exception("No se puede cargar objeto asientocontable")
        End If
    End Sub
    
    Public Overridable Sub MapearDataRowaObjeto(ByVal Fila As DataRow)
        fecha_proceso = CType(Fila("fecha_proceso"),String)
        estado = CType(Fila("estado"),Boolean)
        cabecera = CType(Fila("cabecera"),Integer)
        secuencia = CType(Fila("secuencia"),Integer)
        sucursal = CType(Fila("sucursal"),Integer)
        rubro_contable = CType(Fila("rubro_contable"),String)
        detalle_asiento = CType(Fila("detalle_asiento"),String)
        distribucion = CType(Fila("distribucion"),String)
        fecha_valor = CType(Fila("fecha_valor"),String)
        fuente_fondo = CType(Fila("fuente_fondo"),Integer)
        centro_costo = CType(Fila("centro_costo"),Integer)
        descripcion = CType(Fila("descripcion"),String)
        signo = CType(Fila("signo"),String)
        importe = CType(Fila("importe"),Double)
    End Sub
    
    Public Overridable Function Recargar() As Boolean
        Dim Result As System.Data.DataTable = New System.Data.DataTable
        Dim bReturn As Boolean = true
        OperadorDatos.AgregarParametro("@accion", "C")
        OperadorDatos.AgregarParametro("@fecha_proceso", fecha_proceso)
        OperadorDatos.AgregarParametro("@cabecera", cabecera)
        OperadorDatos.AgregarParametro("@secuencia", secuencia)
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
        Dim bReturn As Boolean = true
        Dim sAccion As String = "M"
        If esNuevo Then
            sAccion = "I"
        End If
        OperadorDatos.AgregarParametro("@accion", sAccion)
        OperadorDatos.AgregarParametro("@fecha_proceso", fecha_proceso)
        OperadorDatos.AgregarParametro("@estado", estado)
        OperadorDatos.AgregarParametro("@cabecera", cabecera)
        OperadorDatos.AgregarParametro("@secuencia", secuencia)
        OperadorDatos.AgregarParametro("@sucursal", sucursal)
        OperadorDatos.AgregarParametro("@rubro_contable", rubro_contable)
        OperadorDatos.AgregarParametro("@detalle_asiento", detalle_asiento)
        OperadorDatos.AgregarParametro("@distribucion", distribucion)
        OperadorDatos.AgregarParametro("@fecha_valor", fecha_valor)
        OperadorDatos.AgregarParametro("@fuente_fondo", fuente_fondo)
        OperadorDatos.AgregarParametro("@centro_costo", centro_costo)
        OperadorDatos.AgregarParametro("@descripcion", descripcion)
        OperadorDatos.AgregarParametro("@signo", signo)
        OperadorDatos.AgregarParametro("@importe", importe)
        OperadorDatos.Procedimiento = _Procedimiento
        bReturn = OperadorDatos.Ejecutar(Result)
        OperadorDatos.LimpiarParametros
        If bReturn Then
            If OperadorDatos.EstaenTransaccion Then
            Else
                Me.AceptarCambios
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
        OperadorDatos.AgregarParametro("@fecha_proceso", fecha_proceso)
        OperadorDatos.AgregarParametro("@cabecera", cabecera)
        OperadorDatos.AgregarParametro("@secuencia", secuencia)
        OperadorDatos.Procedimiento = _Procedimiento
        bReturn = OperadorDatos.Ejecutar
        OperadorDatos.LimpiarParametros
        Return bReturn
    End Function
End Class
#End Region

#Region "asientocontableList"
Public Class asientocontableList
    Inherits System.ComponentModel.BindingList(Of )
End Class
#End Region
