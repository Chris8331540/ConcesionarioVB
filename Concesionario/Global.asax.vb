Imports System.ComponentModel
Imports System.Web.Mvc
Imports System.Web.Optimization
Imports System.Web.Routing
Imports Rotativa.AspNetCore
Imports Unity

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        AreaRegistration.RegisterAllAreas()

        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)

        ' Configurar la inyección de dependencias
        DependencyResolver.SetResolver(DependencyResolver.Current)

        Dim container As New UnityContainer()

        ' Registra las dependencias en el contenedor Unity
        container.RegisterType(Of ICSVManagement, CSVManagement)()

        ' Registra el contenedor Unity en la propiedad Application para poder acceder a él en otras partes de la aplicación
        Application("UnityContainer") = container

    End Sub
End Class
