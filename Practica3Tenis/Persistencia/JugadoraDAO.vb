Public Class JugadoraDAO
    Public ReadOnly Property Jugadora As Collection

    Public Sub New()
        Me.Jugadora = New Collection
    End Sub

    Public Sub LeerTodas(ruta As String)
        Dim p As Jugadora
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Jugadoras ORDER BY PuntosJugadora DESC")
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
            p.FechaNacimiento = Date.Parse(aux(3).ToString)
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
            p.FechaNacimiento = Date.Parse(aux(3).ToString)
            p.PuntosJugadora = Convert.ToInt32(aux(4).ToString)
            p.Pais.idPais = aux(5).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Jugadora) As Integer
        Dim v = AgenteBD.ObtenerAgente.Modificar("INSERT INTO Jugadoras ([NombreJugadora], [FechaNacimiento], [PuntosJugadora], [PaisJugadora]) VALUES (" & p.NombreJugadora & "', " & p.FechaNacimiento & ", " & p.PuntosJugadora & ", '" & p.Pais.idPais & "');")
        p.idJugadora = UltimoId()
        Return v
    End Function

    Public Function Actualizar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET NombreJugadora='" & p.NombreJugadora & "', FechaNacimiento=" & p.FechaNacimiento & ", PuntosJugadora" & p.PuntosJugadora & ", PaisJugadora='" & p.Pais.idPais & "' WHERE idjugadora='" & p.idJugadora & "';")
    End Function

    Public Function Borrar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Jugadoras WHERE idjugadora=" & p.idJugadora & ";")
    End Function

    Public Function VerTorneosParticipados(p As Jugadora) As List(Of String)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer(";")
        Dim lista As New List(Of String)
        Dim i As Integer
        For Each aux In col
            lista.Add(aux(1).ToString & " | " & aux(2).ToString)
            i += 1
        Next
        Return lista

    End Function
    Public Function VerResultadoTorneos(p As Jugadora) As List(Of String)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT Ediciones.Torneo, Partidos.Ronda FROM (Jugadoras INNER JOIN Ediciones ON Jugadoras.idJugadora = Ediciones.Ganadora) INNER JOIN Partidos ON (Jugadoras.idJugadora = Partidos.Ganadora) AND (Ediciones.Anualidad = Partidos.Anualidad);")
        Dim lista As New List(Of String)
        Dim i As Integer
        For Each aux In col
            lista.Add(aux(1).ToString & " | " & aux(2).ToString)
            i += 1
        Next
        Return lista

    End Function
    Public Function AnadirPuntos(ByVal p As Jugadora, puntos As Integer) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET  PuntosJugadora=PuntosJugadora+" & puntos & " Where idJugadora=" & p.idJugadora & ";")
    End Function

    Public Function PartidosGanados(ByVal p As Jugadora) As Integer
        Dim result
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT COUNT(Ganadora) FROM Partidos WHERE Ganadora=" & p.idJugadora & ";")
        For Each aux In col
            result = Convert.ToInt32(aux(1).ToString)
        Next
        Return result
    End Function

    Public Function FinalesDisputadas(ByVal p As Jugadora) As Integer
        Dim result
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT COUNT(Jugadora) FROM Partidos INNER JOIN Juegos ON Partidos.idPartido = Juegos.Partido WHERE Juegos.Jugadora=" & p.idJugadora & " AND Ronda='final';")
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
