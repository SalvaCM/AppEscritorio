
Imports MySql.Data.MySqlClient

Public Class Conexion
	'Public con As New MySqlConnection("Server=192.168.101.24; Database=alojamientos; Uid=grupoAlojamientos; Pwd=123456")
	'Server JOCHEMANUE	Public con As New MySqlConnection("Server=188.213.5.150; Database=alojamientos; Uid=accesoadatos; Pwd=123456") '
	Public con As New MySqlConnection("Server=188.213.5.150; Database=alojamientos; Uid=accesoadatos; Pwd=123456")
	'Public con As New MySqlConnection("Server=192.168.101.24; Database=alojamientos; Uid=grupoAlojamientos; Pwd=123456")
	Public Sub Conectar()
		':::Utilizamos el try para capturar posibles errores
		Try
			':::Abrimos la conexión
			con.Open()
			':::Si se estableció conexión correctamente dirá "Conectado"
			'MsgBox("Conectado")
			Console.WriteLine("Comprobando Conexion con BD : Satisfactoria")
		Catch ex As Exception
			':::Si no se conecta nos mostrara el posible fallo en la conexión
			MsgBox("No se pudo conectar a la BD por: " & ex.Message)
			Application.ExitThread()
		End Try
		con.Close()
	End Sub
End Class
