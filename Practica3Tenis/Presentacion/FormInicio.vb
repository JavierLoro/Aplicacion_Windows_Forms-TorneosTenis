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
End Class
