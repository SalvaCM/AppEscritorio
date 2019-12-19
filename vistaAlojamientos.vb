
Imports MySql.Data.MySqlClient

Public Class vistaAlojamientos
	Public con As New MySqlConnection("Server=192.168.101.24; Database=alojamientos; Uid=grupoAlojamientos; Pwd=123456")
	Public adapter As New MySqlDataAdapter("SELECT * FROM TALOJAMIENTOS", con)
	Private Sub Alojamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim tabla As New DataTable()
		adapter.Fill(tabla)
		DataGridView1.DataSource = tabla
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Dim builder As New MySqlCommandBuilder(adapter)
	End Sub
End Class