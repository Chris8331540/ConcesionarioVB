@ModelType IEnumerable(Of Concesionario.Coche)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Brand)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Model)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Price)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Engine)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Year)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Mileage)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Fuel)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.GearBox)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Location)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Brand)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Model)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Price)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Engine)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Year)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Mileage)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Fuel)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.GearBox)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Location)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
