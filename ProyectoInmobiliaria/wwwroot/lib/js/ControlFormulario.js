// Ejemplo de JavaScript de inicio para deshabilitar los envíos de formularios si hay campos no válidos
(function() {
        'use strict';
    window.addEventListener('load', function() {
    // Obtenga todos los formularios a los que queremos aplicar estilos personalizados de validación Bootstrap
    var forms = document.getElementsByClassName('needs-validation');
    // Pase sobre ellos y evite la sumisión
    var validation = Array.prototype.filter.call(forms, function(form) {
        form.addEventListener('submit', function (event) {
            if (form.checkValidity() === false) {
                event.preventDefault();
                event.stopPropagation();
            }
            form.classList.add('was-validated');
        }, false);
    });
    }, false);
})();
