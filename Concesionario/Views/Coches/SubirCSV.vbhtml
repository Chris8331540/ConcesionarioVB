@Code
    ViewData("Title") = "SubirCSV"
    Dim mensaje As String = Convert.ToString(ViewBag.Mensaje)
End Code


<div class="container">
    <h2>Sube la información de tu fichero csv a la base de datos</h2>
    <form action="/Coches/SubirCSVPost" method="post" enctype="multipart/form-data">
        <div class="row mb-3">
            <div class="col-md-4 d-inline-block">
                <button type="button" class="btn btn-outline-dark mb-2" onclick="elegirCSV()">Elegir CSV</button>
                <div id="ficheroSeleccionado">

                </div>
                <input id="ficheroCSV" type="file" accept=".csv" name="archivoCSV" style="display:none" />
            </div>
        </div>
        <div class="row">
            <div class="col-4">
                <svg style="max-width:100%; height:auto" xmlns="http://www.w3.org/2000/svg" version="1.1" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:svgjs="http://svgjs.com/svgjs" width="256" height="256" x="0" y="0" viewBox="0 0 267 267" style="enable-background:new 0 0 512 512" xml:space="preserve" class=""><g><path fill="#d8dfe3" d="M50 154.167c56.944 9.876 113.889 9.544 170.833 0V75c0-.902-.292-1.779-.833-2.5l-37.5-50a4.168 4.168 0 0 0-3.333-1.667H62.5a12.501 12.501 0 0 0-12.5 12.5v95.834c0 6.188-1.451 11.433-1.451 15.614 0 5.78 1.451 9.386 1.451 9.386z" data-original="#d8dfe3" class=""></path><path fill="#1fb35b" d="M25 143.365v89.968a12.501 12.501 0 0 0 12.5 12.5h191.667a12.503 12.503 0 0 0 12.5-12.5v-66.666a12.501 12.501 0 0 0-12.5-12.5h-187.5c-5.316 0-16.667-10.802-16.667-10.802z" data-original="#1fb35b" class=""></path><path fill="#198043" d="M37.5 154.167c-3.804 0-6.581-1.543-8.625-3.443-1.923-1.788-3.875-4.939-3.875-9.057 0-2.643 1.317-6.495 3.661-8.839s5.524-3.661 8.839-3.661H50v25H37.5z" data-original="#198043" class=""></path><path fill="#afbdc7" d="M179.167 20.833V62.5a12.501 12.501 0 0 0 12.5 12.5h29.166c0-.902-.292-1.779-.833-2.5l-37.5-50a4.168 4.168 0 0 0-3.333-1.667z" data-original="#afbdc7"></path><path fill="#1fb35b" d="M87.5 79.167h54.167c2.299 0 4.166-1.867 4.166-4.167s-1.867-4.167-4.166-4.167H87.5c-2.3 0-4.167 1.867-4.167 4.167s1.867 4.167 4.167 4.167zM87.5 104.167h95.833c2.3 0 4.167-1.867 4.167-4.167s-1.867-4.167-4.167-4.167H87.5c-2.3 0-4.167 1.867-4.167 4.167s1.867 4.167 4.167 4.167zM87.5 129.167h95.833c2.3 0 4.167-1.867 4.167-4.167s-1.867-4.167-4.167-4.167H87.5c-2.3 0-4.167 1.867-4.167 4.167s1.867 4.167 4.167 4.167z" data-original="#1fb35b" class=""></path><g fill="#d8dfe3"><path d="m156.548 180.714 16.667 41.667a4.165 4.165 0 0 0 7.737 0l16.667-41.667a4.168 4.168 0 0 0-2.322-5.416 4.169 4.169 0 0 0-5.416 2.321l-12.798 31.995-12.798-31.995c-.854-2.135-3.281-3.175-5.416-2.321s-3.175 3.281-2.321 5.416zM91.963 175h-2.381c-11.506 0-20.833 9.327-20.833 20.833v8.334c0 11.506 9.327 20.833 20.833 20.833h2.381a18.992 18.992 0 0 0 17.273-11.096c.431-.942.516-1.12.793-1.734a4.124 4.124 0 0 0-1.79-5.419c-2.612-1.313-4.982.142-5.789 1.954-.245.55-.793 1.735-.793 1.735a10.66 10.66 0 0 1-9.694 6.227h-2.381c-6.904 0-12.5-5.597-12.5-12.5v-8.334c0-6.903 5.596-12.5 12.5-12.5h2.381a10.66 10.66 0 0 1 9.694 6.227s.508 1.138.793 1.735c1.252 2.624 4.212 2.997 6.084 1.781 1.315-.856 2.557-2.923 1.495-5.246l-.793-1.734A18.992 18.992 0 0 0 91.963 175zM116.667 210.443v-.001 2.066A12.493 12.493 0 0 0 129.158 225h9.392a12.491 12.491 0 0 0 12.492-12.492v-1.658c0-5.111-3.112-9.707-7.858-11.606l-15.151-6.06a4.825 4.825 0 0 1-3.033-4.48V187.5a4.167 4.167 0 0 1 4.166-4.167h9.376a4.164 4.164 0 0 1 4.166 4.167v2.058c0 1.176.52 2.24 1.043 2.78a4.192 4.192 0 0 0 3.124 1.412c2.028 0 4.167-1.566 4.167-4.192V187.5a12.501 12.501 0 0 0-12.5-12.5h-9.375a12.5 12.5 0 0 0-12.5 12.5v1.204c0 5.38 3.276 10.219 8.271 12.217l15.151 6.061a4.165 4.165 0 0 1 2.619 3.868v1.658a4.16 4.16 0 0 1-4.158 4.159h-9.392a4.157 4.157 0 0 1-4.158-4.158v-2.067c0-2.748-2.24-4.194-4.094-4.194-1.758 0-4.239 1.363-4.239 4.169z" fill="#d8dfe3" data-original="#d8dfe3" class=""></path></g></g></svg>
            </div>
            <div class="col-4">
                <svg style="max-width:100%; height:auto" xmlns="http://www.w3.org/2000/svg" version="1.1" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:svgjs="http://svgjs.com/svgjs" width="256" height="256" x="0" y="0" viewBox="0 0 480 480" style="enable-background:new 0 0 512 512" xml:space="preserve" class=""><g><path d="m461.248 194.736-128-128c-24.928-24.96-65.568-24.96-90.496 0C230.656 78.8 224 94.896 224 111.984s6.656 33.184 18.752 45.248l82.752 82.752-82.752 82.752C230.656 334.832 224 350.896 224 367.984s6.656 33.152 18.752 45.248c12.096 12.096 28.16 18.752 45.248 18.752s33.152-6.656 45.248-18.752l128-128C473.344 273.168 480 257.072 480 239.984s-6.656-33.184-18.752-45.248zm-22.624 67.872-128 128c-12.128 12.096-33.12 12.096-45.248 0-12.48-12.48-12.48-32.768 0-45.248l105.376-105.376-105.376-105.376c-6.048-6.048-9.376-14.08-9.376-22.624s3.328-16.576 9.376-22.624A31.912 31.912 0 0 1 288 79.984a32.013 32.013 0 0 1 22.624 9.344l128 128c6.048 6.08 9.376 14.112 9.376 22.656s-3.328 16.576-9.376 22.624z" fill="#000000" data-original="#000000" class=""></path><path d="m237.248 194.736-128-128c-24.928-24.96-65.568-24.96-90.496 0C6.656 78.8 0 94.896 0 111.984s6.656 33.184 18.752 45.248l82.752 82.752-82.752 82.752C6.656 334.832 0 350.896 0 367.984s6.656 33.152 18.752 45.248c12.096 12.096 28.16 18.752 45.248 18.752s33.152-6.656 45.248-18.752l128-128C249.344 273.168 256 257.072 256 239.984s-6.656-33.184-18.752-45.248zm-22.624 67.872-128 128c-12.128 12.096-33.12 12.096-45.248 0-12.48-12.48-12.48-32.768 0-45.248l105.376-105.376L41.376 134.608C35.328 128.56 32 120.528 32 111.984s3.328-16.576 9.376-22.624c6.24-6.24 14.432-9.376 22.624-9.376s16.384 3.136 22.624 9.344l128 128c6.048 6.08 9.376 14.112 9.376 22.656s-3.328 16.576-9.376 22.624z" fill="#000000" data-original="#000000" class=""></path></g></svg>
            </div>
            <div class="col-4">
                <svg style="max-width:100%; height:auto" xmlns="http://www.w3.org/2000/svg" version="1.1" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:svgjs="http://svgjs.com/svgjs" width="256" height="256" x="0" y="0" viewBox="0 0 512 512" style="enable-background:new 0 0 512 512" xml:space="preserve" class=""><g><g fill-rule="evenodd" clip-rule="evenodd"><path fill="#e5252a" d="M168.584 0h173.398l153.062 153.091v293.98c0 35.698-29.202 64.929-64.929 64.929h-261.53c-35.698 0-64.9-29.231-64.9-64.929V64.929C103.685 29.231 132.887 0 168.584 0z" data-original="#e5252a"></path><path fill="#b71d21" d="m341.982 0 153.062 153.091H358.485c-9.1 0-16.503-7.432-16.503-16.532zM31.206 218.02h352.618c7.842 0 14.25 6.408 14.25 14.25v129.36c0 7.842-6.408 14.25-14.25 14.25H31.206c-7.842 0-14.25-6.408-14.25-14.25V232.27c0-7.842 6.409-14.25 14.25-14.25z" data-original="#b71d21"></path></g><path fill="#ffffff" d="M117.759 244.399H91.161a8.266 8.266 0 0 0-8.266 8.266v88.542a8.266 8.266 0 0 0 16.532 0v-25.94h18.331c19.224 0 34.864-15.64 34.864-34.863v-1.141c.001-19.224-15.639-34.864-34.863-34.864zm18.332 36.004c0 10.108-8.224 18.331-18.332 18.331H99.427V260.93h18.331c10.108 0 18.332 8.224 18.332 18.331v1.142zm70.62-36.004h-26.597a8.266 8.266 0 0 0-8.266 8.266v88.542a8.266 8.266 0 0 0 8.266 8.266h26.597c19.224 0 34.864-15.64 34.864-34.863v-35.347c0-19.224-15.64-34.864-34.864-34.864zm18.332 70.21c0 10.108-8.224 18.331-18.332 18.331H188.38v-72.01h18.331c10.108 0 18.332 8.224 18.332 18.331zm53.897-53.678v22.882h38.317a8.266 8.266 0 0 1 0 16.532H278.94v40.862a8.266 8.266 0 0 1-16.532 0v-88.542a8.266 8.266 0 0 1 8.266-8.266h53.195a8.266 8.266 0 0 1 0 16.532z" data-original="#ffffff"></path></g></svg>
            </div>
        </div>
        <div class="row mb-3">
            <div class="col-md-2">
                <button type="submit" class="btn btn-outline-dark">Subir csv</button>
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
    window.onload = detectarMensaje();

    function elegirCSV() {
        let input = document.getElementById("ficheroCSV");
        input.addEventListener("change", function () {
            const ficheroSeleccionado = input.files[0];
            if (ficheroSeleccionado) {
                let nombreFichero = ficheroSeleccionado.name;
                if (nombreFichero) {
                    let divNombre = document.getElementById("ficheroSeleccionado");
                    divNombre.textContent = "CSV seleccionado: " + nombreFichero;
                }
            }
        });
        input.click();
    }
</script>