<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaActivosLote
  Inherits Infoware.Consola.Base.FrmMantenimientoSimpleBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.btnGenerarPlantillaact = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.lbl_registro = New System.Windows.Forms.Label()
    Me.dgcargaract = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bscargaract = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btncargarplantillaact = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    Me.lblregistroval = New System.Windows.Forms.Label()
    Me.dgcargarval = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btncargarplantillaval = New System.Windows.Forms.Button()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.GroupBox4 = New System.Windows.Forms.GroupBox()
    Me.btnGenerarPlantillaval = New System.Windows.Forms.Button()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.bscargarval = New System.Windows.Forms.BindingSource(Me.components)
    Me.pnlcuerpo.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    CType(Me.dgcargaract, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bscargaract, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    CType(Me.dgcargarval, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox4.SuspendLayout()
    CType(Me.bscargarval, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.Panel1)
    Me.pnlcuerpo.Size = New System.Drawing.Size(647, 517)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.Panel1, 0)
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.btnGenerarPlantillaact)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(613, 80)
    Me.GroupBox1.TabIndex = 2
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Generación de plantilla"
    '
    'btnGenerarPlantillaact
    '
    Me.btnGenerarPlantillaact.Location = New System.Drawing.Point(6, 42)
    Me.btnGenerarPlantillaact.Name = "btnGenerarPlantillaact"
    Me.btnGenerarPlantillaact.Size = New System.Drawing.Size(158, 23)
    Me.btnGenerarPlantillaact.TabIndex = 1
    Me.btnGenerarPlantillaact.Text = "Generar plantilla"
    Me.btnGenerarPlantillaact.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.SystemColors.Info
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
    Me.Label1.Location = New System.Drawing.Point(3, 16)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(607, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Dé clic en Generar plantilla para que se genere una hoja de Microsoft Excel para " & _
    "el ingreso de la carga inicial de activos"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.TabControl1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 25)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
    Me.Panel1.Size = New System.Drawing.Size(647, 492)
    Me.Panel1.TabIndex = 3
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.lbl_registro)
    Me.GroupBox2.Controls.Add(Me.dgcargaract)
    Me.GroupBox2.Controls.Add(Me.btncargarplantillaact)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox2.Location = New System.Drawing.Point(3, 83)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(613, 360)
    Me.GroupBox2.TabIndex = 3
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Cargar plantilla"
    '
    'lbl_registro
    '
    Me.lbl_registro.AutoSize = True
    Me.lbl_registro.Location = New System.Drawing.Point(180, 47)
    Me.lbl_registro.Name = "lbl_registro"
    Me.lbl_registro.Size = New System.Drawing.Size(10, 13)
    Me.lbl_registro.TabIndex = 35
    Me.lbl_registro.Text = "."
    '
    'dgcargaract
    '
    Me.dgcargaract.AgruparRepetidos = False
    Me.dgcargaract.AllowUserToAddRows = False
    Me.dgcargaract.AllowUserToDeleteRows = False
    Me.dgcargaract.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgcargaract.AutoGenerateColumns = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgcargaract.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgcargaract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgcargaract.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
    Me.dgcargaract.DataSource = Me.bscargaract
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgcargaract.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgcargaract.Location = New System.Drawing.Point(6, 71)
    Me.dgcargaract.Name = "dgcargaract"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgcargaract.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgcargaract.RowHeadersVisible = False
    Me.dgcargaract.Size = New System.Drawing.Size(601, 274)
    Me.dgcargaract.TabIndex = 34
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    '
    'btncargarplantillaact
    '
    Me.btncargarplantillaact.Location = New System.Drawing.Point(6, 42)
    Me.btncargarplantillaact.Name = "btncargarplantillaact"
    Me.btncargarplantillaact.Size = New System.Drawing.Size(158, 23)
    Me.btncargarplantillaact.TabIndex = 1
    Me.btncargarplantillaact.Text = "Cargar plantilla"
    Me.btncargarplantillaact.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.SystemColors.Info
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label2.ForeColor = System.Drawing.SystemColors.InfoText
    Me.Label2.Location = New System.Drawing.Point(3, 16)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(607, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Dé clic en Cargar plantilla para comenzar el proceso de lectura de la hoja de Mic" & _
    "rosoft Excel con los datos iniciales"
    '
    'DataGridViewTextBoxColumn44
    '
    Me.DataGridViewTextBoxColumn44.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(10, 10)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(627, 472)
    Me.TabControl1.TabIndex = 4
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.GroupBox2)
    Me.TabPage1.Controls.Add(Me.GroupBox1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(619, 446)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Cargar activos"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.GroupBox3)
    Me.TabPage2.Controls.Add(Me.GroupBox4)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(619, 446)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Cargar valoraciones"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.lblregistroval)
    Me.GroupBox3.Controls.Add(Me.dgcargarval)
    Me.GroupBox3.Controls.Add(Me.btncargarplantillaval)
    Me.GroupBox3.Controls.Add(Me.Label4)
    Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox3.Location = New System.Drawing.Point(3, 83)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(613, 360)
    Me.GroupBox3.TabIndex = 5
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "Cargar plantilla"
    '
    'lblregistroval
    '
    Me.lblregistroval.AutoSize = True
    Me.lblregistroval.Location = New System.Drawing.Point(180, 47)
    Me.lblregistroval.Name = "lblregistroval"
    Me.lblregistroval.Size = New System.Drawing.Size(10, 13)
    Me.lblregistroval.TabIndex = 35
    Me.lblregistroval.Text = "."
    '
    'dgcargarval
    '
    Me.dgcargarval.AgruparRepetidos = False
    Me.dgcargarval.AllowUserToAddRows = False
    Me.dgcargarval.AllowUserToDeleteRows = False
    Me.dgcargarval.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgcargarval.AutoGenerateColumns = False
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgcargarval.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgcargarval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgcargarval.DataSource = Me.bscargarval
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgcargarval.DefaultCellStyle = DataGridViewCellStyle5
    Me.dgcargarval.Location = New System.Drawing.Point(6, 71)
    Me.dgcargarval.Name = "dgcargarval"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgcargarval.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.dgcargarval.RowHeadersVisible = False
    Me.dgcargarval.Size = New System.Drawing.Size(601, 274)
    Me.dgcargarval.TabIndex = 34
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    '
    'btncargarplantillaval
    '
    Me.btncargarplantillaval.Location = New System.Drawing.Point(6, 42)
    Me.btncargarplantillaval.Name = "btncargarplantillaval"
    Me.btncargarplantillaval.Size = New System.Drawing.Size(158, 23)
    Me.btncargarplantillaval.TabIndex = 1
    Me.btncargarplantillaval.Text = "Cargar plantilla"
    Me.btncargarplantillaval.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.BackColor = System.Drawing.SystemColors.Info
    Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label4.ForeColor = System.Drawing.SystemColors.InfoText
    Me.Label4.Location = New System.Drawing.Point(3, 16)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(607, 13)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "Dé clic en Cargar plantilla para comenzar el proceso de lectura de la hoja de Mic" & _
    "rosoft Excel con los datos iniciales"
    '
    'GroupBox4
    '
    Me.GroupBox4.Controls.Add(Me.btnGenerarPlantillaval)
    Me.GroupBox4.Controls.Add(Me.Label5)
    Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.Size = New System.Drawing.Size(613, 80)
    Me.GroupBox4.TabIndex = 4
    Me.GroupBox4.TabStop = False
    Me.GroupBox4.Text = "Generación de plantilla"
    '
    'btnGenerarPlantillaval
    '
    Me.btnGenerarPlantillaval.Location = New System.Drawing.Point(6, 42)
    Me.btnGenerarPlantillaval.Name = "btnGenerarPlantillaval"
    Me.btnGenerarPlantillaval.Size = New System.Drawing.Size(158, 23)
    Me.btnGenerarPlantillaval.TabIndex = 1
    Me.btnGenerarPlantillaval.Text = "Generar plantilla"
    Me.btnGenerarPlantillaval.UseVisualStyleBackColor = True
    '
    'Label5
    '
    Me.Label5.BackColor = System.Drawing.SystemColors.Info
    Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label5.ForeColor = System.Drawing.SystemColors.InfoText
    Me.Label5.Location = New System.Drawing.Point(3, 16)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(607, 13)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Dé clic en Generar plantilla para que se genere una hoja de Microsoft Excel para " & _
    "el ingreso de la carga inicial de valoraciones"
    '
    'FrmCargaActivosLote
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(647, 566)
    Me.Name = "FrmCargaActivosLote"
    Me.Text = "Carga en lote"
    Me.pnlcuerpo.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    CType(Me.dgcargaract, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bscargaract, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox3.PerformLayout()
    CType(Me.dgcargarval, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox4.ResumeLayout(False)
    CType(Me.bscargarval, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents btnGenerarPlantillaact As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents btncargarplantillaact As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dgcargaract As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents bscargaract As System.Windows.Forms.BindingSource
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents lbl_registro As System.Windows.Forms.Label
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents lblregistroval As System.Windows.Forms.Label
  Friend WithEvents dgcargarval As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btncargarplantillaval As System.Windows.Forms.Button
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
  Friend WithEvents btnGenerarPlantillaval As System.Windows.Forms.Button
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents bscargarval As System.Windows.Forms.BindingSource
End Class
