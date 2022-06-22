<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJugadoras
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblNomb = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbPais_J = New System.Windows.Forms.TextBox()
        Me.txbFn_J = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.SuspendLayout()
        Me.boxEstadisticas.SuspendLayout()
        Me.boxMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(20, 28)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(19, 17)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "Id"
        '
        'lblNomb
        '
        Me.lblNomb.AutoSize = True
        Me.lblNomb.Location = New System.Drawing.Point(20, 71)
        Me.lblNomb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNomb.Name = "lblNomb"
        Me.lblNomb.Size = New System.Drawing.Size(68, 17)
        Me.lblNomb.TabIndex = 3
        Me.lblNomb.Text = "Jugadora"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txbPais_J)
        Me.GroupBox1.Controls.Add(Me.txbFn_J)
        Me.GroupBox1.Controls.Add(Me.txbNomb_J)
        Me.GroupBox1.Controls.Add(Me.txbid_J)
        Me.GroupBox1.Controls.Add(Me.lblPais)
        Me.GroupBox1.Controls.Add(Me.lblFech)
        Me.GroupBox1.Controls.Add(Me.lblId)
        Me.GroupBox1.Controls.Add(Me.lblNomb)
        Me.GroupBox1.Location = New System.Drawing.Point(243, 52)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(344, 208)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'txbPais_J
        '
        Me.txbPais_J.Location = New System.Drawing.Point(184, 169)
        Me.txbPais_J.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbPais_J.Name = "txbPais_J"
        Me.txbPais_J.Size = New System.Drawing.Size(141, 22)
        Me.txbPais_J.TabIndex = 9
        '
        'txbFn_J
        '
        Me.txbFn_J.Location = New System.Drawing.Point(184, 118)
        Me.txbFn_J.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbFn_J.Name = "txbFn_J"
        Me.txbFn_J.Size = New System.Drawing.Size(141, 22)
        Me.txbFn_J.TabIndex = 8
        '
        'txbNomb_J
        '
        Me.txbNomb_J.Location = New System.Drawing.Point(184, 68)
        Me.txbNomb_J.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbNomb_J.Name = "txbNomb_J"
        Me.txbNomb_J.Size = New System.Drawing.Size(141, 22)
        Me.txbNomb_J.TabIndex = 7
        '
        'txbid_J
        '
        Me.txbid_J.Location = New System.Drawing.Point(184, 26)
        Me.txbid_J.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txbid_J.Name = "txbid_J"
        Me.txbid_J.ReadOnly = True
        Me.txbid_J.Size = New System.Drawing.Size(141, 22)
        Me.txbid_J.TabIndex = 6
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(20, 172)
        Me.lblPais.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(35, 17)
        Me.lblPais.TabIndex = 5
        Me.lblPais.Text = "Pais"
        '
        'lblFech
        '
        Me.lblFech.AutoSize = True
        Me.lblFech.Location = New System.Drawing.Point(20, 122)
        Me.lblFech.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFech.Name = "lblFech"
        Me.lblFech.Size = New System.Drawing.Size(121, 17)
        Me.lblFech.TabIndex = 4
        Me.lblFech.Text = "Fecha Nacimiento"
        '
        'btnAñad_J
        '
        Me.btnAñad_J.Location = New System.Drawing.Point(256, 270)
        Me.btnAñad_J.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAñad_J.Name = "btnAñad_J"
        Me.btnAñad_J.Size = New System.Drawing.Size(92, 36)
        Me.btnAñad_J.TabIndex = 6
        Me.btnAñad_J.Text = "AÑADIR"
        Me.btnAñad_J.UseVisualStyleBackColor = True
        '
        'btnMod_J
        '
        Me.btnMod_J.Location = New System.Drawing.Point(452, 270)
        Me.btnMod_J.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMod_J.Name = "btnMod_J"
        Me.btnMod_J.Size = New System.Drawing.Size(101, 36)
        Me.btnMod_J.TabIndex = 7
        Me.btnMod_J.Text = "MODIFICAR"
        Me.btnMod_J.UseVisualStyleBackColor = True
        '
        'btnElim_J
        '
        Me.btnElim_J.Location = New System.Drawing.Point(355, 270)
        Me.btnElim_J.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnElim_J.Name = "btnElim_J"
        Me.btnElim_J.Size = New System.Drawing.Size(92, 36)
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
        Me.boxEstadisticas.Location = New System.Drawing.Point(624, 12)
        Me.boxEstadisticas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.boxEstadisticas.Name = "boxEstadisticas"
        Me.boxEstadisticas.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.boxEstadisticas.Size = New System.Drawing.Size(553, 491)
        Me.boxEstadisticas.TabIndex = 9
        Me.boxEstadisticas.TabStop = False
        Me.boxEstadisticas.Text = "ESTADISTICAS"
        '
        'listb_anu
        '
        Me.listb_anu.FormattingEnabled = True
        Me.listb_anu.ItemHeight = 16
        Me.listb_anu.Location = New System.Drawing.Point(23, 278)
        Me.listb_anu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.listb_anu.Name = "listb_anu"
        Me.listb_anu.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listb_anu.Size = New System.Drawing.Size(505, 164)
        Me.listb_anu.TabIndex = 31
        '
        'listb_torn
        '
        Me.listb_torn.FormattingEnabled = True
        Me.listb_torn.ItemHeight = 16
        Me.listb_torn.Location = New System.Drawing.Point(23, 69)
        Me.listb_torn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.listb_torn.Name = "listb_torn"
        Me.listb_torn.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listb_torn.Size = New System.Drawing.Size(505, 164)
        Me.listb_torn.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Resultados torneo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 249)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Resultados año"
        '
        'listaAños
        '
        Me.listaAños.FormattingEnabled = True
        Me.listaAños.Location = New System.Drawing.Point(164, 245)
        Me.listaAños.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.listaAños.Name = "listaAños"
        Me.listaAños.Size = New System.Drawing.Size(137, 24)
        Me.listaAños.TabIndex = 1
        '
        'listaTorneos
        '
        Me.listaTorneos.FormattingEnabled = True
        Me.listaTorneos.Location = New System.Drawing.Point(164, 36)
        Me.listaTorneos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.listaTorneos.Name = "listaTorneos"
        Me.listaTorneos.Size = New System.Drawing.Size(137, 24)
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
        Me.boxMain.Location = New System.Drawing.Point(13, 12)
        Me.boxMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.boxMain.Name = "boxMain"
        Me.boxMain.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.boxMain.Size = New System.Drawing.Size(587, 491)
        Me.boxMain.TabIndex = 10
        Me.boxMain.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(299, 313)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(197, 28)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'listb_Jugadoras
        '
        Me.listb_Jugadoras.FormattingEnabled = True
        Me.listb_Jugadoras.ItemHeight = 16
        Me.listb_Jugadoras.Location = New System.Drawing.Point(9, 52)
        Me.listb_Jugadoras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.listb_Jugadoras.Name = "listb_Jugadoras"
        Me.listb_Jugadoras.Size = New System.Drawing.Size(224, 340)
        Me.listb_Jugadoras.TabIndex = 9
        '
        'FormJugadoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 516)
        Me.Controls.Add(Me.boxEstadisticas)
        Me.Controls.Add(Me.boxMain)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents txbPais_J As TextBox
    Friend WithEvents txbFn_J As TextBox
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
End Class
