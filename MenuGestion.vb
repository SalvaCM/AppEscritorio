Imports MySql.Data.MySqlClient

Public Class MenuGestion
    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        vistaUsuarios.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        vistaAlojamientos.Show()
        Me.Hide()
    End Sub

    Private Sub MenuGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim conexion As New Conexion
        'conexion.Conectar()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        vistaReservas.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        Dim contador As Integer = 2
        'Start a new workbook in Excel    
        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Add

        'Add data to cells of the first worksheet in the new workbook    
        oSheet = oBook.Worksheets(1)
        'Ponemos la parte de arriba de la tabla
        oSheet.Range("A1").Value = "DNI"
        oSheet.Range("B1").Value = "Nombre"
        oSheet.Range("C1").Value = "Apellidos"
        oSheet.Range("D1").Value = "Telefono"
        oSheet.Range("E1").Value = "Apellidos"
        oSheet.Range("A1:E1").Font.Bold = True

        Dim con As String = "Server=192.168.101.24; Database=alojamientos; Uid=grupoAlojamientos; Pwd=123456"
        Dim query As String = "SELECT * FROM tUsuarios"
        Using sqlConn As New MySqlConnection(con)
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = sqlConn
                    .CommandText = query
                    .CommandType = CommandType.Text
                End With
                Try
                    sqlConn.Open()
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    'vamos leyendo en la base de datos e introduciendo los elementos en el excel
                    While sqlReader.Read()

                        oSheet.Range("A" & contador).Value = sqlReader("cDni").ToString()
                        oSheet.Range("B" & contador).Value = sqlReader("cNombre").ToString()
                        oSheet.Range("C" & contador).Value = sqlReader("cApellidos").ToString()
                        oSheet.Range("D" & contador).Value = sqlReader("cTelefono").ToString()
                        oSheet.Range("E" & contador).Value = sqlReader("cTipoUsuario").ToString()
                        contador = contador + 1

                    End While
                Catch ex As MySqlException
                    ' add your exception here '
                End Try
            End Using
        End Using


        'Guardar los elementos en el xlsx
        oBook.SaveAs("C:\Users\IN1DM3B_03\Desktop\prueba.xlsx")
        oExcel.Quit

        MsgBox("Informe Generado!")
    End Sub
End Class
