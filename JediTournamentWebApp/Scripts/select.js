$(document).ready(function () {

    // Variables
    var selectAllInput = $(".select-column input");
    var inputList = $(".item td input");
    var isSelected = false;
    var selectedList;

    // head checkbox
    selectAllInput.change(function () {
        isSelected = !isSelected;
        for (i = 0; i < inputList.length; ++i) {
            inputList[i].checked = isSelected;
        }
    });

    // Only table body checkbox
    $("tbody tr td input").change(function () {
        if (isSelected) {
            selectAllInput[0].checked = false;
            isSelected = false;
        }
    });
});