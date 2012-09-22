Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class FrmListaPolizas
  Private mPoliza As Poliza = Nothing
  Public Property Poliza() As Poliza
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As Poliza)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _Poliza As Poliza In Me.ListBindingSource.DataSource
          If _Poliza.Poliza_Codigo = value.Poliza_Codigo Then
            ListBindingSource.Position = t
          End If
          t += 1
        Next
      End If
    End Set
  End Property

  Public Property Filtro() As String
    Get
      Return MyBase.combobuscar.Text
    End Get
    Set(ByVal value As String)
      MyBase.combobuscar.Text = value
      MyBase.Hacer_busqueda()
    End Set
  End Property

#Region "Eventos"
  Private Sub FrmListaPolizas_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaPolizas_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaPolizas_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim f As New FrmMantenimientoPoliza(Sistema, Restriccion)
    f.Polizas = ListBindingSource
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
  End Sub

  Private Sub FrmListaPolizas_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaPolizas_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaPolizas_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mPolizas Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mPoliza As Poliza
    mPoliza = ListBindingSource.Current
    If mPoliza.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar Poliza" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  'Private Sub FrmListaPolizas_Exportar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Exportar
  '  'exportar
  '  Try
  '    Dim excelApp As New Excel.Application
  '    Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
  '    Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
  '    excelApp.Visible = False
  '    With excelWorksheet
  '      .Range("A1").Value = "Nombre de Poliza"
  '      .Columns("A:A").ColumnWidth = 80
  '      .Columns("A:A").NumberFormat = "@"

  '      .Range("B1").Value = "Direcciones"
  '      .Columns("B:B").ColumnWidth = 80
  '      .Columns("B:B").NumberFormat = "@"

  '      .Range("C1").Value = "Teléfonos"
  '      .Columns("C:C").ColumnWidth = 80
  '      .Columns("C:C").NumberFormat = "@"

  '      .Range("D1").Value = "Emails"
  '      .Columns("D:D").ColumnWidth = 80
  '      .Columns("D:D").NumberFormat = "@"

  '      .Range("E1").Value = "Identificaciones"
  '      .Columns("E:E").ColumnWidth = 80
  '      .Columns("E:E").NumberFormat = "@"

  '      Dim t As Integer = 0
  '      For Each _Poliza As Poliza In mPolizas
  '        .Cells(t, 1).Value = _Poliza.NombreCompleto
  '        .Cells(t, 2).Value = _Poliza.DireccionesString
  '        .Cells(t, 3).Value = _Poliza.TelefonosString
  '        .Cells(t, 4).Value = _Poliza.EmailsString
  '        .Cells(t, 5).Value = _Poliza.TelefonosString
  '      Next

  '      .Columns("A:E").EntireColumn.AutoFit()
  '    End With
  '    excelApp.Visible = True
  '    excelWorksheet.PrintPreview()
  '    'excelApp.Quit()
  '  Catch ex As Exception
  '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
  '  End Try
  'End Sub

  Private Sub FrmListaPolizas_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mPolizas As PolizaList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Polizas"
    MyBase.AgregarLeyenda = "Agregar una nueva Poliza"

    Me.ListBindingSource.DataSource = GetType(Poliza)
    mPolizas = PolizaList.ObtenerLista(Sistema.OperadorDatos, Nothing, _filtro)
    Dim mitemssort As New Infoware.Reglas.SortedView(mPolizas)
    ListBindingSource.DataSource = mitemssort
  End Sub

  Private Sub mPolizas_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mPolizas.AddingNew
    Dim _Poliza As Poliza = New Poliza(Sistema.OperadorDatos, True)
    e.NewObject = _Poliza
  End Sub
#End Region


#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoPolizas)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    EsBusqueda = _busqueda
    ' Add any initialization after the InitializeComponent() call.
    FrmListaPolizas_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoPolizas)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _OpcionNuevo)
  End Sub

  Private Sub FrmListaPolizas_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Llenar_datos()
  End Sub
#End Region

End Class
