@ModelType Concesionario.Coche
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Borrar</h2>

<h3>¿Estás seguro de que deseas borrar este registro?</h3>
<div>
    <h4>Coche</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Brand)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Brand)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Model)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Model)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Price)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Price)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Engine)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Engine)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Year)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Year)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Mileage)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Mileage)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Fuel)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Fuel)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.GearBox)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.GearBox)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Location)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Location)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()
        @<div class="row mb-3">
            <div class="col-2">
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10 ">
                        <input type="submit" value="Borrar" class="btn btn-outline-dark" />
                    </div>
                </div>
            </div>
        </div>
        @<div class="row mb-3">
            <div class="col-2">
                <a class="btn btn-outline-dark" href="/Coches/Index">Volver atrás</a>
            </div>
        </div>

    End Using
</div>
