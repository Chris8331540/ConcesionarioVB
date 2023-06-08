Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function SubirCSV() As ActionResult
        Return RedirectToAction("SubirCSV", "Coches")
    End Function

    Function Crud() As ActionResult
        Return RedirectToAction("Crud", "Coches")
    End Function
End Class
