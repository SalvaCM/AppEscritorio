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
		Dim conexion As New Conexion
		conexion.Conectar()
	End Sub
End Class
