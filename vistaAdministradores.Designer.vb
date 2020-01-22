<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vistaAdministradores
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.txtApellidos = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtTelefono = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtDni = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.btnCrear = New System.Windows.Forms.Button()
		Me.btnModificar = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.comboTipoUsuario = New System.Windows.Forms.ComboBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.btnModi = New System.Windows.Forms.Button()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.lblSalir = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtPassw = New System.Windows.Forms.TextBox()
		Me.Label16 = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(832, 229)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(55, 17)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "NOMBRE :"
		'
		'txtNombre
		'
		Me.txtNombre.Enabled = False
		Me.txtNombre.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNombre.Location = New System.Drawing.Point(835, 251)
		Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(189, 23)
		Me.txtNombre.TabIndex = 2
		'
		'txtApellidos
		'
		Me.txtApellidos.Enabled = False
		Me.txtApellidos.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtApellidos.Location = New System.Drawing.Point(835, 307)
		Me.txtApellidos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtApellidos.Name = "txtApellidos"
		Me.txtApellidos.Size = New System.Drawing.Size(189, 23)
		Me.txtApellidos.TabIndex = 4
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(832, 285)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(67, 17)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "APELLIDOS :"
		'
		'txtTelefono
		'
		Me.txtTelefono.Enabled = False
		Me.txtTelefono.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTelefono.Location = New System.Drawing.Point(835, 364)
		Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtTelefono.Name = "txtTelefono"
		Me.txtTelefono.Size = New System.Drawing.Size(189, 23)
		Me.txtTelefono.TabIndex = 6
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(832, 341)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(60, 17)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "TELEFONO :"
		'
		'txtDni
		'
		Me.txtDni.Enabled = False
		Me.txtDni.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDni.Location = New System.Drawing.Point(835, 195)
		Me.txtDni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtDni.Name = "txtDni"
		Me.txtDni.Size = New System.Drawing.Size(189, 23)
		Me.txtDni.TabIndex = 8
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(832, 173)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(31, 17)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "DNI :"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.White
		Me.Label5.Location = New System.Drawing.Point(832, 398)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(83, 17)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "TIPO USUARIO:"
		'
		'btnCrear
		'
		Me.btnCrear.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCrear.ForeColor = System.Drawing.Color.White
		Me.btnCrear.Location = New System.Drawing.Point(1050, 190)
		Me.btnCrear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnCrear.Name = "btnCrear"
		Me.btnCrear.Size = New System.Drawing.Size(75, 30)
		Me.btnCrear.TabIndex = 11
		Me.btnCrear.Text = "CREAR"
		Me.btnCrear.UseVisualStyleBackColor = False
		'
		'btnModificar
		'
		Me.btnModificar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnModificar.ForeColor = System.Drawing.Color.White
		Me.btnModificar.Location = New System.Drawing.Point(1050, 229)
		Me.btnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnModificar.Name = "btnModificar"
		Me.btnModificar.Size = New System.Drawing.Size(75, 30)
		Me.btnModificar.TabIndex = 12
		Me.btnModificar.Text = "MODIFICAR"
		Me.btnModificar.UseVisualStyleBackColor = False
		'
		'btnEliminar
		'
		Me.btnEliminar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEliminar.ForeColor = System.Drawing.Color.White
		Me.btnEliminar.Location = New System.Drawing.Point(1050, 268)
		Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 30)
		Me.btnEliminar.TabIndex = 13
		Me.btnEliminar.Text = "ELIMINAR"
		Me.btnEliminar.UseVisualStyleBackColor = False
		'
		'Button4
		'
		Me.Button4.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.ForeColor = System.Drawing.Color.White
		Me.Button4.Location = New System.Drawing.Point(1087, 737)
		Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(98, 48)
		Me.Button4.TabIndex = 14
		Me.Button4.Text = "VOLVER"
		Me.Button4.UseVisualStyleBackColor = False
		'
		'comboTipoUsuario
		'
		Me.comboTipoUsuario.Enabled = False
		Me.comboTipoUsuario.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.comboTipoUsuario.FormattingEnabled = True
		Me.comboTipoUsuario.Items.AddRange(New Object() {"Normal", "Administrador"})
		Me.comboTipoUsuario.Location = New System.Drawing.Point(835, 418)
		Me.comboTipoUsuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.comboTipoUsuario.Name = "comboTipoUsuario"
		Me.comboTipoUsuario.Size = New System.Drawing.Size(189, 25)
		Me.comboTipoUsuario.TabIndex = 64
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.BackgroundColor = System.Drawing.Color.Black
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(58, 94)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.DataGridView1.MultiSelect = False
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.DataGridView1.RowHeadersVisible = False
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.ShowCellToolTips = False
		Me.DataGridView1.ShowEditingIcon = False
		Me.DataGridView1.Size = New System.Drawing.Size(702, 583)
		Me.DataGridView1.TabIndex = 65
		'
		'btnCancelar
		'
		Me.btnCancelar.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancelar.Location = New System.Drawing.Point(864, 524)
		Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(79, 29)
		Me.btnCancelar.TabIndex = 66
		Me.btnCancelar.Text = "CANCELAR"
		Me.btnCancelar.UseVisualStyleBackColor = True
		Me.btnCancelar.Visible = False
		'
		'btnModi
		'
		Me.btnModi.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnModi.Location = New System.Drawing.Point(949, 523)
		Me.btnModi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnModi.Name = "btnModi"
		Me.btnModi.Size = New System.Drawing.Size(75, 30)
		Me.btnModi.TabIndex = 67
		Me.btnModi.Text = "ACEPTAR"
		Me.btnModi.UseVisualStyleBackColor = True
		Me.btnModi.Visible = False
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.ForeColor = System.Drawing.Color.White
		Me.Label15.Location = New System.Drawing.Point(53, 52)
		Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(365, 36)
		Me.Label15.TabIndex = 77
		Me.Label15.Text = "GESTION DE ADMINISTRADORES"
		'
		'lblSalir
		'
		Me.lblSalir.AutoSize = True
		Me.lblSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSalir.ForeColor = System.Drawing.Color.White
		Me.lblSalir.Location = New System.Drawing.Point(1155, 12)
		Me.lblSalir.Name = "lblSalir"
		Me.lblSalir.Size = New System.Drawing.Size(27, 31)
		Me.lblSalir.TabIndex = 131
		Me.lblSalir.Text = "x"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.ForeColor = System.Drawing.Color.White
		Me.Label10.Location = New System.Drawing.Point(832, 450)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(73, 17)
		Me.Label10.TabIndex = 135
		Me.Label10.Text = "PASSWORD :"
		'
		'txtPassw
		'
		Me.txtPassw.Enabled = False
		Me.txtPassw.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassw.Location = New System.Drawing.Point(835, 473)
		Me.txtPassw.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.txtPassw.Name = "txtPassw"
		Me.txtPassw.Size = New System.Drawing.Size(189, 23)
		Me.txtPassw.TabIndex = 134
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Harlow Solid Italic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.ForeColor = System.Drawing.Color.White
		Me.Label16.Location = New System.Drawing.Point(12, 755)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(311, 30)
		Me.Label16.TabIndex = 136
		Me.Label16.Text = "Alojamientos Euskadi Admin "
		'
		'vistaAdministradores
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(1194, 794)
		Me.ControlBox = False
		Me.Controls.Add(Me.Label16)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.txtPassw)
		Me.Controls.Add(Me.lblSalir)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.btnModi)
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.comboTipoUsuario)
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
		Me.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "vistaAdministradores"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Button4 As Button
	Friend WithEvents comboTipoUsuario As ComboBox
	Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModi As Button
	Friend WithEvents Label15 As Label
	Friend WithEvents lblSalir As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents txtPassw As TextBox
	Friend WithEvents Label16 As Label
End Class
