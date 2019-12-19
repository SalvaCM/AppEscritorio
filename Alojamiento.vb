Public Class Alojamiento
	Public codigo As Integer
	Public nombre As String
	Public descripcion As String
	Public tipo As String
	Public localizacion As String
	Public telefono As Integer
	Public dir As String
	Public localidad As String
	Public email As String
	Public web As String
	Public capacidad As String
	Public Sub New(codigo As Integer, nombre As String, descripcion As String, tipo As String, localizacion As String, telefono As Integer, dir As String, localidad As String, email As String, web As String, capacidad As String)
		Me.codigo = codigo
		Me.nombre = nombre
		Me.descripcion = descripcion
		Me.tipo = tipo
		Me.localizacion = localizacion
		Me.telefono = telefono
		Me.dir = dir
		Me.localidad = localidad
		Me.email = email
		Me.web = web
		Me.capacidad = capacidad
	End Sub

	Public Sub New()
	End Sub

End Class
'Private Structure Direccion
'Dim calle As String
'Dim numero As Integer
'End Structure
'Dim dir As Direccion