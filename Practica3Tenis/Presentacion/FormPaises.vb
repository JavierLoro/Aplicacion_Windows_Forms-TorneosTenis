Public Class FormPaises
    Private paises As Pais = New Pais
    Private Sub FormPaises_Load(sender As Object, e As EventArgs)

    End Sub


    Public Sub New()
        paises = New Pais
        paises.LeerTodosPaises()
    End Sub
    Private Sub FormPaises_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InitializeComponent()
        For Each pa As Pais In paises.paisDAO.Pais
            listPais.Items.Add(pa.idPais)
        Next
    End Sub
    Private Sub listb_Paises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listPais.SelectedIndexChanged
        Dim PAux As Pais
        If listPais.SelectedItem IsNot Nothing Then
            PAux = New Pais(listPais.SelectedItem.ToString())
            Try
                PAux.LeerPaises()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End Try

            ''Cargamos datos
            txbId.Text = PAux.idPais
            txbNombre.Text = PAux.NombrePais


            btnAñad.Enabled = False
            btnElim.Enabled = True
            btnMod.Enabled = True
        End If
    End Sub

    Private Sub btnAñad_Click(sender As Object, e As EventArgs) Handles btnAñad.Click
        ''Auxiliar
        Dim PAux As Pais
        ''Comprobar que los campos no estan vacios
        If txbId.Text IsNot String.Empty And txbNombre.Text IsNot String.Empty Then
            ''Creamos el objeto con el id y modificamos su nombre por que este siempre se incializa vacio
            PAux = New Pais(txbId.Text)
            PAux.NombrePais = txbNombre.Text
            ''Intentamos insertar el objeto en la BBDD, en caso de error se muestra al usuario
            Try
                ''metemos en el if la operacion que queremos hacer para hacer la comprobacion de que ha salido bien
                If PAux.InsertarPaises() <> 1 Then
                    MessageBox.Show("Insert Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            ''Se añade el pais
            listPais.Items.Add(PAux.idPais)
        End If
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim PAux As Pais
        If txbId.Text IsNot String.Empty And txbNombre.Text IsNot String.Empty Then
            PAux = New Pais(txbId.Text)
            PAux.NombrePais = txbNombre.Text
            Try
                If PAux.ActualizarPaises() <> 1 Then
                    MessageBox.Show("Update Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            ''Despues de las comprobaciones mostrar la info al usuario sobre el intento de actualización
            MessageBox.Show("El objeto" & PAux.idPais & "se ha actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnElim_J_Click(sender As Object, e As EventArgs) Handles btnElim.Click
        Dim PAux As Pais
        If txbId.Text IsNot String.Empty Then
            PAux = New Pais(txbId.Text)
            '' messagebox eliminar si ok hace si no no lo hase xd
            If MessageBox.Show("¿Desea eliminar a " & PAux.idPais & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If PAux.BorrarPaises() <> 1 Then
                        MessageBox.Show("Delete Return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                '' Se elimina al usuario de la lista 
                listPais.Items.Remove(PAux.idPais)
                ''Limpiar los datos del usuario
                BtnLimpiar.PerformClick()
            End If

        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        txbId.Text = String.Empty
        txbNombre.Text = String.Empty
        btnAñad.Enabled = True
        btnElim.Enabled = False
        btnMod.Enabled = False
    End Sub

End Class