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

Imports Infoware.Reglas
Imports System
Imports System.Xml
Imports System.Xml.Serialization


#Region "Activo"
Partial Public Class Activo
  Inherits _Database

  Private mActivo_Codigo As Integer = 0

  Private mActivo_CodigoBarra As String = ""

  Private mActivo_CodigoBarraCruce As String = ""

  Private mActivo_CodigoAux As String = ""

  Private mActivo_Serie As String = ""

  Private mParame_ClaseActivo As Integer = 0

  Private mPardet_ClaseActivo As Integer = 0

  Private mActivo_Descripcion As String = ""

  Private mParame_Marca As Integer = 0

  Private mPardet_Marca As Integer = 0

  Private mActivo_Modelo As String = ""

  Private mActivo_Observacion As String = ""

  Private mParame_EstadoDepreciacion As Integer = 0

  Private mPardet_EstadoDepreciacion As Integer = 0

  Private mParame_EstadoActivo As Integer = 0

  Private mPardet_EstadoActivo As Integer = 0

  Private mActivo_ResponsableMantenimiento As String = ""

  Private mActivo_FechaIngreso As Date = Now.Date

  Private mActivo_FechaCompra As Date = Now.Date

  Private mActivo_FechaUso As Date = Nothing

  Private mParame_CentroCosto As Integer = 0

  Private mPardet_CentroCosto As Integer = 0

  Private mFactura_Codigo As Integer = 0

  Private mActivo_FechaBaja As Date = Nothing

  Private mParame_TipoBajaActivo As Integer = 0

  Private mPardet_TipoBajaActivo As Integer = 0

  Public Sub New()
    MyBase.New()
  End Sub

  <XmlAttribute()> _
  Public Overridable Property Activo_Codigo() As Integer
    Get
      Return Me.mActivo_Codigo
    End Get
    Set(value As Integer)
      Me.mActivo_Codigo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Activo_CodigoBarra() As String
    Get
      Return Me.mActivo_CodigoBarra
    End Get
    Set(value As String)
      Me.mActivo_CodigoBarra = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Activo_CodigoBarraCruce() As String
    Get
      Return Me.mActivo_CodigoBarraCruce
    End Get
    Set(value As String)
      Me.mActivo_CodigoBarraCruce = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Activo_CodigoAux() As String
    Get
      Return Me.mActivo_CodigoAux
    End Get
    Set(value As String)
      Me.mActivo_CodigoAux = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Activo_Serie() As String
    Get
      Return Me.mActivo_Serie
    End Get
    Set(value As String)
      Me.mActivo_Serie = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_ClaseActivo() As Integer
    Get
      Return Me.mParame_ClaseActivo
    End Get
    Set(value As Integer)
      Me.mParame_ClaseActivo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_ClaseActivo() As Integer
    Get
      Return Me.mPardet_ClaseActivo
    End Get
    Set(value As Integer)
      Me.mPardet_ClaseActivo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Activo_Descripcion() As String
    Get
      Return Me.mActivo_Descripcion
    End Get
    Set(value As String)
      Me.mActivo_Descripcion = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_Marca() As Integer
    Get
      Return Me.mParame_Marca
    End Get
    Set(value As Integer)
      Me.mParame_Marca = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_Marca() As Integer
    Get
      Return Me.mPardet_Marca
    End Get
    Set(value As Integer)
      Me.mPardet_Marca = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Activo_Modelo() As String
    Get
      Return Me.mActivo_Modelo
    End Get
    Set(value As String)
      Me.mActivo_Modelo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Activo_Observacion() As String
    Get
      Return Me.mActivo_Observacion
    End Get
    Set(value As String)
      Me.mActivo_Observacion = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_EstadoDepreciacion() As Integer
    Get
      Return Me.mParame_EstadoDepreciacion
    End Get
    Set(value As Integer)
      Me.mParame_EstadoDepreciacion = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_EstadoDepreciacion() As Integer
    Get
      Return Me.mPardet_EstadoDepreciacion
    End Get
    Set(value As Integer)
      Me.mPardet_EstadoDepreciacion = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_EstadoActivo() As Integer
    Get
      Return Me.mParame_EstadoActivo
    End Get
    Set(value As Integer)
      Me.mParame_EstadoActivo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_EstadoActivo() As Integer
    Get
      Return Me.mPardet_EstadoActivo
    End Get
    Set(value As Integer)
      Me.mPardet_EstadoActivo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Activo_ResponsableMantenimiento() As String
    Get
      Return Me.mActivo_ResponsableMantenimiento
    End Get
    Set(value As String)
      Me.mActivo_ResponsableMantenimiento = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Activo_FechaIngreso() As Date
    Get
      Return Me.mActivo_FechaIngreso
    End Get
    Set(value As Date)
      Me.mActivo_FechaIngreso = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Activo_FechaCompra() As Date
    Get
      Return Me.mActivo_FechaCompra
    End Get
    Set(value As Date)
      Me.mActivo_FechaCompra = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Activo_FechaUso() As Date
    Get
      Return Me.mActivo_FechaUso
    End Get
    Set(value As Date)
      Me.mActivo_FechaUso = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_CentroCosto() As Integer
    Get
      Return Me.mParame_CentroCosto
    End Get
    Set(value As Integer)
      Me.mParame_CentroCosto = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_CentroCosto() As Integer
    Get
      Return Me.mPardet_CentroCosto
    End Get
    Set(value As Integer)
      Me.mPardet_CentroCosto = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Factura_Codigo() As Integer
    Get
      Return Me.mFactura_Codigo
    End Get
    Set(value As Integer)
      Me.mFactura_Codigo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Activo_FechaBaja() As Date
    Get
      Return Me.mActivo_FechaBaja
    End Get
    Set(value As Date)
      Me.mActivo_FechaBaja = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_TipoBajaActivo() As Integer
    Get
      Return Me.mParame_TipoBajaActivo
    End Get
    Set(value As Integer)
      Me.mParame_TipoBajaActivo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_TipoBajaActivo() As Integer
    Get
      Return Me.mPardet_TipoBajaActivo
    End Get
    Set(value As Integer)
      Me.mPardet_TipoBajaActivo = Value
      EsModificado = True
    End Set
  End Property
End Class
#End Region
