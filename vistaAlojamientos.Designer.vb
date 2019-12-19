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
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(697, 526)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(75, 23)
		Me.Button4.TabIndex = 29
		Me.Button4.Text = "Volver"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(697, 122)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 23)
		Me.Button3.TabIndex = 28
		Me.Button3.Text = "ELIMINAR"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(697, 91)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 27
		Me.Button2.Text = "MODIFICAR"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(697, 62)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 26
		Me.Button1.Text = "CREAR"
		Me.Button1.UseVisualStyleBackColor = True
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
		Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(18, 62)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(673, 454)
		Me.DataGridView1.TabIndex = 63
		'
		'vistaAlojamientos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(784, 561)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Name = "vistaAlojamientos"
		Me.Text = "Alojamientos"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button4 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Label15 As Label
	Friend WithEvents DataGridView1 As DataGridView
End Class
