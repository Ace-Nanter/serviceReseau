﻿$(document).ready(function () {

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

    /* ----- Extends caracs list ----*/

    var list = $(".extendables label");

    list.click(function () {
        $(this).parent().children(".caracteristiques").slideToggle("slow");
        
    });
    /*--------------------------------*/

    /* ----- Extends matchs ----------*/
    $(".match-extendable label").click(function () {
        var area = $(this).parent().parent(".item");
        area.toggle();

        $.ajax({
            cache: false,
            type: "GET",
            url: $(location).attr('pathname') + "/Details",
            data: {
                id: area.find("input").val()
            },
            success: function (data) {
                area.html(data);
                area.slideToggle("slow");
            },
            error: function () {
                alert("Error !");
            }
        })
    });
    /*--------------------------------*/
    /* -------- Faction manager ------*/
    
    function factionManager() {
        // Get first faction
        var faction;

        if ($('#factionChecker').val() == "True") {
            faction = true;
            $("#factionChooser :first-child").hide();
        }
        else {
            faction = false;
            $("#factionChooser :last-child").hide();
        }

        $("#factionChooser").click(function () {
            $("#factionChooser :first-child").toggle();
            $("#factionChooser :last-child").toggle();
        
            faction = !faction;
            $('#factionChecker').attr('checked', faction);
            $('#factionChecker').val(faction);
        });
    }

    factionManager();

    /* -------- Add and remove carac -----------*/
    function AddCarac() {
        $.ajax({
            cache: false,
            type: "GET",
            url: $(location).attr('pathname') + '/AddCarac',
            success: function (data) {
                $("#CaracsContainer").append(data);
            },
            error: function (xhr, ajaxOptions, thrownError) {
                $("#CaracsContainer").append('<div class="alert alert-danger" >Erreur !<div>');
            }
        });

        CaracIndex++;
    }

    function RemoveCarac() {
        $("#CaracsContainer tr:last-child").remove();
    }

    $("#AddCaracButton").click(AddCarac);

    $("#RemoveCaracButton").click(RemoveCarac);

    /*-------------------------------*/

    /* ------------ Edit ----------- */
    $(".edit-column").click(function (e) {
        e.preventDefault();

        var area = $(this).parent(".item");
        $.ajax({
            cache: false,
            type: "GET",
            url: $(location).attr('pathname') + "/Edit",
            data: {
                id: $(this).parent(".item").find("input").val()
            },
            success: function (data) {
                area.html(data);
                changeForm();
                $(".edit-column").off();
                factionManager();

                // Activation des fonctionnalités
                $("#AddCaracButton").click(AddCarac);
                $("#RemoveCaracButton").click(RemoveCarac);
            },
            error: function () {
                alert("Error !");
            }
        })
    });

    function changeForm() {

        // Changement formulaire
        var form = $('form[name="removeForm"]');
        form.attr('name', 'editForm');
        form.attr('action', $(location).attr('pathname') + '/Edit');

        // Changement bouton
        $("#confirmButton").text("Edit");
        $("#confirmButton").attr('href', 'javascript:(function(){document.editForm.submit();return void(0);})()');
    }

    /*-------------------------------*/
    /* ----------- Launch ---------- */
    $(".launch-column").click(function () {

        var area = $(this).parent(".item");
        $.ajax({
            cache: false,
            type: "POST",
            url: $(location).attr('pathname') + "/Launch",
            data: {
                idTournoi: $(this).parent(".item").find("input").val()
            },
            success: function () {
                alert("Tournament launched !");
            },
            error: function () {
                alert("Error !");
            }
        })
    });
    /*-------------------------------*/
});