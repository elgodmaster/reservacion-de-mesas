<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel
        Me.lblId = New System.Windows.Forms.Label
        Me.lblUsuario = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.NavigationBar1 = New DevComponents.DotNetBar.NavigationBar
        Me.btnReservacion = New DevComponents.DotNetBar.ButtonItem
        Me.btnConsultas = New DevComponents.DotNetBar.ButtonItem
        Me.btnHuesped = New DevComponents.DotNetBar.ButtonItem
        Me.btnReportes = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem
        Me.btnMesas = New DevComponents.DotNetBar.ButtonItem
        Me.btnUsuario = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem
        Me.btnXml = New DevComponents.DotNetBar.ButtonItem
        Me.btnSalir = New DevComponents.DotNetBar.ButtonItem
        Me.btnCerrarsesion = New DevComponents.DotNetBar.ButtonItem
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ExpandablePanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavigationBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 670)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1161, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ExpandablePanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = Global.pryReservamesas.My.Resources.Resources.Windows_7
        Me.SplitContainer1.Size = New System.Drawing.Size(1161, 670)
        Me.SplitContainer1.SplitterDistance = 188
        Me.SplitContainer1.TabIndex = 2
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExpandablePanel1.Controls.Add(Me.lblId)
        Me.ExpandablePanel1.Controls.Add(Me.lblUsuario)
        Me.ExpandablePanel1.Controls.Add(Me.LabelX2)
        Me.ExpandablePanel1.Controls.Add(Me.PictureBox1)
        Me.ExpandablePanel1.Controls.Add(Me.LabelX1)
        Me.ExpandablePanel1.Controls.Add(Me.NavigationBar1)
        Me.ExpandablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExpandablePanel1.Location = New System.Drawing.Point(0, 0)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(188, 670)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 1
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Menu Principal"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.Red
        Me.lblId.Location = New System.Drawing.Point(70, 595)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(21, 20)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "id"
        Me.lblId.Visible = False
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        '
        '
        '
        Me.lblUsuario.BackgroundStyle.Class = ""
        Me.lblUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.Red
        Me.lblUsuario.Location = New System.Drawing.Point(8, 616)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(142, 21)
        Me.lblUsuario.TabIndex = 5
        Me.lblUsuario.Text = "Nombre del usuario"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(8, 592)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(56, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Nombre :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pryReservamesas.My.Resources.Resources.personal_information256
        Me.PictureBox1.Location = New System.Drawing.Point(32, 456)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 104)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Red
        Me.LabelX1.Location = New System.Drawing.Point(16, 568)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(144, 23)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Información del usuario"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'NavigationBar1
        '
        Me.NavigationBar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NavigationBar1.BackgroundStyle.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.NavigationBar1.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.NavigationBar1.BackgroundStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.NavigationBar1.ConfigureItemVisible = False
        Me.NavigationBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavigationBar1.ItemPaddingBottom = 2
        Me.NavigationBar1.ItemPaddingTop = 2
        Me.NavigationBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnReservacion, Me.btnConsultas, Me.btnHuesped, Me.btnReportes, Me.ButtonItem5, Me.btnSalir})
        Me.NavigationBar1.Location = New System.Drawing.Point(3, 30)
        Me.NavigationBar1.Name = "NavigationBar1"
        Me.NavigationBar1.Size = New System.Drawing.Size(182, 364)
        Me.NavigationBar1.TabIndex = 1
        Me.NavigationBar1.Text = "NavigationBar1"
        '
        'btnReservacion
        '
        Me.btnReservacion.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnReservacion.Image = Global.pryReservamesas.My.Resources.Resources.Calendario
        Me.btnReservacion.Name = "btnReservacion"
        Me.btnReservacion.OptionGroup = "navBar"
        Me.btnReservacion.Text = "Reservaciones"
        '
        'btnConsultas
        '
        Me.btnConsultas.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnConsultas.Image = Global.pryReservamesas.My.Resources.Resources.Consultas
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.OptionGroup = "navBar"
        Me.btnConsultas.Text = "Consultas"
        '
        'btnHuesped
        '
        Me.btnHuesped.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnHuesped.Image = Global.pryReservamesas.My.Resources.Resources.Huesped
        Me.btnHuesped.Name = "btnHuesped"
        Me.btnHuesped.OptionGroup = "navBar"
        Me.btnHuesped.Text = "Huesped"
        '
        'btnReportes
        '
        Me.btnReportes.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnReportes.Image = Global.pryReservamesas.My.Resources.Resources.Reportes
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.OptionGroup = "navBar"
        Me.btnReportes.Text = "Reportes"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem5.Image = Global.pryReservamesas.My.Resources.Resources.maintenance256
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.OptionGroup = "navBar"
        Me.ButtonItem5.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnMesas, Me.btnUsuario, Me.ButtonItem9, Me.btnXml})
        Me.ButtonItem5.Text = "Configuración"
        '
        'btnMesas
        '
        Me.btnMesas.Image = Global.pryReservamesas.My.Resources.Resources.Mesa
        Me.btnMesas.Name = "btnMesas"
        Me.btnMesas.Text = "Mesas"
        '
        'btnUsuario
        '
        Me.btnUsuario.Image = Global.pryReservamesas.My.Resources.Resources.Usuarios
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Text = "Usuarios"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.Image = Global.pryReservamesas.My.Resources.Resources.Perfiles
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.Text = "Perfiles"
        '
        'btnXml
        '
        Me.btnXml.Image = Global.pryReservamesas.My.Resources.Resources.Cancelar1
        Me.btnXml.Name = "btnXml"
        Me.btnXml.Text = "Actualizar Plano"
        '
        'btnSalir
        '
        Me.btnSalir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnSalir.Checked = True
        Me.btnSalir.Image = Global.pryReservamesas.My.Resources.Resources.exit_128
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.OptionGroup = "navBar"
        Me.btnSalir.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnCerrarsesion})
        Me.btnSalir.Text = "Salir del sistema"
        '
        'btnCerrarsesion
        '
        Me.btnCerrarsesion.Image = Global.pryReservamesas.My.Resources.Resources.cerrarSesion
        Me.btnCerrarsesion.Name = "btnCerrarsesion"
        Me.btnCerrarsesion.Text = "Cerrar sesión"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 692)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de reservación de mesas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ExpandablePanel1.ResumeLayout(False)
        Me.ExpandablePanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavigationBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents NavigationBar1 As DevComponents.DotNetBar.NavigationBar
    Friend WithEvents btnReservacion As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnConsultas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnHuesped As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnReportes As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnMesas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnUsuario As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Public WithEvents lblUsuario As DevComponents.DotNetBar.LabelX
    Public WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents btnCerrarsesion As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnXml As DevComponents.DotNetBar.ButtonItem

End Class
