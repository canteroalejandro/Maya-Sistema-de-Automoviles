Imports System.IO

Public Class MBD

    Public Sub Agregar(ByVal Tabla As String, ByVal Campos() As String, ByVal Longitud As Integer, ByVal numeroIndices As Integer, ByVal Indices()() As String)
        'Descripcion de los parametros:

        'tabla = nombre de la tabla, tabla de donde se va a modificar
        'r = nº de registro
        'campos = campos que se van a guardar
        'longitud = longitud de la tabla
        'numeroIndices = cantidad de indices 
        'indices = array de indices

        Dim registro As String, CantidadRegistros As Integer, wx As Integer, i, CampoI, LongitudI As Integer, TablaI, registroI As String
        'registroI= cadena que se va a guardar

        registro = String.Join(vbTab, Campos).PadRight(Longitud)
        'PadRight agrega todos los espacios necesario spara competar la longitud

        wx = FreeFile()
        FileOpen(wx, Tabla, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Shared)
        'abro un archivo, wx es el canal
        CantidadRegistros = LOF(wx) / Longitud + 1
        ' calcula las posiciones
        'es la osicion de registro donde escribir
        'lof obtiene la longitud del archivo en byts al / longitud obtiene la cantidad de 
        'registros el poner +1 me posiciona en el ultimo registro

        Dim lon As Integer = Longitud * (CantidadRegistros - 1) + 1
        Seek(wx, lon) ' posiciona el puntero para escribir o leer el sig reg -- me lleva hasta el byte deseado, transforma el nº de registro donde r es nº de registro y me permite posicionar.
        ' se posiciona en la posicion en bits de r
        FilePut(wx, registro)
        'se escribe la variable registro
        FileClose(wx)

        'Realiza la indexacion de los archivos
        For i = 0 To numeroIndices - 1 'se usa en nI un array de array xq necesito el indice, los datos de los campos y el nombre de la tabla.la variable indice es la cantidad de indices que tengo.

            TablaI = Indices(i)(0) 'obtengo el nombre de la tabla de indices
            CampoI = Val(Indices(i)(1)) - 1 'obtengo el campo que deseo indexar
            LongitudI = Val(Indices(i)(2)) 'obtengo la longitud de ese campo

            registroI = Campos(CampoI).PadRight(LongitudI) 'alinea los caracteres a la izquierda ..... el padriight

            wx = FreeFile()
            'abre un canal de transferencia para escribir la tabla indice
            FileOpen(wx, TablaI, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Shared)
            Seek(wx, LongitudI * (CantidadRegistros - 1) + 1)
            FilePut(wx, registroI)
            FileClose(wx)

        Next

    End Sub

    Public Sub Modificar(ByVal Tabla As String, ByVal NroDeRegsitro As Integer, ByVal Campos() As String, ByVal Longitud As Integer, ByVal numeroIndices As Integer, ByVal Indices()() As String)
        'Descripcion de los parametros:

        'tabla = tabla de donde se va a modificar
        'r = nº de registro
        'campos = campos que se van a guardar
        'longitud = longitud de la tabla
        'nI = cantidad de indices
        'indices = array de indices

        Dim registro As String, wx As Integer, i, CampoI, LongitudI As Integer, TablaI, registroI As String

        registro = String.Join(vbTab, Campos).PadRight(Longitud)

        wx = FreeFile() 'canal libre
        FileOpen(wx, Tabla, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Shared) 'abro el archivo
        Seek(wx, Longitud * (NroDeRegsitro - 1) + 1)
        FilePut(wx, registro)
        FileClose(wx)

        'Realiza la indexacion de los archivos
        For i = 0 To numeroIndices - 1

            TablaI = Indices(i)(0) 'obtengo el nombre de la tabla de indices
            CampoI = Val(Indices(i)(1)) - 1 'obtengo el campo que deseo indexar
            LongitudI = Val(Indices(i)(2)) 'obtengo la longitud de ese campo

            registroI = Campos(CampoI).PadRight(LongitudI)

            wx = FreeFile()
            FileOpen(wx, TablaI, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Shared)
            Seek(wx, LongitudI * (NroDeRegsitro - 1) + 1)
            FilePut(wx, registroI)
            FileClose(wx)

        Next

    End Sub

    Public Function ObtenerUnRegistro(ByVal Tabla As String, ByVal NroDeRegsitro As Integer, ByVal Longitud As Integer) As String()
        'Obtiene un registro segun el criterio r buscado

        'Descripcion de parametros:
        '
        'r =  nº de registro
        'tabla = nombre de la tabla 
        'longitud = la long de la tabla

        Dim registro As String, wx As Integer
        wx = FreeFile()
        FileOpen(wx, Tabla, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Shared)
        Seek(wx, Longitud * (NroDeRegsitro - 1) + 1) ' posiciona el puntero para escribir o leer el sig reg -- me lleva hasta el byte deseado, transforma el nº de registro donde r es nº de registro y me permite posicionar.
        registro = Space(Longitud) 'tengo que asignar una cantidad de bytes xq el string no tiene un alongitud fija, entonces siempre se le debe asignar, y si es variable inter tiene una longitud fija de 4, bouble tiene 8, pero el string no tiene longitud determinada la long esta dada ppor el contenido de la variable!
        FileGet(wx, registro) 'lee a partir de donde esta el cursor , lee la cantidad de espacios de registro, la cantidad de bytes que tiene registro. lee la cantidad de bytes que tiene registro!
        FileClose(wx)
        Dim RegistroObtenido() As String = registro.Split(vbTab)
        RegistroObtenido(RegistroObtenido.GetUpperBound(0)) = RegistroObtenido(RegistroObtenido.GetUpperBound(0)).Trim 'getupperbound se le da la dimension de x, si tuviera una matriz iria 0 para filas y 1 para columnas
        Return RegistroObtenido
    End Function

    Public Function BuscarClave(ByVal ClaveBuscada As String, ByVal TablaIndice As String, ByVal LongitudIndice As Integer) As Integer
        'Busca un el criterio x en la tablaindice pasada como parametro
        'BUSCA EN MAYUSCULAS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        'Descripcion de parametros:
        '
        'ClaveBuscada = clave a buscar
        'tablaindice = 
        'longitudindice = 


        Dim Lectura As String
        Dim NroRegistroBuscado, Indice, PosicionActual As Integer
        Dim wx As Integer

        NroRegistroBuscado = 0
        ClaveBuscada = ClaveBuscada.ToUpper

        wx = FreeFile()
        FileOpen(wx, TablaIndice, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Shared)
        If LOF(wx) = 0 Then

            FileClose(wx)

        Else

            Lectura = Space(LOF(wx))
            FileGet(wx, Lectura) 'obtiene todo el contenido del archivo
            FileClose(wx)

            PosicionActual = 0
            'obtiene el indice de la primera aparicion de "ClaveBuscada"
            Indice = Lectura.IndexOf(ClaveBuscada, NroRegistroBuscado)

            'mientras haya resultados de la bsuqueda
            Do While Indice <> -1
                If Indice Mod LongitudIndice = 0 Then
                    NroRegistroBuscado = Indice / LongitudIndice + 1
                    Indice = -1
                Else
                    PosicionActual = Indice + 1
                    Indice = Lectura.IndexOf(ClaveBuscada, PosicionActual)
                End If
            Loop

        End If

        Return NroRegistroBuscado

    End Function

    Public Function Buscar(ByVal CriterioBusqueda As String, ByVal TablaIndice As String, ByVal LongitudIndice As Integer) As Integer()
        'Devuelve todas las apariciones del criterio buscado en forma de indices, para luego obtener a partir de los mismos todo el registro

        Dim z As String
        Dim y, PosicionBusqueda, n, r() As Integer
        Dim wx As Integer

        n = 0
        CriterioBusqueda = CriterioBusqueda.ToUpper 'x es lo que se está buscando

        wx = FreeFile() 'canal libre para el archivo
        FileOpen(wx, TablaIndice, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Shared) 'abro el archivo de indices
        If LOF(wx) = 0 Then ' si la longitud del archivo es = 0

            ReDim r(0)
            r(0) = 0
            FileClose(wx)

        Else

            ReDim r(LOF(wx) / LongitudIndice) 'redimensiona el array segun la cantidad de reg cargados

            z = Space(LOF(wx)) 'rellena con espacion vacios segun la long. del archivo
            FileGet(wx, z)
            FileClose(wx)

            PosicionBusqueda = 0
            y = z.IndexOf(CriterioBusqueda, PosicionBusqueda) 'y=posición de la cadena encontrada

            'mientras obtenga resultados de la busqueda
            Do While y <> -1

                If y Mod LongitudIndice = 0 Then
                    n += 1 'cantidad de resultados
                    r(n) = y / LongitudIndice + 1 'Devuelve el nro de registro encontrado
                End If

                PosicionBusqueda = y + 1 '
                y = z.IndexOf(CriterioBusqueda, PosicionBusqueda) 'busca la proxima aparicion dentro de la cadena 

            Loop

            ReDim Preserve r(n)
            r(0) = n

        End If

        Return r

    End Function

    Public Function BuscarNombre(ByVal x As String, ByVal TablaIndice As String, ByVal LongitudIndice As Integer) As Object

        Dim z As String
        Dim y, p, n, r() As Integer
        Dim wx As Integer

        n = 0
        x = x.ToUpper

        wx = FreeFile()
        FileOpen(wx, TablaIndice, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Shared)
        If LOF(wx) = 0 Then

            ReDim r(0)
            r(0) = 0
            FileClose(wx)

        Else

            ReDim r(LOF(wx) / LongitudIndice)

            z = Space(LOF(wx))
            FileGet(wx, z)
            FileClose(wx)
            p = 0
            y = z.IndexOf(x, p)
            Do While y <> -1
                n += 1
                r(n) = y \ LongitudIndice + 1
                p = y + 1
                y = z.IndexOf(x, p)
            Loop
            ReDim Preserve r(n)
            r(0) = n
        End If

        Return r

    End Function

    Public Function ObtenerRegistros(ByVal RutaArchivo As String, ByVal LongitudRegistro As Integer) As String()()
        'Leo el archivo, obteniendo los registros
        'y devolviendolos en un array de array

        Dim CanalLibre As Integer = FreeFile()
        Dim Registros()() As String
        Dim Todo As String
        Dim CantidadRegistros As Integer

        '1º Abro el archivo para lectura
        FileOpen(CanalLibre, RutaArchivo, OpenMode.Binary, OpenAccess.Default, OpenShare.Shared)
        If LOF(CanalLibre) = 0 Then
            FileClose(CanalLibre)
            Return Nothing
        Else

            '2º obtengo la cant de regs
            CantidadRegistros = LOF(CanalLibre) / LongitudRegistro

            '3º lleno con espacios esta variable segun la longitud del archivo
            Todo = Space(LOF(CanalLibre))
            FileGet(CanalLibre, Todo) 'lee del archivo todos lo registros
            FileClose(CanalLibre)

            Dim PosicionActual As Integer = 0
            Dim Registro As String
            Dim Campos() As String

            '4º separa los registros segun su longitud
            For i As Integer = 0 To CantidadRegistros - 1

                Registro = Todo.Substring(PosicionActual, LongitudRegistro)  'leo un registro dentro del archivo
                Registro = Registro.TrimEnd(" ") 'quito los espacios vacios del final

                ReDim Preserve Registros(i)
                Registros(i) = Registro.Split(vbTab) 'separo los campos por vbtab

                PosicionActual += LongitudRegistro

            Next

            Return Registros

        End If

    End Function

End Class
