Imports MySql.Data.MySqlClient
Public Class vistaReservas
    Dim funciones As New Funciones
    Public queryReservas As String = "SELECT r.cReserva'Codigo Reserva', a.cNombre'Nombre Apartamento', u.cDni'DNI', u.cNombre'Nombre Usuario', u.cApellidos'Apellidos', u.cTelefono'Telefono Usuario', r.cFechaRealizada'Fecha Realizada', r.cFechaEntrada'Fecha Entrada', r.cFechaSalida'Fecha Saluda' FROM tAlojamientos a, tReservas r, tUsuarios u WHERE r.cCodAlojamiento = a.cCodAlojamiento AND cCodUsuario = cDni"
    Public adapter As New MySqlDataAdapter
    'Volver
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        MenuGestion.Show()
        Me.Close()
    End Sub
    'Cargar la lista de las reservas
    Private Sub VistaReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deshabilitarTxt()
        btnCancelar.Visible = False
        btnGuardar.Visible = False
        funciones.CargarGrid(DataGridView1, queryReservas)

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim indiceSelect As Integer = DataGridView1.SelectedCells.Item(0).RowIndex
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
        txtFechaEntrada.Enabled = False
        txtFechaSalida.Enabled = False
        btnCancelar.Visible = False
        btnGuardar.Visible = False
    End Sub

    'BOTON MODIFICAR
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtFechaEntrada.Enabled = True
        txtFechaSalida.Enabled = True
        btnCancelar.Visible = True
        btnGuardar.Visible = True
    End Sub
    'BOTON GUARDAR
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim result As DialogResult = MessageBox.Show("Estas seguro que quieres guardar los datos este usuario?", "Atencion", MessageBoxButtons.YesNo)
        Dim indiceSelect As Integer = DataGridView1.SelectedCells.Item(0).RowIndex
        Dim codigo = DataGridView1.Rows(indiceSelect).Cells(0).Value

        If result = DialogResult.Yes Then
            Dim fecha1 As Date = txtFechaEntrada.Text
            Dim fecha2 As Date = txtFechaSalida.Text
            Dim query As String = "UPDATE tReservas SET cFechaEntrada = '" & fecha1.Year & "-" & fecha1.Month & "-" & fecha1.Day & "', cFechaSalida = '" & fecha2.Year & "-" & fecha2.Month & "-" & fecha2.Day & "' WHERE cReserva = " & codigo
            funciones.LLamadaBD(query)
            MessageBox.Show("Usuario guardado con exito!")
        End If
        txtFechaEntrada.Enabled = False
        txtFechaSalida.Enabled = False
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

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub txtNombreAloj_TextChanged(sender As Object, e As EventArgs) Handles txtNombreAloj.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtFechaEntrada_TextChanged(sender As Object, e As EventArgs) Handles txtFechaEntrada.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtFechaSalida_TextChanged(sender As Object, e As EventArgs) Handles txtFechaSalida.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub txtFechaReserva_TextChanged(sender As Object, e As EventArgs) Handles txtFechaReserva.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtDni_TextChanged(sender As Object, e As EventArgs) Handles txtDni.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtNombreUsuario.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtApellidos_TextChanged(sender As Object, e As EventArgs) Handles txtApellidos.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtTelefonoAlo_TextChanged(sender As Object, e As EventArgs) Handles txtTelefonoAlo.TextChanged

    End Sub
End Class