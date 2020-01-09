Imports MySql.Data.MySqlClient
Public Class vistaReservas
    Public con As New MySqlConnection("Server=192.168.101.24; Database=alojamientos; Uid=grupoAlojamientos; Pwd=123456")
    Public query As String = "SELECT a.cNombre'Nombre Apartamento', u.cDni'DNI', u.cNombre'Nombre Usuario', u.cApellidos'Apellidos', u.cTelefono'Telefono Usuario', r.cFechaRealizada'Fecha Realizada', r.cFechaEntrada'Fecha Entrada', r.cFechaSalida'Fecha Saluda' FROM talojamientos a, treservas r, tusuarios u WHERE r.cCodAlojamiento = a.cCodAlojamiento AND cCodUsuario = cDni"
    Public adapter As New MySqlDataAdapter(query, con)
    'Volver
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MenuGestion.Show()
        Me.Close()
    End Sub
    'Cargar la lista de las reservas
    Private Sub VistaReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrid()

    End Sub

    Private Sub cargarGrid()
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridView1.DataSource = tabla
        con.Close()
    End Sub
End Class