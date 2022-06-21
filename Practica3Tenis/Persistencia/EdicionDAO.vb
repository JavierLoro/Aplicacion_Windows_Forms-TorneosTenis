Public Class EdicionDAO
    Public ReadOnly Property Edicion As Collection

    Public Sub New()
        Me.Edicion = New Collection
    End Sub

    Public Sub LeerTodas(ruta As String)
        Dim p As Edicion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Ediciones ORDER BY Torneo")
        For Each aux In col
            p = New Edicion(Convert.ToInt32(aux(1).ToString), Convert.ToInt32(aux(2).ToString))
            p.Ganadora.idJugadora = Convert.ToInt32(aux(3).ToString)
            Me.Edicion.Add(p)
        Next
    End Sub

    Public Sub LeerTodas()
        Dim p As Edicion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Ediciones ORDER BY Torneo")
        For Each aux In col
            p = New Edicion(Convert.ToInt32(aux(1).ToString), Convert.ToInt32(aux(2).ToString))
            p.Ganadora.idJugadora = Convert.ToInt32(aux(3).ToString)
            Me.Edicion.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Edicion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Ediciones WHERE Anualidad='" & p.Anualidad & "AND Torneo=" & p.Torneo.idTorneos & "';")
        For Each aux In col
            p.Anualidad = Convert.ToInt32(aux(1).ToString)
            p.Torneo.idTorneos = Convert.ToInt32(aux(2).ToString)
            p.Ganadora.idJugadora = Convert.ToInt32(aux(3).ToString)
        Next
    End Sub


    Public Sub LeerParticipantes(ByRef p As Edicion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Ediciones WHERE Anualidad='" & p.Anualidad & "AND Torneo=" & p.Torneo.idTorneos & "';")
        For Each aux In col
            p.Anualidad = Convert.ToInt32(aux(1).ToString)
            p.Torneo.idTorneos = Convert.ToInt32(aux(2).ToString)
            p.Ganadora.idJugadora = Convert.ToInt32(aux(3).ToString)
        Next
    End Sub


    Public Function Insertar(ByVal p As Edicion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Ediciones VALUES (" & p.Anualidad & ", " & p.Torneo.idTorneos & ", " & p.Ganadora.idJugadora & ");")
    End Function

    Public Function InsertarJuego(ByVal p As Edicion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Ediciones VALUES (" & p.Anualidad & ", " & p.Torneo.idTorneos & ", " & p.Ganadora.idJugadora & ");")
    End Function

    Public Function Actualizar(ByVal p As Edicion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Ediciones SET Ganadora=" & p.Ganadora.idJugadora & " WHERE Anualidad=" & p.Anualidad & ", Torneo=" & p.Torneo.idTorneos & ";")
    End Function

    Public Function Borrar(ByVal p As Edicion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Ediciones WHERE Anualidad='" & p.Anualidad & "AND Torneo=" & p.Torneo.idTorneos & "';")
    End Function

    Public Function LeerTorneosParticipados(jugadora As Jugadora) As Queue
        Dim lista As Queue = New Queue
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT t.NombreTorneo,e.Anualidad ((Torneos t INNER JOIN Edicion e ON (e.idTorneo = e.Torneo)) INNER JOIN Juegos j ON (j.Partido = p.idPartido) WHERE j.Jugadora=" & jugadora.idJugadora & ";")
        For Each aux In col
            lista.Enqueue(aux(1).ToString & " - " & aux(2).ToString)
        Next
        Return lista
    End Function
End Class
