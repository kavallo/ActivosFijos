<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWCFService
  Inherits Infoware.Consola.Base.FrmFormaBase

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
    Me.btniniciar = New System.Windows.Forms.Button()
    Me.txtPuerto = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.HeaderStrip1 = New Infoware.Docking.HeaderStrip()
    Me.ToolStriptitulo = New System.Windows.Forms.ToolStripLabel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
    Me.linkservice = New System.Windows.Forms.LinkLabel()
    Me.HeaderStrip1.SuspendLayout()
    Me.FlowLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'btniniciar
    '
    Me.btniniciar.Location = New System.Drawing.Point(12, 133)
    Me.btniniciar.Name = "btniniciar"
    Me.btniniciar.Size = New System.Drawing.Size(100, 23)
    Me.btniniciar.TabIndex = 0
    Me.btniniciar.Text = "Iniciar"
    Me.btniniciar.UseVisualStyleBackColor = True
    '
    'txtPuerto
    '
    Me.txtPuerto.BackColor = System.Drawing.SystemColors.Window
    Me.txtPuerto.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtPuerto.Location = New System.Drawing.Point(68, 62)
    Me.txtPuerto.Margin = New System.Windows.Forms.Padding(2)
    Me.txtPuerto.Mensaje = ""
    Me.txtPuerto.Name = "txtPuerto"
    Me.txtPuerto.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPuerto.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtPuerto.PromptText = ""
    Me.txtPuerto.Size = New System.Drawing.Size(100, 20)
    Me.txtPuerto.TabIndex = 10
    Me.txtPuerto.Text = "9191"
    Me.txtPuerto.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtPuerto.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.SoloNumeros
    Me.txtPuerto.Value = 9191.0R
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 65)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(41, 13)
    Me.Label3.TabIndex = 9
    Me.Label3.Text = "Puerto:"
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.White
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStriptitulo})
    Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Size = New System.Drawing.Size(461, 25)
    Me.HeaderStrip1.TabIndex = 11
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStriptitulo
    '
    Me.ToolStriptitulo.Name = "ToolStriptitulo"
    Me.ToolStriptitulo.Size = New System.Drawing.Size(169, 22)
    Me.ToolStriptitulo.Text = "Servicio de conexión"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 40)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(293, 13)
    Me.Label1.TabIndex = 12
    Me.Label1.Text = "Iniciar el servicio de conexión con la siguiente configuración:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(3, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(146, 13)
    Me.Label2.TabIndex = 13
    Me.Label2.Text = "El servicio ha sido iniciado en"
    '
    'FlowLayoutPanel1
    '
    Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
    Me.FlowLayoutPanel1.Controls.Add(Me.linkservice)
    Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 94)
    Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
    Me.FlowLayoutPanel1.Size = New System.Drawing.Size(437, 33)
    Me.FlowLayoutPanel1.TabIndex = 14
    Me.FlowLayoutPanel1.Visible = False
    '
    'linkservice
    '
    Me.linkservice.AutoSize = True
    Me.linkservice.Location = New System.Drawing.Point(155, 0)
    Me.linkservice.Name = "linkservice"
    Me.linkservice.Size = New System.Drawing.Size(38, 13)
    Me.linkservice.TabIndex = 14
    Me.linkservice.TabStop = True
    Me.linkservice.Text = "lnktext"
    '
    'FrmWCFService
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(461, 336)
    Me.Controls.Add(Me.FlowLayoutPanel1)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.HeaderStrip1)
    Me.Controls.Add(Me.txtPuerto)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.btniniciar)
    Me.Name = "FrmWCFService"
    Me.Text = "FrmWCFService"
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.FlowLayoutPanel1.ResumeLayout(False)
    Me.FlowLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btniniciar As System.Windows.Forms.Button
  Friend WithEvents txtPuerto As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents HeaderStrip1 As Infoware.Docking.HeaderStrip
  Friend WithEvents ToolStriptitulo As System.Windows.Forms.ToolStripLabel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents linkservice As System.Windows.Forms.LinkLabel
End Class
