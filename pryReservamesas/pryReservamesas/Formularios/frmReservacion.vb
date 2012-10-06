Imports System.Data.SqlClient
Imports LibPrintTicketMatriz.Class1
Public Class frmReservacion
    'Declarlación de variables
    Dim registronuevo As Boolean
    Dim tblhuesped As New DataTable
    Dim tblDisponibilidad As New DataTable
    Dim adp As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim enlace As New BindingSource
    Dim sillas, disponibilidad, nomesa As Integer
    Dim enlacedisponibilidad As New BindingSource
    Dim consulta As String
    Dim parametrosReporte As New CrystalDecisions.Shared.ParameterValues
    Dim huesped, mesa, silla, boletos, Fecha As String
    'Declaración de clases
    Dim clsreservacion As New clsReservacion
    Dim clshuesped As New clsHuesped
    Dim clsmesa As New clsMesa
    Dim clsxml As New clsXml

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Sub llenarCombomesas()
        Dim tblmesas As New DataTable
        tblmesas.Clear()
        conectar()
        Dim adp As New SqlDataAdapter("consultarMesasdisponibles", con)
        adp.Fill(tblmesas)
        desconectar()
        With cmbNomesa
            .DataSource = tblmesas
            .DisplayMember = "nomesa"
            .ValueMember = "idmesa"
        End With
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        'HabilitarBotones(btnNuevo, btnGuardar, btnModificar, btnCancelar, btnEliminar, False)
        habilitarBotonsimples(btnNuevo, btnGuardar, btnCancelar, False)
        habilitarControles(GroupPanel1, True)
        llenarCombomesas()
        limpiarControles(GroupPanel1)
        limpiarEnlaces()
        txtNosillas.Text = ""
        registronuevo = True
        cmbHuesped.Focus()
    End Sub

    Private Sub frmReservacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clshuesped.llenarCombo(cmbHuesped)
        actualizarDatatable()
        If DataGridViewX1.RowCount > 0 Then
            DataGridViewX1.Columns(0).Visible = False
            DataGridViewX1.Columns(1).Visible = False
        End If
        consultarDisponibilidad()
        'llenarCombomesas()
        btnNuevo.Focus()
    End Sub

    Private Sub cmbHuesped_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHuesped.SelectedIndexChanged
        cmbNomesa.Focus()
    End Sub

    Private Sub cmbNomesa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNomesa.SelectedIndexChanged
        txtNosillas.Focus()
    End Sub

    Private Sub txtNosillas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNosillas.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            txtNoboletos.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtNoboletos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoboletos.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            txtObservaciones.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If verificarCamposenblanco(GroupPanel1, ErrorProvider1) = True Then     'Verificar campos en blanco
            MsgBox(camposenblanco, MsgBoxStyle.Information, nombreaplicacion)
            Exit Sub
        Else
            If EsDecimal(txtNosillas.Text) = False Then                                     'Verificar si el valor ingresado es un decimal
                MsgBox("El valor que ha ingresado es incorrecto, ingrese un número", MsgBoxStyle.Critical, nombreaplicacion)
                txtNosillas.Focus()
                Exit Sub
            Else
                sillas = txtNosillas.Text                                           'Capturar el valor de el número de sillas
            End If
            disponibilidad = clsmesa.capacidad(cmbNomesa.SelectedValue)         'Obtener la disponiblidad de la mesa
            nomesa = cmbNomesa.Text                                             'Obtener el número de mesa
        End If
        If (sillas > disponibilidad) Then   'En caso de que no haya disponibilidad mostrar el mensaje
            MsgBox("El número de sillas solicitado es mayor a la disponibilidad de la MESA = " + nomesa.ToString + _
                    ", DISPONIBILIDAD = " + disponibilidad.ToString, MsgBoxStyle.Information, nombreaplicacion)
            txtNosillas.Focus()
            Exit Sub
        Else
            If verificarCamposenblanco(GroupPanel1, ErrorProvider1) = True Then 'Verificar si hay campos en blanco
                MsgBox(camposenblanco, MsgBoxStyle.Information, nombreaplicacion)
            Else
                With clsreservacion                                             'Asignarle valores a la clase
                    .idusuario = Form1.lblId.Text
                    .idhuesped = cmbHuesped.SelectedValue.ToString
                    .idmesa = cmbNomesa.SelectedValue.ToString
                    .nosillas = txtNosillas.Text
                    .noboletos = txtNoboletos.Text
                    .observaciones = txtObservaciones.Text
                End With
                If registronuevo = True Then                                    'Establecer que es un registro nuevo
                    If clsreservacion.verificarSiexiste = True Then
                        MsgBox(registroexistente, MsgBoxStyle.Information, nombreaplicacion)
                        Exit Sub
                    Else
                        clsreservacion.agregar()                                'Agregar el registro
                    End If
                Else
                    With clsreservacion                                         'Asignarle los valores a la clase
                        .idhuespedmesa = DataGridViewX1.CurrentRow.Cells(0).Value
                        .modificar()
                    End With
                End If

                huesped = cmbHuesped.Text                                       'Obtener y asignar los valores para la impresión del ticket
                mesa = cmbNomesa.Text
                silla = txtNosillas.Text
                boletos = txtNoboletos.Text
                'MsgBox(huesped + " " + mesa + " " + silla + " " + boletos)
                imprimirTicket(huesped, mesa, sillas, boletos)                  'Impresión del ticket

                limpiarControles(GroupPanel1)
                habilitarControles(GroupPanel1, False)
                HabilitarBotones(btnNuevo, btnGuardar, btnModificar, btnEliminar, btnCancelar, True)
                actualizarDatatable()
                consultarDisponibilidad()
                clsxml.escribirXml()
                btnNuevo.Focus()

            End If
        End If
    End Sub

    Sub consultarDisponibilidad()
        conectar()
        tblDisponibilidad.Clear()
        adp = New SqlDataAdapter("consultarDisponibilidad", con)
        adp.SelectCommand.CommandType = CommandType.StoredProcedure
        adp.Fill(tblDisponibilidad)
        desconectar()
        enlacedisponibilidad.DataSource = tblDisponibilidad
        DataGridViewX2.DataSource = enlacedisponibilidad
        BindingNavigator2.BindingSource = enlacedisponibilidad
    End Sub

    Sub actualizarDatatable()
        consulta = "SELECT tblhuespedmesa.idhuespedmesa,tblhuesped.idhuesped, tblhuesped.nombre AS Huesped ,tblmesa.nomesa AS Mesa, tblhuespedmesa.nosillas AS Sillas, tblhuespedmesa.boletos AS Boletos,tblhuespedmesa.observaciones Observaciones " + _
        "FROM tblmesa INNER JOIN (tblhuesped INNER JOIN tblhuespedmesa ON tblhuesped.idhuesped = tblhuespedmesa.idhuesped) ON tblmesa.idmesa = tblhuespedmesa.idmesa " + _
        "WHERE tblhuespedmesa.estado = 1;"
        tblhuesped.Clear()
        adp = New SqlDataAdapter(consulta, conString)
        adp.Fill(tblhuesped)
        enlace.DataSource = tblhuesped
        DataGridViewX1.DataSource = enlace
        limpiarEnlaces()
        BindingNavigator1.BindingSource = enlace
        cmbHuesped.DataBindings.Add(New Binding("Text", enlace, "huesped"))
        cmbNomesa.DataBindings.Add(New Binding("Text", enlace, "mesa"))
        txtNosillas.DataBindings.Add(New Binding("Text", enlace, "sillas"))
        txtNoboletos.DataBindings.Add(New Binding("Text", enlace, "boletos"))
        txtObservaciones.DataBindings.Add(New Binding("Text", enlace, "observaciones"))
    End Sub

    Sub limpiarEnlaces()
        cmbHuesped.DataBindings.Clear()
        cmbNomesa.DataBindings.Clear()
        txtNosillas.DataBindings.Clear()
        txtNoboletos.DataBindings.Clear()
        txtObservaciones.DataBindings.Clear()
    End Sub

    Private Sub btnHuesped_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuesped.Click
    Dim frmhuesped As New frmHuesped
    frmhuesped.WindowState = FormWindowState.Normal
    frmhuesped.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
    frmhuesped.MaximizeBox = False
    frmhuesped.ShowDialog()
    clshuesped.llenarCombo(cmbHuesped)
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        Dim parametro As String = ""
        If rdbHuesped.Checked = True Then
            parametro = "huesped"
        ElseIf rdbNomesa.Checked Then
            parametro = "mesa"
        End If
        enlace.Filter = parametro + " LIKE '%" + txtBuscar.Text + "%'"
        If Me.DataGridViewX1.RowCount = 0 Then
            txtBuscar.BackColor = Color.Red
        Else
            txtBuscar.BackColor = Color.White
        End If
    End Sub

    Sub imprimirTicket(ByVal huesped As String, ByVal mesa As String, ByVal sillas As String, ByVal boletos As String)
        Try
            'Dim Hora As String
            'Hora = DateTime.Now.ToString("h:mm:ss")
            Fecha = DateTime.Now.ToString
            Dim Ticket1 As New CreaTicket()
            With Ticket1
                .impresora = "Epson TM-U220B"
                .TextoCentro("")
                .LineasIgual()
                .TextoCentro("")
                .TextoCentro("FIESTA PAQUETE DE FIN DE A" + Microsoft.VisualBasic.ChrW(165) + "O")
                .TextoCentro("XETULUL 2011")
                .TextoCentro("")
                .LineasIgual()
                .TextoCentro("")
                .TextoCentro("")

                .TextoIzquierda("Huesped : " + huesped)
                .TextoCentro("")
                .TextoIzquierda("No. de mesa : " + mesa)
                .TextoCentro("")
                .TextoIzquierda("No. de sillas : " + sillas)
                .TextoCentro("")
                .TextoIzquierda("Boletos : " + boletos)

                .TextoCentro("")
                .TextoCentro("")
                .LineasIgual()
                .TextoIzquierda("Fecha de impresi" + Microsoft.VisualBasic.ChrW(162) + "n : " + Fecha)
                '.TextoIzquierda("Hora de impresión : " + Hora)
                .TextoIzquierda("Persona que digit" + Microsoft.VisualBasic.ChrW(162) + " : " + Form1.lblUsuario.Text)
                .TextoCentro("")
                .TextoCentro("")
                .TextoCentro("")
                .TextoCentro("")
                .CortaTicket()
            End With
        Catch ex As Exception
            MsgBox("Ha ocurrido un error de impresión, verifique si esta encendida y si esta conectada correctamente", MsgBoxStyle.Critical, nombreaplicacion)
            Exit Sub
        End Try

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        HabilitarBotones(btnNuevo, btnGuardar, btnModificar, btnEliminar, btnCancelar, False)
        habilitarControles(GroupPanel1, True)
        registronuevo = False
        cmbHuesped.Focus()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        habilitarControles(GroupPanel1, False)
        limpiarControles(GroupPanel1)
        habilitarBotonsimples(btnNuevo, btnGuardar, btnCancelar, True)
        actualizarDatatable()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MsgBox("Desea eliminar el registro", MsgBoxStyle.YesNoCancel, nombreaplicacion) = MsgBoxResult.Yes Then
            With clsreservacion
                .idhuespedmesa = DataGridViewX1.SelectedCells(0).Value.ToString
                .eliminar()
            End With
            actualizarDatatable()
            consultarDisponibilidad()
        End If
    End Sub

    Private Sub txtObservaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObservaciones.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnGuardar.Focus()
            e.Handled = True
        End If
    End Sub

End Class