Imports MySql.Data.MySqlClient

Public Class MenuGestion
	Dim conexion As New Conexion
	Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
		vistaUsuarios.Show()
		Me.Hide()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		vistaAlojamientos.Show()
		Me.Hide()
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		vistaReservas.Show()
		Me.Hide()
	End Sub
	Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
		vistaAdministradores.Show()
		Me.Hide()
	End Sub
	' INFORME ALOJAMIENTOS
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnInformeAloj.Click ' Informe alojamientos '
		Dim oExcel As Object
		Dim oBook As Object
		Dim oSheet As Object
		Dim contador As Integer = 2
		'Start a new workbook in Excel    
		oExcel = CreateObject("Excel.Application")
		oBook = oExcel.Workbooks.Add

		'Add data to cells of the first worksheet in the new workbook    
		oSheet = oBook.Worksheets(1)
		' Ampliar el tamaño de las columnas '
		oSheet.Columns("B").ColumnWidth = oSheet.Columns("B").ColumnWidth * 3
		oSheet.Columns("C").ColumnWidth = oSheet.Columns("C").ColumnWidth * 3
		oSheet.Columns("D").ColumnWidth = oSheet.Columns("D").ColumnWidth * 3
		oSheet.Columns("E").ColumnWidth = oSheet.Columns("E").ColumnWidth * 2
		oSheet.Columns("H").ColumnWidth = oSheet.Columns("H").ColumnWidth * 2
		oSheet.Columns("I").ColumnWidth = oSheet.Columns("I").ColumnWidth * 2
		oSheet.Columns("J").ColumnWidth = oSheet.Columns("J").ColumnWidth * 2
		oSheet.Columns("K").ColumnWidth = oSheet.Columns("K").ColumnWidth * 2
		oSheet.Columns("L").ColumnWidth = oSheet.Columns("L").ColumnWidth * 2

		'Ponemos la parte de arriba de la tabla
		oSheet.Range("A1").Value = "CODIGO"
		oSheet.Range("B1").Value = "NOMBRE"
		oSheet.Range("C1").Value = "DESCRIPCION"
		oSheet.Range("D1").Value = "DIRECCION"
		oSheet.Range("E1").Value = "EMAIL"
		oSheet.Range("F1").Value = "LONGITUD"
		oSheet.Range("G1").Value = "LATITUD"
		oSheet.Range("H1").Value = "LOCALIDAD"
		oSheet.Range("I1").Value = "LOCALIZACION"
		oSheet.Range("J1").Value = "TIPO"
		oSheet.Range("K1").Value = "TELEFONO"
		oSheet.Range("L1").Value = "WEB"
		oSheet.Range("M1").Value = "CAPACIDAD"

		oSheet.Range("A1:M1").Interior.Color = Color.BlanchedAlmond
		oSheet.Range("A1:M1").Font.Bold = True

		Try
			Dim query As String = "SELECT cCodAlojamiento'CODIGO',cNombre'NOMBRE',cDescripcion'DESCRIPCION',cDireccion'DIRECCION',cEmail'EMAIL',cLongitud'LONGITUD',cLatitud'LATITUD',cLocalidad'LOCALIDAD',cLocalizacion'LOCALIZACION',cTipo'TIPO',cTelefono'TELEFONO',cWeb'WEB',cCapacidad'CAPACIDAD' FROM TALOJAMIENTOS"
			Dim cmd As New MySqlCommand(query, conexion.con)
			conexion.con.Open()
			Dim sqlReader As MySqlDataReader = cmd.ExecuteReader()
			'vamos leyendo en la base de datos e introduciendo los elementos en el excel
			While sqlReader.Read()

				oSheet.Range("A" & contador).Value = sqlReader("CODIGO").ToString()

				oSheet.Range("B" & contador).Value = sqlReader("NOMBRE").ToString()
				oSheet.Range("C" & contador).Value = sqlReader("DESCRIPCION").ToString()
				oSheet.Range("D" & contador).Value = sqlReader("DIRECCION").ToString()
				oSheet.Range("E" & contador).Value = sqlReader("EMAIL").ToString()
				oSheet.Range("F" & contador).Value = sqlReader("LONGITUD").ToString()
				oSheet.Range("G" & contador).Value = sqlReader("LATITUD").ToString()
				oSheet.Range("H" & contador).Value = sqlReader("LOCALIDAD").ToString()
				oSheet.Range("I" & contador).Value = sqlReader("LOCALIZACION").ToString()
				oSheet.Range("J" & contador).Value = sqlReader("TIPO").ToString()
				oSheet.Range("K" & contador).Value = sqlReader("TELEFONO").ToString()
				oSheet.Range("L" & contador).Value = sqlReader("WEB").ToString()
				oSheet.Range("M" & contador).Value = sqlReader("CAPACIDAD").ToString()
				contador = contador + 1

			End While
		Catch ex As MySqlException
			' add your exception here '
		Finally
			conexion.con.Close()
		End Try
		'Dim milliseconds = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalSeconds)
		'Console.WriteLine("primer punto" & milliseconds)

		'Guardar los elementos en el xlsx
		oBook.SaveAs("InformeAlojamientos.xlsx")
		oExcel.Quit

		'Dim milliseconds2 = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalSeconds)
		'Console.WriteLine("2 punto" & milliseconds2)
		'Console.WriteLine("tiempo total" & milliseconds - milliseconds2)


		MsgBox("Informe Generado! El archivo se guardara en la carpeta de Documentos")
	End Sub
	' INFORME USUARIOS
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInformeUser.Click
		Dim oExcel As Object
		Dim oBook As Object
		Dim oSheet As Object
		Dim contador As Integer = 2
		'Start a new workbook in Excel    
		oExcel = CreateObject("Excel.Application")
		oBook = oExcel.Workbooks.Add

		'Add data to cells of the first worksheet in the new workbook    
		oSheet = oBook.Worksheets(1)

		' Ampliar el tamaño de las columnas '
		oSheet.Columns("A").ColumnWidth = oSheet.Columns("B").ColumnWidth * 3
		oSheet.Columns("B").ColumnWidth = oSheet.Columns("C").ColumnWidth * 3
		oSheet.Columns("C").ColumnWidth = oSheet.Columns("D").ColumnWidth * 3
		oSheet.Columns("D").ColumnWidth = oSheet.Columns("H").ColumnWidth * 2
		oSheet.Columns("E").ColumnWidth = oSheet.Columns("J").ColumnWidth * 2

		'Ponemos la parte de arriba de la tabla

		oSheet.Range("A1").Value = "DNI"
		oSheet.Range("B1").Value = "Nombre"
		oSheet.Range("C1").Value = "Apellidos"
		oSheet.Range("D1").Value = "Telefono"
		oSheet.Range("E1").Value = "Email"
		oSheet.Range("A1:E1").Font.Bold = True
		oSheet.Range("A1:E1").Interior.Color = Color.BlanchedAlmond


		Try
			Dim query As String = "SELECT * FROM tUsuarios"
			Dim cmd As New MySqlCommand(query, conexion.con)
			conexion.con.Open()
			Dim sqlReader As MySqlDataReader = cmd.ExecuteReader()
			'vamos leyendo en la base de datos e introduciendo los elementos en el excel
			While sqlReader.Read()

				oSheet.Range("A" & contador).Value = sqlReader("cDni").ToString()
				oSheet.Range("B" & contador).Value = sqlReader("cNombre").ToString()
				oSheet.Range("C" & contador).Value = sqlReader("cApellidos").ToString()
				oSheet.Range("D" & contador).Value = sqlReader("cTelefono").ToString()
				oSheet.Range("E" & contador).Value = sqlReader("cEmail").ToString()
				contador = contador + 1

			End While
		Catch ex As MySqlException
			' add your exception here '
		Finally
			conexion.con.Close()
		End Try



		'Guardar los elementos en el xlsx
		oBook.SaveAs("InformeUsuarios.xlsx")
		oExcel.Quit

		MsgBox("Informe Generado! El archivo se guardara en la carpeta de Documentos")
	End Sub
	'INFORME RESERVAS
	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnInformeRes.Click

		Dim oExcel As Object
		Dim oBook As Object
		Dim oSheet As Object
		Dim contador As Integer = 2
		'Start a new workbook in Excel    
		oExcel = CreateObject("Excel.Application")
		oBook = oExcel.Workbooks.Add

		'Add data to cells of the first worksheet in the new workbook    
		oSheet = oBook.Worksheets(1)

		' Ampliar el tamaño de las columnas '
		oSheet.Columns("A").ColumnWidth = oSheet.Columns("A").ColumnWidth * 3
		oSheet.Columns("B").ColumnWidth = oSheet.Columns("B").ColumnWidth * 3
		oSheet.Columns("C").ColumnWidth = oSheet.Columns("C").ColumnWidth * 3
		oSheet.Columns("D").ColumnWidth = oSheet.Columns("D").ColumnWidth * 2
		oSheet.Columns("E").ColumnWidth = oSheet.Columns("E").ColumnWidth * 2
		oSheet.Columns("F").ColumnWidth = oSheet.Columns("F").ColumnWidth * 2

		'Ponemos la parte de arriba de la tabla

		oSheet.Range("A1").Value = "Codigo Reserva"
		oSheet.Range("B1").Value = "Codigo Alojamiento"
		oSheet.Range("C1").Value = "DNI"
		oSheet.Range("D1").Value = "Fecha Entrada"
		oSheet.Range("E1").Value = "Fecha Realizada"
		oSheet.Range("F1").Value = "Fecha Salida"
		oSheet.Range("A1:F1").Font.Bold = True
		oSheet.Range("A1:F1").Interior.Color = Color.BlanchedAlmond



		Try
			Dim query As String = "SELECT * FROM treservas"
			Dim cmd As New MySqlCommand(query, conexion.con)
			conexion.con.Open()
			Dim sqlReader As MySqlDataReader = cmd.ExecuteReader()

			'vamos leyendo en la base de datos e introduciendo los elementos en el excel
			While sqlReader.Read()

				oSheet.Range("A" & contador).Value = sqlReader("cReserva").ToString()
				oSheet.Range("B" & contador).Value = sqlReader("cCodAlojamiento").ToString()
				oSheet.Range("C" & contador).Value = sqlReader("cCodUsuario").ToString()
				oSheet.Range("D" & contador).Value = sqlReader("cFechaEntrada").ToString()
				oSheet.Range("E" & contador).Value = sqlReader("cFechaRealizada").ToString()
				oSheet.Range("F" & contador).Value = sqlReader("cFechaSalida").ToString()
				contador = contador + 1

			End While
		Catch ex As MySqlException
			' add your exception here '
		Finally
			conexion.con.Close()
		End Try



		'Guardar los elementos en el xlsx
		oBook.SaveAs("InformeReservas.xlsx")
		oExcel.Quit

		MsgBox("Informe Generado! El archivo se guardara en la carpeta de Documentos")

	End Sub

	Private Sub LblSalir_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
		Application.ExitThread()
	End Sub

	Private Sub btninformeAdmin_click(sender As Object, e As EventArgs) Handles btnInformeAdmin.Click
		Dim oExcel As Object
		Dim oBook As Object
		Dim oSheet As Object
		Dim contador As Integer = 2
		'Start a new workbook in Excel    
		oExcel = CreateObject("Excel.Application")
		oBook = oExcel.Workbooks.Add

		'Add data to cells of the first worksheet in the new workbook    
		oSheet = oBook.Worksheets(1)

		' Ampliar el tamaño de las columnas '
		oSheet.Columns("A").ColumnWidth = oSheet.Columns("B").ColumnWidth * 3
		oSheet.Columns("B").ColumnWidth = oSheet.Columns("C").ColumnWidth * 3
		oSheet.Columns("C").ColumnWidth = oSheet.Columns("D").ColumnWidth * 3
		oSheet.Columns("D").ColumnWidth = oSheet.Columns("H").ColumnWidth * 2
		oSheet.Columns("E").ColumnWidth = oSheet.Columns("J").ColumnWidth * 2

		'Ponemos la parte de arriba de la tabla

		oSheet.Range("A1").Value = "DNI"
		oSheet.Range("B1").Value = "Nombre"
		oSheet.Range("C1").Value = "Apellidos"
		oSheet.Range("D1").Value = "Telefono"
		oSheet.Range("E1").Value = "Tipo Usuario"
		oSheet.Range("A1:E1").Font.Bold = True
		oSheet.Range("A1:E1").Interior.Color = Color.BlanchedAlmond


		Try
			Dim query As String = "SELECT * FROM tAdministradores"
			Dim cmd As New MySqlCommand(query, conexion.con)
			conexion.con.Open()
			Dim sqlReader As MySqlDataReader = cmd.ExecuteReader()

			'vamos leyendo en la base de datos e introduciendo los elementos en el excel
			While sqlReader.Read()

				oSheet.Range("A" & contador).Value = sqlReader("cDni").ToString()
				oSheet.Range("B" & contador).Value = sqlReader("cNombre").ToString()
				oSheet.Range("C" & contador).Value = sqlReader("cApellidos").ToString()
				oSheet.Range("D" & contador).Value = sqlReader("cTelefono").ToString()
				oSheet.Range("E" & contador).Value = sqlReader("cTipoUsuario").ToString()
				contador = contador + 1

			End While
		Catch ex As MySqlException
			' add your exception here '
		Finally
			conexion.con.Close()
		End Try



		'Guardar los elementos en el xlsx
		oBook.SaveAs("InformeAdministradores.xlsx")
		oExcel.Quit

		MsgBox("Informe Generado! El archivo se guardara en la carpeta de Documentos")
	End Sub

	Private Sub MenuGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If vistaLogin.tipoUser = "admin" Then
			btnAdmin.Visible = True
			btnInformeAdmin.Visible = True
		Else
			Label3.Visible = False
			btnAdmin.Visible = False
			btnInformeAdmin.Visible = False
		End If

	End Sub
End Class
