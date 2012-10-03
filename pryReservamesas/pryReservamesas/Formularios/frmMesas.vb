Imports System.Data.SqlClient
Public Class frmMesas
    'Declarlación de variables
    Dim registronuevo As Boolean
    Dim tblmesa As New DataTable
    Dim adp As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim enlace As New BindingSource
    Dim consulta As String
    'Declaración de clases
    Dim clsmesa As New clsMesa
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        habilitarControles(GroupPanel1, True)
        limpiarControles(GroupPanel1)
        HabilitarBotones(btnNuevo, btnGuardar, btnModificar, btnEliminar, btnCancelar, False)
        cmbCategoria.Focus()
        registronuevo = True
        limpiarEnlaces()
    End Sub

    Private Sub frmMesas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Cargar las categorias
        clsmesa.llenarCombocategoria(cmbCategoria)
        actualizarDatatable()
        If DataGridViewX1.RowCount > 0 Then
            DataGridViewX1.Columns(0).Visible = False
        End If
        btnNuevo.Focus()

    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategoria.SelectedIndexChanged
        txtNomesa.Focus()
    End Sub

    Private Sub txtNomesa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNomesa.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnGuardar.Focus()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If verificarCamposenblanco(GroupPanel1, ErrorProvider1) = True Then
            MsgBox(camposenblanco, MsgBoxStyle.Information, nombreaplicacion)
            Exit Sub
        Else
            If EsInteger(txtNomesa.Text) = False Then
                MsgBox("Ingrese el número de mesa correctamente", MsgBoxStyle.Information, nombreaplicacion)
                txtNomesa.Focus()
                Exit Sub
            Else
                With clsmesa
                    .idcategoria = cmbCategoria.SelectedValue.ToString
                    .nomesa = txtNomesa.Text
                End With
                If registronuevo = True Then
                    If clsmesa.existe = True Then
                        MsgBox(registroexistente, MsgBoxStyle.Information, nombreaplicacion)
                        ErrorProvider1.SetError(cmbCategoria, "Verifique este campo")
                        ErrorProvider1.SetError(txtNomesa, "Verifique este campo")
                        Exit Sub
                    Else
                        clsmesa.insertar()
                    End If
                Else
                    clsmesa.idmesa = DataGridViewX1.SelectedCells(0).Value.ToString
                    clsmesa.nomesa = txtNomesa.Text
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
        consulta = "SELECT M.idmesa, M.nomesa No,C.categoria Categoria FROM tblmesa AS M " + _
        "INNER JOIN tblcategoria AS C " + _
        "ON M.idcategoria = C.idcategoria AND C.estado = 1 " + _
        "WHERE M.estado = 1;"
        tblmesa.Clear()
        adp = New SqlDataAdapter(consulta, conString)
        adp.Fill(tblmesa)
        enlace.DataSource = tblmesa
        DataGridViewX1.DataSource = enlace
        limpiarEnlaces()
        BindingNavigator1.BindingSource = enlace
        cmbCategoria.DataBindings.Add(New Binding("Text", enlace, "categoria"))
        txtNomesa.DataBindings.Add(New Binding("Text", enlace, "No"))
    End Sub

    Sub limpiarEnlaces()                    'Limpiar los enlaces de datos de los controles
        cmbCategoria.DataBindings.Clear()
        txtNomesa.DataBindings.Clear()
    End Sub

End Class