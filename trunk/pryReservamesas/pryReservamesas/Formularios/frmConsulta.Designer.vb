<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
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
    Me.components = New System.ComponentModel.Container
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsulta))
    Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX
    Me.LabelX1 = New DevComponents.DotNetBar.LabelX
    Me.txtBuscar = New System.Windows.Forms.TextBox
    Me.rdbMesa = New System.Windows.Forms.RadioButton
    Me.rdbNombre = New System.Windows.Forms.RadioButton
    Me.btnImprimir = New DevComponents.DotNetBar.ButtonX
    Me.btnCerrar = New DevComponents.DotNetBar.ButtonX
    Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
    Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
    Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
    Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
    Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
    Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
    Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
    Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
    Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
    Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.LabelX2 = New DevComponents.DotNetBar.LabelX
    CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupPanel2.SuspendLayout()
    CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.BindingNavigator1.SuspendLayout()
    Me.SuspendLayout()
    '
    'DataGridViewX1
    '
    Me.DataGridViewX1.AllowUserToAddRows = False
    Me.DataGridViewX1.AllowUserToDeleteRows = False
    Me.DataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
    Me.DataGridViewX1.BackgroundColor = System.Drawing.Color.White
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
    Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle8
    Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
    Me.DataGridViewX1.Location = New System.Drawing.Point(8, 88)
    Me.DataGridViewX1.Name = "DataGridViewX1"
    Me.DataGridViewX1.ReadOnly = True
    Me.DataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.DataGridViewX1.Size = New System.Drawing.Size(944, 400)
    Me.DataGridViewX1.TabIndex = 0
    '
    'LabelX1
    '
    Me.LabelX1.BackColor = System.Drawing.Color.Transparent
    '
    '
    '
    Me.LabelX1.BackgroundStyle.Class = ""
    Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
    Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelX1.Location = New System.Drawing.Point(16, 544)
    Me.LabelX1.Name = "LabelX1"
    Me.LabelX1.Size = New System.Drawing.Size(56, 24)
    Me.LabelX1.TabIndex = 1
    Me.LabelX1.Text = "Buscar :"
    '
    'txtBuscar
    '
    Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBuscar.Location = New System.Drawing.Point(80, 548)
    Me.txtBuscar.Name = "txtBuscar"
    Me.txtBuscar.Size = New System.Drawing.Size(280, 22)
    Me.txtBuscar.TabIndex = 2
    '
    'rdbMesa
    '
    Me.rdbMesa.AutoSize = True
    Me.rdbMesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdbMesa.ForeColor = System.Drawing.Color.Red
    Me.rdbMesa.Location = New System.Drawing.Point(456, 548)
    Me.rdbMesa.Name = "rdbMesa"
    Me.rdbMesa.Size = New System.Drawing.Size(103, 20)
    Me.rdbMesa.TabIndex = 22
    Me.rdbMesa.Text = "No. de mesa"
    Me.rdbMesa.UseVisualStyleBackColor = True
    '
    'rdbNombre
    '
    Me.rdbNombre.AutoSize = True
    Me.rdbNombre.Checked = True
    Me.rdbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdbNombre.ForeColor = System.Drawing.Color.Red
    Me.rdbNombre.Location = New System.Drawing.Point(368, 548)
    Me.rdbNombre.Name = "rdbNombre"
    Me.rdbNombre.Size = New System.Drawing.Size(75, 20)
    Me.rdbNombre.TabIndex = 21
    Me.rdbNombre.TabStop = True
    Me.rdbNombre.Text = "Nombre"
    Me.rdbNombre.UseVisualStyleBackColor = True
    '
    'btnImprimir
    '
    Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
    Me.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
    Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImprimir.Image = Global.pryReservamesas.My.Resources.Resources.Reportes
    Me.btnImprimir.Location = New System.Drawing.Point(608, 536)
    Me.btnImprimir.Name = "btnImprimir"
    Me.btnImprimir.Size = New System.Drawing.Size(168, 48)
    Me.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
    Me.btnImprimir.TabIndex = 23
    Me.btnImprimir.Text = "Imprimir Ticket"
    '
    'btnCerrar
    '
    Me.btnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
    Me.btnCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
    Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.Image = Global.pryReservamesas.My.Resources.Resources._Exit
    Me.btnCerrar.Location = New System.Drawing.Point(784, 536)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(168, 48)
    Me.btnCerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
    Me.btnCerrar.TabIndex = 24
    Me.btnCerrar.Text = "Cerrar"
    '
    'GroupPanel2
    '
    Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
    Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
    Me.GroupPanel2.Controls.Add(Me.BindingNavigator1)
    Me.GroupPanel2.Location = New System.Drawing.Point(8, 496)
    Me.GroupPanel2.Name = "GroupPanel2"
    Me.GroupPanel2.Size = New System.Drawing.Size(416, 33)
    '
    '
    '
    Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
    Me.GroupPanel2.Style.BackColorGradientAngle = 90
    Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
    Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
    Me.GroupPanel2.Style.BorderBottomWidth = 1
    Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
    Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
    Me.GroupPanel2.Style.BorderLeftWidth = 1
    Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
    Me.GroupPanel2.Style.BorderRightWidth = 1
    Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
    Me.GroupPanel2.Style.BorderTopWidth = 1
    Me.GroupPanel2.Style.Class = ""
    Me.GroupPanel2.Style.CornerDiameter = 4
    Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
    Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
    Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
    Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
    '
    '
    '
    Me.GroupPanel2.StyleMouseDown.Class = ""
    Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
    '
    '
    '
    Me.GroupPanel2.StyleMouseOver.Class = ""
    Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
    Me.GroupPanel2.TabIndex = 41
    '
    'BindingNavigator1
    '
    Me.BindingNavigator1.AddNewItem = Nothing
    Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
    Me.BindingNavigator1.DeleteItem = Nothing
    Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
    Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
    Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
    Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
    Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
    Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
    Me.BindingNavigator1.Name = "BindingNavigator1"
    Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
    Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
    Me.BindingNavigator1.Size = New System.Drawing.Size(410, 25)
    Me.BindingNavigator1.TabIndex = 0
    Me.BindingNavigator1.Text = "BindingNavigator1"
    '
    'BindingNavigatorCountItem
    '
    Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
    Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
    Me.BindingNavigatorCountItem.Text = "de {0}"
    Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
    '
    'BindingNavigatorMoveFirstItem
    '
    Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
    Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
    Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
    Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
    '
    'BindingNavigatorMovePreviousItem
    '
    Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
    Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
    Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
    Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
    '
    'BindingNavigatorSeparator
    '
    Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
    Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
    '
    'BindingNavigatorPositionItem
    '
    Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
    Me.BindingNavigatorPositionItem.AutoSize = False
    Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
    Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
    Me.BindingNavigatorPositionItem.Text = "0"
    Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
    '
    'BindingNavigatorSeparator1
    '
    Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
    Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'BindingNavigatorMoveNextItem
    '
    Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
    Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
    Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
    Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
    '
    'BindingNavigatorMoveLastItem
    '
    Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
    Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
    Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
    Me.BindingNavigatorMoveLastItem.Text = "Mover último"
    '
    'BindingNavigatorSeparator2
    '
    Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
    Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'LabelX2
    '
    '
    '
    '
    Me.LabelX2.BackgroundStyle.Class = ""
    Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
    Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelX2.ForeColor = System.Drawing.Color.Red
    Me.LabelX2.Location = New System.Drawing.Point(11, 39)
    Me.LabelX2.Name = "LabelX2"
    Me.LabelX2.Size = New System.Drawing.Size(368, 37)
    Me.LabelX2.TabIndex = 42
    Me.LabelX2.Text = "Consulta de reservaciones"
    '
    'frmConsulta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(960, 593)
    Me.Controls.Add(Me.LabelX2)
    Me.Controls.Add(Me.GroupPanel2)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnImprimir)
    Me.Controls.Add(Me.rdbMesa)
    Me.Controls.Add(Me.rdbNombre)
    Me.Controls.Add(Me.txtBuscar)
    Me.Controls.Add(Me.LabelX1)
    Me.Controls.Add(Me.DataGridViewX1)
    Me.DoubleBuffered = True
    Me.EnableGlass = False
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "frmConsulta"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "frmConsulta"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupPanel2.ResumeLayout(False)
    Me.GroupPanel2.PerformLayout()
    CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.BindingNavigator1.ResumeLayout(False)
    Me.BindingNavigator1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents rdbMesa As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
  Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
