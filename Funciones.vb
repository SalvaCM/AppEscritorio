Imports MySql.Data.MySqlClient

Public Class Funciones
    Dim Conexion As New Conexion
    Public Sub CargarGrid(DataGridView1 As DataGridView, adapter As MySqlDataAdapter)
        Conexion.con.Open()
        Dim tabla As New DataTable()
        adapter.Fill(tabla)
        DataGridView1.DataSource = tabla
        Conexion.con.Close()
        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub
    Public Sub LLamadaBD(query As String)
        Try
            Conexion.con.Open()
            Dim cmd As New MySqlCommand(query, Conexion.con)
            cmd.ExecuteNonQuery()
            MsgBox("Modificado Correctamente!")
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
End Class
