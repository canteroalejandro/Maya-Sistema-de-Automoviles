Public Class AutomovilesManager
    Dim mbd As New MBD
    Dim tablaHash As New Hashtable

    ''-----Variables Globales
    Dim indices As New ArrayList
    Dim tablaPrincipal As String = "automoviles.txt"
    Dim longitudRegistroCompleto As String = 68

    Structure indiceestruct
        Dim nombre_archivo As String
        Dim numero_campo As String
        Dim longitud_campo As String
    End Structure


    Sub New()
        cargaIndices()
        '''----------------------------------TODO ESTO ES PARA TEST--------------

        'Dim propinew As New Propietario
        'Dim propi As New Propietario

        'propi.DNI = "36060391"
        'propi.apellido = "Ferreyra"
        'propi.nombre = "Johnatan"
        'propi.fechadenac = "30/03/1992"

        'propinew.DNI = "36060390"
        'propinew.apellido = "Schiebel"
        'propinew.nombre = "Cecilia"
        'propinew.fechadenac = "30/03/1992"
        'tablaHash = obtenerTodos()
        ''agregar(propi)
        'Dim propietarioFly As New Propietario
        'propietarioFly = tablaHash("36060390")
        'MsgBox(propietarioFly.nombre + " " + propietarioFly.apellido)
        'MsgBox("Modificado")
        'editar(propinew, propi)
        'tablaHash = obtenerTodos()
        'propietarioFly = tablaHash("36060390")
        'MsgBox(propietarioFly.nombre + " " + propietarioFly.apellido)


    End Sub

#Region "funciones utiles"
    'ooooo
    Sub cargaIndices()
        Dim indice As indiceestruct

        indice.nombre_archivo = "automoviles_patente.txt"   '''Necesario para Operaciones ABM
        indice.numero_campo = 1
        indice.longitud_campo = 12
        indices.Add(indice)

    End Sub

    'ooooo
    Function objectToArray(ByVal automov As Automovil) As String()
        Dim arrayaux(5) As String
        arrayaux(0) = automov.patente
        arrayaux(1) = automov.DNI
        arrayaux(2) = automov.marca
        arrayaux(3) = automov.modelo
        arrayaux(4) = automov.ano
        arrayaux(5) = automov.codciudad
        Return arrayaux
    End Function


    Private Function indicesToArraydeArray(ByVal ind As ArrayList) As String()()
        ''Pasa los indices a array de array

        Dim cont As Integer = 0
        Dim auxsalida As String()()
        ReDim auxsalida(ind.Count - 1)
        For Each indaux As indiceestruct In ind
            ReDim auxsalida(cont)(2)
            auxsalida(cont)(0) = indaux.nombre_archivo
            auxsalida(cont)(1) = indaux.numero_campo
            auxsalida(cont)(2) = indaux.longitud_campo
            cont += 1
        Next
        Return auxsalida

        'For Each key As String In modelo.Indices.Keys()
        '    ReDim Preserve ada(i)
        '    ReDim Preserve ada(i)(2)
        '    indic = modelo.Indices(key)
        '    ada(i)(0) = indic.nombre_archivo
        '    ada(i)(1) = indic.numero_campo
        '    ada(i)(2) = indic.longitud_campo
        '    i += 1
        'Next
    End Function

#End Region

    Function agregar(ByRef automov As Automovil) As Boolean
        ''Agrega un objeto Automovil al archivo..
        Try
            tablaHash.Add(automov.patente, automov)
            mbd.Agregar(tablaPrincipal, objectToArray(automov), longitudRegistroCompleto, indices.Count, indicesToArraydeArray(indices))
            Return True
        Catch yaesta As System.ArgumentException
            Return False
        End Try

    End Function

    Function editar(ByVal automovilNuevo As Automovil, ByVal automovilViejo As Automovil) As Boolean
        Try
            tablaHash.Remove(automovilViejo.patente)
            tablaHash.Add(automovilNuevo.patente, automovilNuevo)
            mbd.Modificar(tablaPrincipal, mbd.BuscarClave(automovilViejo.patente, indices.Item(0).nombre_archivo, indices.Item(0).longitud_campo), _
                            objectToArray(automovilNuevo), longitudRegistroCompleto, indices.Count, indicesToArraydeArray(indices))
            Return True
        Catch yaesta As System.ArgumentException
            Return False
        End Try
    End Function

    Function eliminar(ByVal patente As String) As Boolean

        ' -----------borro logicamente del archivo-----------
        ''Buscamos la clave en el archivo indices
        Dim numregistro As Integer = mbd.BuscarClave(patente, indices.Item(0).nombre_archivo, indices.Item(0).longitud_campo)
        'obtengo el registro que quiero eliminar
        Dim campos() As String = mbd.ObtenerUnRegistro(tablaPrincipal, numregistro, longitudRegistroCompleto)
        'agrego la marca de deleteado
        Dim idtocado As String = "|DEL|" & campos(0)
        campos(0) = idtocado
        'modifico en la bd
        mbd.Modificar(tablaPrincipal, numregistro, campos, longitudRegistroCompleto, indices.Count, indicesToArraydeArray(indices))

        '----------elimino el objeto de la hashtable-----------
        tablaHash.Remove(patente)

        Return True
    End Function

    Function obtenerTodos() As Hashtable
        ''Devuelve una tabla hash con clave la Patente del Automovil y valor el Objeto Automovil

        Dim tablita As New Hashtable
        '' Obtengo registros del Archivo
        Dim registros()() As String = mbd.ObtenerRegistros(tablaPrincipal, longitudRegistroCompleto)
        Dim aux() As String
        ''Agrego los objetos automovil a la tabla hash
        If registros Is Nothing Then
            obtenerTodos = tablita
        Else
            For Each aux In registros
                Dim automAux As New Automovil
                Dim esdeteted As Integer = aux(0).IndexOf("|DEL|")
                If esdeteted = -1 Then
                    automAux.patente = aux(0)
                    automAux.DNI = aux(1)
                    automAux.marca = aux(2)
                    automAux.modelo = aux(3)
                    automAux.ano = aux(4)
                    automAux.codciudad = aux(5)
                    tablita.Add(automAux.DNI, automAux)
                End If
            Next
            obtenerTodos = tablita
        End If
    End Function

    Function Buscar(ByVal cosabuscada As String, ByVal filtro As String) As ArrayList
        ''Devuelve un array list con las apariciones del valor buscado
        '' posibilidades: nothing/"cargado"

        Dim auxMetodo As New ArrayList
        Select Case filtro
            Case "patente"
                For Each key As String In tablaHash.Keys()
                    Dim automAux As Automovil
                    automAux = tablaHash(key)
                    If automAux.patente.StartsWith(cosabuscada) Then
                        auxMetodo.Add(automAux)
                    End If
                Next

            Case "dni"
                ''xxxxx
                ''opcion no visible al usuario
                For Each key As String In tablaHash.Keys()
                    Dim automAux As Automovil
                    automAux = tablaHash(key)
                    If automAux.DNI.StartsWith(cosabuscada) Then
                        auxMetodo.Add(automAux)
                    End If
                Next

            Case "marca"
                For Each key As String In tablaHash.Keys()
                    Dim automAux As Automovil
                    automAux = tablaHash(key)
                    If automAux.marca.StartsWith(cosabuscada) Then
                        auxMetodo.Add(automAux)
                    End If
                Next

            Case "modelo"
                For Each key As String In tablaHash.Keys()
                    Dim automAux As Automovil
                    automAux = tablaHash(key)
                    If automAux.modelo.StartsWith(cosabuscada) Then
                        auxMetodo.Add(automAux)
                    End If
                Next

            Case "año"
                For Each key As String In tablaHash.Keys()
                    Dim automAux As Automovil
                    automAux = tablaHash(key)
                    If automAux.ano.StartsWith(cosabuscada) Then
                        auxMetodo.Add(automAux)
                    End If
                Next

            Case "codigo de ciudad"
                For Each key As String In tablaHash.Keys()
                    Dim automAux As Automovil
                    automAux = tablaHash(key)
                    If automAux.codciudad.StartsWith(cosabuscada) Then
                        auxMetodo.Add(automAux)
                    End If
                Next
        End Select

        Return auxMetodo
    End Function
End Class
