Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Funciones
	Dim Conexion As New Conexion
	Public Sub CargarGrid(DataGridView1 As DataGridView, query As String)
		Dim adapter As New MySqlDataAdapter(query, Conexion.con)
		Try
			Conexion.con.Open()
			Dim tabla As New DataTable()
			adapter.Fill(tabla)
			DataGridView1.DataSource = tabla
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error")
			'Console.WriteLine(ex.Message)
		Finally
			Conexion.con.Close()
		End Try
		For Each column As DataGridViewColumn In DataGridView1.Columns
			column.SortMode = DataGridViewColumnSortMode.NotSortable
		Next
	End Sub
	Public Sub LLamadaBD(query As String)
		Try
			Conexion.con.Open()
			Dim cmd As New MySqlCommand(query, Conexion.con)
			cmd.ExecuteNonQuery()
			'MsgBox("Cambios Guardados!")
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error")
			Console.WriteLine(ex.Message)
		Finally
			Conexion.con.Close()
		End Try
	End Sub
	Function maxCod(campo As String, tabla As String)
		Dim maxCodigo As Integer
		Try
			Conexion.con.Open()
			Dim query As String = "SELECT max(" & campo & ") FROM " & tabla & ""
			Dim cmd As New MySqlCommand(query, Conexion.con)
			maxCodigo = cmd.ExecuteScalar()
			If (maxCodigo <> Nothing) Then

				maxCodigo += 1
			Else
				maxCodigo = -1

			End If
		Catch ex As Exception
			MessageBox.Show("No se pudo obtener el codigo" & ex.Message, "Error")
			maxCodigo = -1
		Finally
			Conexion.con.Close()
		End Try
		Return maxCodigo
	End Function
	Function dataReader(query As String)
		Dim reader As MySqlDataReader
		Dim userData(2) As String
		Try
			Conexion.con.Open()
			Dim cmd As New MySqlCommand(query, Conexion.con)
			reader = cmd.ExecuteReader()
			While reader.Read()
				userData(0) = reader("cDni").ToString()
				userData(1) = reader("cContrasena").ToString()
				userData(2) = reader("cTipoUsuario").ToString()
			End While
		Catch ex As Exception
			MessageBox.Show("No se pudo obtener datos," & ex.Message, "Error")
			reader = Nothing
		Finally
			Conexion.con.Close()
		End Try
		Return userData
	End Function
	Function validarMail(ByVal sMail As String) As Boolean
		Return Regex.IsMatch(sMail, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$") ' retorna true o false
	End Function
End Class
