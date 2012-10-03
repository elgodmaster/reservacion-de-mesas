Imports System.Data.SqlClient
Imports LibPrintTicketMatriz.Class1
Public Class frmConsulta
    'Declaración de variables
    Dim consulta As String
    Dim tblhuesped As New DataTable
    Dim adp As SqlDataAdapter
    Dim enlace As New BindingSource
    'Dim rptTicket As New rptTicket
    Dim huesped, mesa, sillas, boletos, Fecha As String
    Dim configuracion = New Printing.PrinterSettings

    Private Sub frmConsulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        consulta = "SELECT tblhuesped.nombre AS Huesped,tblhuesped.habitacion Habitación ,CAST(tblmesa.nomesa AS VARCHAR(5)) AS Mesa,tblhuespedmesa.nosillas AS Sillas, tblhuespedmesa.boletos AS Boletos,tblhuespedmesa.observaciones Observaciones " + _
       "FROM tblmesa INNER JOIN (tblhuesped INNER JOIN tblhuespedmesa ON tblhuesped.idhuesped = tblhuespedmesa.idhuesped) ON tblmesa.idmesa = tblhuespedmesa.idmesa " + _
       "WHERE tblhuespedmesa.estado = 1;"
        Console.WriteLine(consulta)
        tblhuesped.Clear()
        adp = New SqlDataAdapter(consulta, conString)
        adp.Fill(tblhuesped)
        enlace.DataSource = tblhuesped
        DataGridViewX1.DataSource = enlace
        BindingNavigator1.BindingSource = enlace
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        Dim parametro As String = ""
        If rdbNombre.Checked = True Then
            parametro = "huesped"
        ElseIf rdbMesa.Checked Then
            parametro = "mesa"
        End If
        enlace.Filter = parametro + " LIKE '%" + txtBuscar.Text.ToString + "%'"
        If Me.DataGridViewX1.RowCount = 0 Then
            txtBuscar.BackColor = Color.Red
        Else
            txtBuscar.BackColor = Color.White
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        huesped = DataGridViewX1.SelectedCells(0).Value
        mesa = DataGridViewX1.SelectedCells(2).Value
        sillas = DataGridViewX1.SelectedCells(3).Value
        boletos = DataGridViewX1.SelectedCells(4).Value
        Try
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
                .TextoCentro("T I C K E T  R E I M P R E S O")
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

    Sub imprimirTicket(ByVal huesped As String, ByVal mesa As String, ByVal sillas As String, ByVal boletos As String)
        
    End Sub

End Class