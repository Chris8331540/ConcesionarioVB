@ModelType Concesionario.Coche
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
