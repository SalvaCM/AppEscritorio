
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class vistaAlojamientos
	Public con As New MySqlConnection("Server=192.168.101.24; Database=alojamientos; Uid=grupoAlojamientos; Pwd=123456")
	Public adapter As New MySqlDataAdapter("SELECT * FROM TALOJAMIENTOS", con)
	Public indice As Integer
	Private Sub Alojamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim tabla As New DataTable()
		adapter.Fill(tabla)
		DataGridView1.DataSource = tabla
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Dim builder As New MySqlCommandBuilder(adapter)
	End Sub

	Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

		Dim codigo, capacidad As Integer
		Dim descripcion, direccion, email, tipo, localizacion, telefono, nombre, localidad, paginaWeb As String
		Dim latitud, longitud As String

		indice = DataGridView1.CurrentCell.RowIndex

		codigo = Convert.ToInt32(DataGridView1.Rows(indice).Cells(0).Value)
		capacidad = Convert.ToInt32(DataGridView1.Rows(indice).Cells(1).Value)
		telefono = DataGridView1.Rows(indice).Cells(10).Value
		descripcion = DataGridView1.Rows(indice).Cells(2).Value
		direccion = DataGridView1.Rows(indice).Cells(3).Value
		email = DataGridView1.Rows(indice).Cells(4).Value
		latitud = DataGridView1.Rows(indice).Cells(5).Value
		longitud = DataGridView1.Rows(indice).Cells(8).Value
		nombre = DataGridView1.Rows(indice).Cells(9).Value
		localidad = DataGridView1.Rows(indice).Cells(6).Value
		paginaWeb = DataGridView1.Rows(indice).Cells(12).Value
		tipo = DataGridView1.Rows(indice).Cells(11).Value
		localizacion = DataGridView1.Rows(indice).Cells(7).Value


		txtCodigo.Text = codigo.ToString
		txtCapacidad.Text = capacidad.ToString
		txtDescripcion.Text = descripcion
		txtDireccion.Text = direccion
		txtLatitud.Text = latitud
		txtLongitud.Text = longitud
		txtLocalidad.Text = localidad
		txtNombre.Text = nombre
		txtLocalidad.Text = localidad
		txtTelefono.Text = telefono
		txtMail.Text = email
		txtLocalizacion.Text = localizacion
		txtTipo.Text = tipo
		txtWeb.Text = paginaWeb

	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		indice = DataGridView1.CurrentCell.RowIndex


		Try
			Dim codigo As Integer = Convert.ToInt32(DataGridView1.Rows(indice).Cells(0).Value)
			con.Open()
			Dim query As String = "Delete From talojamientos where cCodAlojamiento=" & codigo


			If MessageBox.Show("Confirmar Borrado", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

				MsgBox("Cancelado")

				Exit Sub
			Else
				Dim cmd As New MySqlCommand(query, con)
				cmd.ExecuteNonQuery()
			End If
		Catch ex As Exception
			MessageBox.Show("Error borrando de la tabla..." & ex.Message, "Delete Records")

		Finally

			con.Close()
		End Try
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

	End Sub
End Class