Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class FrmListaFacturaActivos
  '#Region "IOpcion"
  '  Private mOperadorDatos As OperadorDatos = Nothing
  '  Public WriteOnly Property OperadorDatos() As OperadorDatos
  '    Set(ByVal value As OperadorDatos)
  '      mOperadorDatos = value
  '      If value IsNot Nothing Then
  '        Llenar_datos()
  '      End If
  '    End Set
  '  End Property
  '#End Region
  Private mProveedor As Proveedor = Nothing
  Public Property Proveedor As Proveedor
    Get
      Return mProveedor
    End Get
    Set(value As Proveedor)
      mProveedor = value
    End Set
  End Property

  Private mFacturaActivo As FacturaActivo = Nothing
  Public Property FacturaActivo() As FacturaActivo
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As FacturaActivo)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _FacturaActivo As FacturaActivo In Me.ListBindingSource.DataSource
          If _FacturaActivo.Factura_Codigo = value.Factura_Codigo Then
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
  Private Sub FrmListaFacturaActivos_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaFacturaActivos_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaFacturaActivos_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim f As New FrmMantenimientoFacturaActivo(Sistema, Restriccion)
    f.Proveedor = Proveedor
    f.FacturaActivos = ListBindingSource
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
  End Sub

  Private Sub FrmListaFacturaActivos_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaFacturaActivos_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaFacturaActivos_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mFacturaActivos Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mFacturaActivo As FacturaActivo
    mFacturaActivo = ListBindingSource.Current
    If mFacturaActivo.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar FacturaActivo" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  'Private Sub FrmListaFacturaActivos_Exportar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Exportar
  '  'exportar
  '  Try
  '    Dim excelApp As New Excel.Application
  '    Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
  '    Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
  '    excelApp.Visible = False
  '    With excelWorksheet
  '      .Range("A1").Value = "Nombre de FacturaActivo"
  '      .Columns("A:A").ColumnWidth = 80
  '      .Columns("A:A").NumberFormat = "@"

  '      .Range("B1").Value = "Direcciones"
  '      .Columns("B:B").ColumnWidth = 80
  '      .Columns("B:B").NumberFormat = "@"

  '      .Range("C1").Value = "Tel�fonos"
  '      .Columns("C:C").ColumnWidth = 80
  '      .Columns("C:C").NumberFormat = "@"

  '      .Range("D1").Value = "Emails"
  '      .Columns("D:D").ColumnWidth = 80
  '      .Columns("D:D").NumberFormat = "@"

  '      .Range("E1").Value = "Identificaciones"
  '      .Columns("E:E").ColumnWidth = 80
  '      .Columns("E:E").NumberFormat = "@"

  '      Dim t As Integer = 0
  '      For Each _FacturaActivo As FacturaActivo In mFacturaActivos
  '        .Cells(t, 1).Value = _FacturaActivo.NombreCompleto
  '        .Cells(t, 2).Value = _FacturaActivo.DireccionesString
  '        .Cells(t, 3).Value = _FacturaActivo.TelefonosString
  '        .Cells(t, 4).Value = _FacturaActivo.EmailsString
  '        .Cells(t, 5).Value = _FacturaActivo.TelefonosString
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

  Private Sub FrmListaFacturaActivos_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mFacturaActivos As FacturaActivoList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "FacturaActivos"
    MyBase.AgregarLeyenda = "Agregar una nueva Factura Activo"

    If Proveedor Is Nothing Then
      Exit Sub
    End If
    'Me.DataGridView1.Columns.Clear()

    'Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "Provee_Visible"
    'DataGridViewTextBoxColumn0.HeaderText = "Activo"
    'DataGridViewTextBoxColumn0.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "NombreCompleto"
    'DataGridViewTextBoxColumn1.HeaderText = "Nombre de FacturaActivo"
    'DataGridViewTextBoxColumn1.Width = 250
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "DireccionesString"
    'DataGridViewTextBoxColumn1.HeaderText = "Direcci�n"
    'DataGridViewTextBoxColumn1.Width = 250
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "TelefonosString"
    'DataGridViewTextBoxColumn1.HeaderText = "Tel�fono"
    'DataGridViewTextBoxColumn1.Width = 250
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.ListBindingSource.DataSource = GetType(FacturaActivo)
    mFacturaActivos = FacturaActivoList.ObtenerLista(Proveedor, _filtro)
    Dim mitemssort As New Infoware.Reglas.SortedView(mFacturaActivos)
    ListBindingSource.DataSource = mitemssort
  End Sub

  Private Sub mFacturaActivos_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mFacturaActivos.AddingNew
    Dim _FacturaActivo As FacturaActivo = New FacturaActivo(Sistema.OperadorDatos, True)
    e.NewObject = _FacturaActivo
  End Sub
#End Region


#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoFacturaActivos)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    EsBusqueda = _busqueda
    ' Add any initialization after the InitializeComponent() call.
    FrmListaFacturaActivos_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoFacturaActivos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _OpcionNuevo)
  End Sub

  Private Sub FrmListaFacturaActivos_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Llenar_datos()
  End Sub
#End Region

End Class
