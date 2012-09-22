Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class FrmListaTransaccionActivos
  Private mTransaccionActivo As TransaccionActivo = Nothing
  Public Property TransaccionActivo() As TransaccionActivo
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As TransaccionActivo)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _TransaccionActivo As TransaccionActivo In Me.ListBindingSource.DataSource
          If _TransaccionActivo.Transa_Codigo = value.Transa_Codigo Then
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
  Private Sub FrmListaTransaccionActivos_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaTransaccionActivos_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaTransaccionActivos_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim f As New FrmMantenimientoTransaccionActivo(Sistema, Restriccion)
    f.TransaccionActivos = ListBindingSource
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
  End Sub

  Private Sub FrmListaTransaccionActivos_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaTransaccionActivos_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaTransaccionActivos_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mTransaccionActivos Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mTransaccionActivo As TransaccionActivo
    mTransaccionActivo = ListBindingSource.Current
    If mTransaccionActivo.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar TransaccionActivo" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  'Private Sub FrmListaTransaccionActivos_Exportar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Exportar
  '  'exportar
  '  Try
  '    Dim excelApp As New Excel.Application
  '    Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
  '    Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
  '    excelApp.Visible = False
  '    With excelWorksheet
  '      .Range("A1").Value = "Nombre de TransaccionActivo"
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
  '      For Each _TransaccionActivo As TransaccionActivo In mTransaccionActivos
  '        .Cells(t, 1).Value = _TransaccionActivo.NombreCompleto
  '        .Cells(t, 2).Value = _TransaccionActivo.DireccionesString
  '        .Cells(t, 3).Value = _TransaccionActivo.TelefonosString
  '        .Cells(t, 4).Value = _TransaccionActivo.EmailsString
  '        .Cells(t, 5).Value = _TransaccionActivo.TelefonosString
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

  Private Sub FrmListaTransaccionActivos_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mTransaccionActivos As TransaccionActivoList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Transacción Activos"
    MyBase.AgregarLeyenda = "Agregar una nueva Transacción Activo"

    Me.ListBindingSource.DataSource = GetType(TransaccionActivo)
    mTransaccionActivos = TransaccionActivoList.ObtenerLista(Sistema.OperadorDatos, New wwtsusuario(sistema.operadorDatos, sistema.usuario.usuari_codigo), _filtro)
    Dim mitemssort As New Infoware.Reglas.SortedView(mTransaccionActivos)
    ListBindingSource.DataSource = mitemssort
  End Sub

  Private Sub mTransaccionActivos_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mTransaccionActivos.AddingNew
    Dim _TransaccionActivo As TransaccionActivo = New TransaccionActivo(Sistema.OperadorDatos, True)
    e.NewObject = _TransaccionActivo
  End Sub
#End Region


#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoTransaccionActivos)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    EsBusqueda = _busqueda
    ' Add any initialization after the InitializeComponent() call.
    FrmListaTransaccionActivos_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoTransaccionActivos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _OpcionNuevo)
  End Sub

  Private Sub FrmListaTransaccionActivos_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Llenar_datos()
  End Sub
#End Region

End Class
