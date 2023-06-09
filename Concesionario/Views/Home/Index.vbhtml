@Code
    ViewData("Title") = "Home Page"
End Code

<main>
    <section class="row" aria-labelledby="aspnetTitle">
        <h1 id="title">Concesionario</h1>
    </section>

    <div class="row">
        <section class="col-md-4" aria-labelledby="gettingStartedTitle">
            <h2 id="gettingStartedTitle">Sube tu CSV</h2>
            <p>
                Sube tu CSV con los datos de tus coches.
            </p>
            <p><a class="btn btn-outline-dark" href="/Coches/SubirCSV">Subir CSV</a></p>
        </section>
        <section class="col-md-4" aria-labelledby="librariesTitle">
            <h2 id="librariesTitle">Realiza operaciones CRUD</h2>
            <p>Crea, actualiza y elimina los registros de tu BD Concesionario.</p>
            <p><a class="btn btn-outline-dark" href="/Coches/Index">CRUD</a></p>
        </section>
        <section class="col-md-4" aria-labelledby="hostingTitle">
            <h2 id="hostingTitle">Descarga un informe PDF de cada coche.</h2>
            <p>Descarga y visualiza los datos de cada registro de tu BD.</p>
            <p><a class="btn btn-outline-dark" href="/Coches/Index">Ver coches</a></p>
        </section>
    </div>
</main>
