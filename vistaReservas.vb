Imports MySql.Data.MySqlClient
Public Class vistaReservas
    Public con As New MySqlConnection("Server=192.168.101.24; Database=alojamientos; Uid=grupoAlojamientos; Pwd=123456")
    Public query As String = "SELECT r.cReserva'Codigo Reserva', a.cNombre'Nombre Apartamento', u.cDni'DNI', u.cNombre'Nombre Usuario', u.cApellidos'Apellidos', u.cTelefono'Telefono Usuario', r.cFechaRealizada'Fecha Realizada', r.cFechaEntrada'Fecha Entrada', r.cFechaSalida'Fecha Saluda' FROM talojamientos a, treservas r, tusuarios u WHERE r.cCodAlojamiento = a.cCodAlojamiento AND cCodUsuario = cDni"
    Public adapter As New MySqlDataAdapter(query, con)
    'Volver
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MenuGestion.Show()
        Me.Close()
    End Sub
    'Cargar la lista de las reservas
    Private Sub VistaReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaGrid()

    End Sub

    Private Sub cargaGrid()
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridView1.DataSource = tabla
        con.Close()
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
                    con.Open()
                    Dim mysc As New MySqlCommand(query, con)
                    mysc.ExecuteNonQuery()
                    MessageBox.Show("Reserva eliminada!")
                    con.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
            cargaGrid()
        End If
    End Sub
End Class