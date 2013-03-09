Public Class PropietariosManager
    Dim mbd As New mbd
    Dim tablaHash As New Hashtable

    ''-----Variables Globales
    Dim indices As New ArrayList
    Dim vectoraux(3) As String
    Dim tablaPrincipal As String = "propietarios.txt"
    Dim longitudRegistroCompleto As String = 65

    Structure indiceestruct
        Dim nombre_archivo As String
        Dim numero_campo As String
        Dim longitud_campo As String
    End Structure

    Sub New()
        cargaIndices()
        ''----------------------------------TODO ESTO ES PARA TEST--------------

        Dim propinew As New Propietario
        Dim propi As New Propietario

        propi.DNI = "36060391"
        propi.apellido = "Ferreyra"
        propi.nombre = "Johnatan"
        propi.fechadenac = "30/03/1992"

        propinew.DNI = "36060390"
        propinew.apellido = "Schiebel"
        propinew.nombre = "Cecilia"
        propinew.fechadenac = "30/03/1992"

        tablaHash = obtenerTodos()
        'agregar(propi)
        'agregar(propinew)
        'eliminar("36060390")

        Dim pruebaBusq As New ArrayList
        pruebaBusq = Buscar("tan", "nombre")
        If pruebaBusq.Count <> 0 Then
            For Each aux As Propietario In pruebaBusq
                MsgBox(aux.nombre, MsgBoxStyle.Information, "Resultado en la Busqueda")
            Next
        Else
            MsgBox("No hay naranja")
        End If

        ''Muestra los objetos (propietarios) en la tabla hash
        ''For Each key As String In tablaHash.Keys()
        ''    Dim aux As New Propietario
        ''    aux = tablaHash(key)
        ''    MsgBox(aux.nombre, MsgBoxStyle.Information, "Lo que hay en la tabla hash y el archivo")
        ''Next

        'eliminar("36060390")
        'tablaHash = obtenerTodos()

        ''For Each key As String In tablaHash.Keys()
        ''    Dim aux As New Propietario
        ''    aux = tablaHash(key)
        ''    MsgBox(aux.nombre, MsgBoxStyle.Information, "Lo que hay en la tabla hash y el archivo")
        ''Next

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

        indice.nombre_archivo = "propietarios_dni.txt"   '''Necesario para Operaciones ABM
        indice.numero_campo = 1
        indice.longitud_campo = 15
        indices.Add(indice)

        'indice.nombre_archivo = "propietarios_apellido.txt"   '''Necesario para Operaciones ABM
        'indice.numero_campo = 2
        'indice.longitud_campo = 20
        'indices.Add(indice)

        'indice.nombre_archivo = "propietarios_nombre.txt"   '''Necesario para Operaciones ABM
        'indice.numero_campo = 3
        'indice.longitud_campo = 20
        'indices.Add(indice)

        'indice.nombre_archivo = "propietarios_fechanac.txt"   '''Necesario para Operaciones ABM
        'indice.numero_campo = 4
        'indice.longitud_campo = 10
        'indices.Add(indice)
    End Sub

    'ooooo
    Function objectToArray(ByVal propieta As Propietario) As String()
        ''Pasa de objeto a un array de string

        Dim arrayaux(3) As String
        arrayaux(0) = propieta.DNI
        arrayaux(1) = propieta.apellido
        arrayaux(2) = propieta.nombre
        arrayaux(3) = propieta.fechadenac
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

    Function agregar(ByRef propiet As Propietario) As Boolean
        ''Agrega un objeto Propietario al archivo..
        Try
            tablaHash.Add(propiet.DNI, propiet)
            mbd.Agregar(tablaPrincipal, objectToArray(propiet), longitudRegistroCompleto, indices.Count, indicesToArraydeArray(indices))
            Return True
        Catch yaesta As System.ArgumentException
            Return False
        End Try

    End Function

    Function editar(ByVal propietarioNuevo As Propietario, ByVal propietarioViejo As Propietario) As Boolean
        Try
            tablaHash.Remove(propietarioViejo.DNI)
            tablaHash.Add(propietarioNuevo.DNI, propietarioNuevo)
            Dim numregistro As Integer = mbd.BuscarClave(propietarioViejo.DNI, indices.Item(0).nombre_archivo, indices.Item(0).longitud_campo)
            mbd.Modificar(tablaPrincipal, numregistro, objectToArray(propietarioNuevo), longitudRegistroCompleto, indices.Count, indicesToArraydeArray(indices))
            Return True
        Catch yaesta As System.ArgumentException
            Return False
        End Try
    End Function

    Function eliminar(ByVal DNI As String) As Boolean

        ' -----------borro logicamente del archivo-----------
        ''Buscamos la clave en el archivo indice
        Dim numregistro As Integer = mbd.BuscarClave(DNI, indices.Item(0).nombre_archivo, indices.Item(0).longitud_campo) 'todo: verificar que no exista el id
        'obtengo el registro que quiero eliminar
        Dim campos() As String = mbd.ObtenerUnRegistro(tablaPrincipal, numregistro, longitudRegistroCompleto)
        'agrego la marca de deleteado
        Dim idtocado As String = "|DEL|" & campos(0)
        campos(0) = idtocado
        'modifico en la bd
        mbd.Modificar(tablaPrincipal, numregistro, campos, longitudRegistroCompleto, indices.Count, indicesToArraydeArray(indices))

        '----------elimino el objeto de la hashtable-----------
        tablaHash.Remove(DNI)

        Return True
    End Function

    Function obtenerTodos() As Hashtable
        ''Devuelve una tabla hash con clave el DNI del Propietario y valor el Objeto Propietario

        Dim tablita As New Hashtable
        '' Obtengo registros del Archivo
        Dim registros()() As String = mbd.ObtenerRegistros(tablaPrincipal, longitudRegistroCompleto)
        Dim aux() As String
        ''Agrego los objetos propietarios a la tabla hash
        If registros Is Nothing Then
            obtenerTodos = tablita
        Else
            For Each aux In registros
                Dim propAux As New Propietario
                Dim esdeteted As Integer = aux(0).IndexOf("|DEL|")
                If esdeteted = -1 Then
                    propAux.DNI = aux(0)
                    propAux.apellido = aux(1)
                    propAux.nombre = aux(2)
                    propAux.fechadenac = aux(3)
                    tablita.Add(propAux.DNI, propAux)
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
            Case "dni"
                For Each key As String In tablaHash.Keys()
                    Dim propiAux As Propietario
                    propiAux = tablaHash(key)
                    If propiAux.DNI.StartsWith(cosabuscada) Then
                        auxMetodo.Add(propiAux)
                    End If
                Next
            Case "nombre"
                For Each key As String In tablaHash.Keys()
                    Dim propiAux As Propietario
                    propiAux = tablaHash(key)
                    If propiAux.nombre.StartsWith(cosabuscada) Then
                        auxMetodo.Add(propiAux)
                    End If
                Next
            Case "apellido"
                For Each key As String In tablaHash.Keys()
                    Dim propiAux As Propietario
                    propiAux = tablaHash(key)
                    If propiAux.apellido.StartsWith(cosabuscada) Then
                        auxMetodo.Add(propiAux)
                    End If
                Next
        End Select

        Return auxMetodo
    End Function

End Class

