<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGestion
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
		Me.btnUsuarios = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.lblGestion = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnUsuarios
		'
		Me.btnUsuarios.Location = New System.Drawing.Point(89, 153)
		Me.btnUsuarios.Name = "btnUsuarios"
		Me.btnUsuarios.Size = New System.Drawing.Size(162, 83)
		Me.btnUsuarios.TabIndex = 0
		Me.btnUsuarios.Text = "Usuarios"
		Me.btnUsuarios.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(514, 153)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(162, 83)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "Alojamientos"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(89, 242)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(162, 23)
		Me.Button3.TabIndex = 2
		Me.Button3.Text = "Informe"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'lblGestion
		'
		Me.lblGestion.AutoSize = True
		Me.lblGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGestion.Location = New System.Drawing.Point(35, 104)
		Me.lblGestion.Name = "lblGestion"
		Me.lblGestion.Size = New System.Drawing.Size(305, 33)
		Me.lblGestion.TabIndex = 3
		Me.lblGestion.Text = "GESTION USUARIOS"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(514, 242)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(162, 23)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "Informe"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(410, 104)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(378, 33)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "GESTION ALOJAMIENTOS"
		'
		'MenuGestion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(784, 561)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.lblGestion)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.btnUsuarios)
		Me.Name = "MenuGestion"
		Me.Text = "Alojamientos Euskadi v1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnUsuarios As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents lblGestion As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Label1 As Label
End Class
