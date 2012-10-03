Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports DevComponents.DotNetBar.ButtonX

Module ModuloPrincipal

    'Programador: José Miguel Tojil Gento
    'Fecha: lunes 23 de Noviembre de 2009
    'Hora: 21:00
    'Modulo de principal de funciones
    'En este modulo se declararon las funciones mas comunes con los controles de un formulario

    'Declaración de variables
    Public nombreaplicacion As String = "Sistema de reservación de mesas"

    Public Sub habilitarControles(ByVal grupoControl As Control, ByVal estado As Boolean)

        Dim ctrl As Control
        For Each ctrl In grupoControl.Controls          'Recorrer todos los controles del control

            If TypeOf (ctrl) Is TextBox Then        'Verificar si es un textbox
                ctrl.Enabled = estado                     'Habilitarla
            End If

            If TypeOf (ctrl) Is DevComponents.DotNetBar.Controls.TextBoxX Then            'Verificar si es caja de texto
                ctrl.Enabled = estado                     'Habilitarla
            End If

            If TypeOf (ctrl) Is DevComponents.DotNetBar.Controls.ComboBoxEx Then            'Verificar si es un combo
                ctrl.Enabled = estado                     'Habilitarla
            End If

            If TypeOf (ctrl) Is MaskedTextBox Then        'Verificar si es una mascara
                ctrl.Enabled = estado                     'Habilitarla
            End If

            If TypeOf (ctrl) Is CheckBox Then             'Verificar si es un checkbox
                ctrl.Enabled = estado                     'Habilitarla
            End If

            If TypeOf (ctrl) Is DevComponents.Editors.DateTimeAdv.DateTimeInput Then
                ctrl.Enabled = estado
            End If

            If TypeOf (ctrl) Is DevComponents.DotNetBar.ButtonX Then
                ctrl.Enabled = estado
            End If

            If TypeOf (ctrl) Is DateTimePicker Then      'Verificar si es datetimepicker
                ctrl.Enabled = estado                         'Habilitarla
            End If


            'If TypeOf (ctrl) Is DevComponents.DotNetBar.Controls Then             'Verificar si es un checkbox
            '    ctrl.Enabled = estado                           'Habilitarla
            'End If

            'If TypeOf (ctrl) Is DevComponents.DotNetBar.ButtonX Then             'Verificar si es un checkbox
            '    ctrl.Enabled = estado                           'Habilitarla
            'End If

        Next

    End Sub

    Public Sub limpiarControles(ByVal grupoControl As Control)

        Dim ctrl As Control
        For Each ctrl In grupoControl.Controls          'Recorrer todos los controles del control

            If TypeOf (ctrl) Is TextBox Then        'Verificar si es un textbox
                ctrl.Text = ""                     'Limpiarla
            End If

            If TypeOf (ctrl) Is DevComponents.DotNetBar.Controls.TextBoxX Then            'Verificar si es caja de texto
                ctrl.Text = ""                          'Limpiarla
            End If

            If TypeOf (ctrl) Is DevComponents.DotNetBar.Controls.ComboBoxEx Then            'Verificar si es caja de combo
                ctrl.Text = ""                          'Limpiarla
            End If

            If TypeOf (ctrl) Is MaskedTextBox Then      'Verificar si es caja de mascara de texto
                ctrl.Text = ""                          'Limpiarla
            End If

            'If TypeOf (ctrl) Is DateTimePicker Then      'Verificar si es datetimepicker
            '    ctrl.Text = ""                          'Limpiarla
            'End If

            If TypeOf (ctrl) Is DevComponents.DotNetBar.Controls.TextBoxX Then            'Verificar si es caja de texto
                ctrl.Text = ""
            End If

            If TypeOf (ctrl) Is DevComponents.DotNetBar.Controls.ComboBoxEx Then            'Verificar si es un combo
                ctrl.Text = ""
            End If

            'If TypeOf (ctrl) Is DevComponents.Editors.DateTimeAdv.DateTimeInput Then
            '    ctrl.Text = ""
            'End If

        Next

    End Sub

    Public Function verificarCamposenblanco(ByVal grupoControl As Control, ByVal ep As ErrorProvider) As Boolean
        Dim estado As Boolean = False
        Dim ctrl As Control
        For Each ctrl In grupoControl.Controls          'Recorrer todos los controles del control

            If TypeOf (ctrl) Is TextBox Then            'Verificar si es caja de texto

                If ctrl.Name = "txtObservaciones" Then
                    estado = False
                Else
                    If ctrl.Text = "" Then                  'Verificar campo en blanco
                        estado = True
                        ep.SetError(ctrl, "Escriba algo aquí")
                    End If
                End If

            End If

            If TypeOf (ctrl) Is ComboBox Then            'Verificar si es un combo

                If ctrl.Text = "" Then                  'Verificar campo en blanco
                    estado = True
                    ep.SetError(ctrl, "Seleccione algun valor")
                End If

            End If
        Next
        Return estado
    End Function

    Public Function MostrarVentanadialogo(ByVal mensaje As String) As Boolean
        If MsgBox(mensaje, MsgBoxStyle.YesNoCancel, nombreaplicacion) = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub HabilitarBotones(ByVal btnNuevo As DevComponents.DotNetBar.ButtonX, ByVal btnGuardar As DevComponents.DotNetBar.ButtonX, ByVal btnModificar As DevComponents.DotNetBar.ButtonX, ByVal btnEliminar As DevComponents.DotNetBar.ButtonX, ByVal btnCancelar As DevComponents.DotNetBar.ButtonX, ByVal estado As Boolean)
        If estado = False Then
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
            estado = False
        Else
            estado = True
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False
        End If
        btnNuevo.Enabled = estado
        btnModificar.Enabled = estado
        btnEliminar.Enabled = estado
    End Sub

    Public Sub habilitarBotonsimples(ByVal btnNuevo As DevComponents.DotNetBar.ButtonX, ByVal btnGuardar As DevComponents.DotNetBar.ButtonX, ByVal btnCancelar As DevComponents.DotNetBar.ButtonX, ByVal estado As Boolean)
        If estado = False Then
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
            estado = False
        Else
            estado = True
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False
        End If
        btnNuevo.Enabled = estado
    End Sub

    Public Function EsInteger(ByVal theValue As String) As Boolean
        'funcion para enteros
        Try
            If CType(theValue, Integer) <= 0 Then
                Return False
            Else
                Convert.ToInt32(theValue)
                Return True
            End If
        Catch
            Return False
        End Try
    End Function

    Public Function EsDecimal(ByVal theValue As String) As Boolean
        'funcion para enteros
        Try
            If CType(theValue, Integer) <= 0 Then
                Return False
            Else
                Convert.ToDecimal(theValue)
                Return True
            End If
            
        Catch
            Return False
        End Try
    End Function

End Module
