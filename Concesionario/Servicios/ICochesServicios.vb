Imports Rotativa

Public Interface ICochesServicios
    Function ObtenerListaCoches() As List(Of Coche)
    Function ObtenerCochePorId(id As Integer) As Coche

    Function ObtenerInforme(coche As Coche) As ViewAsPdf

    Sub AgregarCoche(coche As Coche)
    Sub ModificarCoche(Coche As Coche)
    Sub BorrarCoche(Coche As Coche)
End Interface
