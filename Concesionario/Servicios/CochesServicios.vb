Imports System.Data.Entity
Imports Rotativa

Public Class CochesServicios
    Implements ICochesServicios

    Private db As New MyDbContext

    Public Sub AgregarCoche(coche As Coche) Implements ICochesServicios.AgregarCoche
        db.Coches.Add(coche)
        db.SaveChanges()
    End Sub

    Public Sub ModificarCoche(Coche As Coche) Implements ICochesServicios.ModificarCoche
        db.Entry(Coche).State = EntityState.Modified
        db.SaveChanges()
    End Sub

    Public Sub BorrarCoche(Coche As Coche) Implements ICochesServicios.BorrarCoche
        db.Coches.Remove(Coche)
        db.SaveChanges()
    End Sub

    Function ObtenerListaCoches() As List(Of Coche) Implements ICochesServicios.ObtenerListaCoches
        Dim listaCoches As List(Of Coche) = db.Coches.ToList()
        Return listaCoches
    End Function

    Public Function ObtenerInforme(coche As Coche) As ViewAsPdf Implements ICochesServicios.ObtenerInforme
        Dim pdf As ViewAsPdf = New ViewAsPdf("Details", coche) With {
                    .FileName = "Informe" + coche.Id.ToString + ".pdf"
            }
        Return pdf
    End Function

    Private Function ObtenerCochePorId(id As Integer) As Coche Implements ICochesServicios.ObtenerCochePorId
        Dim coche As Coche = db.Coches.Find(id)
        Return coche
    End Function


End Class
