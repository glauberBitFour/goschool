//Menu Side bar
        $("#menu-toggle").click(function (e) {
            e.preventDefault();
            $("#wrapper").toggleClass("toggled");
        });


//carregar menu horario 
function carregar() {
    $("#MenuDadosHorarioAjax").load("@Url.Action()");
}


//menu navBar
        function myFunction(x) {
            x.classList.toggle("change");
        }


        $(document).ready(function() {
            $("#testeButton").click(function() {
                $("#body").load("DadosParaGerarRelatorios/Index");
            })

})