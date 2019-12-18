Public Class MenuGestion
	Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
		Usuarios.Show()
		Me.Hide()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Alojamientos.Show()
		Me.Hide()
	End Sub
End Class
