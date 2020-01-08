
Imports MySql.Data.MySqlClient

Public Class Conexion
	Dim con As New MySqlConnection("Server=192.168.101.24; Database=alojamientos; Uid=grupoAlojamientos; Pwd=123456")

	Public Sub Conectar()
		':::Utilizamos el try para capturar posibles errores
		Try
			':::Abrimos la conexión
			con.Open()
			':::Si se estableció conexión correctamente dirá "Conectado"
			MsgBox("Conectado")
		Catch ex As Exception
			':::Si no se conecta nos mostrara el posible fallo en la conexión
			MsgBox("No se pudo conectar a la BD por: " & ex.Message)
			Application.ExitThread()
		End Try
		con.Close()
	End Sub
End Class
