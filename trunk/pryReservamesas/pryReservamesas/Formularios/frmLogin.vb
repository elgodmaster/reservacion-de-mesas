Public Class frmLogin
    'Clases
    Dim clsusuario As New clsUsuario
    Dim tblusuario As New DataTable

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        My.Application.ApplicationContext.MainForm.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        validarUsuario()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtUsuario.Focus()
        txtUsuario.Focus()
    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            txtContrasena.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtContrasena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContrasena.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            validarUsuario()
            e.Handled = True
        End If
    End Sub

    Sub validarUsuario()
        If (verificarCamposenblanco(GroupPanel1, ErrorProvider1) = True) Then
            MsgBox(camposenblanco, MsgBoxStyle.Information, nombreaplicacion)
            Exit Sub
        Else
            With clsusuario
                .usuario = txtUsuario.Text
                .contrasena = txtContrasena.Text
            End With
            tblusuario = clsusuario.validarUsuario
            If (tblusuario.Rows.Count > 0) Then
                Form1.lblId.Text = tblusuario.Rows(0)(0).ToString
                Form1.lblUsuario.Text = tblusuario.Rows(0)(2).ToString + " " + tblusuario.Rows(0)(1).ToString
                Me.Close()
            Else
                MsgBox("El usuario o el password son incorrectos!!!!", MsgBoxStyle.Critical, nombreaplicacion)
                Exit Sub
            End If
        End If
    End Sub

End Class
