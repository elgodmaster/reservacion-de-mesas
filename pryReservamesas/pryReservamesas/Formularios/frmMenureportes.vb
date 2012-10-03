Imports System.Data.SqlClient
Public Class frmMenureportes
    Dim frmreporte As New frmReporte
    Dim nodo As String
    Dim cmd As SqlCommand
    Dim adp As SqlDataAdapter
    Dim tabla As New DataTable
    Dim consulta As String
    Dim procedimiento As String
    Dim reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private Sub frmMenureportes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TreeView1.ExpandAll()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        nodo = TreeView1.SelectedNode.Name
        Select Case nodo
            Case "nodListadofinalhuesped"
                procedimiento = "consultarMesasporhuesped"
                reporte = New rptListado
            Case "nodCantidadvendida"
                procedimiento = "consultarVendidas_disponibles"
                reporte = New rptVendidas_disponibles
            Case "nodListadofinalmesa"
                procedimiento = "consultarMesaspormesa"
                reporte = New rptListado
        End Select
        LlenarElReporte()
    End Sub

    Private Sub LlenarElReporte()
        Try
            tabla.Clear()
            conectar()
            adp = New SqlDataAdapter(procedimiento, con)
            adp.Fill(tabla)
            desconectar()
            reporte.SetDataSource(tabla)
            frmreporte = New frmReporte
            frmreporte.CrystalReportViewer1.ReportSource = reporte
            frmreporte.Show()
        Catch ex As Exception
            MsgBox("Seleccione un reporte", MsgBoxStyle.Information, nombreaplicacion)
            Exit Sub
        End Try
    End Sub
End Class