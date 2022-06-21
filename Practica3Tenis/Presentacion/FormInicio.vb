Public Class FormInicio
    Private JAux As Jugadora = New Jugadora
    Private PAux As Pais = New Pais
    Private TAux As Torneos = New Torneos
    Private EAux As Edicion = New Edicion
    Private ParAux As Partido = New Partido
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnJugadoras_Click(sender As Object, e As EventArgs) Handles btnJugadoras.Click
        Dim f As New FormJugadoras()
        f.Show()
    End Sub
    Private Sub btnClasif_Click(sender As Object, e As EventArgs) Handles btnClasif.Click
        Dim f As New FormClasificacion()
        f.Show()
    End Sub

    Private Sub btnTorneos_Click(sender As Object, e As EventArgs) Handles btnTorneos.Click
        Dim f As New FormTorneos()
        f.Show()
    End Sub

    Private Sub btnPaises_Click(sender As Object, e As EventArgs) Handles btnPaises.Click
        Dim f As New FormPaises()
        f.Show()
    End Sub
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        '' Escoger el directorio en el que se encuentra la bbdd
        OpenFileDialog1.InitialDirectory = Application.StartupPath
        ''Si la Ruta es valida
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txbBD.Text = OpenFileDialog1.FileName
        End If
        ''Se leen todas las tablas de la bbdd, en caso de que salte una excepcion mostrar mensaje de error junto a la excepcion
        Try
            JAux.LeerTodasJugadora(txbBD.Text)
            PAux.LeerTodosPaises(txbBD.Text)
            TAux.LeerTodosTorneos(txbBD.Text)
            EAux.LeerTodosEdicion(txbBD.Text)
            ParAux.LeerTodasPartido(txbBD.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblResultConex.Text = "Error de conexión"
            lblResultConex.ForeColor = Color.Red
            Exit Sub
        End Try


        ''Botones
        btnConectar.Enabled = False
        lblResultConex.Text = "Conexion Ok"
        lblResultConex.ForeColor = Color.Green

        btnClasif.Enabled = True
        btnPaises.Enabled = True
        btnJugadoras.Enabled = True
        btnTorneos.Enabled = True

    End Sub


End Class
