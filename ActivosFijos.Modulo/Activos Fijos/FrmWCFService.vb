Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas
Imports System.ServiceModel.Description
Imports System.ServiceModel

Public Class FrmWCFService
  Private host As ActivosFijos.Service.ServiceHoster

  Private Sub btniniciar_Click(sender As System.Object, e As System.EventArgs) Handles btniniciar.Click
    Dim _namespace As String = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).HostName
    Dim baseAddress As Uri = New Uri(String.Format("http://{0}:{1}/activosfijos", System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).HostName, Me.txtPuerto.Value))

    Try
      host = New ActivosFijos.Service.ServiceHoster(_namespace, baseAddress)
      host.AddService(Of IService)(GetType(Reglas.Service))

      Me.btniniciar.Enabled = False
      Me.linkservice.Text = baseAddress.AbsoluteUri
      Me.FlowLayoutPanel1.Visible = True
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      Me.btniniciar.Enabled = True
    End Try
  End Sub

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoTransaccionActivos)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmMantenimientoTransaccionActivo_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoTransaccionActivos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private mUsuario As WWTSUsuario = Nothing

  Private Sub FrmMantenimientoTransaccionActivo_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar

  End Sub
#End Region

  Protected Overrides Sub Finalize()
    Try
      host.ShutDown()
    Catch ex As Exception

    End Try
    MyBase.Finalize()
  End Sub

  Private Sub linkservice_Click(sender As Object, e As System.EventArgs) Handles linkservice.Click
    System.Diagnostics.Process.Start(Me.linkservice.Text)
  End Sub
End Class