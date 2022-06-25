<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJugadoras
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblNomb = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbFn_J = New System.Windows.Forms.DateTimePicker()
        Me.txbNomb_J = New System.Windows.Forms.TextBox()
        Me.txbid_J = New System.Windows.Forms.TextBox()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblFech = New System.Windows.Forms.Label()
        Me.btnAñad_J = New System.Windows.Forms.Button()
        Me.btnMod_J = New System.Windows.Forms.Button()
        Me.btnElim_J = New System.Windows.Forms.Button()
        Me.boxEstadisticas = New System.Windows.Forms.GroupBox()
        Me.listb_anu = New System.Windows.Forms.ListBox()
        Me.listb_torn = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listaAños = New System.Windows.Forms.ComboBox()
        Me.listaTorneos = New System.Windows.Forms.ComboBox()
        Me.boxMain = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.listb_Jugadoras = New System.Windows.Forms.ListBox()
        Me.ComboBoxPaises = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.boxEstadisticas.SuspendLayout()
        Me.boxMain.SuspendLayout()
        Me.SuspendLayout()
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
        Me.lblNomb.Size = New System.Drawing.Size(51, 13)
        Me.lblNomb.TabIndex = 3
        Me.lblNomb.Text = "Jugadora"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxPaises)
        Me.GroupBox1.Controls.Add(Me.txbFn_J)
        Me.GroupBox1.Controls.Add(Me.txbNomb_J)
        Me.GroupBox1.Controls.Add(Me.txbid_J)
        Me.GroupBox1.Controls.Add(Me.lblPais)
        Me.GroupBox1.Controls.Add(Me.lblFech)
        Me.GroupBox1.Controls.Add(Me.lblId)
        Me.GroupBox1.Controls.Add(Me.lblNomb)
        Me.GroupBox1.Location = New System.Drawing.Point(182, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 169)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'txbFn_J
        '
        Me.txbFn_J.Location = New System.Drawing.Point(138, 93)
        Me.txbFn_J.Name = "txbFn_J"
        Me.txbFn_J.Size = New System.Drawing.Size(107, 20)
        Me.txbFn_J.TabIndex = 11
        '
        'txbNomb_J
        '
        Me.txbNomb_J.Location = New System.Drawing.Point(138, 55)
        Me.txbNomb_J.Name = "txbNomb_J"
        Me.txbNomb_J.Size = New System.Drawing.Size(107, 20)
        Me.txbNomb_J.TabIndex = 7
        '
        'txbid_J
        '
        Me.txbid_J.Location = New System.Drawing.Point(138, 21)
        Me.txbid_J.Name = "txbid_J"
        Me.txbid_J.ReadOnly = True
        Me.txbid_J.Size = New System.Drawing.Size(107, 20)
        Me.txbid_J.TabIndex = 6
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(15, 140)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(27, 13)
        Me.lblPais.TabIndex = 5
        Me.lblPais.Text = "Pais"
        '
        'lblFech
        '
        Me.lblFech.AutoSize = True
        Me.lblFech.Location = New System.Drawing.Point(15, 99)
        Me.lblFech.Name = "lblFech"
        Me.lblFech.Size = New System.Drawing.Size(93, 13)
        Me.lblFech.TabIndex = 4
        Me.lblFech.Text = "Fecha Nacimiento"
        '
        'btnAñad_J
        '
        Me.btnAñad_J.Location = New System.Drawing.Point(192, 219)
        Me.btnAñad_J.Name = "btnAñad_J"
        Me.btnAñad_J.Size = New System.Drawing.Size(69, 29)
        Me.btnAñad_J.TabIndex = 6
        Me.btnAñad_J.Text = "AÑADIR"
        Me.btnAñad_J.UseVisualStyleBackColor = True
        '
        'btnMod_J
        '
        Me.btnMod_J.Location = New System.Drawing.Point(339, 219)
        Me.btnMod_J.Name = "btnMod_J"
        Me.btnMod_J.Size = New System.Drawing.Size(76, 29)
        Me.btnMod_J.TabIndex = 7
        Me.btnMod_J.Text = "MODIFICAR"
        Me.btnMod_J.UseVisualStyleBackColor = True
        '
        'btnElim_J
        '
        Me.btnElim_J.Location = New System.Drawing.Point(266, 219)
        Me.btnElim_J.Name = "btnElim_J"
        Me.btnElim_J.Size = New System.Drawing.Size(69, 29)
        Me.btnElim_J.TabIndex = 8
        Me.btnElim_J.Text = "ELIMINAR"
        Me.btnElim_J.UseVisualStyleBackColor = True
        '
        'boxEstadisticas
        '
        Me.boxEstadisticas.Controls.Add(Me.listb_anu)
        Me.boxEstadisticas.Controls.Add(Me.listb_torn)
        Me.boxEstadisticas.Controls.Add(Me.Label2)
        Me.boxEstadisticas.Controls.Add(Me.Label1)
        Me.boxEstadisticas.Controls.Add(Me.listaAños)
        Me.boxEstadisticas.Controls.Add(Me.listaTorneos)
        Me.boxEstadisticas.Location = New System.Drawing.Point(468, 10)
        Me.boxEstadisticas.Name = "boxEstadisticas"
        Me.boxEstadisticas.Size = New System.Drawing.Size(415, 399)
        Me.boxEstadisticas.TabIndex = 9
        Me.boxEstadisticas.TabStop = False
        Me.boxEstadisticas.Text = "ESTADISTICAS"
        '
        'listb_anu
        '
        Me.listb_anu.FormattingEnabled = True
        Me.listb_anu.Location = New System.Drawing.Point(17, 226)
        Me.listb_anu.Name = "listb_anu"
        Me.listb_anu.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listb_anu.Size = New System.Drawing.Size(380, 134)
        Me.listb_anu.TabIndex = 31
        '
        'listb_torn
        '
        Me.listb_torn.FormattingEnabled = True
        Me.listb_torn.Location = New System.Drawing.Point(17, 56)
        Me.listb_torn.Name = "listb_torn"
        Me.listb_torn.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listb_torn.Size = New System.Drawing.Size(380, 134)
        Me.listb_torn.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Resultados torneo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Resultados año"
        '
        'listaAños
        '
        Me.listaAños.FormattingEnabled = True
        Me.listaAños.Location = New System.Drawing.Point(123, 199)
        Me.listaAños.Name = "listaAños"
        Me.listaAños.Size = New System.Drawing.Size(104, 21)
        Me.listaAños.TabIndex = 1
        '
        'listaTorneos
        '
        Me.listaTorneos.FormattingEnabled = True
        Me.listaTorneos.Location = New System.Drawing.Point(123, 29)
        Me.listaTorneos.Name = "listaTorneos"
        Me.listaTorneos.Size = New System.Drawing.Size(104, 21)
        Me.listaTorneos.TabIndex = 0
        '
        'boxMain
        '
        Me.boxMain.Controls.Add(Me.btnLimpiar)
        Me.boxMain.Controls.Add(Me.listb_Jugadoras)
        Me.boxMain.Controls.Add(Me.GroupBox1)
        Me.boxMain.Controls.Add(Me.btnElim_J)
        Me.boxMain.Controls.Add(Me.btnMod_J)
        Me.boxMain.Controls.Add(Me.btnAñad_J)
        Me.boxMain.Location = New System.Drawing.Point(10, 10)
        Me.boxMain.Name = "boxMain"
        Me.boxMain.Size = New System.Drawing.Size(440, 399)
        Me.boxMain.TabIndex = 10
        Me.boxMain.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(224, 254)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(148, 23)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'listb_Jugadoras
        '
        Me.listb_Jugadoras.FormattingEnabled = True
        Me.listb_Jugadoras.Location = New System.Drawing.Point(7, 42)
        Me.listb_Jugadoras.Name = "listb_Jugadoras"
        Me.listb_Jugadoras.Size = New System.Drawing.Size(169, 277)
        Me.listb_Jugadoras.TabIndex = 9
        '
        'ComboBoxPaises
        '
        Me.ComboBoxPaises.FormattingEnabled = True
        Me.ComboBoxPaises.Location = New System.Drawing.Point(138, 137)
        Me.ComboBoxPaises.Name = "ComboBoxPaises"
        Me.ComboBoxPaises.Size = New System.Drawing.Size(107, 21)
        Me.ComboBoxPaises.TabIndex = 11
        '
        'FormJugadoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 419)
        Me.Controls.Add(Me.boxEstadisticas)
        Me.Controls.Add(Me.boxMain)
        Me.Name = "FormJugadoras"
        Me.Text = "JUGADORAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.boxEstadisticas.ResumeLayout(False)
        Me.boxEstadisticas.PerformLayout()
        Me.boxMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblId As Label
    Friend WithEvents lblNomb As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txbNomb_J As TextBox
    Friend WithEvents txbid_J As TextBox
    Friend WithEvents lblPais As Label
    Friend WithEvents lblFech As Label
    Friend WithEvents btnAñad_J As Button
    Friend WithEvents btnMod_J As Button
    Friend WithEvents btnElim_J As Button
    Friend WithEvents boxEstadisticas As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents listaAños As ComboBox
    Friend WithEvents listaTorneos As ComboBox
    Friend WithEvents boxMain As GroupBox
    Friend WithEvents listb_Jugadoras As ListBox
    Friend WithEvents listb_anu As ListBox
    Friend WithEvents listb_torn As ListBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txbFn_J As DateTimePicker
    Friend WithEvents ComboBoxPaises As ComboBox
End Class
