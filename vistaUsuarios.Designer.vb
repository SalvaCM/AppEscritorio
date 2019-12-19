<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vistaUsuarios
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
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout()
		'
		'ListBox1
		'
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.Location = New System.Drawing.Point(12, 45)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(447, 485)
		Me.ListBox1.TabIndex = 0
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
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(482, 106)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(189, 20)
		Me.TextBox1.TabIndex = 2
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(482, 149)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(189, 20)
		Me.TextBox2.TabIndex = 4
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
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(482, 192)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(189, 20)
		Me.TextBox3.TabIndex = 6
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
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(482, 63)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(189, 20)
		Me.TextBox4.TabIndex = 8
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
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(697, 59)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 11
		Me.Button1.Text = "CREAR"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(697, 89)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 12
		Me.Button2.Text = "MODIFICAR"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(697, 119)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 23)
		Me.Button3.TabIndex = 13
		Me.Button3.Text = "ELIMINAR"
		Me.Button3.UseVisualStyleBackColor = True
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
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(482, 234)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(189, 21)
		Me.ComboBox1.TabIndex = 64
		'
		'Usuarios
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(784, 561)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.ListBox1)
		Me.Name = "Usuarios"
		Me.Text = "Usuarios"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ListBox1 As ListBox
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Label15 As Label
	Friend WithEvents ComboBox1 As ComboBox
End Class
