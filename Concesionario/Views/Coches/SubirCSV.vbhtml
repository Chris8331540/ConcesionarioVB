@Code
    ViewData("Title") = "SubirCSV"
    Dim mensaje As String = Convert.ToString(ViewBag.Mensaje)
End Code


<div class="container">
    <h2>Sube la información de tu fichero csv a la base de datos</h2>
    <form action="/Coches/SubirCSVPost" method="post" enctype="multipart/form-data">
        <div class="row mb-3">
            <div class="col-md-2">
                <input type="file" accept=".csv" name="archivoCSV" />
            </div>
        </div>
        <div class="row mb-3">
            <div class="col-md-2">
                <button type="submit" class="btn btn-primary">Subir csv</button>
            </div>
        </div>

    </form>
</div>

<div class="position-fixed top-0 end-0 p-3" style="z-index:11">
    <div id="miToast" class="toast">
        <div class="toast-header justify-content-between d-flex">
            <strong class="me-auto">Aviso</strong>
            <button class="btn-close" data-bs-dismiss="toast"></button>
        </div>
        <div class="toast-body">
            @mensaje
        </div>
    </div>
</div>

<script>
    var mensaje = '@mensaje'
    function detectarMensaje() {
        if (mensaje != '') {
            mostrarToast();
        }
    }
    function mostrarToast() {
        var ejemploToast = document.getElementById(`miToast`);
        var toast = new bootstrap.Toast(ejemploToast);
        toast.show();
    }
    window.onload = detectarMensaje();
</script>