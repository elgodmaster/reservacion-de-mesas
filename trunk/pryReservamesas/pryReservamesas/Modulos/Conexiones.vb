Imports System.Data.SqlClient
Imports System.Xml
Module Conexiones

    Public con As SqlConnection
    'Public conString As String = "Data Source=COMPUTOHOSTALES\SQLEXPRESS;Initial Catalog=bdreservaciones;Persist Security Info=True;User ID=sa;Password=mandrake"
    Public conString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=bdreservaciones;Integrated Security=True"
    'Public conString As String = generarCadena()
    Dim origen As String = ""
    Dim instancia As String = ""
    Dim bd As String = ""
    Dim usuario As String = ""
    Dim password As String = ""

    Sub conectar()
        Try
            con = New SqlConnection(conString)
            con.Open()
        Catch ex As Exception
            MsgBox("Error de conexion con el servidor", MsgBoxStyle.Critical, nombreaplicacion)
            Exit Sub
        End Try
    End Sub

    Sub desconectar()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Function generarCadena() As String
        Dim xml As New XmlDocument
        Dim listadenodos As XmlNodeList
        Dim nodo As XmlNode
        xml.Load(My.Application.Info.DirectoryPath.ToString() + "\configcon.xml")
        listadenodos = xml.SelectNodes("/servidor/origen")
        For Each nodo In listadenodos
            origen = nodo.ChildNodes.Item(0).InnerText
        Next
        listadenodos = xml.SelectNodes("/servidor/instancia")
        For Each nodo In listadenodos
            instancia = nodo.ChildNodes.Item(0).InnerText
        Next
        listadenodos = xml.SelectNodes("/servidor/bd")
        For Each nodo In listadenodos
            bd = nodo.ChildNodes.Item(0).InnerText
        Next
        listadenodos = xml.SelectNodes("/servidor/usuario")
        For Each nodo In listadenodos
            usuario = nodo.ChildNodes.Item(0).InnerText
        Next
        listadenodos = xml.SelectNodes("/servidor/password")
        For Each nodo In listadenodos
            password = nodo.ChildNodes.Item(0).InnerText
        Next
        conString = "Data Source=" + origen + "\" + instancia + ";Initial Catalog=" + bd + ";User Id=" + usuario + ";Password=" + password + ";"
        Return conString
    End Function

End Module