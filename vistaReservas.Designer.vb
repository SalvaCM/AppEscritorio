<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vistaReservas
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
		Me.btnVolver = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnModificar = New System.Windows.Forms.Button()
		Me.txtDni = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtTelefonoAlo = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtApellidos = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtFechaSalida = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtFechaEntrada = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtFechaReserva = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.txtNombreAloj = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.lblSalir = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnVolver
		'
		Me.btnVolver.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnVolver.ForeColor = System.Drawing.Color.White
		Me.btnVolver.Location = New System.Drawing.Point(1088, 744)
		Me.btnVolver.Name = "btnVolver"
		Me.btnVolver.Size = New System.Drawing.Size(94, 41)
		Me.btnVolver.TabIndex = 78
		Me.btnVolver.Text = "VOLVER"
		Me.btnVolver.UseVisualStyleBackColor = False
		'
		'btnEliminar
		'
		Me.btnEliminar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEliminar.ForeColor = System.Drawing.Color.White
		Me.btnEliminar.Location = New System.Drawing.Point(1057, 75)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(83, 35)
		Me.btnEliminar.TabIndex = 77
		Me.btnEliminar.Text = "ELIMINAR"
		Me.btnEliminar.UseVisualStyleBackColor = False
		'
		'btnModificar
		'
		Me.btnModificar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnModificar.ForeColor = System.Drawing.Color.White
		Me.btnModificar.Location = New System.Drawing.Point(968, 75)
		Me.btnModificar.Name = "btnModificar"
		Me.btnModificar.Size = New System.Drawing.Size(83, 35)
		Me.btnModificar.TabIndex = 76
		Me.btnModificar.Text = "MODIFICAR"
		Me.btnModificar.UseVisualStyleBackColor = False
		'
		'txtDni
		'
		Me.txtDni.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDni.Location = New System.Drawing.Point(968, 305)
		Me.txtDni.Name = "txtDni"
		Me.txtDni.Size = New System.Drawing.Size(189, 23)
		Me.txtDni.TabIndex = 73
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(965, 288)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(31, 17)
		Me.Label4.TabIndex = 72
		Me.Label4.Text = "DNI :"
		'
		'txtTelefonoAlo
		'
		Me.txtTelefonoAlo.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTelefonoAlo.Location = New System.Drawing.Point(968, 434)
		Me.txtTelefonoAlo.Name = "txtTelefonoAlo"
		Me.txtTelefonoAlo.Size = New System.Drawing.Size(189, 23)
		Me.txtTelefonoAlo.TabIndex = 71
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(965, 417)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(60, 17)
		Me.Label3.TabIndex = 70
		Me.Label3.Text = "TELEFONO :"
		'
		'txtApellidos
		'
		Me.txtApellidos.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtApellidos.Location = New System.Drawing.Point(968, 391)
		Me.txtApellidos.Name = "txtApellidos"
		Me.txtApellidos.Size = New System.Drawing.Size(189, 23)
		Me.txtApellidos.TabIndex = 69
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(965, 374)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(67, 17)
		Me.Label2.TabIndex = 68
		Me.Label2.Text = "APELLIDOS :"
		'
		'txtNombreUsuario
		'
		Me.txtNombreUsuario.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNombreUsuario.Location = New System.Drawing.Point(968, 348)
		Me.txtNombreUsuario.Name = "txtNombreUsuario"
		Me.txtNombreUsuario.Size = New System.Drawing.Size(189, 23)
		Me.txtNombreUsuario.TabIndex = 67
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(965, 331)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(55, 17)
		Me.Label1.TabIndex = 66
		Me.Label1.Text = "NOMBRE :"
		'
		'txtFechaSalida
		'
		Me.txtFechaSalida.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFechaSalida.Location = New System.Drawing.Point(968, 215)
		Me.txtFechaSalida.Name = "txtFechaSalida"
		Me.txtFechaSalida.Size = New System.Drawing.Size(189, 23)
		Me.txtFechaSalida.TabIndex = 84
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.Color.White
		Me.Label7.Location = New System.Drawing.Point(965, 198)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(97, 17)
		Me.Label7.TabIndex = 83
		Me.Label7.Text = "FECHA DE SALIDA :"
		'
		'txtFechaEntrada
		'
		Me.txtFechaEntrada.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFechaEntrada.Location = New System.Drawing.Point(968, 172)
		Me.txtFechaEntrada.Name = "txtFechaEntrada"
		Me.txtFechaEntrada.Size = New System.Drawing.Size(189, 23)
		Me.txtFechaEntrada.TabIndex = 82
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.Color.White
		Me.Label8.Location = New System.Drawing.Point(965, 155)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(106, 17)
		Me.Label8.TabIndex = 81
		Me.Label8.Text = "FECHA DE ENTRADA :"
		'
		'txtFechaReserva
		'
		Me.txtFechaReserva.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFechaReserva.Location = New System.Drawing.Point(968, 260)
		Me.txtFechaReserva.Name = "txtFechaReserva"
		Me.txtFechaReserva.Size = New System.Drawing.Size(189, 23)
		Me.txtFechaReserva.TabIndex = 88
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.White
		Me.Label9.Location = New System.Drawing.Point(965, 243)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(105, 17)
		Me.Label9.TabIndex = 87
		Me.Label9.Text = "FECHA DE RESERVA :"
		'
		'txtNombreAloj
		'
		Me.txtNombreAloj.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNombreAloj.Location = New System.Drawing.Point(968, 129)
		Me.txtNombreAloj.Name = "txtNombreAloj"
		Me.txtNombreAloj.Size = New System.Drawing.Size(189, 23)
		Me.txtNombreAloj.TabIndex = 93
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.ForeColor = System.Drawing.Color.White
		Me.Label11.Location = New System.Drawing.Point(965, 113)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(123, 17)
		Me.Label11.TabIndex = 89
		Me.Label11.Text = "NOMBRE ALOJAMIENTO:"
		'
		'btnCancelar
		'
		Me.btnCancelar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancelar.Location = New System.Drawing.Point(1088, 470)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(69, 32)
		Me.btnCancelar.TabIndex = 96
		Me.btnCancelar.Text = "CANCELAR"
		Me.btnCancelar.UseVisualStyleBackColor = True
		Me.btnCancelar.Visible = False
		'
		'btnGuardar
		'
		Me.btnGuardar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGuardar.Location = New System.Drawing.Point(1013, 470)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(69, 32)
		Me.btnGuardar.TabIndex = 97
		Me.btnGuardar.Text = "GUARDAR"
		Me.btnGuardar.UseVisualStyleBackColor = True
		Me.btnGuardar.Visible = False
		'
		'lblSalir
		'
		Me.lblSalir.AutoSize = True
		Me.lblSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSalir.ForeColor = System.Drawing.Color.White
		Me.lblSalir.Location = New System.Drawing.Point(1145, 9)
		Me.lblSalir.Name = "lblSalir"
		Me.lblSalir.Size = New System.Drawing.Size(27, 31)
		Me.lblSalir.TabIndex = 130
		Me.lblSalir.Text = "x"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.ForeColor = System.Drawing.Color.White
		Me.Label15.Location = New System.Drawing.Point(25, 30)
		Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(263, 36)
		Me.Label15.TabIndex = 131
		Me.Label15.Text = "GESTION DE RESERVAS"
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
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AllowUserToResizeRows = False
		Me.DataGridView1.BackgroundColor = System.Drawing.Color.Black
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
		Me.DataGridView1.Location = New System.Drawing.Point(31, 69)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
		Me.DataGridView1.MultiSelect = False
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(887, 609)
		Me.DataGridView1.TabIndex = 133
		'
		'vistaReservas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(1194, 794)
		Me.ControlBox = False
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.lblSalir)
		Me.Controls.Add(Me.btnGuardar)
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.txtNombreAloj)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.txtFechaReserva)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.txtFechaSalida)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.txtFechaEntrada)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.btnVolver)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnModificar)
		Me.Controls.Add(Me.txtDni)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtTelefonoAlo)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtApellidos)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtNombreUsuario)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "vistaReservas"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnVolver As Button
	Friend WithEvents btnEliminar As Button
	Friend WithEvents btnModificar As Button
	Friend WithEvents txtDni As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtTelefonoAlo As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtApellidos As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtNombreUsuario As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents txtFechaSalida As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents txtFechaEntrada As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents txtFechaReserva As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents txtNombreAloj As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents btnCancelar As Button
	Friend WithEvents btnGuardar As Button
	Friend WithEvents lblSalir As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents Label16 As Label
	Friend WithEvents DataGridView1 As DataGridView
End Class
