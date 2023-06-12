﻿<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Mi aplicación ASP.NET</title>
    <link rel="stylesheet" href="https://cdn.datatables.net/1.13.4/css/jquery.dataTables.css" />
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    <style>
        html, body {
            height: 100%;
        }

        .wrapper {
            min-height: 100%;
            display: flex;
            flex-direction: column;
        }

        .body-content {
            flex: 1;
        }
    </style>
</head>
<body class="">
    <div class="wrapper">
        <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
            <div class="container">
                @Html.ActionLink("Concesionario", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
                <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" title="Alternar navegación" aria-controls="navbarSupportedContent"
                        aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
                    <ul class="navbar-nav flex-grow-1">
                        <li>@Html.ActionLink("Inicio", "Index", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                        <li>@Html.ActionLink("Subir csv", "SubirCSV", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                        <li>@Html.ActionLink("CRUD", "Crud", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="container body-content">
            @RenderBody()
        </div>
        <hr />
        <footer class="text-center">
            <div class="container">
                <p>&copy; @DateTime.Now.Year - Mi aplicación ASP.NET</p>
            </div>

        </footer>
    </div>

    <script src="https://cdn.datatables.net/1.13.4/js/jquery.dataTables.js"></script>
    @RenderSection("scripts", required:=False)
</body>
</html>
