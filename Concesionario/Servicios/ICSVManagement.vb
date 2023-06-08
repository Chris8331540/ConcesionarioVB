Public Interface ICSVManagement
    Function SubirFicheroBD(archivoCSV As HttpPostedFileBase) As Boolean
    Sub SubirRegistroBD(registro As String())

End Interface
