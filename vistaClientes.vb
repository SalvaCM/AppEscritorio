Imports MySql.Data.MySqlClient

Public Class vistaClientes
	Public funciones As New Funciones
	Public queryUsuarios = "SELECT cDni'DNI', cApellidos'Apellidos', cNombre'Nombre', cTelefono'Telefono', cEmail'eMail' FROM tUsuarios"
	Dim modo = "CREAR"
	'Volver
	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		MenuGestion.Show()
		Me.Close()
	End Sub

	Private Sub VistaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		funciones.CargarGrid(DataGridView1, queryUsuarios)
	End Sub
	'CUANDO HAGAS CLICK EN UNA CELL, QUE SE PONGA EN LOS TEXTBOX LOS DATOS
	Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.MouseClick

		Dim indiceSelect As Integer = DataGridView1.CurrentCell.RowIndex
		txtDni.Text = DataGridView1.Rows(indiceSelect).Cells(0).Value
		txtNombre.Text = DataGridView1.Rows(indiceSelect).Cells(2).Value
		txtApellidos.Text = DataGridView1.Rows(indiceSelect).Cells(1).Value
		txtTelefono.Text = DataGridView1.Rows(indiceSelect).Cells(3).Value
		txtEmail.Text = DataGridView1.Rows(indiceSelect).Cells(4).Value
		Dim queryReservasUsuarios = "SELECT cReserva'CODIGO RESERVA',cCodAlojamiento'CODIGO ALOJAMIENTO', cCodUsuario'DNI',cFechaEntrada'FECHA ENTRADA', cFechaRealizada'FECHA REALIZADA', cFechaSalida'FECHA SALIDA' FROM tReservas WHERE cCodUsuario='" & txtDni.Text & "'"
		funciones.CargarGrid(DataGridView2, queryReservasUsuarios)
	End Sub
	'ELIMINAR UN USUARIO
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

		Dim indiceSelect As Integer = DataGridView1.SelectedCells.Item(0).RowIndex
		Dim query As String
		txtDni.Text = DataGridView1.Rows(indiceSelect).Cells(0).Value
		If txtDni.Text = "" Then
			MsgBox("No tienes seleccionado un usuario")
		Else
			Dim result As DialogResult = MessageBox.Show("Estas seguro que quieres eliminar este usuario?", "Atencion", MessageBoxButtons.YesNo)
			If (result = DialogResult.Yes) Then

				query = "DELETE FROM tUsuarios WHERE cDni = '" & DataGridView1.Rows(indiceSelect).Cells(0).Value & "'"
					funciones.LLamadaBD(query)
				MessageBox.Show("Usuario dado de baja")
			End If
			funciones.CargarGrid(DataGridView1, queryUsuarios)
		End If

	End Sub

	'MODIFICAR UN USUARIO
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

		If txtDni.Text = "" Then
			MsgBox("No tienes seleccionado un usuario")
		Else
			habilitarTxt()
			Dim indiceSelect As Integer = DataGridView1.SelectedCells.Item(0).RowIndex
			txtDni.Text = DataGridView1.Rows(indiceSelect).Cells(0).Value
			txtNombre.Text = DataGridView1.Rows(indiceSelect).Cells(2).Value
			txtApellidos.Text = DataGridView1.Rows(indiceSelect).Cells(1).Value
			txtTelefono.Text = DataGridView1.Rows(indiceSelect).Cells(3).Value
			txtEmail.Text = DataGridView1.Rows(indiceSelect).Cells(4).Value
			modo = "MODIFICAR"
		End If

	End Sub

	'CREAR UN USUARIO
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        habilitarTxt()
        'aqui que se pueda habilitar el campo del dni
        txtDni.Enabled = True
        txtDni.Text = Nothing
		txtNombre.Text = Nothing
		txtApellidos.Text = Nothing
        txtTelefono.Text = Nothing
        txtEmail.Text = Nothing

        modo = "CREAR"

	End Sub
	'funcionalidad del boton que aparece al darle a crear o modificar usuario
	Private Sub BtnModi_Click(sender As Object, e As EventArgs) Handles btnModi.Click

		Dim query As String
		Dim result As DialogResult = MessageBox.Show("Estas seguro que quieres guardar los datos este usuario?", "Atencion", MessageBoxButtons.YesNo)
		Dim indiceSelect As Integer = DataGridView1.SelectedCells.Item(0).RowIndex

		Dim dni = txtDni.Text
		Dim nombre = txtNombre.Text
		Dim apellidos = txtApellidos.Text
		Dim telefono = txtTelefono.Text
		Dim mail = txtEmail.Text
        If dni <> "" And nombre <> "" And apellidos <> "" And telefono.Length > 8 And mail <> "" Then

            If result = DialogResult.Yes Then
                If modo = "MODIFICAR" Then
                    query = "UPDATE tUsuarios SET cDni = '" & dni & "', cNombre = '" & nombre & "', cApellidos = '" & apellidos & "', cTelefono = " & telefono & ", cEmail = '" & mail & "' "
                    query = query + "WHERE cDni = '" & DataGridView1.Rows(indiceSelect).Cells(0).Value & "'"
                Else
                    query = "insert into tUsuarios (cDni,cApellidos,cContrasena,cNombre,cTelefono,cEmail) values ('" & dni & "','" & apellidos & "','default','" & nombre & "'," & telefono & ",'" & mail & "')"
                End If
                funciones.LLamadaBD(query)

                funciones.CargarGrid(DataGridView1, queryUsuarios)
                MessageBox.Show("Usuario guardado con exito!")
                deshabilitarTxt()
            End If
        Else
            MessageBox.Show("Alguno de estos campos no esta bien insertados!")
        End If
    End Sub
	'BOTON CANCELAR
	Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
		deshabilitarTxt()
	End Sub

	Sub deshabilitarTxt()
		txtDni.Enabled = False
		txtNombre.Enabled = False
		txtApellidos.Enabled = False
		txtTelefono.Enabled = False
		DataGridView1.Enabled = True
		btnCrear.Enabled = True
		btnModificar.Enabled = True
		btnEliminar.Enabled = True
		btnCancelar.Visible = False
		btnBuscar.Enabled = True
		btnActualizar.Enabled = True
		busApellido.Enabled = True
		busNombre.Enabled = True
		busMail.Enabled = True
		btnModi.Visible = False
		txtEmail.Enabled = False

	End Sub
	Sub habilitarTxt()

        txtNombre.Enabled = True
		txtApellidos.Enabled = True
		txtTelefono.Enabled = True
		DataGridView1.Enabled = False
		btnCrear.Enabled = False
		btnModificar.Enabled = False
		btnEliminar.Enabled = False
		btnCancelar.Visible = True
		btnModi.Visible = True
		txtEmail.Enabled = True
		btnBuscar.Enabled = False
		btnActualizar.Enabled = False
		busApellido.Enabled = False
		busNombre.Enabled = False
		busMail.Enabled = False

	End Sub
	'buscar un usuario
	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
		Dim query As String = "SELECT cDni'DNI', cApellidos'Apellidos', cNombre'Nombre', cTelefono'Telefono', cEmail'Email' FROM tUsuarios "
		Dim primero As Boolean = True
		' si no se ha escrito ningun elemento y le damos a buscar, nos saltara un mensaje
		If busNombre.Text = "" And busApellido.Text = "" And busMail.Text = "" Then
			MsgBox("No has añadido ningun campo de busqueda")
		Else

			If busNombre.Text <> "" Then
				'aqui comprobamos si es el primer dato en entrar para construir el select con el where
				If primero = True Then
					query = query + "WHERE "
					primero = False
				End If
				query = query + "cNombre LIKE '%" & busNombre.Text & "%' "
			End If

			If busApellido.Text <> "" Then
				If primero = True Then
					query = query + "WHERE "
					primero = False
				Else ' en el caso de que no, se le añadira un AND
					query = query + "AND "
				End If
				query = query + "cApellidos LIKE '%" & busApellido.Text & "%' "
			End If

			If busMail.Text <> "" Then
				If primero = True Then
					query = query + "WHERE "
					primero = False
				Else
					query = query + "AND "
				End If

                query = query + "cEmail LIKE '%" & busMail.Text & "%' "
            End If

			funciones.CargarGrid(DataGridView1, query)

		End If

	End Sub

	Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        funciones.CargarGrid(DataGridView1, queryUsuarios)
        busNombre.Text = ""
        busMail.Text = ""
        busApellido.Text = ""
    End Sub

	Private Sub LbSalir_Click(sender As Object, e As EventArgs) Handles lbSalir.Click
		Application.ExitThread()
	End Sub
End Class