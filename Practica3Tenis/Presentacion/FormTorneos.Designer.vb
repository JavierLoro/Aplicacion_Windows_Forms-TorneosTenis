<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTorneos
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
        Me.btnElim = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnAñad = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbCiu = New System.Windows.Forms.TextBox()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.txbId = New System.Windows.Forms.TextBox()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblFech = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblNomb = New System.Windows.Forms.Label()
        Me.masInfTorneos = New System.Windows.Forms.GroupBox()
        Me.pF2 = New System.Windows.Forms.Label()
        Me.pF1 = New System.Windows.Forms.Label()
        Me.pJ6 = New System.Windows.Forms.Label()
        Me.pJ7 = New System.Windows.Forms.Label()
        Me.pJ5 = New System.Windows.Forms.Label()
        Me.pG3 = New System.Windows.Forms.Label()
        Me.pG1 = New System.Windows.Forms.Label()
        Me.pG4 = New System.Windows.Forms.Label()
        Me.F2 = New System.Windows.Forms.Label()
        Me.F1 = New System.Windows.Forms.Label()
        Me.G4 = New System.Windows.Forms.Label()
        Me.G2 = New System.Windows.Forms.Label()
        Me.G3 = New System.Windows.Forms.Label()
        Me.G1 = New System.Windows.Forms.Label()
        Me.J6 = New System.Windows.Forms.Label()
        Me.J3 = New System.Windows.Forms.Label()
        Me.J5 = New System.Windows.Forms.Label()
        Me.J4 = New System.Windows.Forms.Label()
        Me.J7 = New System.Windows.Forms.Label()
        Me.J2 = New System.Windows.Forms.Label()
        Me.J8 = New System.Windows.Forms.Label()
        Me.J1 = New System.Windows.Forms.Label()
        Me.listGanadores = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pJ1 = New System.Windows.Forms.Label()
        Me.pG2 = New System.Windows.Forms.Label()
        Me.pJ2 = New System.Windows.Forms.Label()
        Me.pJ8 = New System.Windows.Forms.Label()
        Me.pJ4 = New System.Windows.Forms.Label()
        Me.pJ3 = New System.Windows.Forms.Label()
        Me.ComBoxEdiciones = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxMain = New System.Windows.Forms.GroupBox()
        Me.lblNuevEdic = New System.Windows.Forms.Label()
        Me.txtAnualidad = New System.Windows.Forms.TextBox()
        Me.btnNuevaEdicion = New System.Windows.Forms.Button()
        Me.listTorneos = New System.Windows.Forms.ListBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.ComboBoxPaises = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.masInfTorneos.SuspendLayout()
        Me.boxMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnElim
        '
        Me.btnElim.Enabled = False
        Me.btnElim.Location = New System.Drawing.Point(253, 210)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(69, 29)
        Me.btnElim.TabIndex = 20
        Me.btnElim.Text = "ELIMINAR"
        Me.btnElim.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Enabled = False
        Me.btnMod.Location = New System.Drawing.Point(327, 210)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(82, 29)
        Me.btnMod.TabIndex = 19
        Me.btnMod.Text = "MODIFICAR"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnAñad
        '
        Me.btnAñad.Location = New System.Drawing.Point(179, 210)
        Me.btnAñad.Name = "btnAñad"
        Me.btnAñad.Size = New System.Drawing.Size(69, 29)
        Me.btnAñad.TabIndex = 18
        Me.btnAñad.Text = "AÑADIR"
        Me.btnAñad.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxPaises)
        Me.GroupBox1.Controls.Add(Me.txbCiu)
        Me.GroupBox1.Controls.Add(Me.txbNombre)
        Me.GroupBox1.Controls.Add(Me.txbId)
        Me.GroupBox1.Controls.Add(Me.lblPais)
        Me.GroupBox1.Controls.Add(Me.lblFech)
        Me.GroupBox1.Controls.Add(Me.lblId)
        Me.GroupBox1.Controls.Add(Me.lblNomb)
        Me.GroupBox1.Location = New System.Drawing.Point(164, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 169)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'txbCiu
        '
        Me.txbCiu.Location = New System.Drawing.Point(110, 96)
        Me.txbCiu.Name = "txbCiu"
        Me.txbCiu.Size = New System.Drawing.Size(135, 20)
        Me.txbCiu.TabIndex = 8
        '
        'txbNombre
        '
        Me.txbNombre.Location = New System.Drawing.Point(110, 55)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(135, 20)
        Me.txbNombre.TabIndex = 7
        '
        'txbId
        '
        Me.txbId.Location = New System.Drawing.Point(110, 21)
        Me.txbId.Name = "txbId"
        Me.txbId.ReadOnly = True
        Me.txbId.Size = New System.Drawing.Size(135, 20)
        Me.txbId.TabIndex = 6
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
        Me.lblFech.Size = New System.Drawing.Size(40, 13)
        Me.lblFech.TabIndex = 4
        Me.lblFech.Text = "Ciudad"
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
        Me.lblNomb.Size = New System.Drawing.Size(41, 13)
        Me.lblNomb.TabIndex = 3
        Me.lblNomb.Text = "Torneo"
        '
        'masInfTorneos
        '
        Me.masInfTorneos.Controls.Add(Me.pF2)
        Me.masInfTorneos.Controls.Add(Me.pF1)
        Me.masInfTorneos.Controls.Add(Me.pJ6)
        Me.masInfTorneos.Controls.Add(Me.pJ7)
        Me.masInfTorneos.Controls.Add(Me.pJ5)
        Me.masInfTorneos.Controls.Add(Me.pG3)
        Me.masInfTorneos.Controls.Add(Me.pG1)
        Me.masInfTorneos.Controls.Add(Me.pG4)
        Me.masInfTorneos.Controls.Add(Me.F2)
        Me.masInfTorneos.Controls.Add(Me.F1)
        Me.masInfTorneos.Controls.Add(Me.G4)
        Me.masInfTorneos.Controls.Add(Me.G2)
        Me.masInfTorneos.Controls.Add(Me.G3)
        Me.masInfTorneos.Controls.Add(Me.G1)
        Me.masInfTorneos.Controls.Add(Me.J6)
        Me.masInfTorneos.Controls.Add(Me.J3)
        Me.masInfTorneos.Controls.Add(Me.J5)
        Me.masInfTorneos.Controls.Add(Me.J4)
        Me.masInfTorneos.Controls.Add(Me.J7)
        Me.masInfTorneos.Controls.Add(Me.J2)
        Me.masInfTorneos.Controls.Add(Me.J8)
        Me.masInfTorneos.Controls.Add(Me.J1)
        Me.masInfTorneos.Controls.Add(Me.listGanadores)
        Me.masInfTorneos.Controls.Add(Me.Label3)
        Me.masInfTorneos.Controls.Add(Me.pJ1)
        Me.masInfTorneos.Controls.Add(Me.pG2)
        Me.masInfTorneos.Controls.Add(Me.pJ2)
        Me.masInfTorneos.Controls.Add(Me.pJ8)
        Me.masInfTorneos.Controls.Add(Me.pJ4)
        Me.masInfTorneos.Controls.Add(Me.pJ3)
        Me.masInfTorneos.Controls.Add(Me.ComBoxEdiciones)
        Me.masInfTorneos.Controls.Add(Me.Label2)
        Me.masInfTorneos.Controls.Add(Me.Label1)
        Me.masInfTorneos.Location = New System.Drawing.Point(461, 10)
        Me.masInfTorneos.Name = "masInfTorneos"
        Me.masInfTorneos.Size = New System.Drawing.Size(467, 369)
        Me.masInfTorneos.TabIndex = 21
        Me.masInfTorneos.TabStop = False
        '
        'pF2
        '
        Me.pF2.AutoSize = True
        Me.pF2.Location = New System.Drawing.Point(251, 271)
        Me.pF2.Name = "pF2"
        Me.pF2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pF2.Size = New System.Drawing.Size(13, 13)
        Me.pF2.TabIndex = 50
        Me.pF2.Text = "0"
        '
        'pF1
        '
        Me.pF1.AutoSize = True
        Me.pF1.Location = New System.Drawing.Point(157, 271)
        Me.pF1.Name = "pF1"
        Me.pF1.Size = New System.Drawing.Size(13, 13)
        Me.pF1.TabIndex = 49
        Me.pF1.Text = "0"
        '
        'pJ6
        '
        Me.pJ6.AutoSize = True
        Me.pJ6.Location = New System.Drawing.Point(397, 318)
        Me.pJ6.Name = "pJ6"
        Me.pJ6.Size = New System.Drawing.Size(13, 13)
        Me.pJ6.TabIndex = 48
        Me.pJ6.Text = "0"
        '
        'pJ7
        '
        Me.pJ7.AutoSize = True
        Me.pJ7.Location = New System.Drawing.Point(400, 223)
        Me.pJ7.Name = "pJ7"
        Me.pJ7.Size = New System.Drawing.Size(13, 13)
        Me.pJ7.TabIndex = 47
        Me.pJ7.Text = "0"
        '
        'pJ5
        '
        Me.pJ5.AutoSize = True
        Me.pJ5.Location = New System.Drawing.Point(102, 318)
        Me.pJ5.Name = "pJ5"
        Me.pJ5.Size = New System.Drawing.Size(13, 13)
        Me.pJ5.TabIndex = 46
        Me.pJ5.Text = "0"
        '
        'pG3
        '
        Me.pG3.Location = New System.Drawing.Point(22, 271)
        Me.pG3.Name = "pG3"
        Me.pG3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pG3.Size = New System.Drawing.Size(35, 13)
        Me.pG3.TabIndex = 45
        Me.pG3.Text = "0"
        '
        'pG1
        '
        Me.pG1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.pG1.Location = New System.Drawing.Point(22, 255)
        Me.pG1.Name = "pG1"
        Me.pG1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pG1.Size = New System.Drawing.Size(35, 13)
        Me.pG1.TabIndex = 44
        Me.pG1.Text = "0"
        '
        'pG4
        '
        Me.pG4.AutoSize = True
        Me.pG4.Location = New System.Drawing.Point(378, 271)
        Me.pG4.Name = "pG4"
        Me.pG4.Size = New System.Drawing.Size(13, 13)
        Me.pG4.TabIndex = 43
        Me.pG4.Text = "0"
        '
        'F2
        '
        Me.F2.AutoSize = True
        Me.F2.Location = New System.Drawing.Point(245, 255)
        Me.F2.Name = "F2"
        Me.F2.Size = New System.Drawing.Size(19, 13)
        Me.F2.TabIndex = 42
        Me.F2.Text = "F2"
        Me.F2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'F1
        '
        Me.F1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.F1.Location = New System.Drawing.Point(114, 255)
        Me.F1.Name = "F1"
        Me.F1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.F1.Size = New System.Drawing.Size(81, 13)
        Me.F1.TabIndex = 41
        Me.F1.Text = "F1"
        Me.F1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'G4
        '
        Me.G4.Location = New System.Drawing.Point(320, 271)
        Me.G4.Name = "G4"
        Me.G4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.G4.Size = New System.Drawing.Size(52, 13)
        Me.G4.TabIndex = 40
        Me.G4.Text = "G4"
        Me.G4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'G2
        '
        Me.G2.Location = New System.Drawing.Point(320, 255)
        Me.G2.Name = "G2"
        Me.G2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.G2.Size = New System.Drawing.Size(52, 13)
        Me.G2.TabIndex = 39
        Me.G2.Text = "G2"
        Me.G2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'G3
        '
        Me.G3.AutoSize = True
        Me.G3.Location = New System.Drawing.Point(63, 271)
        Me.G3.Name = "G3"
        Me.G3.Size = New System.Drawing.Size(21, 13)
        Me.G3.TabIndex = 38
        Me.G3.Text = "G3"
        '
        'G1
        '
        Me.G1.AutoSize = True
        Me.G1.Location = New System.Drawing.Point(63, 255)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(21, 13)
        Me.G1.TabIndex = 37
        Me.G1.Text = "G1"
        '
        'J6
        '
        Me.J6.Location = New System.Drawing.Point(320, 318)
        Me.J6.Name = "J6"
        Me.J6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.J6.Size = New System.Drawing.Size(71, 13)
        Me.J6.TabIndex = 36
        Me.J6.Text = "Jugadora6"
        Me.J6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'J3
        '
        Me.J3.Location = New System.Drawing.Point(320, 302)
        Me.J3.Name = "J3"
        Me.J3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.J3.Size = New System.Drawing.Size(71, 13)
        Me.J3.TabIndex = 35
        Me.J3.Text = "Jugadora3"
        Me.J3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'J5
        '
        Me.J5.Location = New System.Drawing.Point(39, 318)
        Me.J5.Name = "J5"
        Me.J5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.J5.Size = New System.Drawing.Size(57, 13)
        Me.J5.TabIndex = 34
        Me.J5.Text = "Jugadora5"
        '
        'J4
        '
        Me.J4.Location = New System.Drawing.Point(39, 302)
        Me.J4.Name = "J4"
        Me.J4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.J4.Size = New System.Drawing.Size(57, 13)
        Me.J4.TabIndex = 33
        Me.J4.Text = "Jugadora4"
        '
        'J7
        '
        Me.J7.Location = New System.Drawing.Point(320, 226)
        Me.J7.Name = "J7"
        Me.J7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.J7.Size = New System.Drawing.Size(74, 13)
        Me.J7.TabIndex = 32
        Me.J7.Text = "Jugadora7"
        Me.J7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'J2
        '
        Me.J2.Location = New System.Drawing.Point(320, 210)
        Me.J2.Name = "J2"
        Me.J2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.J2.Size = New System.Drawing.Size(74, 13)
        Me.J2.TabIndex = 31
        Me.J2.Text = "Jugadora2"
        Me.J2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'J8
        '
        Me.J8.Location = New System.Drawing.Point(39, 226)
        Me.J8.Name = "J8"
        Me.J8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.J8.Size = New System.Drawing.Size(57, 13)
        Me.J8.TabIndex = 30
        Me.J8.Text = "Jugadora8"
        '
        'J1
        '
        Me.J1.Location = New System.Drawing.Point(39, 210)
        Me.J1.Name = "J1"
        Me.J1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.J1.Size = New System.Drawing.Size(57, 13)
        Me.J1.TabIndex = 29
        Me.J1.Text = "Jugadora1"
        '
        'listGanadores
        '
        Me.listGanadores.FormattingEnabled = True
        Me.listGanadores.Location = New System.Drawing.Point(22, 53)
        Me.listGanadores.Name = "listGanadores"
        Me.listGanadores.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listGanadores.Size = New System.Drawing.Size(420, 95)
        Me.listGanadores.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(209, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "VS"
        '
        'pJ1
        '
        Me.pJ1.AutoSize = True
        Me.pJ1.Location = New System.Drawing.Point(102, 210)
        Me.pJ1.Name = "pJ1"
        Me.pJ1.Size = New System.Drawing.Size(13, 13)
        Me.pJ1.TabIndex = 25
        Me.pJ1.Text = "0"
        '
        'pG2
        '
        Me.pG2.AutoSize = True
        Me.pG2.Location = New System.Drawing.Point(378, 255)
        Me.pG2.Name = "pG2"
        Me.pG2.Size = New System.Drawing.Size(13, 13)
        Me.pG2.TabIndex = 24
        Me.pG2.Text = "0"
        '
        'pJ2
        '
        Me.pJ2.AutoSize = True
        Me.pJ2.Location = New System.Drawing.Point(400, 210)
        Me.pJ2.Name = "pJ2"
        Me.pJ2.Size = New System.Drawing.Size(13, 13)
        Me.pJ2.TabIndex = 23
        Me.pJ2.Text = "0"
        '
        'pJ8
        '
        Me.pJ8.AutoSize = True
        Me.pJ8.Location = New System.Drawing.Point(102, 226)
        Me.pJ8.Name = "pJ8"
        Me.pJ8.Size = New System.Drawing.Size(13, 13)
        Me.pJ8.TabIndex = 22
        Me.pJ8.Text = "0"
        '
        'pJ4
        '
        Me.pJ4.AutoSize = True
        Me.pJ4.Location = New System.Drawing.Point(102, 302)
        Me.pJ4.Name = "pJ4"
        Me.pJ4.Size = New System.Drawing.Size(13, 13)
        Me.pJ4.TabIndex = 21
        Me.pJ4.Text = "0"
        '
        'pJ3
        '
        Me.pJ3.AutoSize = True
        Me.pJ3.Location = New System.Drawing.Point(397, 302)
        Me.pJ3.Name = "pJ3"
        Me.pJ3.Size = New System.Drawing.Size(13, 13)
        Me.pJ3.TabIndex = 20
        Me.pJ3.Text = "0"
        '
        'ComBoxEdiciones
        '
        Me.ComBoxEdiciones.FormattingEnabled = True
        Me.ComBoxEdiciones.Location = New System.Drawing.Point(114, 167)
        Me.ComBoxEdiciones.Name = "ComBoxEdiciones"
        Me.ComBoxEdiciones.Size = New System.Drawing.Size(86, 21)
        Me.ComBoxEdiciones.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cuadro año"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ganadores"
        '
        'boxMain
        '
        Me.boxMain.Controls.Add(Me.lblNuevEdic)
        Me.boxMain.Controls.Add(Me.txtAnualidad)
        Me.boxMain.Controls.Add(Me.btnNuevaEdicion)
        Me.boxMain.Controls.Add(Me.listTorneos)
        Me.boxMain.Controls.Add(Me.btnLimpiar)
        Me.boxMain.Controls.Add(Me.GroupBox1)
        Me.boxMain.Controls.Add(Me.btnElim)
        Me.boxMain.Controls.Add(Me.btnMod)
        Me.boxMain.Controls.Add(Me.btnAñad)
        Me.boxMain.Location = New System.Drawing.Point(10, 10)
        Me.boxMain.Name = "boxMain"
        Me.boxMain.Size = New System.Drawing.Size(446, 369)
        Me.boxMain.TabIndex = 22
        Me.boxMain.TabStop = False
        '
        'lblNuevEdic
        '
        Me.lblNuevEdic.AutoSize = True
        Me.lblNuevEdic.Location = New System.Drawing.Point(301, 339)
        Me.lblNuevEdic.Name = "lblNuevEdic"
        Me.lblNuevEdic.Size = New System.Drawing.Size(97, 13)
        Me.lblNuevEdic.TabIndex = 25
        Me.lblNuevEdic.Text = "Inserte año edicion"
        '
        'txtAnualidad
        '
        Me.txtAnualidad.Location = New System.Drawing.Point(288, 305)
        Me.txtAnualidad.Name = "txtAnualidad"
        Me.txtAnualidad.Size = New System.Drawing.Size(121, 20)
        Me.txtAnualidad.TabIndex = 24
        '
        'btnNuevaEdicion
        '
        Me.btnNuevaEdicion.Enabled = False
        Me.btnNuevaEdicion.Location = New System.Drawing.Point(173, 302)
        Me.btnNuevaEdicion.Name = "btnNuevaEdicion"
        Me.btnNuevaEdicion.Size = New System.Drawing.Size(109, 23)
        Me.btnNuevaEdicion.TabIndex = 23
        Me.btnNuevaEdicion.Text = "Nueva Edicion: "
        Me.btnNuevaEdicion.UseVisualStyleBackColor = True
        '
        'listTorneos
        '
        Me.listTorneos.FormattingEnabled = True
        Me.listTorneos.Location = New System.Drawing.Point(7, 29)
        Me.listTorneos.Name = "listTorneos"
        Me.listTorneos.Size = New System.Drawing.Size(151, 290)
        Me.listTorneos.TabIndex = 22
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(223, 245)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(127, 23)
        Me.btnLimpiar.TabIndex = 21
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'ComboBoxPaises
        '
        Me.ComboBoxPaises.FormattingEnabled = True
        Me.ComboBoxPaises.Location = New System.Drawing.Point(110, 134)
        Me.ComboBoxPaises.Name = "ComboBoxPaises"
        Me.ComboBoxPaises.Size = New System.Drawing.Size(135, 21)
        Me.ComboBoxPaises.TabIndex = 9
        '
        'FormTorneos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 385)
        Me.Controls.Add(Me.boxMain)
        Me.Controls.Add(Me.masInfTorneos)
        Me.Name = "FormTorneos"
        Me.Text = "TORNEOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.masInfTorneos.ResumeLayout(False)
        Me.masInfTorneos.PerformLayout()
        Me.boxMain.ResumeLayout(False)
        Me.boxMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnElim As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnAñad As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txbCiu As TextBox
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents txbId As TextBox
    Friend WithEvents lblPais As Label
    Friend WithEvents lblFech As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblNomb As Label
    Friend WithEvents masInfTorneos As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pJ1 As Label
    Friend WithEvents pG2 As Label
    Friend WithEvents pJ2 As Label
    Friend WithEvents pJ8 As Label
    Friend WithEvents pJ4 As Label
    Friend WithEvents pJ3 As Label
    Friend WithEvents ComBoxEdiciones As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents boxMain As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents listGanadores As ListBox
    Friend WithEvents listTorneos As ListBox
    Friend WithEvents lblNuevEdic As Label
    Friend WithEvents txtAnualidad As TextBox
    Friend WithEvents btnNuevaEdicion As Button
    Friend WithEvents G3 As Label
    Friend WithEvents G1 As Label
    Friend WithEvents J6 As Label
    Friend WithEvents J3 As Label
    Friend WithEvents J5 As Label
    Friend WithEvents J4 As Label
    Friend WithEvents J7 As Label
    Friend WithEvents J2 As Label
    Friend WithEvents J8 As Label
    Friend WithEvents J1 As Label
    Friend WithEvents F2 As Label
    Friend WithEvents F1 As Label
    Friend WithEvents G4 As Label
    Friend WithEvents G2 As Label
    Friend WithEvents pF2 As Label
    Friend WithEvents pF1 As Label
    Friend WithEvents pJ6 As Label
    Friend WithEvents pJ7 As Label
    Friend WithEvents pJ5 As Label
    Friend WithEvents pG3 As Label
    Friend WithEvents pG1 As Label
    Friend WithEvents pG4 As Label
    Friend WithEvents ComboBoxPaises As ComboBox
End Class
