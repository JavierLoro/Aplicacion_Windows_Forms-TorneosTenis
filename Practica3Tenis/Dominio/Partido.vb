Public Class Partido
    Public Property idPartido As Integer
    Public Property Anualidad As Integer
    Public Property Torneo As Torneos
    Public Property Ganadora As Jugadora
    Public Property Ronda As String
    Public ReadOnly Property PartDAO As PartidoDAO
    Public Sub New()
        Me.PartDAO = New PartidoDAO
        Torneo = New Torneos()
        Ganadora = New Jugadora()
    End Sub

    Public Sub New(Torneo As Torneos, anualidad As Integer, ronda As String)
        Me.PartDAO = New PartidoDAO
        Me.Torneo = Torneo
        Me.Anualidad = anualidad
        Me.Ronda = ronda
        Me.Ganadora = New Jugadora()

    End Sub

    Public Sub LeerTodasPartido(ruta As String)
        Me.PartDAO.LeerTodas(ruta)
    End Sub

    Public Sub LeerPartido()
        Me.PartDAO.Leer(Me)
    End Sub

    Public Function InsertarPartido() As Integer
        Return Me.PartDAO.Insertar(Me)
    End Function

    Public Function ActualizarPartido() As Integer
        Return Me.PartDAO.Actualizar(Me)
    End Function

    Public Function BorrarPartido() As Integer
        Return Me.PartDAO.Borrar(Me)
    End Function
End Class
