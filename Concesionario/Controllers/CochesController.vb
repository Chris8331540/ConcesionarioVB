Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Services.Description
Imports Concesionario
Imports Unity

Namespace Controllers
    Public Class CochesController
        Inherits System.Web.Mvc.Controller

        Private db As New MyDbContext
        Private _servicioCsv As ICSVManagement

        Protected Overrides Sub Initialize(requestContext As RequestContext)
            MyBase.Initialize(requestContext)

            ' Recupera el contenedor Unity desde el contenedor global
            Dim container As UnityContainer = CType(HttpContext.Application("UnityContainer"), UnityContainer)

            ' Resuelve la dependencia ICSVManagement utilizando el contenedor Unity
            _servicioCsv = container.Resolve(Of ICSVManagement)()
        End Sub
        'Public Sub New(servicioCsv As ICSVManagement)
        '    _servicioCsv = servicioCsv
        '    db = New MyDbContext()
        'End Sub

        ' GET: Coches
        Function Index() As ActionResult
            Return View(db.Coches.ToList())
        End Function

        ' GET: Coches/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim coche As Coche = db.Coches.Find(id)
            If IsNothing(coche) Then
                Return HttpNotFound()
            End If
            Return View(coche)
        End Function

        ' GET: Coches/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Coches/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Brand,Model,Price,Engine,Year,Mileage,Fuel,GearBox,Location")> ByVal coche As Coche) As ActionResult
            If ModelState.IsValid Then
                db.Coches.Add(coche)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(coche)
        End Function

        ' GET: Coches/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim coche As Coche = db.Coches.Find(id)
            If IsNothing(coche) Then
                Return HttpNotFound()
            End If
            Return View(coche)
        End Function

        ' POST: Coches/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Brand,Model,Price,Engine,Year,Mileage,Fuel,GearBox,Location")> ByVal coche As Coche) As ActionResult
            If ModelState.IsValid Then
                db.Entry(coche).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(coche)
        End Function

        ' GET: Coches/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim coche As Coche = db.Coches.Find(id)
            If IsNothing(coche) Then
                Return HttpNotFound()
            End If
            Return View(coche)
        End Function

        ' POST: Coches/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim coche As Coche = db.Coches.Find(id)
            db.Coches.Remove(coche)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Function SubirCSV() As ActionResult
            ViewData("Message") = "Sube tu CSV"
            Dim mensaje As String = TempData("mensaje")?.ToString()
            ViewBag.Mensaje = mensaje
            Return View()
        End Function

        <HttpPost>
        Function SubirCSVPost(archivoCSV As HttpPostedFileBase) As ActionResult
            Dim resultado As Boolean = _servicioCsv.SubirFicheroBD(archivoCSV)
            Dim mensaje As String
            If resultado Then
                mensaje = "Se han subido correctamente todos los registros."
            Else
                mensaje = "Ha ocurrido un error al subir los registros."
            End If
            TempData("mensaje") = mensaje
            Return RedirectToAction("SubirCSV")
        End Function
        Function Crud() As ActionResult
            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace
