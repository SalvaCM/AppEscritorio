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
		Me.Label15 = New System.Windows.Forms.Label()
		Me.comboTipoUsuario = New System.Windows.Forms.ComboBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.btnModi = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(479, 89)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(60, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "NOMBRE :"
		'
		'txtNombre
		'
		Me.txtNombre.Enabled = False
		Me.txtNombre.Location = New System.Drawing.Point(482, 106)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(189, 20)
		Me.txtNombre.TabIndex = 2
		'
		'txtApellidos
		'
		Me.txtApellidos.Enabled = False
		Me.txtApellidos.Location = New System.Drawing.Point(482, 149)
		Me.txtApellidos.Name = "txtApellidos"
		Me.txtApellidos.Size = New System.Drawing.Size(189, 20)
		Me.txtApellidos.TabIndex = 4
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(479, 132)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(72, 13)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "APELLIDOS :"
		'
		'txtTelefono
		'
		Me.txtTelefono.Enabled = False
		Me.txtTelefono.Location = New System.Drawing.Point(482, 192)
		Me.txtTelefono.Name = "txtTelefono"
		Me.txtTelefono.Size = New System.Drawing.Size(189, 20)
		Me.txtTelefono.TabIndex = 6
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(479, 175)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(70, 13)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "TELEFONO :"
		'
		'txtDni
		'
		Me.txtDni.Enabled = False
		Me.txtDni.Location = New System.Drawing.Point(482, 63)
		Me.txtDni.Name = "txtDni"
		Me.txtDni.Size = New System.Drawing.Size(189, 20)
		Me.txtDni.TabIndex = 8
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(479, 46)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(32, 13)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "DNI :"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(479, 218)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(105, 13)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "TIPO DE USUARIO:"
		'
		'btnCrear
		'
		Me.btnCrear.Location = New System.Drawing.Point(697, 59)
		Me.btnCrear.Name = "btnCrear"
		Me.btnCrear.Size = New System.Drawing.Size(75, 23)
		Me.btnCrear.TabIndex = 11
		Me.btnCrear.Text = "CREAR"
		Me.btnCrear.UseVisualStyleBackColor = True
		'
		'btnModificar
		'
		Me.btnModificar.Location = New System.Drawing.Point(697, 89)
		Me.btnModificar.Name = "btnModificar"
		Me.btnModificar.Size = New System.Drawing.Size(75, 23)
		Me.btnModificar.TabIndex = 12
		Me.btnModificar.Text = "MODIFICAR"
		Me.btnModificar.UseVisualStyleBackColor = True
		'
		'btnEliminar
		'
		Me.btnEliminar.Location = New System.Drawing.Point(697, 119)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
		Me.btnEliminar.TabIndex = 13
		Me.btnEliminar.Text = "ELIMINAR"
		Me.btnEliminar.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(697, 526)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(75, 23)
		Me.Button4.TabIndex = 14
		Me.Button4.Text = "Volver"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(12, 13)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(323, 29)
		Me.Label15.TabIndex = 63
		Me.Label15.Text = "GESTION DE USUARIOS :"
		'
		'comboTipoUsuario
		'
		Me.comboTipoUsuario.Enabled = False
		Me.comboTipoUsuario.FormattingEnabled = True
		Me.comboTipoUsuario.Items.AddRange(New Object() {"Normal", "Administrador"})
		Me.comboTipoUsuario.Location = New System.Drawing.Point(482, 234)
		Me.comboTipoUsuario.Name = "comboTipoUsuario"
		Me.comboTipoUsuario.Size = New System.Drawing.Size(189, 21)
		Me.comboTipoUsuario.TabIndex = 64
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(17, 59)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(444, 490)
		Me.DataGridView1.TabIndex = 65
		'
		'btnCancelar
		'
		Me.btnCancelar.Location = New System.Drawing.Point(482, 271)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(79, 22)
		Me.btnCancelar.TabIndex = 66
		Me.btnCancelar.Text = "CANCELAR"
		Me.btnCancelar.UseVisualStyleBackColor = True
		Me.btnCancelar.Visible = False
		'
		'btnModi
		'
		Me.btnModi.Location = New System.Drawing.Point(596, 270)
		Me.btnModi.Name = "btnModi"
		Me.btnModi.Size = New System.Drawing.Size(75, 23)
		Me.btnModi.TabIndex = 67
		Me.btnModi.Text = "ACEPTAR"
		Me.btnModi.UseVisualStyleBackColor = True
		Me.btnModi.Visible = False
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(694, 152)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(65, 13)
		Me.Label6.TabIndex = 68
		Me.Label6.Text = "modi o crear"
		Me.Label6.Visible = False
		'
		'vistaUsuarios
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(784, 561)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.btnModi)
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.comboTipoUsuario)
		Me.Controls.Add(Me.Label15)
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
		Me.Name = "vistaUsuarios"
		Me.Text = "Usuarios"
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
    Friend WithEvents Label15 As Label
    Friend WithEvents comboTipoUsuario As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModi As Button
    Friend WithEvents Label6 As Label
End Class
