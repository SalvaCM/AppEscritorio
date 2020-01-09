Imports MySql.Data.MySqlClient

Public Class vistaUsuarios
    Public con As New MySqlConnection("Server=192.168.101.24; Database=alojamientos; Uid=grupoAlojamientos; Pwd=123456")
    Public adapter As New MySqlDataAdapter("SELECT * FROM TUSUARIOS", con)
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MenuGestion.Show()
        Me.Close()
    End Sub

    Private Sub VistaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridView1.DataSource = tabla
        con.Close()
        txtDni.Text = DataGridView1.Rows(0).Cells(0).Value
        txtNombre.Text = DataGridView1.Rows(0).Cells(3).Value
        txtApellidos.Text = DataGridView1.Rows(0).Cells(1).Value
        txtTelefono.Text = DataGridView1.Rows(0).Cells(4).Value
        comboTipoUsuario.Text = DataGridView1.Rows(0).Cells(5).Value

    End Sub
    'CUANDO HAGAS CLICK EN UNA CELL, QUE SE PONGA EN LOS TEXTBOX LOS DATOS
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim indiceSelect As Integer = DataGridView1.SelectedCells.Item(0).RowIndex
        txtDni.Text = DataGridView1.Rows(indiceSelect).Cells(0).Value
        txtNombre.Text = DataGridView1.Rows(indiceSelect).Cells(3).Value
        txtApellidos.Text = DataGridView1.Rows(indiceSelect).Cells(1).Value
        txtTelefono.Text = DataGridView1.Rows(indiceSelect).Cells(4).Value
        comboTipoUsuario.Text = DataGridView1.Rows(indiceSelect).Cells(5).Value

    End Sub

    'ELIMINAR UN USUARIO
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult = MessageBox.Show("Estas seguro que quieres eliminar este usuario?", "Title", MessageBoxButtons.YesNo)
        Dim indiceSelect As Integer = DataGridView1.SelectedCells.Item(0).RowIndex
        Dim query As String
        txtDni.Text = DataGridView1.Rows(indiceSelect).Cells(0).Value
        If (result = DialogResult.Yes) Then
            Try
                query = "DELETE FROM tusuarios WHERE cDni = '" & DataGridView1.Rows(indiceSelect).Cells(0).Value & "'"
                con.Open()
                Dim mysc As New MySqlCommand(query, con)
                mysc.ExecuteNonQuery()
                MessageBox.Show("Usuario eliminado!")
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        Else
            MessageBox.Show("nop")
        End If
        cargaGrid()
    End Sub

    'MODIFICAR UN USUARIO
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnModificar.Click


        habilitarTxt()

        Label6.Text = "Modificar"

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
        Try
            con.Open()
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
            Command = New MySqlCommand(query, con)

            READER = Command.ExecuteReader

            MessageBox.Show("Usuario guardado con exito!")


            con.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        cargaGrid()
        deshabilitarTxt()
    End Sub
    'BOTON CANCELAR
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        deshabilitarTxt()

    End Sub

    Sub cargaGrid()
        con.Open()
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridView1.DataSource = tabla
        con.Close()
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
    End Sub

End Class