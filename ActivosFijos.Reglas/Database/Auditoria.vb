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


#Region "Auditoria"
Partial Public Class Auditoria
    Inherits _Database
    
    Private mUsuari_Codigo As String = ""
    
    Private mParame_Opciones As Integer = 0
    
    Private mPardet_Opciones As Integer = 0
    
    Private mAudito_Secuencia As Integer = 0
    
    Private mAudito_Descripcion As String = ""
    
    Private mAudito_FechaHora As Date = Nothing
    
    Private mParame_TipoAccion As Integer = 0
    
    Private mPardet_TipoAccion As Integer = 0
    
    Public Sub New()
        MyBase.New
    End Sub
    
    <XmlAttribute()>  _
    Public Overridable Property Usuari_Codigo() As String
        Get
            Return Me.mUsuari_Codigo
        End Get
        Set
            Me.mUsuari_Codigo = value
            EsModificado = true
        End Set
    End Property
    
    <XmlAttribute()>  _
    Public Overridable Property Parame_Opciones() As Integer
        Get
            Return Me.mParame_Opciones
        End Get
        Set
            Me.mParame_Opciones = value
            EsModificado = true
        End Set
    End Property
    
    <XmlAttribute()>  _
    Public Overridable Property Pardet_Opciones() As Integer
        Get
            Return Me.mPardet_Opciones
        End Get
        Set
            Me.mPardet_Opciones = value
            EsModificado = true
        End Set
    End Property
    
    <XmlAttribute()>  _
    Public Overridable Property Audito_Secuencia() As Integer
        Get
            Return Me.mAudito_Secuencia
        End Get
        Set
            Me.mAudito_Secuencia = value
            EsModificado = true
        End Set
    End Property
    
    <XmlAttribute()>  _
    Public Overridable Property Audito_Descripcion() As String
        Get
            Return Me.mAudito_Descripcion
        End Get
        Set
            Me.mAudito_Descripcion = value
            EsModificado = true
        End Set
    End Property
    
    <XmlAttribute()>  _
    Public Overridable Property Audito_FechaHora() As Date
        Get
            Return Me.mAudito_FechaHora
        End Get
        Set
            Me.mAudito_FechaHora = value
            EsModificado = true
        End Set
    End Property
    
    <XmlAttribute()>  _
    Public Overridable Property Parame_TipoAccion() As Integer
        Get
            Return Me.mParame_TipoAccion
        End Get
        Set
            Me.mParame_TipoAccion = value
            EsModificado = true
        End Set
    End Property
    
    <XmlAttribute()>  _
    Public Overridable Property Pardet_TipoAccion() As Integer
        Get
            Return Me.mPardet_TipoAccion
        End Get
        Set
            Me.mPardet_TipoAccion = value
            EsModificado = true
        End Set
    End Property
End Class
#End Region
