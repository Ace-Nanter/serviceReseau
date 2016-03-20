$(document).ready(function () {

    
    /* ----- Remove checks ----- */

    // Variables
    var selectAllInputs = $(".select-column input");
    var inputList = $(".item td input");
    var isSelected = false;
    var selectedList;
    var CaracIndex = 0;

    // head checkbox
    selectAllInputs.change(function () {
        isSelected = !isSelected;
        for (i = 0; i < inputList.length; ++i) {
            inputList[i].checked = isSelected;
        }
    });

    // Only table body checkbox
    $("tbody tr td input").change(function () {
        if (isSelected) {
            selectAllInputs[0].checked = false;
            isSelected = false;
        }
    });

    /* ------------------------------*/

    /* ----- Extends list -----------*/

    var list = $(".extendables label");

    list.click(function () {
        $(this).parent().children(".caracteristiques").slideToggle("slow");
        
    });
    /* ------------------------------*/

    /* -------- Choose faction ------*/
    $("#factionChooser :last-child").hide();
    var faction = false;

    $("#factionChooser").click(function () {
        $("#factionChooser :first-child").toggle();
        $("#factionChooser :last-child").toggle();
        
        faction = !faction;
        $('#factionChecker').attr('checked', faction);
    });


    /* -------- Add carac -----------*/

    $("#AddCaracButton").click(function (e) {
        
        e.preventDefault();

        $.ajax({
            cache: false,
            type: "GET",
            url: "/Jedi/AddCarac",
            data: {
                Index: CaracIndex
            },
            success: function (data) {
                $("#CaracsContainer").append(data);
            },
            error: function (xhr, ajaxOptions, thrownError) {
                $("#CaracsContainer").append('<div class="alert alert-danger" >Erreur !<div>');
            }
        });

        CaracIndex++;
    });
});