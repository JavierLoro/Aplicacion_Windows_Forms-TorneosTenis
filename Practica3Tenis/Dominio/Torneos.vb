Public Class Torneos
    Public Property idTorneos As Integer
    Public Property NombreTorneo As String
    Public Property CiudadTorneo As String
    Public Property PaisTorneo As Pais
    Public ReadOnly Property EdiciDAO As EdicionDAO
    Public ReadOnly Property PartiDAO As PartidoDAO
    Public ReadOnly Property TorDAO As TorneoDAO
    Public Sub New()
        Me.TorDAO = New TorneoDAO
        Me.EdiciDAO = New EdicionDAO
        PaisTorneo = New Pais
    End Sub

    Public Sub New(id As Integer)
        Me.TorDAO = New TorneoDAO
        Me.idTorneos = id
        PaisTorneo = New Pais
    End Sub

    Public Function comprobarediciones(aux As Integer) As Boolean
        Return Me.TorDAO.comprobarEdicion(Me, aux)
    End Function

    Public Sub LeerTodosTorneos(ruta As String)
        Me.TorDAO.LeerTodas(ruta)
    End Sub

    Public Sub LeerTodosTorneos()
        Me.TorDAO.LeerTodas()
    End Sub

    Public Sub LeerTorneos()
        Me.TorDAO.Leer(Me)
    End Sub

    Public Function InsertarTorneos() As Integer
        Return Me.TorDAO.Insertar(Me)
    End Function

    Public Function ActualizarTorneos() As Integer
        Return Me.TorDAO.Actualizar(Me)
    End Function

    Public Function BorrarTorneos() As Integer
        Return Me.TorDAO.Borrar(Me)
    End Function

    Public Function Ganadores() As List(Of String)
        Return Me.TorDAO.VerGanadores(Me)
    End Function

    Public Function CargarEdiciones() As List(Of Integer)
        Return Me.TorDAO.listaEdiciones(Me)
    End Function

    Public Function SacarCuadro(aux As Integer) As List(Of String)
        Return Me.TorDAO.devolvercuadro(Me, aux)
    End Function

End Class
