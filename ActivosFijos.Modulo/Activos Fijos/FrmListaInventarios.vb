Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class FrmListaInventarios
  Private ReadOnly Property Usuario As WWTSUsuario
    Get
      Return New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)
    End Get
  End Property

  Private mInventario As Inventario = Nothing
  Public Property Inventario() As Inventario
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As Inventario)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _Inventario As Inventario In Me.ListBindingSource.DataSource
          If _Inventario.Parame_Ubicacion = value.Parame_Ubicacion And _Inventario.Pardet_Ubicacion = value.Pardet_Ubicacion And _Inventario.Parame_PeriodoInventario = value.Parame_PeriodoInventario And _Inventario.Pardet_PeriodoInventario = value.Pardet_PeriodoInventario Then
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
  Private Sub FrmListaInventarios_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaInventarios_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaInventarios_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim f As New FrmMantenimientoInventario(Sistema, Restriccion)
    f.Inventarios = ListBindingSource
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
  End Sub

  Private Sub FrmListaInventarios_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaInventarios_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaInventarios_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mInventarios Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mInventario As Inventario
    mInventario = ListBindingSource.Current
    If mInventario.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar Inventario" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  'Private Sub FrmListaInventarios_Exportar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Exportar
  '  'exportar
  '  Try
  '    Dim excelApp As New Excel.Application
  '    Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
  '    Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
  '    excelApp.Visible = False
  '    With excelWorksheet
  '      .Range("A1").Value = "Nombre de Inventario"
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
  '      For Each _Inventario As Inventario In mInventarios
  '        .Cells(t, 1).Value = _Inventario.NombreCompleto
  '        .Cells(t, 2).Value = _Inventario.DireccionesString
  '        .Cells(t, 3).Value = _Inventario.TelefonosString
  '        .Cells(t, 4).Value = _Inventario.EmailsString
  '        .Cells(t, 5).Value = _Inventario.TelefonosString
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

  Private Sub FrmListaInventarios_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mInventarios As InventarioList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Inventarios"
    MyBase.AgregarLeyenda = "Agregar un nuevo Inventario"

    Me.ListBindingSource.DataSource = GetType(Inventario)
    mInventarios = InventarioList.ObtenerLista(Sistema.OperadorDatos, Usuario.PardetUbicacion, Nothing, _filtro)
    Dim mitemssort As New Infoware.Reglas.SortedView(mInventarios)
    ListBindingSource.DataSource = mitemssort
  End Sub

  Private Sub mInventarios_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mInventarios.AddingNew
    Dim _Inventario As Inventario = New Inventario(Sistema.OperadorDatos, True)
    e.NewObject = _Inventario
  End Sub
#End Region


#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.InventarioActivo)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    EsBusqueda = _busqueda
    ' Add any initialization after the InitializeComponent() call.
    FrmListaInventarios_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.InventarioActivo)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _OpcionNuevo)
  End Sub

  Private Sub FrmListaInventarios_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Llenar_datos()
  End Sub
#End Region

End Class
