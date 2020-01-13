<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vistaLogin1
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
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'TextBox1
		'
		Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(241, 145)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(168, 38)
		Me.TextBox1.TabIndex = 0
		'
		'TextBox2
		'
		Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox2.Location = New System.Drawing.Point(241, 201)
		Me.TextBox2.MaxLength = 32
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBox2.Size = New System.Drawing.Size(168, 38)
		Me.TextBox2.TabIndex = 1
		'
		'Button1
		'
		Me.Button1.AutoSize = True
		Me.Button1.BackColor = System.Drawing.Color.Black
		Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia
		Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Button1.ForeColor = System.Drawing.Color.White
		Me.Button1.Location = New System.Drawing.Point(423, 334)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(93, 34)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "CONTINUAR"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.ForeColor = System.Drawing.Color.White
		Me.Button2.Location = New System.Drawing.Point(483, 12)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(33, 34)
		Me.Button2.TabIndex = 5
		Me.Button2.Text = "X"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(112, 148)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(123, 31)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Usuario :"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(65, 201)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(170, 31)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Contraseña :"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Webdings", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(22, 11)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(148, 30)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "YIPQB"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Ink Free", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(21, 41)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(252, 34)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Alojamientos Euskadi"
		'
		'vistaLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(528, 380)
		Me.ControlBox = False
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Name = "vistaLogin"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
End Class
