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


#Region "Depreciacion"
Partial Public Class Depreciacion
  Inherits _Database

  Private mParame_FrecuenciaDepreciacion As Integer = 0

  Private mPardet_FrecuenciaDepreciacion As Integer = 0

  Private mParame_TipoDepreciacion As Integer = 0

  Private mPardet_TipoDepreciacion As Integer = 0

  Private mDeprec_Codigo As String = ""

  Private mDeprec_Observacion As String = ""

  Private mDeprec_esProyeccion As Boolean = False

  Public Sub New()
    MyBase.New()
  End Sub

  <XmlAttribute()> _
  Public Overridable Property Parame_FrecuenciaDepreciacion() As Integer
    Get
      Return Me.mParame_FrecuenciaDepreciacion
    End Get
    Set(value As Integer)
      Me.mParame_FrecuenciaDepreciacion = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_FrecuenciaDepreciacion() As Integer
    Get
      Return Me.mPardet_FrecuenciaDepreciacion
    End Get
    Set(value As Integer)
      Me.mPardet_FrecuenciaDepreciacion = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_TipoDepreciacion() As Integer
    Get
      Return Me.mParame_TipoDepreciacion
    End Get
    Set(value As Integer)
      Me.mParame_TipoDepreciacion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_TipoDepreciacion() As Integer
    Get
      Return Me.mPardet_TipoDepreciacion
    End Get
    Set(value As Integer)
      Me.mPardet_TipoDepreciacion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Deprec_Codigo() As String
    Get
      Return Me.mDeprec_Codigo
    End Get
    Set(value As String)
      Me.mDeprec_Codigo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Deprec_Observacion() As String
    Get
      Return Me.mDeprec_Observacion
    End Get
    Set(value As String)
      Me.mDeprec_Observacion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Deprec_esProyeccion As Boolean
    Get
      Return Me.mDeprec_esProyeccion
    End Get
    Set(value As Boolean)
      Me.mDeprec_esProyeccion = value
      EsModificado = True
    End Set
  End Property
End Class
#End Region
