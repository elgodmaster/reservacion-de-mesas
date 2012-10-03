Imports System.Data.SqlClient
Public Class Form1
    'Formularios
    Dim frmhuesped As frmHuesped
    Dim frmmesas As frmMesas
    Dim frmreservacion As frmReservacion
    Dim frmconsulta As New frmConsulta
    Dim frmreporte As New frmReporte
    Dim frmusuario As New frmUsuario
    Dim frmmenureportes As New frmMenureportes
    Dim frmlogin As frmLogin
    Dim xml As New clsXml
    'Declaración de variables
    Dim tabla As New DataTable
    Dim adp As SqlDataAdapter
    Dim consulta As String

    Private Sub btnHuesped_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuesped.Click
        If frmhuesped Is Nothing OrElse Not frmhuesped.Visible Then
            frmhuesped = New frmHuesped
            frmhuesped.MdiParent = Me
            Me.SplitContainer1.Panel2.Controls.Add(frmhuesped)
            frmhuesped.Show()
        Else
            MsgBox("Este formulario ya esta abierto", MsgBoxStyle.Information, nombreaplicacion)
            Exit Sub
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnMesas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMesas.Click
        If frmmesas Is Nothing OrElse Not frmmesas.Visible Then
            frmmesas = New frmMesas
            frmmesas.MdiParent = Me
            Me.SplitContainer1.Panel2.Controls.Add(frmmesas)
            frmmesas.Show()
        Else
            MsgBox("Este formulario ya esta abierto", MsgBoxStyle.Information, nombreaplicacion)
            Exit Sub
        End If
    End Sub

    Private Sub btnReservacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservacion.Click
        If frmreservacion Is Nothing OrElse Not frmreservacion.Visible Then
            frmreservacion = New frmReservacion
            frmreservacion.MdiParent = Me
            Me.SplitContainer1.Panel2.Controls.Add(frmreservacion)
            frmreservacion.Show()
        Else
            MsgBox("Este formulario ya esta abierto", MsgBoxStyle.Information, nombreaplicacion)
            Exit Sub
        End If
    End Sub

    Private Sub btnConsultas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultas.Click
        If frmconsulta Is Nothing OrElse Not frmconsulta.Visible Then
            frmconsulta = New frmConsulta
            frmconsulta.MdiParent = Me
            Me.SplitContainer1.Panel2.Controls.Add(frmconsulta)
            frmconsulta.Show()
        Else
            MsgBox("Este formulario ya esta abierto", MsgBoxStyle.Information, nombreaplicacion)
            Exit Sub
        End If
    End Sub

    Private Sub btnReportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportes.Click
    If frmmenureportes Is Nothing OrElse Not frmmenureportes.Visible Then
      frmmenureportes = New frmMenureportes
      frmmenureportes.MdiParent = Me
      Me.SplitContainer1.Panel2.Controls.Add(frmmenureportes)
      frmmenureportes.Show()
    Else
      MsgBox("Este formulario ya esta abierto", MsgBoxStyle.Information, nombreaplicacion)
      Exit Sub
    End If
  End Sub

    Private Sub LlenarElReporte()
        Try
            consulta = "SELECT tblhuespedmesa.idhuespedmesa,tblhuesped.idhuesped, tblhuesped.nombre AS HUESPED ,tblmesa.nomesa AS MESA, tblhuespedmesa.nosillas AS SILLAS, tblhuespedmesa.boletos AS BOLETOS,tblhuespedmesa.observaciones OBSERVACIONES " + _
            "FROM tblmesa INNER JOIN (tblhuesped INNER JOIN tblhuespedmesa ON tblhuesped.idhuesped = tblhuespedmesa.idhuesped) ON tblmesa.idmesa = tblhuespedmesa.idmesa " + _
            "WHERE tblhuespedmesa.estado = 1;"
            Console.WriteLine(consulta)
            tabla.Clear()
            conectar()
            adp = New SqlDataAdapter(consulta, con)
            adp.Fill(tabla)
            desconectar()
            Dim reporte As New rptListado
            frmreporte = New frmReporte
            reporte.SetDataSource(tabla)
            frmreporte.CrystalReportViewer1.ReportSource = reporte
            frmreporte.Show()
        Catch ex As Exception
            MsgBox("Seleccione un reporte", MsgBoxStyle.Information, nombreaplicacion)
            Exit Sub
        End Try
    End Sub

    Private Sub btnUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuario.Click
        If frmusuario Is Nothing OrElse Not frmusuario.Visible Then
            frmusuario = New frmUsuario
            frmusuario.MdiParent = Me
            Me.SplitContainer1.Panel2.Controls.Add(frmusuario)
            frmusuario.Show()
        Else
            MsgBox("Este formulario ya esta abierto", MsgBoxStyle.Information, nombreaplicacion)
            Exit Sub
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frmlogin = New frmLogin
        frmlogin.ShowDialog()
        'Me.lblId.Text = tblUsuario.Rows(0)(0).ToString
        'Me.lblUsuario.Text = tblUsuario.Rows(1)(1).ToString + " " + tblUsuario.Rows(1)(2).ToString
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub btnCerrarsesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarsesion.Click
        lblUsuario.Text = "Nombre del usuario"
        frmlogin = New frmLogin
        frmlogin.ShowDialog()
    End Sub

    Private Sub btnXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXml.Click
        xml.escribirXml()
    MsgBox("Plano Actualizado!!!", MsgBoxStyle.Information, nombreaplicacion)
    End Sub

End Class
