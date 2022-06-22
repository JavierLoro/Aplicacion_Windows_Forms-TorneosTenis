Public Class FormClasificacion
    Private jAux As Jugadora

    Public Sub New()
        jAux = New Jugadora
        jAux.LeerTodasJugadora()
    End Sub

    Private Sub Clasificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listClasificacion.SelectedIndexChanged

    End Sub

    Private Sub FormClasificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InitializeComponent()
        Dim i As Integer
        i = 0
        listClasificacion.Items.Add("Nº" & Chr(9) & "ID" & Chr(9) & "Jugadora" & Chr(9) & "  " & Chr(9) & "Puntos" & " " & Chr(9) & "Finales" & " " & Chr(9) & "Victorias")
        For Each Pj As Jugadora In jAux.JugaDAO.Jugadora
            i += 1
            listClasificacion.Items.Add(i & Chr(9) & Convert.ToString(Pj.idJugadora) & Chr(9) & Pj.NombreJugadora & Chr(9) & " " & Chr(9) & Pj.PuntosJugadora & " " & Chr(9) & Pj.FinalesDisputadas & " " & Chr(9) & Pj.PartidosGanados)
        Next
    End Sub


End Class