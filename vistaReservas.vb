Imports MySql.Data.MySqlClient
Public Class vistaReservas
	Public conexion As New Conexion
    Public query As String = "SELECT r.cReserva'Codigo Reserva', a.cNombre'Nombre Apartamento', u.cDni'DNI', u.cNombre'Nombre Usuario', u.cApellidos'Apellidos', u.cTelefono'Telefono Usuario', r.cFechaRealizada'Fecha Realizada', r.cFechaEntrada'Fecha Entrada', r.cFechaSalida'Fecha Saluda' FROM tAlojamientos a, tReservas r, tUsuarios u WHERE r.cCodAlojamiento = a.cCodAlojamiento AND cCodUsuario = cDni"
    Public adapter As New MySqlDataAdapter(query, conexion.con)
	'Volver
	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MenuGestion.Show()
        Me.Close()
    End Sub
    'Cargar la lista de las reservas
    Private Sub VistaReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDni.Enabled = False
        txtNombreAloj.Enabled = False
        txtNombreUsuario.Enabled = False
        txtApellidos.Enabled = False
        txtFechaEntrada.Enabled = False
        txtFechaReserva.Enabled = False
        txtFechaSalida.Enabled = False
        txtTelefonoAlo.Enabled = False

        Button1.Visible = False
        Button5.Visible = False
        cargaGrid()

        txtNombreAloj.Text = DataGridView1.Rows(0).Cells(1).Value
        txtDni.Text = DataGridView1.Rows(0).Cells(2).Value
        txtNombreUsuario.Text = DataGridView1.Rows(0).Cells(3).Value
        txtApellidos.Text = DataGridView1.Rows(0).Cells(4).Value
        txtTelefonoAlo.Text = DataGridView1.Rows(0).Cells(5).Value
        txtFechaReserva.Text = DataGridView1.Rows(0).Cells(6).Value
        txtFechaEntrada.Text = DataGridView1.Rows(0).Cells(7).Value
        txtFechaSalida.Text = DataGridView1.Rows(0).Cells(8).Value


    End Sub

    Private Sub cargaGrid()
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridView1.DataSource = tabla
		conexion.con.Close()
	End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim indiceSelect As Integer = DataGridView1.SelectedCells.Item(0).RowIndex
        txtNombreAloj.Text = DataGridView1.Rows(indiceSelect).Cells(1).Value
        txtDni.Text = DataGridView1.Rows(indiceSelect).Cells(2).Value
        txtNombreUsuario.Text = DataGridView1.Rows(indiceSelect).Cells(3).Value
        txtApellidos.Text = DataGridView1.Rows(indiceSelect).Cells(4).Value
        txtTelefonoAlo.Text = DataGridView1.Rows(indiceSelect).Cells(5).Value
        txtFechaReserva.Text = DataGridView1.Rows(indiceSelect).Cells(6).Value
        txtFechaEntrada.Text = DataGridView1.Rows(indiceSelect).Cells(7).Value
		txtFechaSalida.Text = DataGridView1.Rows(indiceSelect).Cells(8).Value

	End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim indiceSelect As Integer = DataGridView1.SelectedCells.Item(0).RowIndex
        Dim query As String
        txtDni.Text = DataGridView1.Rows(indiceSelect).Cells(0).Value
        If txtDni.Text = "" Then
            MsgBox("No tienes seleccionado ninguna reserva")

        Else
            Dim result As DialogResult = MessageBox.Show("Estas seguro que quieres eliminar esta reserva?", "Atencion", MessageBoxButtons.YesNo)
            If (result = DialogResult.Yes) Then
                Try
                    query = "DELETE FROM treservas WHERE cReserva = " & DataGridView1.Rows(indiceSelect).Cells(0).Value
					conexion.con.Open()
					Dim mysc As New MySqlCommand(query, conexion.con)
					mysc.ExecuteNonQuery()
                    MessageBox.Show("Reserva eliminada!")
					conexion.con.Close()
				Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
            cargaGrid()
        End If
    End Sub
    'BOTON CANCELAR
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtFechaEntrada.Enabled = False
        txtFechaSalida.Enabled = False
        Button1.Visible = False
        Button5.Visible = False

    End Sub

    'BOTON MODIFICAR
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtFechaEntrada.Enabled = True
        txtFechaSalida.Enabled = True
        Button1.Visible = True
        Button5.Visible = True
    End Sub
    'BOTON GUARDAR
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim result As DialogResult = MessageBox.Show("Estas seguro que quieres guardar los datos este usuario?", "Atencion", MessageBoxButtons.YesNo)
        Dim READER As MySqlDataReader
        Dim Command As MySqlCommand
        Dim indiceSelect As Integer = DataGridView1.SelectedCells.Item(0).RowIndex
        Dim codigo = DataGridView1.Rows(indiceSelect).Cells(0).Value

        If result = DialogResult.Yes Then
            Dim fecha1 As Date = txtFechaEntrada.Text
            Dim fecha2 As Date = txtFechaSalida.Text
            Dim upd As String = "UPDATE tReservas SET cFechaEntrada = '" & fecha1.Year & "-" & fecha1.Month & "-" & fecha1.Day & "', cFechaSalida = '" & fecha2.Year & "-" & fecha2.Month & "-" & fecha2.Day & "' WHERE cReserva = " & codigo
            conexion.con.Open()
			Command = New MySqlCommand(upd, conexion.con)

			READER = Command.ExecuteReader

            MessageBox.Show("Usuario guardado con exito!")
			conexion.con.Close()


		End If
        txtFechaEntrada.Enabled = False
        txtFechaSalida.Enabled = False
        Button1.Visible = False
        Button5.Visible = False
        cargaGrid()

    End Sub

    Private Sub lblSalir_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
        Application.ExitThread()
    End Sub

End Class