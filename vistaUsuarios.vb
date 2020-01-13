Imports MySql.Data.MySqlClient

Public Class vistaUsuarios
	Public conexion As New Conexion
	Public adapter As New MySqlDataAdapter("SELECT cDni'DNI', cApellidos'Apellidos', cNombre'Nombre', cTelefono'Telefono', cTipoUsuario'Tipo' FROM TUSUARIOS", conexion.con)
	'Volver
	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MenuGestion.Show()
        Me.Close()
    End Sub

    Private Sub VistaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridView1.DataSource = tabla
		conexion.con.Close()
		txtDni.Text = DataGridView1.Rows(0).Cells(0).Value
        txtNombre.Text = DataGridView1.Rows(0).Cells(2).Value
        txtApellidos.Text = DataGridView1.Rows(0).Cells(1).Value
        txtTelefono.Text = DataGridView1.Rows(0).Cells(3).Value
        comboTipoUsuario.Text = DataGridView1.Rows(0).Cells(4).Value

    End Sub
    'CUANDO HAGAS CLICK EN UNA CELL, QUE SE PONGA EN LOS TEXTBOX LOS DATOS
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim indiceSelect As Integer = DataGridView1.SelectedCells.Item(0).RowIndex
        txtDni.Text = DataGridView1.Rows(indiceSelect).Cells(0).Value
        txtNombre.Text = DataGridView1.Rows(indiceSelect).Cells(2).Value
        txtApellidos.Text = DataGridView1.Rows(indiceSelect).Cells(1).Value
        txtTelefono.Text = DataGridView1.Rows(indiceSelect).Cells(3).Value
        comboTipoUsuario.Text = DataGridView1.Rows(indiceSelect).Cells(4).Value

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
                Try
                    query = "DELETE FROM tusuarios WHERE cDni = '" & DataGridView1.Rows(indiceSelect).Cells(0).Value & "'"
					conexion.con.Open()
					Dim mysc As New MySqlCommand(query, conexion.con)
					mysc.ExecuteNonQuery()
                    MessageBox.Show("Usuario dado de baja")
					conexion.con.Close()
				Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
            cargaGrid()
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
            comboTipoUsuario.Text = DataGridView1.Rows(indiceSelect).Cells(4).Value
            Label6.Text = "Modificar"
        End If


    End Sub


    'CREAR UN USUARIO
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        habilitarTxt()
        txtDni.Text = Nothing
        txtNombre.Text = Nothing
        txtApellidos.Text = Nothing
        txtTelefono.Text = Nothing
        Label6.Text = "Crear"

    End Sub
    'funcionalidad del boton que aparece al darle a crear o modificar usuario
    Private Sub BtnModi_Click(sender As Object, e As EventArgs) Handles btnModi.Click

        Dim READER As MySqlDataReader
        Dim query As String
        Dim Command As MySqlCommand
        Dim result As DialogResult = MessageBox.Show("Estas seguro que quieres guardar los datos este usuario?", "Atencion", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
				conexion.con.Open()
				If Label6.Text = "Modificar" Then
                    Dim indiceSelect As Integer = DataGridView1.SelectedCells.Item(0).RowIndex

                    Dim dni = txtDni.Text
                    Dim nombre = txtNombre.Text
                    Dim apellidos = txtApellidos.Text
                    Dim telefono = txtTelefono.Text
                    Dim tipo = comboTipoUsuario.Text

                    query = "UPDATE tusuarios SET cDni = '" & dni & "', cNombre = '" & nombre & "', cApellidos = '" & apellidos & "', cTelefono = " & telefono & ", cTipoUsuario = '" & tipo & "' "
                    query = query + "WHERE cDni = '" & DataGridView1.Rows(indiceSelect).Cells(0).Value & "'"
                Else
                    query = "insert into tusuarios values ('" & txtDni.Text & "','" & txtApellidos.Text & "','hola','" & txtNombre.Text & "'," & txtTelefono.Text & ",' " & comboTipoUsuario.Text & "')"
                End If
				Command = New MySqlCommand(query, conexion.con)

				READER = Command.ExecuteReader

                MessageBox.Show("Usuario guardado con exito!")
				conexion.con.Close()

			Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try
            cargaGrid()
            deshabilitarTxt()

        End If

    End Sub
    'BOTON CANCELAR
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        deshabilitarTxt()

    End Sub

    Sub cargaGrid()
		conexion.con.Open()
		Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridView1.DataSource = tabla
		conexion.con.Close()
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
        Button1.Enabled = True
        btnActualizar.Enabled = True
        busApellido.Enabled = True
        busNombre.Enabled = True
        busTipo.Enabled = True
        btnModi.Visible = False
        comboTipoUsuario.Enabled = False

    End Sub
    Sub habilitarTxt()
        txtDni.Enabled = True
        txtNombre.Enabled = True
        txtApellidos.Enabled = True
        txtTelefono.Enabled = True
        DataGridView1.Enabled = False
        btnCrear.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Visible = True
        btnModi.Visible = True
        comboTipoUsuario.Enabled = True
        Button1.Enabled = False
        btnActualizar.Enabled = False
        busApellido.Enabled = False
        busNombre.Enabled = False
        busTipo.Enabled = False

    End Sub
    'buscar un usuario
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Dim query As String = "SELECT cDni'DNI', cApellidos'Apellidos', cNombre'Nombre', cTelefono'Telefono', cTipoUsuario'Tipo' FROM TUSUARIOS "
        Dim primero As Boolean = True
        ' si no se ha escrito ningun elemento y le damos a buscar, nos saltara un mensaje
        If busNombre.Text = "" And busApellido.Text = "" And busTipo.Text = "" Then
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

            If busTipo.Text <> "" Then
                If primero = True Then
                    query = query + "WHERE "
                    primero = False
                Else
                    query = query + "AND "
                End If

                query = query + "cTipoUsuario = '" & busTipo.Text & "' "
            End If

            Dim tabla As New DataTable()
            Dim nAdapter As New MySqlDataAdapter(query, conexion.con)
            conexion.con.Open()

            nAdapter.Fill(tabla)
            DataGridView1.DataSource = tabla
            conexion.con.Close()

        End If

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs)
        cargaGrid()
    End Sub


    Private Sub lblSalir_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
        Application.ExitThread()
    End Sub
End Class