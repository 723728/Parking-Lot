var i = 0;
$('button').on('click', function () {
    if (i == 0) {
        if (this.id == 'Aparcamiento') {
            $.ajax({
                url: 'https://localhost:44372/Aparcamientos/Index',
                type: 'get'
            }).done(function (response) {
                $("div#Contenido").html(response)
            });
            i = 1;
        }
        if (this.id == 'Pago') {
            $.ajax({
                url: 'https://localhost:44372/Tarjeta/Index',
                type: 'get'
            }).done(function (response) {
                $("div#Contenido").html(response)
            });
            i = 1;
        }
        if (this.id == 'Vehiculo') {
            $.ajax({
                url: 'https://localhost:44372/Vehiculos/Index',
                type: 'get'
            }).done(function (response) {
                $("div#Contenido").html(response)
            });
            i = 1;
        }
        if (this.id == 'Historial') {
            $.ajax({
                url: 'https://localhost:44372/Historial/Index',
                type: 'get'
            }).done(function (response) {
                $("div#Contenido").html(response)
            });
            i = 1;
        }
    } else {
            $("div#Contenido").empty();
        i = 0;
    }

});
