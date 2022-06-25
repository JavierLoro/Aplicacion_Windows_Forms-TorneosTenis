Public Class Edicion
    Public Property Anualidad As Integer
    Public Property Torneo As Torneos
    Public Property Ganadora As Jugadora
    Public Property jugadorasTorneo As List(Of Jugadora)
    Public ReadOnly Property ediDAO As EdicionDAO
    Public ReadOnly Property partiDAO As PartidoDAO

    Public Sub New()
        Me.ediDAO = New EdicionDAO
        Torneo = New Torneos
        Ganadora = New Jugadora
    End Sub

    Public Sub New(anualidad As Integer, torneo As Torneos, jugadoras As Jugadora)
        Me.ediDAO = New EdicionDAO
        Me.partiDAO = New PartidoDAO
        Me.Torneo = torneo
        Me.Anualidad = anualidad
        jugadorasTorneo = New List(Of Jugadora)
        GenerarEnfrentamientos(jugadoras)
    End Sub

    Public Sub New(anualidad As Integer, torneo As Integer)
        Me.ediDAO = New EdicionDAO
        Me.Torneo = New Torneos(torneo)
        Me.Anualidad = anualidad
        Ganadora = New Jugadora
    End Sub

    Public Sub LeerTodosEdicion(ruta As String)
        Me.ediDAO.LeerTodas(ruta)
    End Sub

    Public Sub LeerTodosEdicion()
        Me.ediDAO.LeerTodas()
    End Sub

    Public Sub LeerEdicion()
        Me.ediDAO.Leer(Me)
    End Sub

    Public Function InsertarEdicion() As Integer
        Return Me.ediDAO.Insertar(Me)
    End Function

    Public Function InsertarJuego() As Integer
        Return Me.ediDAO.InsertarJuego(Me)
    End Function
    Public Function ActualizarEdicion() As Integer
        Return Me.ediDAO.Actualizar(Me)
    End Function

    Public Function BorrarEdicion() As Integer
        Return Me.ediDAO.Borrar(Me)
    End Function

    Public Function OrdenarJugadoras(jugadoras As List(Of Jugadora)) As List(Of Jugadora)

        Dim aux As Jugadora
        Dim n = jugadoras.Count
        For i As Integer = 0 To n - 1
            For j As Integer = 0 To (n - i - 2)
                If jugadoras(j).PuntosJugadora > jugadoras(j + 1).PuntosJugadora Then
                    aux = jugadoras(j)
                    jugadoras(j) = jugadoras(j + 1)
                    jugadoras(j + 1) = aux
                End If
            Next
        Next
        Return jugadoras
    End Function

    Public Function GenerarEnfrentamientos(jugadoras As Jugadora) As Integer
        Randomize()
        Me.InsertarEdicion()
        Dim value As Integer
        Dim j As Jugadora
        Dim rango = jugadoras.NumeroJugadoras
        value = CInt(Int((rango * Rnd()) + 1))
        j = jugadoras.JugaDAO.Jugadora(value)
        jugadorasTorneo.Add(j)
        While jugadorasTorneo.Count < 8
            value = CInt(Int((rango * Rnd()) + 1))
            j = jugadoras.JugaDAO.Jugadora(value)
            If Not jugadorasTorneo.Contains(j) Then
                jugadorasTorneo.Add(j)
            End If
        End While

        ''Ordenar jugadoras
        jugadorasTorneo = OrdenarJugadoras(jugadorasTorneo)

        ''Primera Fase
        Dim fase1 = "c"
        Dim g1 = generarPartido(jugadorasTorneo(0), jugadorasTorneo(7), fase1)
        Dim g2 = generarPartido(jugadorasTorneo(1), jugadorasTorneo(6), fase1)
        Dim g3 = generarPartido(jugadorasTorneo(3), jugadorasTorneo(4), fase1)
        Dim g4 = generarPartido(jugadorasTorneo(2), jugadorasTorneo(5), fase1)

        ''SegundaFase
        Dim fase2 = "s"
        Dim f1 = generarPartido(g1, g3, fase2)
        Dim f2 = generarPartido(g2, g4, fase2)

        ''Final
        Dim fase3 = "f"
        Dim ganadora = generarPartido(f1, f2, fase3)
        ''Puntos ganador torneo
        If ganadora.idJugadora = f1.idJugadora Then
            f1.sumarPuntos(100)
        Else
            f2.sumarPuntos(100)
        End If
        Me.Ganadora = ganadora
        Me.ActualizarEdicion()

        Return Nothing
    End Function

    Public Function puntosObtenidos(ronda As String) As Integer
        Select Case ronda
            Case "c"
                Return 10
            Case "s"
                Return 25
            Case "f"
                Return 50
            Case Else
                Return 100
        End Select

    End Function

    Public Function generarPartido(j1 As Jugadora, j2 As Jugadora, ronda As String) As Jugadora
        ''Generamos los juegos y partido
        Dim s1, s2, s3 As List(Of Integer)
        s1 = New List(Of Integer)
        s2 = New List(Of Integer)
        s3 = New List(Of Integer)
        Dim rand1, rand2, rand3 As Integer
        Dim Jaux1, Jaux2 As Juegos
        Dim partido = New Partido(Torneo, Anualidad, ronda)
        Dim ganadora As Jugadora
        rand1 = CInt(Int((2 * Rnd()) + 1))
        rand2 = CInt(Int((2 * Rnd()) + 1))
        rand3 = CInt(Int((2 * Rnd()) + 1))
        partido.Anualidad = Me.Anualidad
        partido.Torneo = Me.Torneo
        partido.InsertarPartido()

        If rand1 = 1 Then
            s1.Add(6)
            s1.Add(CInt(Int((4 * Rnd()) + 1)))
        Else
            s1.Add(CInt(Int((4 * Rnd()) + 1)))
            s1.Add(6)
        End If

        If rand2 = 1 Then
            s2.Add(6)
            s2.Add(CInt(Int((4 * Rnd()) + 1)))
        Else
            s2.Add(CInt(Int((4 * Rnd()) + 1)))
            s2.Add(6)
        End If

        If rand3 = 1 Then
            s3.Add(6)
            s3.Add(CInt(Int((4 * Rnd()) + 1)))
        Else
            s3.Add(CInt(Int((4 * Rnd()) + 1)))
            s3.Add(6)
        End If

        ''Juego jugadora1
        Jaux1 = New Juegos(j1)
        Jaux1.Set1 = s1(0)
        Jaux1.Set2 = s2(0)

        ''Juego jugadora2
        Jaux2 = New Juegos(j2)
        Jaux2.Set1 = s1(1)
        Jaux2.Set2 = s2(1)

        If (rand1 = 1 And rand2 = 1) Or (rand1 = 1 And rand3 = 1) Or (rand2 = 1 And rand3 = 1) Then
            ''Gana jugadora1
            ganadora = j1
            partido.Ganadora = j1
            j2.sumarPuntos(puntosObtenidos(ronda))

            If rand1 = 1 And rand2 = 1 Then
                ''Gano en 2 sets
                Jaux1.Set3 = 0
                Jaux2.Set3 = 0
            Else
                ''Gano en 3 sets
                Jaux1.Set3 = s3(0)
                Jaux2.Set3 = s3(1)
            End If

        Else
            ''Gana jugadora2
            ganadora = j2
            partido.Ganadora = j2
            j1.sumarPuntos(puntosObtenidos(ronda))

            If rand1 = 2 And rand2 = 2 Then
                ''Gano en 2 sets
                Jaux1.Set3 = 0
                Jaux2.Set3 = 0
            Else
                ''Gano en 3 sets
                Jaux1.Set3 = s3(0)
                Jaux2.Set3 = s3(1)

            End If

        End If
        ''Guardar partido y juegos

        partido.ActualizarPartido()
        Jaux1.Partido = partido
        Jaux2.Partido = partido
        partiDAO.InsertarJuego(Jaux1)
        partiDAO.InsertarJuego(Jaux2)
        Return ganadora
    End Function
End Class
