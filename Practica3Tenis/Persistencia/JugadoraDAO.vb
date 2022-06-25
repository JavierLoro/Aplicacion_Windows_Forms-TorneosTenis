Public Class JugadoraDAO
    Public ReadOnly Property Jugadora As Collection

    Public Sub New()
        Me.Jugadora = New Collection
    End Sub

    Public Sub LeerTodas(ruta As String)
        Dim p As Jugadora
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Jugadoras ORDER BY PuntosJugadora DESC")
        For Each aux In col
            p = New Jugadora(Convert.ToInt32(aux(1).ToString))
            p.NombreJugadora = aux(2).ToString
            p.FechaNacimiento = Date.Parse(aux(3).ToString)
            p.PuntosJugadora = Convert.ToInt32(aux(4).ToString)
            p.Pais.idPais = aux(5).ToString
            Me.Jugadora.Add(p)
        Next
    End Sub

    Public Sub LeerTodas()
        Dim p As Jugadora
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Jugadoras ORDER BY PuntosJugadora DESC")
        For Each aux In col
            p = New Jugadora(Convert.ToInt32(aux(1).ToString))
            p.NombreJugadora = aux(2).ToString
            p.FechaNacimiento = aux(3).ToString
            p.PuntosJugadora = Convert.ToInt32(aux(4).ToString)
            p.Pais.idPais = aux(5).ToString
            Me.Jugadora.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Jugadora)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Jugadoras WHERE idJugadora=" & p.idJugadora & ";")
        For Each aux In col
            p.NombreJugadora = aux(2).ToString
            p.FechaNacimiento = aux(3).ToString
            p.PuntosJugadora = Convert.ToInt32(aux(4).ToString)
            p.Pais.idPais = aux(5).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Jugadora) As Integer
        Dim v = AgenteBD.ObtenerAgente.Modificar("INSERT INTO Jugadoras (NombreJugadora, FechaNacimientoJugadora, PuntosJugadora, PaisJugadora) VALUES ('" & p.NombreJugadora & "', '" & p.FechaNacimiento & "', " & 0 & ", '" & p.Pais.idPais & "');")
        p.idJugadora = UltimoId()
        Return v
    End Function

    Public Function Actualizar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET NombreJugadora='" & p.NombreJugadora & "', FechaNacimientoJugadora='" & p.FechaNacimiento & "', PuntosJugadora=" & p.PuntosJugadora & ", PaisJugadora='" & p.Pais.idPais & "' WHERE idjugadora=" & p.idJugadora & ";")
    End Function

    Public Function Borrar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Jugadoras WHERE idjugadora=" & p.idJugadora & ";")
    End Function

    Public Function VerAnualCompetido(p As Jugadora) As List(Of Integer)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT DISTINCT Ediciones.Anualidad FROM (Torneos INNER JOIN (Partidos INNER JOIN Juegos ON Partidos.idPartido = Juegos.Partido) ON Torneos.idTorneo = Partidos.Torneo) INNER JOIN Ediciones ON (Partidos.Anualidad = Ediciones.Anualidad) AND (Torneos.idTorneo = Ediciones.Torneo) WHERE Juegos.Jugadora =" & p.idJugadora & ";")
        Dim lista As New List(Of Integer)
        For Each aux In col
            lista.Add(aux(1).ToString)
        Next
        Return lista

    End Function

    Public Function VerResultadosAnual(p As Jugadora, edic As Integer) As List(Of String)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT Torneos.NombreTorneo, Partidos.Ronda FROM Torneos INNER JOIN ((Partidos INNER JOIN Ediciones ON Partidos.Anualidad = Ediciones.Anualidad) INNER JOIN Juegos ON Partidos.idPartido = Juegos.Partido) ON (Torneos.idTorneo = Ediciones.Torneo) AND (Torneos.idTorneo = Partidos.Torneo) WHERE Juegos.Jugadora=" & p.idJugadora & " AND Partidos.Ganadora<>" & p.idJugadora & " AND Ediciones.Anualidad=" & edic & ";")
        Dim lista As New List(Of String)
        For Each aux In col
            If aux(2).ToString.Equals("c") Then
                lista.Add(aux(1).ToString & " - Cuartofinalista")
            ElseIf aux(2).ToString.Equals("s") Then
                lista.Add(aux(1).ToString & " - Semifinalista")
            ElseIf aux(2).ToString.Equals("f") Then
                lista.Add(aux(1).ToString & " - Finalita")
            End If
        Next
        col = AgenteBD.ObtenerAgente.Leer("SELECT DISTINCT Torneos.NombreTorneo FROM Torneos INNER JOIN Ediciones ON Torneos.idTorneo = Ediciones.Torneo WHERE Ediciones.Ganadora=" & p.idJugadora & " AND Ediciones.Anualidad=" & edic & ";")
        For Each aux In col
            lista.Add(aux(1).ToString & " - Ganadora")
        Next
        Return lista

    End Function

    Public Function VerTorneosParticipados(p As Jugadora) As List(Of Torneos)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("Select DISTINCT Torneos.idTorneo FROM (Torneos INNER JOIN (Partidos INNER JOIN Juegos On Partidos.idPartido = Juegos.Partido) On Torneos.idTorneo = Partidos.Torneo) INNER JOIN Ediciones On (Torneos.idTorneo = Ediciones.Torneo) And (Partidos.Anualidad = Ediciones.Anualidad) WHERE Juegos.Jugadora = " & p.idJugadora & ";")
        Dim lista As New List(Of Torneos)
        For Each aux In col
            Dim t As New Torneos(aux(1).ToString)
            t.LeerTorneos()
            lista.Add(t)
        Next
        Return lista

    End Function
    Public Function VerResultadosTorneo(p As Jugadora, idTor As Integer) As List(Of String)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("Select Partidos.Anualidad, Partidos.Ronda FROM (Torneos INNER JOIN (Partidos INNER JOIN Juegos On Partidos.idPartido = Juegos.Partido) On Torneos.idTorneo = Partidos.Torneo) INNER JOIN Ediciones On (Torneos.idTorneo = Ediciones.Torneo) And (Partidos.Anualidad = Ediciones.Anualidad) WHERE (Juegos.Jugadora = " & p.idJugadora & " And Not Partidos.Ganadora = " & p.idJugadora & ") And Torneos.idTorneo=" & idTor & ";")
        Dim lista As New List(Of String)
        For Each aux In col
            If aux(2).ToString.Equals("c") Then
                lista.Add(aux(1).ToString & " - Cuartofinalista")
            ElseIf aux(2).ToString.Equals("s") Then
                lista.Add(aux(1).ToString & " - Semifinalista")
            ElseIf aux(2).ToString.Equals("f") Then
                lista.Add(aux(1).ToString & " - Finalita")
            End If
        Next
        col = AgenteBD.ObtenerAgente.Leer("SELECT DISTINCT Ediciones.Anualidad FROM Torneos INNER JOIN Ediciones ON Torneos.idTorneo = Ediciones.Torneo WHERE Ediciones.Ganadora=" & p.idJugadora & " AND Torneos.idTorneo=" & idTor & ";")
        For Each aux In col
            lista.Add(aux(1).ToString & " - Ganadora")
        Next
        Return lista

    End Function

    Public Function AnadirPuntos(ByVal p As Jugadora, puntos As Integer) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras Set  PuntosJugadora=PuntosJugadora+" & puntos & " Where idJugadora=" & p.idJugadora & ";")
    End Function

    Public Function PartidosGanados(ByVal p As Jugadora) As Integer
        Dim result
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("Select COUNT(Ganadora) FROM Partidos WHERE Ganadora=" & p.idJugadora & ";")
        For Each aux In col
            result = Convert.ToInt32(aux(1).ToString)
        Next
        Return result
    End Function

    Public Function FinalesDisputadas(ByVal p As Jugadora) As Integer
        Dim result
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("Select COUNT(Jugadora) FROM Partidos INNER JOIN Juegos On Partidos.idPartido = Juegos.Partido WHERE Juegos.Jugadora=" & p.idJugadora & " And Ronda='f';")
        For Each aux In col
            result = Convert.ToInt32(aux(1).ToString)
        Next
        Return result
    End Function

    Public Function UltimoId() As Integer
        Dim result
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT MAX(idJugadora) FROM Jugadoras;")
        For Each aux In col
            result = Convert.ToInt32(aux(1).ToString)
        Next
        Return result
    End Function
End Class
