﻿Imports System.Configuration
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class vistaLogin
	Public funciones As New Funciones
	Public conexion As New Conexion
	Public tipoUser As String = ""
	Public usuarioEncriptado As String = Nothing
	Private passwordEncriptada As String = Nothing
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If (txtNombre.Text = "") Then
			MsgBox("Introduzca Usuario", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Error!")
		ElseIf (txtPassword.Text = "") Then
			MsgBox("Introduzca Contraseña", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Error!")
		Else
			conectarUsuario()
		End If
	End Sub

	Sub conectarUsuario()
		Dim dbUser As String = ""
		Dim dbPass As String = ""
		Dim datosUser(2) As String
		usuarioEncriptado = MD5EncryptPass(txtNombre.Text)
		passwordEncriptada = MD5EncryptPass(txtPassword.Text)

		Dim query As String = "SELECT cDni,cContrasena,cTipoUsuario FROM tAdministradores WHERE cDni='" & usuarioEncriptado & "' AND  cContrasena='" & passwordEncriptada & "'"
		datosUser = funciones.dataReader(query)
		dbUser = datosUser(0)
		dbPass = datosUser(1)
		If (usuarioEncriptado = dbUser And passwordEncriptada = dbPass) Then
            'MsgBox("Conectado Satisfactoriamente", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton2, "¡Login!")
            tipoUser = datosUser(2)
			Me.Hide()
			MenuGestion.Show()
		Else
			MsgBox("Usuario Incorrecto", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton2, "¡Error!")
		End If
	End Sub

	Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
		Application.ExitThread()
	End Sub

    Public Function MD5EncryptPass(ByVal StrPass As String)
        Dim md5 As MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim pwEncriptada As String = Nothing
        Dim i As Integer

        md5 = New MD5CryptoServiceProvider
        bytValue = System.Text.Encoding.UTF8.GetBytes(StrPass)
        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()
        For i = 0 To bytHash.Length - 1
            pwEncriptada &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next
        Return pwEncriptada
    End Function

    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then

            If (txtNombre.Text = "") Then
                MsgBox("Introduzca Usuario", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Error!")
            ElseIf (txtPassword.Text = "") Then
                MsgBox("Introduzca Contraseña", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Error!")
            Else
                conectarUsuario()
            End If

        End If
    End Sub
End Class