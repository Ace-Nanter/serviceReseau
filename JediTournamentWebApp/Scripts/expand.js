$(document).ready(function () {

    var list = $(".extendables");

    list.click(function () {
        $(this).children(".caracteristiques").slideToggle(1000, null);
    });

    // TODO : a améliorer
});