@ModelType Concesionario.Coche
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
