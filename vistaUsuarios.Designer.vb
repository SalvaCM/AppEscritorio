<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vistaUsuarios
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
		Me.lblSalir = New System.Windows.Forms.Label()
		Me.btnActualizar = New System.Windows.Forms.Button()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.busApellido = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.busNombre = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.btnModi = New System.Windows.Forms.Button()
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnModificar = New System.Windows.Forms.Button()
		Me.btnCrear = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtDni = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtTelefono = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtApellidos = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.busMail = New System.Windows.Forms.TextBox()
		Me.lbSalir = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()

		'
		'btnActualizar
		'
		Me.btnActualizar.BackColor = System.Drawing.Color.Black
		Me.btnActualizar.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnActualizar.ForeColor = System.Drawing.Color.White
		Me.btnActualizar.Location = New System.Drawing.Point(308, 105)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(94, 23)
		Me.btnActualizar.TabIndex = 160
		Me.btnActualizar.Text = "ACTUALIZAR"
		Me.btnActualizar.UseVisualStyleBackColor = False
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.Color.Black
		Me.btnBuscar.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBuscar.ForeColor = System.Drawing.Color.White
		Me.btnBuscar.Location = New System.Drawing.Point(408, 106)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(94, 23)
		Me.btnBuscar.TabIndex = 159
		Me.btnBuscar.Text = "BUSCAR"
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.White
		Me.Label9.Location = New System.Drawing.Point(78, 106)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(35, 15)
		Me.Label9.TabIndex = 157
		Me.Label9.Text = "EMAIL:"
		'
		'busApellido
		'
		Me.busApellido.Location = New System.Drawing.Point(308, 79)
		Me.busApellido.Name = "busApellido"
		Me.busApellido.Size = New System.Drawing.Size(125, 20)
		Me.busApellido.TabIndex = 156
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.Color.White
		Me.Label8.Location = New System.Drawing.Point(245, 82)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(57, 15)
		Me.Label8.TabIndex = 155
		Me.Label8.Text = "APELLIDOS :"
		'
		'busNombre
		'
		Me.busNombre.Location = New System.Drawing.Point(119, 79)
		Me.busNombre.Name = "busNombre"
		Me.busNombre.Size = New System.Drawing.Size(120, 20)
		Me.busNombre.TabIndex = 154
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.Color.White
		Me.Label7.Location = New System.Drawing.Point(65, 82)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(48, 15)
		Me.Label7.TabIndex = 153
		Me.Label7.Text = "NOMBRE :"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.ForeColor = System.Drawing.Color.White
		Me.Label15.Location = New System.Drawing.Point(76, 34)
		Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(251, 34)
		Me.Label15.TabIndex = 152
		Me.Label15.Text = "GESTION DE USUARIOS"
		'
		'btnModi
		'
		Me.btnModi.BackColor = System.Drawing.Color.White
		Me.btnModi.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnModi.Location = New System.Drawing.Point(970, 431)
		Me.btnModi.Name = "btnModi"
		Me.btnModi.Size = New System.Drawing.Size(75, 33)
		Me.btnModi.TabIndex = 150
		Me.btnModi.Text = "ACEPTAR"
		Me.btnModi.UseVisualStyleBackColor = False
		Me.btnModi.Visible = False
		'
		'btnCancelar
		'
		Me.btnCancelar.BackColor = System.Drawing.Color.White
		Me.btnCancelar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancelar.Location = New System.Drawing.Point(889, 431)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(75, 33)
		Me.btnCancelar.TabIndex = 149
		Me.btnCancelar.Text = "CANCELAR"
		Me.btnCancelar.UseVisualStyleBackColor = False
		Me.btnCancelar.Visible = False
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.BackgroundColor = System.Drawing.Color.Black
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(68, 144)
		Me.DataGridView1.MultiSelect = False
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.DataGridView1.RowHeadersVisible = False
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.ShowCellToolTips = False
		Me.DataGridView1.ShowEditingIcon = False
		Me.DataGridView1.Size = New System.Drawing.Size(702, 471)
		Me.DataGridView1.TabIndex = 148
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.Black
		Me.Button4.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.ForeColor = System.Drawing.Color.White
		Me.Button4.Location = New System.Drawing.Point(1067, 699)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(98, 43)
		Me.Button4.TabIndex = 146
		Me.Button4.Text = "VOLVER"
		Me.Button4.UseVisualStyleBackColor = False
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.Black
		Me.btnEliminar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEliminar.ForeColor = System.Drawing.Color.White
		Me.btnEliminar.Location = New System.Drawing.Point(1020, 159)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 33)
		Me.btnEliminar.TabIndex = 145
		Me.btnEliminar.Text = "ELIMINAR"
		Me.btnEliminar.UseVisualStyleBackColor = False
		'
		'btnModificar
		'
		Me.btnModificar.BackColor = System.Drawing.Color.Black
		Me.btnModificar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnModificar.ForeColor = System.Drawing.Color.White
		Me.btnModificar.Location = New System.Drawing.Point(936, 159)
		Me.btnModificar.Name = "btnModificar"
		Me.btnModificar.Size = New System.Drawing.Size(78, 33)
		Me.btnModificar.TabIndex = 144
		Me.btnModificar.Text = "MODIFICAR"
		Me.btnModificar.UseVisualStyleBackColor = False
		'
		'btnCrear
		'
		Me.btnCrear.BackColor = System.Drawing.Color.Black
		Me.btnCrear.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCrear.ForeColor = System.Drawing.Color.White
		Me.btnCrear.Location = New System.Drawing.Point(855, 159)
		Me.btnCrear.Name = "btnCrear"
		Me.btnCrear.Size = New System.Drawing.Size(75, 33)
		Me.btnCrear.TabIndex = 143
		Me.btnCrear.Text = "CREAR"
		Me.btnCrear.UseVisualStyleBackColor = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.White
		Me.Label5.Location = New System.Drawing.Point(853, 375)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(43, 17)
		Me.Label5.TabIndex = 142
		Me.Label5.Text = "EMAIL :"
		'
		'txtDni
		'
		Me.txtDni.Enabled = False
		Me.txtDni.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDni.Location = New System.Drawing.Point(856, 220)
		Me.txtDni.Name = "txtDni"
		Me.txtDni.Size = New System.Drawing.Size(189, 23)
		Me.txtDni.TabIndex = 141
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(853, 203)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(31, 17)
		Me.Label4.TabIndex = 140
		Me.Label4.Text = "DNI :"
		'
		'txtTelefono
		'
		Me.txtTelefono.Enabled = False
		Me.txtTelefono.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTelefono.Location = New System.Drawing.Point(856, 349)
		Me.txtTelefono.Name = "txtTelefono"
		Me.txtTelefono.Size = New System.Drawing.Size(189, 23)
		Me.txtTelefono.TabIndex = 139
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(853, 332)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(60, 17)
		Me.Label3.TabIndex = 138
		Me.Label3.Text = "TELEFONO :"
		'
		'txtApellidos
		'
		Me.txtApellidos.Enabled = False
		Me.txtApellidos.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtApellidos.Location = New System.Drawing.Point(856, 306)
		Me.txtApellidos.Name = "txtApellidos"
		Me.txtApellidos.Size = New System.Drawing.Size(189, 23)
		Me.txtApellidos.TabIndex = 137
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(853, 289)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(67, 17)
		Me.Label2.TabIndex = 136
		Me.Label2.Text = "APELLIDOS :"
		'
		'txtNombre
		'
		Me.txtNombre.Enabled = False
		Me.txtNombre.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNombre.Location = New System.Drawing.Point(856, 263)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(189, 23)
		Me.txtNombre.TabIndex = 135
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(853, 246)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(55, 17)
		Me.Label1.TabIndex = 134
		Me.Label1.Text = "NOMBRE :"
		'
		'txtEmail
		'
		Me.txtEmail.Enabled = False
		Me.txtEmail.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEmail.Location = New System.Drawing.Point(856, 393)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(189, 23)
		Me.txtEmail.TabIndex = 163
		'
		'busMail
		'
		Me.busMail.Location = New System.Drawing.Point(119, 106)
		Me.busMail.Name = "busMail"
		Me.busMail.Size = New System.Drawing.Size(120, 20)
		Me.busMail.TabIndex = 164
		'
		'lbSalir
		'
		Me.lbSalir.AutoSize = True
		Me.lbSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbSalir.ForeColor = System.Drawing.Color.White
		Me.lbSalir.Location = New System.Drawing.Point(1145, 9)
		Me.lbSalir.Name = "lbSalir"
		Me.lbSalir.Size = New System.Drawing.Size(27, 31)
		Me.lbSalir.TabIndex = 165
		Me.lbSalir.Text = "x"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Harlow Solid Italic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.ForeColor = System.Drawing.Color.White
		Me.Label16.Location = New System.Drawing.Point(12, 722)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(311, 30)
		Me.Label16.TabIndex = 166
		Me.Label16.Text = "Alojamientos Euskadi Admin "
		'
		'vistaUsuarios
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(1184, 761)
		Me.ControlBox = False
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.lbSalir)
		Me.Controls.Add(Me.busMail)
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.lblSalir)
		Me.Controls.Add(Me.btnActualizar)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.busApellido)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.busNombre)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.btnModi)
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnModificar)
		Me.Controls.Add(Me.btnCrear)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtDni)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtTelefono)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtApellidos)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtNombre)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "vistaUsuarios"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lblSalir As Label
	Friend WithEvents btnActualizar As Button
	Friend WithEvents btnBuscar As Button
	Friend WithEvents Label9 As Label
	Friend WithEvents busApellido As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents busNombre As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents btnModi As Button
	Friend WithEvents btnCancelar As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Button4 As Button
	Friend WithEvents btnEliminar As Button
	Friend WithEvents btnModificar As Button
	Friend WithEvents btnCrear As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents txtDni As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtTelefono As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtApellidos As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtNombre As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents busMail As TextBox
	Friend WithEvents lbSalir As Label
	Friend WithEvents Label16 As Label
End Class
