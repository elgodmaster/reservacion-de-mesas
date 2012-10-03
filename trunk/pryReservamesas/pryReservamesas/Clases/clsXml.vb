Imports System.Data.SqlClient
Public Class clsXml

    Public Sub escribirXml()
        Try
            Dim tbldisponibilidad As New DataSet
            Dim adp As SqlDataAdapter
            conectar()
            tbldisponibilidad.Clear()
            tbldisponibilidad.DataSetName = "datos"
            adp = New SqlDataAdapter("consultarDisponibilidad", con)
            adp.SelectCommand.CommandType = CommandType.StoredProcedure
            adp.Fill(tbldisponibilidad, "tblmesa")
            desconectar()
            'If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\xml") Then
            '    My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\xml")
            'End If
            'tbldisponibilidad.WriteXml(Application.StartupPath & "\xml\" & "disponibilidad" & ".xml", XmlWriteMode.IgnoreSchema)
            tbldisponibilidad.WriteXml("X:\" & "disponibilidad" & ".xml", XmlWriteMode.IgnoreSchema)
        Catch ex As Exception
            MsgBox("Actualizar el plano", MsgBoxStyle.Information, nombreaplicacion)
            Exit Sub
        End Try
    End Sub

End Class
