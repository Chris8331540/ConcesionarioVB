@ModelType IEnumerable(Of Concesionario.Coche)
@Code
ViewData("Title") = "Index"
End Code

<p>
    @Html.ActionLink("Crear nuevo registro", "Create")
</p>
<table id="registros" class="display">
    <thead>
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
            <th>Acciones</th>
        </tr>
    </thead>
    <tbody>
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
                    @Html.ActionLink("Editar", "Edit", New With {.id = item.Id}) |
                    @Html.ActionLink("Detalles", "Details", New With {.id = item.Id}) |
                    @Html.ActionLink("Borrar", "Delete", New With {.id = item.Id})
                </td>
            </tr>
        Next
    </tbody>
</table>

<script>
    $(document).ready(function () {
        $('#registros').DataTable({
            paging: true,
            scrollY: 400,
            language: {
                url: "//cdn.datatables.net/plug-ins/1.13.4/i18n/es-ES.json"
            }
        });
    });
</script>

