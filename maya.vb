Module Maya
    Sub main()
        Dim PM As New PropietariosManager
        Dim AM As New AutomovilesManager
        Dim GUIPrincipal As New GUIPrincipal(PM)

        GUIPrincipal.ShowDialog()
    End Sub
End Module
