var setContains = function (e) {
    $("#autocomplete").data("kendoAutoComplete").setOptions({ filter: "contains" });

};

var setStart = function (e) {
    $("#autocomplete").data("kendoAutoComplete").setOptions({ filter: "startswith" });

};


$("#autocomplete").keyup(function (e) {
    setStart()
    setTimeout(function () {
        if ($('.k-list').children().length == 0) {
            setContains();

            $("#autocomplete").data("kendoAutoComplete").search($('#autocomplete').val());
        }
    }, 500);

});

$("#autocomplete").kendoAutoComplete({
    filter: "startswith",
    dataSource: {
        data: ["Orange", "Grapes", "Apple", "Freet"]
    },


});