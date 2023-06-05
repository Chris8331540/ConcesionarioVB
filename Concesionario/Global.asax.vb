Imports System.Web.Mvc
Imports System.Web.Optimization
Imports System.Web.Routing
Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        AreaRegistration.RegisterAllAreas()

        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)

        ' Configurar la inyecci�n de dependencias
        DependencyResolver.SetResolver(DependencyResolver.Current)

    End Sub
End Class
