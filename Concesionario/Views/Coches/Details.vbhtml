@ModelType Concesionario.Coche
@Code
    ViewData("Title") = "Details"
    Layout = Nothing
End Code
<div>
    <h1 class="text-center">Detalles del coche</h1>
    <h2 style="margin-bottom:0px">@Html.DisplayNameFor(Function(model) model.Brand)</h2>
    <hr />
    <p class="text-center">@Html.DisplayFor(Function(model) model.Brand)</p>
    <br />

    <h2 style="margin-bottom:0px">@Html.DisplayNameFor(Function(model) model.Model)</h2>
    <hr />
    <p>@Html.DisplayFor(Function(model) model.Model)</p>
    <br />

    <h2 style="margin-bottom:0px">@Html.DisplayNameFor(Function(model) model.Price)</h2>
    <hr />
    <p>@Html.DisplayFor(Function(model) model.Price)</p>
    <br />

    <h2 style="margin-bottom:0px">@Html.DisplayNameFor(Function(model) model.Engine)</h2>
    <hr />
    <p>@Html.DisplayFor(Function(model) model.Engine)</p>
    <br />

    <h2 style="margin-bottom:0px">@Html.DisplayNameFor(Function(model) model.Year)</h2>
    <hr />
    <p>@Html.DisplayFor(Function(model) model.Year)</p>
    <br />

    <h2 style="margin-bottom:0px">@Html.DisplayNameFor(Function(model) model.Mileage)</h2>
    <hr />
    <p>@Html.DisplayFor(Function(model) model.Mileage)</p>
    <br />

    <h2 style="margin-bottom:0px">@Html.DisplayNameFor(Function(model) model.Fuel)</h2>
    <hr />
    <p>@Html.DisplayFor(Function(model) model.Fuel)</p>
    <br />

    <h2 style="margin-bottom:0px">@Html.DisplayNameFor(Function(model) model.GearBox)</h2>
    <hr />
    <p>@Html.DisplayFor(Function(model) model.GearBox)</p>
    <br />

    <h2 style="margin-bottom:0px">@Html.DisplayNameFor(Function(model) model.Location)</h2>
    <hr />
    <p>@Html.DisplayFor(Function(model) model.Location)</p>
    <br />

</div>