Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Concesionario

Namespace Controllers
    Public Class CochesController
        Inherits System.Web.Mvc.Controller

        Private db As New MyDbContext

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
    End Class
End Namespace
