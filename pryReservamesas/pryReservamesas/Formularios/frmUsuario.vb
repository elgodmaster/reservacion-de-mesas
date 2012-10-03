Imports System.Data.SqlClient
Public Class frmUsuario
    'Declarlación de variables
    Dim registronuevo As Boolean
    Dim tblhuesped As New DataTable
    Dim adp As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim enlace As New BindingSource
    'Declaración de clases
    Dim clsusuario As New clsUsuario
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        habilitarControles(GroupPanel1, True)
        limpiarControles(GroupPanel1)
        HabilitarBotones(btnNuevo, btnGuardar, btnModificar, btnEliminar, btnCancelar, False)
        txtApellidos.Focus()
        registronuevo = True
        'limpiarEnlaces()
    End Sub

    Private Sub frmUsuario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        btnNuevo.Focus()    'Asignarle el foco al boton nuevo
        actualizarDatatable()
        If DataGridViewX1.RowCount > 0 Then
            DataGridViewX1.Columns(0).Visible = False
            DataGridViewX1.Columns(4).Visible = False
        End If
    End Sub

    Private Sub txtApellidos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidos.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            txtNombres.Focus()
            e.Handled = True
        End If
        
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            txtUsuario.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            txtContrasena.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtContrasena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContrasena.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnGuardar.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If verificarCamposenblanco(GroupPanel1, ErrorProvider1) = True Then
            MsgBox(camposenblanco, MsgBoxStyle.Information, nombreaplicacion)
            Exit Sub
        Else
            
            With clsusuario
                If DataGridViewX1.RowCount > 0 Then
                    .idusuario = DataGridViewX1.SelectedCells(0).Value.ToString
                End If
                .apellidos = txtApellidos.Text
                .nombres = txtNombres.Text
                .usuario = txtUsuario.Text
                .contrasena = txtContrasena.Text
            End With
            If registronuevo = True Then
                If clsusuario.existe = True Then
                    MsgBox(registroexistente, MsgBoxStyle.Information, nombreaplicacion)
                    ErrorProvider1.SetError(txtUsuario, "Verifique este campo")
                    Exit Sub
                Else
                    clsusuario.insertar()
                End If
            Else
                clsusuario.modificar()
            End If
            limpiarControles(GroupPanel1)
            habilitarControles(GroupPanel1, False)
            HabilitarBotones(btnNuevo, btnGuardar, btnModificar, btnEliminar, btnCancelar, True)
            actualizarDatatable()
        End If
        btnNuevo.Focus()
    End Sub

    Sub actualizarDatatable()
        tblhuesped.Clear()
        adp = New SqlDataAdapter("SELECT idusuario,apellidos Apellidos,nombres Nombres,usuario Usuario,contrasena FROM tblusuario WHERE estado = 1", conString)
        adp.Fill(tblhuesped)
        enlace.DataSource = tblhuesped
        DataGridViewX1.DataSource = enlace
        limpiarEnlaces()
        BindingNavigator1.BindingSource = enlace
        txtApellidos.DataBindings.Add("Text", enlace, "apellidos")
        txtNombres.DataBindings.Add("Text", enlace, "nombres")
        txtUsuario.DataBindings.Add("Text", enlace, "usuario")
        txtContrasena.DataBindings.Add("Text", enlace, "contrasena")
    End Sub

    Sub limpiarEnlaces()
        txtApellidos.DataBindings.Clear()
        txtNombres.DataBindings.Clear()
        txtUsuario.DataBindings.Clear()
        txtContrasena.DataBindings.Clear()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        HabilitarBotones(btnNuevo, btnGuardar, btnModificar, btnEliminar, btnCancelar, False)
        habilitarControles(GroupPanel1, True)
        registronuevo = False
        txtApellidos.Focus()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MsgBox("Desea eliminar el registro", MsgBoxStyle.YesNoCancel, nombreaplicacion) = MsgBoxResult.Yes Then
            With clsusuario
                .idusuario = DataGridViewX1.SelectedCells(0).Value.ToString
                .eliminar()
            End With
            actualizarDatatable()
        End If
    End Sub
End Class