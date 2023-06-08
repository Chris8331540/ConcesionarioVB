@ModelType IEnumerable(Of Concesionario.Coche)
@Code
    ViewData("Title") = "Crud"
End Code

<h2>CRUD</h2>


<ul class="nav nav-tabs" id="myTab" role="tablist">
    <li class="nav-item" role="presentation">
        <button class="nav-link active" id="home-tab" data-bs-toggle="tab" data-bs-target="#visualizar" type="button" role="tab" aria-controls="visualizar" aria-selected="true">Visualizar</button>
    </li>
    <li class="nav-item" role="presentation">
        <button class="nav-link active" id="home-tab" data-bs-toggle="tab" data-bs-target="#crear" type="button" role="tab" aria-controls="crear" aria-selected="true">Crear</button>
    </li>
    <li class="nav-item" role="presentation">
        <button class="nav-link" id="profile-tab" data-bs-toggle="tab" data-bs-target="#editar" type="button" role="tab" aria-controls="editar" aria-selected="false">Editar</button>
    </li>
    <li class="nav-item" role="presentation">
        <button class="nav-link" id="contact-tab" data-bs-toggle="tab" data-bs-target="#eliminar" type="button" role="tab" aria-controls="eliminar" aria-selected="false">Eliminar</button>
    </li>
</ul>
<div class="tab-content" id="myTabContent">
    <div class="tab-pane fade show active" id="visualizar" role="tabpanel" aria-labelledby="visualizar-tab">
        @Html.Partial("Index")
    </div>
    <div class="tab-pane fade" id="crear" role="tabpanel" aria-labelledby="crear-tab">
        @Html.Partial("Create")
    </div>
    <div class="tab-pane fade" id="editar" role="tabpanel" aria-labelledby="editar-tab">
        @Html.Partial("Edit")
    </div>
    <div class="tab-pane fade" id="eliminar" role="tabpanel" aria-labelledby="eliminar-tab">
        @Html.Partial("Delete")
    </div>
</div>