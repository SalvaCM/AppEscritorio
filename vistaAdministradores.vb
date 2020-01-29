Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class vistaAdministradores
	Public funciones As New Funciones
	Public modo As String = "CREAR"
	Dim queryAdmins = "SELECT cDni'DNI', cApellidos'Apellidos', cNombre'Nombre', cTelefono'Telefono', cTipoUsuario'Tipo',cContrasena'Password' FROM tAdministradores"
	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		MenuGestion.Show()
		Me.Close()
	End Sub

	Private Sub VistaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		funciones.CargarGrid(DataGridView1, queryAdmins)
	End Sub

	'CUANDO HAGAS CLICK EN UNA CELL, QUE SE PONGA EN LOS TEXTBOX LOS DATOS
	Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

		Dim indice = DataGridView1.CurrentCell.RowIndex

		txtDni.Text = DataGridView1.Rows(indice).Cells(0).Value
		txtNombre.Text = DataGridView1.Rows(indice).Cells(2).Value
		txtApellidos.Text = DataGridView1.Rows(indice).Cells(1).Value
		txtTelefono.Text = DataGridView1.Rows(indice).Cells(3).Value
		comboTipoUsuario.Text = DataGridView1.Rows(indice).Cells(4).Value
		txtPassw.Text = DataGridView1.Rows(indice).Cells(5).Value

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
				query = "DELETE FROM tAdministradores WHERE cDni = '" & DataGridView1.Rows(indiceSelect).Cells(0).Value & "'"
				funciones.LLamadaBD(query)
			End If
			funciones.CargarGrid(DataGridView1, queryAdmins)
		End If
	End Sub
	'MODIFICAR UN USUARIO
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
		Dim indiceSelect As Integer = DataGridView1.SelectedCells.Item(0).RowIndex
		Dim cambiarPw As DialogResult = MessageBox.Show("Desea cambiar la Password?", "Atencion", MessageBoxButtons.YesNo)
		modo = "MODIFICAR"
		If txtDni.Text = "" Then
			MsgBox("No tienes seleccionado un usuario")
		Else
			habilitarTxt()
            txtDni.Enabled = False
            txtNombre.Select()

            If (cambiarPw = DialogResult.No) Then
				txtPassw.Enabled = False
				txtPassw.Text = DataGridView1.Rows(indiceSelect).Cells(5).Value
			Else
				txtPassw.Text = ""
			End If
			txtDni.Text = DataGridView1.Rows(indiceSelect).Cells(0).Value
			txtNombre.Text = DataGridView1.Rows(indiceSelect).Cells(2).Value
			txtApellidos.Text = DataGridView1.Rows(indiceSelect).Cells(1).Value
			txtTelefono.Text = DataGridView1.Rows(indiceSelect).Cells(3).Value
			comboTipoUsuario.Text = DataGridView1.Rows(indiceSelect).Cells(4).Value

		End If

	End Sub
	'CREAR UN USUARIO
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

		habilitarTxt()
		limpiarCampos()
        txtDni.Select()
        modo = "CREAR"

	End Sub
	Private Sub limpiarCampos()
		Dim tbox As TextBox
		For Each ctrl In Me.Controls
			If TypeOf ctrl Is TextBox Then
				tbox = CType(ctrl, TextBox)
				tbox.Text = Nothing
			End If
		Next
	End Sub
	'funcionalidad del boton que aparece al darle a crear o modificar usuario
	Private Sub BtnModi_Click(sender As Object, e As EventArgs) Handles btnModi.Click

		Dim query As String
		Dim result As DialogResult = MessageBox.Show("Estas seguro que quieres guardar los datos este usuario?", "Atencion", MessageBoxButtons.YesNo)
		Dim dni = txtDni.Text
		Dim nombre = txtNombre.Text
		Dim apellidos = txtApellidos.Text
		Dim telefono = txtTelefono.Text
		Dim tipo = comboTipoUsuario.Text
		Dim passW = txtPassw.Text
		Dim usuarioEncriptado As String = vistaLogin.MD5EncryptPass(dni)
		Dim passwordEncriptada As String = vistaLogin.MD5EncryptPass(passW)
		If result = DialogResult.Yes Then
			If modo = "MODIFICAR" Then
				Dim indiceSelect As Integer = DataGridView1.SelectedCells.Item(0).RowIndex
				If txtPassw.Enabled = True Then
					passW = passwordEncriptada
				End If
				query = "UPDATE tAdministradores SET cDni = '" & usuarioEncriptado & "', cNombre = '" & nombre & "', cApellidos = '" & apellidos & "', cTelefono = " & telefono & ", cTipoUsuario = '" & tipo & "',cContrasena ='" & passW & "'"
				query = query + "WHERE cDni = '" & DataGridView1.Rows(indiceSelect).Cells(0).Value & "'"
				funciones.LLamadaBD(query)
			Else
				query = "insert into tAdministradores values ('" & usuarioEncriptado & "','" & apellidos & "','" & passwordEncriptada & "','" & nombre & "'," & telefono & ",' " & tipo & "')"
				funciones.LLamadaBD(query)
			End If
			MessageBox.Show("Usuario guardado con exito!")
			funciones.CargarGrid(DataGridView1, queryAdmins)
			deshabilitarTxt()
		End If

	End Sub
	'BOTON CANCELAR
	Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
		deshabilitarTxt()
		limpiarCampos()
	End Sub

	Sub deshabilitarTxt()
		txtDni.Enabled = False
		txtNombre.Enabled = False
		txtApellidos.Enabled = False
		txtTelefono.Enabled = False
		txtPassw.Enabled = False
		DataGridView1.Enabled = True
		btnCrear.Enabled = True
		btnModificar.Enabled = True
		btnEliminar.Enabled = True
		btnCancelar.Visible = False
		btnModi.Visible = False
		comboTipoUsuario.Enabled = False

	End Sub
    Sub habilitarTxt()

        txtDni.Enabled = True
        txtNombre.Enabled = True
        txtApellidos.Enabled = True
        txtTelefono.Enabled = True
        txtPassw.Enabled = True
        DataGridView1.Enabled = False
        btnCrear.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Visible = True
        btnModi.Visible = True
        comboTipoUsuario.Enabled = True
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs)
		funciones.CargarGrid(DataGridView1, queryAdmins)
	End Sub
	Private Sub lblSalir_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
		Application.ExitThread()
	End Sub

	Private Sub BtnCancelar_MouseHover(sender As Object, e As EventArgs) Handles btnCancelar.MouseHover
		btnCancelar.BackColor = Color.Red
	End Sub

	Private Sub BtnCancelar_MouseLeave(sender As Object, e As EventArgs) Handles btnCancelar.MouseLeave
		btnCancelar.BackColor = Color.WhiteSmoke
	End Sub

	Private Sub BtnModi_MouseHover(sender As Object, e As EventArgs) Handles btnModi.MouseHover
		btnModi.BackColor = Color.Green
	End Sub
	Private Sub BtnModi_MouseLeave(sender As Object, e As EventArgs) Handles btnModi.MouseLeave
		btnModi.BackColor = Color.WhiteSmoke
	End Sub
End Class