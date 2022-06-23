Public Class Jugadora
    Public Property idJugadora As Integer
    Public Property NombreJugadora As String
    Public Property FechaNacimiento As Date
    Public Property PuntosJugadora As Integer
    Public Property Pais As Pais
    Public ReadOnly Property JugaDAO As JugadoraDAO

    Public Sub New()
        Me.JugaDAO = New JugadoraDAO
        Pais = New Pais()
    End Sub

    Public Sub New(id As Integer, n As Integer)
        Me.JugaDAO = New JugadoraDAO()
        Me.idJugadora = id
        Pais = New Pais()
        If n = 1 Then
            LeerJugadora()
        End If
    End Sub

    Public Sub New(id As Integer)
        Me.JugaDAO = New JugadoraDAO()
        Me.idJugadora = id
        Pais = New Pais()
    End Sub

    Public Sub LeerTodasJugadora(ruta As String)
        Me.JugaDAO.LeerTodas(ruta)
    End Sub

    Public Sub LeerTodasJugadora()
        Me.JugaDAO.LeerTodas()
    End Sub

    Public Sub LeerJugadora()
        Me.JugaDAO.Leer(Me)
    End Sub

    Public Function InsertarJugadora() As Integer
        Return Me.JugaDAO.Insertar(Me)
    End Function

    Public Function ActualizarJugadora() As Integer
        Return Me.JugaDAO.Actualizar(Me)
    End Function

    Public Function BorrarJugadora() As Integer
        Return Me.JugaDAO.Borrar(Me)
    End Function

    Public Function NumeroJugadoras() As Integer
        Return Me.JugaDAO.Jugadora.Count
    End Function

    Public Function sumarPuntos(puntos As Integer) As Integer
        Return Me.JugaDAO.AnadirPuntos(Me, puntos)
    End Function

    Public Function FinalesDisputadas() As Integer
        Return Me.JugaDAO.FinalesDisputadas(Me)
    End Function
    Public Function PartidosGanados() As Integer
        Return Me.JugaDAO.PartidosGanados(Me)
    End Function

    Friend Function anualcompetido() As List(Of Integer)
        Return Me.JugaDAO.VerAnualCompetido(Me)
    End Function

    Friend Function anualresultados(edic As Integer) As List(Of String)
        Return Me.JugaDAO.VerResultadosAnual(Me, edic)
    End Function

    Friend Function torneosParticipados() As List(Of Torneos)
        Return Me.JugaDAO.VerTorneosParticipados(Me)
    End Function

    Friend Function resultadosTorneo(idTor As Integer) As List(Of String)
        Return Me.JugaDAO.VerResultadosTorneo(Me, idTor)
    End Function
End Class
