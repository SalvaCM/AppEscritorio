Imports MySql.Data.MySqlClient

Public Class vistaAlojamientos
	Public queryAlojamientos = "SELECT cCodAlojamiento'CODIGO',cNombre'NOMBRE',cDescripcion'DESCRIPCION',cDireccion'DIRECCION',cEmail'EMAIL',cLongitud'LONGITUD',cLatitud'LATITUD',cLocalidad'LOCALIDAD',cLocalizacion'LOCALIZACION',cTipo'TIPO',cTelefono'TELEFONO',cWeb'WEB',cCapacidad'CAPACIDAD' FROM tAlojamientos"
	Public indice As Integer
	Public modo As String = "Crear" 'modos disponibles : Crear , Modificar / Se usa para saber si hay que crear un aloj o modificarlo'
	Public funciones As New Funciones
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
		If (Convert.ToInt32(txtCodigo.Text) <> -1) Then
			Dim query As String = "Update tAlojamientos set cCapacidad=" & Convert.ToInt32(txtCapacidad.Text) & ",cDescripcion='" & txtDescripcion.Text & "',cDireccion='" & txtDireccion.Text & "',cEmail='" & txtMail.Text & "',cLatitud=" & txtLatitud.Text & ",cLocalidad='" & txtLocalidad.Text & "',cLocalizacion='" & txtLocalizacion.Text & "',cLongitud=" & txtLongitud.Text & ",cNombre='" & txtNombre.Text & "',cTelefono=" & txtTelefono.Text & ",cTipo='" & txtTipo.Text & "',cWeb='" & txtWeb.Text & "'  where cCodAlojamiento=" & Convert.ToInt32(txtCodigo.Text) & " ;"
			funciones.LLamadaBD(query)
			DataGridView1.DataSource = Nothing
			DataGridView1.Refresh()
			funciones.CargarGrid(DataGridView1, queryAlojamientos)
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
					'If tbox.Name = "txtTelefono" Then
					'	If tbox.Text.Length <> 9 Then
					'		validado = False
					'		MsgBox("El numero debe ser de 9 cifras")
					'	End If
					'End If
				End If
			End If
		Next
		Return validado
	End Function

	Private Sub CrearAlojamiento()

		Dim codigo = funciones.maxCod("cCodAlojamiento", "tAlojamientos")
		Dim query As String = "Insert into tAlojamientos (cCodAlojamiento,cCapacidad,cDescripcion,cDireccion,cEmail,cLatitud,cLocalidad,cLocalizacion,cLongitud,cNombre,cTelefono,cTipo,cWeb) values (" & codigo & "," & Convert.ToInt32(txtCapacidad.Text) & ",'" & txtDescripcion.Text & "','" & txtDireccion.Text & "','" & txtLatitud.Text & "','" & txtLongitud.Text & "','" & txtLocalidad.Text & "','" & txtNombre.Text & "','" & txtTelefono.Text & "','" & txtMail.Text & "','" & txtLocalizacion.Text & "','" & txtTipo.Text & "','" & txtWeb.Text & "'); "
		funciones.LLamadaBD(query)
		DataGridView1.DataSource = Nothing
		DataGridView1.Refresh()
		funciones.CargarGrid(DataGridView1, queryAlojamientos)
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
		txtCodigo.Text = DataGridView1.Rows(indice).Cells(0).Value
		txtNombre.Text = DataGridView1.Rows(indice).Cells(1).Value
		txtDescripcion.Text = DataGridView1.Rows(indice).Cells(2).Value
		txtDireccion.Text = DataGridView1.Rows(indice).Cells(3).Value
		txtMail.Text = DataGridView1.Rows(indice).Cells(4).Value
		txtLatitud.Text = DataGridView1.Rows(indice).Cells(5).Value
		txtLongitud.Text = DataGridView1.Rows(indice).Cells(6).Value
		txtLocalidad.Text = DataGridView1.Rows(indice).Cells(7).Value
		txtLocalizacion.Text = DataGridView1.Rows(indice).Cells(8).Value
		txtTipo.Text = DataGridView1.Rows(indice).Cells(9).Value
		txtTelefono.Text = DataGridView1.Rows(indice).Cells(10).Value
		txtWeb.Text = DataGridView1.Rows(indice).Cells(11).Value
		txtCapacidad.Text = DataGridView1.Rows(indice).Cells(12).Value
	End Sub

	Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
		indice = DataGridView1.CurrentCell.RowIndex
		If indice <> -1 Then
			Dim codigo As Integer = Convert.ToInt32(DataGridView1.Rows(indice).Cells(0).Value)
			Dim query As String = "Delete From tAlojamientos where cCodAlojamiento=" & codigo
			If MessageBox.Show("¿Estas seguro que quieres eliminar el alojamiento y sus reservas?", "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
				funciones.LLamadaBD(query)
				'eliminar las reservas asignadas al alojamiento
				query = "Delete from tReservas where cCodAlojamiento = " & codigo
				funciones.LLamadaBD(query)
			End If
			DataGridView1.DataSource = Nothing
			DataGridView1.Refresh()
			funciones.CargarGrid(DataGridView1, queryAlojamientos)
		Else
			MsgBox("No ha seleccionado ningun alojamiento")
		End If
	End Sub
	Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
		deshabilitarTxt()
		limpiarTxtBox()
		btnCancelar.Visible = False
		btnAceptar.Visible = False
	End Sub
	Private Sub Alojamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		funciones.CargarGrid(DataGridView1, queryAlojamientos)
	End Sub
	Sub deshabilitarTxt()
		For Each ctrl In Me.Controls
			If TypeOf ctrl Is TextBox Then
				ctrl.Enabled = False
			End If
		Next
		DataGridView1.Enabled = True
		btnCrear.Enabled = True
		btnModificar.Enabled = True
		btnEliminar.Enabled = True
		btnVolver.Enabled = True

	End Sub
	Sub habilitarTxt()
		For Each ctrl In Me.Controls
			If TypeOf ctrl Is TextBox Then
				ctrl.Enabled = True
			End If
		Next
		txtCodigo.Enabled = False
		DataGridView1.Enabled = False
		btnCrear.Enabled = False
		btnModificar.Enabled = False
		btnEliminar.Enabled = False
		btnVolver.Enabled = False
	End Sub
	Private Sub limpiarTxtBox()
		For Each ctrl In Me.Controls
			If TypeOf ctrl Is TextBox Then
				ctrl.clear()
			End If
		Next
	End Sub

End Class