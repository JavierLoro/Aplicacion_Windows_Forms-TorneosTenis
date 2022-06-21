<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPaises
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
        Me.btnElim = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnAñad = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.txbId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblNomb = New System.Windows.Forms.Label()
        Me.Main = New System.Windows.Forms.GroupBox()
        Me.listPais = New System.Windows.Forms.ListBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnElim
        '
        Me.btnElim.Location = New System.Drawing.Point(270, 131)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(69, 29)
        Me.btnElim.TabIndex = 14
        Me.btnElim.Text = "ELIMINAR"
        Me.btnElim.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(344, 131)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(82, 29)
        Me.btnMod.TabIndex = 13
        Me.btnMod.Text = "MODIFICAR"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnAñad
        '
        Me.btnAñad.Location = New System.Drawing.Point(196, 131)
        Me.btnAñad.Name = "btnAñad"
        Me.btnAñad.Size = New System.Drawing.Size(69, 29)
        Me.btnAñad.TabIndex = 12
        Me.btnAñad.Text = "AÑADIR"
        Me.btnAñad.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txbNombre)
        Me.GroupBox1.Controls.Add(Me.txbId)
        Me.GroupBox1.Controls.Add(Me.lblId)
        Me.GroupBox1.Controls.Add(Me.lblNomb)
        Me.GroupBox1.Location = New System.Drawing.Point(181, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 92)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'txbNombre
        '
        Me.txbNombre.Location = New System.Drawing.Point(138, 55)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(107, 20)
        Me.txbNombre.TabIndex = 7
        '
        'txbId
        '
        Me.txbId.Location = New System.Drawing.Point(138, 21)
        Me.txbId.Name = "txbId"
        Me.txbId.Size = New System.Drawing.Size(107, 20)
        Me.txbId.TabIndex = 6
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(15, 23)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(16, 13)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "Id"
        '
        'lblNomb
        '
        Me.lblNomb.AutoSize = True
        Me.lblNomb.Location = New System.Drawing.Point(15, 58)
        Me.lblNomb.Name = "lblNomb"
        Me.lblNomb.Size = New System.Drawing.Size(64, 13)
        Me.lblNomb.TabIndex = 3
        Me.lblNomb.Text = "NombrePais"
        '
        'Main
        '
        Me.Main.Controls.Add(Me.listPais)
        Me.Main.Controls.Add(Me.BtnLimpiar)
        Me.Main.Controls.Add(Me.GroupBox1)
        Me.Main.Controls.Add(Me.btnElim)
        Me.Main.Controls.Add(Me.btnMod)
        Me.Main.Controls.Add(Me.btnAñad)
        Me.Main.Location = New System.Drawing.Point(10, 10)
        Me.Main.Name = "Main"
        Me.Main.Size = New System.Drawing.Size(451, 272)
        Me.Main.TabIndex = 15
        Me.Main.TabStop = False
        '
        'listPais
        '
        Me.listPais.FormattingEnabled = True
        Me.listPais.Location = New System.Drawing.Point(7, 19)
        Me.listPais.Name = "listPais"
        Me.listPais.Size = New System.Drawing.Size(158, 238)
        Me.listPais.TabIndex = 16
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(227, 166)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(155, 23)
        Me.BtnLimpiar.TabIndex = 15
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'FormPaises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 302)
        Me.Controls.Add(Me.Main)
        Me.Name = "FormPaises"
        Me.Text = "PAISES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnElim As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnAñad As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents txbId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents lblNomb As Label
    Friend WithEvents Main As GroupBox
    Friend WithEvents listPais As ListBox
    Friend WithEvents BtnLimpiar As Button
End Class
