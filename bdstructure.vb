Public Class bdstructure
    Structure indice
        Dim nombre_archivo As String
        Dim numero_campo As String
        Dim longitud_campo As String
    End Structure

    Structure model
        Dim nombreTabla As String 'nombre del archivo
        Dim LongitudTabla As Integer 'maximo largo del archivo
        Dim NroIndices As Integer 'cantidad de indices de la tabla(un indice por cada tabla)
        Dim Indices As Hashtable
    End Structure

    Public modelo As model
    Public bd As MBD

    'OOO
    Sub New(ByVal nombretabla As String, ByVal longitud As Integer, ByVal mbd As MBD)
        modelo.nombreTabla = nombretabla
        modelo.LongitudTabla = longitud
        Me.bd = mbd
    End Sub

    'OOO
    Public Sub agregar_indice(ByVal nombreindice As String, ByVal nombrearchivo As String, ByVal numdecampo As String, ByVal longitud As String)
        Dim ind As indice
        ind.longitud_campo = longitud
        ind.nombre_archivo = nombrearchivo
        ind.numero_campo = numdecampo
        modelo.Indices = New Hashtable
        modelo.Indices.Add(nombreindice, ind)
        modelo.NroIndices = modelo.Indices.Count()
    End Sub

    'OOO
    Public Function agregar(ByVal datos As ArrayList) As Boolean
        Dim campos() As String = arraylistToVector(datos)
        Dim indices()() As String = indicesToArraydeArray(modelo.Indices)
        'todo verificar que no exista el id
        bd.Agregar(modelo.nombreTabla, campos, modelo.LongitudTabla, modelo.NroIndices, indices)
        Return True
    End Function

    'OOO
    Public Function modificar(ByVal criterio As String, ByVal datos As ArrayList) As Boolean
        Dim numregistro As Integer
        'consigo el primer indice(el de id)
        Dim ind As indice = modelo.Indices("ID")
        'todo verificar que no exista el id
        numregistro = bd.BuscarClave(criterio, ind.nombre_archivo, ind.longitud_campo)
        Dim indices()() As String = indicesToArraydeArray(modelo.Indices)
        Dim campos() As String = arraylistToVector(datos)
        bd.Modificar(modelo.nombreTabla, numregistro, campos, modelo.LongitudTabla, modelo.NroIndices, indices)
        Return True
    End Function

    Public Function eliminar(ByVal id As String) As Boolean
        Return True
    End Function
    'OOO
    Public Function eliminarlogico(ByVal id As String) As Boolean
        'consigo el primer indice(el de id)
        Dim ind As indice = modelo.Indices("ID")
        'busco la clave en el indice
        Dim indices()() As String = indicesToArraydeArray(modelo.Indices)
        Dim numregistro As Integer = bd.BuscarClave(id, ind.nombre_archivo, ind.longitud_campo) 'todo: verificar que no exista el id
        'obtengo el registro que quiero eliminar
        Dim campos() As String = bd.ObtenerUnRegistro(modelo.nombreTabla, numregistro, modelo.LongitudTabla)
        'agrego la marca de deleteado
        Dim idtocado As String = "|DEL|" & campos(0)
        campos(0) = idtocado
        'modifico en la bd
        bd.Modificar(modelo.nombreTabla, numregistro, campos, modelo.LongitudTabla, modelo.NroIndices, indices)
        Return True
    End Function

    'OOO
    Public Function obtener_todos() As Hashtable
        Dim ht As New Hashtable
        Dim mio1()() As String = bd.ObtenerRegistros(modelo.nombreTabla, 100)
        For Each reg() As String In mio1
            Dim esdeteted As Integer = reg(0).IndexOf("|DEL|")
            If esdeteted = -1 Then
                ht.Add(reg(0), reg)
            End If
        Next
        Return ht
    End Function
    'OOO
    Private Function arraylistToVector(ByVal al As ArrayList) As String()
        Dim vector() As String
        ReDim vector(al.Count)
        Dim i As Integer = 0
        For Each actual As String In al
            vector(i) = actual.ToString.ToUpper()
            i += 1
        Next
        Return vector
    End Function
    'OOO
    Private Function indicesToArraydeArray(ByVal ht As Hashtable) As String()()
        Dim ada()() As String
        Dim indic As indice
        Dim i As Integer
        Dim h As New Collection
        For Each key As String In modelo.Indices.Keys()
            ReDim Preserve ada(i)
            ReDim Preserve ada(i)(2)
            indic = modelo.Indices(key)
            ada(i)(0) = indic.nombre_archivo
            ada(i)(1) = indic.numero_campo
            ada(i)(2) = indic.longitud_campo
            i += 1
        Next
        Return ada
    End Function

End Class
