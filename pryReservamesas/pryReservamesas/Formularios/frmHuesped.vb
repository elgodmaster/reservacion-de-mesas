Imports System.Data.SqlClient
Public Class frmHuesped

    'Declarlación de variables
    Dim registronuevo As Boolean
    Dim tblhuesped As New DataTable
    Dim adp As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim enlace As New BindingSource
    'Declaración de clases
    Dim clshuesped As New clsHuesped

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        habilitarControles(GroupPanel1, True)
        limpiarControles(GroupPanel1)
        HabilitarBotones(btnNuevo, btnGuardar, btnModificar, btnEliminar, btnCancelar, False)
        txtNombre.Focus()
        registronuevo = True
        limpiarEnlaces()
    End Sub

    Sub limpiarEnlaces()                    'Limpiar los enlaces de datos de los controles
        txtNombre.DataBindings.Clear()
        txtHabitación.DataBindings.Clear()
    End Sub

    Private Sub frmHuesped_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnNuevo.Focus()                    'Asignar el foco al boton nuevo
        actualizarDatatable()
        If DataGridViewX1.RowCount > 0 Then
            DataGridViewX1.Columns(0).Visible = False
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            txtHabitación.Focus()
        End If
    End Sub

    Private Sub txtHabitación_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHabitación.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnGuardar.Focus()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If verificarCamposenblanco(GroupPanel1, ErrorProvider1) = True Then
            MsgBox(camposenblanco, MsgBoxStyle.Information, nombreaplicacion)
            Exit Sub
        Else
            If EsInteger(txtHabitación.Text) = False Then
                MsgBox("Ingrese el número de habitación correctamente", MsgBoxStyle.Information, nombreaplicacion)
                txtHabitación.Focus()
                Exit Sub
            Else
                With clshuesped
                    .nombre = txtNombre.Text
                    .habitacion = txtHabitación.Text
                End With
                If registronuevo = True Then
                    If clshuesped.existe = True Then
                        MsgBox(registroexistente, MsgBoxStyle.Information, nombreaplicacion)
                        ErrorProvider1.SetError(txtNombre, "Verifique este campo")
                        ErrorProvider1.SetError(txtHabitación, "Verifique este campo")
                        Exit Sub
                    Else
                        clshuesped.insertar()
                    End If
                Else
                    clshuesped.idhuesped = DataGridViewX1.SelectedCells(0).Value.ToString
                    clshuesped.modificar()
                End If
                limpiarControles(GroupPanel1)
                habilitarControles(GroupPanel1, False)
                HabilitarBotones(btnNuevo, btnGuardar, btnModificar, btnEliminar, btnCancelar, True)
                actualizarDatatable()
            End If
            btnNuevo.Focus()
        End If
    End Sub

    Sub actualizarDatatable()
        tblhuesped.Clear()
        adp = New SqlDataAdapter("SELECT idhuesped, nombre Nombre,habitacion Habitacion FROM tblhuesped WHERE estado = 1 ORDER BY nombre", conString)
        adp.Fill(tblhuesped)
        enlace.DataSource = tblhuesped
        DataGridViewX1.DataSource = enlace
        limpiarEnlaces()
        BindingNavigator1.BindingSource = enlace
        txtNombre.DataBindings.Add(New Binding("Text", enlace, "nombre"))
        txtHabitación.DataBindings.Add(New Binding("Text", enlace, "habitacion"))
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        habilitarControles(GroupPanel1, False)
        limpiarControles(GroupPanel1)
        HabilitarBotones(btnNuevo, btnGuardar, btnModificar, btnEliminar, btnCancelar, True)
        actualizarDatatable()
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        Dim parametro As String = ""
        If rdbNombre.Checked = True Then
            parametro = "nombre"
        Else
            parametro = "habitacion"
        End If
        enlace.Filter = parametro + " LIKE '%" + txtBuscar.Text + "%'"
        If Me.DataGridViewX1.RowCount = 0 Then
            txtBuscar.BackColor = Color.Red
        Else
            txtBuscar.BackColor = Color.White
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        HabilitarBotones(btnNuevo, btnGuardar, btnModificar, btnEliminar, btnCancelar, False)
        habilitarControles(GroupPanel1, True)
        registronuevo = False
        txtNombre.Focus()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MsgBox("Desea eliminar el registro", MsgBoxStyle.YesNoCancel, nombreaplicacion) = MsgBoxResult.Yes Then
            With clshuesped
                .idhuesped = DataGridViewX1.SelectedCells(0).Value.ToString
                .eliminar()
            End With
            actualizarDatatable()
        End If
    End Sub

End Class