Imports System.Data.SqlClient
Public Class clsReservacion
    'Declaración de variables
    Dim consulta As String
    Dim cmd As SqlCommand
    Dim adp As SqlDataAdapter

    'Propiedades de la clase
    Private _idhuesdpedmesa As String
    Public Property idhuespedmesa() As String
        Get
            Return _idhuesdpedmesa
        End Get
        Set(ByVal value As String)
            _idhuesdpedmesa = value
        End Set
    End Property
    Private _idusuario As String
    Public Property idusuario() As String
        Get
            Return _idusuario
        End Get
        Set(ByVal value As String)
            _idusuario = value
        End Set
    End Property

    Private _idhuesped As String
    Public Property idhuesped() As String
        Get
            Return _idhuesped
        End Get
        Set(ByVal value As String)
            _idhuesped = value
        End Set
    End Property

    Private _idmesa As String
    Public Property idmesa() As String
        Get
            Return _idmesa
        End Get
        Set(ByVal value As String)
            _idmesa = value
        End Set
    End Property
    Private _nosillas As String
    Public Property nosillas() As String
        Get
            Return _nosillas
        End Get
        Set(ByVal value As String)
            _nosillas = value
        End Set
    End Property
    Private _noboletos As String
    Public Property noboletos() As String
        Get
            Return _noboletos
        End Get
        Set(ByVal value As String)
            _noboletos = value
        End Set
    End Property
    Private _reserva As String
    Public Property reserva() As String
        Get
            Return _reserva
        End Get
        Set(ByVal value As String)
            _reserva = value
        End Set
    End Property
    Private _fecha As String
    Public Property fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property

    Private _observaciones As String
    Public Property observaciones() As String
        Get
            Return _observaciones
        End Get
        Set(ByVal value As String)
            _observaciones = value
        End Set
    End Property



    'Métodos
    Public Sub agregar()
        consulta = "INSERT INTO tblhuespedmesa (idusuario,idhuesped,idmesa,nosillas,boletos,observaciones)VALUES(" + idusuario + "," + idhuesped + "," + idmesa + "," + nosillas + ",'" + _
        _noboletos + "','" + observaciones + "');"
        Console.WriteLine(consulta)
        conectar()
        cmd = New SqlCommand(consulta, con)
        cmd.ExecuteNonQuery()
        desconectar()
        MsgBox(registroalmacenado, MsgBoxStyle.Information, nombreaplicacion)
    End Sub

    Public Sub modificar()
        consulta = "UPDATE tblhuespedmesa SET idhuesped = '" + idhuesped + "', idmesa = '" + idmesa + "', nosillas = '" + nosillas + "', boletos = '" + noboletos + "' " + _
        "WHERE idhuespedmesa = " + idhuespedmesa
        conectar()
        cmd = New SqlCommand(consulta, con)
        cmd.ExecuteNonQuery()
        desconectar()
        MsgBox(registromodificado, MsgBoxStyle.Information, nombreaplicacion)
    End Sub

    Public Sub eliminar()
        consulta = "UPDATE tblhuespedmesa set estado = 0 WHERE idhuespedmesa = " + idhuespedmesa + " AND estado = 1;"
        conectar()
        cmd = New SqlCommand(consulta, con)
        cmd.ExecuteNonQuery()
        desconectar()
        MsgBox(registroeliminado, MsgBoxStyle.Information, nombreaplicacion)
    End Sub

    Public Function verificarSiexiste()
        consulta = "SELECT COUNT(*) FROM tblhuespedmesa WHERE idhuesped = " + _idhuesped + " AND idmesa = " + _idmesa + " AND boletos = '" + _noboletos + "' AND estado = 1"
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



End Class
