Public Class FormJugadoras
    Private jugadoras As Jugadora = New Jugadora
    Private torneos As Torneos = New Torneos
    Private torn As List(Of Torneos) = New List(Of Torneos)

    Public Sub New()
        jugadoras = New Jugadora
        jugadoras.LeerTodasJugadora()
        torneos = New Torneos
        torneos.LeerTodosTorneos()
    End Sub

    Private Sub FormJugadoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InitializeComponent()
        For Each Pj As Jugadora In jugadoras.JugaDAO.Jugadora
            listb_Jugadoras.Items.Add(Pj.NombreJugadora & " (" & Pj.idJugadora & ")")
        Next
    End Sub


    Private Sub btnEstadist_Click(sender As Object, e As EventArgs)
        boxMain.Hide()
        boxEstadisticas.Show()
    End Sub

    Private Sub listb_Jugadoras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listb_Jugadoras.SelectedIndexChanged
        Dim JAux As Jugadora
        If listb_Jugadoras.SelectedItem IsNot Nothing Then
            JAux = jugadoras.JugaDAO.Jugadora(listb_Jugadoras.SelectedIndex + 1)
            Try
                JAux.LeerJugadora()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End Try
            btnLimpiar.PerformClick()
            ''Estadisticas
            torn = JAux.torneosParticipados()

            For Each ot As Torneos In torn
                listaTorneos.Items.Add(ot.NombreTorneo)
            Next

            Dim anualidades = JAux.anualcompetido()
            For Each an As Integer In anualidades
                listaAños.Items.Add(an)
            Next

            If Not listaAños.Items.Count = 0 Then
                listaAños.SelectedIndex = 0
            End If

            If Not listaTorneos.Items.Count = 0 Then
                listaTorneos.SelectedIndex = 0
            End If

            ''Cargamos datos de la jugadora
            txbid_J.Text = JAux.idJugadora
            txbNomb_J.Text = JAux.NombreJugadora
            txbFn_J.Value = JAux.FechaNacimiento
            txbPais_J.Text = JAux.Pais.idPais

            btnAñad_J.Enabled = False
            btnElim_J.Enabled = True
            btnMod_J.Enabled = True
        End If
    End Sub

    Private Sub btnAñad_J_Click(sender As Object, e As EventArgs) Handles btnAñad_J.Click
        ''Auxiliar
        Dim JAux As Jugadora
        ''Comprobar que los campos no estan vacios
        If txbNomb_J.Text IsNot String.Empty And txbPais_J IsNot String.Empty Then
            ''Creamos la jugadora con el id y modificamos su nombre por que este siempre se incializa vacio
            JAux = New Jugadora()
            JAux.NombreJugadora = txbNomb_J.Text
            JAux.FechaNacimiento = txbFn_J.Value.ToString("yyyy-MM-dd")
            JAux.Pais.idPais = txbPais_J.Text

            ''Intentamos insertar la jugadora en la BBDD, en caso de error se muestra al usuario
            Try
                ''metemos en el if la operacion que queremos hacer para hacer la comprobacion de que ha salido bien
                If JAux.InsertarJugadora() <> 1 Then
                    MessageBox.Show("Insert Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            ''Se añade la persona a la listbox
            listb_Jugadoras.Items.Add(JAux.NombreJugadora & " (" & JAux.idJugadora & ")")
            jugadoras.JugaDAO.Jugadora.Add(JAux)
            listb_Jugadoras.SelectedIndex = listb_Jugadoras.TopIndex
        End If
    End Sub

    Private Sub btnMod_J_Click(sender As Object, e As EventArgs) Handles btnMod_J.Click
        Dim JAux As Jugadora
        If txbid_J.Text IsNot String.Empty And txbNomb_J.Text IsNot String.Empty And txbPais_J IsNot String.Empty Then
            JAux = New Jugadora(txbid_J.Text)
            JAux.NombreJugadora = txbNomb_J.Text
            JAux.FechaNacimiento = txbFn_J.Value.ToString("yyyy-MM-dd")
            JAux.Pais.idPais = txbPais_J.Text
            Try
                If JAux.ActualizarJugadora() <> 1 Then
                    MessageBox.Show("Update Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            ''Despues de las comprobaciones mostrar la info al usuario sobre el intento de actualización
            MessageBox.Show("La jugadora" & JAux.NombreJugadora & "( " & JAux.idJugadora & ")" & "se ha actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnElim_J_Click(sender As Object, e As EventArgs) Handles btnElim_J.Click
        Dim JAux As Jugadora
        If txbid_J.Text IsNot String.Empty Then
            JAux = New Jugadora(txbid_J.Text)
            '' messagebox eliminar si ok hace si no no lo hase xd
            If MessageBox.Show("¿Desea eliminar a " & JAux.idJugadora & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If JAux.BorrarJugadora() <> 1 Then
                        MessageBox.Show("Delete Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

                ''Limpiar los datos del usuario
                btnLimpiar.PerformClick()
            End If
            '' Se elimina al usuario de la lista 
            jugadoras.JugaDAO.Jugadora.Remove(listb_Jugadoras.SelectedIndex)
            listb_Jugadoras.Items.RemoveAt(listb_Jugadoras.SelectedIndex)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        listaAños.Items.Clear()
        listaTorneos.Items.Clear()
        listb_anu.Items.Clear()
        listb_torn.Items.Clear()
        txbid_J.Text = String.Empty
        txbNomb_J.Text = String.Empty
        txbFn_J.Text = String.Empty
        txbPais_J.Text = String.Empty
        btnAñad_J.Enabled = True
        btnElim_J.Enabled = False
        btnMod_J.Enabled = False
    End Sub

    Private Sub listaTorneos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaTorneos.SelectedIndexChanged
        Dim JAux As Jugadora
        JAux = jugadoras.JugaDAO.Jugadora(listb_Jugadoras.SelectedIndex + 1)
        Dim EAux = JAux.resultadosTorneo(torn(listaTorneos.SelectedIndex).idTorneos)
        listb_torn.Items.Clear()
        For Each tor As String In EAux
            listb_torn.Items.Add(tor)
        Next
    End Sub

    Private Sub listaAños_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaAños.SelectedIndexChanged
        Dim JAux As Jugadora
        JAux = jugadoras.JugaDAO.Jugadora(listb_Jugadoras.SelectedIndex + 1)
        Dim EAux = JAux.anualresultados(listaAños.SelectedItem)
        listb_anu.Items.Clear()
        For Each tor As String In EAux
            listb_anu.Items.Add(tor)
        Next
    End Sub

End Class