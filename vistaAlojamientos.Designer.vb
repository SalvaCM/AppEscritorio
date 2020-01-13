<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vistaAlojamientos
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnModificar = New System.Windows.Forms.Button()
		Me.btnCrear = New System.Windows.Forms.Button()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.txtLocalizacion = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtTipo = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtDireccion = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.txtCodigo = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtDescripcion = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtMail = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtLocalidad = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtLongitud = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtLatitud = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtWeb = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtCapacidad = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtTelefono = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.btnAceptar = New System.Windows.Forms.Button()
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(1005, 717)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(75, 23)
		Me.Button4.TabIndex = 29
		Me.Button4.Text = "Volver"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'btnEliminar
		'
		Me.btnEliminar.Location = New System.Drawing.Point(1021, 45)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
		Me.btnEliminar.TabIndex = 28
		Me.btnEliminar.Text = "ELIMINAR"
		Me.btnEliminar.UseVisualStyleBackColor = True
		'
		'btnModificar
		'
		Me.btnModificar.Location = New System.Drawing.Point(940, 45)
		Me.btnModificar.Name = "btnModificar"
		Me.btnModificar.Size = New System.Drawing.Size(75, 23)
		Me.btnModificar.TabIndex = 27
		Me.btnModificar.Text = "MODIFICAR"
		Me.btnModificar.UseVisualStyleBackColor = True
		'
		'btnCrear
		'
		Me.btnCrear.Location = New System.Drawing.Point(859, 45)
		Me.btnCrear.Name = "btnCrear"
		Me.btnCrear.Size = New System.Drawing.Size(75, 23)
		Me.btnCrear.TabIndex = 26
		Me.btnCrear.Text = "CREAR"
		Me.btnCrear.UseVisualStyleBackColor = True
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(13, 13)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(389, 29)
		Me.Label15.TabIndex = 62
		Me.Label15.Text = "GESTION DE ALOJAMIENTOS :"
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(18, 45)
		Me.DataGridView1.MultiSelect = False
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(832, 593)
		Me.DataGridView1.TabIndex = 63
		'
		'txtLocalizacion
		'
		Me.txtLocalizacion.Enabled = False
		Me.txtLocalizacion.Location = New System.Drawing.Point(859, 444)
		Me.txtLocalizacion.Name = "txtLocalizacion"
		Me.txtLocalizacion.Size = New System.Drawing.Size(189, 20)
		Me.txtLocalizacion.TabIndex = 108
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(857, 427)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(90, 13)
		Me.Label10.TabIndex = 113
		Me.Label10.Text = "LOCALIZACION :"
		'
		'txtTipo
		'
		Me.txtTipo.Enabled = False
		Me.txtTipo.Location = New System.Drawing.Point(859, 487)
		Me.txtTipo.Name = "txtTipo"
		Me.txtTipo.Size = New System.Drawing.Size(189, 20)
		Me.txtTipo.TabIndex = 109
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(857, 470)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(38, 13)
		Me.Label11.TabIndex = 111
		Me.Label11.Text = "TIPO :"
		'
		'txtDireccion
		'
		Me.txtDireccion.Enabled = False
		Me.txtDireccion.Location = New System.Drawing.Point(859, 225)
		Me.txtDireccion.Name = "txtDireccion"
		Me.txtDireccion.Size = New System.Drawing.Size(189, 20)
		Me.txtDireccion.TabIndex = 103
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(857, 208)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(72, 13)
		Me.Label9.TabIndex = 109
		Me.Label9.Text = "DIRECCION :"
		'
		'txtCodigo
		'
		Me.txtCodigo.Enabled = False
		Me.txtCodigo.Location = New System.Drawing.Point(859, 94)
		Me.txtCodigo.Name = "txtCodigo"
		Me.txtCodigo.Size = New System.Drawing.Size(189, 20)
		Me.txtCodigo.TabIndex = 100
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(856, 77)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(55, 13)
		Me.Label6.TabIndex = 107
		Me.Label6.Text = "CODIGO :"
		'
		'txtDescripcion
		'
		Me.txtDescripcion.Enabled = False
		Me.txtDescripcion.Location = New System.Drawing.Point(859, 180)
		Me.txtDescripcion.Name = "txtDescripcion"
		Me.txtDescripcion.Size = New System.Drawing.Size(189, 20)
		Me.txtDescripcion.TabIndex = 102
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(856, 163)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(86, 13)
		Me.Label7.TabIndex = 105
		Me.Label7.Text = "DESCRIPCION :"
		'
		'txtNombre
		'
		Me.txtNombre.Enabled = False
		Me.txtNombre.Location = New System.Drawing.Point(859, 137)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(189, 20)
		Me.txtNombre.TabIndex = 101
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(856, 120)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(60, 13)
		Me.Label8.TabIndex = 103
		Me.Label8.Text = "NOMBRE :"
		'
		'txtMail
		'
		Me.txtMail.Enabled = False
		Me.txtMail.Location = New System.Drawing.Point(859, 270)
		Me.txtMail.Name = "txtMail"
		Me.txtMail.Size = New System.Drawing.Size(189, 20)
		Me.txtMail.TabIndex = 104
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(857, 253)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(48, 13)
		Me.Label4.TabIndex = 101
		Me.Label4.Text = "E-MAIL :"
		'
		'txtLocalidad
		'
		Me.txtLocalidad.Enabled = False
		Me.txtLocalidad.Location = New System.Drawing.Point(859, 399)
		Me.txtLocalidad.Name = "txtLocalidad"
		Me.txtLocalidad.Size = New System.Drawing.Size(189, 20)
		Me.txtLocalidad.TabIndex = 107
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(857, 382)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(73, 13)
		Me.Label3.TabIndex = 99
		Me.Label3.Text = "LOCALIDAD :"
		'
		'txtLongitud
		'
		Me.txtLongitud.Enabled = False
		Me.txtLongitud.Location = New System.Drawing.Point(859, 356)
		Me.txtLongitud.Name = "txtLongitud"
		Me.txtLongitud.Size = New System.Drawing.Size(189, 20)
		Me.txtLongitud.TabIndex = 106
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(857, 339)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(69, 13)
		Me.Label2.TabIndex = 97
		Me.Label2.Text = "LONGITUD :"
		'
		'txtLatitud
		'
		Me.txtLatitud.Enabled = False
		Me.txtLatitud.Location = New System.Drawing.Point(859, 313)
		Me.txtLatitud.Name = "txtLatitud"
		Me.txtLatitud.Size = New System.Drawing.Size(189, 20)
		Me.txtLatitud.TabIndex = 105
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(857, 296)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(59, 13)
		Me.Label1.TabIndex = 95
		Me.Label1.Text = "LATITUD :"
		'
		'txtWeb
		'
		Me.txtWeb.Enabled = False
		Me.txtWeb.Location = New System.Drawing.Point(859, 575)
		Me.txtWeb.Name = "txtWeb"
		Me.txtWeb.Size = New System.Drawing.Size(189, 20)
		Me.txtWeb.TabIndex = 111
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(857, 558)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(38, 13)
		Me.Label5.TabIndex = 121
		Me.Label5.Text = "WEB :"
		'
		'txtCapacidad
		'
		Me.txtCapacidad.Enabled = False
		Me.txtCapacidad.Location = New System.Drawing.Point(859, 618)
		Me.txtCapacidad.Name = "txtCapacidad"
		Me.txtCapacidad.Size = New System.Drawing.Size(189, 20)
		Me.txtCapacidad.TabIndex = 112
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(857, 601)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(74, 13)
		Me.Label12.TabIndex = 119
		Me.Label12.Text = "CAPACIDAD :"
		'
		'txtTelefono
		'
		Me.txtTelefono.Enabled = False
		Me.txtTelefono.Location = New System.Drawing.Point(859, 530)
		Me.txtTelefono.Name = "txtTelefono"
		Me.txtTelefono.Size = New System.Drawing.Size(189, 20)
		Me.txtTelefono.TabIndex = 110
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(857, 513)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(70, 13)
		Me.Label13.TabIndex = 117
		Me.Label13.Text = "TELEFONO :"
		'
		'btnAceptar
		'
		Me.btnAceptar.Location = New System.Drawing.Point(860, 644)
		Me.btnAceptar.Name = "btnAceptar"
		Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
		Me.btnAceptar.TabIndex = 125
		Me.btnAceptar.Text = "ACEPTAR"
		Me.btnAceptar.UseVisualStyleBackColor = True
		Me.btnAceptar.Visible = False
		'
		'btnCancelar
		'
		Me.btnCancelar.Location = New System.Drawing.Point(973, 644)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
		Me.btnCancelar.TabIndex = 126
		Me.btnCancelar.Text = "CANCELAR"
		Me.btnCancelar.UseVisualStyleBackColor = True
		Me.btnCancelar.Visible = False
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(18, 644)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(156, 35)
		Me.Button1.TabIndex = 127
		Me.Button1.Text = "Generar Informe"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'vistaAlojamientos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1108, 761)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.btnAceptar)
		Me.Controls.Add(Me.txtWeb)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtCapacidad)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.txtTelefono)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.txtLocalizacion)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.txtTipo)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.txtDireccion)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.txtCodigo)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtDescripcion)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.txtNombre)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.txtMail)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtLocalidad)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtLongitud)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtLatitud)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnModificar)
		Me.Controls.Add(Me.btnCrear)
		Me.Name = "vistaAlojamientos"
		Me.Text = "Alojamientos"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button4 As Button
	Friend WithEvents btnEliminar As Button
	Friend WithEvents btnModificar As Button
	Friend WithEvents btnCrear As Button
	Friend WithEvents Label15 As Label
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents txtLocalizacion As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents txtTipo As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents txtDireccion As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents txtCodigo As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents txtDescripcion As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents txtNombre As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents txtMail As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtLocalidad As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtLongitud As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtLatitud As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents txtWeb As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents txtCapacidad As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents txtTelefono As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents btnAceptar As Button
	Friend WithEvents btnCancelar As Button
	Friend WithEvents Button1 As Button
End Class
