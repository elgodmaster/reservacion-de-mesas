Imports System.Data.SqlClient
Public Class clsMesa

    Dim consulta As String
    Dim cmd As SqlCommand

    Private _idmesa As String
    Public Property idmesa() As String
        Get
            Return _idmesa
        End Get
        Set(ByVal value As String)
            _idmesa = value
        End Set
    End Property

    Private _idcategoria As String
    Public Property idcategoria() As String
        Get
            Return _idcategoria
        End Get
        Set(ByVal value As String)
            _idcategoria = value
        End Set
    End Property

    Private _nomesa As String
    Public Property nomesa() As String
        Get
            Return _nomesa
        End Get
        Set(ByVal value As String)
            _nomesa = value
        End Set
    End Property

    Private _llena As Boolean
    Public Property llena() As Boolean
        Get
            Return _llena
        End Get
        Set(ByVal value As Boolean)
            _llena = value
        End Set
    End Property

    Public Function existe()
        consulta = "SELECT COUNT(*) FROM tblmesa WHERE nomesa = " + _nomesa + " AND estado = 1;"
        conectar()
        Dim cmd As New SqlCommand(consulta, con)
        Dim numReg As Integer = CInt(cmd.ExecuteScalar())
        If numReg > 0 Then
            Return True
        Else
            Return False
        End If
        desconectar()
    End Function

    Public Sub insertar()
        consulta = "INSERT INTO tblmesa (idcategoria,nomesa)VALUES('" + _idcategoria + "','" + _nomesa + "');"
        conectar()
        cmd = New SqlCommand(consulta, con)
        cmd.ExecuteNonQuery()
        desconectar()
        MsgBox(registroalmacenado, MsgBoxStyle.Information, nombreaplicacion)
    End Sub

    Public Sub modificar()
        consulta = "UPDATE tblmesa SET idcategoria = " + _idcategoria + ", nomesa = '" + _nomesa + "' WHERE idmesa = " + _idmesa + ";"
        conectar()
        cmd = New SqlCommand(consulta, con)
        cmd.ExecuteNonQuery()
        desconectar()
        MsgBox(registromodificado, MsgBoxStyle.Information, nombreaplicacion)
    End Sub

    Public Sub eliminar()
        consulta = "UPDATE tblmesa SET estado = 0 WHERE idmesa = " + _idmesa + ";"
        conectar()
        cmd = New SqlCommand(consulta, con)
        cmd.ExecuteNonQuery()
        desconectar()
        MsgBox(registroeliminado, MsgBoxStyle.Information, nombreaplicacion)
    End Sub

    Sub llenarCombocategoria(ByVal combo As DevComponents.DotNetBar.Controls.ComboBoxEx)
        Dim consultarMesas As String = "SELECT idcategoria, categoria FROM tblcategoria WHERE estado = 1"
        Dim tblcategoria As New DataTable
        conectar()
        Dim adp As New SqlDataAdapter(consultarMesas, con)
        adp.Fill(tblcategoria)
        desconectar()
        With combo
            .DataSource = tblcategoria
            .DisplayMember = "categoria"
            .ValueMember = "idcategoria"
        End With
    End Sub

    Public Function capacidad(ByVal idmesa As String)
        consulta = "SELECT D.disponibilidad FROM " + _
        "( " + _
        "SELECT A.idmesa, A.nomesa MESA,A.sillas CAPACIDAD,ISNULL(B.sillas,'')OCUPADAS, ISNULL((A.sillas - B.sillas),A.sillas) DISPONIBILIDAD FROM " + _
        "( " + _
        "SELECT M.idmesa idmesa,M.nomesa, C.sillas sillas FROM tblmesa AS M " + _
        "INNER JOIN tblcategoria AS C " + _
        "ON M.idcategoria = C.idcategoria " + _
        "GROUP BY M.idmesa,sillas,M.nomesa " + _
        ")AS A " + _
        "FULL OUTER JOIN " + _
        "( " + _
        "SELECT idmesa,SUM(nosillas) sillas FROM tblhuespedmesa VENDIDAS WHERE VENDIDAS.estado = 1 GROUP BY idmesa " + _
        ") AS B " + _
        "ON A.idmesa = B.idmesa " + _
        ") AS D " + _
        "WHERE D.idmesa = " + idmesa + " ;"
        'Console.WriteLine(consulta)
        conectar()
        Dim cmd As New SqlCommand(consulta, con)
        Dim sillas As Integer = CInt(cmd.ExecuteScalar())
        Return sillas
    End Function

End Class
