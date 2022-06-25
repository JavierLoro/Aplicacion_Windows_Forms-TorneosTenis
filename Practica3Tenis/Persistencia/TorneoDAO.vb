Public Class TorneoDAO
    Public ReadOnly Property Torneo As Collection

    Public Sub New()
        Me.Torneo = New Collection
    End Sub

    Public Sub LeerTodas(ruta As String)
        Dim p As Torneos
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Torneos ORDER BY idTorneo")
        For Each aux In col
            p = New Torneos(Convert.ToInt32(aux(1).ToString))
            p.NombreTorneo = aux(2).ToString
            p.CiudadTorneo = aux(3).ToString
            p.PaisTorneo.idPais = aux(4).ToString
            Me.Torneo.Add(p)
        Next
    End Sub

    Public Sub LeerTodas()
        Dim p As Torneos
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Torneos ORDER BY idTorneo")
        For Each aux In col
            p = New Torneos(Convert.ToInt32(aux(1).ToString))
            p.NombreTorneo = aux(2).ToString
            p.CiudadTorneo = aux(3).ToString
            p.PaisTorneo.idPais = aux(4).ToString
            Me.Torneo.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Torneos)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Torneos WHERE idTorneo=" & p.idTorneos & ";")
        For Each aux In col
            p.NombreTorneo = aux(2).ToString
            p.CiudadTorneo = aux(3).ToString
            p.PaisTorneo.idPais = aux(4).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Torneos) As Integer
        Dim v = AgenteBD.ObtenerAgente.Modificar("INSERT INTO Torneos (NombreTorneo, CiudadTorneo, PaisTorneo) VALUES ('" & p.NombreTorneo & "', '" & p.CiudadTorneo & "', '" & p.PaisTorneo.idPais & "');")
        p.idTorneos = UltimoId()
        Return v
    End Function

    Public Function Actualizar(ByVal p As Torneos) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Torneos SET NombreTorneo='" & p.NombreTorneo & "', CiudadTorneo='" & p.CiudadTorneo & "', PaisTorneo='" & p.PaisTorneo.idPais & "' WHERE idTorneo=" & p.idTorneos & ";")
    End Function

    Public Function Borrar(ByVal p As Torneos) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Torneos WHERE idTorneo=" & p.idTorneos & ";")
    End Function
    Public Function comprobarEdicion(ByVal t As Torneos, anualidad As Integer) As Integer
        Dim col As Collection, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT Anualidad FROM Ediciones WHERE Anualidad=" & anualidad & " AND Torneo=" & t.idTorneos & ";")
        If col.Count = 0 Then
            Return False
        End If
        Return True
    End Function
    Public Function VerGanadores(p As Torneos) As List(Of String)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT Ediciones.Anualidad, Jugadoras.NombreJugadora FROM Jugadoras INNER JOIN Ediciones ON Jugadoras.idJugadora = Ediciones.Ganadora WHERE Ediciones.Torneo=" & p.idTorneos & ";")
        Dim lista As New List(Of String)
        For Each aux In col
            lista.Add(aux(1).ToString & " | " & aux(2).ToString)
        Next
        Return lista

    End Function

    Public Function listaEdiciones(t As Torneos) As List(Of Integer)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT Ediciones.Anualidad FROM Torneos INNER JOIN Ediciones ON Torneos.idTorneo = Ediciones.Torneo WHERE Torneos.idTorneo=" & t.idTorneos & " ;")
        Dim lista As New List(Of Integer)
        For Each aux In col
            lista.Add(aux(1).ToString)
        Next
        Return lista
    End Function

    Friend Function devolvercuadro(torneos As Torneos, anualidad As Integer) As List(Of String)
        Dim col As Collection : Dim aux As Collection
        Dim lista As New List(Of String)
        col = AgenteBD.ObtenerAgente.Leer("SELECT Juegos.Jugadora, Juegos.Set1, Juegos.Set2, Juegos.Set3 FROM Ediciones, Partidos, Juegos WHERE Ediciones.Anualidad = Partidos.Anualidad AND Partidos.idPartido = Juegos.Partido AND Ediciones.Torneo = Partidos.Torneo AND Ediciones.Anualidad=" & anualidad & " AND Ediciones.Torneo=" & torneos.idTorneos & " ORDER BY  Juegos.Partido;")
        For Each aux In col
            lista.Add(aux(1).ToString + " " + aux(2).ToString + "|" + aux(3).ToString + "|" + aux(4).ToString)
        Next
        Return lista
    End Function

    Public Function UltimoId() As Integer
        Dim result
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT MAX(idTorneo) FROM Torneos;")
        For Each aux In col
            result = Convert.ToInt32(aux(1).ToString)
        Next
        Return result
    End Function
End Class
