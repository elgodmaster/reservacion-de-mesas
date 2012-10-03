Imports System.Data.SqlClient
Public Class clsHuesped

    'Declaración de variables
    Dim cmd As SqlCommand
    Dim adp As SqlDataAdapter
    Dim consulta As String

    'Propiedades de la clase
    Private _idhuesped As String
    Public Property idhuesped() As String
        Get
            Return _idhuesped
        End Get
        Set(ByVal value As String)
            _idhuesped = value
        End Set
    End Property

    Private _Nombre As String
    Public Property nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Private _Habitacion As String
    Public Property habitacion() As String
        Get
            Return _Habitacion
        End Get
        Set(ByVal value As String)
            _Habitacion = value
        End Set
    End Property

    'Métodos

    Public Sub insertar()
        consulta = "INSERT INTO tblhuesped (nombre,habitacion) VALUES('" + nombre + "','" + habitacion + "');"
        conectar()
        cmd = New SqlCommand(consulta, con)
        If cmd.ExecuteNonQuery > 0 Then
            MsgBox(registroalmacenado, MsgBoxStyle.Information, nombreaplicacion)
        Else
            MsgBox(erroralalmacenar, MsgBoxStyle.Critical, nombreaplicacion)
            Exit Sub
        End If
        desconectar()
    End Sub

    Public Sub modificar()
        conectar()
        consulta = "UPDATE tblhuesped SET nombre ='" + nombre + "', habitacion ='" + habitacion + "' WHERE idhuesped = " + idhuesped + "" + _
        " AND estado = 1;"
        cmd = New SqlCommand(consulta, con)
        If cmd.ExecuteNonQuery > 0 Then
            MsgBox(registromodificado, MsgBoxStyle.Information, nombreaplicacion)
        Else
            MsgBox(erroralmodificar, MsgBoxStyle.Critical, nombreaplicacion)
            Exit Sub
        End If
        desconectar()
    End Sub

    Public Sub eliminar()
        conectar()
        consulta = "UPDATE tblhuesped SET estado = 0 WHERE idhuesped = " + idhuesped + " AND estado = 1;"
        cmd = New SqlCommand(consulta, con)
        If cmd.ExecuteNonQuery > 0 Then
            MsgBox(registroeliminado, MsgBoxStyle.Information, nombreaplicacion)
        Else
            MsgBox(erroraaleliminar, MsgBoxStyle.Critical, nombreaplicacion)
            Exit Sub
        End If
        desconectar()
    End Sub

    Public Function existe()
        consulta = "SELECT COUNT(*) FROM tblhuesped WHERE nombre = '" + nombre + "' AND estado = 1;"
        conectar()
        Dim cmd As New SqlCommand(consulta, con)
        Dim numReg As Integer = CInt(cmd.ExecuteScalar())
        If numReg > 0 Then
            Return True
        Else
            Return False
        End If
        desconectar()
        Return False
    End Function

    Sub llenarCombo(ByVal combo As DevComponents.DotNetBar.Controls.ComboBoxEx)
        Dim consultarHuespedes As String = "SELECT idhuesped, nombre FROM tblhuesped WHERE estado = 1"
        Dim tblhuesped As New DataTable
        conectar()
        Dim adtpPaciente As New SqlDataAdapter(consultarHuespedes, con)
        adtpPaciente.Fill(tblhuesped)
        desconectar()
        With combo
            .DataSource = tblhuesped
            .DisplayMember = "nombre"
            .ValueMember = "idhuesped"
        End With
    End Sub

End Class
