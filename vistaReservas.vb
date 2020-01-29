Imports MySql.Data.MySqlClient
Public Class vistaReservas
    Dim funciones As New Funciones
	Public queryReservas = "SELECT r.cReserva'codigo', a.cNombre'Nombre Alojamiento', u.cDni'DNI', u.cNombre'Nombre Usuario', u.cApellidos'Apellidos', u.cTelefono'Telefono Usuario', r.cFechaRealizada'Fecha Realizada', r.cFechaEntrada'Fecha Entrada', r.cFechaSalida'Fecha Salida' FROM tAlojamientos a, tReservas r, tUsuarios u WHERE r.cCodAlojamiento = a.cCodAlojamiento AND r.cCodUsuario = u.cDni order by a.cCodAlojamiento DESC"
	'Volver
	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        MenuGestion.Show()
        Me.Close()
    End Sub
	'Cargar la lista de las reservas
	Private Sub VistaReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		deshabilitarTxt()
		funciones.CargarGrid(DataGridView1, queryReservas)
	End Sub

	Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

		Dim indice = DataGridView1.CurrentCell.RowIndex
		txtNombreAloj.Text = DataGridView1.Rows(indice).Cells(1).Value
		txtDni.Text = DataGridView1.Rows(indice).Cells(2).Value
		txtNombreUsuario.Text = DataGridView1.Rows(indice).Cells(3).Value
		txtApellidos.Text = DataGridView1.Rows(indice).Cells(4).Value
		txtTelefonoAlo.Text = DataGridView1.Rows(indice).Cells(5).Value
		txtFechaReserva.Text = DataGridView1.Rows(indice).Cells(6).Value
		dtpFechaEntrada.Value = DataGridView1.Rows(indice).Cells(7).Value
		dtpFechaSalida.Value = DataGridView1.Rows(indice).Cells(8).Value
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
		Dim indiceSelect As Integer = DataGridView1.CurrentCell.RowIndex
		Dim query As String
        txtDni.Text = DataGridView1.Rows(indiceSelect).Cells(0).Value
        If txtDni.Text = "" Or txtDni.Text = Nothing Then
            MsgBox("No tienes seleccionado ninguna reserva")
        Else
            Dim result As DialogResult = MessageBox.Show("Estas seguro que quieres eliminar esta reserva?", "Atencion", MessageBoxButtons.YesNo)
            If (result = DialogResult.Yes) Then
                query = "DELETE FROM treservas WHERE cReserva = " & DataGridView1.Rows(indiceSelect).Cells(0).Value
                funciones.LLamadaBD(query)
            End If
            funciones.CargarGrid(DataGridView1, queryReservas)
        End If
    End Sub
	'BOTON CANCELAR
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
		dtpFechaEntrada.Enabled = False
		dtpFechaSalida.Enabled = False
		btnCancelar.Visible = False
		btnGuardar.Visible = False
	End Sub

	'BOTON MODIFICAR
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
		dtpFechaEntrada.Enabled = True
		dtpFechaSalida.Enabled = True
		btnCancelar.Visible = True
        btnGuardar.Visible = True
        dtpFechaEntrada.Select()
    End Sub
	'BOTON GUARDAR
	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim result As DialogResult = MessageBox.Show("Estas seguro que quieres guardar los datos este usuario?", "Atencion", MessageBoxButtons.YesNo)
		Dim indiceSelect As Integer = DataGridView1.CurrentCell.RowIndex
		Dim codigo = DataGridView1.Rows(indiceSelect).Cells(0).Value

		If result = DialogResult.Yes Then
			Dim fecha1 As Date = dtpFechaEntrada.Value
			Dim fecha2 As Date = dtpFechaSalida.Value
			Dim query As String = "UPDATE tReservas SET cFechaEntrada = '" & fecha1.Year & "-" & fecha1.Month & "-" & fecha1.Day & "', cFechaSalida = '" & fecha2.Year & "-" & fecha2.Month & "-" & fecha2.Day & "' WHERE cReserva = " & codigo
			funciones.LLamadaBD(query)
            MessageBox.Show("Reserva guardada con exito!")
        End If
		dtpFechaEntrada.Enabled = False
		dtpFechaSalida.Enabled = False
		btnCancelar.Visible = False
        btnGuardar.Visible = False
        funciones.CargarGrid(DataGridView1, queryReservas)

    End Sub

    Private Sub lblSalir_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
        Application.ExitThread()
    End Sub
	Sub deshabilitarTxt()
		For Each ctrl In Me.Controls
			If TypeOf ctrl Is TextBox Then
				ctrl.Enabled = False
			End If
		Next
		DataGridView1.Enabled = True
		'btnCrear.Enabled = True
		'btnModificar.Enabled = True
		'btnEliminar.Enabled = True
		'btnVolver.Enabled = True

	End Sub
    'boton volver
    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
		MenuGestion.Show()
		Me.Close()
	End Sub

	Private Sub DtpFechaEntrada_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaEntrada.ValueChanged
		Console.WriteLine(dtpFechaEntrada.ToString())
        dtpFechaSalida.MinDate = dtpFechaEntrada.Value.AddDays(0)
    End Sub
End Class