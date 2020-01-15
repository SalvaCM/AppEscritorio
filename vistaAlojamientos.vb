
Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class vistaAlojamientos
	Dim conexion As New Conexion
	Public adapter As New MySqlDataAdapter("SELECT cCodAlojamiento'CODIGO',cNombre'NOMBRE',cDescripcion'DESCRIPCION',cDireccion'DIRECCION',cEmail'EMAIL',cLongitud'LONGITUD',cLatitud'LATITUD',cLocalidad'LOCALIDAD',cLocalizacion'LOCALIZACION',cTipo'TIPO',cTelefono'TELEFONO',cWeb'WEB',cCapacidad'CAPACIDAD' FROM tAlojamientos", conexion.con)
	Public indice As Integer
	Public codigo, capacidad As Integer
	Public descripcion, direccion, email, tipo, localizacion, telefono, nombre, localidad, paginaWeb, latitud, longitud As String
	Public modo As String = "Crear" 'modos disponibles : Crear , Modificar / Se usa para saber si hay que crear un aloj o modificarlo'

	Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
		If validar() Then

			deshabilitarTxt()
			btnCancelar.Visible = False
			btnAceptar.Visible = False
			If modo = "Crear" Then
				CrearAlojamiento()
			Else
				ModificarAlojamiento()
			End If
		Else
			MsgBox("Es necesario rellenar todos los campos")
		End If
	End Sub

	Private Sub ModificarAlojamiento()
		codigo = Convert.ToInt32(txtCodigo.Text)
		capacidad = Convert.ToInt32(txtCapacidad.Text)
		descripcion = txtDescripcion.Text
		direccion = txtDireccion.Text
		latitud = txtLatitud.Text
		longitud = txtLongitud.Text
		localidad = txtLocalidad.Text
		nombre = txtNombre.Text
		telefono = txtTelefono.Text
		email = txtMail.Text
		localizacion = txtLocalizacion.Text
		tipo = txtTipo.Text
		paginaWeb = txtWeb.Text
		If (codigo <> -1) Then
			'(" & codigo & "," & capacidad & ",'" & descripcion & "','" & direccion & "','" & latitud & "','" & longitud & "','" & localidad & "','" & nombre & "','" & telefono & "','" & email & "','" & localizacion & "','" & tipo & "','" & paginaWeb & "')'
			Try
				conexion.con.Open()

				Dim query As String = "Update tAlojamientos set cCapacidad=@capacidad,cDescripcion=@descripcion,cDireccion=@direccion,cEmail=@email,cLatitud=@latitud,cLocalidad=@localidad,cLocalizacion=@localizacion,cLongitud=@longitud,cNombre=@nombre,cTelefono=@telefono,cTipo=@tipo,cWeb=@web  where cCodAlojamiento=@codigo ;"
				Dim cmd As New MySqlCommand(query, conexion.con)
				cmd.CommandType = CommandType.Text
				cmd.Parameters.AddWithValue("@codigo", codigo)
				cmd.Parameters.AddWithValue("@capacidad", capacidad)
				cmd.Parameters.AddWithValue("@descripcion", descripcion)
				cmd.Parameters.AddWithValue("@direccion", direccion)
				cmd.Parameters.AddWithValue("@email", email)
				cmd.Parameters.AddWithValue("@latitud", latitud)
				cmd.Parameters.AddWithValue("@localidad", localidad)
				cmd.Parameters.AddWithValue("@localizacion", localizacion)
				cmd.Parameters.AddWithValue("@longitud", longitud)
				cmd.Parameters.AddWithValue("@nombre", nombre)
				cmd.Parameters.AddWithValue("@telefono", telefono)
				cmd.Parameters.AddWithValue("@tipo", tipo)
				cmd.Parameters.AddWithValue("@web", paginaWeb)

				cmd.ExecuteNonQuery()
				MsgBox("Modificado Correctamente!")
			Catch ex As Exception
				MessageBox.Show("Error en actualizacion en la tabla..." & ex.Message, "Error")

			Finally

				conexion.con.Close()

			End Try

			DataGridView1.DataSource = Nothing
			DataGridView1.Refresh()
			cargaGrid()
		End If


	End Sub

	Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
		MenuGestion.Show()
		Me.Close()
	End Sub

	Private Sub lblSalir_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
		Application.ExitThread()
	End Sub
	Private Function validar()
		Dim validado As Boolean = True
		Dim tbox As TextBox
		For Each ctrl In Me.Controls
			If TypeOf ctrl Is TextBox Then
				tbox = CType(ctrl, TextBox)
				If tbox.Name <> "txtCodigo" Then

					If tbox.Text = Nothing Or tbox.Text = "" Then
						validado = False
					End If
					If tbox.Name = "txtTelefono" Then
						If tbox.Text.Length > 9 Then
							validado = False
							MsgBox("El numero debe ser de 9 cifras")
						End If
					End If

				End If
			End If
		Next

		Return validado
	End Function

	Private Sub CrearAlojamiento()

		codigo = maxCod()
		capacidad = Convert.ToInt32(txtCapacidad.Text)
		descripcion = txtDescripcion.Text
		direccion = txtDireccion.Text
		latitud = txtLatitud.Text
		longitud = txtLongitud.Text
		localidad = txtLocalidad.Text
		nombre = txtNombre.Text
		telefono = txtTelefono.Text
		email = txtMail.Text
		localizacion = txtLocalizacion.Text
		tipo = txtTipo.Text
		paginaWeb = txtWeb.Text
		If (codigo <> -1) Then

			Try
				'codigo = Convert.ToInt32(DataGridView1.Rows(indice).Cells(0).Value)'
				conexion.con.Open()

				Dim query As String = "Insert into tAlojamientos (cCodAlojamiento,cCapacidad,cDescripcion,cDireccion,cEmail,cLatitud,cLocalidad,cLocalizacion,cLongitud,cNombre,cTelefono,cTipo,cWeb) values (" & codigo & "," & capacidad & ",'" & descripcion & "','" & direccion & "','" & latitud & "','" & longitud & "','" & localidad & "','" & nombre & "','" & telefono & "','" & email & "','" & localizacion & "','" & tipo & "','" & paginaWeb & "'); "
				Dim cmd As New MySqlCommand(query, conexion.con)
				cmd.ExecuteNonQuery()
				MsgBox("Creado Correctamente!")
			Catch ex As Exception
				MessageBox.Show("Error en insercion en la tabla..." & ex.Message, "Insert Records")

			Finally

				conexion.con.Close()
				DataGridView1.DataSource = Nothing
				DataGridView1.Refresh()
				cargaGrid()
			End Try
		End If

	End Sub

	Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
		modo = "Modificar"
		habilitarTxt()
		btnCancelar.Visible = True
		btnAceptar.Visible = True
	End Sub

	Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
		modo = "Crear"
		habilitarTxt()
		limpiarTxtBox()
		btnAceptar.Visible = True
		btnCancelar.Visible = True
	End Sub


	Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

		indice = DataGridView1.CurrentCell.RowIndex

		codigo = Convert.ToInt32(DataGridView1.Rows(indice).Cells(0).Value)
		nombre = DataGridView1.Rows(indice).Cells(1).Value
		descripcion = DataGridView1.Rows(indice).Cells(2).Value
		direccion = DataGridView1.Rows(indice).Cells(3).Value
		email = DataGridView1.Rows(indice).Cells(4).Value
		latitud = DataGridView1.Rows(indice).Cells(5).Value
		longitud = DataGridView1.Rows(indice).Cells(6).Value
		localidad = DataGridView1.Rows(indice).Cells(7).Value
		localizacion = DataGridView1.Rows(indice).Cells(8).Value
		tipo = DataGridView1.Rows(indice).Cells(9).Value
		telefono = DataGridView1.Rows(indice).Cells(10).Value
		paginaWeb = DataGridView1.Rows(indice).Cells(11).Value
		capacidad = Convert.ToInt32(DataGridView1.Rows(indice).Cells(12).Value)

		txtCodigo.Text = codigo.ToString
		txtCapacidad.Text = capacidad.ToString
		txtDescripcion.Text = descripcion
		txtDireccion.Text = direccion
		txtLatitud.Text = latitud
		txtLongitud.Text = longitud
		txtLocalidad.Text = localidad
		txtNombre.Text = nombre
		txtTelefono.Text = telefono
		txtMail.Text = email
		txtLocalizacion.Text = localizacion
		txtTipo.Text = tipo
		txtWeb.Text = paginaWeb

	End Sub

	Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
		'if indice = -1 ' seleccionee
		indice = DataGridView1.CurrentCell.RowIndex
		Try
			Dim codigo As Integer = Convert.ToInt32(DataGridView1.Rows(indice).Cells(0).Value)
			conexion.con.Open()
			Dim query As String = "Delete From tAlojamientos where cCodAlojamiento=" & codigo
			If MessageBox.Show("Confirmar Borrado", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
				MsgBox("Cancelado")
				Exit Sub
			Else
				Dim cmd As New MySqlCommand(query, conexion.con)
				cmd.ExecuteNonQuery()
			End If
		Catch ex As Exception
			MessageBox.Show("Error borrando de la tabla..." & ex.Message, "Delete Records")
		Finally
			conexion.con.Close()
		End Try
		DataGridView1.DataSource = Nothing
		DataGridView1.Refresh()
		cargaGrid()
	End Sub
	Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
		deshabilitarTxt()
		limpiarTxtBox()
		btnCancelar.Visible = False
		btnAceptar.Visible = False
	End Sub
	Private Sub Alojamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		cargaGrid()
	End Sub
	Sub cargaGrid()
		conexion.con.Open()
		Dim tabla As New DataTable()
		adapter.Fill(tabla)
		DataGridView1.DataSource = tabla
		conexion.con.Close()
		For Each column As DataGridViewColumn In DataGridView1.Columns
			column.SortMode = DataGridViewColumnSortMode.NotSortable
		Next
	End Sub
	Sub deshabilitarTxt()
		txtNombre.Enabled = False
		txtCapacidad.Enabled = False
		txtDescripcion.Enabled = False
		txtDireccion.Enabled = False
		txtLatitud.Enabled = False
		txtLongitud.Enabled = False
		txtLocalidad.Enabled = False
		txtTelefono.Enabled = False
		txtMail.Enabled = False
		txtLocalizacion.Enabled = False
		txtTipo.Enabled = False
		txtWeb.Enabled = False

		DataGridView1.Enabled = True

		btnCrear.Enabled = True
		btnModificar.Enabled = True
		btnEliminar.Enabled = True
		btnVolver.Enabled = True

	End Sub
	Sub habilitarTxt()
		txtCapacidad.Enabled = True
		txtDescripcion.Enabled = True
		txtDireccion.Enabled = True
		txtLatitud.Enabled = True
		txtLongitud.Enabled = True
		txtLocalidad.Enabled = True
		txtTelefono.Enabled = True
		txtMail.Enabled = True
		txtLocalizacion.Enabled = True
		txtTipo.Enabled = True
		txtWeb.Enabled = True
		txtNombre.Enabled = True

		DataGridView1.Enabled = False

		btnCrear.Enabled = False
		btnModificar.Enabled = False
		btnEliminar.Enabled = False
		btnVolver.Enabled = False
	End Sub
	Private Sub limpiarTxtBox()
		txtCodigo.Text = ""
		txtCapacidad.Text = ""
		txtDescripcion.Text = ""
		txtDireccion.Text = ""
		txtLatitud.Text = ""
		txtLongitud.Text = ""
		txtLocalidad.Text = ""
		txtNombre.Text = ""
		txtLocalidad.Text = ""
		txtTelefono.Text = ""
		txtMail.Text = ""
		txtLocalizacion.Text = ""
		txtTipo.Text = ""
		txtWeb.Text = ""
	End Sub
	Function maxCod()
		Dim maxCodigo As Integer
		Try
			conexion.con.Open()
			Dim query As String = "SELECT max(cCodAlojamiento) FROM tAlojamientos"
			Dim cmd As New MySqlCommand(query, conexion.con)
			maxCodigo = cmd.ExecuteScalar()
			If (maxCodigo <> Nothing) Then

				maxCodigo += 1
			Else
				maxCodigo = -1

			End If
		Catch ex As Exception
			MessageBox.Show("No se pudo obtener el codigo" & ex.Message, "Error")
			maxCodigo = -1
		Finally
			conexion.con.Close()
		End Try
		Return maxCodigo
	End Function
End Class