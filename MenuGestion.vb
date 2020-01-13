Imports MySql.Data.MySqlClient

Public Class MenuGestion
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

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click ' Informe alojamientos '
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
		oSheet.Columns("H").ColumnWidth = oSheet.Columns("H").ColumnWidth * 2
		oSheet.Columns("J").ColumnWidth = oSheet.Columns("J").ColumnWidth * 2
		oSheet.Columns("L").ColumnWidth = oSheet.Columns("L").ColumnWidth * 2

		'Ponemos la parte de arriba de la tabla
		oSheet.Range("A1").Value = "CODIGO"
		oSheet.Range("A1").Interior.Color = Color.BlanchedAlmond
		oSheet.Range("B1").Value = "NOMBRE"
		oSheet.Range("B1").Interior.Color = Color.BlanchedAlmond
		oSheet.Range("C1").Value = "DESCRIPCION"
		oSheet.Range("C1").Interior.Color = Color.BlanchedAlmond
		oSheet.Range("D1").Value = "DIRECCION"
		oSheet.Range("D1").Interior.Color = Color.BlanchedAlmond
		oSheet.Range("E1").Value = "EMAIL"
		oSheet.Range("E1").Interior.Color = Color.BlanchedAlmond
		oSheet.Range("F1").Value = "LONGITUD"
		oSheet.Range("F1").Interior.Color = Color.BlanchedAlmond
		oSheet.Range("G1").Value = "LATITUD"
		oSheet.Range("G1").Interior.Color = Color.BlanchedAlmond
		oSheet.Range("H1").Value = "LOCALIDAD"
		oSheet.Range("H1").Interior.Color = Color.BlanchedAlmond
		oSheet.Range("I1").Value = "LOCALIZACION"
		oSheet.Range("I1").Interior.Color = Color.BlanchedAlmond
		oSheet.Range("J1").Value = "TIPO"
		oSheet.Range("J1").Interior.Color = Color.BlanchedAlmond
		oSheet.Range("K1").Value = "TELEFONO"
		oSheet.Range("K1").Interior.Color = Color.BlanchedAlmond
		oSheet.Range("L1").Value = "WEB"
		oSheet.Range("L1").Interior.Color = Color.BlanchedAlmond
		oSheet.Range("M1").Value = "CAPACIDAD"
		oSheet.Range("M1").Interior.Color = Color.BlanchedAlmond

		oSheet.Range("A1:M1").Font.Bold = True

		Dim con As String = "Server=192.168.101.24; Database=alojamientos; Uid=grupoAlojamientos; Pwd=123456"
		Dim query As String = "SELECT cCodAlojamiento'CODIGO',cNombre'NOMBRE',cDescripcion'DESCRIPCION',cDireccion'DIRECCION',cEmail'EMAIL',cLongitud'LONGITUD',cLatitud'LATITUD',cLocalidad'LOCALIDAD',cLocalizacion'LOCALIZACION',cTipo'TIPO',cTelefono'TELEFONO',cWeb'WEB',cCapacidad'CAPACIDAD' FROM TALOJAMIENTOS"
		Using sqlConn As New MySqlConnection(con)
			Using sqlComm As New MySqlCommand()
				With sqlComm
					.Connection = sqlConn
					.CommandText = query
					.CommandType = CommandType.Text
				End With
				Try
					sqlConn.Open()
					Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
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

				End Try
			End Using
		End Using


		'Guardar los elementos en el xlsx
		oBook.SaveAs("C:\Users\IN1DM3B_09\Desktop\raro\prueba.xlsx")
		oExcel.Quit

		MsgBox("Informe Generado!")
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim oExcel As Object
		Dim oBook As Object
		Dim oSheet As Object
		Dim contador As Integer = 2
		'Start a new workbook in Excel    
		oExcel = CreateObject("Excel.Application")
		oBook = oExcel.Workbooks.Add

		'Add data to cells of the first worksheet in the new workbook    
		oSheet = oBook.Worksheets(1)
		'Ponemos la parte de arriba de la tabla
		oSheet.Range("A1").Value = "DNI"
		oSheet.Range("B1").Value = "Nombre"
		oSheet.Range("C1").Value = "Apellidos"
		oSheet.Range("D1").Value = "Telefono"
		oSheet.Range("E1").Value = "Apellidos"
		oSheet.Range("A1:E1").Font.Bold = True

		Dim con As String = "Server=192.168.101.24; Database=alojamientos; Uid=grupoAlojamientos; Pwd=123456"
		Dim query As String = "SELECT * FROM tUsuarios"
		Using sqlConn As New MySqlConnection(con)
			Using sqlComm As New MySqlCommand()
				With sqlComm
					.Connection = sqlConn
					.CommandText = query
					.CommandType = CommandType.Text
				End With
				Try
					sqlConn.Open()
					Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
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
				End Try
			End Using
		End Using


		'Guardar los elementos en el xlsx
		oBook.SaveAs("C:\Users\IN1DM3B_09\Desktop\prueba.xlsx")
		oExcel.Quit

		MsgBox("Informe Generado!")
	End Sub
End Class
