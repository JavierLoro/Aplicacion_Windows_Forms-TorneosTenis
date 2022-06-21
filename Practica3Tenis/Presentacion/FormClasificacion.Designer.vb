<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClasificacion
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
        Me.listClasificacion = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(74, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CLASIFICACION JUGADORAS"
        '
        'listClasificacion
        '
        Me.listClasificacion.FormattingEnabled = True
        Me.listClasificacion.Location = New System.Drawing.Point(12, 73)
        Me.listClasificacion.Name = "listClasificacion"
        Me.listClasificacion.Size = New System.Drawing.Size(398, 225)
        Me.listClasificacion.TabIndex = 2
        '
        'FormClasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 313)
        Me.Controls.Add(Me.listClasificacion)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormClasificacion"
        Me.Text = "CLASIFICACION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents listClasificacion As ListBox
End Class
