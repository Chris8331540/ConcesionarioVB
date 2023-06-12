@ModelType IEnumerable(Of Concesionario.Coche)
@Code
    ViewData("Title") = "Index"
End Code
<div class="container-fluid">
    <a class="btn btn-outline-dark mb-3" href="/Coches/Create">
        Crear un nuevo registro
    </a>

    <div class="row mb-3">
        <div class="col-auto">
            <h5>Filtros:</h5>
        </div>
        <div class="col">
            <input type="text" id="minYear" placeholder="Año mínimo" class="form-control" />
        </div>
        <div class="col">
            <input type="text" id="maxYear" placeholder="Año máximo" class="form-control" />
        </div>
        <div class="col">
            <input type="text" id="minMileage" placeholder="Kilometraje mínimo" class="form-control" />
        </div>
        <div class="col">
            <input type="text" id="maxMileage" placeholder="Kilometraje máximo" class="form-control" />
        </div>
    </div>


    <table id="registros" class="display col-12">
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
                        @Html.ActionLink("Borrar", "Delete", New With {.id = item.Id}) |
                        @Html.ActionLink("Generar informe", "Details", New With {.id = item.Id})
                    </td>
                </tr>
            Next
        </tbody>
    </table>


</div>

<script>
    $(document).ready(function () {
        $('#registros').DataTable({
            paging: true,
            scrollY: 400,
            scrollX: true,
            language: {
                url: "//cdn.datatables.net/plug-ins/1.13.4/i18n/es-ES.json"
            }
        });
    });

    $(document).ready(function () {
        $.fn.dataTable.ext.search.push(
            function (settings, data, dataIndex) {
                var minYear = parseInt($('#minYear').val(), 10);
                var maxYear = parseInt($('#maxYear').val(), 10);
                var minMileage = parseInt($('#minMileage').val(), 10);
                var maxMileage = parseInt($('#maxMileage').val(), 10);
                var year = parseInt(data[4], 10);
                var mileage = parseInt(data[5], 10);
                var yearFilter = (isNaN(minYear) && isNaN(maxYear)) ||
                    (isNaN(minYear) && year <= maxYear) ||
                    (minYear <= year && isNaN(maxYear)) ||
                    (minYear <= year && year <= maxYear);

                var kilometrajeFilter = (isNaN(minMileage) && isNaN(maxMileage)) ||
                    (isNaN(minMileage) && mileage <= maxMileage) ||
                    (minMileage <= mileage && isNaN(maxMileage)) ||
                    (minMileage <= mileage && mileage <= maxMileage);

                return yearFilter && kilometrajeFilter;


            }
        );

        var table = $('#registros').DataTable();

        $('#minYear, #maxYear, #minMileage, #maxMileage').keyup(function () {
            table.draw();
        });
    });

</script>

