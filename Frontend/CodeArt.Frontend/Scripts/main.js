$(function() {
    //
    var technologyButton = $("#technology-button");
    var technologyInput = $("#technology-input");
    var technologyMultilineSelect = $("#technology-multiline-select");
    
    technologyButton.on("click", function () {
        var technology = technologyInput.val();
        var option = "<option>" + technology + "</option>";
        if (technology.length > 0) {
            technologyMultilineSelect.append(option);
            technologyInput.val("");
        }

        return false;
    });
})