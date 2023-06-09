@ModelType Concesionario.Coche
@Code
    ViewData("Title") = "Details"
    Layout = Nothing
End Code
<div">
    <h3 class="text-center">Detalles del coche</h3>
    <h3 class="text-center">@Html.DisplayNameFor(Function(model) model.Brand): @Html.DisplayFor(Function(model) model.Brand)</h3>
    <hr />
    <div style="text-align:center">
        <table>
            <tbody>
                <tr>
                    <td>
                        <strong>@Html.DisplayNameFor(Function(model) model.Model)</strong>
                    </td>
                    <td>
                        @Html.DisplayFor(Function(model) model.Model)
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>@Html.DisplayNameFor(Function(model) model.Price)</strong>
                    </td>
                    <td>
                        @Html.DisplayFor(Function(model) model.Price)
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>@Html.DisplayNameFor(Function(model) model.Engine)</strong>
                    </td>
                    <td>
                        @Html.DisplayFor(Function(model) model.Engine)
                    </td>
                </tr>

                <tr>
                    <td>
                        <strong>@Html.DisplayNameFor(Function(model) model.Year)</strong>
                    </td>
                    <td>
                        @Html.DisplayFor(Function(model) model.Year)
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>@Html.DisplayNameFor(Function(model) model.Mileage)</strong>
                    </td>
                    <td>
                        @Html.DisplayFor(Function(model) model.Mileage)
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>@Html.DisplayNameFor(Function(model) model.Fuel)</strong>
                    </td>
                    <td>
                        @Html.DisplayFor(Function(model) model.Fuel)
                    </td>
                </tr>

                <tr>
                    <td>
                        <strong>@Html.DisplayNameFor(Function(model) model.GearBox)</strong>
                    </td>
                    <td>
                        @Html.DisplayFor(Function(model) model.GearBox)
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>@Html.DisplayNameFor(Function(model) model.Location)</strong>
                    </td>
                    <td>
                        @Html.DisplayFor(Function(model) model.Location)
                    </td>
                </tr>

            </tbody>
        </table>
    </div>
</div>
<style>
    table {
        border: 1px solid black;
        border-collapse: collapse;
    }

    td {
        border: 1px solid black;
        padding: 10px;
        text-align: center;
    }
</style>
@*<div>

        <h2>@Html.DisplayNameFor(Function(model) model.Brand): @Html.DisplayFor(Function(model) model.Brand)</h2>
        <hr />

        <div class="mb-5">
            <strong>@Html.DisplayNameFor(Function(model) model.Model): </strong>@Html.DisplayFor(Function(model) model.Model)
        </div>

        <div class="mb-5">
            <strong>@Html.DisplayNameFor(Function(model) model.Price): </strong>@Html.DisplayFor(Function(model) model.Price)
        </div>

        <div class="mb-5">
            <strong>@Html.DisplayNameFor(Function(model) model.Engine): </strong>@Html.DisplayFor(Function(model) model.Engine)
        </div>

        <div class="mb-5">
            <strong>@Html.DisplayNameFor(Function(model) model.Year): </strong>@Html.DisplayFor(Function(model) model.Year)
        </div>

        <div class="mb-5">
            <strong>@Html.DisplayNameFor(Function(model) model.Mileage): </strong>  @Html.DisplayFor(Function(model) model.Mileage)
        </div>

        <div class="mb-5">
            <strong>@Html.DisplayNameFor(Function(model) model.Fuel): </strong>@Html.DisplayFor(Function(model) model.Fuel)
        </div>

        <div class="mb-5">
            <strong>@Html.DisplayNameFor(Function(model) model.GearBox): </strong>@Html.DisplayFor(Function(model) model.GearBox)
        </div>


        <div class="mb-5">
            <strong>@Html.DisplayNameFor(Function(model) model.Location): </strong> @Html.DisplayFor(Function(model) model.Location)
        </div>

    </div>*@