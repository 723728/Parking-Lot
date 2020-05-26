var i = 0;
if (true) {
    //confirm("Permitir Ubicación");
    //confirm("Permitir Notificaciones");
    function AskForWebNotificationPermissions() {
        if (Notification) {
            Notification.requestPermission();
        }
    }
    x = 0;
}


$('button').on('click', function () {
    if (i == 0) {
        if (this.id == 'b1') {
            $.ajax({
                url: 'https://localhost:44372/Usuario/Index',
                type: 'get'
            }).done(function (response) {
                $("div#Contenido").html(response)
            });
            i = 1;
        }
        if (this.id == 'b2') {
            $.ajax({
                url: 'https://localhost:44372/Tarjeta/Index',
                type: 'get'
            }).done(function (response) {
                $("div#Contenido").html(response)
            });
            i = 1;
        }
        if (this.id == 'b3') {
            $.ajax({
                url: 'https://localhost:44372/Aparcamientos/Index',
                type: 'get'
            }).done(function (response) {
                $("div#Contenido").html(response)
            });
            i = 1;
        }
        if (this.id == 'b4') {
            $.ajax({
                url: 'https://localhost:44372/Tarjeta/Index',
                type: 'get'
            }).done(function (response) {
                $("div#Contenido").html(response)
            });
            i = 1;
        }
        if (this.id == 'b5') {
            $.ajax({
                url: 'https://localhost:44372/Vehiculos/Index',
                type: 'get'
            }).done(function (response) {
                $("div#Contenido").html(response)
            });
            i = 1;
        }
        if (this.id == 'b6') {
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
