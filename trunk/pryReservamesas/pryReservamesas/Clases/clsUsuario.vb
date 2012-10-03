Imports System.Data.SqlClient
Public Class clsUsuario
    'Declaración de variables
    Dim cmd As SqlCommand
    Dim adp As SqlDataAdapter
    Dim consulta As String
    Dim tblusuario As New DataTable

    'Propiedades de la clase
    Private _idusuario As String
    Public Property idusuario() As String
        Get
            Return _idusuario
        End Get
        Set(ByVal value As String)
            _idusuario = value
        End Set
    End Property

    Private _apellidos As String
    Public Property apellidos() As String
        Get
            Return _apellidos
        End Get
        Set(ByVal value As String)
            _apellidos = value
        End Set
    End Property

    Private _nombres As String
    Public Property nombres() As String
        Get
            Return _nombres
        End Get
        Set(ByVal value As String)
            _nombres = value
        End Set
    End Property

    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _contrasena As String
    Public Property contrasena() As String
        Get
            Return _contrasena
        End Get
        Set(ByVal value As String)
            _contrasena = value
        End Set
    End Property

    Public Sub insertar()
        consulta = "INSERT INTO tblusuario(apellidos,nombres,usuario,contrasena)VALUES('" + apellidos + "','" + nombres + "'," + _
        "'" + usuario + "','" + contrasena + "');"
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
        consulta = "UPDATE tblusuario SET apellidos ='" + apellidos + "', nombres ='" + nombres + "', usuario ='" + usuario + "'," + _
        "contrasena ='" + contrasena + "' WHERE idusuario = " + idusuario + " AND estado = 1;"
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
        consulta = "UPDATE tblusuario SET estado = 0 WHERE idusuario =" + idusuario + " AND estado = 1;"
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
        consulta = "SELECT COUNT(*) FROM tblusuario WHERE usuario = '" + _usuario + "';"
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

    Public Function validarUsuario()
        consulta = "SELECT idusuario,apellidos,nombres FROM tblusuario WHERE usuario = '" + usuario + "' AND contrasena = '" + contrasena + "' AND estado = 1"
        'Console.WriteLine(consulta)
        Try
            conectar()
            adp = New SqlDataAdapter(consulta, conString)
            adp.Fill(tblusuario)
            desconectar()
            'MsgBox(tblusuario.Rows.Count)
        Catch ex As Exception
            MsgBox("Error al validar al usuario", MsgBoxStyle.Critical, nombreaplicacion)
        End Try
        Return tblusuario
    End Function


    'Public Function validarUsuario()
    '    Try
    '        consulta = "SELECT COUNT(*) FROM tblusuario WHERE usuario = '" + _usuario + "' AND contrasena = '" + _contrasena + "';"
    '        conectar()
    '        Dim cmd As New SqlCommand(consulta, con)
    '        Dim numReg As Integer = CInt(cmd.ExecuteScalar())
    '        If numReg > 0 Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '        desconectar()
    '    Catch ex As Exception
    '        MsgBox("Error al validar al usuario", MsgBoxStyle.Critical, nombreaplicacion)
    '        'MsgBox(ex.Message)
    '        Return False
    '    End Try
    'End Function

    'Public Function validar()
    '    consulta = "SELECT idusuario,apellidos,nombres FROM tblusuario WHERE usuario = '" + usuario + "' AND contrasena = '" + contrasena + " ' AND estado = 1"
    '    Try
    '        conectar()
    '        adp = New SqlDataAdapter(consulta, conString)
    '        adp.Fill(tblusuario)
    '        desconectar()
    '        'MsgBox(tblusuario.Rows.Count)
    '    Catch ex As Exception
    '        MsgBox("Error al validar al usuario", MsgBoxStyle.Critical, nombreaplicacion)
    '    End Try
    '    Return tblusuario
    'End Function

End Class
