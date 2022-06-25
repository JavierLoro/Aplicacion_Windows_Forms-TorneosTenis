<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnJugadoras = New System.Windows.Forms.Button()
        Me.btnClasif = New System.Windows.Forms.Button()
        Me.btnTorneos = New System.Windows.Forms.Button()
        Me.btnPaises = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnJugadoras
        '
        Me.btnJugadoras.Location = New System.Drawing.Point(29, 29)
        Me.btnJugadoras.Name = "btnJugadoras"
        Me.btnJugadoras.Size = New System.Drawing.Size(111, 30)
        Me.btnJugadoras.TabIndex = 0
        Me.btnJugadoras.Text = "JUGADORAS"
        Me.btnJugadoras.UseVisualStyleBackColor = True
        '
        'btnClasif
        '
        Me.btnClasif.Location = New System.Drawing.Point(29, 79)
        Me.btnClasif.Name = "btnClasif"
        Me.btnClasif.Size = New System.Drawing.Size(111, 30)
        Me.btnClasif.TabIndex = 1
        Me.btnClasif.Text = "CLASIFICACION"
        Me.btnClasif.UseVisualStyleBackColor = True
        '
        'btnTorneos
        '
        Me.btnTorneos.Location = New System.Drawing.Point(267, 29)
        Me.btnTorneos.Name = "btnTorneos"
        Me.btnTorneos.Size = New System.Drawing.Size(101, 30)
        Me.btnTorneos.TabIndex = 2
        Me.btnTorneos.Text = "TORNEOS"
        Me.btnTorneos.UseVisualStyleBackColor = True
        '
        'btnPaises
        '
        Me.btnPaises.Location = New System.Drawing.Point(267, 79)
        Me.btnPaises.Name = "btnPaises"
        Me.btnPaises.Size = New System.Drawing.Size(101, 30)
        Me.btnPaises.TabIndex = 5
        Me.btnPaises.Text = "PAISES"
        Me.btnPaises.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 132)
        Me.Controls.Add(Me.btnPaises)
        Me.Controls.Add(Me.btnTorneos)
        Me.Controls.Add(Me.btnClasif)
        Me.Controls.Add(Me.btnJugadoras)
        Me.Name = "FormInicio"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnJugadoras As Button
    Friend WithEvents btnClasif As Button
    Friend WithEvents btnTorneos As Button
    Friend WithEvents btnPaises As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
