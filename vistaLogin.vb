Imports System.Configuration
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class vistaLogin
	Public usuario, password As String
	Public conexion As New Conexion
	'Public con As New MySqlConnection("Server=192.168.101.24; Database=alojamientos; Uid=grupoAlojamientos; Pwd=123456")
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		usuario = txtNombre.Text
		password = txtPassword.Text
		If usuario = Nothing And password = Nothing Then
			MsgBox("Error, Rellene los campos")
		Else
			conectarUsuario()
		End If


	End Sub

	Sub conectarUsuario()

		'Dim dni As String = ConfigurationManager.AppSettings.Get("Admin")
		'Dim password As String = ConfigurationManager.AppSettings.Get("Password")
		usuario = txtNombre.Text
		password = txtPassword.Text

		Dim dbUser
		Dim dbPass
		Dim tipoUser
		Try

			If (usuario = "") Then
				MsgBox("Introduzca Usuario", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Error!")
			ElseIf (password = "") Then
				MsgBox("Introduzca Contraseña", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "¡Error!")
			Else

				Dim usuarioEncriptado As String = MD5EncryptPass(usuario)
				Dim passwordEncriptada As String = MD5EncryptPass(password)
				Dim query As String = "SELECT cDni,cContrasena,cTipoUsuario FROM tAdministradores WHERE cDni='" & usuarioEncriptado & "' AND  cContrasena='" & passwordEncriptada & "'"

				conexion.con.Open()
				Dim cmd As New MySqlCommand(query, conexion.con)
				'adapterUsuario.
				Dim reader As MySqlDataReader = cmd.ExecuteReader()
				While reader.Read()
					dbUser = reader("cDni").ToString()
					Console.WriteLine("pass ><<<<<<<<<<<<<<<<<<<<<<<<<<")
					dbPass = reader("cContrasena").ToString()
					tipoUser = reader("cTipoUsuario").ToString()



				End While
				Console.WriteLine("hola user" & dbUser)
				Console.WriteLine("hola pp" & dbPass)

				conexion.con.Close()

				If (usuarioEncriptado = dbUser And passwordEncriptada = dbPass) Then
					MsgBox("Conectado Satisfactoriamente", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton2, "¡Login!")
					Me.Hide()
					MenuGestion.Show()
				Else

					MsgBox("Usuario Incorrecto", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton2, "¡Error!")
				End If
			End If
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)
		End Try
	End Sub

	Private Sub VistaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim conexion As New Conexion
		conexion.Conectar()
	End Sub

	Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
		Application.ExitThread()
	End Sub

	Public Function MD5EncryptPass(ByVal StrPass As String)
		Dim md5 As MD5CryptoServiceProvider
		Dim bytValue() As Byte
		Dim bytHash() As Byte
		Dim contraEncriptada As String
		Dim i As Integer
		contraEncriptada = ""

		md5 = New MD5CryptoServiceProvider
		bytValue = System.Text.Encoding.UTF8.GetBytes(StrPass)
		bytHash = md5.ComputeHash(bytValue)
		md5.Clear()

		For i = 0 To bytHash.Length - 1
			contraEncriptada &= bytHash(i).ToString("x").PadLeft(2, "0")
		Next

		Return contraEncriptada
	End Function
End Class