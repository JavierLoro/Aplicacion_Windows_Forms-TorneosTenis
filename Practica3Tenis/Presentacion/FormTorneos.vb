Public Class FormTorneos
    Private torneos As Torneos
    Private jugadoras As Jugadora


    Public Sub New()
        torneos = New Torneos
        torneos.LeerTodosTorneos()
        jugadoras = New Jugadora
        jugadoras.LeerTodasJugadora()
    End Sub

    Private Sub FormTorneos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InitializeComponent()
        For Each tor As Torneos In torneos.TorDAO.Torneo
            listTorneos.Items.Add(tor.idTorneos)
        Next

    End Sub
    Private Sub listb_Torneos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listTorneos.SelectedIndexChanged
        Dim TAux As Torneos
        Dim EAux As Edicion

        If listTorneos.SelectedItem IsNot Nothing Then
            TAux = New Torneos(listTorneos.SelectedItem.ToString())
            Try
                TAux.LeerTorneos()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End Try

            btnLimpiar.PerformClick()


            ''Cargamos datos
            Dim ganadores = TAux.Ganadores
            For Each st As String In ganadores
                listGanadores.Items.Add(st)
            Next

            Dim ediciones = TAux.CargarEdiciones
            For Each ed As Integer In ediciones
                ComBoxEdiciones.Items.Add(ed)
            Next


            txbId.Text = TAux.idTorneos
            txbNombre.Text = TAux.NombreTorneo
            txbCiu.Text = TAux.CiudadTorneo
            txbPais.Text = TAux.PaisTorneo.idPais

            If Not ComBoxEdiciones.Items.Count = 0 Then
                ComBoxEdiciones.SelectedIndex = 0
            Else
                ComBoxEdiciones.SelectedIndex = -1
            End If


            btnAñad.Enabled = False
            btnElim.Enabled = True
            btnMod.Enabled = True
            btnNuevaEdicion.Enabled = True
        End If
    End Sub

    Private Function actualizarCuadro(aux As String) As Integer
        Dim EAux As Edicion
        Dim TAux = New Torneos(aux)
        EAux = New Edicion(ComBoxEdiciones.SelectedItem, Convert.ToInt32(TAux.idTorneos))
        Dim tabla As List(Of String) = TAux.SacarCuadro(EAux.Anualidad)
        Dim StrAux As New List(Of String())

        For Each aux In tabla
            Dim Saux = Split(aux)
            StrAux.Add(Saux)

        Next

        J1.Text = New Jugadora(StrAux(0)(0), 1).NombreJugadora
        pJ1.Text = StrAux(0)(1)

        J8.Text = New Jugadora(StrAux(1)(0), 1).NombreJugadora
        pJ8.Text = StrAux(1)(1)

        J2.Text = New Jugadora(StrAux(2)(0), 1).NombreJugadora
        pJ2.Text = StrAux(2)(1)

        J7.Text = New Jugadora(StrAux(3)(0), 1).NombreJugadora
        pJ7.Text = StrAux(3)(1)

        J4.Text = New Jugadora(StrAux(4)(0), 1).NombreJugadora
        pJ4.Text = StrAux(4)(1)

        J5.Text = New Jugadora(StrAux(5)(0), 1).NombreJugadora
        pJ5.Text = StrAux(5)(1)

        J3.Text = New Jugadora(StrAux(6)(0), 1).NombreJugadora
        pJ3.Text = StrAux(6)(1)

        J6.Text = New Jugadora(StrAux(7)(0), 1).NombreJugadora
        pJ6.Text = StrAux(7)(1)

        G3.Text = New Jugadora(StrAux(8)(0), 1).NombreJugadora
        pG3.Text = StrAux(8)(1)

        G1.Text = New Jugadora(StrAux(9)(0), 1).NombreJugadora
        pG1.Text = StrAux(9)(1)

        G2.Text = New Jugadora(StrAux(10)(0), 1).NombreJugadora
        pG2.Text = StrAux(10)(1)

        G4.Text = New Jugadora(StrAux(11)(0), 1).NombreJugadora
        pG4.Text = StrAux(11)(1)

        F2.Text = New Jugadora(StrAux(12)(0), 1).NombreJugadora
        pF2.Text = StrAux(12)(1)

        F1.Text = New Jugadora(StrAux(13)(0), 1).NombreJugadora
        pF1.Text = StrAux(13)(1)

    End Function


    Private Function actualizarDatos(aux As String) As Integer
        Dim TAux As Torneos


        If listTorneos.SelectedItem IsNot Nothing Then
            TAux = New Torneos(aux)
            Try
                TAux.LeerTorneos()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End

            End Try

            btnLimpiar.PerformClick()

            ''Cargamos datos
            Dim ganadores = TAux.Ganadores
            For Each st As String In ganadores
                listGanadores.Items.Add(st)
            Next

            Dim ediciones = TAux.CargarEdiciones
            For Each ed As Integer In ediciones
                ComBoxEdiciones.Items.Add(ed)
            Next


            txbId.Text = TAux.idTorneos
            txbNombre.Text = TAux.NombreTorneo
            txbCiu.Text = TAux.CiudadTorneo
            txbPais.Text = TAux.PaisTorneo.idPais


            btnAñad.Enabled = False
            btnElim.Enabled = True
            btnMod.Enabled = True
        End If

    End Function

    Private Sub btnAñad_Click(sender As Object, e As EventArgs) Handles btnAñad.Click
        ''Auxiliar
        Dim TAux As Torneos
        ''Comprobar que los campos no estan vacios
        If txbNombre.Text IsNot String.Empty And txbCiu.Text IsNot String.Empty And txbPais IsNot String.Empty Then
            ''Creamos la jugadora con el id y modificamos su nombre por que este siempre se incializa vacio
            TAux = New Torneos()
            TAux.NombreTorneo = txbNombre.Text
            TAux.CiudadTorneo = txbCiu.Text
            TAux.PaisTorneo.idPais = txbPais.Text
            ''Intentamos insertar el objeto en la BBDD, en caso de error se muestra al usuario
            Try
                ''metemos en el if la operacion que queremos hacer para hacer la comprobacion de que ha salido bien
                If TAux.InsertarTorneos() <> 1 Then
                    MessageBox.Show("Insert Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            ''Se añade el objeto a la listbox
            listTorneos.Items.Add(TAux.idTorneos)

        End If
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim TAux As Torneos
        If txbId.Text IsNot String.Empty And txbNombre.Text IsNot String.Empty And txbCiu.Text IsNot String.Empty And txbPais IsNot String.Empty Then
            TAux = New Torneos(txbId.Text)
            TAux.NombreTorneo = txbNombre.Text
            TAux.CiudadTorneo = txbCiu.Text
            TAux.PaisTorneo.idPais = txbPais.Text
            Try
                If TAux.ActualizarTorneos() <> 1 Then
                    MessageBox.Show("Update Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            ''Despues de las comprobaciones mostrar la info al usuario sobre el intento de actualización
            MessageBox.Show("El objeto" & TAux.idTorneos & "se ha actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnElim_J_Click(sender As Object, e As EventArgs) Handles btnElim.Click
        Dim TAux As Torneos
        If txbId.Text IsNot String.Empty Then
            TAux = New Torneos(txbId.Text)
            '' messagebox eliminar si ok hace si no no lo hase xd
            If MessageBox.Show("¿Desea eliminar a " & TAux.idTorneos & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If TAux.BorrarTorneos() <> 1 Then
                        MessageBox.Show("Delete Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                '' Se elimina al usuario de la lista 
                listTorneos.Items.Remove(TAux.idTorneos)
                ''Limpiar los datos del usuario
                btnLimpiar.PerformClick()
            End If

        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        listGanadores.Items.Clear()
        ComBoxEdiciones.Items.Clear()
        txbId.Text = String.Empty
        txbNombre.Text = String.Empty
        txbCiu.Text = String.Empty
        txbPais.Text = String.Empty

        btnAñad.Enabled = True
        btnElim.Enabled = False
        btnMod.Enabled = False
    End Sub

    Private Sub btnNuevaEdicion_Click(sender As Object, e As EventArgs) Handles btnNuevaEdicion.Click
        ''Auxiliar
        Dim EAux As Edicion
        Dim TAux As Torneos
        Dim aux As Integer
        ''Comprobar que los campos no estan vacios
        If txtAnualidad.Text IsNot String.Empty Then
            TAux = New Torneos(txbId.Text)
            aux = Convert.ToInt32(txtAnualidad.Text)
            If TAux.TorDAO.comprobarEdicion(TAux, aux) = Nothing Then

                ''Generar edicion
                EAux = New Edicion(aux, TAux, jugadoras)
                lblNuevEdic.Text = "Edicion Creada"
                lblNuevEdic.ForeColor = Color.Green
                actualizarDatos(listTorneos.SelectedItem.ToString())
                ComBoxEdiciones.SelectedItem = EAux.Anualidad
            Else
                lblNuevEdic.Text = "Edicion ya existe"
                lblNuevEdic.ForeColor = Color.Red

            End If

        End If

    End Sub

    Private Sub ComBoxEdiciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComBoxEdiciones.SelectedIndexChanged
        actualizarCuadro(listTorneos.SelectedItem)
    End Sub
End Class