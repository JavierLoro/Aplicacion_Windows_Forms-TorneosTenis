Public Class PartidoDAO
    Public ReadOnly Property Partido As Collection

    Public Sub New()
        Me.Partido = New Collection
    End Sub

    Public Sub LeerTodas(ruta As String)
        Dim p As Partido
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Partidos ORDER BY idPartido")
        For Each aux In col
            p = New Partido()
            p.Anualidad = aux(2).ToString
            p.Torneo.idTorneos = aux(3).ToString
            p.Ganadora.idJugadora = aux(4).ToString
            p.Ronda = aux(5).ToString
            Me.Partido.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Partido)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Partidos WHERE idPartido='" & p.idPartido & "';")
        For Each aux In col
            p.Anualidad = Convert.ToInt32(aux(2).ToString)
            p.Torneo.idTorneos = Convert.ToInt32(aux(3).ToString)
            p.Ganadora.idJugadora = Convert.ToInt32(aux(4).ToString)
            p.Ronda = Convert.ToInt32(aux(5).ToString)
        Next
    End Sub

    Public Function Insertar(ByVal p As Partido) As Integer
        Dim v = AgenteBD.ObtenerAgente.Modificar("INSERT INTO Partidos (Anualidad, Torneo, Ganadora, Ronda) VALUES (" & p.Anualidad & ", " & p.Torneo.idTorneos & ", " & 1 & ", '" & p.Ronda & "');")
        p.idPartido = UltimoId()
        Return v
    End Function

    Public Function Actualizar(ByVal p As Partido) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Partidos SET Anualidad=" & p.Anualidad & ", Torneo=" & p.Torneo.idTorneos & ", Ganadora=" & p.Ganadora.idJugadora & ", Ronda='" & p.Ronda & "' WHERE idPartido=" & p.idPartido & ";")
    End Function

    Public Function Borrar(ByVal p As Partido) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Partidos WHERE idPartido='" & p.idPartido & "';")
    End Function

    Public Function UltimoId() As Integer
        Dim result
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT MAX(idPartido) FROM Partidos;")
        For Each aux In col
            result = Convert.ToInt32(aux(1).ToString)
        Next
        Return result
    End Function

    Public Function InsertarJuego(ByVal j As Juegos) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Juegos VALUES (" & j.Jugadora.idJugadora & ", " & j.Partido.idPartido & ", " & j.Set1 & ", " & j.Set2 & ", " & j.Set3 & ");")
    End Function
End Class
