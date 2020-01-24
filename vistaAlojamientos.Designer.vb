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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.btnVolver = New System.Windows.Forms.Button()
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
		Me.lblSalir = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnVolver
		'
		Me.btnVolver.BackColor = System.Drawing.Color.Black
		Me.btnVolver.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnVolver.ForeColor = System.Drawing.Color.White
		Me.btnVolver.Location = New System.Drawing.Point(1087, 739)
		Me.btnVolver.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.btnVolver.Name = "btnVolver"
		Me.btnVolver.Size = New System.Drawing.Size(96, 43)
		Me.btnVolver.TabIndex = 29
		Me.btnVolver.Text = "VOLVER"
		Me.btnVolver.UseVisualStyleBackColor = False
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.Black
		Me.btnEliminar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEliminar.ForeColor = System.Drawing.Color.White
		Me.btnEliminar.Location = New System.Drawing.Point(1100, 71)
		Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(78, 29)
		Me.btnEliminar.TabIndex = 28
		Me.btnEliminar.Text = "ELIMINAR"
		Me.btnEliminar.UseVisualStyleBackColor = False
		'
		'btnModificar
		'
		Me.btnModificar.BackColor = System.Drawing.Color.Black
		Me.btnModificar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnModificar.ForeColor = System.Drawing.Color.White
		Me.btnModificar.Location = New System.Drawing.Point(1020, 71)
		Me.btnModificar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.btnModificar.Name = "btnModificar"
		Me.btnModificar.Size = New System.Drawing.Size(76, 29)
		Me.btnModificar.TabIndex = 27
		Me.btnModificar.Text = "MODIFICAR"
		Me.btnModificar.UseVisualStyleBackColor = False
		'
		'btnCrear
		'
		Me.btnCrear.BackColor = System.Drawing.Color.Black
		Me.btnCrear.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCrear.ForeColor = System.Drawing.Color.White
		Me.btnCrear.Location = New System.Drawing.Point(938, 71)
		Me.btnCrear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.btnCrear.Name = "btnCrear"
		Me.btnCrear.Size = New System.Drawing.Size(78, 29)
		Me.btnCrear.TabIndex = 26
		Me.btnCrear.Text = "CREAR"
		Me.btnCrear.UseVisualStyleBackColor = False
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.ForeColor = System.Drawing.Color.White
		Me.Label15.Location = New System.Drawing.Point(20, 32)
		Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(315, 36)
		Me.Label15.TabIndex = 62
		Me.Label15.Text = "GESTION DE ALOJAMIENTOS"
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AllowUserToResizeRows = False
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
		Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.DataGridView1.BackgroundColor = System.Drawing.Color.Black
		Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(26, 71)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.DataGridView1.MultiSelect = False
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowHeadersVisible = False
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(886, 622)
		Me.DataGridView1.TabIndex = 63
		'
		'txtLocalizacion
		'
		Me.txtLocalizacion.Enabled = False
		Me.txtLocalizacion.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLocalizacion.Location = New System.Drawing.Point(968, 457)
		Me.txtLocalizacion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.txtLocalizacion.Name = "txtLocalizacion"
		Me.txtLocalizacion.Size = New System.Drawing.Size(189, 23)
		Me.txtLocalizacion.TabIndex = 108
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.ForeColor = System.Drawing.Color.White
		Me.Label10.Location = New System.Drawing.Point(968, 439)
		Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(85, 17)
		Me.Label10.TabIndex = 113
		Me.Label10.Text = "LOCALIZACION :"
		'
		'txtTipo
		'
		Me.txtTipo.Enabled = False
		Me.txtTipo.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTipo.Location = New System.Drawing.Point(968, 499)
		Me.txtTipo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.txtTipo.Name = "txtTipo"
		Me.txtTipo.Size = New System.Drawing.Size(189, 23)
		Me.txtTipo.TabIndex = 109
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.ForeColor = System.Drawing.Color.White
		Me.Label11.Location = New System.Drawing.Point(968, 481)
		Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(37, 17)
		Me.Label11.TabIndex = 111
		Me.Label11.Text = "TIPO :"
		'
		'txtDireccion
		'
		Me.txtDireccion.Enabled = False
		Me.txtDireccion.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDireccion.Location = New System.Drawing.Point(968, 247)
		Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.txtDireccion.Name = "txtDireccion"
		Me.txtDireccion.Size = New System.Drawing.Size(189, 23)
		Me.txtDireccion.TabIndex = 103
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.White
		Me.Label9.Location = New System.Drawing.Point(968, 229)
		Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(68, 17)
		Me.Label9.TabIndex = 109
		Me.Label9.Text = "DIRECCION :"
		'
		'txtCodigo
		'
		Me.txtCodigo.Enabled = False
		Me.txtCodigo.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCodigo.Location = New System.Drawing.Point(968, 121)
		Me.txtCodigo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.txtCodigo.Name = "txtCodigo"
		Me.txtCodigo.Size = New System.Drawing.Size(189, 23)
		Me.txtCodigo.TabIndex = 100
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Location = New System.Drawing.Point(968, 103)
		Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(52, 17)
		Me.Label6.TabIndex = 107
		Me.Label6.Text = "CODIGO :"
		'
		'txtDescripcion
		'
		Me.txtDescripcion.Enabled = False
		Me.txtDescripcion.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDescripcion.Location = New System.Drawing.Point(968, 205)
		Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.txtDescripcion.Name = "txtDescripcion"
		Me.txtDescripcion.Size = New System.Drawing.Size(189, 23)
		Me.txtDescripcion.TabIndex = 102
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.Color.White
		Me.Label7.Location = New System.Drawing.Point(968, 187)
		Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(82, 17)
		Me.Label7.TabIndex = 105
		Me.Label7.Text = "DESCRIPCION :"
		'
		'txtNombre
		'
		Me.txtNombre.Enabled = False
		Me.txtNombre.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNombre.Location = New System.Drawing.Point(968, 163)
		Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(189, 23)
		Me.txtNombre.TabIndex = 101
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.Color.White
		Me.Label8.Location = New System.Drawing.Point(968, 145)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(55, 17)
		Me.Label8.TabIndex = 103
		Me.Label8.Text = "NOMBRE :"
		'
		'txtMail
		'
		Me.txtMail.Enabled = False
		Me.txtMail.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMail.Location = New System.Drawing.Point(968, 289)
		Me.txtMail.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.txtMail.Name = "txtMail"
		Me.txtMail.Size = New System.Drawing.Size(189, 23)
		Me.txtMail.TabIndex = 104
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(968, 271)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(47, 17)
		Me.Label4.TabIndex = 101
		Me.Label4.Text = "E-MAIL :"
		'
		'txtLocalidad
		'
		Me.txtLocalidad.Enabled = False
		Me.txtLocalidad.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLocalidad.Location = New System.Drawing.Point(968, 415)
		Me.txtLocalidad.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.txtLocalidad.Name = "txtLocalidad"
		Me.txtLocalidad.Size = New System.Drawing.Size(189, 23)
		Me.txtLocalidad.TabIndex = 107
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(968, 397)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(69, 17)
		Me.Label3.TabIndex = 99
		Me.Label3.Text = "LOCALIDAD :"
		'
		'txtLongitud
		'
		Me.txtLongitud.Enabled = False
		Me.txtLongitud.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLongitud.Location = New System.Drawing.Point(968, 373)
		Me.txtLongitud.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.txtLongitud.Name = "txtLongitud"
		Me.txtLongitud.Size = New System.Drawing.Size(189, 23)
		Me.txtLongitud.TabIndex = 106
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(968, 355)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(63, 17)
		Me.Label2.TabIndex = 97
		Me.Label2.Text = "LONGITUD :"
		'
		'txtLatitud
		'
		Me.txtLatitud.Enabled = False
		Me.txtLatitud.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLatitud.Location = New System.Drawing.Point(968, 331)
		Me.txtLatitud.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.txtLatitud.Name = "txtLatitud"
		Me.txtLatitud.Size = New System.Drawing.Size(189, 23)
		Me.txtLatitud.TabIndex = 105
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(968, 313)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(54, 17)
		Me.Label1.TabIndex = 95
		Me.Label1.Text = "LATITUD :"
		'
		'txtWeb
		'
		Me.txtWeb.Enabled = False
		Me.txtWeb.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWeb.Location = New System.Drawing.Point(968, 583)
		Me.txtWeb.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.txtWeb.Name = "txtWeb"
		Me.txtWeb.Size = New System.Drawing.Size(189, 23)
		Me.txtWeb.TabIndex = 111
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.White
		Me.Label5.Location = New System.Drawing.Point(968, 565)
		Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(36, 17)
		Me.Label5.TabIndex = 121
		Me.Label5.Text = "WEB :"
		'
		'txtCapacidad
		'
		Me.txtCapacidad.Enabled = False
		Me.txtCapacidad.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCapacidad.Location = New System.Drawing.Point(968, 625)
		Me.txtCapacidad.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.txtCapacidad.Name = "txtCapacidad"
		Me.txtCapacidad.Size = New System.Drawing.Size(189, 23)
		Me.txtCapacidad.TabIndex = 112
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.ForeColor = System.Drawing.Color.White
		Me.Label12.Location = New System.Drawing.Point(968, 607)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(73, 17)
		Me.Label12.TabIndex = 119
		Me.Label12.Text = "CAPACIDAD :"
		'
		'txtTelefono
		'
		Me.txtTelefono.Enabled = False
		Me.txtTelefono.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTelefono.Location = New System.Drawing.Point(968, 541)
		Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.txtTelefono.Name = "txtTelefono"
		Me.txtTelefono.Size = New System.Drawing.Size(189, 23)
		Me.txtTelefono.TabIndex = 110
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.ForeColor = System.Drawing.Color.White
		Me.Label13.Location = New System.Drawing.Point(968, 523)
		Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(60, 17)
		Me.Label13.TabIndex = 117
		Me.Label13.Text = "TELEFONO :"
		'
		'btnAceptar
		'
		Me.btnAceptar.BackColor = System.Drawing.Color.White
		Me.btnAceptar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAceptar.Location = New System.Drawing.Point(1010, 660)
		Me.btnAceptar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.btnAceptar.Name = "btnAceptar"
		Me.btnAceptar.Size = New System.Drawing.Size(70, 33)
		Me.btnAceptar.TabIndex = 125
		Me.btnAceptar.Text = "ACEPTAR"
		Me.btnAceptar.UseVisualStyleBackColor = False
		Me.btnAceptar.Visible = False
		'
		'btnCancelar
		'
		Me.btnCancelar.BackColor = System.Drawing.Color.White
		Me.btnCancelar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancelar.Location = New System.Drawing.Point(1087, 660)
		Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(70, 33)
		Me.btnCancelar.TabIndex = 126
		Me.btnCancelar.Text = "CANCELAR"
		Me.btnCancelar.UseVisualStyleBackColor = False
		Me.btnCancelar.Visible = False
		'
		'lblSalir
		'
		Me.lblSalir.AutoSize = True
		Me.lblSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSalir.ForeColor = System.Drawing.Color.White
		Me.lblSalir.Location = New System.Drawing.Point(1154, 9)
		Me.lblSalir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblSalir.Name = "lblSalir"
		Me.lblSalir.Size = New System.Drawing.Size(27, 31)
		Me.lblSalir.TabIndex = 129
		Me.lblSalir.Text = "x"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Harlow Solid Italic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.ForeColor = System.Drawing.Color.White
		Me.Label16.Location = New System.Drawing.Point(12, 755)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(311, 30)
		Me.Label16.TabIndex = 132
		Me.Label16.Text = "Alojamientos Euskadi Admin "
		'
		'vistaAlojamientos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(1194, 794)
		Me.ControlBox = False
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.lblSalir)
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
		Me.Controls.Add(Me.btnVolver)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnModificar)
		Me.Controls.Add(Me.btnCrear)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "vistaAlojamientos"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnVolver As Button
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
	Friend WithEvents lblSalir As Label
	Friend WithEvents Label16 As Label
End Class
