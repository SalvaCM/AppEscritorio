<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vistaReservas
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(328, 29)
        Me.Label15.TabIndex = 79
        Me.Label15.Text = "GESTION DE RESERVAS :"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1085, 480)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 78
        Me.Button4.Text = "Volver"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1085, 209)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 77
        Me.Button3.Text = "ELIMINAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1085, 238)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 76
        Me.Button2.Text = "MODIFICAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1085, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "CREAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(877, 252)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(189, 20)
        Me.txtDni.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(874, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "DNI :"
        '
        'txtTelefonoAlo
        '
        Me.txtTelefonoAlo.Location = New System.Drawing.Point(877, 381)
        Me.txtTelefonoAlo.Name = "txtTelefonoAlo"
        Me.txtTelefonoAlo.Size = New System.Drawing.Size(189, 20)
        Me.txtTelefonoAlo.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(874, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "TELEFONO :"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(877, 338)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(189, 20)
        Me.txtApellidos.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(874, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "APELLIDOS :"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(877, 295)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(189, 20)
        Me.txtNombreUsuario.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(874, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "NOMBRE :"
        '
        'txtFechaSalida
        '
        Me.txtFechaSalida.Location = New System.Drawing.Point(877, 162)
        Me.txtFechaSalida.Name = "txtFechaSalida"
        Me.txtFechaSalida.Size = New System.Drawing.Size(189, 20)
        Me.txtFechaSalida.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(874, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "FECHA DE SALIDA :"
        '
        'txtFechaEntrada
        '
        Me.txtFechaEntrada.Location = New System.Drawing.Point(877, 119)
        Me.txtFechaEntrada.Name = "txtFechaEntrada"
        Me.txtFechaEntrada.Size = New System.Drawing.Size(189, 20)
        Me.txtFechaEntrada.TabIndex = 82
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(874, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "FECHA DE ENTRADA :"
        '
        'txtFechaReserva
        '
        Me.txtFechaReserva.Location = New System.Drawing.Point(877, 207)
        Me.txtFechaReserva.Name = "txtFechaReserva"
        Me.txtFechaReserva.Size = New System.Drawing.Size(189, 20)
        Me.txtFechaReserva.TabIndex = 88
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(874, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 13)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "FECHA DE RESERVA :"
        '
        'txtNombreAloj
        '
        Me.txtNombreAloj.Location = New System.Drawing.Point(877, 76)
        Me.txtNombreAloj.Name = "txtNombreAloj"
        Me.txtNombreAloj.Size = New System.Drawing.Size(189, 20)
        Me.txtNombreAloj.TabIndex = 93
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(874, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 13)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "NOMBRE ALOJAMIENTO:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(797, 457)
        Me.DataGridView1.TabIndex = 95
        '
        'vistaReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 563)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtNombreAloj)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtFechaReserva)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFechaSalida)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFechaEntrada)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTelefonoAlo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "vistaReservas"
        Me.Text = "Reservas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
	Friend WithEvents Button4 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button1 As Button
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
    Friend WithEvents DataGridView1 As DataGridView
End Class
