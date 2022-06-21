Public Class Pais
    Public Property idPais As String
    Public Property NombrePais As String
    Public ReadOnly Property paisDAO As PaisDAO
    Public Sub New()
        Me.PaisDAO = New PaisDAO
    End Sub

    Public Sub New(id As String)
        Me.PaisDAO = New PaisDAO
        Me.idPais = id
    End Sub

    Public Sub LeerTodosPaises(ruta As String)
        Me.paisDAO.LeerTodas(ruta)
    End Sub

    Public Sub LeerTodosPaises()
        Me.paisDAO.LeerTodas()
    End Sub

    Public Sub LeerPaises()
        Me.paisDAO.Leer(Me)
    End Sub

    Public Function InsertarPaises() As Integer
        Return Me.paisDAO.Insertar(Me)
    End Function

    Public Function ActualizarPaises() As Integer
        Return Me.paisDAO.Actualizar(Me)
    End Function

    Public Function BorrarPaises() As Integer
        Return Me.paisDAO.Borrar(Me)
    End Function
End Class
